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
      Cost = Loaves * 5;
    }
  }
}