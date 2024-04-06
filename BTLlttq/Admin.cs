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
using System.Windows.Forms.DataVisualization.Charting;

namespace BTLlttq
{
	public partial class Admin : Form
	{
		BindingSource foodlst = new BindingSource();
		BindingSource categorylst = new BindingSource();
		BindingSource tablelstbd = new BindingSource();
		BindingSource accountlst = new BindingSource();

		DataProcesser dtBase = new DataProcesser();
		public Admin()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;


		}

		private void Admin_Load(object sender, EventArgs e)
		{
			dtgvAddFood.DataSource = foodlst;
			dtgvCategory.DataSource = categorylst;
			dtgvTable.DataSource = tablelstbd;
			dtgvLogin.DataSource = accountlst;

			
			LoadLstFood();
			LoadLstCategory();
			LoadLstTable();
			LoadLstAccount();
			AddCategoryBinding();
			AddFoodBinding();
			AddTableBinding();
			AddAccountBinding();
			GetCategoryIntoCb(cbCategory);

		}
		List<Classes.Food> SearchFood(string name)
		{
			List<Classes.Food> f = new List<Classes.Food>();
			DataTable dt = dtBase.ReadData("select * from Food where name like '%" + name + "%'");
			foreach(DataRow row in dt.Rows)
			{
				Classes.Food food= new Classes.Food(row);
				f.Add(food);
			}
			return f;
		}
		public void LoadLstAccount()
		{
			DataTable acList = new DataTable();
			acList = dtBase.ReadData("select * from Accoumt");
			accountlst.DataSource = acList;
		}
		public void LoadLstTable()
		{
			DataTable tablelst = new DataTable();
			tablelst = dtBase.ReadData("select * from tablefood");
			tablelstbd.DataSource = tablelst;
		}
		public void LoadLstCategory()
		{
			DataTable catelst = new DataTable();
			catelst = dtBase.ReadData("select * from foodcategory");
			categorylst.DataSource = catelst;
		}
		public void LoadLstFood() {
			DataTable billlst = new DataTable();
			billlst = dtBase.ReadData("select * from food");
			foodlst.DataSource = billlst;
		}
		void AddFoodBinding()
		{
			txtNameFood.DataBindings.Add(new Binding("Text",dtgvAddFood.DataSource,"name",true,	DataSourceUpdateMode.Never));
			txtID.DataBindings.Add(new Binding("Text",dtgvAddFood.DataSource,"id",true,DataSourceUpdateMode.Never));
			nmGiaFood.DataBindings.Add(new Binding("value",dtgvAddFood.DataSource,"price",true,DataSourceUpdateMode.Never));
			dtgvAddFood.Columns["ID"].HeaderText = "Mã thức ăn";
			dtgvAddFood.Columns["name"].HeaderText = "Tên món ăn";
			dtgvAddFood.Columns["idCategory"].HeaderText = "Mã danh mục";
			dtgvAddFood.Columns["price"].HeaderText = "Giá";



		}
		void AddCategoryBinding()
		{
			txtNameCategory.DataBindings.Add(new Binding("Text",dtgvCategory.DataSource,"name",true,	DataSourceUpdateMode.Never));
			txtIdCategory.DataBindings.Add(new Binding("Text",dtgvCategory.DataSource,"id",true,DataSourceUpdateMode.Never));
			dtgvCategory.Columns["id"].HeaderText = "Mã danh mục";
			dtgvCategory.Columns["name"].HeaderText = "Tên danh mục";

		}
		void AddTableBinding()
		{
			txtNameTable.DataBindings.Add(new Binding("Text",dtgvTable.DataSource,"name",true,	DataSourceUpdateMode.Never));
			txtIdTable.DataBindings.Add(new Binding("Text",dtgvTable.DataSource,"id",true,DataSourceUpdateMode.Never));
			txtTrangThaiTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
			dtgvTable.Columns["id"].HeaderText = "Mã bàn";
			dtgvTable.Columns["name"].HeaderText = "Tên bàn";
			dtgvTable.Columns["status"].HeaderText = "Trạng thái";
			

		}
		void AddAccountBinding()
		{
			txtTenTaiKhoan.DataBindings.Add(new Binding("Text",dtgvLogin.DataSource,"username",true,	DataSourceUpdateMode.Never));
			txtTenHienThi.DataBindings.Add(new Binding("Text",dtgvLogin.DataSource, "DisplayName", true,DataSourceUpdateMode.Never));
			txtLoaiTaiKhoan.DataBindings.Add(new Binding("Text", dtgvLogin.DataSource, "Type", true, DataSourceUpdateMode.Never));
			dtgvLogin.Columns["userName"].HeaderText = "Tên đăng nhập";
			dtgvLogin.Columns["displayName"].HeaderText = "Tên hiển thị";
			dtgvLogin.Columns["passWord"].HeaderText = "Mật khẩu";
			dtgvLogin.Columns["type"].HeaderText = "Loại tài khoản";

		}

		void GetCategoryIntoCb(ComboBox cb)
		{
			DataTable dtcategory = new DataTable();
			dtcategory = dtBase.ReadData("select * from FoodCategory");
			List<Classes.Category> categories = new List<Classes.Category>();
			foreach (DataRow c in dtcategory.Rows)
			{
				Classes.Category category = new Classes.Category(c);
				categories.Add(category);
			}
			cb.DataSource = categories;
			cb.DisplayMember = "Name";

		}
		public Classes.Category GetCategoryById(int id)
		{
			Classes.Category category = null;
			DataTable dtcategory = dtBase.ReadData("select * from foodcategory where id = " + id);
			foreach(DataRow c in dtcategory.Rows)
			{
				category = new Classes.Category(c);
				return category;
			}
			return category;

		}
		
		public int GetFood(int id)
		{
			DataTable dtfood = dtBase.ReadData("select Food.id,Food.idCategory,Food.name,Food.price from Food inner join BillInfo on BillInfo.idFood = Food.id inner join FoodCategory on Food.idCategory= FoodCategory.id where FoodCategory.id =" + id);
			if (dtfood.Rows.Count > 0)
			{
				Classes.Food bill = new Classes.Food(dtfood.Rows[0]);
				return bill.Id;
			}
			return -1;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			dataTable = dtBase.ReadData("select * from Bill where DateCheckIn>='"+dateTimePicker2.Value+"'and DateCheckOut<='"+dateTimePicker1.Value+"'\r\n");
			dtgvBill.DataSource = dataTable;

			DataTable dt = new DataTable();
			dt = dtBase.ReadData("select foodcategory.name as namecategory , SUM(BillInfo.count) as Tong from BillInfo inner join Food on BillInfo.idFood= Food.id inner join Bill on Bill.id = BillInfo.idBill inner join foodcategory on food.idcategory = foodcategory.id  where Bill.DateCheckIn>='"+dateTimePicker2.Value+"' and Bill.DateCheckOut<='"+dateTimePicker1.Value+"' group by foodcategory.name\r\n");
			foreach(DataRow chart in dt.Rows)
			{
				string name = chart["namecategory"].ToString();
				int dem = Convert.ToInt32(chart["Tong"]);
				chart1.Series["Food"].Points.AddXY(name, dem);
				
			}
			decimal totalValue = 0;
			foreach (DataGridViewRow row in dtgvBill.Rows)
			{
				decimal value = Convert.ToDecimal(row.Cells["TongTien"].Value);
				totalValue += value;
			}
			txtTongDT.Text = totalValue.ToString();

		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			LoadLstFood();
		}

		private void btnXemCategory_Click(object sender, EventArgs e)
		{
			LoadLstCategory();
		}

		private void btnXemTable_Click(object sender, EventArgs e)
		{
			LoadLstTable();
		}

		private void btnXemLogin_Click(object sender, EventArgs e)
		{
			LoadLstAccount();
		}
		public Classes.Category GetCategoryByFood(int idfood)
		{
			Classes.Category category = null;
			DataTable dtcategory = dtBase.ReadData("select FoodCategory.id, FoodCategory.name from FoodCategory inner join Food on FoodCategory.id = Food.idCategory where Food.id =" + idfood);
			foreach (DataRow c in dtcategory.Rows)
			{
				category = new Classes.Category(c);
				
			}

			return category;

		}

		private void txtID_TextChanged(object sender, EventArgs e)
		{
			Classes.Category x = GetCategoryByFood(Int32.Parse(txtID.Text));
			cbCategory.SelectedItem = x;
			int index = -1;
			int i = 0;
			foreach(Classes.Category c in cbCategory.Items)
			{
				if (c.id == x.id)
				{
					index= i; break;	
				}
				i++;
			}
			cbCategory.SelectedIndex = index;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string name = txtNameFood.Text;
			int idcategory = (cbCategory.SelectedItem as Classes.Category).id;
			int price = (int)nmGiaFood.Value;
			int row = dtBase.BoolChangeData("insert Food(name,idCategory,price) values('" + name + "'," + idcategory + "," + price + ")\r\n");
			if (row > 0)
			{
				MessageBox.Show("Thêm thành công");
				LoadLstFood();
				insertFood?.Invoke(this, EventArgs.Empty);
				txtID.Text = "";
				txtNameFood.Text = "";
				nmGiaFood.Value = 0;
				cbCategory.SelectedIndex = 0;

			}
			else
			{
				MessageBox.Show("Thất bại");
			}

			

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string name = txtNameFood.Text;
			int idcategory = (cbCategory.SelectedItem as Classes.Category).id;
			int price = (int)nmGiaFood.Value;
			int id = Int32.Parse(txtID.Text);
			int row = dtBase.BoolChangeData("update Food set name ='"+name+"' , idcategory ="+idcategory+", price="+price+"where id ="+id);
			if (row > 0)
			{
				MessageBox.Show("Sửa thành công");
				LoadLstFood();
				updateFood?.Invoke(this, EventArgs.Empty);
				txtID.Text = "";
				txtNameFood.Text = "";
				nmGiaFood.Value = 0;
				cbCategory.SelectedIndex = 0;
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}
		private event EventHandler insertFood;
		public event EventHandler InsertFood
		{
			add { insertFood += value; }
			remove { insertFood -= value; }
		}
		private event EventHandler deletFood;
		public event EventHandler DeletFood
		{
			add { deletFood += value; }
			remove { deletFood -= value; }
		}
		private event EventHandler updateFood;
		public event EventHandler UpdateFood
		{
			add { updateFood += value; }
			remove { updateFood -= value; }
		}

		

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int id = Int32.Parse(txtID.Text);
			dtBase.ChangeData("delete billinfo where idfood = " + id);
			int row = dtBase.BoolChangeData("delete food where id =" + id);
			if (row > 0)
			{
				MessageBox.Show("Xóa thành công");
				LoadLstFood();
				deletFood?.Invoke(this, EventArgs.Empty);
				txtID.Text = "";
				txtNameFood.Text = "";
				nmGiaFood.Value = 0;
				cbCategory.SelectedIndex = 0;
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}

		private void btnThemCategory_Click(object sender, EventArgs e)
		{
			string name = txtNameCategory.Text;

			if (string.IsNullOrWhiteSpace(name))
			{
				MessageBox.Show("Tên không được để trống");
				return;
			}

			if (dtBase != null)
			{
				int row = dtBase.BoolChangeData("INSERT INTO FoodCategory (name) VALUES ('" + name + "')");

				if (row > 0)
				{
					MessageBox.Show("Thêm thành công");
					LoadLstCategory();

					// Gọi sự kiện đúng tên
					insertTable?.Invoke(this, EventArgs.Empty);
				}
				else
				{
					MessageBox.Show("Thất bại");
				}
				txtIdCategory.Text = "";
				txtNameCategory.Text = "";

			}
			else
			{
				MessageBox.Show("Đối tượng dtBase chưa được khởi tạo");
			}
		}

		private void btnSuaCategory_Click(object sender, EventArgs e)
		{
			string name = txtNameCategory.Text;
			int id = Int32.Parse(txtIdCategory.Text);
			int row = dtBase.BoolChangeData("update FoodCategory set name ='" + name + "' where id =" + id);
			if (row > 0)
			{
				MessageBox.Show("Sửa thành công");
				LoadLstCategory();
				updateCategory?.Invoke(this, EventArgs.Empty);
				txtIdCategory.Text = "";
				txtNameCategory.Text = "";
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}
		private void btnXoaCategory_Click(object sender, EventArgs e)
		{
			int id = Int32.Parse(txtIdCategory.Text);
			int idfood = GetFood(id);
			dtBase.ChangeData("delete billinfo where idfood = " + idfood);
			dtBase.ChangeData("delete food where idcategory = " + id);
			int row = dtBase.BoolChangeData("delete foodcategory where id =" + id);
			if (row > 0)
			{
				MessageBox.Show("Xóa thành công");
				LoadLstCategory();
				deletCategory?.Invoke(this, EventArgs.Empty);
				txtIdCategory.Text = "";
				txtNameCategory.Text = "";

			}
			else
			{
				MessageBox.Show("that bai");
			}

		}
		private event EventHandler insertCategory;
		public event EventHandler InsertCategory
		{
			add { insertCategory += value; }
			remove { insertCategory -= value; }
		}
		private event EventHandler deletCategory;
		public event EventHandler DeletCategory
		{
			add { deletCategory += value; }
			remove { deletCategory -= value; }
		}
		private event EventHandler updateCategory;
		public event EventHandler UpdateCategory
		{
			add { updateCategory += value; }
			remove { updateCategory -= value; }
		}

		private void btnThemTable_Click(object sender, EventArgs e)
		{
			string name = txtNameTable.Text;
			int id = Int32.Parse( txtIdTable.Text);
			string status = txtTrangThaiTable.Text;
			int row = dtBase.BoolChangeData("insert TableFood(name,status) values('" + name + "','"+status+"')");
			if (row > 0)
			{
				MessageBox.Show("Thêm thành công");
				LoadLstTable();
				insertTable?.Invoke(this,EventArgs.Empty);
				txtIdTable.Text = "";
				txtNameTable.Text = "";
				txtTrangThaiTable.Text = "";
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}

		private void btnSuaTable_Click(object sender, EventArgs e)
		{
			string name = txtNameTable.Text;
			int id = Int32.Parse(txtIdTable.Text);
			string status = txtTrangThaiTable.Text;
			int row = dtBase.BoolChangeData("update TableFood set name ='" + name + "',status='"+status+"' where id =" + id);
			if (row > 0)
			{
				MessageBox.Show("Sửa thành công");
				LoadLstTable();
				updateTable?.Invoke(this, EventArgs.Empty);
				txtIdTable.Text = "";
				txtNameTable.Text = "";
				txtTrangThaiTable.Text = "";
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}

		private void btnXoaTable_Click(object sender, EventArgs e)
		{
			string name = txtNameTable.Text;
			int id = Int32.Parse(txtIdTable.Text);

			int row = dtBase.BoolChangeData("delete TableFood where id =" + id);
			if (row > 0)
			{
				MessageBox.Show("Xóa thành công");
				LoadLstTable();
				deletTable?.Invoke(this, EventArgs.Empty);
				txtIdTable.Text = "";
				txtNameTable.Text = "";
				txtTrangThaiTable.Text = "";
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}
		private event EventHandler insertTable;
		public event EventHandler InsertTable
		{
			add { insertTable += value; }
			remove { insertTable -= value; }
		}
		private event EventHandler deletTable;
		public event EventHandler DeletTable
		{
			add { deletTable += value; }
			remove { deletTable -= value; }
		}
		private event EventHandler updateTable;
		public event EventHandler UpdateTable
		{
			add { updateTable += value; }
			remove { updateTable -= value; }
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			foodlst.DataSource =	SearchFood(txtFoodName.Text);
		}

		private void btnThemLogin_Click(object sender, EventArgs e)
		{
			string username = txtTenTaiKhoan.Text;
			string displayname = txtTenHienThi.Text;
			int type = Int32.Parse(txtLoaiTaiKhoan.Text);
			int row = dtBase.BoolChangeData("insert Accoumt(username,displayname,type) values('" + username + "','" + displayname + "','" + type + "')");
			if (row > 0)
			{
				MessageBox.Show("Thêm thành công");
				LoadLstAccount();
				txtTenTaiKhoan.Text = "";
				txtTenHienThi.Text = "";
				txtLoaiTaiKhoan.Text = "";

			}
			else
			{
				MessageBox.Show("that bai");
			}
		}

		private void btnSuaLogin_Click(object sender, EventArgs e)
		{
			string username = txtTenTaiKhoan.Text;
			string displayname = txtTenHienThi.Text;
			int type = Int32.Parse(txtLoaiTaiKhoan.Text);
			int row = dtBase.BoolChangeData("update Accoumt set displayname ='" + displayname + "',type=" + type + " where username ='" + username + "'");
			if (row > 0)
			{
				MessageBox.Show("Sửa thành công");
				LoadLstAccount();
				txtTenTaiKhoan.Text = "";
				txtTenHienThi.Text = "";
				txtLoaiTaiKhoan.Text = "";
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}

		private void btnXoaLogin_Click(object sender, EventArgs e)
		{
			string username = txtTenTaiKhoan.Text;
			string displayname = txtTenHienThi.Text;
			int type = Int32.Parse(txtLoaiTaiKhoan.Text);
			int row = dtBase.BoolChangeData("delete Accoumt where username ='" + username+"'");
			if (row > 0)
			{
				MessageBox.Show("Xóa thành công");
				LoadLstAccount();
				txtTenTaiKhoan.Text = "";
				txtTenHienThi.Text = "";
				txtLoaiTaiKhoan.Text = "";
			}
			else
			{
				MessageBox.Show("that bai");
			}
		}

		private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dtgvAddFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
