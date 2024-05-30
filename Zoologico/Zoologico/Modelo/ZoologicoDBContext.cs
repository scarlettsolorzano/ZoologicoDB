using Microsoft.EntityFrameworkCore;

namespace Zoologico.Modelo
{
    public class ZoologicoDBContext :DbContext 
    {
        //Se crea el constructor de la clase ZoologicoDBContext
        public ZoologicoDBContext(DbContextOptions<ZoologicoDBContext> options) : base(options)
        {
        }
        //Se crean las tablas en el contexto de base de datos 
        public DbSet<Area> Areas { get; set; }
        public DbSet<Animal> Animales { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}
