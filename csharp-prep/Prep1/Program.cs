using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("What is your last name?");
    string lastname = Console.ReadLine();

    Console.WriteLine($"My name is {lastname}, {name} {lastname}.");

    Console.WriteLine("What is your grade percentage?");
    string UserInput = Console.ReadLine();
    int Percentage = int.Parse(UserInput);

    if (Percentage >= 90)

    {
      Console.WriteLine("A");
    }
    if (Percentage >= 80 && Percentage < 90)

    {
      Console.WriteLine("B");
    }

    if (Percentage >= 70 && Percentage < 80)

    {
      Console.WriteLine("C");
    }

    if (Percentage >= 60 && Percentage < 70)

    {
      Console.WriteLine("D");
    }

    if (Percentage < 60)
    {
      Console.WriteLine("F");
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