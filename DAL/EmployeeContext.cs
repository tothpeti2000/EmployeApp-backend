using DAL.DbObjects;
using EntityFramework.Exceptions.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeContext: IdentityDbContext<DbUser>
    {
        public DbSet<DbEmployee> Employees { get; set; }
        public DbSet<DbDepartment> Departments { get; set; }

        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseExceptionProcessor();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigureEmployees(builder);
            ConfigureDepartments(builder);
        }

        private void ConfigureEmployees(ModelBuilder builder) 
        {
            builder.Entity<DbEmployee>()
                .ToTable("Employee");

            builder.Entity<DbEmployee>()
                .HasKey(e => e.Id);

            builder.Entity<DbEmployee>()
                .HasOne(e => e.Superior);

            builder.Entity<DbEmployee>()
                .HasOne(e => e.Department);
        }

        private void ConfigureDepartments(ModelBuilder builder)
        {
            builder.Entity<DbDepartment>()
                .ToTable("Department");

            builder.Entity<DbDepartment>()
                .HasKey(d => d.Id);
        }
    }
}
