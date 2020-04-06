using Microsoft.EntityFrameworkCore;

namespace EksamenApi.Models{
    public class restaurantContext : DbContext {

        public restaurantContext(DbContextOptions<restaurantContext> options):base(options){}
        public DbSet<EksamenApi.Models.menu> Menu { get; set; }
        public DbSet<EksamenApi.Models.drink> Drink { get; set; }
        public DbSet<EksamenApi.Models.food> Food { get; set; }
        public DbSet<EksamenApi.Models.customer> Customer { get; set; }
        public DbSet<EksamenApi.Models.admin> Admin { get; set; }
    }
}
