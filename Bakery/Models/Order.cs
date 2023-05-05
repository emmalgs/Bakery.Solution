using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public abstract class Order
  {
    public int Amount { get; set; }
    public int Cost { get; set; }
    public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int> {};

    public abstract void CalculateCost();
    public abstract void CreateMenuItems();
  }
}
