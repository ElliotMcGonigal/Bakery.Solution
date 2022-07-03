using System;
using Bakery.Models;

namespace Pierres
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How many loaves of BREAD would you like?(enter '0' for none, please enter only a number)");
      int loavesOfBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many PASTRIES would you like?(enter '0' for none, please enter only a number)");
      int numberOfPastries = int.Parse(Console.ReadLine());
    }
  }
}