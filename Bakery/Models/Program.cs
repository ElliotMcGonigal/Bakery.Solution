using System;
using Bakery.Models;

namespace Pierres
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Here we only sell loaves of bread and pastries. Each loaf is $5, but we have a buy 2 get one free sale! Each pastry is $2, but we have a 3 pastries for $5 deal!");
      Console.WriteLine("How many loaves of BREAD would you like?(enter '0' for none, please enter only a number)");
      int loavesOfBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many PASTRIES would you like?(enter '0' for none, please enter only a number)");
      int numberOfPastries = int.Parse(Console.ReadLine());
      Bread bread = new Bread(loavesOfBread);
      Pastry pastry = new Pastry(numberOfPastries);
      int totalPrice = bread.BreadCost() + pastry.PastryCost();
      Console.WriteLine("Your total cost will be $" + totalPrice + "! Enjoy your bakery bounty!");
    }
  }
}