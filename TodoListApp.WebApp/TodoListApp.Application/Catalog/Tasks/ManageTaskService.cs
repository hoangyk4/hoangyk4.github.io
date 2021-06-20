using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Data.EF;
using TodoListApp.Utilities.Exceptions;
using TodoListApp.ViewModels.Catalog.Products;
using TodoListApp.ViewModels.Catalog.Products.Manage;
using TodoListApp.ViewModels.Comon;

namespace TodoListApp.Application.Catalog.Tasks
{
    public class ManageTaskService : IManageTaskService
    {
        private readonly TodoListDbContext _context;
        public ManageTaskService(TodoListDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(TaskCreateRequest request)
        {
            var _task = new Data.Entities.Task()
            {
                Name = request.Name,
                Status = request.Status,
                Owner = request.Owner,
                CategoryID = request.CategoryID,
                IsCompleted = request.IsCompleted,
                DueDate = request.DueDate,
                OverDue = request.OverDue,
                CreatedDate = request.CreatedDate,
                CreatedBy = request.CreatedBy,
                UpdatedDate = request.UpdatedDate,
                UpdatedBy = request.UpdatedBy,
            };
            _context.Tasks.Add(_task);
           return  await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int taskID)
        {
            var _task = await _context.Tasks.FindAsync(taskID);
            if (_task == null) throw new TodoListException($"Canot find a Task: {taskID}");
            _context.Tasks.Remove(_task);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> Update(TaskUpdateRequest request)
        {
            var _task = await _context.Tasks.FindAsync(request.ID);
            if (_task == null) throw new TodoListException($"Canot find a Task with ID: {request.ID}");
            _task.Name = request.Name;
            _task.Status = request.Status;
            _task.Owner = request.Owner;
            _task.IsCompleted = request.IsCompleted;
            _task.OverDue = request.OverDue;
            _task.UpdatedBy = request.UpdatedBy;
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<TaskViewModel>> GetAllPaging(GetManageTaskPagingRequest request)
        {
            var query = from p in _context.Tasks select p;
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.Name.Contains(request.Keyword));
            //if (request.CategoryIds.Count > 0)
            //{
            //    query = query.Where(p => request.CategoryIds.Contains(int p.CategoryID));
            //}
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new TaskViewModel()
            {
                ID = x.ID,
                Name = x.Name,
                Status = x.Status,
                Owner = x.Owner,
                CategoryID = x.CategoryID,
                IsCompleted = x.IsCompleted,
                DueDate = x.DueDate,
                CreatedBy = x.CreatedBy,
                UpdatedBy = x.UpdatedBy,
            }).ToListAsync();
            var pagedResult = new PagedResult<TaskViewModel>()
            {
                TotalRecord = totalRow,
                //PageSize = request.PageSize,
                //PageIndex = request.PageIndex,
                Items = data,
            };
            return pagedResult;
        }

        public Task<TaskViewModel> GetbyId(int taskID)
        {
            throw new NotImplementedException();
        }
    }
}
