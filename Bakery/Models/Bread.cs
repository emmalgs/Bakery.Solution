namespace Bakery.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    public Bread(int loafOrder)
    {
      Loaves = loafOrder;
    }
  }
}