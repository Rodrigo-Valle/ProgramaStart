using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projetomvc.DTO;
using projetomvc.Models;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    public class ProjetoController : Controller
    {   
        private readonly ApplicationDbContext _database;
        public ProjetoController(ApplicationDbContext database)
        {
            _database = database;
        }
        public IActionResult NovoProjeto(){
            ViewBag.Modulo = _database.Modulos.ToList();
            return View();
        }

        public IActionResult Salvar(ProjetoDTO dto){
            if (ModelState.IsValid)
            {
                Projeto p = new Projeto();
                p.Etapa = dto.Etapa;
                var modulo = _database.Modulos.First(x => x.Id == dto.Modulo);
                modulo.Projetos.Add(p);
                _database.Projetos.Add(p);
                _database.Modulos.Update(modulo);
                _database.SaveChanges();
                return RedirectToAction("Consultar","ProgramaStart");
            }
            else{
                return RedirectToAction("Consultar","ProgramaStart");
            }

        }
    }
}