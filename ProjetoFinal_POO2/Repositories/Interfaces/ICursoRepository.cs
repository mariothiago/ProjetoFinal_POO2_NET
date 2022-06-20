using ProjetoFinal_POO2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Repositories.Interfaces
{
    public interface ICursoRepository
    {
        public Task<IEnumerable<Curso>> GetAllCursos();
        public Task<int> CreateCurso(Curso curso);
    }
}
