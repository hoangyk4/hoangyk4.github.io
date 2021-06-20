using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Data.EF;
using TodoListApp.ViewModels.Catalog.Products;
using TodoListApp.ViewModels.Comon;

namespace TodoListApp.Application.Catalog.Tasks
{
    public class PublicTaskService : IPublicTaskService
    {
        private readonly TodoListDbContext _context;
        public PublicTaskService(TodoListDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskViewModel>> GetAll()
        {
            var query = from p in _context.Tasks select p;
            //if (!string.IsNullOrEmpty(request.TaskID))
            //    query = query.Where(x => x.Name.Contains(request.TaskID));
            //if (request.CategoryIds.Count > 0)
            //{
            //    query = query.Where(p => request.CategoryIds.Contains(int p.CategoryID));
            //}
            int totalRow = await query.CountAsync();
            var data = await query.Select(x => new TaskViewModel()
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
            return data;
        }

        public async Task<PagedResult<TaskViewModel>> GetAllByTaskID(GetPublicTaskPagingRequest request)
        {
            var query = from p in _context.Tasks select p;
            //if (!string.IsNullOrEmpty(request.TaskID))
            //    query = query.Where(x => x.Name.Contains(request.TaskID));
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

    }
}
