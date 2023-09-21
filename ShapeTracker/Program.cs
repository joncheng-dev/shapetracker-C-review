using System;
using ShapeTracker.Models;
using System.Collections.Generic;

// User Interface Logic
namespace ShapeTracker 
{
  class Program 
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("Please enter an integer for side 1:");
      string stringLength1 = Console.ReadLine();
      Console.WriteLine("Please enter an integer for side 2:");
      string stringLength2 = Console.ReadLine();
      Console.WriteLine("Please enter an integer for side 3:");
      string stringLength3 = Console.ReadLine();

      int length1 = int.Parse(stringLength1);
      int length2 = int.Parse(stringLength2);
      int length3 = int.Parse(stringLength3);

      Triangle instanceOfTriangle = new Triangle(length1, length2, length3);
      ConfirmOrEditTriangle(instanceOfTriangle);
    }

    static void ConfirmOrEditTriangle(Triangle instance)
    {
      Console.WriteLine("Please confirm that your triangle's side are correct.");
      Console.WriteLine($"Side1 has a length of {instance.GetSide1()}");
      Console.WriteLine($"Side2 has a length of {instance.GetSide2()}");
      Console.WriteLine($"Side3 has a length of {instance.GetSide3()}");
      Console.WriteLine("If correct, enter 'yes'. If incorrect, enter 'no'.");
      string userResponse = Console.ReadLine();

      if (userResponse == "yes")
      {
        CheckTriangleType(instance);
      }
      else 
      {
        Console.WriteLine("Let's re-enter your 3 sides.");
        Console.WriteLine("Please enter side1:");
        string stringReenterSide1 = Console.ReadLine();
        Console.WriteLine("Please enter side2:");
        string stringReenterSide2 = Console.ReadLine();
        Console.WriteLine("Please enter side3:");
        string stringReenterSide3 = Console.ReadLine();

        instance.SetSide1(int.Parse(stringReenterSide1));
        instance.SetSide2(int.Parse(stringReenterSide2));
        instance.SetSide3(int.Parse(stringReenterSide3));
        ConfirmOrEditTriangle(instance);                
      }
    }

    static void CheckTriangleType(Triangle instance)
    {
      string result = instance.CheckType();
      Console.WriteLine($"Your triangle is: {result}.");
      Console.WriteLine("What would you like to do now?");
      Console.WriteLine("Please enter 'new' to check a new triangle.");
      string userResponse = Console.ReadLine();

      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye.");
      }
    }
  }  
}
