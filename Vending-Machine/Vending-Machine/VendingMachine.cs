using System;
namespace Vending_Machine
{
    public class VendingMachine
    {
        public List<string> Menu { get; } = new List<string>
    {
<<<<<<< Updated upstream
        "choose products",
        "balance",
          "exit",
=======
        "products",
        "purchase",
        "balance",
        "help",
        "exit",
>>>>>>> Stashed changes


    };


        public void RunVendingMachine()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to VAT vending-machine!");
            string command;

            do
            {

                command = GetMenu();
<<<<<<< Updated upstream
                if(command=="choose products")
=======
                if (command == "products")
>>>>>>> Stashed changes
                {
                    ShowProducts();
                }
                else if (command == "purchase")
                {
                    PurchaseProduct();
                }
                else if (command == "balance")
                {
                    ShowBalance();

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

        public string ShowProducts()
        {
<<<<<<< Updated upstream
            
=======

        var ProductStock = new Inventory();
        var ProductPrices = new Inventory();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("VAT Products and current stock:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------");
            Console.ResetColor();
            foreach (var price in ProductPrices.Prices)
            {
                foreach (var name in ProductStock.Items)
                {
                    if (name.Key == price.Key)
                    {
                        if (name.Value != 0)
                        {
                            Console.Write($"{name.Key} {price.Value}$. Stock: ");
                            if (name.Value < 3)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else
                            {
                            Console.ForegroundColor = ConsoleColor.Green;
                            }
                            Console.WriteLine($"{name.Value}");
                            Console.ResetColor();
                        }
                    }
                }
            }
            Console.WriteLine();
>>>>>>> Stashed changes
        }
        

<<<<<<< Updated upstream
        
=======
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

                foreach (var product in Products)
                {
                    Console.Write($"{product.Key} ");
                }
                Console.Write(": ");
                choice = Console.ReadLine();
                Console.WriteLine();
                //Console.WriteLine(choice);

                foreach (var product in Products)
                {
                    if (choice == product.Key)
                    {
                        Console.Write($"You selected {product.Key}. Do you want to purchase it? {product.Value}$ (yes / no): ");
                        choice = Console.ReadLine();
                        Console.WriteLine();

                        if (choice == "yes")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Thank you for choosing VAT!");
                            Console.ResetColor();
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
>>>>>>> Stashed changes
    }
}

