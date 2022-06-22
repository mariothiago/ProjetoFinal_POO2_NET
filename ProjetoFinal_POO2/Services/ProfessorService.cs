using Microsoft.Extensions.Configuration;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Repositories;
using ProjetoFinal_POO2.Repositories.Interfaces;
using ProjetoFinal_POO2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Services
{
    public class ProfessorService : IProfessorService
    {
        private ProfessorRepository _repository;
        public ProfessorService(IConfiguration config)
        {
            _repository = new ProfessorRepository(config);
        }

        public async Task<int> CreateProfessor(Professor professor)
        {
            try
            {
                return await _repository.CreateProfessor(professor);
            }
            catch (Exception) { throw; }
        }

        public Task<IEnumerable<Professor>> GetAllProfessores()
        {
            throw new NotImplementedException();
        }
    }
}
