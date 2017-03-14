using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FitTrack
{
	public partial class WorkoutPage : ContentPage
	{
		private Workout Workout;

		public ObservableCollection<Exercise> Exercises;

		public WorkoutPage(Workout workout)
		{
			Title = workout.Name;
			Workout = workout;
			Exercises = new ObservableCollection<Exercise>(workout.Exercises);
			InitializeComponent();
			listView.ItemsSource = Exercises;
		}
	}
}
