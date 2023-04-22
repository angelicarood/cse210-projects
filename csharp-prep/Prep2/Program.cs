using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("What is your grade percentage?");
    string UserInput = Console.ReadLine();
    int Percentage = int.Parse(UserInput);

    string letter = null;

    if (Percentage >= 90)
      letter = ("A");

    else if (Percentage >= 80 && Percentage < 90)
      letter = ("B");


    else if (Percentage >= 70 && Percentage < 80)
      letter = ("C");


    else if (Percentage >= 60 && Percentage < 70)
      letter = ("D");

    else
      letter = ("F");

    {
      Console.WriteLine(letter);
    }


    if (Percentage >= 70)
    {
      Console.WriteLine("Congrats you passed the course");
    }

    else
    {
      Console.WriteLine("We will like to encourage you to keep working hard");
    }

  }
}