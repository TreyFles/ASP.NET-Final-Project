using Packt.Shared;                        // Employee
using System.Collections.Generic;          // IEnumerable<T>

namespace Final_ASP.NET.Models
{
  public class HomeIndexViewModel
  { 
    public IList<Category> Categories { get; set; } 
    public IList<Product> Products { get; set; }
  }
}