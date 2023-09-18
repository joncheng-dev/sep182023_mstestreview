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
      int aLengthToPassIn = 5;
      int aLengthToPassIn2 = 6;
      Triangle newTriangle = new Triangle(aLengthToPassIn, aLengthToPassIn2);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 3);
      // Act
      int result = newTriangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      
      Triangle newTriangle = new Triangle(3, 4);
      int newLength1 = 44;

      newTriangle.Side1 = newLength1;

      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Triangle newTriangle = new Triangle(2, length2);
      int result = newTriangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Triangle newTriangle = new Triangle(3, 4);
      int newLength2 = 6;
      newTriangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }
  }
}