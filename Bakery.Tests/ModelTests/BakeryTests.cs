using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void HowMuchIsTheBreadBeforeTheDiscount()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.BreadCost(1));
    }
  }
}