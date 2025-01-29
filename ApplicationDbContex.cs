using Microsoft.EntityFrameworkCore;

namespace DriveSmartAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<VehicleEfficiency> VehicleEfficiencies { get; set; }
    }
}
