namespace Bakery.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    public int Cost { get; set; }
    public Bread(int loafOrder)
    {
      Loaves = loafOrder;
    }
    public void GetCost()
    {
      for (int i = 1; i <= Loaves; i++)
      {
        if (i % 3 != 0)
        {
          Cost += 5;
        }
      }
    }
  }
}