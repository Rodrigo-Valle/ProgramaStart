using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetomvc.DTO;
using projetomvc.Models;
using projetomvc.Models.Enum;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    [Authorize(Policy = "Admin")]
    public class GrupoController : Controller
    {
        private readonly ApplicationDbContext _database;
        public GrupoController(ApplicationDbContext database)
        {
            _database = database;
        }
        public IActionResult Consultar()
        {
            var lista = _database.Grupos.Include(x => x.Tecnologia).Include(x => x.ProgramaStart).Include(x => x.ScrumMaster).ToList();
            return View(lista);
        }
        public IActionResult Criar()
        {
            ViewBag.Tec = _database.Tecnologias.ToList();
            ViewBag.Empregado = _database.Empregados.Where(x => x.Cargo == Cargo.ScrumMaster).ToList();
            ViewBag.ProgramaStart = _database.ProgramasStarter.ToList();
            return View();
        }

        public IActionResult Salvar(GrupoDTO dto)
        {
            if (ModelState.IsValid)
            {
                Grupo grupo = new Grupo();
                grupo.Tecnologia = _database.Tecnologias.First(x => x.Id == dto.Tecnologia);
                grupo.ProgramaStart = _database.ProgramasStarter.First(x => x.Id == dto.ProgramaStart);
                grupo.ScrumMaster = _database.Empregados.First(x => x.Id == dto.ScrumMaster);
                _database.Grupos.Add(grupo);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Grupo");
            }
            else
            {
                return RedirectToAction("Consultar", "Grupo");
            }



        }
        public IActionResult Editar(int id)
        {
            var grupo = _database.Grupos.Include(x => x.Tecnologia).Include(x => x.ProgramaStart).Include(x => x.ScrumMaster).First(x => x.Id == id);
            GrupoDTO dto = new GrupoDTO();
            dto.Id = grupo.Id;
            dto.ProgramaStart = grupo.ProgramaStart.Id;
            dto.ScrumMaster = grupo.ScrumMaster.Id;
            dto.Tecnologia = grupo.Tecnologia.Id;
            ViewBag.Tec = _database.Tecnologias.ToList();
            ViewBag.Empregado = _database.Empregados.Where(x => x.Cargo == Cargo.ScrumMaster).ToList();
            ViewBag.ProgramaStart = _database.ProgramasStarter.ToList();
            return View(dto);
        }

        [HttpPost]
        public IActionResult Atualizar(GrupoDTO dto)
        {
            if (ModelState.IsValid)
            {
                Grupo grupo = new Grupo();
                grupo.Id = dto.Id;
                grupo.Tecnologia = _database.Tecnologias.First(x => x.Id == dto.Tecnologia);
                grupo.ProgramaStart = _database.ProgramasStarter.First(x => x.Id == dto.ProgramaStart);
                grupo.ScrumMaster = _database.Empregados.First(x => x.Id == dto.ScrumMaster);
                _database.Grupos.Update(grupo);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Grupo");
            }
            else
            {
                return RedirectToAction("Consultar", "Grupo");
            }
        }

        public IActionResult Excluir(int id)
        {
            var grupo = _database.Grupos.First(x => x.Id == id);
            _database.Grupos.Remove(grupo);
            _database.SaveChanges();
            return RedirectToAction("Consultar", "Grupo");
        }

        public IActionResult Gerenciar()
        {
            var grupos = _database.Grupos.Include(x => x.Tecnologia).Include(x => x.ProgramaStart).Include(x => x.ScrumMaster).ToList();
            return View(grupos);
        }

        public IActionResult ConsultarStarters(int id)
        {
            var starters = _database.Starters.Include(x => x.Grupo).Where(x => x.Grupo.Id == id).ToList();
            return View(starters);
        }

        public IActionResult AdicionarStarters(int id)
        {
            ViewBag.Starters = _database.Starters.Include(x => x.Grupo).Where(x => x.Grupo == null).ToList();
            var grupo = _database.Grupos.Include(x => x.Tecnologia).Include(x => x.ProgramaStart).Include(x => x.ScrumMaster).First(x => x.Id == id);
            GrupoDTO dto = new GrupoDTO();
            dto.Id = grupo.Id;
            dto.ProgramaStart = grupo.ProgramaStart.Id;
            dto.ScrumMaster = grupo.ScrumMaster.Id;
            dto.Tecnologia = grupo.Tecnologia.Id;
            ViewBag.Tec = _database.Tecnologias.ToList();
            ViewBag.Empregado = _database.Empregados.Where(x => x.Cargo == Cargo.ScrumMaster).ToList();
            ViewBag.ProgramaStart = _database.ProgramasStarter.ToList();
            return View(dto);
        }

        [HttpPost]
        public IActionResult SalvarStarter(GrupoDTO dto)
        {
            if (ModelState.IsValid)
            {
                Grupo grupo = new Grupo();
                grupo.Id = dto.Id;
                Starter starter = new Starter();
                starter = _database.Starters.First(x => x.Id == dto.Starter);
                grupo.Starter.Add(starter);
                _database.Grupos.Update(grupo);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Grupo");
            }
            else
            {
                return RedirectToAction("Consultar", "Grupo");
            }
        }

        public IActionResult RemoverStarters(int id)
        {
            var starters = _database.Starters.Where(x => x.Grupo.Id == id).ToList();
            return View(starters);
        }
        public IActionResult ExcluirStarter(int id){
            var starter = _database.Starters.Include(x => x.Grupo).First(x => x.Id == id);
            starter.Grupo = null;
            _database.Starters.Update(starter);
            _database.SaveChanges();
            return RedirectToAction("Gerenciar","Grupo");
        }


    }
}