using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabanRent.ShabanContext
{
    public class ShabanRentDbContext : DbContext
    {
        public ShabanRentDbContext() : base("PutanjaDoBaze")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Datum> Datum { get; set; }

    }
}
