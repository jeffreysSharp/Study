using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApp.Data;
using MinhaPrimeiraApp.Models;

namespace MinhaPrimeiraApp.Controllers
{
    public class TestEFController : Controller
    {
        public AppDbContext Db { get; set; }

        public TestEFController(AppDbContext db)
        {
            Db = db;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Eduardo",
                Email = "hello@eduardo.com",
                DataNascimento = new DateTime(1982, 04, 24),
                Avaliacao = 5,
                Ativo = true
            };

            //Db.Alunos.Add(aluno);
            //Db.SaveChanges();

             var alunosChange = Db.Alunos.Where(a => a.Nome.Contains("Eduardo")).FirstOrDefault();
            //alunosChange.Nome = "Eduardo Pires";


            //Db.Alunos.Update(alunosChange);
            //Db.SaveChanges();

            Db.Alunos.Remove(alunosChange);
            Db.SaveChanges();

            return Content("");
        }
    }
}
