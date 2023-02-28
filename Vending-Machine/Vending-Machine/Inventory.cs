using System;
using Vending_Machine;
namespace Vending_Machine
{
	public class Inventory

	{
		private string ItemName { get; set; }
        private int ItemInventory { get; set; }

        public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int>
        {
            {"japp", 10},
                     {"daim", 10},
                     {"sour cream onion", 10},
                     {"coca cola", 10},
                     {"fanta", 10},
                     {"sprite", 10},

        };

        public Inventory()
		{
	
		}


	}

  
}





