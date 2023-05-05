namespace Bakery.Models
{
  public class Pastry
  {
    public int Pastries { get; set; }
    public int Cost { get; set; }
    public Pastry(int order)
    {
      Pastries = order;
    }
    public void GetCost()
    {
      for (int i = 1; i <= Pastries; i++)
      {
        if (i % 4 != 0)
        {
          Cost += 2;
        }
      }
    }
  }
}