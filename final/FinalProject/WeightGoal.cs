public class WeightGoal : FitnessTracker
{
  public WeightGoal(int goalCalories, string goalWeight)
      : base(goalCalories, goalWeight)
  {

  }

  public override void SetGoal()
  {
    Console.WriteLine("Set your weight goal:");
    Console.WriteLine("Enter goal calories per week:");
    int goalCalories = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter goal weight:");
    string goalWeight = Console.ReadLine();

    _GoalCalories = goalCalories;
    _GoalWeight = goalWeight;
  }

  public override void PlanMeal()
  {
    Console.WriteLine("Planning meals based on weight goal...");
    Console.WriteLine($"Goal calories per week: {_GoalCalories}");
    Console.WriteLine($"Goal weight: {_GoalWeight}");
    // Additional meal planning logic...
  }

  public override void SuggestWorkout()
  {
    Console.WriteLine("Suggesting workouts based on weight goal...");
    Console.WriteLine($"Goal calories per week: {_GoalCalories}");
    Console.WriteLine($"Goal weight: {_GoalWeight}");
    // Additional workout suggestion logic...
  }
}
