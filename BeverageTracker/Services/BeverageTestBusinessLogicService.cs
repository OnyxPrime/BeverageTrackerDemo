using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
namespace BeverageTracker
{
	public class BeverageTestBusinessLogicService : IBeverageBusinessLogicService
	{
		IBeverageDataService dataService;

		public BeverageTestBusinessLogicService(IBeverageDataService dataService)
		{
			this.dataService = dataService;
		}

		public ObservableCollection<BeverageEventGroup> GetBeverageEventsGrouped()
		{
			var events = dataService.GetBeverageEvents().Where(x=>x.DrinkingDate > (DateTime.Now - TimeSpan.FromDays(7))).ToList();
			var groupedEvents = events.OrderByDescending(b => b.DrinkingDate)
									  .GroupBy(b => b.DrinkingDate.Date)
			                          .Select(b=> new BeverageEventGroup(b.Key.ToString("dddd - MM/dd"), b.Key.ToString("ddd"),b.OrderBy(x=>x.DrinkingDate)))
									  .ToList();
			var eventGroupCollection = new ObservableCollection<BeverageEventGroup>(groupedEvents);

			return eventGroupCollection;
		}

		public void AddBeverageEvent(BeverageEvent bevEvent)
		{
			dataService.AddEvent(bevEvent);
		}
	}
}

