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

    [TestMethod]
    public void SetSide1_SetsNewValueForSide1_Void()
    {
      int aNewSide1 = 10;
      Rectangle anInstanceOfRectangle = new Rectangle(5);
      anInstanceOfRectangle.Side1 = aNewSide1;
      Assert.AreEqual(aNewSide1, anInstanceOfRectangle.Side1);
    }
  }
}