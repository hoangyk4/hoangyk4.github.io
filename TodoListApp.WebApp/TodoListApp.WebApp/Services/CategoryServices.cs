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
        public int Insert(Category entity)
        {
            context.Categories.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }
        public Category GetByID(string category)
        {
            return context.Categories.SingleOrDefault(x => x.Name == category);
        }
        public Category ViewDetail(int id)
        {
            return context.Categories.Find(id);
        }
        public bool Update(Category entity)
        {
            try
            {
                var category = context.Categories.Find(entity.ID);
                category.Name = entity.Name;
                category.Status = entity.Status;
                category.UpdatedDate = entity.UpdatedDate;
                category.UpdatedBy = entity.UpdatedBy;
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
                var category = context.Categories.Find(id);
                context.Categories.Remove(category);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Category> GetAll()
        {
            var rs = context.Categories.ToList();
            return rs;
        }
    }
}
