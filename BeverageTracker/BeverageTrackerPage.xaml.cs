using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeverageTracker
{
	public partial class BeverageTrackerPage : ContentPage
	{
		public BeverageTrackerPage()
		{
			InitializeComponent();
			var vm = new BeverageTrackerViewModel(Navigation, ServiceLocator.Instance.BevBusinessLogicService);
			this.BindingContext = vm;
			this.Appearing += (sender, e) =>
			 {
				 vm.LoadData();
			 };
		}
	}
}

