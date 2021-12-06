using System;
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
        public readonly ApplicationDbContext _database;

        public ColaboradoresController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ApplicationDbContext database)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
                await _userManager.AddClaimAsync(user, new Claim("url", empregado.urlImagem));
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
                return RedirectToAction("Consultar", "Colaboradores");
            }else{
                return RedirectToAction("Cadastrar", "Colaboradores", empregado);
            }
        }

        public IActionResult Editar(string id){
            var e = _database.Empregados.First(x => x.Id == id);
            EmpregadoDTO dto = new EmpregadoDTO();
            dto.Id = e.Id;
            dto.Nome = e.Nome;
            dto.Letras = e.Letras;
            dto.Email = e.Email;
            dto.Cargo = e.Cargo.ToString();
            dto.Senha = e.PasswordHash;
            return View(dto);

        }

        [HttpPost]
        public async Task<IActionResult> Atualiar(EmpregadoDTO dto)
        {
            var user = _database.Empregados.First(x => x.Id == dto.Id);
            user.UserName = dto.Nome;
            user.Nome = dto.Nome;
            user.Cargo = Enum.Parse<Cargo>(dto.Cargo);
            user.Email = dto.Email;
            user.Letras = dto.Letras;


            var result = await _userManager.UpdateAsync(user);
            await _userManager.AddClaimAsync(user, new Claim("Permissao", user.Cargo.ToString()));
            await _userManager.AddClaimAsync(user, new Claim("url", dto.urlImagem));

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return RedirectToAction("Consultar", "Colaboradores");
        }
        

        public async Task<IActionResult> Excluir(string id){
            var user = await _userManager.FindByIdAsync(id);
            if (_database.Grupos.Any(x => x.ScrumMaster.Id == id)){
                ViewBag.M = "Há um grupo cadastrado para este usuario, exclua este grupo primeiro";
                var lista = _database.Empregados.ToList();
                return View("Consultar", lista);
            }

            var result = await _userManager.DeleteAsync(user);
            return RedirectToAction("Consultar", "Colaboradores");
        }
    }
}