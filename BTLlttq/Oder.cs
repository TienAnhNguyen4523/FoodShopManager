using BTLlttq.Classes;
using BTLlttq.Properties;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
namespace BTLlttq
{
	public partial class Oder : Form
	{
		DataProcesser dtBase = new DataProcesser();
		private Classes.Account account;
		public Classes.Account Account { get { return account; } set { account = value; } }
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public Oder(int id,Classes.Account a)
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.id = id;
			this.account = a;
		}
		void ShowBill(int id)
		{
			lstBill.Items.Clear();

			List<Classes.Menu> list = GetListMenu(id);
			float x = 0;
			foreach (Classes.Menu m in list)
			{
				ListViewItem listViewItem = new ListViewItem(m.Name.ToString());
				listViewItem.SubItems.Add(m.Count.ToString());
				listViewItem.SubItems.Add(m.DonGia.ToString());
				listViewItem.SubItems.Add(m.ThanhTien.ToString());
				x += m.ThanhTien;
				lstBill.Items.Add(listViewItem);
			}
			txtTongTien.Text = x.ToString();
		}
		public List<Classes.Menu> GetListMenu(int id)
		{
			List<Classes.Menu> list = new List<Classes.Menu>();
			DataTable dt = dtBase.ReadData("select Food.name, SUM(BillInfo.count) as Soluong, Food.price,Food.price*Sum(BillInfo.count) as thanhtien from Food inner join BillInfo on BillInfo.idFood= Food.id inner join Bill on Bill.id = BillInfo.idBill where Bill.idTable=" + id + " and bill.status =0 group by Food.name, Food.price");
			foreach (DataRow dr in dt.Rows)
			{

				Classes.Menu menues = new Classes.Menu(dr);
				if (menues.Count > 0)
					list.Add(menues);
			}
			return list;
		}
		public void LoadLstCategory()
		{
			DataTable dtcategory = new DataTable();
			dtcategory = dtBase.ReadData("select * from FoodCategory");
			List<Classes.Category> categories = new List<Classes.Category>();
			foreach (DataRow c in dtcategory.Rows)
			{
				Classes.Category category = new Classes.Category(c);
				categories.Add(category);
			}
			cbCategory.DataSource = categories;
			cbCategory.DisplayMember = "Name";
		}

		private void lstBill_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Oder_Load(object sender, EventArgs e)
		{
			ShowBill(id);
			LoadLstCategory();
		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{

			int id = 0;



			ComboBox cb = sender as ComboBox;

			Category selected = cb.SelectedItem as Category;
			id = selected.id;
			LoadFood(id);
		}
		void LoadFood(int id)
		{
			flpFood.Controls.Clear();
			List<Classes.Food> list = new List<Classes.Food>();
			DataTable dt = new DataTable();
			dt = dtBase.ReadData("select * from Food where idcategory =" + id);
			foreach (DataRow t in dt.Rows)
			{
				Classes.Food food = new Classes.Food(t);
				list.Add(food);
			}
			foreach (Classes.Food t in list)
			{
				Button btn = new Button() { Width = 100, Height = 100 };
				btn.Text = t.Name + Environment.NewLine + t.price;
				btn.Click += Btn_Click;
				btn.Tag = t;

				flpFood.Controls.Add(btn);
			}
		}
		private void Btn_Click(object sender, EventArgs e)
		{
			int idbill = GetCheckIdBillByTable(id);
			int FoodId = ((sender as Button).Tag as Classes.Food).Id;

			int count = Int32.Parse(nmFoodCount.Value.ToString());
			if (idbill == -1)
			{
				dtBase.ChangeData("exec InsertBill @TableID = " + id);
				dtBase.ChangeData("insert BillInfo(idBill,idFood,count) values((select MAX(id) from Bill)," + FoodId + "," + count + ")");
			}
			else
			{
				dtBase.ChangeData("exec InsertBillInfo @idbill = " + idbill + ",@idfood =" + FoodId + ", @count = " + count);

			}
			dtBase.ChangeData("update tablefood set status = 'co nguoi' where id = " + id);
			ShowBill(id);



		}
		public int GetCheckIdBillByTable(int id)
		{
			DataTable selectidbill = dtBase.ReadData("select * from Bill where idTable = " + id + " and status =0");
			if (selectidbill.Rows.Count > 0)
			{
				Classes.Bill bill = new Bill(selectidbill.Rows[0]);
				return bill.Id;
			}
			return -1;
		}


		private void flpFood_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnThanhToan_Click_1(object sender, EventArgs e)
		{
			int idbill = GetCheckIdBillByTable(id);
			int discount = (int)nmDisCount.Value;
			int tongtien = Int32.Parse(txtTongTien.Text);
			int thanhtien = tongtien - tongtien * discount / 100;
			if (idbill != -1)
			{
				if (MessageBox.Show("Tổng tiền là : " + thanhtien.ToString(), "thông bao", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
					if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn bàn " + id, "thông bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
					{

						dtBase.ChangeData("update bill set datecheckout = getdate(), status = 1, discount = " + (int)nmDisCount.Value + ",TongTien=" + thanhtien + " where id = " + idbill);
						dtBase.ChangeData("update tablefood set status = 'trong' where id = " + id);
						Table table = new Table(account);
						
						
						if (MessageBox.Show("Bạn có muốn in hóa đơn bàn " + id, "thông bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
						{
							Excel.Application exApp = new Excel.Application();
							Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
							Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
							Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
							exRange.Font.Size = 15;
							exRange.Font.Bold = true;
							exRange.Font.Color = Color.Green;
							exRange.Value = "Quản lý quán trà sữa";
							Excel.Range nhom = (Excel.Range)exSheet.Cells[2, 1];
							nhom.Font.Size = 15;
							nhom.Font.Bold = true;
							nhom.Font.Color = Color.Green;
							nhom.Value = "Bài tập lớn nhóm 17 ";
							exSheet.Range["D4"].Font.Size = 25;
							exSheet.Range["D4"].Font.Bold = true;
							exSheet.Range["D4"].Font.Color = Color.Red;
							exSheet.Range["D4"].Value = "Hóa đơn bán bàn " + id;
							exSheet.Range["C8"].ColumnWidth = 17;
							exSheet.Range["B7"].Font.Size = 10;
							exSheet.Range["B7"].Font.Bold = true;
							exSheet.Range["B7"].Font.Color = Color.Green;
							exSheet.Range["B7"].Value = "Bàn số " + id;
							exSheet.Range["B7:E7"].Font.Size = 15;
							exSheet.Range["B8:F8"].Font.Bold = true;
							exSheet.Range["B8"].Value = "Số thứ tự ";
							exSheet.Range["C8"].Value = "Tên món ăn";
							exSheet.Range["D8"].Value = "Số lượng";
							exSheet.Range["E8"].Value = "Đơn giá";
							exSheet.Range["F8"].Value = "Thành tiền";
							exSheet.Range["F8"].ColumnWidth = 17;
							int dong = 9;
							//DataTable dt = dtBase.ReadData("select idFood,count(count) as soluongmua from billinfo where idBill = '"+id+"' group by idFood");
							
							for (int i = 0; i < lstBill.Items.Count; i++)
							{
								ListViewItem firstItem = lstBill.Items[i];
								exSheet.Range["B" + (dong + i).ToString()].Value = (i + 1).ToString();
								exSheet.Range["C" + (dong + i).ToString()].Value = firstItem.SubItems[0].Text;
								exSheet.Range["D" + (dong + i).ToString()].Value = firstItem.SubItems[1].Text;
								exSheet.Range["E" + (dong + i).ToString()].Value = firstItem.SubItems[2].Text;
								exSheet.Range["F" + (dong + i).ToString()].Value = firstItem.SubItems[3].Text;

							}
							exSheet.Range["F18"].Value = "Giảm giá : ";
							exSheet.Range["G18"].Value = discount.ToString() + "%";
							exSheet.Range["F20"].Value = "Tổng tiền hóa đơn : ";
							exSheet.Range["G20"].ColumnWidth = 17;
							exSheet.Range["G20"].Value = thanhtien.ToString() + " dong";






							exSheet.Name = "Hóa đơn";
							exBook.Activate();
							SaveFileDialog save = new SaveFileDialog();
							if (save.ShowDialog() == DialogResult.OK)
							{
								exBook.SaveAs(save.FileName.ToLower());
							}
							exApp.Quit();

							MessageBox.Show("Đã in ra file excel");
							
							this.Close();
							table.Show();
						}
						else
						{
							this.Close();
							table.Show();
						}
					}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Table table = new Table(account);

			this.Close();
			table.Show();
		}

		private void flpFood_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void btnGiamgia_Click(object sender, EventArgs e)
		{

		}
	}
}
