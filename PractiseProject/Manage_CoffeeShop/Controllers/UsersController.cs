using Manage_CoffeeShop.Models;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Manage_CoffeeShop.Controllers
{
    public class UsersController : Controller
    {
        private readonly DB_Entities _db;
        public UsersController(DB_Entities db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var users = _db.Users.Include(u => u.Role).Select(x => new UserViewModel
            {
                Id = x.Id.ToString(),
                Name = x.Name,
                Password = x.Password,
                RoleId = x.RoleId,
                RoleName = x.Role.Name
            }).ToList();
            return View(users);
        }

        public IActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Login(Users users)
        {
            if (users == null)
            {
                return View(users);
            }
           
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            
            var user = new Users();
            user.Id = Guid.NewGuid();
            user.Name = model.Name;
            user.Password = model.Password;
            user.RoleId = model.RoleId;
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");

          
        }

        public IActionResult Register()
       {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserViewModel model)
        { 
                var user = new Users();

                user.Id = Guid.NewGuid();
                user.Name = model.Name;
                user.Password = model.Password;
                user.RoleId = model.RoleId;
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Login");


        }

        public IActionResult Edit(Guid? id  )
        {

            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            return View(user);

        }
        [HttpPost]
        public IActionResult Edit(Guid id ,UserViewModel model)
        {
            var user = _db.Users.FirstOrDefault( x => x.Id == id);
            user.Name = model.Name;
            user.Password = model.Password;
            user.RoleId = model.RoleId;
            _db.Users.Update(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid? id) 
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost]
        public IActionResult DeleteUser(Guid id,UserViewModel model)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            user.Name = model.Name;
            user.Password = model.Password;
            user.RoleId = model.RoleId;
            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



    


    }
}
