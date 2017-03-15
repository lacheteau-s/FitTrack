using System;
using System.Collections.Generic;

namespace FitTrack
{
	public class WorkoutViewModel
	{
		public string Name { get; set; }

		public IReadOnlyList<Exercise> Exercises { get; set; }
	}

	public class Exercise
	{
		public string Name { get; set; }

		public string Sets { get; set; }

		public string Reps { get; set; }

		public string Weights { get; set; }
	}
}
