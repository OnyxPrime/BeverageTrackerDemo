using System;
using System.Collections.ObjectModel;

namespace BeverageTracker
{
	public interface IBeverageBusinessLogicService
	{
		ObservableCollection<BeverageEventGroup> GetBeverageEventsGrouped();
		void AddBeverageEvent(BeverageEvent bevEvent);
	}
}

