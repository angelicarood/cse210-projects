using System;

class Program
{
  static void Main(string[] args)
  {
    Assigment asig1 = new Assigment("Manuel leon", "Algebra");
    asig1.GetSummary();
    Console.Write(asig1.GetSummary());
    Console.WriteLine();
    Console.WriteLine();
    MathAssignment asig2 = new MathAssignment("Laura Guerrero", "Substraction", "section 2.3", "Problems 1-4");
    Console.Write(asig2.GetHomeworkList());
    Console.WriteLine();
    Console.WriteLine();
    WritingAssignment asig3 = new WritingAssignment("Camilo Ruiz", "History", "World War II");
    Console.Write(asig3.GetWritingInformation());

  }
}