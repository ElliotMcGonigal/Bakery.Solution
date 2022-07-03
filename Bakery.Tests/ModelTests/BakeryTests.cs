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
    [TestMethod]
    public void HowMuchIsTheBreadAfterTheDiscount()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.BreadCost(3));
    }
    [TestMethod]
    public void HowMuchIsThePastryBeforeTheDiscount()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2,testPastry.PastryCost(1));
    }
  }
}