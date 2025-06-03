using Microsoft.EntityFrameworkCore;

namespace WebAppNoite.Models
{
    public class ContextoAluno : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbEscolinha");
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }
    }
}

