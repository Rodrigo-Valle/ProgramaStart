using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.DTO
{
    public class ProjetoDTO
    {
        public int Id { get; set; }
        public double Avaliacao { get; set; }
        public string Etapa { get; set; }
        public int Modulo { get; set; }
    }
}