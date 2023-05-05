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
        AddToBreadBasket(newBread);
      }
    }

    static void AddToBreadBasket(Bread bread)
    {
      Console.WriteLine("Please enter the loaf you would like to order:");
      string orderItem = Console.ReadLine();
      if (bread.Menu.ContainsKey(orderItem.ToLower()))
      {
        Console.WriteLine($"Great choice! How many loaves would you like of {orderItem}?");
        string stringAmount = Console.ReadLine();
        int orderAmount = int.Parse(stringAmount);
        bread.TakeOrder(orderItem, orderAmount);
        DancingChef();
        Console.WriteLine("Order up!");
        Console.WriteLine("You're basket currently has:");
        foreach (KeyValuePair<string, int> items in bread.OrderItems)
        {
          Console.WriteLine($"{items.Value} loaves of {items.Key.ToUpper()}");
        }
        Console.WriteLine("Would you like to order more bread? (Y/N)");
        string answer = Console.ReadLine();
        if (answer.ToUpper() == "Y")
        {
          AddToBreadBasket(bread);
        }
        else
        {
          Console.WriteLine("Okay");
        }
      }
      else
      {
        Console.WriteLine("Yikes, fresh out!");
        AddToBreadBasket(bread);
      }
    }

    static void PastryOrder()
    {

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
  }
}