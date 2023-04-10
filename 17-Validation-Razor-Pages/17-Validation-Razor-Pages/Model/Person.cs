using System.ComponentModel.DataAnnotations;

namespace _17_Validation_Razor_Pages.Model
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(25, ErrorMessage = "{0} La longitud debe estar entre {2} y {1}.", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(18, 100, ErrorMessage = "Solo se permiten mayores de edad")]
        public int? Age { get; set; }
    }
}
