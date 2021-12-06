using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.DTO
{
    public class ProjetoStarterDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int StarterId {get; set;}
        [Required]
        public int ProjetoId { get; set; }
        [Required]
        [Range(0, 10, ErrorMessage = "Nota de 0 a 10")]
        public double Avaliacao { get; set; }
    }
}