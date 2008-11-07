using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace LogFilePurger
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.  If arguments are provided, then
		/// purge the files and move on.  If not, then show the UI
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args != null && args.Length > 0)
			{
				try
				{
					DirectoryInfo dir = new DirectoryInfo(args[0]);
					int days = (args.Length > 1) ? int.Parse(args[1]) : 30;

					PurgeFiles(dir, days);
				}
				catch (Exception ex)
				{
					// tell anybody listening that we exited with an error
					Environment.ExitCode = 1;

					FileInfo errLog = new FileInfo(GetCurDir() + "\\LFP_error.log");
					FileStream fs = errLog.OpenWrite();
					StreamWriter sw = new StreamWriter(fs);
					sw.WriteLine(ex.ToString());
					sw.Close();
					fs.Close();

				}

				Application.Exit();
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new WinMain(args));

			}
		}

		static string GetCurDir()
		{
			return Path.GetDirectoryName(Application.ExecutablePath);
			// return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
		}

		/// <summary>
		/// Purge all files older than the specified number of days from the given directory
		/// </summary>
		/// <param name="dir">directory to purge</param>
		/// <param name="days">number of days</param>
		public static void PurgeFiles(DirectoryInfo dir, int days)
		{
			PurgeFiles(dir, days, null);
		}

		/// <summary>
		/// Purges all files older than the specified number of days from the given directory
		/// and providing user feedback
		/// </summary>
		/// <param name="dir">directory to purge</param>
		/// <param name="days">number of days</param>
		/// <param name="callback">callback function for providing user feedback</param>
		public static void PurgeFiles(DirectoryInfo dir, int days, WinMain callback)
		{

			FileInfo[] files = dir.GetFiles();
			DateTime cuttoff = DateTime.Now.Subtract(
				new TimeSpan(days, 0, 0, 0)
				);

			if (callback != null) callback.ClearOutput("Removing all files older than " + cuttoff.ToShortDateString());

			foreach (FileInfo fileInfo in files)
			{
				if (fileInfo.LastWriteTime.CompareTo(cuttoff) < 0)
				{
					if (callback != null) callback.Output(fileInfo.FullName + " " + fileInfo.LastWriteTime.ToShortDateString() + " is old.  I shall delete thee.");
					fileInfo.Delete();
				}
				else
				{
					if (callback != null) callback.Output(fileInfo.FullName + " " + fileInfo.LastWriteTime.ToShortDateString() + " is not old.");
				}
			}
		}

	}
}
