using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.WebApp.DBModel;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TodoListApp.WebApp.Services
{
    public class UserServices
    {
        private ToDoContext context = null;
        public UserServices()
        {
            context = new ToDoContext();
        }
        public List<User> GetAllUser()
        {
            var rs = context.Users.ToList();
            return rs;
        }
        public int Insert(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }
        public User GetByID(string userName)
        {
            return context.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public bool Login(string userName, string passWord)
        {
            var result = context.Users.Count(x => x.UserName == userName && x.Password == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(User entity)
        {
            try
            {
                var user = context.Users.Find(entity.ID);
                user.Name = entity.Name;
                if (!string.IsNullOrEmpty(entity.Password))
                {
                    user.Password = entity.Password;
                }
                user.Email = entity.Email;
                user.Birth = entity.Birth;
                user.Phone = entity.Phone;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var user = context.Users.Find(id);
                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public User ViewDetail(int id)
        {
            var user = context.Users.Where(x => x.ID == id).FirstOrDefault();
            return user;
        }

    }
}
