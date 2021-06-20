using System.Threading.Tasks;
using TodoListApp.ViewModels.Catalog.Products;
using TodoListApp.ViewModels.Catalog.Products.Manage;
using TodoListApp.ViewModels.Comon;

namespace TodoListApp.Application.Catalog.Tasks
{
    public interface IManageTaskService
    {
        Task<int> Create(TaskCreateRequest request);
        Task<int> Update(TaskUpdateRequest request);
        Task<int> Delete(int taskID);
        Task<TaskViewModel> GetbyId(int taskID);
        Task<PagedResult<TaskViewModel>> GetAllPaging(GetManageTaskPagingRequest request);
    }
}
