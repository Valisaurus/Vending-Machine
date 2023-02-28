using System;
using Vending_Machine;
namespace Vending_Machine
{
	public class Inventory

	{

        public List<string> ItemName { get; set; } = new List<string>
        {
            "japp",
            "daim",
            "sourcream onion",
            "coca cola",
            "fanta",
            "sprite"

        };
        public List<int> ItemInventory { get; set; } = new List<int>
        {
           10,
           10,
           10,
           10,
           10,
           10,
        };

        public List<int> ItemPrice { get; set; } = new List<int>
        {
           5,
           5,
           5,
           5,
           5,
           5,
        };



        
        public Inventory()
		{
            
	
		}




        //public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int>
        //{
        //             {"japp", 10},
        //             {"daim", 10},
        //             {"sour cream onion", 10},
        //             {"coca cola", 10},
        //             {"fanta", 10},
        //             {"sprite", 10},

        //};

    }


    

}





