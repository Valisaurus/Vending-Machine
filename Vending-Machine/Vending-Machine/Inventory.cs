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
    }
}