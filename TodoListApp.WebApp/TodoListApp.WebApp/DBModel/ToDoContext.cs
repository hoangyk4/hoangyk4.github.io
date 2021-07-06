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

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=CET-TKDA-005\MSSQLSERVER2016;Database=ToDoList; User Id =sa;password=Abc@1234;");
            optionsBuilder.UseSqlServer(@"Server=.;Database=TodoList;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(s => s.ID);
            modelBuilder.Entity<Task>().ToTable("Tasks");
            modelBuilder.Entity<Category>().ToTable("Categories");
            base.OnModelCreating(modelBuilder);
        }
        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
