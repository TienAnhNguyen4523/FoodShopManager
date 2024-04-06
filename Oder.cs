using BTLlttq.Classes;
using BTLlttq.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				if (MessageBox.Show("Tong tien la: " + thanhtien.ToString(), "thong bao", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
					if (MessageBox.Show("ban co muon thanh toan hoa don ban " + id, "thong bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
					{

						dtBase.ChangeData("update bill set datecheckout = getdate(), status = 1, discount = " + (int)nmDisCount.Value + ",TongTien=" + thanhtien + " where id = " + idbill);
						dtBase.ChangeData("update tablefood set status = 'trong' where id = " + id);
						Table table = new Table(account);
						
						this.Close();
						table.Show();
					}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Table table = new Table(account);

			this.Close();
			table.Show();
		}
	}
}
