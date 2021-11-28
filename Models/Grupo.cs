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

        [InverseProperty("ScrumMaster")]
        public Empregado ScrumMaster { get; set; }
        [InverseProperty("Starter")]
        public ICollection<Empregado> Starter { get; set; } = new List<Empregado>();



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