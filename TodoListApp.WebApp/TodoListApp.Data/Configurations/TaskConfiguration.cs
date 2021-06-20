using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoListApp.Data.Entities;
using TodoListApp.Data.Enums;

namespace TodoListApp.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Tasks");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Status).HasDefaultValue(StatusTask.Todo);
            builder.Property(x => x.IsCompleted).HasDefaultValue(IsCompelete.NotSuccess);
            builder.Property(x => x.OverDue).HasDefaultValue(null);
           //builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            //builder.Property(x => x.CreatedBy).IsRequired();
            //builder.Property(x => x.UpdatedDate).HasDefaultValue(DateTime.Now);
            //builder.Property(x => x.UpdatedBy).IsRequired();

        }
    }
}
