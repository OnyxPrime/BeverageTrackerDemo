using System;
using System.Diagnostics.Contracts;
namespace BeverageTracker
{
	public class BeverageEvent
	{
		public Beverage BeverageType { get; set; }
		public DateTime DrinkingDate { get; set; }
	}
}

