using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using projetomvc.Models.Enum;

namespace projetomvc.Models
{
    public class Empregado : IdentityUser
    {
        public string Nome { get; set; }
        public string Letras { get; set; }
        public Cargo Cargo {get; set;}


    }
}