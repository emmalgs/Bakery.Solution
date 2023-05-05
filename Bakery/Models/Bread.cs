using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : Order
  {
    public Bread()
    {
      Menu.Add("sourdough", 4);
      Menu.Add("rye", 6);
      Menu.Add("cheddar", 5);
      Menu.Add("pierre surprise", 7);
    }

    public override void CalculateCost()
    {
      foreach (KeyValuePair<string, int> orderItems in OrderItems)
      {
        Cost += Menu[orderItems.Key] * orderItems.Value;
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