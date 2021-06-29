using ClosedXML.Excel;
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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
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
        public IActionResult Edit(int id)
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
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DeleteUserPartial", user);
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
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

        // POST: UsersController/Excel
        public IActionResult Excel()
        {
            using (var workbook = new XLWorkbook())
            {
                var dao = new UserServices();
                var model = dao.GetAllUser();
                var worksheet = workbook.Worksheets.Add("Users");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "UserName";
                worksheet.Cell(currentRow, 3).Value = "Password";
                worksheet.Cell(currentRow, 4).Value = "Name";
                worksheet.Cell(currentRow, 5).Value = "Birth";
                worksheet.Cell(currentRow, 6).Value = "Email";
                worksheet.Cell(currentRow, 7).Value = "Phone";
                worksheet.Cell(currentRow, 8).Value = "Note";
                foreach (var user in model)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = user.ID;
                    worksheet.Cell(currentRow, 2).Value = user.UserName;
                    worksheet.Cell(currentRow, 3).Value = user.Password;
                    worksheet.Cell(currentRow, 4).Value = user.Name;
                    worksheet.Cell(currentRow, 5).Value = user.Birth;
                    worksheet.Cell(currentRow, 6).Value = user.Email;
                    worksheet.Cell(currentRow, 7).Value = user.Phone;
                    worksheet.Cell(currentRow, 8).Value = user.Note;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "users.xlsx");
                }
            }
        }

    }
}
