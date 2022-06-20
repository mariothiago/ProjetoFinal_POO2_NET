using ProjetoFinal_POO2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Services.Interfaces
{
    public interface IAlunoService
    {
        public Task<IEnumerable<Aluno>> GetAllAlunos();
        public Task<int> CadastroAlunos(Aluno aluno);
    }
}
