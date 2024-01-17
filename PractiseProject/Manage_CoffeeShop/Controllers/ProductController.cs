using Manage_CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using System.Drawing;

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
            var product = _db.Products.Select(e => new ProductViewModel
            {
                Id=e.Id.ToString(),
                Name = e.Name,
                Description = e.Description,
                Quantity = e.Quantity,
                Images = e.Images.ToString(),
                Price = e.Price,
            }).ToList();
            return View(product);
        }

        
        public IActionResult GetImage(Guid? id)
        {
            var product = _db.Products.Find(id);

            if (product.Images != null)
            {
                return File(product.Images, "images/jpg");
            }
            else
            {
                return NotFound();
            }
        }



        public IActionResult ListMenu() 
        {
            var product = _db.Products.Select(e => new ProductViewModel
            {
                Id = e.Id.ToString(),
                Name = e.Name,
                Description = e.Description,
                Quantity = e.Quantity,
                Images = e.Images.ToString(),
                Price = e.Price,
            }).ToList();
            return View(product);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel model,List<IFormFile> files) 
        {
            var product = new Product();
            product.Id = Guid.NewGuid();
            product.Name = model.Name;
            product.Description = model.Description;
            product.Quantity = model.Quantity;
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var filePath = Path.GetTempFileName();

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        formFile.CopyToAsync(stream);
                        product.Images=model.Images;
                    }
                    
                }
            }
            product.Price = model.Price;
            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        }

        public IActionResult Edit(Guid? id)
        {
            var product = _db.Products.FirstOrDefault(e => e.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel model,Guid? id)
        {
  
            return RedirectToAction("Index");

        }

        public IActionResult Delete(Guid? id)
        {
            var product = _db.Products.FirstOrDefault(e => e.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(ProductViewModel model, Guid? id)
        {

            return RedirectToAction("Index");

        }


        public IActionResult DetailProduct(Guid? id)
        {
            var product = _db.Products.FirstOrDefault(e => e.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DetailProduct(ProductViewModel model, Guid? id)
        {

      
            return RedirectToAction("Index");
        }

    }
}
