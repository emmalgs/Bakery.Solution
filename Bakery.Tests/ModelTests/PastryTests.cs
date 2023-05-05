using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void GetPastryOrder_ReturnsPastryOrder_int()
    {
      Pastry newPastry = new Pastry();
      newPastry.TakeOrder("croissant", 3);
      int result = newPastry.Amount;
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void CostMethod_AddsPastryCostToField_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.TakeOrder("croissant", 3);
      newPastry.CalculateCost();
      int result = newPastry.Cost;
      Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void CostMethod_CalculatesCostOfPastriesWithDeal_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.TakeOrder("croissant", 3);
      newPastry.TakeOrder("bucky surprise", 2);
      newPastry.CalculateCost();
      int result = newPastry.Cost;
      Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void CostMethod_ReturnsZeroIfOrderIsZero_Int()
    {
      Pastry newPastry = new Pastry();
      int result = newPastry.Items["croissant"];
      Assert.AreEqual(3, result);
    }
  }
}