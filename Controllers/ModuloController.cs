using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projetomvc.DTO;
using projetomvc.Models;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    [Authorize(Policy = "Admin")]
    public class ModuloController : Controller
    {
        private readonly ApplicationDbContext _database;

        public ModuloController(ApplicationDbContext database){
            _database = database;
        }

        public IActionResult NovoModulo(){
            return View();
        }

        [HttpPost]
        public IActionResult SalvarModulo(Modulo moduloDto){
            if(ModelState.IsValid){
                Modulo novoModulo = new Modulo();
                novoModulo.Nome = moduloDto.Nome;

                _database.Modulos.Add(novoModulo);
                _database.SaveChanges();
                return RedirectToAction("ConsultarModulos", "ProgramaStart");
            }
            else{
                return View("../ProgramaStart/ConsultarModulos");
            }
        }     

        public IActionResult Editar(int id){
            var modulo = _database.Modulos.First(x => x.Id == id);
            ModuloDTO dto = new ModuloDTO();
            dto.Id = modulo.Id;
            dto.Nome = modulo.Nome;

            return View(dto);
        }

        public IActionResult Atualizar(Modulo dto){
            if(ModelState.IsValid){
                var modulo = _database.Modulos.First(x => x.Id == dto.Id);
                modulo.Nome = dto.Nome;
                _database.Modulos.Update(modulo);
                _database.SaveChanges();
                return RedirectToAction("ConsultarModulos", "ProgramaStart");
            }
            else{
                return View("../ProgramaStart/ConsultarModulos");
            }
        }

        public IActionResult Excluir(int id){
            var modulo = _database.Modulos.First(x => x.Id == id);
            _database.Modulos.Remove(modulo);
            _database.SaveChanges();
            return RedirectToAction("ConsultarModulos", "ProgramaStart");
        }
    }
}