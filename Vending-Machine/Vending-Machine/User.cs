using System;
namespace Vending_Machine
{
	public class User
	{
		public string Name { get; set; }
		public int Wallet { get; set; }

		public User(string Name, int Wallet) 
		{
			this.Name = Name;
			this.Wallet = Wallet;
		}
	}
}

