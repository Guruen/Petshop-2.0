using Microsoft.EntityFrameworkCore;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.SQLite.Data
{
    public class PetShopContext: DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> opt): base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>()
                .HasMany(p => p.Pets)
                .WithOne(o => o.Owner)
                .OnDelete(DeleteBehavior.SetNull);
        }

        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }

    }
}
