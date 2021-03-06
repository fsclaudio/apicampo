using apicampo.Models;
using Microsoft.EntityFrameworkCore;

namespace apicampo.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options){}
        public DbSet<Tarefa> Tarefas{get; set;}
         public DbSet<Usuario> Usuarios{get; set;}
         public DbSet<Variaveis> Variaveis{get; set;}
         public DbSet<Indicadores> Indcadores{get; set;}
    }
}