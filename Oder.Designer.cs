namespace BTLlttq
{
	partial class Oder
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
			this.lstBill = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.nmDisCount = new System.Windows.Forms.NumericUpDown();
			this.btnGiamgia = new System.Windows.Forms.Button();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstBill
			// 
			this.lstBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lstBill.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lstBill.GridLines = true;
			this.lstBill.HideSelection = false;
			this.lstBill.Location = new System.Drawing.Point(0, 0);
			this.lstBill.Name = "lstBill";
			this.lstBill.Size = new System.Drawing.Size(491, 482);
			this.lstBill.TabIndex = 1;
			this.lstBill.UseCompatibleStateImageBehavior = false;
			this.lstBill.View = System.Windows.Forms.View.Details;
			this.lstBill.SelectedIndexChanged += new System.EventHandler(this.lstBill_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Ten san pham";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "So luong";
			this.columnHeader2.Width = 78;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Don gia";
			this.columnHeader3.Width = 94;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thanh tien";
			this.columnHeader4.Width = 97;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.txtTongTien);
			this.panel3.Controls.Add(this.nmDisCount);
			this.panel3.Controls.Add(this.btnCancel);
			this.panel3.Controls.Add(this.btnGiamgia);
			this.panel3.Controls.Add(this.btnThanhToan);
			this.panel3.Location = new System.Drawing.Point(565, 501);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(494, 58);
			this.panel3.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(179, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 30);
			this.button1.TabIndex = 7;
			this.button1.Text = "Tong tien";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(179, 32);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(100, 22);
			this.txtTongTien.TabIndex = 1;
			this.txtTongTien.Text = "0";
			this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// nmDisCount
			// 
			this.nmDisCount.Location = new System.Drawing.Point(69, 33);
			this.nmDisCount.Name = "nmDisCount";
			this.nmDisCount.Size = new System.Drawing.Size(91, 22);
			this.nmDisCount.TabIndex = 3;
			// 
			// btnGiamgia
			// 
			this.btnGiamgia.Location = new System.Drawing.Point(69, 0);
			this.btnGiamgia.Name = "btnGiamgia";
			this.btnGiamgia.Size = new System.Drawing.Size(91, 30);
			this.btnGiamgia.TabIndex = 6;
			this.btnGiamgia.Text = "Giam gia";
			this.btnGiamgia.UseVisualStyleBackColor = true;
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.Location = new System.Drawing.Point(400, 3);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(91, 53);
			this.btnThanhToan.TabIndex = 3;
			this.btnThanhToan.Text = "Thanh Toan";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(3, 16);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(253, 24);
			this.cbCategory.TabIndex = 1;
			this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
			// 
			// flpFood
			// 
			this.flpFood.Location = new System.Drawing.Point(-1, -1);
			this.flpFood.Name = "flpFood";
			this.flpFood.Size = new System.Drawing.Size(546, 592);
			this.flpFood.TabIndex = 6;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(303, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(91, 53);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Thoat";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// nmFoodCount
			// 
			this.nmFoodCount.Location = new System.Drawing.Point(279, 18);
			this.nmFoodCount.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.nmFoodCount.Name = "nmFoodCount";
			this.nmFoodCount.Size = new System.Drawing.Size(44, 22);
			this.nmFoodCount.TabIndex = 9;
			this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbCategory);
			this.panel1.Controls.Add(this.nmFoodCount);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(545, 57);
			this.panel1.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.flpFood);
			this.panel2.Location = new System.Drawing.Point(13, 77);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(545, 591);
			this.panel2.TabIndex = 11;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lstBill);
			this.panel4.Location = new System.Drawing.Point(565, 13);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(494, 482);
			this.panel4.TabIndex = 12;
			// 
			// Oder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 680);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "Oder";
			this.Text = "Oder";
			this.Load += new System.EventHandler(this.Oder_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListView lstBill;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.NumericUpDown nmDisCount;
		private System.Windows.Forms.Button btnGiamgia;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.FlowLayoutPanel flpFood;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown nmFoodCount;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
	}
}