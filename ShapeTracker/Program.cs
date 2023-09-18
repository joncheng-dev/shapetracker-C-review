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
      List<Triangle> allTriangles = Triangle.GetAll();
      Triangle testTriangle = new Triangle(3, 4, 5);
      Triangle secondTriangle = new Triangle(32, 74, 75);
      if (allTriangles.Count == 0)
      {
        Console.WriteLine("There are no triangles!");
      }
      else 
      {
        foreach (Triangle tri in allTriangles)
        {
          Console.WriteLine($"Side one is: {tri.GetSide1()}");
          Console.WriteLine($"Side two is: {tri.GetSide2()}");
          Console.WriteLine($"Side three is: {tri.GetSide3()}");
        }
      }
    }
  }  
}
