using chdog.Models;
using Microsoft.EntityFrameworkCore;

namespace chdog.Persistence
{
    public class CHDogDbContext : DbContext
    {
        public CHDogDbContext(DbContextOptions<CHDogDbContext> options) 
            : base(options)
        {
            
        } 
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Raca> Racas { get; set; }
    }
}