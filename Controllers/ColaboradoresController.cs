using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projetomvc.DTO;
using projetomvc.Models;
using projetomvc.Models.Enum;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    [Authorize(Policy = "Admin")]
    public class ColaboradoresController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        public readonly ApplicationDbContext _database;

        public ColaboradoresController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext database)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _database = database;
        }

        public IActionResult Consultar(){
            var lista = _database.Empregados.ToList();
            return View(lista);
        }
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(EmpregadoDTO empregado)
        {
            if (ModelState.IsValid)
            {
                // Copia os dados do RegisterViewModel para o IdentityUser
                var user = new Empregado
                {
                    UserName = empregado.Email,
                    Email = empregado.Email,
                    Nome = empregado.Nome,
                    Letras = empregado.Letras,
                    Cargo = Enum.Parse<Cargo>(empregado.Cargo)
                };
                // Armazena os dados do usuário na tabela AspNetUsers
                var result = await _userManager.CreateAsync(user, empregado.Senha);
                await _userManager.AddClaimAsync(user, new Claim("Permissao", user.Cargo.ToString()));

                // Se o usuário foi criado com sucesso, faz o login do usuário
                // usando o serviço SignInManager e redireciona para o Método Action Index
                //if (result.Succeeded)
                //{
                //    await _signInManager.SignInAsync(user, isPersistent: false);
                //    return RedirectToAction("index", "home");
                //}
                // Se houver erros então inclui no ModelState
                // que será exibido pela tag helper summary na validação
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return RedirectToAction("Consultar", "Colaboradores");
        }



    }
}