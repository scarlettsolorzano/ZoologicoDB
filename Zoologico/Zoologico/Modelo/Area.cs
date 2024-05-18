using System.ComponentModel.DataAnnotations;

namespace Zoologico.Modelo
{
    public class Area
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Seleccionar un encargado es obligatorio")]
        virtual public ICollection<Animal>? Animales { get; set; }
        virtual public ICollection<Persona>? Personas { get; set; }

    }
}
