using Microsoft.AspNetCore.Mvc;
using AmazonSaMVC.Models;
using System.Linq;

namespace AmazonSaMVC.Controllers
{
    public class OrderController : Controller
    {
       
        private static readonly List<Order> _orders = new();

       
        private static readonly List<Product> _products = new()
        {
            new() { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 5000, ImageUrl = "laptop.jpg" },
            new() { Id = 2, Name = "Smartphone", Description = "Latest model", Price = 3000, ImageUrl = "smartphone.jpg" },
            new() { Id = 3, Name = "Tablet", Description = "Portable tablet", Price = 2000, ImageUrl = "tablet.jpg" }
        };

      
        [HttpGet]
        public IActionResult Create(int productId)
        {
            var selectedProduct = _products.FirstOrDefault(p => p.Id == productId);
            if (selectedProduct == null) return NotFound();
            return View(new Order { ProductId = selectedProduct.Id, Product = selectedProduct });
        }

       
        [HttpPost]
        public IActionResult PlaceOrder(Order newOrder)
        {
            if (!ModelState.IsValid)
            {
            
                newOrder.Product = _products.FirstOrDefault(p => p.Id == newOrder.ProductId);
                return View("Create", newOrder);
            }


            newOrder.OrderDate = DateTime.Now;


            _orders.Add(newOrder);

            return RedirectToAction("History", new { userId = newOrder.UserId });
        }


        [HttpGet]
        public IActionResult History(string userId)
        {
            
            var userOrders = _orders.Where(o => o.UserId == userId).ToList();

           
            if (!userOrders.Any())
            {
                ViewBag.Message = "No orders found for this user.";
                return View(); 
            }

            return View(userOrders); 
        }
    }
}


