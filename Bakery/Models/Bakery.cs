using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCount {get; set;}
    public Bread (int count)
    {
      BreadCount = count;
    }
    public int BreadCost()
    {
      int breadCostDivisor = Convert.ToInt32(Math.Floor(Convert.ToDouble(BreadCount) / 3));
      return ((BreadCount * 5) - (breadCostDivisor * 5));
    }
  }
  public class Pastry
  {
    public int PastryCount {get; set;}
    public Pastry (int count)
    {
      PastryCount = count;
    }
    public int PastryCost()
    {
      int pastryCostDivisor = Convert.ToInt32(Math.Floor(Convert.ToDouble(PastryCount) / 3));
      return ((PastryCount * 2) - (pastryCostDivisor));
    } 
  }
}