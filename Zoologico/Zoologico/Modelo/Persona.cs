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
        [Length(10, 10, ErrorMessage = "El campo debe tener exactamente 10 caracteres.")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Selecciona un área")]
        public int AreaId { get; set; }
        //1 persona pertenece a un área y un área puede tener muchas personas
        virtual public Area? Area { get; set; } // sirve para hacer la relación con la tabla Area

    }
}
