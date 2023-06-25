using System;

class Program
{
  static void Main(string[] args)
  {
    GoalManager goalManager = new GoalManager();
    bool quit = false;

    while (!quit)
    {
      Console.WriteLine("Eternal Quest Program");
      Console.WriteLine("Score: " + goalManager.GetScore());
      Console.WriteLine("1. Create a new goal");
      Console.WriteLine("2. List all goals");
      Console.WriteLine("3. Save goals");
      Console.WriteLine("4. Load goals");
      Console.WriteLine("5. Record events");
      Console.WriteLine("6. Quit");

      Console.Write("Enter your choice: ");
      int choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1:
          Console.WriteLine("Select the type of goal to create:");
          Console.WriteLine("1. Simple Goal");
          Console.WriteLine("2. Eternal Goal");
          Console.WriteLine("3. Checklist Goal");

          Console.Write("Enter your choice: ");
          int goalType = int.Parse(Console.ReadLine());

          Console.Write("Enter the name of the goal: ");
          string name = Console.ReadLine();

          Console.Write("Enter the description of the goal: ");
          string description = Console.ReadLine();

          Console.Write("Enter the value/points for completing the goal: ");
          int value = int.Parse(Console.ReadLine());

          switch (goalType)
          {
            case 1:
              goalManager.AddGoal(new Simple(name, description, value));
              break;
            case 2:
              goalManager.AddGoal(new Eternal(name, description, value));
              break;
            case 3:
              Console.Write("Enter the required count for the checklist goal: ");
              int requiredCount = int.Parse(Console.ReadLine());
              goalManager.AddGoal(new Checklist(name, description, value, requiredCount));
              break;
          }
          break;

        case 2:
          goalManager.DisplayGoals();
          break;

        case 3:
          Console.Write("Enter the filename to save the goals: ");
          string saveFilename = Console.ReadLine();
          goalManager.SaveGoals(saveFilename);
          break;

        case 4:
          Console.Write("Enter the filename to load the goals: ");
          string loadFilename = Console.ReadLine();
          goalManager.LoadGoals(loadFilename);
          break;

        case 5:
          goalManager.DisplayGoals();
          Console.Write("Enter the index of the goal to record an event: ");
          int goalIndex = int.Parse(Console.ReadLine());
          goalManager.RecordGoal(goalIndex - 1);
          break;

        case 6:
          quit = true;
          break;

        default:
          Console.WriteLine("Invalid choice. Please try again.");
          break;
      }

      Console.WriteLine();
    }

    Console.WriteLine("Thank you for using the Eternal Quest program!");
  }
}

