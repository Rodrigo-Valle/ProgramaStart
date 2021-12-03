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
        [DisplayFormat(DataFormatString = "{0:F1}")]
        [RegularExpression(@"^\d+(\.\d{1,1})?$", ErrorMessage = "Nota de 0 a 10, com no maximo uma casa decimal")]
        [Range(0.0, 10.0, ErrorMessage = "Nota de 0 a 10, com no maximo uma casa decimal")]
        public double Avaliacao { get; set; }
    }
}