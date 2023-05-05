using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : Order
  {
    public Bread()
    {
      Items.Add("sourdough", 5);
      Items.Add("rye", 5);
      Items.Add("chedder", 5);
      Items.Add("pierre surprise", 5);
    }

    public override void TakeOrder(string item, int amount)
    {
      OrderItems.Add(item, amount);
      Amount += OrderItems[item];
    }

    public override void CalculateCost()
    {
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 3 != 0)
        {
          Cost += 5;
        }
      }
    }
  }
}