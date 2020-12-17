namespace Final_ASP.NET.Models
{
  public class CartItem
  {
    public int ProductID { get; set; }
    
    public string ProductName { get; set; }

    public decimal? UnitPrice { get; set; } = 0;

  }

}