using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLlttq.Classes
{
	public class Bill
	{
		public Bill(int id, DateTime? datecheckin, DateTime? datecheckout, int status, int tongtien=0,int discount = 0) {
			this.id = id;
			this.datecheckin = datecheckin;
			
			this.datecheckout = datecheckout;
			this.status = status;
			this.discount = discount;
			this.tongtien = tongtien;
		}
		public Bill(DataRow row)
		{
			this.Id = (int)row["id"];
			this.datecheckin = (DateTime?)row["datecheckin"];
			var datecheckout = row["datecheckout"];
			if (datecheckout.ToString() != "")
				this.datecheckout = (DateTime?)datecheckout;
			this.status = (int)row["status"];
			this.discount = (int)row["discount"];
			this.tongtien = (int)row["TongTien"];
		}

		private int id;
		private DateTime? datecheckin;
		private DateTime? datecheckout;
		private int status;
		private int discount;
		private int tongtien;
		public int TongTien { get {  return tongtien; } set { tongtien = value; } }
		public int Discount { get { return discount; } set { discount = value; } }
		public int Id { get { return id; } set { id = value; } }
		public DateTime? Datecheckin { get {  return datecheckin; } set {  datecheckin = value; } }
		public DateTime? Datecheckout { get {  return datecheckout; } set { datecheckout = value; } }
		public int Status { get { return status; } set { status = value; } }
	}
}
