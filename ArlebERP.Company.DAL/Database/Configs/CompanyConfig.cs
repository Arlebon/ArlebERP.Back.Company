using Entities = ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArlebERP.Company.DAL.Database.Configs
{
    public class CompanyConfig : IEntityTypeConfiguration<Entities.Company>
    {
        public void Configure(EntityTypeBuilder<Entities.Company> builder)
        {
            builder.ToTable("Company");

            builder.HasKey(c => c.Id)
                .HasName("PK_Company");
            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasIndex(c => c.VatNumber)
                .IsUnique();
            builder.Property(c => c.VatNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(15);

            builder.OwnsOne(c => c.HeadquarterAddress, a =>
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

            builder.HasMany(c => c.Employees)
                .WithOne(e => e.Company)
                .HasForeignKey(e => e.CompanyId);
        }
    }
}
