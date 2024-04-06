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
	public partial class Profile : Form
	{
		DataProcesser dtbase = new DataProcesser();
		private Classes.Account account;
		public Classes.Account Account
		{
			get { return account; }
			set { account = value; }
		}
		public Profile(Classes.Account account)
		{
			InitializeComponent();
			this.account=account;
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Profile_Load(object sender, EventArgs e)
		{
			txtName.Text = account.Username;
			txtTenHienThi.Text = account.Displayname;
			
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if(txtPass.Text != account.Password)
			{
				MessageBox.Show("sai mat khau");
			}
			else
			{
				if(txtNewPass.Text == txtNhapLai.Text)
				{
					dtbase.ChangeData("update Accoumt set PassWord = '"+txtNewPass.Text+"' where username ='"+account.Username+"'" );
					account.Password = txtNewPass.Text;
					txtPass.Text = txtNewPass.Text = txtNhapLai.Text = "";
				}
				else
				{
					MessageBox.Show("mat khau moi khong dung");
				}
			}
		}
	}
}
