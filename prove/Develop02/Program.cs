using System;
using System.Collections.Generic;
using System.IO;
class Program
{
  static void Main(string[] args)
  {
    string _userOption = "0";
    Journal journal = new Journal();
    QuestionList questions = new QuestionList();
    while (_userOption != "5")
    {
      Console.WriteLine("Chose one of the following options");
      Console.WriteLine();
      Console.WriteLine("(1) Write");
      Console.WriteLine("(2) Display");
      Console.WriteLine("(3) Load");
      Console.WriteLine("(4) Save");
      Console.WriteLine("(5) Quit");
      Console.WriteLine();
      Console.WriteLine("What would you like to do?");

      _userOption = Console.ReadLine();
      Console.WriteLine();

      if (_userOption == "1")
      {
        string question = questions.GetRandomQuestion();
        Console.WriteLine(question);
        string response = Console.ReadLine();
        journal.AddEntry(question, response);

      }
      else if (_userOption == "2")
      {

        journal.DisplayEntries();
      }

      // put other stuff 3,4,5

      else
      {
        Console.WriteLine("Error: Invalid option.\n");
      }


    }
  }



}
