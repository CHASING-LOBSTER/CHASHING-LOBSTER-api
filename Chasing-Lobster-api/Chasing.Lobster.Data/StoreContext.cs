
using System.Net.ServerSentEvents;
using Chasing.Lobster.Domain.catalog;
using Microsoft.EntityFrameworkCore;

namespace Chasing.Lobster.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        {}
        public DbSet<Item> Items { get; set; }
    }
}


