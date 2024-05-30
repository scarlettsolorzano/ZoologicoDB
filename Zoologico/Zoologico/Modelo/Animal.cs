using System.ComponentModel.DataAnnotations;

namespace Zoologico.Modelo
{
    public class Animal
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Especie es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el máximo de caractéres")]
        public string? Especie { get; set; }
        [Required(ErrorMessage = "El campo Sexo es obligatorio")]
        public string? Sexo { get; set; }
        [Required(ErrorMessage = "Selecciona un área")]
        public int AreaId { get; set; }
        //1 animal pertenece a un área y un área puede tener muchos animales
        virtual public Area? Area { get; set; } // sirve para hacer la relación con la tabla Area
        
    }

}
