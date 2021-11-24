using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class Daily
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Fazendo { get; set; }
        public string Feito { get; set; }
        public string Impedimentos { get; set; }
        public bool Presenca { get; set; }
        public Modulo Modulo { get; set; }
        public Empregado Empregado { get; set; }
    }
}