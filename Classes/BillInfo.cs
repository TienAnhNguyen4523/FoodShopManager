using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLlttq.Classes
{
	public class BillInfo
	{
		public BillInfo(int id, int idBill, int idFood, int count) {
			this.id = id;
			this.idBill = idBill;
			this.idFood = idFood;
			this.count = count;
		}
		public BillInfo(DataRow row) { 
			this.id = (int)row["id"];
			this.idBill = (int)row["idBill"];
			this.idFood = (int)row["idFood"];
			this.count= (int)row["count"];
		}
		public int id;
		public int idBill;
		public int idFood;
		public int count;
		public int Id{ get { return id; } set { id = value; } }
		public int IdBill { get { return idBill; } set { idBill = value; } }
		public int IdFood { get {  return idFood; } set {  count = value; } }
		public int Count { get { return count; }set { count = value; } }
		
	}
}
