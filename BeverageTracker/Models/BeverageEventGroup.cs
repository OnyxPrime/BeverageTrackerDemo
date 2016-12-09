using System;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace BeverageTracker
{
	public class BeverageEventGroup : ObservableCollection<BeverageEvent>
	{
		public String Name { get; private set; }
		public String ShortName { get; private set; }

		public BeverageEventGroup(String Name, String ShortName, IEnumerable<BeverageEvent> items)
			:base(items)
		{
			this.Name = Name;
			this.ShortName = ShortName;
		}
	}
}

