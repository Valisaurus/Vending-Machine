using System;
using System.Xml.Linq;

namespace Vending_Machine
{
    public class VendingMachine
    {

        public List<string> Menu { get; } = new List<string>
        {
        "products",
        "purchase",
        "balance",
        "help",
        "exit",
        };

        private List<Product> ListOfProducts { get; } = new List<Product>
    {

        new Product("Apple", 2, 10),
        new Product("Banan", 3, 10),
        new Product("Apple", 2, 10),
        new Product("Chips", 4, 10),
        new Product("Korv", 6, 10),
        new Product("Kebab", 7, 5),
        new Product("Fisk", 5, 2),

    };

        public void RunVendingMachine()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to VAT vending-machine!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("------------ MENU ------------");
            foreach (var menuOption in Menu)
            {
                Console.WriteLine(menuOption);

            }

            Console.WriteLine("------------------------------");
            string command;

            do
            {

                command = GetMenu();

                if (command == "products")
                {
                    ShowProducts();
                }
                else if (command == "purchase")
                {
                    PurchaseProduct();
                }
                else if (command == "balance")
                {
                    //ShowBalance();

                }
                else if (command == "help")
                {
                    ListHelp();
                }

            }

            while (command != "exit");

        }

        public string GetMenu()
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Please choose an option from the menu or 'help'");
                Console.ResetColor();
                var input = Console.ReadLine();
                
                if (Menu.Contains(input))
                {
                    Console.WriteLine();
                    return input;
                }
            }
        }

        public void ShowProducts()
        {

            var ProductStock = new Inventory();
            var ProductPrices = new Inventory();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("VAT Products and current stock:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------");
            Console.ResetColor();

            foreach (var product in ListOfProducts)
            {
                if (product.Stock != 0)
                {
                    Console.Write($"{product.Name} {product.Price}$. Stock: ");
                    if (product.Stock < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine($"{product.Stock}");
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
        }

        public void PurchaseProduct()
        {
            //var Stock = new Inventory().Items;
            var Products = new Inventory().Prices;
            string choice = null;
            //selection = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Select a product from the list:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------");
            Console.ResetColor();

            while (choice == null)
            {

                foreach (var product in ListOfProducts)
                {
                    Console.Write($"{product.Name} ");
                }
                Console.Write(": ");
                choice = Console.ReadLine();
                Console.WriteLine();
                //Console.WriteLine(choice);

                foreach (var product in ListOfProducts)
                {
                    if (choice == product.Name)
                    {
                        var productChoice = choice;

                        Console.Write($"You selected {product.Name}. Do you want to purchase it? {product.Price}$ (yes / no): ");
                        choice = Console.ReadLine();
                        Console.WriteLine();

                        if (choice == "yes")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Thank you for choosing VAT!");
                            Console.ResetColor();
                            AdjustStock(productChoice);
                        }

                        if (choice == "no")
                        {
                            choice = null;
                        }
                    }

                }

                Console.WriteLine();

            }
        }

        public void AdjustStock(string inputChoice)
        {
            //var ProductStock = new Inventory().Items;

            foreach (var product in ListOfProducts)
            {
                int newValue = product.Stock - 1;
                if (inputChoice == product.Name)
                {

                    product.Stock = newValue;

                }
            }
        }


        public void ListHelp()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("         Menu Selection");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------");
            Console.ResetColor();

            foreach (var menuItem in Menu)
            {
                if (menuItem != "help")
                {
                    Console.WriteLine(menuItem);
                }
            }

            Console.WriteLine();
        }
    }
}