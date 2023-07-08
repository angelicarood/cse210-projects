public abstract class FitnessTracker
{
  protected int _GoalCalories { get; set; }
  protected string _GoalWeight { get; set; }
  protected List<Recipe> Meals { get; set; }

  public FitnessTracker(int goalCalories, string goalWeight)
  {
    _GoalCalories = goalCalories;
    _GoalWeight = goalWeight;
    Meals = new List<Recipe>();
  }

  public void SetGoal(int goalCalories)
  {
    _GoalCalories = goalCalories;
  }

  public void SetWeightGoal(string goalWeight)
  {
    _GoalWeight = goalWeight;
  }

  public void CreateMeal()
  {
    Console.WriteLine("Enter the name of the meal:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter the calorie count of the meal:");
    int calories = Convert.ToInt32(Console.ReadLine());

    Recipe meal = new Recipe { Name = name, Calories = calories };
    Meals.Add(meal);

    Console.WriteLine("Meal created successfully!");
  }

  public abstract void SetGoal();

  public abstract void PlanMeal();

  public abstract void SuggestWorkout();
}