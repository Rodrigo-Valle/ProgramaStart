using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.DTO
{
    public class DailyDTO
    {
        [Required]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [StringLength(450, MinimumLength =3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Fazendo { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [StringLength(450, MinimumLength =3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Feito { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [StringLength(450, MinimumLength =3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Impedimentos { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        public bool Presenca { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Modulo { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        public int Starter { get; set; }
    }
}