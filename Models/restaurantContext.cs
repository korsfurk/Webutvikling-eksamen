using Microsoft.EntityFrameworkCore;

namespace EksamenApi.Models{
    public class restaurantContext : DbContext {

        public restaurantContext(DbContextOptions<restaurantContext> options):base(options){}
        public DbSet<EksamenApi.Models.restaurant> Restaurant { get; set; }
        public DbSet<EksamenApi.Models.kunde> Kunde { get; set; }
        public DbSet<EksamenApi.Models.admin> Admin { get; set; }
    }
}
