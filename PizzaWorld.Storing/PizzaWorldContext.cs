using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
  public class PizzaWorldContext : DbContext
  {
    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=fredpizzaworlddb.database.windows.net;Initial Catalog=PizzaWorldDb;User ID=sqladmin;Password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(s => s.EntityId);
      builder.Entity<User>().HasKey(u => u.EntityId);
      builder.Entity<Order>().HasKey(o => o.EntityId);
      builder.Entity<APizzaModel>().HasKey(p => p.EntityId);

      builder.Entity<Store>().Property(s => s.EntityId).ValueGeneratedNever();

      SeedData(builder);
    }

    private void SeedData(ModelBuilder builder)
    {
      builder.Entity<Store>().HasData(new List<Store>
        {
          new Store() { EntityId = 2, Name = "One" },
          new Store() { EntityId = 3, Name = "Two" }
        }
      );
    }
  }
}
