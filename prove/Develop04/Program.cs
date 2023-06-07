using System;

class Program
{
  static void Main(string[] args)
  {
    string userOption = "";

    while (userOption != "4")
    {
      Console.WriteLine("Menu options:");
      Console.WriteLine();
      Console.WriteLine("(1) Start breathing activity");
      Console.WriteLine("(2) Start reflection activity");
      Console.WriteLine("(3) Start listing activity");
      Console.WriteLine("(4) Quit");
      Console.WriteLine();
      Console.WriteLine("Select a choice from the menu");
      userOption = Console.ReadLine();
      Console.WriteLine();

      switch (userOption)
      {
        case "1":
          Breathing breathingActivity = new Breathing(
              "Breathing Activity\n",
              0,
              "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n",
              "Breathe in...",
              "Breathe out..."
          );
          breathingActivity.BreathingActivity();
          break;

        case "2":
          Reflection reflectionActivity = new Reflection(
              "Reflection Activity\n",
              0,
              "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n"
          );
          reflectionActivity.ReflectionActivity();
          break;

        case "3":
          Listing listingActivity = new Listing(
              "Listing Activity\n",
              0,
              "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n"
          );
          listingActivity.ListingActivity();
          break;

        case "4":
          Console.WriteLine("Goodbye!");
          break;

        default:
          Console.WriteLine("Invalid option. Please select a valid choice.");
          break;
      }

      Console.WriteLine();
    }
  }
}