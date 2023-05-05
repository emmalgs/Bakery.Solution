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
      int pastryOrder = 4;
      Pastry newPastry = new Pastry(pastryOrder);
      int result = newPastry.Amount;
      Assert.AreEqual(pastryOrder, result);
    }

    [TestMethod]
    public void CostMethod_AddsPastryCostToField_Int()
    {
      int pastryOrder = 1;
      Pastry newPastry = new Pastry(pastryOrder);
      newPastry.CalculateCost();
      int result = newPastry.Cost;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void CostMethod_CalculatesCostOfPastriesWithDeal_Int()
    {
      int pastryOrder = 5;
      Pastry newPastry = new Pastry(pastryOrder);
      newPastry.CalculateCost();
      int result = newPastry.Cost;
      Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void CostMethod_ReturnsZeroIfOrderIsZero_Int()
    {
      int pastryOrder = 0;
      Pastry newPastry = new Pastry(pastryOrder);
      newPastry.CalculateCost();
      int result = newPastry.Cost;
      Assert.AreEqual(pastryOrder, result);
    }
  }
}