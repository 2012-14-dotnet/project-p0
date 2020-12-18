using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
  class Program
  {
    private static readonly ClientSingleton _client = ClientSingleton.Instance;
    private readonly ClientSingleton _client2;

    public Program()
    {
      _client2 = ClientSingleton.Instance;
    }

    static void Main(string[] args)
    {
      _client.MakeStore();

      PrintAllStores();
    }

    static void PrintAllStores()
    {
      foreach (var store in _client.Stores)
      {
        System.Console.WriteLine(store);
      }
    }
  }
}
