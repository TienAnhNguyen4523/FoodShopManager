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
	public partial class Table : Form
	{
		DataProcesser dtBase = new DataProcesser();
		private Classes.Account account;
		public Classes.Account Account
		{
			get { return account; } set { account = value; }
		}
		
		

		public Table(Classes.Account account)
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.account = account;
			
		}
		

		private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Close();
			form1.ShowDialog();
		}

		

		
		

		public void Table_Load(object sender, EventArgs e)
		{
			ChangeAccount(account.Type);
			LoadTable();
		}
		
		void LoadTable()
		{
			flpTable.Controls.Clear();
			List<Classes.Table> list = new List<Classes.Table>();
			DataTable dt = new DataTable();
			dt = dtBase.ReadData("select * from TableFood");
			foreach (DataRow t in dt.Rows)
			{
				Classes.Table table = new Classes.Table(t);
				list.Add(table);
			}
			foreach (Classes.Table t in list)
			{
				Button btn = new Button() { Width = 100, Height = 100 };
				btn.Text = t.Name + Environment.NewLine + t.Status;
				btn.Click += Btn_Click;
				btn.Tag = t;
				switch (t.Status)
				{
					case "trong":
						btn.BackColor = Color.Aqua;
						break;
					default: btn.BackColor = Color.Red; break;
				}
				flpTable.Controls.Add(btn);
			}
		}
		

		

		private void Btn_Click(object sender, EventArgs e)
		{
			int TableId = ((sender as Button).Tag as Classes.Table).Id;
			Oder o =new Oder(TableId,Account);
			o.Show();
			this.Close();
		}
		


		
		
		
		

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Admin admin = new Admin();
			

			admin.Show();
		}

		
		void ChangeAccount(int type)
		{
			adminToolStripMenuItem.Enabled = type == 1;
		}

		private void lstBill_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Profile profile = new Profile(account);
			profile.Show();
		}
	}
}
