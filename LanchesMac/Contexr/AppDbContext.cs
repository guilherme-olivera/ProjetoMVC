using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Contexr
{
    public class AppDbContext: DbContext
    {
        //opçoes de configuração 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        //mapeia as tabelas 
        //quais classes estão mapeando 
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Lanche> Lanches { get; set; }


    }
}
