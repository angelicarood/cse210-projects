using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("What is the magic number?");
    string Input = Console.ReadLine();
    int MagicNumber;
    Int32.TryParse(Input, out MagicNumber);
    Console.WriteLine("What is your guess?");
    string InputGuess = Console.ReadLine();
    int Guess;
    Int32.TryParse(InputGuess, out Guess);

    if (MagicNumber == Guess)
      Console.WriteLine("Your guess is right. Congrats!");


    else if (MagicNumber > Guess)
      Console.WriteLine("Go Higher");


    else if (MagicNumber < Guess)
      Console.WriteLine("Go Lower");


  }
}