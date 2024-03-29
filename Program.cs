﻿using System;

namespace structs
{
  class Program
  {
    static void Main(string[] args)
    {


      int? randNum = null;

      if (randNum == null)
      {
        System.Console.WriteLine("randNum is null");
      }
      if (!randNum.HasValue)
      {
        System.Console.WriteLine("randNum is null");
      }

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
      tiger.MakeSound();

      System.Console.WriteLine("Number of animals: {0}", Animal.GetNumOfAnimals());

      System.Console.WriteLine("Area of rectangle : {0}",
      ShapeMath.GetArea("rectangle", 5, 6));



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
