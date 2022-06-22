using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal_POO2.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Matrícula é obrigatória!")]
        public long Matricula { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório!")]
        public string CPF { get; set; }
    }
}
