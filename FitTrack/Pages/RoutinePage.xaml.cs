using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FitTrack
{
	public partial class RoutinePage : ContentPage
	{
		private Dictionary<Button, WorkoutViewModel> _workouts;

		public RoutinePage()
		{
			Title = "Workouts";
			NavigationPage.SetBackButtonTitle(this, string.Empty);
			InitializeComponent();

			_workouts = new Dictionary<Button, WorkoutViewModel>
			{
				{ button1, ViewModelGenerator.GenerateLegsViewModel() },
				{ button2, ViewModelGenerator.GenerateBackViewModel() },
				{ button3, ViewModelGenerator.GeneratePecsViewModel() },
				{ button4, ViewModelGenerator.GenerateArmsViewModel() },
				{ button5, ViewModelGenerator.GenerateShouldersViewModel() }
			};
		}

		private async void OnWorkoutClicked(object sender, EventArgs e)
		{
			
			await Navigation.PushAsync(new WorkoutPage(_workouts[(Button)sender]));
		}
	}
}
