using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Model
{
    public class Aluno
    {
        public int Id {get;set;}
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public List<Curso> Cursos {get; set;}
        public List<Disciplina> Disciplinas {get; set;}
    }
}