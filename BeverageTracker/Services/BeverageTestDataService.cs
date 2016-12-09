using System;
using System.Collections.Generic;

namespace BeverageTracker
{
	public class BeverageTestDataService : IBeverageDataService
	{
		List<BeverageEvent> events;

		public BeverageTestDataService()
		{
			LoadTestEvents();
		}

		public void AddEvent(BeverageEvent beverageEvent)
		{
			events.Add(beverageEvent);
		}

		public List<BeverageEvent> GetBeverageEvents()
		{
			return events;
		}

		void LoadTestEvents()
		{
			events = new List<BeverageEvent>();
			events.AddRange(CreateTestEvents(DateTime.Now));
			events.AddRange(CreateTestEvents(DateTime.Now - TimeSpan.FromDays(1)));
			events.AddRange(CreateTestEvents(DateTime.Now - TimeSpan.FromDays(2)));
			events.AddRange(CreateTestEvents(DateTime.Now - TimeSpan.FromDays(3)));
			events.AddRange(CreateTestEvents(DateTime.Now - TimeSpan.FromDays(4)));
			events.AddRange(CreateTestEvents(DateTime.Now - TimeSpan.FromDays(5)));
			events.AddRange(CreateTestEvents(DateTime.Now - TimeSpan.FromDays(6)));
		}

		IEnumerable<BeverageEvent> CreateTestEvents(DateTime date)
		{ 
			return new List<BeverageEvent>()
			{
				new BeverageEvent() { BeverageType = Beverage.Coffee, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,8,0,0) },
				new BeverageEvent() { BeverageType = Beverage.Coffee, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,8,30,0) },
				new BeverageEvent() { BeverageType = Beverage.Coffee, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,9,30,0) },
				new BeverageEvent() { BeverageType = Beverage.Coffee, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,11,0,0) },
				new BeverageEvent() { BeverageType = Beverage.SodaPop, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,12,0,0) },
				new BeverageEvent() { BeverageType = Beverage.Water, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,14,0,0) },
				new BeverageEvent() { BeverageType = Beverage.Water, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,16,0,0) },
				new BeverageEvent() { BeverageType = Beverage.SodaPop, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,19,0,0) },
				new BeverageEvent() { BeverageType = Beverage.Water, DrinkingDate = new DateTime(date.Year, date.Month, date.Day,21,0,0) }
			};
		}
	}
}

