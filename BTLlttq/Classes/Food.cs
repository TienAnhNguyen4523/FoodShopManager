using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLlttq.Classes
{
	internal class Food
	{
		public Food(int id, string name, int idcategory, float price) {
			this.id = id;
			this.name = name;
			this.idcategory = idcategory;
			this.price = price;
		}
		public Food(DataRow row) {
			this.id = (int)row["id"];
			this.name = row["name"].ToString();
			this.idcategory = (int)row["idCategory"];
			this.price = (float)Convert.ToDouble(row["price"].ToString());
		}
		public int id;
		public string name;
		public int idcategory;
		public float price;

		public int Id { get { return id; } set {  id = value; } }
		public float Price { get { return price; } set { price = value; } }
		public int IdCategory { get { return idcategory; } set { idcategory = value; } }
		public string Name { get { return name; } set {  name = value; } }
	}
}
