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

  }



}