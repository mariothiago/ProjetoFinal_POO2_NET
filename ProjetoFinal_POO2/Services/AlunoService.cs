using Microsoft.Extensions.Configuration;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Repositories;
using ProjetoFinal_POO2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Services
{
    public class AlunoService : IAlunoService
    {
        private AlunoRepository _repository;
        public AlunoService(IConfiguration config)
        {
            _repository = new AlunoRepository(config);
        }

        public async Task<int> CadastroAlunos(Aluno aluno)
        {
            try
            {
                return await _repository.CadastroAlunos(aluno);
            }
            catch (Exception) { throw; }
        }

        public async Task<IEnumerable<Aluno>> GetAllAlunos()
        {
            try
            {
                return await _repository.GetAllAlunos();
            }
            catch (Exception) { throw; }
        }
    }
}
