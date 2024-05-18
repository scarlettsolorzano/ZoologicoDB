using Zoologico.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Zoologico.Repositorio
{
    public class RepositorioAreas : IRepositorioAreas
    {
        private readonly ZoologicoDBContext _context;

        public RepositorioAreas(ZoologicoDBContext context)
        {
            _context = context;
        }
        public async Task<List<Area>> GetAll()
        {
            return await _context.Areas.ToListAsync();
        }
        public async Task<Area?> Get(int id)
        {
            return await _context.Areas.FindAsync(id);
        }
        public async Task<Area> Add(Area area)
        {
            await _context.Areas.AddAsync(area);
            await _context.SaveChangesAsync();
            return area;
        }
        public async Task Update(int id, Area area)
        {
            var areaactual = await _context.Areas.FindAsync(id);
            if (areaactual != null)
            {
                areaactual.Nombre = area.Nombre;
                await _context.SaveChangesAsync();
            }
        }
        public async Task Delete(int id)
        {
            var area = await _context.Areas.FindAsync(id);
            if (area != null)
            {
                _context.Areas.Remove(area);
                await _context.SaveChangesAsync();
            }
        }
    }
}



