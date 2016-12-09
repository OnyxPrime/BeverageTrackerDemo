using System;
using System.Collections.ObjectModel;

namespace BeverageTracker
{
	public class BeverageBuisnessLogicService : IBeverageBusinessLogicService
	{
		public BeverageBuisnessLogicService(IBeverageDataService dataservice)
		{
		}

		public void AddBeverageEvent(BeverageEvent bevEvent)
		{
			throw new NotImplementedException();
		}

		public ObservableCollection<BeverageEventGroup> GetBeverageEventsGrouped()
		{
			throw new NotImplementedException();
		}
	}
}

