using System.ComponentModel.DataAnnotations;

namespace Zoologico.Modelo
{
    public class Area
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de área es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el máximo de caractéres")]
        public string? Nombre { get; set; }
        
        virtual public ICollection<Animal>? Animales { get; set; } // sirve para hacer la relación con la tabla Animal
        virtual public ICollection<Persona>? Personas { get; set; } // sirve para hacer la relación con la tabla Persona

    }
}
