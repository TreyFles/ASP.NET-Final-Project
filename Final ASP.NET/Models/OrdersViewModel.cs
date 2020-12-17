using Packt.Shared;  
using System.Collections.Generic;
 
namespace Final_ASP.NET.Models
{
  public class OrdersViewModel
  {
    public IList<Order> Orders { get; set;}
    public IList<OrderDetail> OrderDetails { get; set;}
  }
}