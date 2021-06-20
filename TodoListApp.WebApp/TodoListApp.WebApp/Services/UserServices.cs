using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.WebApp.DBModel;

namespace TodoListApp.WebApp.Services
{
    public class UserServices
    {
        public List<Student> GetAllUser()
        {
            var ctx = new ToDoContext();
            var rs = ctx.Students.ToList();
            return rs;
        }

    }
}
