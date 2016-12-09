using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeverageTracker
{
	public partial class AddBeveragePage : ContentPage
	{
		public AddBeveragePage()
		{
			InitializeComponent();
			var blService = ServiceLocator.Instance.BevBusinessLogicService;
			var vm = new AddBeverageViewModel(Navigation, blService);
			BindingContext = vm;
		}
	}
}
