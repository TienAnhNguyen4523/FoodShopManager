using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLlttq.Classes
{
	public class Category
	{
		public Category(int id, string name) { 
			this.id = id; this.name = name;
		}
		public Category(DataRow row)
		{
			this.id = (int)row["id"];
			this.name = row["name"].ToString();
		}
		public int id;
		public string name;
		public int Id { get {  return this.id; } set { this.id = value; } }
		public string Name { get { return this.name; } set { this.name = value; } }
	}
}
