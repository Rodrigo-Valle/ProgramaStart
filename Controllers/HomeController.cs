using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projetomvc.DTO;
using projetomvc.Models;
using ProjetoProgramaStart.Models;

namespace ProjetoProgramaStart.Controllers
{
    public class HomeController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        

        public HomeController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager )
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated==false)
            {
                return RedirectToAction("Login", "Home");
                
            }
            else{
                if (User.HasClaim(c => c.Value == "Administrador"))
                {
                    return View();
                }
                else if (User.HasClaim(c => c.Value == "ScrumMaster")){
                    return RedirectToAction("Index", "Scrum");
                }
                else {
                    return View("Login");
                }
            }
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logar(LoginDTO dto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    dto.Email, dto.Password, isPersistent : false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                else{
                    return View(dto);
                }
                
            }
            else{
                return View(dto);

            }
        }
    }
}
