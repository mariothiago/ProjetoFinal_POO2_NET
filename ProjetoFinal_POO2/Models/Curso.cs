using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Models
{
    public class Curso
    {
        public Professor NomeProfessor { get; set; }
        public List<Aluno> alunos { get; set; }
    }
}
