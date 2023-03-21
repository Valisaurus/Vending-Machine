using System;
namespace Vending_Machine
{
	public class Product
	{

        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Product (string Name, int Price, int Stock)
		{
			this.Name = Name;
			this.Price = Price;
			this.Stock = Stock;
		}
	}
}

