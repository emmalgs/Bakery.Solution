
namespace Bakery.Models
{
  public abstract class Order
  {
    public int Amount { get; set; }
    public int Cost { get; set; }
    public abstract void CalculateCost();
  }
}
