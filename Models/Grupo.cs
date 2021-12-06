using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public Tecnologia Tecnologia { get; set; }
        public ProgramaStart ProgramaStart { get; set; }
        public Empregado ScrumMaster { get; set; }
        public ICollection<Starter> Starter { get; set; } = new List<Starter>();

        public Grupo()
        {

        }

        public Grupo(Tecnologia tecnologia, Empregado scrumMaster, ProgramaStart programaStart)
        {
            Tecnologia = tecnologia;
            ScrumMaster = scrumMaster;
            ProgramaStart = programaStart;
        }

    }
}