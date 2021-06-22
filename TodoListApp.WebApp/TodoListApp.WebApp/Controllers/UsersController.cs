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
        private readonly ToDoContext context;
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
            return View();
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dao = new UserServices();
                    int id = dao.Insert(collection);
                    if (id > 0)
                    {
                        return RedirectToAction("Index", "Users");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công");
                    }
                }
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/AddOrEdit
        [HttpGet]
        public ActionResult AddOrEdit(int id)
        {
            var userviewdetail = new UserServices().ViewDetail(id);
            var user = new User();
            return PartialView("_UserModelPartial", user);
        }

        // POST: UsersController/AddOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrEdit(User collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var dao = new UserServices();
                    //Create
                    int id = dao.Insert(collection);
                    if (id > 0)
                    {
                        return PartialView("_UserModelPartial", collection);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công");
                    }
                    //Edit
                    var result = dao.Update(collection);
                    if (result)
                    {
                        return PartialView("_UserModelPartial", collection);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Cập nhật thông tin không thành công");
                    }
                }
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            var user = new UserServices().ViewDetail(id);
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var dao = new UserServices();
                    var result = dao.Update(collection);
                    if (result)
                    {
                        return RedirectToAction("Index", "Users");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Cập nhật thông tin không thành công");
                    }
                }
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            new UserServices().Delete(id);
            return RedirectToAction("Index", "Users");
            //return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(User collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
