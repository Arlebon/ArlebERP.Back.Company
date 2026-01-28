using Entities = ArlebERP.Company.DL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ArlebERP.Company.DL.Entities;

namespace ArlebERP.Company.DAL.Database
{
    public class ArlebERPCompanyContext: DbContext
    {
        public ArlebERPCompanyContext(DbContextOptions<ArlebERPCompanyContext> options) : base(options) { }

        public DbSet<Entities.Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CompanyRole> CompanyRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArlebERPCompanyContext).Assembly);
        }
    }
}
