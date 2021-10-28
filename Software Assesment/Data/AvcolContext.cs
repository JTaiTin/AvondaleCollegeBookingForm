using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Software_Assesment.Models;

namespace Software_Assesment.Data
{
    public class AvcolContext : DbContext
    {
        public AvcolContext (DbContextOptions<AvcolContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().ToTable("Booking");
        }

        public DbSet<Software_Assesment.Models.Booking> Booking { get; set; }
    }
}
