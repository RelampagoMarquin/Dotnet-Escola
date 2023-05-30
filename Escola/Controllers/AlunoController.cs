using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Escola.Model;
namespace Escola.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "alunos")]
        public List<Aluno>GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            List<Curso> cursos = new List<Curso>();
            List<Disciplina> disciplinas = new List<Disciplina>();
            disciplinas.Add(new Disciplina{
                Nome = "Programação para Internet",
                CargaHoraria = 60,
                Semestre = 6
            });

            disciplinas.Add(new Disciplina{
                Nome = "POO",
                CargaHoraria = 240,
                Semestre = 3 
            });
            cursos.Add(new Curso{
                Nome = "POO",
                Area = "240",
                Duracao = 3,
                Disciplinas = disciplinas 
            });

            cursos.Add(new Curso{
                Nome = "Back-end",
                Area = "130",
                Duracao = 4,
                Disciplinas = disciplinas
            });

            alunos.Add(new Aluno{
                Nome = "Alana",
                DataNascimento = new DateTime(2003,05,21),
                Cpf = "465.543.234-12",
                Disciplinas = disciplinas,
                Cursos = cursos
            });
            alunos.Add(new Aluno{
                Nome = "Ian",
                DataNascimento = new DateTime(2003,05,21),
                Cpf = "465.543.234-22",
                Disciplinas = disciplinas,
                Cursos = cursos 
            });
            alunos.Add(new Aluno{
                Nome = "Murilo",
                DataNascimento = new DateTime(2003,05,21),
                Cpf = "465.543.234-34",
                Disciplinas = disciplinas,
                Cursos = cursos 
            });
            return alunos;
        }
    }
}