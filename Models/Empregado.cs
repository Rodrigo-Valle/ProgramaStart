using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetomvc.Models.Enum;

namespace projetomvc.Models
{
    public class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cargo Cargo { get; set; }

    }
}