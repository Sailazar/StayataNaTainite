using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace StayataNaTainite.Data
{
    public class StayataNaTainiteContext : DbContext
    {
        public StayataNaTainiteContext (DbContextOptions<StayataNaTainiteContext> options)
            : base(options)
        {
        }

        public DbSet<Models.User> User { get; set; } = default!;
        public DbSet<Models.Creation> Creation { get; set; } = default!;
    }
}
