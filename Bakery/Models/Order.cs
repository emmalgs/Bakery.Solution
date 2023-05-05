using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public abstract class Order
  {
    public int Amount { get; set; }
    public int Cost { get; set; }
    public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int> {};
    public Dictionary<string, int> OrderItems { get; set; } = new Dictionary<string, int> {};

    public abstract void TakeOrder(string item, int amount);
    public abstract void CalculateCost();
  }
}
