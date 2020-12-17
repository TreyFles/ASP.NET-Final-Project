using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final_ASP.NET.Models;
using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using Newtonsoft.Json;

namespace Final_ASP.NET.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    private readonly Northwind db;

    private readonly IHttpClientFactory clientFactory;

    public HomeController(
      ILogger<HomeController> logger,
      Northwind injectedContext,
      IHttpClientFactory httpClientFactory)
    {
      _logger = logger;
      db = injectedContext;
      clientFactory = httpClientFactory;
    }
    
    public IActionResult Index(string[] args)
      {
          return View();
      }

    public async Task<IActionResult> Products()
    {
      var model = new HomeIndexViewModel
      {
        Categories = await db.Categories.ToListAsync(),
        Products = await db.Products.ToListAsync()
      };

      return View(model); // pass model to view
    }

    public async Task<IActionResult> Orders()
    {
     var model = new OrdersViewModel
      {
        Orders = await db.Orders.ToListAsync(),
        OrderDetails = await db.OrderDetails.ToListAsync()
      };

      return View(model);
    }

    public async Task<IActionResult> OrderDetail(int? id)
    {
      if (!id.HasValue)
      {
        return NotFound("You must pass a product ID in the route, for example, /Home/ProductDetail/21");
      }

      var model = await db.Orders
        .SingleOrDefaultAsync(o => o.OrderID == id);

      if (model == null)
      {
        return NotFound($"Product with ID of {id} not found.");
      }

      return View(model); // pass model to view and then return result
    }

    public IActionResult Cart(int? id)
    {
      // the current cart is stored as a cookie
      string cartCookie = Request.Cookies["nw_cart"] ?? string.Empty;

      // if visitor clicked Add to Cart button
      if (id.HasValue)
      {
        if (string.IsNullOrWhiteSpace(cartCookie))
        {
          cartCookie = id.ToString();
        }
        else
        {
          string[] ids = cartCookie.Split('-');

          if (!ids.Contains(id.ToString()))
          {
            cartCookie = string.Join('-', cartCookie, id.ToString());
          }
        }

        Response.Cookies.Append("nw_cart", cartCookie);
      }

      var model = new HomeCartViewModel
      {
        Cart = new Cart
        {
          Items = Enumerable.Empty<CartItem>()
        }
      };

      if (cartCookie.Length > 0)
      {
        model.Cart.Items = cartCookie.Split('-').Select(item =>
          new CartItem
          {
            ProductID = int.Parse(item),
            ProductName = db.Products.Find(
              int.Parse(item)).ProductName,
            UnitPrice = db.Products.Find(
              int.Parse(item)).UnitPrice
          });
      }
      return View(model);
    }

    [HttpPost]
    public IActionResult ModelBinding(Thing thing)
    {
      // return View(thing); // show the model bound thing

      var model = new HomeModelBindingViewModel
      {
        Thing = thing,
        HasErrors = !ModelState.IsValid,
        ValidationErrors = ModelState.Values
          .SelectMany(state => state.Errors)
          .Select(error => error.ErrorMessage)
      };

      return View(model);
    }


    public async Task<IActionResult> Customers(string country)
    {
      string uri;

      if (string.IsNullOrEmpty(country))
      {
        ViewData["Title"] = "All Customers Worldwide";
        uri = "api/customers/";
      }
      else
      {
        ViewData["Title"] = $"Customers in {country}";
        uri = $"api/customers/?country={country}";
      }

      var client = clientFactory.CreateClient(
        name: "NorthwindService");

      var request = new HttpRequestMessage(
        method: HttpMethod.Get, requestUri: uri);

      HttpResponseMessage response = await client.SendAsync(request);

      string jsonString = await response.Content.ReadAsStringAsync();

      IEnumerable<Customer> model = JsonConvert
        .DeserializeObject<IEnumerable<Customer>>(jsonString);

      return View(model);
    }

    public IActionResult Privacy()
    {
      return View();
    }
  }
}