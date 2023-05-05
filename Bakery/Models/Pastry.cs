using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : Order
  {
    public Pastry()
    {
      Items.Add("croissant", 3);
      Items.Add("danish", 2);
      Items.Add("bucky surprise", 4);
    }

    public override void CalculateCost()
    {
      foreach (KeyValuePair<string, int> orderItems in OrderItems)
      {
        Cost += Items[orderItems.Key] * orderItems.Value;
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