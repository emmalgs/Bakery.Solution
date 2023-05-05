using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetLoafOrder_ReturnsLoafOrder_Int()
    {
      Bread newBread = new Bread();
      newBread.TakeOrder("sourdough", 2);
      int result = newBread.Amount;
      Assert.AreEqual(2, result);
    }
    
    [TestMethod]
    public void CostMethod_AddsCostToCostField_Int()
    {
      Bread newBread = new Bread();
      newBread.TakeOrder("sourdough", 2);
      newBread.TakeOrder("rye", 1);
      newBread.CalculateCost();
      int result = newBread.Cost;
      Assert.AreEqual(10, result);
    }

    // [TestMethod]
    // public void CostMethod_CalculatesCostOfLoavesWithDeal_Int()
    // {
    //   int loafOrder = 4;
    //   Bread newBread = new Bread(loafOrder);
    //   newBread.CalculateCost();
    //   int result = newBread.Cost;
    //   Assert.AreEqual(15, result);
    // }

    [TestMethod]
    public void CreateMenuItems_SetsAndGetsMenuItemsForBreads_Dictionary()
    {
      Bread newBread = new Bread();
      int result = newBread.Items["sourdough"];
      Assert.AreEqual(5, result);
    }
  }
}