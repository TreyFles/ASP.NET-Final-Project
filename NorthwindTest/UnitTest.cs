using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Final_ASP.NET.Models;
using Final_ASP.NET.Controllers;
using Packt.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NorthwindTest.Tests
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void ProductTest()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductController(testProducts);

            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductController(testProducts);

            var result = await controller.GetAllProductsAsync() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void CustomerTest()
        {
            var testCustomers = GetTestCustomers();
            var controller = new CustomerController(testCustomers);

            var result = controller.GetAllCustomers() as List<Customer>;
            Assert.AreEqual(testCustomers.Count, result.Count);
        }

        [TestMethod]
        public async Task GetAllCustomers_ShouldReturnAllCustomers()
        {
            var testCustomers = GetTestCustomers();
            var controller = new CustomerController(testCustomers);

            var result = await controller.GetAllCustomersAsync() as List<Customer>;
            Assert.AreEqual(testCustomers.Count, result.Count);
        }

        [TestMethod]
        public void OrderTest()
        {
            var testOrders = GetTestOrders();
            var controller = new OrderController(testOrders);

            var result = controller.GetAllOrders() as List<Order>;
            Assert.AreEqual(testOrders.Count, result.Count);
        }

        [TestMethod]
        public void OrderDetailTest()
        {
            var testOrderDetails = GetOrderDetails();
            var controller = new OrderDetailController(testOrderDetails);

            var result = controller.GetAllOrderDetails() as List<OrderDetail>;
            Assert.AreEqual(testOrderDetails.Count, result.Count);
        }


        private List<OrderDetail> GetOrderDetails()
        {
            var testOrderDetails = new List<OrderDetail>();
            testOrderDetails.Add( new OrderDetail
            {
            OrderID = 12345,
            ProductID = 1,
            UnitPrice = 7.99m,
            Quantity = 14,
            Discount = 0.5,
        });

        return testOrderDetails; 
        }

        private List<Order> GetTestOrders()
        {
            var testOrders = new List<Order>();
            testOrders.Add( new Order
            {
            OrderID = 12345,
            CustomerID = "ABCD",
            EmployeeID = 1,
            OrderDate = null ,
            RequiredDate = null,
            ShippedDate = null,
            ShipVia = 1,
            Freight = 7.99m,
            ShipName = "Test Order 1",
            ShipAddress = "Test Order 1",
            ShipCity = "Test Order 1",
            ShipRegion = "Test Order 1",
            ShipPostalCode = "Test Order 1",
            ShipCountry = "Test Order 1",
        });

        return testOrders; 
        }
        private List<Customer> GetTestCustomers()
        {
            var testCustomers = new List<Customer>();
            testCustomers.Add( new Customer
            {
            CustomerID = "ABCD",
            CompanyName = "Test Customer 1",
            ContactName = "Test Customer 1",
            ContactTitle = "Test Customer 1",
            Address = "Test Customer 1",
            City = "Test Customer 1",
            Region = "Test Customer 1",
            PostalCode = "Test Customer 1",
            Country = "Test Customer 1",
            Phone = "Test Customer 1",
            Fax= "Test Customer 1",
        });

        return testCustomers;
        }

        private List<Product> GetTestProducts()
        {
            var testProducts = new List<Product>();
            testProducts.Add( new Product
            {
            ProductID = 1,
            ProductName = "Test Product 1",
            SupplierID = 1,
            CategoryID = 1,
            QuantityPerUnit = "10 boxes x 20 items",
            UnitPrice = 10.01m,
            UnitsInStock = 1,
            UnitsOnOrder = 99,
            ReorderLevel = 1,
            Discontinued = false,
        });

        return testProducts;
        }

    }
}
