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

        public IActionResult Avaliacao(int id)
        {
            var starter = _database.Starters.First(x => x.Id == id);
            ViewBag.Starter = starter;
            var lista = _database.ProjetosStarters.Include(x => x.Starter).Where(x => x.Starter.Id == id).Include(x => x.Projeto).ToList();
            return View(lista);
        }

        public IActionResult Avaliar(int id){
            ViewBag.Starter = _database.Starters.First(x => x.Id == id);
            ViewBag.Projeto = _database.Projetos.ToList();
            return View();

        }

        public IActionResult SalvarNota(ProjetoStarterDTO dto){
            if (ModelState.IsValid)
            {
                ProjetoStarter ps = new ProjetoStarter();
                ps.Avaliacao = dto.Avaliacao;
                ps.Projeto = _database.Projetos.First(x => x.Id == dto.ProjetoId);
                ps.Starter = _database.Starters.First(x => x.Id == dto.StarterId);
                _database.ProjetosStarters.Add(ps);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Starter");
            }
            else{
                return RedirectToAction("Avaliar", "Starter", dto);
            }
        }

        public IActionResult EditarAvaliacao(int id){
            var ps = _database.ProjetosStarters.Include(x => x.Projeto).Include(x => x.Starter).First(x => x.Id == id);
            ProjetoStarterDTO dto = new ProjetoStarterDTO();
            dto.Id = ps.Id;
            dto.ProjetoId = ps.Projeto.Id;
            dto.StarterId = ps.Starter.Id;
            dto.Avaliacao = ps.Avaliacao;
            ViewBag.Starter = _database.Starters.First(x => x.Id == ps.Starter.Id);
            ViewBag.Projeto = _database.Projetos.ToList();
            return View(dto);
        }

        public IActionResult AtualizarAvaliacao(ProjetoStarterDTO dto){
            if (ModelState.IsValid)
            {
                var ps = _database.ProjetosStarters.First(x => x.Id == dto.Id );
                ps.Id = dto.Id;
                ps.Avaliacao = dto.Avaliacao;
                ps.Projeto = _database.Projetos.First(x => x.Id == dto.ProjetoId);
                ps.Starter = _database.Starters.First(x => x.Id == dto.StarterId);
                _database.ProjetosStarters.Update(ps);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Starter");
            }
            else{
                return RedirectToAction("Avaliar", "Starter", dto);
            }
        }

        public IActionResult ExcluirAvaliacao(int id){
            var ps = _database.ProjetosStarters.First(x => x.Id == id);
            _database.ProjetosStarters.Remove(ps);
            _database.SaveChanges();
            return RedirectToAction("Consultar", "Starter");
        }


        

    }
}