namespace Bakery.Models
{
  public class Pastry : Order
  {
    public Pastry(int order)
    {
      Amount = order;
    }

    public override void CreateMenuItems()
    {
      
    }

    public override void CalculateCost()
    {
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 4 != 0)
        {
          Cost += 2;
        }
      }
    }
  }
}