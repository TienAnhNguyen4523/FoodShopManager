namespace BTLlttq
{
	partial class Table
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thongTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.flpTable);
			this.panel1.Location = new System.Drawing.Point(367, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(574, 568);
			this.panel1.TabIndex = 0;
			// 
			// flpTable
			// 
			this.flpTable.Location = new System.Drawing.Point(0, 0);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(574, 568);
			this.flpTable.TabIndex = 0;
			// 
			// menuStrip2
			// 
			this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thongTinTaiKhoanToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(953, 36);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thongTinTaiKhoanToolStripMenuItem
			// 
			this.thongTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinCaNhanToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
			this.thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
			this.thongTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
			this.thongTinTaiKhoanToolStripMenuItem.Text = "Thong tin tai khoan";
			// 
			// thongTinCaNhanToolStripMenuItem
			// 
			this.thongTinCaNhanToolStripMenuItem.Name = "thongTinCaNhanToolStripMenuItem";
			this.thongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
			this.thongTinCaNhanToolStripMenuItem.Text = "Thong tin ca nhan";
			// 
			// dangXuatToolStripMenuItem
			// 
			this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
			this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
			this.dangXuatToolStripMenuItem.Text = "Dang xuat";
			this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(12, 39);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(349, 302);
			this.panel2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.pictureBox1.Image = global::BTLlttq.Properties.Resources.tea_green_high_resolution_logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(349, 302);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Table
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.ClientSize = new System.Drawing.Size(953, 608);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip2);
			this.Name = "Table";
			this.Text = "Table";
			this.Load += new System.EventHandler(this.Table_Load);
			this.panel1.ResumeLayout(false);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thongTinCaNhanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
		private System.Windows.Forms.FlowLayoutPanel flpTable;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}