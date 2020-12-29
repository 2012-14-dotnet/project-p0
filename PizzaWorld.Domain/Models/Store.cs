using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class Store : AEntity
  {
    public List<Order> Orders { get; set; }
    public string Name { get; set; }

    public Store()
    {
      Orders = new List<Order>();
    }

    public void CreateOrder()
    {
      Orders.Add(new Order());
    }

    bool DeleteOrder(Order order)
    {
      try
      {
        Orders.Remove(order);

        return true;
      }
      catch
      {
        return false;
      }
    }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}
