using Zoologico.Modelo;

namespace Zoologico.Repositorio
{
    public interface IRepositorioAnimales
    {
        Task<List<Animal>> GetAll();
        Task<Animal?> Get(int id);
        Task<Animal> Add(Animal animal);
        Task Update(int id, Animal animal);
        Task Delete(int id);
        Task<List<Area>> GetAreas();
    }
}
