namespace LogFilePurger
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.lblDays = new System.Windows.Forms.ToolStripLabel();
			this.txtDays = new System.Windows.Forms.ToolStripTextBox();
			this.btnPurge = new System.Windows.Forms.ToolStripButton();
			this.btnSelect = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDays,
            this.txtDays,
            this.btnPurge,
            this.btnSelect});
			this.toolStrip1.Location = new System.Drawing.Point(3, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(236, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// lblDays
			// 
			this.lblDays.Name = "lblDays";
			this.lblDays.Size = new System.Drawing.Size(35, 22);
			this.lblDays.Text = "Days:";
			// 
			// txtDays
			// 
			this.txtDays.Name = "txtDays";
			this.txtDays.Size = new System.Drawing.Size(35, 25);
			this.txtDays.Text = "30";
			this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
			// 
			// btnPurge
			// 
			this.btnPurge.Image = ((System.Drawing.Image)(resources.GetObject("btnPurge.Image")));
			this.btnPurge.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPurge.Name = "btnPurge";
			this.btnPurge.Size = new System.Drawing.Size(58, 22);
			this.btnPurge.Text = "Purge";
			this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
			this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(94, 22);
			this.btnSelect.Text = "Select Folder";
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.txtOutput);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(555, 345);
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(555, 370);
			this.toolStripContainer1.TabIndex = 1;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtOutput.ForeColor = System.Drawing.Color.Lime;
			this.txtOutput.Location = new System.Drawing.Point(0, 0);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutput.Size = new System.Drawing.Size(555, 345);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.Text = "Select a Folder...";
			// 
			// WinMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 370);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WinMain";
			this.Text = "Log File Purger";
			this.Load += new System.EventHandler(this.WinMain_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.ToolStripButton btnPurge;
		private System.Windows.Forms.ToolStripButton btnSelect;
		private System.Windows.Forms.ToolStripLabel lblDays;
		private System.Windows.Forms.ToolStripTextBox txtDays;





	}
}

