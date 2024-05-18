using Zoologico.Modelo;

namespace Zoologico.Repositorio
{
    public interface IRepositorioPersonas
    {
        Task<List<Persona>> GetAll();
        Task<List<Area>> GetAreas();
        Task<Persona?> Get(int id);
        Task<Persona> Add(Persona persona);
        Task Update(int id, Persona persona);
        Task Delete(int id);
    }
}
