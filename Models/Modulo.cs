using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class Modulo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();

        public Modulo()
        {
            
        }
        public Modulo(string nome){
            Nome = nome;
        }
    }
}