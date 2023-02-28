using System;
namespace Vending_Machine
{
	public class VendingMachine
	{
		  public List<string> CustomerCommands { get; } = new List<string>
    {
		"choose",
        "amount",
        "pay"
    };
		public VendingMachine()
		{

		}
	}
}

