using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoListApp.Data.EF
{
    public class TodoListDbContextFactory : IDesignTimeDbContextFactory<TodoListDbContext>
    {
        public TodoListDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<TodoListDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("TodoListAppDatabase"));

            return new TodoListDbContext(optionsBuilder.Options);
        }
    }
}
