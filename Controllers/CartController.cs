using System.Collections.Generic;
using improweb2022_02.PayPal;
using Microsoft.AspNetCore.Mvc;
using PayPal_integration.models;

namespace PayPal_integration.Controllers
{
    [Route("cart")]
    public class CartController: Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            var products = new List<Product>() {
                new Product() { 
                    Id = "P01",
                    Name = "Name 01",
                    Price = 44,
                    Quantity = 1 
                },
                new Product() { 
                    Id = "P02",
                    Name = "Name 02",
                    Price = 42,
                    Quantity = 2 
                },
                new Product() { 
                    Id = "P03",
                    Name = "Name 03",
                    Price = 43,
                    Quantity = 3 
                },
                new Product() { 
                    Id = "P04",
                    Name = "Name 04",
                    Price = 45,
                    Quantity = 1 
                }
            };
            ViewBag.products = products;

            PayPalConfig payPalConfig = PayPalService.getPayPalConfig();
            ViewBag.payPalConfig = payPalConfig;
            return View();
        }
        
        [Route("Success")]
        public IActionResult Success()
        {
            #region  PayPal Transaction
            var result = PDTHolder.Success(Request.Query["tx"].ToString());
            ViewBag.paypalResult = result;
            #endregion
            return View();
        }
    }
}