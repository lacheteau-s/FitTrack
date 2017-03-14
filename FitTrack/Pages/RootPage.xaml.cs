using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FitTrack
{
	public partial class RootPage : ContentPage
	{
		public RootPage()
		{
			InitializeComponent();
		}

		private async void OnRoutineClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RoutinePage());
		}
	}
}
