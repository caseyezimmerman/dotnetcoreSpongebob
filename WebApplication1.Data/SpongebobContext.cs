using System;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Common;

namespace WebApplication1.Data
{
    public class SpongebobContext : DbContext
    {
        public SpongebobContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        
        public virtual DbSet<Character> Character { get; set; }
        public virtual DbSet<Episode> Episode { get; set; }
        public virtual DbSet<Season> Season { get; set; }
    }
}