using ArlebERP.Company.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Database.Seeders
{
    public class PermissionSeeder : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasData(new Permission { Id = 1, Name = "Global Modifidcation", Code = "GLO" },
                            new Permission { Id = 2, Name = "Accounting", Code = "ACC" },
                            new Permission { Id = 3, Name = "Stock", Code = "STK" },
                            new Permission { Id = 4, Name = "HR", Code = "HR"});
        }
    }
}
