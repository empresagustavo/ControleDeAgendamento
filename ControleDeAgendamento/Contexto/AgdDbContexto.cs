using ControleDeAgendamento.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControleDeAgendamento.Contexto
{
    public class AgdDbContexto : IdentityDbContext<UserApplication>
    {
        public AgdDbContexto(DbContextOptions<AgdDbContexto> pOpcoes) : base(pOpcoes){ }
    }
}
