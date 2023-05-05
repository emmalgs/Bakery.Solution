using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : Order
  {
    public Pastry(int order)
    {
      Amount = order;
    }

    public override void TakeOrder(string item, int amount)
    {

    }

    public override void CalculateCost()
    {
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 4 != 0)
        {
          Cost += 2;
        }
      }
    }
  }
}