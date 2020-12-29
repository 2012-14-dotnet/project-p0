using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
  class Program
  {
    private static readonly ClientSingleton _client = ClientSingleton.Instance;
    private readonly ClientSingleton _client2;
    private static readonly SqlClient _sql = new SqlClient();

    public Program()
    {
      _client2 = ClientSingleton.Instance;
    }

    static void Main(string[] args)
    {
      UserView();
    }

    static void PrintAllStores()
    {
      foreach (var store in _client.Stores)
      {
        System.Console.WriteLine(store);
      }
    }

    static void PrintAllStoresWithEF()
    {
      foreach (var store in _sql.ReadStores())
      {
        System.Console.WriteLine(store);
      }
    }

    static void UserView()
    {
      var user = new User();

      PrintAllStoresWithEF();

      user.SelectedStore = _sql.SelectStore(); // lazy loading
      user.SelectedStore.CreateOrder();
      user.Orders.Add(user.SelectedStore.Orders.Last()); // eager loading
      // while user.SelectPizza()
      user.Orders.Last().MakeMeatPizza();
      user.Orders.Last().MakeMeatPizza();
      _sql.Update();

      System.Console.WriteLine(user);
    }
  }
}
