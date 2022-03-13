using System.ComponentModel.DataAnnotations;

namespace ControleDeAgendamento.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "Nome")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "A {0} pode conter o mínimo de {2} caracteres.", MinimumLength = 6)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Confirmar Senha")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senha não são íguais.")]
        [Required]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Role Name")]
        [Required]
        public string RoleName { get; set; }
    }
}
