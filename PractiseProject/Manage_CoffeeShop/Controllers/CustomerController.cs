using Manage_CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Manage_CoffeeShop.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DB_Entities _db;
        public CustomerController(DB_Entities db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var customer = _db.Customers.Select(c => new CustViewModel
            {
                Id = c.Id.ToString(),
                Name = c.Name,
                Phone = c.Phone,
                Email = c.Email,
                Country = c.Country,
            }).ToList();
            return View(customer);
        }

        public IActionResult Create() 
        {
     
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustViewModel model)
        {
            var customer = new Customers();
            customer.Id = Guid.NewGuid();
            customer.Name =model.Name;
            customer.Phone = model.Phone;  
            customer.Email = model.Email;
            customer.Country = model.Country;
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid? id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(CustViewModel model,Guid? id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            customer.Name = model.Name;
            customer.Phone = model.Phone;  
            customer.Email = model.Email;
            customer.Country = model.Country;
            _db.Customers.Update(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid? id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(CustViewModel model,Guid? id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            customer.Name = model.Name;
            customer.Phone = model.Phone;
            customer.Email = model.Email;
            customer.Country = model.Country;
            _db.Customers.Remove(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
