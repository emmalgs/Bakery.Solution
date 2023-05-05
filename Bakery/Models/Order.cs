
namespace Bakery.Models
{
  public class Order
  {
    public int Amount { get; set; }
    public int Cost { get; set; }
    public Order(int amount)
    {
      Amount = amount;
    }
    
    public void GetCost(int price)
    {
      Cost = price * Amount;
    }
  }
}
