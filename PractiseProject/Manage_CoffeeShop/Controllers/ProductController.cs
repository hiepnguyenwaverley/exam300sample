using Manage_CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Web;

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
            var product = _db.Products.FirstOrDefault(p => p.Id == id);

            if (product.Images != null)
            {
                return File(product.Images, "images/jpg");
            }
            else
            {
                return Content("Images not found");
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
        public IActionResult Create(ProductViewModel model,List<IFormFile> Files) 
        {
            var product = new Product();
            product.Id = Guid.NewGuid();
            product.Name = model.Name;
            product.Description = model.Description;
            product.Quantity = model.Quantity;
            
            if(Files == null || Files.Count == 0)
            {
                ModelState.AddModelError("Images", "Please upload images");
                return View(model);
            }
            var File = Files[0];
            if (File.Length == 0)
            {
                ModelState.AddModelError("Images", "File is empty");
                return View(model);
            }
            var fileName = Path.GetFileName(File.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images");
            string fileNamePath = Path.Combine(filePath, fileName);
            using (var stream = new FileStream(fileNamePath, FileMode.Create))
            {
                File.CopyTo(stream);
            }

            byte[] bytes = Encoding.UTF8.GetBytes(fileNamePath);
            string strings = Encoding.UTF8.GetString(bytes);
            product.Images = bytes;
            
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
        public IActionResult Edit(Guid id,ProductViewModel model, List<IFormFile> Files)
        {
            var product = _db.Products.FirstOrDefault(e => e.Id == id);
            product.Name = model.Name;
            product.Description = model.Description;
            product.Quantity = model.Quantity;
           
         
            
            product.Price = model.Price;
            _db.Products.Update(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid? id)
        {
            var product = _db.Products.FirstOrDefault(e => e.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(ProductViewModel model, Guid id,List<IFormFile>Files)
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
