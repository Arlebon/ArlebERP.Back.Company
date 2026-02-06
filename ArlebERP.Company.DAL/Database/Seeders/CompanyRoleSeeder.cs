using ArlebERP.Company.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Database.Seeders
{
    public class CompanyRoleSeeder : IEntityTypeConfiguration<CompanyRole>
    {
        public void Configure(EntityTypeBuilder<CompanyRole> builder)
        {
            builder.HasData(new CompanyRole { Id = 1, Name = "Admin"},
                            new CompanyRole { Id = 2, Name = "Accountable"},
                            new CompanyRole { Id = 3, Name = "Stock Manager"},
                            new CompanyRole { Id = 4, Name = "RH Manager"});
        }
    }
}
