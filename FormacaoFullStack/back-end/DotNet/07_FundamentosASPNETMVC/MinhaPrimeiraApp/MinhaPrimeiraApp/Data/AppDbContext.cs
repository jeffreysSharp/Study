using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApp.Models;

namespace MinhaPrimeiraApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
