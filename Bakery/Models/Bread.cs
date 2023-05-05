using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : Order
  {
    public Bread()
    {
      Items.Add("sourdough", 4);
      Items.Add("rye", 6);
      Items.Add("cheddar", 5);
      Items.Add("pierre surprise", 7);
    }

    public override void CalculateCost()
    {
      foreach (KeyValuePair<string, int> orderItems in OrderItems)
      {
        Cost += Items[orderItems.Key] * orderItems.Value;
      }
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 3 == 0)
        {
          Cost -= 5;
        }
      }
    }
  }
}