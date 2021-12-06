using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using projetomvc.DTO;
using projetomvc.Models;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    [Authorize(Policy = "Admin")]
    public class ProgramaStartController : Controller
    {
        private readonly ApplicationDbContext _database;

        public ProgramaStartController(ApplicationDbContext database){
            _database = database;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult ConsultarModulos(){
            var lista = _database.Modulos.ToList();
            return View(lista);
        }

        public IActionResult ConsultarTecnologias(){
            var lista = _database.Tecnologias.ToList();
            return View(lista);
        }

        public IActionResult ConsultarProjetos(){
            var lista = _database.Projetos.ToList();
            return View(lista);
        }

        public IActionResult Consultar(){
            var lista = _database.ProgramasStarter.ToList();
            return View(lista);
        }

        [HttpPost]
        public IActionResult SalvarProgramaStart(ProgramaStart programaStartDto){
            if(ModelState.IsValid){
                ProgramaStart novoPrograma = new ProgramaStart();
                novoPrograma.Nome = programaStartDto.Nome;
                novoPrograma.DataInicio = programaStartDto.DataInicio;
                novoPrograma.DataFim = programaStartDto.DataFim;
                _database.ProgramasStarter.Add(novoPrograma);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "ProgramaStart");
            }
            else{
                return View("../ProgramaStart/Cadastrar");
            }
        }

        [HttpPost]
        public IActionResult AtualizarProgramaStart(ProgramaStart programaStartDto){
            if(ModelState.IsValid){
                ProgramaStart novoPrograma = new ProgramaStart();
                novoPrograma.Id = programaStartDto.Id;
                novoPrograma.Nome = programaStartDto.Nome;
                novoPrograma.DataInicio = programaStartDto.DataInicio;
                novoPrograma.DataFim = programaStartDto.DataFim;
                _database.ProgramasStarter.Update(novoPrograma);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "ProgramaStart");
            }
            else{
                return View("../ProgramaStart/Cadastrar");
            }
        }

        [HttpPost]
        public IActionResult SalvarTecnologia(Tecnologia tecnologiaDto){
            if(ModelState.IsValid){
                Tecnologia novaTecnologia = new Tecnologia();
                novaTecnologia.Nome = tecnologiaDto.Nome;
                novaTecnologia.Descricao = tecnologiaDto.Descricao;

                _database.Tecnologias.Add(novaTecnologia);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "ProgramaStart");
            }
            else{
                return View("../ProgramaStart/Cadastrar");
            }
        }

        public IActionResult Editar(int id){
            ProgramaStartDTO dto = new ProgramaStartDTO();
            var p = _database.ProgramasStarter.First(x => x.Id == id);
            dto.Id = p.Id;
            dto.Nome = p.Nome;
            dto.DataInicio = p.DataInicio;
            dto.DataFim = p.DataFim;
            return View(dto);
            
        }

        public IActionResult Excluir(int id){
            var programa = _database.ProgramasStarter.First(x => x.Id == id);
            _database.Remove(programa);
            _database.SaveChanges();
            return RedirectToAction("Consultar", "ProgramaStart");
        }
    }
}