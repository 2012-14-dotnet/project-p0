using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client
{
  public class SqlClient
  {
    private readonly PizzaWorldContext _context = new PizzaWorldContext();

    public IEnumerable<Store> ReadStores()
    {
      return _context.Stores;
    }

    public Store ReadOne(string name)
    {
      var s = _context.Stores.FirstOrDefault(s => s.Name == name); //linq - predicate
                                                                   // return _db.Stores.SingleOrDefault(s => s.Name == name);

      // int x = 10; // eager loading

      // var stores = from s in _context.Stores // linq - query
      //             where s.Name == name
      //             select s; // lazy loading

      // _context.Stores.Add(new Store(){ Name = name});
      // _context.SaveChanges();

      // return stores.ToList();
      return s;
    }

    public IEnumerable<Order> ReadOrders(Store store) // how to make this generic
    {
      var s = ReadOne(store.Name);

      return s.Orders;
    }

    public void Save(Store store)
    {
      _context.Add(store); // git add
      _context.SaveChanges(); // git commit
    }

    public void Update()
    {
      _context.SaveChanges();
    }

    public Store SelectStore()
    {
      string input = Console.ReadLine();

      return ReadOne(input);
    }

    public void UserOrderHistory(User user)
    {
      var u = _context.Users
                      .Include(u => u.Orders)
                      .ThenInclude(o => o.Pizzas)
                      .FirstOrDefault(u => u.EntityId == user.EntityId); // explicit loading
      var o = u.Orders.Pizzas;
      var p = _context.Pizzas.Select(s => s.EntityId == u.Pizzas);
    }

    // repository pattern
    // CRUD for Storage - DML for SQL
  }
}
