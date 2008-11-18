using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;

namespace LogMonitor
{
	public partial class WinMain : Form
	{
		private String logFileName = "";
		private FileInfo logFileInfo;
		private FileStream logFileStream;
		private StreamReader logFileReader;
		private long bufferChars = 5000;

		/*[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]*/
		public WinMain(string[] args)
		{
			InitializeComponent();

			// if a file was passed in, we want to open it but 
			// we have to wait until the form is fully loaded
			if (args.Length > 0)
			{
				logFileName = args[0].ToString();
			}
		}

		/// <summary>
		/// Once the form is fully loaded, check for command line 
		/// parameters and load the file if necessary
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WinMain_Load(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			timer1.Tick += new System.EventHandler(this.ScrollToBottom);
			timer1.Interval = 200;

			if (logFileName != "")
			{
				StartMonitoring();
			}
		}

		protected override void OnResize(EventArgs e)
		{
			tbLog.Width = this.Width - 15;
			tbLog.Height = this.Height - 65;
		}

		/// <summary>
		/// Opens a dialog to select a new file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			//Stream myStream = null;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "All Files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				logFileName = openFileDialog1.FileName;
				StartMonitoring();
			}

		}

		/// <summary>
		/// Starts watching the selected file for changes
		/// </summary>
		private void StartMonitoring()
		{
			logFileInfo = new FileInfo(logFileName);
			btnSelectFile.Text = "Monitoring: " + logFileName;

			fileSystemWatcher1.Path = logFileInfo.DirectoryName;
			fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;
			fileSystemWatcher1.Filter = logFileInfo.Name;
			fileSystemWatcher1.Changed += new FileSystemEventHandler(this.OnChanged);

			UpdateDisplay();

			fileSystemWatcher1.EnableRaisingEvents = true;
			btnPauseContinue.Text = "Pause";

		}

		/// <summary>
		/// Fired by the filesystem listener when the logfile has changed
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void OnChanged(object source, FileSystemEventArgs e)
		{
			UpdateDisplay();
		}

		/// <summary>
		/// Stops watching for changes
		/// </summary>
		private void StopMonitoring()
		{
			fileSystemWatcher1.EnableRaisingEvents = false;
			btnPauseContinue.Text = "Continue";
		}

		/// <summary>
		/// Fired when the user clicks the pause/continue button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPauseContinue_Click(object sender, EventArgs e)
		{
			if (logFileName != "")
			{
				if (btnPauseContinue.Text == "Continue")
				{
					StartMonitoring();
				}
				else
				{
					StopMonitoring();
				}
			}
		}

		/// <summary>
		/// Updates the textarea with the tail of the logfile and
		/// scrolls to the bottom
		/// </summary>
		private void UpdateDisplay()
		{
			try
			{
				logFileStream = new FileStream(
						logFileInfo.FullName,
						FileMode.Open,
						FileAccess.Read,
						FileShare.ReadWrite);
			}
			catch (Exception ex)
			{
				tbLog.Text = "ERROR: Unable to open file: " + ex.Message;
			} 

			if (logFileStream != null)
			{
				if (logFileStream.Length > bufferChars) logFileStream.Position = logFileStream.Length - bufferChars;
				logFileReader = new StreamReader(logFileStream);
				tbLog.Text = logFileReader.ReadToEnd();
				logFileReader.Close();
				logFileStream.Close();
			}
			else
			{
				tbLog.Text = "ERROR: The file stream returned null";
			}
			
		}

		/// <summary>
		/// Handles changing of the character buffer textbox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbBuffer_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bufferChars = long.Parse(tbBuffer.Text);
			}
			catch (Exception)
			{
				tbBuffer.Text = bufferChars.ToString();
			}
		}

		/// <summary>
		/// When the main text area changes, scroll to the bottom
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbLog_TextChanged(object sender, EventArgs e)
		{

			timer1.Enabled = true;
		}

		private void ScrollToBottom(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			tbLog.SelectionStart = tbLog.Text.Length;
			tbLog.SelectionLength = 0;
			tbLog.ScrollToCaret();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (logFileName != "")
			{
				System.Diagnostics.Process.Start("notepad.exe", logFileName);
			}
		}

		private void btnErase_Click(object sender, EventArgs e)
		{
			if (logFileName != "" && MessageBox.Show("Eraase the contents of the current file?", "Confirm Erase", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				FileStream fs = new FileStream(
						logFileInfo.FullName,
						FileMode.Open,
						FileAccess.Write,
						FileShare.ReadWrite);

				fs.SetLength(0);
				fs.Close();
			}

		}

	}


}
