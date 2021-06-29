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
            var tasks = _context.Tasks.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_EditTaskPartial", tasks);

        }

        // POST: Tasks/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(DBModel.Task task)
        {
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

        // POST: Tasks/Delete/5
        [HttpPost]
        public IActionResult Delete(DBModel.Task task)
        {
            var tasks = _context.Tasks.Where(x => x.ID == task.ID).FirstOrDefault();
            _context.Tasks.Remove(tasks);
            _context.SaveChanges();
            return PartialView("_DeleteTaskPartial", tasks);
        }

        private bool TaskExists(int id)
        {
            return _context.Tasks.Any(e => e.ID == id);
        }

        // POST: Tasks/CSV
        public IActionResult CSV()
        {
            var dao = new TaskServices();
            var model = dao.GetAll();
            var builder = new StringBuilder();
            builder.AppendLine("ID, Name, Status, Owner, CategoryID, IsCompleted, DueDate, OverDue, CreatedDate, CreatedBy, UpdateDate, UpdateBy");
            foreach (var task in model)
            {
                builder.AppendLine($"{task.ID},{task.Name},{task.Status},{task.Owner},{task.CategoryID},{task.IsCompleted},{task.DueDate},{task.OverDue},{task.CreatedDate},{task.CreatedBy},{task.UpdatedDate},{task.UpdatedBy}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "tasks.csv");
        }
    }
}
