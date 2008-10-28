namespace LogMonitor
{
	partial class WinMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
			this.tbLog = new System.Windows.Forms.TextBox();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnPauseContinue = new System.Windows.Forms.Button();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.tbBuffer = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbLog
			// 
			this.tbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.tbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tbLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLog.ForeColor = System.Drawing.Color.LimeGreen;
			this.tbLog.Location = new System.Drawing.Point(12, 12);
			this.tbLog.Multiline = true;
			this.tbLog.Name = "tbLog";
			this.tbLog.ReadOnly = true;
			this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbLog.Size = new System.Drawing.Size(732, 380);
			this.tbLog.TabIndex = 2;
			this.tbLog.Text = "Select a file to begin monitoring...";
			this.tbLog.WordWrap = false;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnPauseContinue
			// 
			this.btnPauseContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPauseContinue.Location = new System.Drawing.Point(12, 418);
			this.btnPauseContinue.Name = "btnPauseContinue";
			this.btnPauseContinue.Size = new System.Drawing.Size(126, 23);
			this.btnPauseContinue.TabIndex = 1;
			this.btnPauseContinue.Text = "Pause";
			this.btnPauseContinue.UseVisualStyleBackColor = true;
			this.btnPauseContinue.Click += new System.EventHandler(this.btnPauseContinue_Click);
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(196, 418);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(548, 23);
			this.btnSelectFile.TabIndex = 0;
			this.btnSelectFile.Text = "Selected File: NONE...";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// tbBuffer
			// 
			this.tbBuffer.Location = new System.Drawing.Point(145, 420);
			this.tbBuffer.Name = "tbBuffer";
			this.tbBuffer.Size = new System.Drawing.Size(45, 20);
			this.tbBuffer.TabIndex = 3;
			this.tbBuffer.Text = "5000";
			this.tbBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbBuffer.TextChanged += new System.EventHandler(this.tbBuffer_TextChanged);
			// 
			// WinMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 453);
			this.Controls.Add(this.tbBuffer);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.btnPauseContinue);
			this.Controls.Add(this.tbLog);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WinMain";
			this.Text = "Log Monitor";
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbLog;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Button btnPauseContinue;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox tbBuffer;
	}
}

