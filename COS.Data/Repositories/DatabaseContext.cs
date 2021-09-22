using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using COS.Core.Models;

namespace COS.Data.Repositories
{
    // The Context is How EntityFramework communicates with the database
    // We define DbSet properties for each table in the database
    public class DatabaseContext : DbContext
    {
        // autentication store
        public DbSet<User> Users { get; set; }

        // create DbSets for models
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<UserFavourite> UserFavourites { get; set; }

        // Configure the context to use Specified database. We are using 
        // Sqlite database as it does not require any additional installations.
        // Could use SqlServer using connection below if installed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasKey(x => new { x.OrderId, x.ItemId });
            modelBuilder.Entity<UserFavourite>().HasKey(x => new { x.UserId, x.ItemId });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                /** use logger to log the sql commands issued by entityframework **/
                // .UseLoggerFactory(new ServiceCollection()
                //      .AddLogging(builder => builder.AddConsole())
                //      .BuildServiceProvider()
                //      .GetService<ILoggerFactory>()
                //  )    
                .UseSqlite("Filename=COS.db");
            //.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=SMS; Trusted_Connection=True;ConnectRetryCount=0");
        }

        // Convenience method to recreate the database thus ensuring  the new database takes 
        // account of any changes to the Models or DatabaseContext
        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }
}
