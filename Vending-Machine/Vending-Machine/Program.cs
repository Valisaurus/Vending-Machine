using Vending_Machine;

var vendingMachine = new VendingMachine();

Console.WriteLine("Welcome to vending machine. Enter customer ID:");
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


