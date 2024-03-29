public class MealPlanner : FitnessTracker
{
  public MealPlanner(int goalCalories, string goalWeight)
      : base(goalCalories, goalWeight)
  {

  }

  public override void PlanMeal()
  {
    Console.WriteLine("Planning meals based on weight goal...");
    Console.WriteLine($"Goal calories per week: {_GoalCalories}");
    Console.WriteLine($"Goal weight: {_GoalWeight}");

    Console.WriteLine("Created Meals:");
    foreach (Recipe meal in Meals)
    {
      Console.WriteLine($"{meal.Name}: {meal.Calories} calories");
    }
  }

  public string GetRandomRecipeLose()
  {
    string[] recipes = File.ReadAllLines("randommeallose.txt");
    Random random = new Random();
    int randomIndex = random.Next(0, recipes.Length);
    return recipes[randomIndex];
  }

  public string GetRandomRecipeGain()
  {
    Console.WriteLine("Generating meal suggestion...");



    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();
    string[] recipesgain = File.ReadAllLines("randommealgain.txt");
    Random random = new Random();
    int randomIndex = random.Next(0, recipesgain.Length);
    return recipesgain[randomIndex];
  }

  public List<Recipe> SuggestMealByIngredients(List<Recipe> recipes, List<string> ingredients)
  {
    Console.WriteLine("Suggesting a meal based on ingredients...");
    Console.WriteLine("Generating workout suggestion...");
    Thread.Sleep(2000); // Pause for 2 seconds

    Console.Write("Calculating");
    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();
    List<Recipe> suggestedMeal = new List<Recipe>();

    // Logic for suggesting a meal based on the provided ingredients and recipes

    return suggestedMeal;
  }

  public void SaveReceipts()
  {
    using (StreamWriter writer = new StreamWriter("receipts.txt"))
    {
      foreach (Recipe meal in Meals)
      {
        writer.WriteLine($"{meal.Name}:{meal.Calories}");
      }
    }

    Console.WriteLine("Receipts saved successfully!");
  }

  public void LoadReceipts()
  {
    Meals.Clear();

    string[] lines = File.ReadAllLines("receipts.txt");

    foreach (string line in lines)
    {
      string[] parts = line.Split(':');
      if (parts.Length == 2)
      {
        string name = parts[0].Trim();
        int calories = int.Parse(parts[1].Trim());

        Recipe meal = new Recipe { Name = name, Calories = calories };
        Meals.Add(meal);
      }
    }

    Console.WriteLine("Receipts loaded successfully!");

    if (Meals.Count > 0)
    {
      Console.WriteLine("Loaded Meals:");
      foreach (Recipe meal in Meals)
      {
        Console.WriteLine($"{meal.Name}: {meal.Calories} calories");
      }
    }
    else
    {
      Console.WriteLine("No meals found in the receipts.");
    }
  }

  public override void SetGoal()
  {
    Console.WriteLine("Set your weight goal:");
    Console.WriteLine("Enter goal calories per week:");
    int goalCalories = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter goal weight:");
    string goalWeight = Console.ReadLine();

    SetGoal(goalCalories);
    SetWeightGoal(goalWeight);
  }

  public override void SuggestWorkout()
  {
    Console.WriteLine("Suggesting workouts based on weight goal...");
    Console.WriteLine($"Goal calories per week: {_GoalCalories}");
    Console.WriteLine($"Goal weight: {_GoalWeight}");

    Console.WriteLine("Generating workout suggestion...");
    Thread.Sleep(2000); // Pause for 2 seconds

    Console.Write("Calculating");
    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();

    string[] workouts = File.ReadAllLines("workouttolose.txt");
    Random random = new Random();
    int randomIndex = random.Next(0, workouts.Length);
    string suggestedWorkout = workouts[randomIndex];

    Console.WriteLine($"Suggested Workout: {suggestedWorkout}");
  }
}