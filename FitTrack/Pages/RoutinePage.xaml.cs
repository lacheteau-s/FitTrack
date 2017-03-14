using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FitTrack
{
	public partial class RoutinePage : ContentPage
	{
		public RoutinePage()
		{
			Title = "Workouts";
			NavigationPage.SetBackButtonTitle(this, string.Empty);
			InitializeComponent();
		}

		private void OnWorkoutClicked(object sender, EventArgs e)
		{
			
		}
	}
}
