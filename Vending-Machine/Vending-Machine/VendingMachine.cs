﻿using System;
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

        

        
    }


}

