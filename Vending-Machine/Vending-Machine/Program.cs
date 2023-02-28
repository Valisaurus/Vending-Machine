using Vending_Machine;

var food = new Inventory();
var Items = food.ItemName;

foreach (var item in Items)
{
    Console.WriteLine(item);
}
