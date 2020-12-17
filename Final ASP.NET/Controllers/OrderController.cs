using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Final_ASP.NET.Models;
using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using Newtonsoft.Json;

namespace Final_ASP.NET.Controllers
{
    public class OrderController : Controller
    {       
        List<Order> orders = new List<Order>();
        public OrderController() { }

        public OrderController(List<Order> orders)
        {
            this.orders = orders;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await Task.FromResult(GetAllOrders());
        }

    }
}