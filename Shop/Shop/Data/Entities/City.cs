using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carácteres.")]
        public string Name { get; set; }

        public State State { get; set; }
        
    }
}
