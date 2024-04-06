using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLlttq.Classes
{
	public class Menu
	{
		public Menu(string name, int count, float dongia, float thanhtien) {
			this.name = name;
			this.count = count;
			this.dongia = dongia;
			this.thanhtien = thanhtien;
		}
		public Menu(DataRow row)
		{
			this.name = row["Name"].ToString();
			this.count = (int)row["Soluong"];
			this.dongia = (float)Convert.ToDouble(row["price"].ToString());
			this.thanhtien = (float)Convert.ToDouble(row["thanhtien"].ToString());

		}	
		public float thanhtien;
		public float ThanhTien { get {  return thanhtien; } set {  thanhtien = value; } }
		public float dongia;
		public float DonGia { get { return dongia; } set { dongia = value; } }

		public int count;
		public int Count { get { return count; } set { count = value; } }

		public string name;
		public string Name { get { return name; } set { name = value; } }
	}
}
