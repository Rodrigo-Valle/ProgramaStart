using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using projetomvc.Models;

namespace projetomvc.DTO
{
    public class GrupoDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Tecnologia { get; set; }
        [Required]
        public string ScrumMaster { get; set; }
        [Required]
        public int ProgramaStart { get; set; }
        
        public int? Starter { get; set; }
    }
}