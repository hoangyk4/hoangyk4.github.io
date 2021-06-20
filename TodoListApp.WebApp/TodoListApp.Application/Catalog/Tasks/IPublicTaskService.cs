using System.Collections.Generic;
using System.Threading.Tasks;
using TodoListApp.ViewModels.Catalog.Products;
using TodoListApp.ViewModels.Comon;

namespace TodoListApp.Application.Catalog.Tasks
{
    public interface IPublicTaskService
    {
        Task<PagedResult<TaskViewModel>> GetAllByTaskID(GetPublicTaskPagingRequest request);
        Task<List<TaskViewModel>> GetAll();
    }
}
