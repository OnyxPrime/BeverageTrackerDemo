using System;
namespace BeverageTracker
{
	public class ServiceLocator
	{
		private static ServiceLocator instance = new ServiceLocator();
		public static ServiceLocator Instance => instance;

		private ServiceLocator()
		{
		}

		IBeverageBusinessLogicService blService;
		IBeverageDataService dataService;

		public IBeverageDataService BevDataService
		{
			get
			{
				if (dataService == null)
					dataService = new BeverageTestDataService();
				return dataService;
			}
		}

		public IBeverageBusinessLogicService BevBusinessLogicService
		{
			get
			{
				if (blService == null)
					blService = new BeverageTestBusinessLogicService(BevDataService);
				return blService;
			}
		}
	}
}

