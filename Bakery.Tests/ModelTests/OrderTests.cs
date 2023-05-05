using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void SetAmount_ReturnsAmountInOrder_Int()
    {
      int bakeryOrder = 2;
      Order newOrder = new Order(bakeryOrder);
      int result = newOrder.Amount;
      Assert.AreEqual(bakeryOrder, result);
    }
  }
}