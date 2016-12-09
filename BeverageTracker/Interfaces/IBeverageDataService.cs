using System;
using System.Collections.Generic;
namespace BeverageTracker
{
	public interface IBeverageDataService
	{
		List<BeverageEvent> GetBeverageEvents();
		void AddEvent(BeverageEvent beverageEvent);
	}
}

