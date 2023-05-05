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
      int loafOrder = 4;
      Bread newBread = new Bread(loafOrder);
      int result = newBread.Amount;
      Assert.AreEqual(loafOrder, result);
    }
    
    [TestMethod]
    public void CostMethod_AddsCostToCostField_Int()
    {
      int loafOrder = 1;
      Bread newBread = new Bread(loafOrder);
      newBread.CalculateCost();
      int result = newBread.Cost;
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void CostMethod_CalculatesCostOfLoavesWithDeal_Int()
    {
      int loafOrder = 4;
      Bread newBread = new Bread(loafOrder);
      newBread.CalculateCost();
      int result = newBread.Cost;
      Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void CreateMenuItems_SetsAndGetsMenuItemsForBreads_Dictionary()
    {
      Bread newBread = new Bread(2);
      newBread.CreateMenuItems();
      int result = newBread.Items["Sourdough"];
      Assert.AreEqual(5, result);
    }
  }
}