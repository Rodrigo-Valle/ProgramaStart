using System.Collections.Generic;

namespace projetomvc.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Etapa { get; set; }
        public Modulo Modulo{get; set;}
        public ICollection<ProjetoStarter> ProjetoStarter { get; set; } = new List<ProjetoStarter>();


        public Projeto()
        {
            
        }
        public Projeto(string etapa, Modulo modulo)
        {
            Etapa = etapa;  
            Modulo = modulo;
        }
    }
}