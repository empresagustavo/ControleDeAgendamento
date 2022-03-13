using ControleDeAgendamento.Contexto;
using ControleDeAgendamento.Models;
using ControleDeAgendamento.Models.ViewModels;
using ControleDeAgendamento.Models.ViewModels.Enumerators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControleDeAgendamento.Controllers
{
    public class AccountController : Controller
    {
        private readonly AgdDbContexto _contexto;

        //Aqui estou mapeando e configurando quem é que vai ser minha 
        //classe de autenticação de usuário.
        private UserManager<UserApplication> _userManager;
        private SignInManager<UserApplication> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        //Aqui eu faço a injeção de dependencia.
        public AccountController(AgdDbContexto pContexto, UserManager<UserApplication> pUserManager,
            SignInManager<UserApplication> pSignInManager, RoleManager<IdentityRole> pRoleManager)
        {
            _contexto = pContexto;
            _userManager = pUserManager;
            _signInManager = pSignInManager;
            _roleManager = pRoleManager;
        }

        public IActionResult Index()
        {



            return View();
        }

        public async Task<IActionResult> Register()
        {
            if (!_roleManager.RoleExistsAsync(Helper.Admin).GetAwaiter().GetResult())
            {
                foreach (var role in Helper.GetHelperList())
                {
                    await _roleManager.CreateAsync(new IdentityRole(role.Text));
                }
            }

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel pRegister)
        {
            if (ModelState.IsValid)
            {
                var user = new UserApplication
                {
                    Name = pRegister.Name,
                    Email = pRegister.Email,
                    UserName = pRegister.Email
                };

                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, pRegister.RoleName);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
    }
}
