using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetomvc.Models;

namespace projetomvc.DTO
{
    public class GrupoDTO
    {
        public int Id { get; set; }
        public int Tecnologia { get; set; }
        public string ScrumMaster { get; set; }
        public int ProgramaStart { get; set; }
        public int? Starter { get; set; }
    }
}