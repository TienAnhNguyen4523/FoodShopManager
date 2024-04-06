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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnGiamgia = new System.Windows.Forms.Button();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
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
			this.lstBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lstBill.Name = "lstBill";
			this.lstBill.Size = new System.Drawing.Size(369, 479);
			this.lstBill.TabIndex = 1;
			this.lstBill.UseCompatibleStateImageBehavior = false;
			this.lstBill.View = System.Windows.Forms.View.Details;
			this.lstBill.SelectedIndexChanged += new System.EventHandler(this.lstBill_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên sản phẩm";
			this.columnHeader1.Width = 96;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			this.columnHeader2.Width = 78;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn giá";
			this.columnHeader3.Width = 94;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thành tiền";
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
			this.panel3.Location = new System.Drawing.Point(424, 494);
			this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(370, 47);
			this.panel3.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(134, 2);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 24);
			this.button1.TabIndex = 7;
			this.button1.Text = "Tổng tiền";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(134, 26);
			this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(76, 20);
			this.txtTongTien.TabIndex = 1;
			this.txtTongTien.Text = "0";
			this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// nmDisCount
			// 
			this.nmDisCount.Location = new System.Drawing.Point(31, 25);
			this.nmDisCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nmDisCount.Name = "nmDisCount";
			this.nmDisCount.Size = new System.Drawing.Size(78, 20);
			this.nmDisCount.TabIndex = 3;
			this.nmDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.btnCancel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(227, 4);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(68, 43);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Thoát";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnGiamgia
			// 
			this.btnGiamgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.btnGiamgia.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGiamgia.Location = new System.Drawing.Point(31, 0);
			this.btnGiamgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnGiamgia.Name = "btnGiamgia";
			this.btnGiamgia.Size = new System.Drawing.Size(78, 24);
			this.btnGiamgia.TabIndex = 6;
			this.btnGiamgia.Text = "Giảm giá";
			this.btnGiamgia.UseVisualStyleBackColor = false;
			this.btnGiamgia.Click += new System.EventHandler(this.btnGiamgia_Click);
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.btnThanhToan.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThanhToan.Location = new System.Drawing.Point(300, 2);
			this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(68, 43);
			this.btnThanhToan.TabIndex = 3;
			this.btnThanhToan.Text = "Thanh toán";
			this.btnThanhToan.UseVisualStyleBackColor = false;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(2, 13);
			this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(286, 21);
			this.cbCategory.TabIndex = 1;
			this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
			// 
			// flpFood
			// 
			this.flpFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.flpFood.Location = new System.Drawing.Point(-1, -1);
			this.flpFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.flpFood.Name = "flpFood";
			this.flpFood.Size = new System.Drawing.Size(410, 481);
			this.flpFood.TabIndex = 6;
			this.flpFood.Paint += new System.Windows.Forms.PaintEventHandler(this.flpFood_Paint_1);
			// 
			// nmFoodCount
			// 
			this.nmFoodCount.Location = new System.Drawing.Point(319, 14);
			this.nmFoodCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nmFoodCount.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.nmFoodCount.Name = "nmFoodCount";
			this.nmFoodCount.Size = new System.Drawing.Size(61, 20);
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
			this.panel1.Location = new System.Drawing.Point(10, 11);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(409, 46);
			this.panel1.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.flpFood);
			this.panel2.Location = new System.Drawing.Point(10, 63);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(409, 480);
			this.panel2.TabIndex = 11;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lstBill);
			this.panel4.Location = new System.Drawing.Point(424, 11);
			this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(370, 392);
			this.panel4.TabIndex = 12;
			// 
			// Oder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(190)))), ((int)(((byte)(83)))));
			this.ClientSize = new System.Drawing.Size(803, 552);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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