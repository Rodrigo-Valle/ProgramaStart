using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.DTO
{
    public class ProjetoDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:F1}")]
       
        public double Avaliacao { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [StringLength(100, MinimumLength =3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Etapa { get; set; }
        [Required]
        public int Modulo { get; set; }
    }
}