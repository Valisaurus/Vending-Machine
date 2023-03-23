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
        "receipt",
        "help",
        "exit",
        };

        private List<Product> ListOfProducts { get; } = new List<Product>
    {

        new Product("Apple", 2, 10),
        new Product("Banana", 3, 10),
        new Product("Granola bar", 2, 10),
        new Product("Crisps", 4, 10),
        new Product("Korv", 6, 10),
        new Product("Kebab", 7, 5),
        new Product("Fisk", 5, 2),

    };

        public List<Product> Receipt { get; set; } = new List<Product> { };

        public void RunVendingMachine(User customer)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Welcome {customer.Name}");
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
                    PurchaseProduct(customer);
                }
                else if (command == "balance")
                {
                    ShowBalance(customer);
                }
                else if (command == "receipt")
                {
                    ShowReceipt();
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
                    Console.Write($"{product.Name}, stock: ");
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

        public void PurchaseProduct(User customer)
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
                    Console.WriteLine($"{product.Name}: ${product.Price}");
                }
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
                            if (customer.ShowBalance() >= product.Price)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Thank you for choosing VAT!");
                                Console.ResetColor();
                                AdjustStock(productChoice);
                                customer.UpdateWallet(product.Price);
                                Console.WriteLine("You have "+customer.ShowBalance() + " dollars left.");


                                Receipt.Add(product);

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

        public void ShowBalance(User customer)
        {
            Console.WriteLine($"Current balance of {customer.Name}: ${customer.ShowBalance()}");
        }


        public void ShowReceipt() {
            if (Receipt.Count == 0)
            {
                Console.WriteLine("You haven't purchased anything yet.");
            }
            else
            {
            Console.WriteLine("Receipt:\n");
            foreach (var product in Receipt)
            {
                Console.WriteLine($"{product.Name}, ${product.Price}");
            }
            int totalPrice = Receipt.Sum(product => product.Price);
            Console.WriteLine($"\nTotal: ${totalPrice}");
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