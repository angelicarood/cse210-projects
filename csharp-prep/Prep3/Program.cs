using System;

class Program
{
  static void Main(string[] args)
  {


    //while (continuePlaying == "yes")


    Random randomGenerator = new Random();
    int MagicNumber = randomGenerator.Next(1, 101);

    int Guess = -1;


    while (Guess != MagicNumber)

    {
      Console.WriteLine("What is your guess?");
      Guess = int.Parse(Console.ReadLine());

      if (Guess > MagicNumber)
      {
        Console.WriteLine("Go lower");
      }

      else if (Guess < MagicNumber)
      {
        Console.WriteLine("Go Higher");
      }
      else
      {
        Console.WriteLine("Your guess is right. Congrats!");
      }
    }
    //Console.WriteLine("Would you like to play again (yes | no): ");
    //string ContinuePlaying = Console.ReadLine();
  }
}