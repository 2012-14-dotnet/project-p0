using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
  internal class User
  {
    public List<Order> Orders { get; set; }
  }
}
