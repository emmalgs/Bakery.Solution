
namespace Bakery.Models
{
  public class Order
  {
    public int Amount { get; set; }
    public Order(int amount)
    {
      Amount = amount;
    }
  }
}
