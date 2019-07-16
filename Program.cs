using System;

namespace structs
{
  class Program
  {
    static void Main(string[] args)
    {


      Rectangle rect1;
      rect1.length = 200;
      rect1.width = 40;

      Rectangle rect2 = rect1;

      System.Console.WriteLine(rect1.Area);


      Animal fox = new Animal()
      {
        Name = "Red Fox",
        Sound = "Rawwr"
      };

      Animal tiger = new Animal("tiger", "Roarr");


      System.Console.WriteLine("Number of animals: {0}", Animal.GetNumOfAnimals());
    }

    struct Rectangle
    {
      public double length;
      public double width;


      public Rectangle(double l = 1, double w = 1)
      {
        length = l;
        width = w;
      }

      public double Area
      {
        get
        {
          return length * width;
        }
      }
    }
  }
}
