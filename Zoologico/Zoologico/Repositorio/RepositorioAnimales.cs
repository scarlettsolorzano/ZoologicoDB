using Zoologico.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Zoologico.Repositorio
{
    public class RepositorioAnimales : IRepositorioAnimales
    {
        public async Task<List<Animal>> GetAll()
        {
            return await _context.Animales.ToListAsync();
        }
        public async Task<Animal?> Get(int id)
        {
            return await _context.Animales.FindAsync(id);
        }
        public async Task<Animal> Add(Animal animal)
        {
            await _context.Animales.AddAsync(animal);
            await _context.SaveChangesAsync();
            return animal;
        }
        public async Task Update(int id, Animal animal)
        {
            var animalactual = await _context.Animales.FindAsync(id);
            if (animalactual != null)
            {
                animalactual.Especie = animal.Especie;
                animalactual.AreaId = animal.AreaId;
                await _context.SaveChangesAsync();
            }
        }
        public async Task Delete(int id)
        {
            var animal = await _context.Animales.FindAsync(id);
            if (animal != null)
            {
                _context.Animales.Remove(animal);
                await _context.SaveChangesAsync();
            }
        }
        private readonly ZoologicoDBContext _context;
        public RepositorioAnimales(ZoologicoDBContext context)
        {
            _context = context;
        }
    }
}
