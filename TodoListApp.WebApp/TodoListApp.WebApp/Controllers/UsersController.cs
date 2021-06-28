using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.WebApp.DBModel;
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
        public ActionResult Index()
        {
            var dao = new UserServices();
            var model = dao.GetAllUser();
            return View(model);
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
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
        //[ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return PartialView("_UserModelPartial", user);
            }
            return View(user);
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_EditUserPartial", user);
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
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
        public ActionResult Delete(int id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DeleteUserPartial", user);
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(User user)
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
    }
}
