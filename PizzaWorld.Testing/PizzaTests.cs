using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
  public class PizzaTests
  {
    [Fact]
    private void Test_PizzaExists()
    {
      // arrange
      var sut = new Pizza(); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<Order>(actual);
      Assert.NotNull(actual);
    }
  }
}
