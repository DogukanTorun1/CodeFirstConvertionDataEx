using CodeFirstConvertionDataEx.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvertionDataEx.Context
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employment> Employments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=.;Database=CodeFirstDB1;Trusted_Connection=True;TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Employment)
                .WithOne(e => e.Employee)
                .HasForeignKey<Employment>(e => e.EmployeeId);
        }



    }
}
