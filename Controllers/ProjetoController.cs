using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return RedirectToAction("ConsultarProjeto","Projeto");
            }
            else{
                return RedirectToAction("ConsultarProjeto","Projeto");
            }
        }

        public IActionResult ConsultarProjeto(){
            var lista = _database.Projetos.Include(x => x.Modulo).ToList();
            return View(lista);
        }

        public IActionResult Editar(int id){
            var projeto = _database.Projetos.Include(x => x.Modulo).First(x => x.Id == id);
            ProjetoDTO dto = new ProjetoDTO();
            dto.Id = projeto.Id;
            dto.Etapa = projeto.Etapa;
            dto.Modulo = projeto.Modulo.Id;
            ViewBag.Modulo = _database.Modulos.ToList();
            return View(dto);
        }

        public IActionResult Atualizar(ProjetoDTO dto){
            if (ModelState.IsValid)
            {
                var projeto = _database.Projetos.Include(x => x.Modulo).First(x => x.Id == dto.Id);
                projeto.Id = dto.Id;
                projeto.Etapa = dto.Etapa;
                projeto.Modulo = _database.Modulos.First(x => x.Id == dto.Modulo);
                _database.Projetos.Update(projeto);
                _database.SaveChanges();
                return RedirectToAction("ConsultarProjeto", "Projeto");
            }
            else{
                return RedirectToAction("ConsultarProjeto", "Projeto");
            }
        }

        public IActionResult Excluir(int id){
            var projeto = _database.Projetos.First(x => x.Id == id);
            _database.Remove(projeto);
            _database.SaveChanges();
            return RedirectToAction("ConsultarProjeto", "Projeto");
        }
    }
}