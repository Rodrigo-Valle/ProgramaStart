using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projetomvc.DTO;
using projetomvc.Models;
using projetomvc.Models.Enum;
using ProjetoProgramaStart.Data;

namespace projetomvc.Controllers
{
    public class ColaboradoresController : Controller
    {

        private readonly ApplicationDbContext _database;

        public ColaboradoresController(ApplicationDbContext database)
        {
            _database = database;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }


        public IActionResult Consultar()
        {
            var lista = _database.Empregados.ToList();
            return View(lista);
        }

        [HttpPost]
        public IActionResult Salvar(EmpregadoDTO dto)
        {
            if (ModelState.IsValid)
            {
                Empregado empregado = new Empregado();
                empregado.Id = dto.Id;
                empregado.Nome = dto.Nome;
                empregado.Letras = dto.Letras;
                empregado.Cargo = Enum.Parse<Cargo>(dto.Cargo);
                
                _database.Empregados.Update(empregado);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Colaboradores");
            }
            else
            {
                return RedirectToAction("Colaboradores", "Consultar");
            }
        }

        public IActionResult Editar(int id)
        {
            var empregado = _database.Empregados.First(x => x.Id == id);
            EmpregadoDTO dto = new EmpregadoDTO();
            dto.Id = empregado.Id;
            dto.Letras = empregado.Letras;
            dto.Nome = empregado.Nome;
            dto.Cargo = empregado.Cargo.ToString();
            return View(dto);
        }

        public IActionResult Atualizar(EmpregadoDTO dto)
        {
            if (ModelState.IsValid)
            {
                Empregado empregado = new Empregado();
                empregado.Id = dto.Id;
                empregado.Nome = dto.Nome;
                empregado.Letras = dto.Letras;
                empregado.Cargo = Enum.Parse<Cargo>(dto.Cargo);
                _database.Empregados.Update(empregado);
                _database.SaveChanges();
                return RedirectToAction("Consultar", "Colaboradores");
            }
            else
            {
                return RedirectToAction("Colaboradores", "Consultar");
            }
        }

        public IActionResult Excluir(int id)
        {
            var empregado = _database.Empregados.First(x => x.Id == id);
            _database.Empregados.Remove(empregado);
            _database.SaveChanges();
            return RedirectToAction("Consultar", "Colaboradores");
        }
    }
}