using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : Order
  {
    public Bread(int loafOrder)
    {
      Amount = loafOrder;
    }

    public override void CreateMenuItems()
    {
      Items.Add("Sourdough", 5);
      Items.Add("Rye", 5);
      Items.Add("Chedder Spicy Pepper", 5);
      Items.Add("Pierre's Surprise", 5);
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