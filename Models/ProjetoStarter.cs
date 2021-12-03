using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class ProjetoStarter
    {
        public int Id { get; set; }
        public int StarterId {get; set;}
        public virtual Starter Starter { get; set; }
        public int ProjetoId { get; set; }
        public virtual Projeto Projeto { get; set; }
        public double Avaliacao { get; set; }

        public ProjetoStarter()
        {
            
        }
        public ProjetoStarter(Starter starter, Projeto projeto, double avaliacao)
        {
            Starter = starter;
            Projeto = projeto;
            Avaliacao = avaliacao;

        }
    }
}