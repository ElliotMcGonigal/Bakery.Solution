using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost(int bread)
    {
      int breadCostDivisor = Convert.ToInt32(Math.Floor(Convert.ToDouble(bread) / 3));
      return ((bread * 5) - (breadCostDivisor * 5));
    }
  }
  public class Pastry
  {
    public int PastryCost(int pastry)
    {
      return (pastry * 2);
    } 
  }
}