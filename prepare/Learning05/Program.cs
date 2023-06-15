using System;

class Program
{
  static void Main(string[] args)
  {
    List<Shapes> ShapeList = new List<Shapes>();

    Square S1 = new Square("Pink", 8);
    ShapeList.Add(S1);

    Rectangle S2 = new Rectangle("Black", 6, 2);
    ShapeList.Add(S2);

    Circle S3 = new Circle("Red", 5);
    ShapeList.Add(S3);

    foreach (Shapes s in ShapeList)
    {

      string color = s.GetColor();

      double area = s.GetArea();

      Console.WriteLine($"The {color} shape has an area of {area}.");
    }
  }
}
