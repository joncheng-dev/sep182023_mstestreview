using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests : IDisposable
  {
    public void Dispose()
    {
      Triangle.ClearAll();
    }

    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      int aLengthToPassIn = 5;
      int aLengthToPassIn2 = 6;
      Triangle newTriangle = new Triangle(aLengthToPassIn, aLengthToPassIn2, 7);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 3, 2);
      // Act
      int result = newTriangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      
      Triangle newTriangle = new Triangle(3, 4, 5);
      int newLength1 = 44;

      newTriangle.Side1 = newLength1;

      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Triangle newTriangle = new Triangle(2, length2, 5);
      int result = newTriangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Triangle newTriangle = new Triangle(3, 4, 5);
      int newLength2 = 6;
      newTriangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }

    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      int length3 = 55;
      Triangle newTriangle = new Triangle(2, 3, length3);
      int result = newTriangle.GetSide3();
      Assert.AreEqual(length3, result);
    }

    [TestMethod]
    public void SetSide3_ReturnsSide3_Void()
    {
      int side3ValueReplacement = 70;
      Triangle newTriangle = new Triangle(2, 3, 55);
      newTriangle.SetSide3(side3ValueReplacement);
      Assert.AreEqual(side3ValueReplacement, newTriangle.GetSide3());
    }

    [TestMethod]
    public void CheckType_DeterminesWhenNotATriangle_String()
    {
      Triangle notATriangle = new Triangle(3, 4, 88);
      string triangleType = notATriangle.CheckType();
      Assert.AreEqual("not a triangle", triangleType);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenScalene_String()
    {
      Triangle scaleneTriangle = new Triangle(3, 4, 5);
      string triangleType = scaleneTriangle.CheckType();
      Assert.AreEqual("scalene triangle", triangleType);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenIsosceles_String()
    {
      Triangle isoscelesTriangle = new Triangle(2, 1, 2);
      string triangleType = isoscelesTriangle.CheckType();
      Assert.AreEqual("isosceles triangle", triangleType);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenEquilateral_String()
    {
      Triangle equilateralTriangle = new Triangle(3, 3, 3);
      string triangleType = equilateralTriangle.CheckType();
      Assert.AreEqual("equilateral triangle", triangleType);
    }

    [TestMethod]
    public void GetAll_ReturnsAllTriangleInstances_List()
    {
      Triangle triangle1 = new Triangle(2, 2, 9);
      Triangle triangle2 = new Triangle(21, 3, 9);
      Triangle triangle3 = new Triangle(1, 3, 9);
      List<Triangle> expected = new List<Triangle> { triangle1, triangle2, triangle3 };
      List<Triangle> actualResult = Triangle.GetAll();
      CollectionAssert.AreEqual(expected, actualResult);
    }

    [TestMethod]
    public void ClearAll_ClearsAllTriangleInstances_Void()
    {
      Triangle triangle1 = new Triangle(2, 2, 9);
      Triangle triangle2 = new Triangle(21, 3, 9);
      Triangle triangle3 = new Triangle(1, 3, 9);
      List<Triangle> listOfTriangles = new List<Triangle> { };
      Triangle.ClearAll();
      CollectionAssert.AreEqual(listOfTriangles, Triangle.GetAll());      
    }

    
  }
}