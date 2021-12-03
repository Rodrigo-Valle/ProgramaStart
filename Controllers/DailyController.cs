using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetomvc.DTO;
using projetomvc.Models;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    [Authorize(Policy = "Scrum")]
    public class DailyController : Controller
    {
        private readonly ApplicationDbContext _database;

        public DailyController(ApplicationDbContext database){
            _database = database;
        }


        public IActionResult Registrar(int id){
            
            ViewBag.Modulo = _database.Modulos.ToList();

            var starterId = _database.Starters.First(x => x.Id == id);
            DailyDTO dto = new DailyDTO();
            dto.Starter = starterId.Id;

            return View(dto);
        }

        [HttpPost]
        public IActionResult Salvar(DailyDTO dto){
            if (ModelState.IsValid)
            {
            Daily daily = new Daily();
            daily.Data = dto.Data;
            daily.Impedimentos = dto.Impedimentos;
            daily.Feito = dto.Feito;    
            daily.Fazendo = dto.Fazendo;
            daily.Presenca = dto.Presenca;
            daily.Starter = _database.Starters.First(x => x.Id == dto.Starter);
            daily.Modulo = _database.Modulos.First(x => x.Id == dto.Modulo);
            _database.Dailys.Add(daily);
            _database.SaveChanges();
            return RedirectToAction("Consultar","Daily");
            }
            else{
                return RedirectToAction("Registrar","Scrum", dto);
            }
        }
        public IActionResult Consultar(int id){
            var daily = _database.Dailys.Include(x => x.Modulo).Where(x => x.Starter.Id == id).ToList();
            return View(daily);
        }

        public IActionResult Editar(int id){
            ViewBag.Modulo = _database.Modulos.ToList();
            var daily = _database.Dailys.Include(x => x.Modulo).Include(x => x.Starter).First(x => x.Id == id);
            DailyDTO dto = new DailyDTO();
            dto.Id = daily.Id;
            dto.Data = daily.Data;
            dto.Starter = daily.Starter.Id;
            dto.Feito = daily.Feito;
            dto.Fazendo = daily.Fazendo;
            dto.Impedimentos = daily.Impedimentos;
            return View(dto);
        }

        [HttpPost]
        public IActionResult Atualizar(DailyDTO dto){
            if (ModelState.IsValid)
            {
            Daily daily = new Daily();
            daily.Id = dto.Id;
            daily.Data = dto.Data;
            daily.Impedimentos = dto.Impedimentos;
            daily.Feito = dto.Feito;    
            daily.Fazendo = dto.Fazendo;
            daily.Presenca = dto.Presenca;
            daily.Starter = _database.Starters.First(x => x.Id == dto.Starter);
            daily.Modulo = _database.Modulos.First(x => x.Id == dto.Modulo);
            _database.Dailys.Update(daily);
            _database.SaveChanges();
            return RedirectToAction("Consultar", "Daily");
            }
            else{
                return RedirectToAction("Consultar", "Daily");
            }
        }

        public IActionResult Excluir(int id){
            var daily = _database.Dailys.First(x => x.Id == id);
            _database.Dailys.Remove(daily);
            _database.SaveChanges();
            return RedirectToAction("Consultar", "Daily");
        }



    }
}