using System;

class Program
{
  static void Main(string[] args)
  {


    Scripture S1 = new Scripture();
    S1.SelectVerses(4, 6);
    S1.PrintVerse();
    S1.RemoveWords();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Press Enter to hide random words or type 'quit' to exit.");
    string input = Console.ReadLine();


    while (input != "quit")
    {
      Console.Clear();
      S1.PrintVerse();
      S1.RemoveWords();


      if (S1.IsEverythingBlank())
      {
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Press Enter to exit.");
        break;
      }


      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Press Enter to hide random words or type 'quit' to exit.");
      input = Console.ReadLine();
    }
  }
}