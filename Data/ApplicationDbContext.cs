using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projetomvc.Models;

namespace ProjetoProgramaStart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Starter> Starters { get; set; }
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<ProjetoStarter> ProjetosStarters{get; set;}
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Daily> Dailys { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<ProgramaStart> ProgramasStarter { get; set; }
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        internal void ProjetoStarter()
        {
            throw new NotImplementedException();
        }
    }
}
