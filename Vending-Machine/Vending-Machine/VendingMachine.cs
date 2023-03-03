using System;
namespace Vending_Machine
{


    public class VendingMachine
    {
        public List<string> Menu { get; } = new List<string>
    {
        "choose products",
        "balance",
          "exit",


    };

        public static void Products()
        {
            List<Product> Products = new List<Product>();

            Products.Add(new Product("Apple", 2, 10));
            Products.Add(new Product("Chips", 4, 10));
            Products.Add(new Product("Korv", 6, 10));
            Products.Add(new Product("Kebab", 7, 10));
            Products.Add(new Product("Fisk", 5, 10));

        }





        public void RunVendingMachine()
        {
            Console.WriteLine("Welcome to VAT vending-machine! Choose an item");
            string command;

            do
            {

                command = GetMenu();
                if(command=="choose products")
                {
                    ShowProducts();
                }
                else if (command=="balance")
                {
                    ShowBalance();

                }

            }

            while (command != "exit");
            
        }

        public string GetMenu()
        {
            while (true)
            {
                Console.WriteLine("Please choose an option from the menu");
                var input = Console.ReadLine();

                if (Menu.Contains(input))
                {
                    Console.WriteLine("hej");
                    return input;
                }
            }


        }

        public string ShowProducts()
        {
            foreach(var Product in Products)
            {
                Console.WriteLine(Product);
            }
        }
        

        
    }




}

