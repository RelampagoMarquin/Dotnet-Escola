using Microsoft.EntityFrameworkCore;
using Escola.Model;

namespace Escola.data
{
    public class EscolaDbContext : DbContext
    {
       public EscolaDbContext(DbContextOptions<EscolaDbContext> options):base(options){
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.LowercaseRelationalTableANdPropertyNames();
        }
        public DbSet<Aluno>? Alunos {get; set;}
        public DbSet<Curso>? Cursos {get; set;}
        public DbSet<Disciplina>? Disciplinas {get; set;}
    }

    static class DataContextExtensions{
        public static void LowercaseRelationalTableANdPropertyNames(this ModelBuilder modelBuilder){
            foreach (var entity in modelBuilder.Model.GetEntityTypes()){
                entity.SetTableName(entity.GetTableName().ToLowerInvariant());
                foreach (var property in entity.GetProperties()){
                    property.GetColumnName().ToLowerInvariant();
                }
            }
        }
    }
}
 