using System;
using Vending_Machine;
namespace Vending_Machine
{
    public class Inventory
    {

        public Inventory()
        {

        }

        public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int>
        {
            {"Japp", 10},
            {"Daim", 10},
            {"Sour-cream & Onion", 10},
            {"Coca-cola", 10},
            {"Fanta", 10},
            {"Sprite", 0},
            {"Kebab", 0},
            {"Fesk", 1}
        };

        public Dictionary<string, int> Prices { get; set; } = new Dictionary<string, int>
        {
            {"Japp", 5},
            {"Daim", 4},
            {"Sour-cream & Onion", 4},
            {"Coca-cola", 3},
            {"Fanta", 3},
            {"Sprite", 3},
            {"Kebab", 8},
            {"Fesk", 10}
        };



        //public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int>
        //{
<<<<<<< Updated upstream
        //             {"japp", 10},
        //             {"daim", 10},
        //             {"sour cream onion", 10},
        //             {"coca cola", 10},
        //             {"fanta", 10},
        //             {"sprite", 10},
=======
        //             "japp",
        //             "daim",
        //             "sour cream onion",
        //             "coca cola",
        //             "fanta",
        //             "sprite",
        //};

        //public List<int> Prices { get; set; } = new List<int>
        //{
        //    2, 2, 5, 7, 2, 3,
>>>>>>> Stashed changes

        //};
    }
}





