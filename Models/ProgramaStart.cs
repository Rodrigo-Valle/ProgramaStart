using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class ProgramaStart
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

        public ProgramaStart()
        {
            
        }

        public ProgramaStart(string nome, DateTime dataInicio, DateTime dataFim)
        {
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}