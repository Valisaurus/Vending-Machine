using System;
namespace Vending_Machine
{
	public class User
	{
		public string Name { get; set; }
		private int Wallet { get; set; }

		public User(string name, int wallet) 
		{
			Name = name;
			Wallet = wallet;
		}

		public int ShowBalance()
		{
			return this.Wallet;
		}

		public void UpdateWallet(int price)
		{
			this.Wallet -= price;
		}

	}
}

