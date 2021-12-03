using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class Daily
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Fazendo { get; set; }
        public string Feito { get; set; }
        public string Impedimentos { get; set; }
        public bool Presenca { get; set; }
        public Modulo Modulo { get; set; }
        public Starter Starter { get; set; }

        public Daily()
        {
            
        }
        public Daily(DateTime data, string fazendo, string feito, string impedimentos, bool presenca, Modulo modulo, Starter starter)
        {
            Data = data;
            Fazendo = fazendo;
            Feito = feito;
            Impedimentos = impedimentos;
            Presenca = presenca;
            Modulo = modulo;
            Starter = starter;
        }
    }
}