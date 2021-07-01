using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApp.DBModel;
using TodoListApp.WebApp.Services;

namespace TodoListApp.WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ToDoContext _context;

        public CategoriesController(ToDoContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public IActionResult Details(int id)
        {
            var category = _context.Categories.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DetailCategoryPartial", category);
        }

        // GET: Categories/Create
        [HttpGet]
        public IActionResult Create()
        {
            var category = new DBModel.Category();
            return PartialView("_CreateCategoryPartial", category);
        }

        // POST: Categories/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return PartialView("_CreateCategoryPartial", category);
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_EditCategoryPartial", category);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return PartialView("_EditCategoryPartial", category);
            }
            return View(category);
        }

        //// GET: Categories/Delete/5
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DeleteCategoryPartial", category);
        }

        //// POST: Categories/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(Category collection)
        {
            try
            {
                var category = _context.Categories.Where(x => x.ID == collection.ID).FirstOrDefault();
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return PartialView("_DeleteCategoryPartial", category);
            }
            catch
            {
                return View();
            }
        }

        //// POST: Categories/CSV
        public IActionResult CSV()
        {
            var dao = new CategoryServices();
            var model = dao.GetAll();
            var builder = new StringBuilder();
            builder.AppendLine("ID, Name, Status, CreatedDate, CreatedBy, UpdateDate, UpdateBy");
            foreach (var category in model)
            {
                builder.AppendLine($"{category.ID},{category.Name},{category.Status},{category.CreatedDate},{category.CreatedBy},{category.UpdatedDate},{category.UpdatedBy}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "categories.csv");
        }
    }
}
