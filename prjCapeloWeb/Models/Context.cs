using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prjCapeloWeb.Models;

namespace prjCapeloWeb.Models
{
    public class Context : IdentityDbContext<Pessoa>
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Exercicio> Exercicios { get; set; }        
        public DbSet<GrupoMuscular> GruposMusculares{ get; set; }
        public DbSet<Pessoa> Pessoas{ get; set; }
    }
}
