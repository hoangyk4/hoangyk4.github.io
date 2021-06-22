using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.WebApp.DBModel;

namespace TodoListApp.WebApp.Services
{
    public class CategoryServices
    {
        private ToDoContext context = null;
        public CategoryServices()
        {
            context = new ToDoContext();
        }
        public List<Category> GetAllUser()
        {
            var rs = context.Categories.ToList();
            return rs;
        }
    }
}
