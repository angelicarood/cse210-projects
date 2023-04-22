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

    if (Percentage >= 80 && Percentage < 90)
      letter = ("B");


    if (Percentage >= 70 && Percentage < 80)
      letter = ("C");


    if (Percentage >= 60 && Percentage < 70)
      letter = ("D");

    if (Percentage < 60)
      letter = ("F");

    {
      Console.WriteLine(letter);
    }


    if (Percentage >= 70)
    {
      Console.WriteLine("Congrats you passed the course");
    }

    else if (Percentage < 70)
    {
      Console.WriteLine("We will like to encourage you to keep working hard");
    }
  }



}