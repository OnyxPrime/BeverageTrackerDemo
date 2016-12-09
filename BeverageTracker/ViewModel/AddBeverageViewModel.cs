using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeverageTracker
{
	public class AddBeverageViewModel
	{
		INavigation navigation;
		IBeverageBusinessLogicService blService;
		public List<Beverage> BeverageTypes => Beverage.List().ToList();
		public string SelectedBeverageType { get; set; }
		public DateTime DrinkingDate { get; set; }
		public ICommand AddBeverageCommand { get; private set; }


		public AddBeverageViewModel(INavigation navigation, IBeverageBusinessLogicService blService)
		{
			DrinkingDate = DateTime.Now;
			this.navigation = navigation;
			this.blService = blService;
			AddBeverageCommand = new Command(AddBeverage);
		}

		async void AddBeverage()
		{
			var x = BeverageTypes.FirstOrDefault((arg) => arg.Name == SelectedBeverageType);
			this.blService.AddBeverageEvent(new BeverageEvent() { BeverageType = x, DrinkingDate = DrinkingDate });
			await navigation.PopAsync();
		}
	}
}

