using Zoologico.Modelo;

namespace Zoologico.Repositorio
{
    public interface IRepositorioAreas
    {
        Task<List<Area>> GetAll();
        Task<Area?> Get(int id);
        Task<Area> Add(Area area);
        Task Update(int id, Area area);
        Task Delete(int id);
    }
}
