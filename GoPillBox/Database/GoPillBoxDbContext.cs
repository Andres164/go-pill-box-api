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
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationInTreatment> MedicationInTreatments { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
