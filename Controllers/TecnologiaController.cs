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
    public class TecnologiaController : Controller
    {
        
        private readonly ApplicationDbContext _database;

        public TecnologiaController(ApplicationDbContext database){
            _database = database;
        }


        public IActionResult NovaTecnologia(){
            return View();
        }

        [HttpPost]
        public IActionResult SalvarTecnologia(Tecnologia dto){
            if(ModelState.IsValid){
                Tecnologia novaTecnologia = new Tecnologia();
                novaTecnologia.Nome = dto.Nome;
                novaTecnologia.Descricao = dto.Descricao;

                _database.Tecnologias.Add(novaTecnologia);
                _database.SaveChanges();
                return RedirectToAction("ConsultarTecnologias", "ProgramaStart");
            }
            else{
                return View("../ProgramaStart/ConsultarTecnologias");
            }
        }     

        public IActionResult Editar(int id){
            var tecnologia = _database.Tecnologias.First(x => x.Id == id);
            TecnologiaDTO dto = new TecnologiaDTO();
            dto.Id = tecnologia.Id;
            dto.Nome = tecnologia.Nome;
            dto.Descricao = tecnologia.Descricao;

            return View(dto);
        }

        public IActionResult Atualizar(Tecnologia dto){
            if(ModelState.IsValid){
                var tecnologia = _database.Tecnologias.First(x => x.Id == dto.Id);
                tecnologia.Nome = dto.Nome;
                tecnologia.Descricao = dto.Descricao;
                _database.Tecnologias.Update(tecnologia);
                _database.SaveChanges();
                return RedirectToAction("ConsultarTecnologias", "ProgramaStart");
            }
            else{
                return View("../ProgramaStart/ConsultarTecnologias");
            }
        }

        public IActionResult Excluir(int id){
            var tecnologia = _database.Tecnologias.First(x => x.Id == id);
            _database.Tecnologias.Remove(tecnologia);
            _database.SaveChanges();
            return RedirectToAction("ConsultarTecnologias", "ProgramaStart");
        }
    }
}