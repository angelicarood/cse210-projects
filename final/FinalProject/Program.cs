class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Fitness Tracker!");




    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();

    Console.WriteLine("Do you want to lose weight or gain weight? (Lose/Gain)");
    string weightGoal = Console.ReadLine();



    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();

    Console.WriteLine("Enter your desired calorie intake per week:");
    int calorieGoal = Convert.ToInt32(Console.ReadLine());

    FitnessTracker fitnessTracker;

    if (weightGoal.ToLower() == "lose")
    {
      fitnessTracker = new MealPlanner(calorieGoal, "Lose");
    }
    else if (weightGoal.ToLower() == "gain")
    {
      fitnessTracker = new MealPlanner(calorieGoal, "Gain");
    }
    else
    {
      Console.WriteLine("Invalid choice. Exiting program.");
      return;
    }
    for (int i = 0; i < 5; i++)
    {
      Thread.Sleep(500); // Pause for half a second
      Console.Write(".");
    }
    Console.WriteLine();

    bool isRunning = true;

    while (isRunning)
    {
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("1. Create a meal");
      Console.WriteLine("2. Plan your meals");
      Console.WriteLine("3. Get a random recipe");
      Console.WriteLine("4. Suggest a workout");
      Console.WriteLine("5. Save receipts");
      Console.WriteLine("6. Load receipts");
      Console.WriteLine("7. Quit");
      Console.WriteLine("Enter your choice (1-7):");

      int choice = Convert.ToInt32(Console.ReadLine());

      switch (choice)
      {
        case 1:
          fitnessTracker.CreateMeal();
          break;
        case 2:
          fitnessTracker.PlanMeal();
          break;
        case 3:
          if (weightGoal.ToLower() == "lose")
          {
            string randomRecipeLose = ((MealPlanner)fitnessTracker).GetRandomRecipeLose();
            Console.WriteLine("Random Recipe for Losing Weight:");
            Console.WriteLine(randomRecipeLose);
          }
          else if (weightGoal.ToLower() == "gain")
          {
            string randomRecipeGain = ((MealPlanner)fitnessTracker).GetRandomRecipeGain();
            Console.WriteLine("Random Recipe for Gaining Weight:");
            Console.WriteLine(randomRecipeGain);
          }
          break;
        case 4:
          fitnessTracker.SuggestWorkout();
          break;
        case 5:
          ((MealPlanner)fitnessTracker).SaveReceipts();
          break;
        case 6:
          ((MealPlanner)fitnessTracker).LoadReceipts();
          break;
        case 7:
          isRunning = false;
          Console.WriteLine("Exiting program.");
          break;
        default:
          Console.WriteLine("Invalid choice.");
          break;
      }
    }
  }
}