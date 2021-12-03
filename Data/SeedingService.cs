using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using projetomvc.Models;
using projetomvc.Models.Enum;
using ProjetoProgramaStart.Data;

namespace projetomvc.Data
{
    public class SeedingService : IdentityDbContext
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _database;

        public SeedingService(ApplicationDbContext database, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _database = database;
        }

        public async Task Seed()
        {
            if (_database.Starters.Any() || _database.Tecnologias.Any() || _database.Dailys.Any() ||
                _database.Empregados.Any() || _database.Grupos.Any() || _database.Modulos.Any() ||
                _database.ProgramasStarter.Any() || _database.Projetos.Any())
            {
                return;
            }

            Tecnologia tec1 = new Tecnologia("DotNet", "Desenvolvimento utilizando a plataforma DotNet");
            Tecnologia tec2 = new Tecnologia("Java", "Desenvolvimento utilizando a plataforma Java");

            Modulo mod1 = new Modulo("MVC");
            Modulo mod2 = new Modulo("API");
            Modulo mod3 = new Modulo("Testes");
            Modulo mod4 = new Modulo("Front");

            ProgramaStart ps1 = new ProgramaStart("Programa Start DotNet Gft", new DateTime(2021, 4, 15), new DateTime(2021, 7, 16));
            ProgramaStart ps2 = new ProgramaStart("Programa Start Java Gft", new DateTime(2021, 11, 3), new DateTime(2022, 2, 1));

            SeedAdmin().Wait();
            ScrumMasterUm().Wait();
            ScrumMasterDois().Wait();
            AddClaim().Wait();

            var scrum1 = _database.Empregados.First(x => x.Email == "yoda@gft.com");
            var scrum2 = _database.Empregados.First(x => x.Email == "jukes@gft.com");

            Grupo gr1 = new Grupo(tec1, scrum1, ps1);
            Grupo gr2 = new Grupo(tec2, scrum2, ps2);

            Starter st1 = new Starter("Takeshi", "tksh", gr1);
            Starter st2 = new Starter("Mylon", "myon", gr1);
            Starter st3 = new Starter("Kami", "mika", gr1);
            Starter st4 = new Starter("Faye", "ayef", gr1);
            Starter st5 = new Starter("Soneca", "sonc", gr2);
            Starter st6 = new Starter("Calango", "calg", gr2);
            Starter st7 = new Starter("Rakin", "kina", gr2);
            Starter st8 = new Starter("Alanzoka", "alzk", gr2);

            Projeto pj1 = new Projeto("Estudo MVC", mod1);
            Projeto pj2 = new Projeto("Projeto MVC", mod1);
            Projeto pj3 = new Projeto("Estudo API", mod2);
            Projeto pj4 = new Projeto("Projeto API", mod2);
            Projeto pj5 = new Projeto("Estudo Testes", mod3);
            Projeto pj6 = new Projeto("Estudo Front", mod4);

            ProjetoStarter p1 = new ProjetoStarter(st1, pj1, 7.9);
            ProjetoStarter p2 = new ProjetoStarter(st1, pj2, 8.4);
            ProjetoStarter p3 = new ProjetoStarter(st1, pj3, 3.9);
            ProjetoStarter p4 = new ProjetoStarter(st1, pj4, 9.2);
            ProjetoStarter p5 = new ProjetoStarter(st1, pj5, 6.9);
            ProjetoStarter p6 = new ProjetoStarter(st1, pj6, 7.5);
            ProjetoStarter p7 = new ProjetoStarter(st2, pj1, 8.9);
            ProjetoStarter p8 = new ProjetoStarter(st2, pj2, 6.9);
            ProjetoStarter p9 = new ProjetoStarter(st2, pj1, 7.9);
            ProjetoStarter p10 = new ProjetoStarter(st2, pj2, 8.4);
            ProjetoStarter p11 = new ProjetoStarter(st2, pj3, 3.9);
            ProjetoStarter p12 = new ProjetoStarter(st2, pj4, 9.2);
            ProjetoStarter p13 = new ProjetoStarter(st2, pj5, 6.9);
            ProjetoStarter p14 = new ProjetoStarter(st2, pj6, 7.5);
            ProjetoStarter p15 = new ProjetoStarter(st3, pj1, 8.9);
            ProjetoStarter p16 = new ProjetoStarter(st3, pj2, 6.9);
            ProjetoStarter p17 = new ProjetoStarter(st3, pj3, 7.9);
            ProjetoStarter p18 = new ProjetoStarter(st3, pj4, 8.4);
            ProjetoStarter p19 = new ProjetoStarter(st3, pj5, 3.9);
            ProjetoStarter p20 = new ProjetoStarter(st3, pj6, 9.2);
            ProjetoStarter p21 = new ProjetoStarter(st3, pj1, 6.9);
            ProjetoStarter p22 = new ProjetoStarter(st3, pj2, 7.5);
            ProjetoStarter p23 = new ProjetoStarter(st4, pj3, 8.9);
            ProjetoStarter p24 = new ProjetoStarter(st4, pj4, 6.9);
            ProjetoStarter p25 = new ProjetoStarter(st4, pj5, 7.9);
            ProjetoStarter p26 = new ProjetoStarter(st4, pj6, 8.4);
            ProjetoStarter p27 = new ProjetoStarter(st4, pj1, 3.9);
            ProjetoStarter p28 = new ProjetoStarter(st4, pj2, 9.2);
            ProjetoStarter p29 = new ProjetoStarter(st4, pj3, 6.9);
            ProjetoStarter p30 = new ProjetoStarter(st4, pj4, 7.5);
            ProjetoStarter p31 = new ProjetoStarter(st4, pj5, 8.9);
            ProjetoStarter p32 = new ProjetoStarter(st4, pj6, 6.9);

            Daily d1 = new Daily(new DateTime(2021, 4, 15), "Estudando CRUD", "Terminou video 1", "Nenhum", true, mod1, st1);
            Daily d2 = new Daily(new DateTime(2021, 4, 26), "Criando Autorização", "Fez o front end", "Dificuldade com Bootstrap", true, mod1, st1);
            Daily d3 = new Daily(new DateTime(2021, 4, 29), "Faltou", "Faltou", "Faltou", false, mod2, st1);
            Daily d4 = new Daily(new DateTime(2021, 5, 7), "Estudando API", "Terminou pasta 4", "Nenhum", true, mod2, st1);
            Daily d5 = new Daily(new DateTime(2021, 5, 23), "Estudando Swagger", "Criando Post", "Nenhum", true, mod2, st1);
            Daily d6 = new Daily(new DateTime(2021, 6, 12), "Estudando Teste unitario", "Terminou aula 3", "Dificuldades de acesso na maquina", true, mod3, st1);
            Daily d7 = new Daily(new DateTime(2021, 6, 22), "Testando projeto", "Estudar automação de teste", "Nenhum", true, mod3, st1);
            Daily d8 = new Daily(new DateTime(2021, 7, 4), "Estudando Animações com CSS", "utilizar flex e grid", "Nenhum", true, mod4, st1);

            Daily d9 = new Daily(new DateTime(2021, 4, 15), "Estudando CRUD", "Terminou video 1", "Nenhum", true, mod1, st2);
            Daily d10 = new Daily(new DateTime(2021, 4, 26), "Criando Autorização", "Fez o front end", "Dificuldade com Bootstrap", true, mod1, st2);
            Daily d11 = new Daily(new DateTime(2021, 4, 29), "Faltou", "Faltou", "Faltou", false, mod2, st2);
            Daily d12 = new Daily(new DateTime(2021, 5, 7), "Estudando API", "Terminou pasta 4", "Nenhum", true, mod2, st2);
            Daily d13 = new Daily(new DateTime(2021, 5, 15), "Estudando Swagger", "Criando Post", "Nenhum", true, mod2, st2);
            Daily d14 = new Daily(new DateTime(2021, 5, 22), "Estudando Teste unitario", "Terminou aula 3", "Dificuldades de acesso na maquina", true, mod3, st2);
            Daily d15 = new Daily(new DateTime(2021, 6, 16), "Testando projeto", "Estudar automação de teste", "Nenhum", true, mod3, st2);
            Daily d16 = new Daily(new DateTime(2021, 7, 3), "Estudando Animações com CSS", "utilizar flex e grid", "Nenhum", true, mod4, st2);

            Daily d17 = new Daily(new DateTime(2021, 4, 15), "Estudando CRUD", "Terminou video 1", "Nenhum", true, mod1, st3);
            Daily d18 = new Daily(new DateTime(2021, 4, 26), "Criando Autorização", "Fez o front end", "Dificuldade com Bootstrap", true, mod1, st3);
            Daily d19 = new Daily(new DateTime(2021, 4, 29), "Faltou", "Faltou", "Faltou", false, mod2, st3);
            Daily d20 = new Daily(new DateTime(2021, 5, 7), "Estudando API", "Terminou pasta 4", "Nenhum", true, mod2, st3);
            Daily d21 = new Daily(new DateTime(2021, 5, 15), "Estudando Swagger", "Criando Post", "Nenhum", true, mod2, st3);
            Daily d22 = new Daily(new DateTime(2021, 5, 22), "Estudando Teste unitario", "Terminou aula 3", "Dificuldades de acesso na maquina", true, mod3, st3);
            Daily d23 = new Daily(new DateTime(2021, 6, 16), "Testando projeto", "Estudar automação de teste", "Nenhum", true, mod3, st3);
            Daily d24 = new Daily(new DateTime(2021, 7, 3), "Estudando Animações com CSS", "utilizar flex e grid", "Nenhum", true, mod4, st3);

            Daily d25 = new Daily(new DateTime(2021, 4, 15), "Estudando CRUD", "Terminou video 1", "Nenhum", true, mod1, st4);
            Daily d26 = new Daily(new DateTime(2021, 4, 26), "Criando Autorização", "Fez o front end", "Dificuldade com Bootstrap", true, mod1, st4);
            Daily d27 = new Daily(new DateTime(2021, 4, 29), "Faltou", "Faltou", "Faltou", false, mod2, st4);
            Daily d28 = new Daily(new DateTime(2021, 5, 7), "Estudando API", "Terminou pasta 4", "Nenhum", true, mod2, st4);
            Daily d29 = new Daily(new DateTime(2021, 5, 15), "Estudando Swagger", "Criando Post", "Nenhum", true, mod2, st4);
            Daily d30 = new Daily(new DateTime(2021, 5, 22), "Estudando Teste unitario", "Terminou aula 3", "Dificuldades de acesso na maquina", true, mod3, st4);
            Daily d31 = new Daily(new DateTime(2021, 6, 16), "Testando projeto", "Estudar automação de teste", "Nenhum", true, mod3, st4);
            Daily d32 = new Daily(new DateTime(2021, 7, 3), "Estudando Animações com CSS", "utilizar flex e grid", "Nenhum", true, mod4, st4);



            _database.Tecnologias.AddRange(tec1, tec2);
            _database.Modulos.AddRange(mod1, mod2, mod3, mod4);
            _database.ProgramasStarter.AddRange(ps1, ps2);
            _database.Grupos.AddRange(gr1, gr2);
            _database.Starters.AddRange(st1, st2, st3, st4, st5, st6, st7, st8);
            _database.Projetos.AddRange(pj1, pj2, pj3, pj4, pj5, pj6);
            _database.ProjetosStarters.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26 ,p27 , p28, p29, p30, p32, p31);
            _database.Dailys.AddRange(d1, d2, d3, d4, d5,d6,d7,d8,d9,d10,d11,d12,d13,d14,d15,d16,d17,d18,d19,d20,d21,d22,d23,d24,d25,d26,d27,d28,d29,d30,d31,d32);
            _database.SaveChanges();
        }

        public async Task SeedAdmin()
        {
            var user = new Empregado
            {
                UserName = "clecio.silva@gft.com",
                Email = "clecio.silva@gft.com",
                Nome = "Clecio Silva",
                Letras = "clsi",
                Cargo = Cargo.Administrador
            };
            // Armazena os dados do usuário na tabela AspNetUsers
            var result = await _userManager.CreateAsync(user, "/Gft2021");


        }

        public async Task ScrumMasterUm()
        {
            var user = new Empregado
            {
                UserName = "yoda@gft.com",
                Email = "yoda@gft.com",
                Nome = "yoda",
                Letras = "adoy",
                Cargo = Cargo.ScrumMaster
            };
            // Armazena os dados do usuário na tabela AspNetUsers
            var result = await _userManager.CreateAsync(user, "/Abc123");
        }
        public async Task ScrumMasterDois()
        {
            var user = new Empregado
            {
                UserName = "jukes@gft.com",
                Email = "jukes@gft.com",
                Nome = "jukes",
                Letras = "juke",
                Cargo = Cargo.ScrumMaster
            };
            // Armazena os dados do usuário na tabela AspNetUsers
            var result = await _userManager.CreateAsync(user, "/Abc123");
        }
        public async Task AddClaim()
        {
            var admin = _database.Empregados.FirstOrDefault(x => x.Email == "clecio.silva@gft.com");
            var scrumUm = _database.Empregados.FirstOrDefault(x => x.Email == "yoda@gft.com");
            var scrumDois = _database.Empregados.FirstOrDefault(x => x.Email == "jukes@gft.com");
            var adminClaim = new Claim("Permissao", "Administrador");
            var scrumClaim = new Claim("Permissao", "ScrumMaster");
            var result = await _userManager.AddClaimAsync(admin, adminClaim);
            result = await _userManager.AddClaimAsync(scrumUm, scrumClaim);
            result = await _userManager.AddClaimAsync(scrumDois, scrumClaim);


        }




    }

}


