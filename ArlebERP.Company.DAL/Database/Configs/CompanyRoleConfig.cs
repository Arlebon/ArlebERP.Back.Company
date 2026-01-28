using ArlebERP.Company.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Database.Configs
{
    public class CompanyRoleConfig : IEntityTypeConfiguration<CompanyRole>
    {
        public void Configure(EntityTypeBuilder<CompanyRole> builder)
        {
            builder.ToTable("CompanyRole");

            builder.HasKey(r => r.Id)
                .HasName("PK_CompanyRole");
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Name)
                .IsRequired();

            builder.HasMany(r => r.Permissions)
                .WithMany()
                .UsingEntity(j => j.ToTable("CompanyRole_Permissions"));
        }
    }
}
