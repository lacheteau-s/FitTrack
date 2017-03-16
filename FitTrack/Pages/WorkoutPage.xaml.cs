using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Xamarin.Forms;

namespace FitTrack
{
	public partial class WorkoutPage : ContentPage
	{
		private WorkoutViewModel Workout;

		public TimeSpan Timer { get; set; }

		public ObservableCollection<Exercise> Exercises;

		public WorkoutPage(WorkoutViewModel workout)
		{
			Title = workout.Name;
			Workout = workout;
			Exercises = new ObservableCollection<Exercise>(workout.Exercises);
			InitializeComponent();
			listView.ItemsSource = Exercises;
			Timer = TimeSpan.FromTicks(0);

			Xamarin.Forms.Device.StartTimer(TimeSpan.FromMilliseconds(10), () => 
			{
				Timer = Timer.Add(TimeSpan.FromMilliseconds(10));
				timerLabel.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", Timer);
				return true; // false to stop timer
			});
		}
	}
}
