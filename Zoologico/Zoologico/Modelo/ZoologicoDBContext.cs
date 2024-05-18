using Microsoft.EntityFrameworkCore;

namespace Zoologico.Modelo
{
    public class ZoologicoDBContext :DbContext 
    {
        public ZoologicoDBContext(DbContextOptions<ZoologicoDBContext> options) : base(options)
        {
        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Animal> Animales { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}
