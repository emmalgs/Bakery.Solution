using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : Order
  {
    public Pastry()
    {
      Menu.Add("croissant", 3);
      Menu.Add("danish", 2);
      Menu.Add("bucky surprise", 4);
    }

    public override void CalculateCost()
    {
      foreach (KeyValuePair<string, int> orderItems in OrderItems)
      {
        Cost += Menu[orderItems.Key] * orderItems.Value;
      }
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 4 == 0)
        {
          Cost -= 2;
        }
      }
    }
  }
}