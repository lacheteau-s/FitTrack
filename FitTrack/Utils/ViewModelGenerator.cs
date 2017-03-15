using System;
using System.Collections.Generic;

namespace FitTrack
{
	public static class ViewModelGenerator
	{
		// 17
		public static WorkoutViewModel GenerateLegsViewModel()
		{
			return new WorkoutViewModel
			{
				Name = "Legs",
				Exercises = new List<Exercise>
				{
					new Exercise
					{
						Name = "Leg press",
						Sets = "1 + 4",
						Reps = "20 + 1 to 6",
						Weights = "60 - 80 - 100 - 120 - 140"
					},
					new Exercise
					{
						Name = "Leg extensions",
						Sets = "4",
						Reps = "12 - 10 - 9 - 8",
						Weights = "50 - 55 - 59 - 64"
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
						Name = "Calf raises",
						Sets = "4",
						Reps = "15 - 12 - 12 - 10",
						Weights = "30 - 40 - 50 - 60"
					}
				}
			};
		}

		// 30
		public static WorkoutViewModel GenerateArmsViewModel()
		{
			return new WorkoutViewModel
			{
				Name = "Arms",
				Exercises = new List<Exercise>
				{
					new Exercise
					{
						Name = "Rope triceps extensions",
						Sets = "3",
						Reps = "15",
						Weights = "23 - 27 - 32"
					},
					new Exercise
					{
						Name = "Zottman curls",
						Sets = "3",
						Reps = "15",
						Weights = "6 - 8 - 10"
					},
					new Exercise
					{
						Name = "Skull crushers",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "2.5 + 4 + 5 + 6.5"
					},
					new Exercise
					{
						Name = "Barbell curls",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "23 - 27 - 32 - 36"
					},
					new Exercise
					{
						Name = "Behind neck dumbell extensions",
						Sets = "4",
						Reps = "10",
						Weights = "14 - 16 - 18 - 20"
					},
					new Exercise
					{
						Name = "Incline bench dumbell curls",
						Sets = "4",
						Reps = "10",
						Weights = "6 - 8 - 10 - 10"
					},
					new Exercise
					{
						Name = "Cross bench triceps dips",
						Sets = "4",
						Reps = "15 to 20",
						Weights = string.Empty
					},
					new Exercise
					{
						Name = "Concentration curls",
						Sets = "4",
						Reps = "10 to 12",
						Weights = "6 - 8 - 10 - 10"
					}
				}
			};
		}

		// 20
		public static WorkoutViewModel GenerateBackViewModel()
		{
			return new WorkoutViewModel
			{
				Name = "Back",
				Exercises = new List<Exercise>
				{
					new Exercise
					{
						Name = "Pull ups",
						Sets = "4",
						Reps = "15 to 20",
						Weights = "50 - 45 - 41 - 36"
					},
					new Exercise
					{
						Name = "One arm seated row",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "9 - 14 - 18 - 23"
					},
					new Exercise
					{
						Name = "One arm dumbell row",
						Sets = "4",
						Reps = "10 to 12",
						Weights = "12 - 14 - 16 - 18"
					},
					new Exercise
					{
						Name = "Straight arms pull downs",
						Sets = "4",
						Reps = "10 to 12",
						Weights = "27 - 32 - 36 - 41"
					},
					new Exercise
					{
						Name = "Tirage de barre en pronation",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = string.Empty
					}
				}
			};
		}

		// 21
		public static WorkoutViewModel GeneratePecsViewModel()
		{
			return new WorkoutViewModel
			{
				Name = "Pecs",
				Exercises = new List<Exercise>
				{
					new Exercise
					{
						Name = "Flat barbell press",
						Sets = "5",
						Reps = "25 - 15 - 10 - 12 - 8",
						Weights = "5 - 10 - 12.5 - 15 - 17.5"
					},
					new Exercise
					{
						Name = "Incline barbell press",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "5 - 7.5 - 10 - 12.5"
					},
					new Exercise
					{
						Name = "Dumbell fly",
						Sets = "4",
						Reps = "10 to 12",
						Weights = "8 - 10 - 10 - 12"
					},
					new Exercise
					{
						Name = "Weighted dips",
						Sets = "4",
						Reps = "10 to 15",
						Weights = "41 - 36 - 32 - 27"
					},
					new Exercise
					{
						Name = "Cable cross-overs",
						Sets = "4",
						Reps = "12",
						Weights = "11 - 14 - 16 - 18"
					}
				}
			};
		}

		// 23
		public static WorkoutViewModel GenerateShouldersViewModel()
		{
			return new WorkoutViewModel
			{
				Name = "Shoulders",
				Exercises = new List<Exercise>
				{
					new Exercise
					{
						Name = "Bradford press",
						Sets = "3",
						Reps = "20",
						Weights = "5 - 7.5 - 10"
					},
					new Exercise
					{
						Name = "Overhead press",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "5 - 7.5 - 10 - 12.5"
					},
					new Exercise
					{
						Name = "Lateral raises (seated)",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "6 - 8 - 10 - 10"
					},
					new Exercise
					{
						Name = "Bent over lateral raises",
						Sets = "4",
						Reps = "10",
						Weights = "6 - 8 - 10 - 10"
					},
					new Exercise
					{
						Name = "Upright rows",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "5 - 10 - 15 - 15"
					},
					new Exercise
					{
						Name = "Reverse upright rows",
						Sets = "4",
						Reps = "12 - 10 - 8 - 8",
						Weights = "5 - 10 - 15 - 20"
					}
				}
			};
		}
	}
}
