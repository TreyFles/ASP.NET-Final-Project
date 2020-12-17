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
    public class CustomerController : Controller
    {       
        List<Customer> customers = new List<Customer>();

        public CustomerController() { }

        public CustomerController(List<Customer> customers)
        {
            this.customers = customers;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await Task.FromResult(GetAllCustomers());
        }
    }
}