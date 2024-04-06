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
	public partial class Form1 : Form
	{
		DataProcesser dtBase = new DataProcesser();
		public Form1()
		{
			InitializeComponent();

			
			this.StartPosition = FormStartPosition.CenterScreen;
			
		}
		
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtName.Text;
			string password = txtPass.Text;
			if (Login(username,	password))
			{
				Classes.Account account = GetAccount(username);
				Table table = new Table(account);
				
				table.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
			}
			
		}
		bool Login(string username, string password )
		{
			
			DataTable dt = new DataTable();
			dt = dtBase.ReadData("select * from Accoumt where UserName='"+username+"'"+ "and PassWord ='" + password+"'");
			if(dt.Rows.Count > 0)
			{
				return true;
			}
			return false;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		
		public Classes.Account GetAccount(string username)
		{
			DataTable t = new DataTable();
			t = dtBase.ReadData("select * from Accoumt where username ='" + username + "'");
			foreach(DataRow dr in t.Rows)
			{
				return new Classes.Account(dr);
			}
			return null;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				this.Close();
			}
		}

		

		
	}
}
