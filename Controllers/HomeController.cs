using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using projetomvc.DTO;
using ProjetoProgramaStart.Data;

namespace ProjetoProgramaStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _database;
        

        public HomeController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext database)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _database = database;
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
                    return RedirectToAction("Consultar","ProgramaStart");
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
//                    SendMail(dto);
                    return RedirectToAction("Index", "Home");
                }
                else{
                    return View(dto);
                }
                
            }
            else{
                return View(dto);

            }
        }

        public async Task<IActionResult> Logout(){
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AcessoNegado(){
            return View();
        }
        public bool SendMail(LoginDTO dto){
            try
            {
                var user = _database.Empregados.First(x => x.Email == dto.Email);
                MailMessage _mailMessage = new MailMessage();
                _mailMessage.From = new MailAddress("rodrigocostavalle2@gmail.com");

                _mailMessage.CC.Add("rodrigocostavalle@gmail.com");
                _mailMessage.Subject = "Teste";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = "O Scrum Master " + user.Nome + " Logou no sistema";

                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("rodrigocostavalle2@gmail.com", "/Abc123456");
                _smtpClient.EnableSsl = true;
                _smtpClient.Send(_mailMessage);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
