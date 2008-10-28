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

		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public WinMain()
		{
			InitializeComponent();
		}

		protected override void OnResize(EventArgs e)
		{
			tbLog.Width = this.Width - 15;
			tbLog.Height = this.Height - 65;
		}

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
				logFileInfo = new FileInfo(logFileName);
				btnSelectFile.Text = "Selected File: " + logFileName;

				UpdateDisplay();
				StartMonitoring();

			}

		}

		/// <summary>
		/// Starts watching the selected file for changes
		/// </summary>
		private void StartMonitoring()
		{
			fileSystemWatcher1.Path = logFileInfo.DirectoryName;
			fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;
			fileSystemWatcher1.Filter = logFileInfo.Name;
			fileSystemWatcher1.Changed += new FileSystemEventHandler(this.OnChanged);

			fileSystemWatcher1.EnableRaisingEvents = true;
			btnPauseContinue.Text = "Pause";

		}

		private void StopMonitoring()
		{
			fileSystemWatcher1.EnableRaisingEvents = false;
			btnPauseContinue.Text = "Continue";
		}

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
				tbLog.Text = "Error: Could not read file from disk. Original error: " + ex.Message;
			} 

			if (logFileStream != null)
			{
				if (logFileStream.Length > bufferChars) logFileStream.Position = logFileStream.Length - bufferChars;
				logFileReader = new StreamReader(logFileStream);
				tbLog.Text = logFileReader.ReadToEnd();
				logFileReader.Close();
				logFileStream.Close();

				// scroll to the bottom
				tbLog.SelectionStart = tbLog.Text.Length;
				tbLog.ScrollToCaret();

			}
			else
			{
				tbLog.Text = "Unable to read stream";
			}
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void OnChanged(object source, FileSystemEventArgs e)
		{
			UpdateDisplay();
		}

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

	}


}
