using System;
namespace Vending_Machine
{
	public class VendingMachine
	{
		  public List<string> Commands { get; } = new List<string>
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

