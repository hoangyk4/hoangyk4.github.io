using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.WebApp.DBModel;
using TodoListApp.WebApp.Models;
using TodoListApp.WebApp.Services;

namespace TodoListApp.WebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ToDoContext _context;

        public UsersController(ToDoContext context)
        {
            _context = context;
        }

        // GET: UsersController
        public async Task<IActionResult> Index(int pageNumber=1)
        {
            return View(await PaginatedList<User>.CreateAsync(_context.Users, pageNumber, 5));
        }

        // GET: UsersController/Details/5
        public IActionResult Details(int id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DetailsUserPartial", user);
        }

        // GET: UsersController/Create
        public IActionResult Create()
        {
            var user = new User();
            return PartialView("_UserModelPartial", user);
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return PartialView("_UserModelPartial", user);
            }
            return View();
        }

        // GET: UsersController/Edit/5
        public IActionResult Edit(int id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_EditUserPartial", user);
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(User user)
        {
            // TODO: Add update logic here
            if (ModelState.IsValid)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return PartialView("_EditUserPartial", user);
            }
            return View(user);
        }

        // GET: UsersController/Delete/5
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DeleteUserPartial", user);
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(User user)
        {
            try
            {
                var users = _context.Users.Where(x => x.ID == user.ID).FirstOrDefault();
                _context.Users.Remove(users);
                _context.SaveChanges();
                return PartialView("_DeleteUserPartial", users);
            }
            catch
            {
                return View();
            }
        }

        // POST: UsersController/CSV
        public IActionResult CSV()
        {
            var dao = new UserServices();
            var model = dao.GetAllUser();
            var builder = new StringBuilder();
            builder.AppendLine("ID, UserName, Password, Name, Birth, Email, Phone, Note");
            foreach(var user in model)
            {
                builder.AppendLine($"{user.ID},{user.UserName},{user.Password},{user.Name},{user.Birth},{user.Email},{user.Phone},{user.Note}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "users.csv");
        }

    }
}
