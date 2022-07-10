using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void MakingTheBreadClass()
    {
      Bread testBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void HowMuchIsTheBreadBeforeTheDiscount()
    {
      Bread testBread = new Bread(1);
      Assert.AreEqual(5, testBread.BreadCost());
    }
    [TestMethod]
    public void HowMuchIsTheBreadAfterTheDiscount()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(10, testBread.BreadCost());
    }
    [TestMethod]
    public void MakingThePastryClass()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void HowMuchIsThePastryBeforeTheDiscount()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(2, testPastry.PastryCost());
    }
    [TestMethod]
    public void HowMuchIsThePastryAfterTheDiscount()
    {
      Pastry testPastry = new Pastry(3);
      Assert.AreEqual(5, testPastry.PastryCost());
    }
  }
}