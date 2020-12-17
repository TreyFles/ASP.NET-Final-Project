using System.Collections.Generic;

namespace Packt.Shared
{
  public class Shipper
  {
    public int ShipperID { get; set; }
    public string CompanyName { get; set; }
    public string Phone { get; set; }

    // related entities
    public ICollection<Order> Orders { get; set; }
  }
}