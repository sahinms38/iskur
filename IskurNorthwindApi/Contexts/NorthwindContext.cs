using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IskurNorthwindApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IskurNorthwindApi.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Categories");

            base.OnModelCreating(modelBuilder);
        }
    }
}
