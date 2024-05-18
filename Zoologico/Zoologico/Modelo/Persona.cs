using System.ComponentModel.DataAnnotations;

namespace Zoologico.Modelo
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el máximo de caractéres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo teléfono es obligatorio")]
        [StringLength(10, ErrorMessage = "Excede el máximo de caractéres")]
        public string? Telefono { get; set; }
        public int AreaId { get; set; }
        virtual public Area? Area { get; set; }

    }
}
