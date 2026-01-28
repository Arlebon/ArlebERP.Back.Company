using ArlebERP.Company.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Database.Configs
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(e => e.Id)
                .HasName("PK_Employee");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Firstname)
                .IsRequired();

            builder.Property(e => e.Lastname)
                .IsRequired();

            builder.Property(e => e.Email)
                .IsRequired();

            builder.Property(e => e.Phone)
                .IsRequired();

            builder.OwnsOne(e => e.Address, a =>
            {
                a.Property(a => a.Street)
                    .IsRequired();
                a.Property(a => a.StreetNumber)
                    .IsRequired();
                a.Property(a => a.City)
                    .IsRequired();
                a.Property(a => a.ZipCode)
                    .IsRequired();
                a.Property(a => a.Country)
                    .IsRequired();
            });

            builder.HasMany(e => e.Roles)
                .WithMany()
                .UsingEntity(j => j.ToTable("Employee_Role"));

            builder.HasOne(e => e.Company)
                .WithMany(c => c.Employees)
                .HasForeignKey(e => e.CompanyId);
        }
    }
}
