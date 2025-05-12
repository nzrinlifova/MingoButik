using Microsoft.AspNetCore.Mvc;
using MingoButik.Models;

namespace MingoButik.Controllers
{
    public class HomeController : Controller
    {
 
        public IActionResult Index()
        {
            List<Products> products = new List<Products>();
            Products pruduct1 = new Products
            {
                Id = 1,
                ImgUrl = "evan-mcdougall-qnh1odlqOmk-unsplash.jpeg",
                ProductName = "Tree Pot",
                ProductDescription = "Original package design from house",
                ProductPrice = 56
            };
            Products pruduct2 = new Products
            {
                Id = 1,
                ImgUrl = "jordan-nix-CkCUvwMXAac-unsplash.jpeg",
                ProductName = "Fashion Set",
                ProductDescription = "Costume Package",
                ProductPrice = 65
            };
            Products pruduct3 = new Products
            {
                Id = 1,
                ImgUrl = "nature-zen-3Dn1BZZv3m8-unsplash.jpeg",
                ProductName = "Juice Drinks",
                ProductDescription = "Nature made another world",
                ProductPrice = 48
            };
            products.Add(pruduct1);
            products.Add(pruduct2);
            products.Add(pruduct3);
              
            return View(products);
        }
    }
}
