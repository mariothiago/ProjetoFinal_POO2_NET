using ProjetoFinal_POO2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Services.Interfaces
{
    public interface IProfessorService
    {
        public Task<IEnumerable<Professor>> GetAllProfessores();
        public Task<int> CreateProfessor(Professor professor);
    }
}
