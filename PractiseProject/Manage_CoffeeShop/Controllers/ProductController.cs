using Manage_CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace Manage_CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly DB_Entities _db;
        public ProductController(DB_Entities db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }






    }
}
