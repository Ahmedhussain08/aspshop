using Microsoft.EntityFrameworkCore;

namespace aspshop.Models
{
    public class shopDbContext :DbContext
    {
        public shopDbContext(DbContextOptions<shopDbContext> options):base(options) { }

        public DbSet<admin> admin { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<brand> brands{ get; set; }
        public DbSet<product> products{ get; set; }
    }
}
