using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BeverageTracker
{
	public class BeverageTrackerViewModel : INotifyPropertyChanged
	{
		IBeverageBusinessLogicService blService;
		INavigation navigation;

		public event PropertyChangedEventHandler PropertyChanged;


		private ObservableCollection<BeverageEventGroup> events;
		public ObservableCollection<BeverageEventGroup> Events 
		{ 
			get { return events; } 
			set
			{
				events = value;
				RaisePropertyChanged(nameof(Events));
			}
		}
		public ICommand AddEventCommand { get; private set; }

		public BeverageTrackerViewModel(INavigation navigation, IBeverageBusinessLogicService blService)
		{
			this.blService = blService;
			this.navigation = navigation;
			LoadData();
		}

		public void LoadData()
		{
			Events = blService.GetBeverageEventsGrouped();
			AddEventCommand = new Command(AddEvent);
		}

		async void AddEvent()
		{
			await navigation.PushAsync(new AddBeveragePage());
		}

		private void RaisePropertyChanged(string name)
		{
			if (PropertyChanged != null)
				PropertyChanged(null, new PropertyChangedEventArgs(name));
		}
	}

}

