using Microsoft.AspNetCore.Identity;

namespace ControleDeAgendamento.Models
{
    public class UserApplication : IdentityUser
    {
        public string Name { get; set; }
    }
}
