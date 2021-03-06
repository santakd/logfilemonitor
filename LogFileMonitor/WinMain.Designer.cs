﻿namespace LogMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            this.tbLog = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblBuffer = new System.Windows.Forms.ToolStripLabel();
            this.tbBuffer = new System.Windows.Forms.ToolStripTextBox();
            this.btnPauseContinue = new System.Windows.Forms.ToolStripButton();
            this.btnErase = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnSelectFile = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.forcedTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnForced = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbLog.Location = new System.Drawing.Point(0, 28);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(756, 413);
            this.tbLog.TabIndex = 2;
            this.tbLog.Text = "Select a file to begin monitoring...";
            this.tbLog.WordWrap = false;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
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
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBuffer,
            this.tbBuffer,
            this.btnPauseContinue,
            this.btnErase,
            this.btnEdit,
            this.toolStripSeparator1,
            this.btnSelectFile,
            this.btnForced});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblBuffer
            // 
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(37, 22);
            this.lblBuffer.Text = "Buffer";
            // 
            // tbBuffer
            // 
            this.tbBuffer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuffer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tbBuffer.Name = "tbBuffer";
            this.tbBuffer.Size = new System.Drawing.Size(50, 24);
            this.tbBuffer.Text = "25000";
            this.tbBuffer.TextChanged += new System.EventHandler(this.tbBuffer_TextChanged);
            // 
            // btnPauseContinue
            // 
            this.btnPauseContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnPauseContinue.Image")));
            this.btnPauseContinue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPauseContinue.Name = "btnPauseContinue";
            this.btnPauseContinue.Size = new System.Drawing.Size(56, 22);
            this.btnPauseContinue.Text = "Pause";
            this.btnPauseContinue.Click += new System.EventHandler(this.btnPauseContinue_Click);
            // 
            // btnErase
            // 
            this.btnErase.Image = ((System.Drawing.Image)(resources.GetObject("btnErase.Image")));
            this.btnErase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(54, 22);
            this.btnErase.Text = "Erase";
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 22);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFile.Image")));
            this.btnSelectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(87, 22);
            this.btnSelectFile.Text = "Select File...";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // forcedTimer
            // 
            this.forcedTimer.Tick += new System.EventHandler(this.forcedTimer_Tick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnForced
            // 
            this.btnForced.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnForced.Image = ((System.Drawing.Image)(resources.GetObject("btnForced.Image")));
            this.btnForced.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForced.Name = "btnForced";
            this.btnForced.Size = new System.Drawing.Size(43, 22);
            this.btnForced.Text = "(Local)";
            this.btnForced.Click += new System.EventHandler(this.btnForced_Click);
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinMain";
            this.Text = "Log File Monitor";
            this.Load += new System.EventHandler(this.WinMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbLog;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel lblBuffer;
		private System.Windows.Forms.ToolStripTextBox tbBuffer;
		private System.Windows.Forms.ToolStripButton btnPauseContinue;
		private System.Windows.Forms.ToolStripButton btnSelectFile;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnErase;
        private System.Windows.Forms.Timer forcedTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnForced;
	}
}

