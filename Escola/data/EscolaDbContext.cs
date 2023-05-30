using Microsoft.EntityFrameworkCore;
using Escola.Model;

namespace Escola.data
{
    public class EscolaDbContext : DbContext
    {
       public EscolaDbContext(DbContextOptions<EscolaDbContext> options):base(options){
            
        }

        public DbSet<Aluno>? Alunos {get; set;}
        public DbSet<Curso>? Cursos {get; set;}
        public DbSet<Disciplina>? Disciplinas {get; set;}
    }
}