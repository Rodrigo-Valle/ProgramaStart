using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetomvc.Models;
using projetomvc.Models.Enum;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    
    [Authorize(Policy = "Admin")]
    public class AdminScrumController : Controller
    {
        private readonly ApplicationDbContext _database;

        public AdminScrumController(ApplicationDbContext database){
            _database = database;
        }

        public IActionResult Consultar()
        {
            var lista = _database.Grupos.Include(x => x.Tecnologia).Include(x => x.ProgramaStart).Include(x => x.ScrumMaster).ToList();
            return View(lista);
        }
    }
}