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

    public override void TakeOrder(string item, int amount)
    {
      OrderItems.Add(item, amount);
      Amount += OrderItems[item];
    }

    public override void CalculateCost()
    {
      foreach (KeyValuePair<string, int> orderItems in OrderItems)
      {
        Cost += Items[orderItems.Key] * orderItems.Value;
      }
    }
  }
}