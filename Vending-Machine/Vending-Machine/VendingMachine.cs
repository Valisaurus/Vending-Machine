using System;
using System.Xml.Linq;

namespace Vending_Machine
{
    public class VendingMachine
    {

        public User Customer { get; set; } = new User("Tomer", 10);

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

        public void RunVendingMachine(User customer)
        {
            Console.WriteLine(customer.Name + " " + customer.ShowBalance() + '\n');
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

        public void ShowProducts()
        {
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
            string choice = null;

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
                            if (Customer.ShowBalance() >= product.Price)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Thank you for choosing VAT!");
                                Console.ResetColor();
                                AdjustStock(productChoice);
                                Customer.UpdateWallet(product.Price);
                                Console.WriteLine("You have "+Customer.ShowBalance() + " dollars left.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Sorry mate, you have insufficient funds.");
                                Console.ResetColor();
                            }

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
            foreach (var product in ListOfProducts)
            {
                int newValue = product.Stock - 1;
                if (inputChoice == product.Name)
                {

                    product.Stock = newValue;

                }
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"${Customer.ShowBalance()}");
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