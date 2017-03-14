using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FitTrack
{
	public partial class RoutinePage : ContentPage
	{
		public RoutinePage()
		{
			Title = "Select a workout";
			NavigationPage.SetBackButtonTitle(this, string.Empty);
			InitializeComponent();
		}
	}
}
