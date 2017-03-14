using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

		private async void OnWorkoutClicked(object sender, EventArgs e)
		{
			var workout = new Workout
			{
				Name = "Legs",
				Exercises = new ObservableCollection<Exercise>
				{
					new Exercise
					{
						Name = "Leg press",
						Sets = "1 + 4",
						Reps = "20 + 10 to 6",
						Weights = "60 - 80 - 100 - 120 - 140"
					},
					new Exercise
					{
						Name = "Leg extensions",
						Sets = "4",
						Reps = "12 - 10 - 9 - 8",
						Weights = "55 - 59 - 64 - 68"
					},
					new Exercise
					{
						Name = "Leg curls",
						Sets = "4",
						Reps = "12 - 10 - 9 - 8",
						Weights = "50 - 55 - 59 - 64"
					},
					new Exercise
					{
						Name = "Calves raises",
						Sets = "4",
						Reps = "15 - 12 - 12 - 10",
						Weights = "30 - 40 - 50 - 60"
					}
				}
			};

			await Navigation.PushAsync(new WorkoutPage(workout));
		}
	}

	public class Exercise
	{
		public string Name { get; set; }

		public string Sets { get; set; }

		public string Reps { get; set; }

		public string Weights { get; set; }
	}

	public class Workout
	{
		public string Name { get; set; }

		public ObservableCollection<Exercise> Exercises { get; set; }
	}

}
