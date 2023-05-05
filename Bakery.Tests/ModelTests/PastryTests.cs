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
      int result = newPastry.Pastries;
      Assert.AreEqual(pastryOrder, result);
    }
  }
}