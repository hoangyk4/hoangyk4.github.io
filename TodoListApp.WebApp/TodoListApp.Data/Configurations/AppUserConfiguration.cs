using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.Data.Entities;

namespace TodoListApp.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.UserName).HasMaxLength(200);
            builder.Property(x => x.PasswordHash).HasMaxLength(200);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Birth).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200);
            builder.Property(x => x.PhoneNumber).HasMaxLength(200);
            //builder.Property(x => x.Note).HasMaxLength(1000);
        }
    }
}
