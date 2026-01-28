using ArlebERP.Company.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Database.Configs
{
    public class PermissionConfig : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permission");

            builder.HasKey(p => p.Id)
                .HasName("PK_Permission");
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .IsRequired();
            builder.HasIndex(p => p.Name)
                .IsUnique();

            builder.Property(p => p.Code)
                .IsRequired();
            builder.HasIndex(p => p.Code)
                .IsUnique();
        }
    }
}
