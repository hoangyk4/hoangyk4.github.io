using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.WebApp.DBModel;

namespace TodoListApp.WebApp.Services
{
    public class TaskServices
    {
        private ToDoContext context = null;
        public TaskServices()
        {
            context = new ToDoContext();
        }
        public List<DBModel.Task> GetAllUser()
        {
            var rs = context.Tasks.ToList();
            return rs;
        }
    }
}
