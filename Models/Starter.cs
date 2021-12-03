using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetomvc.Models.Enum;

namespace projetomvc.Models
{
    public class Starter
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Letras { get; set; }
        public Cargo Cargo {get; set;} = Cargo.Starter;
        public Grupo Grupo { get; set; }
        public ICollection<Daily> Dailys { get; set; } = new List<Daily>();
        public ICollection<ProjetoStarter> ProjetoStarter { get; set; } = new List<ProjetoStarter>();

        public Starter()
        {
            
        }
        public Starter(string nome, string letras, Grupo grupo)
        {
            Nome = nome;
            Letras = letras;
            Grupo = grupo;    
        }
    }
}