using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Model
{
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }


        [Display(Name = "Frente de Trabajo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string UserName { get; set; }

        [Display(Name = "Frente de Trabajo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Email { get; set; }

        [Display(Name = "Frente de Trabajo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Password { get; set; }

    }
}
