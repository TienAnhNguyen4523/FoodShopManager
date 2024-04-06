using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLlttq.Properties
{
	internal class DataProcesser
	{
		string strConnect = "Data Source=DESKTOP-UT6L5JI\\SQLEXPRESS;Initial Catalog=laptrinhtrucquan;Integrated Security=True";
		SqlConnection sqlCnn = null;
		//Hàm mở kết nối
		void OpenConnect()
		{
			sqlCnn = new SqlConnection(strConnect);
			if (sqlCnn.State != ConnectionState.Open)
				sqlCnn.Open();
		}
		//Hàm đóng kết nối
		void CloseConnect()
		{
			if (sqlCnn.State != ConnectionState.Closed)
				sqlCnn.Close();
			sqlCnn.Dispose();
		}
		//Hàm thưc hiện lệnh insert,update, delete
		public void ChangeData(string sql)
		{
			int row = 0;
			OpenConnect();
			SqlCommand command = new SqlCommand();
			command.Connection = sqlCnn;
			command.CommandText = sql;
			row=command.ExecuteNonQuery();
			CloseConnect();

		}
		public int BoolChangeData(string sql)
		{
			int rowsAffected = 0;
			OpenConnect();
			using (SqlCommand command = new SqlCommand(sql, sqlCnn))
			{
				rowsAffected = command.ExecuteNonQuery();
			}
			CloseConnect();
			return rowsAffected;
		}
		//Hàm đọc dl
		public DataTable ReadData(string sqlSelect)
		{
			DataTable dt = new DataTable();
			OpenConnect();
			SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, sqlCnn);
			adapter.Fill(dt);
			CloseConnect();
			return dt;
		}

	}
}

