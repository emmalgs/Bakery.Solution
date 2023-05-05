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
      
    }
  }
}