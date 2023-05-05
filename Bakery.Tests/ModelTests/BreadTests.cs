using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetLoafOrder_ReturnsLoadOrder_Int()
    {
      int loafOrder = 4;
      Bread newBread = new Bread(loafOrder);
      int result = newBread.Loaves;
      Assert.AreEqual(loafOrder, result);
    }
  }
}