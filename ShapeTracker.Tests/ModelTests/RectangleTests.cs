using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {
    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(3);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1ForRectangle_Int()
    {
      int aSide = 5;
      Rectangle anInstanceOfRectangle = new Rectangle(aSide);
      Assert.AreEqual(aSide, anInstanceOfRectangle.Side1);
    }
  }
}