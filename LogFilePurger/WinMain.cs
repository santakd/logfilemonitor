using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LogFilePurger
{
	public partial class WinMain : Form
	{
		private DirectoryInfo selectedDirectoryInfo;

		public WinMain(string[] args)
		{
			InitializeComponent();
		}

		private void WinMain_Load(object sender, EventArgs e)
		{

		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbDialog = new FolderBrowserDialog();
			fbDialog.RootFolder = Environment.SpecialFolder.MyComputer;

			if (fbDialog.ShowDialog() == DialogResult.OK)
			{
				this.SelectDirectory(fbDialog.SelectedPath);
			}
		}

		private void SelectDirectory(string path)
		{
			selectedDirectoryInfo = new DirectoryInfo(path);
			btnSelect.Text = selectedDirectoryInfo.FullName;
			this.ClearOutput(selectedDirectoryInfo.FullName + " has been selected.  Click Purge to delete old file inside this directory.");
		}

		private void PurgeFiles()
		{
			if (selectedDirectoryInfo == null)
			{
				if (this.Visible)
				{
					MessageBox.Show("You didn't select a directory.  This app wipes files.  Pay attentions clownshoes!", "User Error");
				}
				return;
			}

			try
			{
				Program.PurgeFiles(selectedDirectoryInfo, int.Parse(txtDays.Text), this);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception Occured");
			}
		}

		private void btnPurge_Click(object sender, EventArgs e)
		{
			this.PurgeFiles();
		}

		public void Output(String msg)
		{
			txtOutput.Text += msg + "\r\n";
		}

		public void ClearOutput(String msg)
		{
			txtOutput.Text = msg + "\r\n";
		}

		private void txtDays_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int.Parse(txtDays.Text);
			}
			catch (Exception)
			{
				txtDays.Text = "30";
			}
		}

	}
}
