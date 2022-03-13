using System.ComponentModel.DataAnnotations;

namespace ControleDeAgendamento.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Me lembre?")]
        public bool RememberMe { get; set; }
    }
}
