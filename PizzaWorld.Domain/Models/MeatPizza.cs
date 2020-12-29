using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class MeatPizza : APizzaModel
  {
    private PizzaWorldContext _db = new PizzaWorldContext();
    protected override void AddCrust(Crust crust)
    {
      Crust = crust;
    }

    protected override void AddSize()
    {
      Size = "small";
    }

    protected override void AddToppings()
    {
      // Toppings = new List<string>
      // {
      //   "cheese",
      //   "tomato"
      // };
    }
  }
}
