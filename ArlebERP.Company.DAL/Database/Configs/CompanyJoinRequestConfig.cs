using ArlebERP.Company.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Database.Configs
{
    public class CompanyJoinRequestConfig : IEntityTypeConfiguration<CompanyJoinRequest>
    {
        public void Configure(EntityTypeBuilder<CompanyJoinRequest> builder)
        {
            builder.ToTable("CompanyJoinRequest");

            builder.HasKey(jr => jr.Id)
                .HasName("PK_CompanyJoinRequest");
            builder.Property(jr => jr.Id)
                .ValueGeneratedOnAdd();

            builder.Property(jr => jr.UserId)
                .IsRequired();

            builder.Property(jr => jr.CompanyId)
                .IsRequired();

            builder.Property(jr => jr.Status)
                .HasConversion<string>();

            builder.Property(jr => jr.Date)
                .IsRequired();
        }
    }
}
