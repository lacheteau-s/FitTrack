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

		private bool _running = false;

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
		}

		private void OnStartStopClicked(object sender, EventArgs e)
		{
			if (!_running)
			{
				startStopButton.Text = "Stop";
				startStopButton.BackgroundColor = Color.Red;
				_running = true;
				Device.StartTimer(TimeSpan.FromMilliseconds(10), OnElapsed);
			}
			else
			{
				startStopButton.Text = "Start";
				startStopButton.BackgroundColor = Color.Lime;
				_running = false;
			}
		}

		private void OnResetClicked(object sender, EventArgs e)
		{
			Timer = TimeSpan.FromTicks(0);
			timerLabel.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", Timer);
		}

		private bool OnElapsed()
		{
			Timer = Timer.Add(TimeSpan.FromMilliseconds(10));
			timerLabel.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", Timer);
			return _running;
		}
	}
}
