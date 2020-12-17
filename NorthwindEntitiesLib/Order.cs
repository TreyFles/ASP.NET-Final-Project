using System;
using System.Collections.Generic;

namespace Packt.Shared
{
  public class Order
  {
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime? OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public int ShipVia { get; set; }
    public decimal? Freight { get; set; } = 0;
    public string ShipName { get; set;}
    public string ShipAddress { get; set;}
    public string ShipCity { get; set;}
    public string ShipRegion { get; set;}
    public string ShipPostalCode { get; set;}
    public string ShipCountry { get; set;}

    // related entities
    public Customer Customer { get; set; }
    public Employee Employee { get; set; }
    public Shipper Shipper { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
  }
}