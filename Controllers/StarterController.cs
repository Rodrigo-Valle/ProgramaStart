using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projetomvc.DTO;
using projetomvc.Models;
using projetomvc.Models.Enum;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    [Authorize(Policy = "Admin")]
    public class StarterController : Controller
    {   
        private readonly ApplicationDbContext _database;

        public StarterController(ApplicationDbContext database)
        {
            _database = database;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }


        public IActionResult Consultar()
        {
            var lista = _database.Starters.ToList();
            return View(lista);
        }

        [HttpPost]
        public IActionResult Salvar(StarterDTO dto)
        {
            if (ModelState.IsValid)
            {
                Starter starter = new Starter();
                starter.Id = dto.Id;
                starter.Nome = dto.Nome;
                starter.Letras = dto.Letras;
                                
                _database.Starters.Add(starter);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Starter");
            }
            else
            {
                return RedirectToAction("Consultar", "Starter");
            }
        }

        public IActionResult Editar(int id)
        {
            var starter = _database.Starters.First(x => x.Id == id);
            StarterDTO dto = new StarterDTO();
            dto.Id = starter.Id;
            dto.Letras = starter.Letras;
            dto.Nome = starter.Nome;
            dto.Cargo = starter.Cargo.ToString();
            return View(dto);
        }

        public IActionResult Atualizar(StarterDTO dto)
        {
            if (ModelState.IsValid)
            {
                Starter starter = new Starter();
                starter.Id = dto.Id;
                starter.Nome = dto.Nome;
                starter.Letras = dto.Letras;
                starter.Cargo = Enum.Parse<Cargo>(dto.Cargo);
                _database.Starters.Update(starter);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Starter");
            }
            else
            {
                return RedirectToAction("Consultar", "Starter");
            }
        }

        public IActionResult Excluir(int id)
        {
            var starter = _database.Starters.First(x => x.Id == id);
            _database.Starters.Remove(starter);
            _database.SaveChanges();
            return RedirectToAction("Consultar", "Starter");
        }


        

    }
}