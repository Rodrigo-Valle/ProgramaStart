using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public Tecnologia Tecnologia { get; set; }
        public Empregado ScrumMaster { get; set; }
        public ICollection<Starter> Starter { get; set; } = new List<Starter>();
        public ProgramaStart ProgramaStart { get; set; }


        public Grupo()
        {
            
        }

        public Grupo(Tecnologia tecnologia, Empregado scrumMaster, ProgramaStart programaStar)
        {
            Tecnologia = tecnologia;
            ScrumMaster = scrumMaster;
            ProgramaStart = programaStar;
        }

    }
}