using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Repositories.Scripts
{
    public class ProfessorScripts
    {
        internal static string Table = "professor";


        internal static string CreateProfessor = $@"INSERT INTO {Table} (
                                                        NOME_PROFESSOR,
                                                        CPF,
                                                        SALARIO
                                                    ) VALUES (
                                                        @Nome,
                                                        @CPF,
                                                        @Salario
                                                    );";
    }
}
