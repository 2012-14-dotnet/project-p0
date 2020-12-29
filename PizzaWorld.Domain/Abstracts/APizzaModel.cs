using System.Collections.Generic;

namespace PizzaWorld.Domain.Abstracts
{
  public class APizzaModel : AEntity
  {
    public string Crust { get; set; }
    public string Size { get; set; }
    // public List<string> Toppings { get; set; }

    protected APizzaModel(Crust crust, Size size)
    {
      AddCrust(crust);
      AddSize(size);
      AddToppings();
    }

    public APizzaModel(string name)
    {

    }

    protected virtual void AddCrust(Crust crust) { }
    protected virtual void AddSize() { }
    protected virtual void AddToppings() { }
  }
}
