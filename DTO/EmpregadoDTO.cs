using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetomvc.Models.Enum;

namespace projetomvc.DTO
{
    public class EmpregadoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Letras { get; set; }
        public string Cargo { get; set; }      
        public int EmpregadoId {get; set;}
        public int StarterId { get; set; }
    }
}