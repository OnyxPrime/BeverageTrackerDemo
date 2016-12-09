using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BeverageTracker.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[TestFixtureSetUp]
		public void BeforeFirstTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		//[SetUp]
		//public void BeforeEachTest()
		//{
		//	app = AppInitializer.StartApp(platform);
		//}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}

		[Test]
		public void AddBeverageTest()
		{
			app.Tap("Add Beverage");
			app.Screenshot("Add Beverage Screen");
			if (platform == Platform.Android)
			{
				app.Tap(c => c.Class("PickerRenderer"));
				app.Tap("Water");
			}
			else
			{
				app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_PickerRenderer"));
				app.Tap("Water");
				app.Tap("Done");
			}
			app.Tap("Add Beverage");
			app.Screenshot("Beverage Added");

		}
	}
}

