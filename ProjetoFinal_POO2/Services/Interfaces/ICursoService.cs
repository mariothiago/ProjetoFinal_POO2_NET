using ProjetoFinal_POO2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Services.Interfaces
{
    public interface ICursoService
    {
        public Task<IEnumerable<Curso>> GetAllCursos();
        public Task<int> CreateCurso(Curso curso);
    }
}
