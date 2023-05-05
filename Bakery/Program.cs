using Bakery.Models;
using Bakery.UserInterfaceModels;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      SpinBread();
      WelcomeUser();
      BreadOrPastry();
    }

    static void WelcomeUser()
    {
      Console.WriteLine("Welcome to...");
      Console.WriteLine($"{Art.WelcomeBanner}");
      Console.WriteLine($"{Art.TheChef}");
    }

    static void BreadOrPastry()
    {
      Console.WriteLine("Bread or Pastry?");
      string answer = Console.ReadLine();
      if (answer.ToLower() == "bread")
      {
        BreadOrder();
      }
      else if (answer.ToLower() == "pastry")
      {
        PastryOrder();
      }
      else
      {
        Console.WriteLine("Sorry, didn't get that...");
        BreadOrPastry();
      }
    }

    static void BreadOrder()
    {
      Console.WriteLine("Our bread menu today is...");
      Bread newBread = new Bread();
      foreach (KeyValuePair<string, int> menuItem in newBread.Menu)
      {
        Console.WriteLine($"{menuItem.Key.ToUpper()}: {menuItem.Value.ToString("C2")}");
      }
      Console.WriteLine("Would you like to order a loaf of bread? (Y/N)");
      string answer = Console.ReadLine();
      if (answer.ToUpper() == "Y")
      {
        AddToBasket(newBread);
      }
      else
      {
        Console.WriteLine("Sorry, this frenchman doesn't understand");
        BreadOrPastry();
      }
    }

    static void PastryOrder()
    {
      Console.WriteLine("Our bread pastry today is...");
      Pastry newPastry = new Pastry();
      foreach (KeyValuePair<string, int> menuItem in newPastry.Menu)
      {
        Console.WriteLine($"{menuItem.Key.ToUpper()}: {menuItem.Value.ToString("C2")}");
      }
      Console.WriteLine("Would you like to order a pastry? (Y/N)");
      string answer = Console.ReadLine();
      if (answer.ToUpper() == "Y")
      {
        AddToBasket(newPastry);
      }
      else
      {
        Console.WriteLine("Sorry, this frenchman doesn't understand");
        BreadOrPastry();
      }
    }

    static void AddToBasket(Order order)
    {
      Console.WriteLine("Please enter the item you would like to order:");
      string orderItem = Console.ReadLine();
      if (order.Menu.ContainsKey(orderItem.ToLower()))
      {
        Console.WriteLine($"Great choice! How many would you like of {orderItem}?");
        string stringAmount = Console.ReadLine();
        try
        {
          int orderAmount = int.Parse(stringAmount);
          order.TakeOrder(orderItem, orderAmount);
          DancingChef();
          Console.WriteLine("Order up!");
          Console.WriteLine("Your basket currently has:");
          foreach (KeyValuePair<string, int> items in order.OrderItems)
          {
            Console.WriteLine($"{items.Key.ToUpper()}: x{items.Value}");
          }
          Console.WriteLine("Would you like to order more? (Y/N)");
          string answer = Console.ReadLine();
          if (answer.ToUpper() == "Y")
          {
            AddToBasket(order);
          }
          else
          {
            SpinBread();
            Console.WriteLine("Ready to checkout?");
            ApplyDeals(order);
          }
        }
        catch
        {
          Console.WriteLine("There's a line. Please hurry up and enter a REAL number.");
          AddToBasket(order);
        }
      }
      else
      {
        Console.WriteLine("Yikes, fresh out!");
        AddToBasket(order);
      }
    }

    static void ApplyDeals(Order order)
    {
      Console.WriteLine("Great news! Pierre has a special today. It's $5 off on every third loaf of bread, and $2 off every fourth pastry!");
      Console.WriteLine("Let's calculate your total");
      ShowSimplePercentage();
      order.CalculateCost();
      Total.AddOrder(order);
      int total = Total.CalculateTotalCost();
      Console.WriteLine($"Your total is {total.ToString("C2")}");
      Console.WriteLine($"Your basket currently has:");
      foreach (Order basket in Total.Orders)
      {
        foreach (KeyValuePair<string, int> items in basket.OrderItems)
        {
          Console.WriteLine($"{items.Key.ToUpper()} x{items.Value}");
        }
      }
      Console.WriteLine("Keep shopping? (Y/N)");
      string answer = Console.ReadLine();
      if (answer.ToUpper() == "Y")
      {
        BreadOrPastry();
      }
      else
      {
        Console.Beep();
        BonVoyage();
      }
    }

    static void SpinBread()
    {
      int counter = 0;
      for (int i = 0; i < 12; i++)
      {
        Console.Clear();
        switch (counter % 2)
        {
          case 0: Console.WriteLine($"{Art.BreadLeft}"); break;
          case 1: Console.WriteLine($"{Art.BreadRight}"); break;
        }
        counter++;
        Thread.Sleep(100);
      }
    }

    static void DancingChef()
    {
      int counter = 0;
      for (int i = 0; i < 12; i++)
      {
        Console.Clear();
        switch (counter % 2)
        {
          case 0: Console.WriteLine($"{Art.TheChefDanceRight}"); break;
          case 1: Console.WriteLine($"{Art.TheChefDanceLeft}"); break;
        }
        counter++;
        Thread.Sleep(100);
      }
    }

    static void ShowSimplePercentage()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.Write($"\rProgress: {i}%   ");
            Thread.Sleep(25);
        }

        Console.Write("\rChaching!          ");
    }

    static void BonVoyage()
    {
      int counter = 0;
      for (int i = 0; i < 12; i++)
      {
        Console.Clear();
        switch (counter % 2)
        {
          case 0: Console.WriteLine($"{Art.TheGoodbyeChefRight}"); break;
          case 1: Console.WriteLine($"{Art.TheGoodbyeChefLeft}"); break;
        }
        counter++;
        Thread.Sleep(100);
      }
    }
  }
}