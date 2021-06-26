using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApp.DBModel;

namespace TodoListApp.WebApp.Controllers
{
    public class TasksController : Controller
    {
        private readonly ToDoContext _context;

        public TasksController(ToDoContext context)
        {
            _context = context;
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tasks.ToListAsync());
        }

        // GET: Tasks/Details/5
        public IActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var task = await _context.Tasks
            //    .FirstOrDefaultAsync(m => m.ID == id);
            //if (task == null)
            //{
            //    return NotFound();
            //}

            //return View(task);
            var task = _context.Tasks.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DetailTaskPartial", task);
        }

        // GET: Tasks/Create
        [HttpGet]
        public IActionResult Create()
        {
            var task = new DBModel.Task();
            return PartialView("_TaskModelPartial", task);
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(DBModel.Task task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();
                return PartialView("_TaskModelPartial", task);
            }
            return View(task);
        }

        // GET: Tasks/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var task = await _context.Tasks.FindAsync(id);
            //if (task == null)
            //{
            //    return NotFound();
            //}
            //return View(task);
            var tasks = _context.Tasks.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_EditTaskPartial", tasks);

        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DBModel.Task task)
        {
            //if (id != task.ID)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(task);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!TaskExists(task.ID))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(task);
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return PartialView("_EditTaskPartial", task);
        }

        // GET: Tasks/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var tasks = _context.Tasks.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DeleteTaskPartial", tasks);
        }
        [HttpPost]
        public IActionResult Delete(DBModel.Task task)
        {
            var tasks = _context.Tasks.Where(x => x.ID == task.ID).FirstOrDefault();
            _context.Tasks.Remove(tasks);
            _context.SaveChanges();
            return PartialView("_DeleteTaskPartial", tasks);
        }

        // POST: Tasks/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var task = await _context.Tasks.FindAsync(id);
        //    _context.Tasks.Remove(task);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool TaskExists(int id)
        {
            return _context.Tasks.Any(e => e.ID == id);
        }
    }
}
