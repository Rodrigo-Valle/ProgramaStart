using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using projetomvc.Models.Enum;

namespace projetomvc.DTO
{
    public class EmpregadoDTO
    {
        [Required]
        public string Id { get; set; }

        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Endereço invalido")]
        [EmailAddress(ErrorMessage = "Entre com um endereço valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8}$", 
         ErrorMessage = "A senha deve possuir 8 caracteres, sendo pelo menos uma letra maiuscula, uma minuscula, um caractere especial e um numero")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [StringLength(100, MinimumLength =3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [StringLength(4, MinimumLength =4, ErrorMessage = "O campo deve ter {2} caracteres")]
        public string Letras { get; set; }
        [Required(ErrorMessage = "Selecione um {0}")]
        public string Cargo { get; set; }    
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]  
        [Url(ErrorMessage = "Entre com uma url valida")]
        public string urlImagem {get; set;}

    }
}