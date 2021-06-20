using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.Data.Entities;
using TodoListApp.Data.Enums;

namespace TodoListApp.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            //builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            //builder.Property(x => x.CreatedBy).IsRequired();
            //builder.Property(x => x.UpdatedDate).HasDefaultValue(DateTime.Now);
            //builder.Property(x => x.UpdatedBy).IsRequired();
        }
    }
}
