using Vending_Machine;

var vendingMachine = new VendingMachine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Welcome to VAT vending-machine! Please enter ID.");
Console.ResetColor();

string? input = null;
while (input == null || input == "")
{
    if (input == "")
    {
    Console.WriteLine("Not a valid ID, please try again.");
    }
input = Console.ReadLine();
}
var customer = new User(input, 10);

vendingMachine.RunVendingMachine(customer);


