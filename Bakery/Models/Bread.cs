namespace Bakery.Models
{
  public class Bread : Order
  {
    public Bread(int loafOrder)
    {
      Amount = loafOrder;
    }
    public override void CalculateCost()
    {
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 3 != 0)
        {
          Cost += 5;
        }
      }
    }
  }
}