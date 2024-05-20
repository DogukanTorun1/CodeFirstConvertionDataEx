using CodeFirstConvertionDataEx.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvertionDataEx.Context
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=.;Database=CodeFirstDB1;Trusted_Connection=True;TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne(a => a.Profile)
            .WithOne(a => a.User)
            .HasForeignKey<Profile>(a => a.Id);

        }



    }
}
