using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.DTO
{
    public class ProgramaStartDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim {get; set;}
    }
}