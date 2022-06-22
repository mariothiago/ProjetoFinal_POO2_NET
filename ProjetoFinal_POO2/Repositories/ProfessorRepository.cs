using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Repositories.Interfaces;
using ProjetoFinal_POO2.Repositories.Scripts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private IConfiguration _configuration;
        public ProfessorRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> CreateProfessor(Professor professor)
        {
            try
            {
                using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(ProfessorScripts.CreateProfessor, professor);
                }
            }
            catch (Exception) { throw; }
        }

        public Task<IEnumerable<Professor>> GetAllProfessores()
        {
            throw new NotImplementedException();
        }
    }
}
