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
    public class OrderDetailController : Controller
    {       
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        public OrderDetailController() { }

        public OrderDetailController(List<OrderDetail> orderDetails)
        {
            this.orderDetails = orderDetails;
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return orderDetails;
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrderDetailsAsync()
        {
            return await Task.FromResult(GetAllOrderDetails());
        }

    }
}