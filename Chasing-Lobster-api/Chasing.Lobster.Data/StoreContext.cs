
using System.Net.ServerSentEvents;
using Chasing.Lobster.Domain.catalog;
using Microsoft.EntityFrameworkCore;
using Chasing.Lobster.Domain.Orders;

namespace Chasing.Lobster.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        {}
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}


