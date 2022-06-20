using System.Collections.Generic;

namespace ProjetoFinal_POO2.Models
{
    public class Curso
    {
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }
    }
}
