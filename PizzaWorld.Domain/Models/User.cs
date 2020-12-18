using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaWorld.Domain.Models
{
  public class User
  {
    public List<Order> Orders { get; set; }
    public Store SelectedStore { get; set; }

    public User()
    {
      Orders = new List<Order>();
    }

    public override string ToString()
    {
      var sb = new StringBuilder();

      foreach (var p in Orders.Last().Pizzas)
      {
        sb.AppendLine(p.ToString());
      }

      return $"you have selected this store: {SelectedStore} and ordered these pizzas: {sb.ToString()}"; // string interpolation
      //return "I have selected this store: " + SelectedStore.ToString(); // string concatenation
    }
  }
}
