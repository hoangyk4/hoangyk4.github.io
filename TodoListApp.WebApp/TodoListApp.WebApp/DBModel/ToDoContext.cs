using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.WebApp.DBModel
{
    public class ToDoContext: DbContext
    {
        public ToDoContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CET-TKDA-005\MSSQLSERVER2016;Database=ToDoList; User Id =sa;password=Abc@1234;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Student> Students { get; set; }
    }
}
