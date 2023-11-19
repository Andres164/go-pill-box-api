using GoPillBox.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GoPillBox.Database
{
    public class GoPillBoxDbContext : DbContext
    {
        public GoPillBoxDbContext(DbContextOptions<GoPillBoxDbContext> options)
            : base(options)
        {

        }


        public DbSet<AlarmEvent> AlarmEvents { get; set; }
        public DbSet<UserMedication> UserMedications { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
