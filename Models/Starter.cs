using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class Starter : Empregado
    {
        public Grupo Grupo { get; set; }
        public ICollection<Daily> Dailys { get; set; } = new List<Daily>();
        public ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();    
        
        public Starter()
        {
            
        }

        public Starter(Grupo grupo, string nome) {
            Nome = nome;
            Cargo = Enum.Cargo.Starter;
            Grupo = grupo;
        }  
    }
}