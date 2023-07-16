public class WorkoutSuggestion : FitnessTracker
{
  private static readonly Random random = new Random();

  public WorkoutSuggestion(int goalCalories, string goalWeight)
      : base(goalCalories, goalWeight)
  {
  }

  public string GetRandomWorkoutLose()

  {
    Console.WriteLine("Generating workout suggestion...");
    Thread.Sleep(2000); // Pause for 2 seconds

    Console.Write("Calculating");
    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();
    string[] workoutLoseLines = File.ReadAllLines("workouttolose.txt");
    string workoutLose = SelectRandomItem(workoutLoseLines);
    string[] workoutLoseItems = workoutLose.Split('.');
    string randomWorkout = SelectRandomItem(workoutLoseItems);
    return randomWorkout.Trim();
  }

  public string GetRandomWorkoutGain()
  {
    Console.WriteLine("Generating workout suggestion...");
    Thread.Sleep(2000); // Pause for 2 seconds

    Console.Write("Calculating");
    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();
    string[] workoutGainLines = File.ReadAllLines("workouttogain.txt");
    string workoutGain = SelectRandomItem(workoutGainLines);
    string[] workoutGainItems = workoutGain.Split('.');
    string randomWorkout = SelectRandomItem(workoutGainItems);
    return randomWorkout.Trim();
  }

  private string SelectRandomItem(string[] items)
  {
    int randomIndex = random.Next(items.Length);
    return items[randomIndex];
  }

  public override void SetGoal()
  {
    throw new NotImplementedException();
  }

  public override void PlanMeal()
  {
    throw new NotImplementedException();
  }

  public override void SuggestWorkout()
  {
    throw new NotImplementedException();
  }
}