using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using projetomvc.Models;
using projetomvc.Models.Enum;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{  
    [Authorize(Policy = "Scrum")] 
    public class ScrumController : Controller
    {
        private readonly ApplicationDbContext _database;
        private readonly UserManager<IdentityUser> _userManager;

        public ScrumController(ApplicationDbContext database, UserManager<IdentityUser> userManager){
            _database = database;
            _userManager = userManager;
        }

        public IActionResult Index(){
            var id = _userManager.GetUserId(User);
            var user = _database.Empregados.First(x => x.Id == id);
            if(user.Cargo == Cargo.Administrador){
                return RedirectToAction("Consultar", "AdminScrum");
            }
            else{
                var grupo = _database.Grupos.First(x => x.ScrumMaster.Id == id);
                ViewBag.Starter = _database.Starters.Where(x => x.Grupo.Id == grupo.Id);
                return View(grupo);
            }
        }

        public IActionResult ConsultarGrupoAdmin(int id){
            var grupo = _database.Grupos.First(x => x.Id == id);
            ViewBag.Starter = _database.Starters.Where(x => x.Grupo.Id == grupo.Id);
            return View("/Views/Scrum/Index.cshtml", grupo);
        }
    }
}