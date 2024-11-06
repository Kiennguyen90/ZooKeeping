using Microsoft.EntityFrameworkCore;

namespace ZooKeeping
{
    public class AnimalDbContext : DbContext
    {
        public AnimalDbContext(DbContextOptions<AnimalDbContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
