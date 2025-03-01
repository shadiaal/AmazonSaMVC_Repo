using Microsoft.AspNetCore.Mvc;
using AmazonSaMVC.Models;
namespace AmazonSaMVC.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> _products = new()
        {
            new() { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 5000, ImageUrl = "laptop.jpg" },
            new() { Id = 2, Name = "Smartphone", Description = "Latest model", Price = 3000, ImageUrl = "smartphone.jpg" },
            new() { Id = 3, Name = "Tablet", Description = "Portable tablet", Price = 2000, ImageUrl = "tablet.jpg" }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(_products);
        }
    

    }
}