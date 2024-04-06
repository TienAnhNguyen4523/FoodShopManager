using System.Data;

namespace BTLlttq.Classes
{
	public class Account
	{
		private string username;
		private string password;
		private string displayname;
		private int type;

		

		public Account(string username, string password, string displayname, int type)
		{
			this.username = username;
			this.Password = password;
			this.displayname = displayname;
			this.type = type;
		}
		public Account(DataRow row)
		{
			this.username = row["username"].ToString();
			this.password = row["password"].ToString();
			this.displayname = row["displayname"].ToString();
			this.type = (int)row["type"];
		}

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Displayname { get => displayname; set => displayname = value; }
		public int Type { get => type; set => type = value; }
	}
}
