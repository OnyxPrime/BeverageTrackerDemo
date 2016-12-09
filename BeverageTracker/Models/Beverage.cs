using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BeverageTracker
{
	public class Beverage
	{
		public static Beverage SodaPop { get; } = new Beverage(0, "Soda Pop");
		public static Beverage Coffee { get; } = new Beverage(1, "Coffee");
		public static Beverage Water { get; } = new Beverage(2, "Water");
		public static Beverage Juice { get; } = new Beverage(3, "Juice");

		public string Name { get; private set; }
		public int Value { get; private set; }

		public Beverage(int val, string name)
		{
			this.Name = name;
			this.Value = val;
		}

		public static IEnumerable<Beverage> List()
		{
			return new[] { SodaPop, Coffee, Water, Juice };
		}

		public Beverage FromString(string beverageString)
		{
			return List().FirstOrDefault(b => String.Equals(b.Name, beverageString));
		}

		public Beverage FromValue(int value)
		{
			return List().FirstOrDefault(b => b.Value == value);
		}

		public override string ToString()
		{
			return string.Format("{0}", Name);
		}
	}
}

