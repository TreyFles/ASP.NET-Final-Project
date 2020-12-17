using Packt.Shared;
using System.Collections.Generic;

namespace Final_ASP.NET.Models
{
  public class HomeModelBindingViewModel
  {
    public Thing Thing { get; set; }

    public bool HasErrors { get; set; }

    public IEnumerable<string> ValidationErrors { get; set; }
  }
}