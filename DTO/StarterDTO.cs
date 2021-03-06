using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.DTO
{
    public class StarterDTO
    {   
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100, MinimumLength =3, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "O campo deve ser composto por {1} caracteres")]
        public string Letras { get; set; }
        public string Cargo { get; set; }      

    }
}