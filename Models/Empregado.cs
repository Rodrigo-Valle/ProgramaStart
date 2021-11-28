using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using projetomvc.Models.Enum;

namespace projetomvc.Models
{
    public class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Letras { get; set; }
        public Cargo Cargo {get; set;}

        public int? ScrumMasterId {get; set;}
        public int? StarterId { get; set; }

        public virtual Grupo ScrumMaster {get; set;}
        public virtual Grupo Starter {get; set;}


    }
}