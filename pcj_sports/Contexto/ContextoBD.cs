using pcj_sports.Models;
//using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pcj_sports.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Organizacao> Organizacoes { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
    }
}
