using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Total
  {
    public static List<Order> Orders = new List<Order>();

    public static void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static int CalculateTotalCost()
    {
      int totalCost = 0;
      foreach (Order order in Orders)
      {
        totalCost += order.Cost;
      }
      return totalCost;
    }
  }
}