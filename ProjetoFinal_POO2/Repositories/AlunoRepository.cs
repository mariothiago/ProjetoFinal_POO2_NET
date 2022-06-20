using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Repositories.Interfaces;
using ProjetoFinal_POO2.Repositories.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private IConfiguration _configuration;
        public AlunoRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> CadastroAlunos(Aluno aluno)
        {
            try
            {
                using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(AlunoScripts.CreateAluno, aluno);
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<IEnumerable<Aluno>> GetAllAlunos()
        {
            try
            {
                using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryAsync<Aluno>(AlunoScripts.GetAllAlunos);
                }
            }
            catch (Exception) { throw; }
        }
    }
}
