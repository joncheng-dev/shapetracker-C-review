using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 4, 5);
      int result = newTriangle.Side1;
      Assert.AreEqual(length1, result);
    }
  }
}