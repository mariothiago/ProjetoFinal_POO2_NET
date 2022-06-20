namespace ProjetoFinal_POO2.Repositories.Scripts
{
    public class AlunoScripts
    {
        internal static string Table = "ALUNOS";

        internal static string GetAllAlunos = $@"SELECT NOME_ALUNO AS Nome,
                                                      MATRICULA AS Matricula,
                                                      CPF AS Cpf
                                                FROM {Table};";

        internal static string CreateAluno = $@"INSERT INTO {Table} (
                                                        NOME_ALUNO,
                                                        MATRICULA,
                                                        CPF
                                                    ) VALUES (
                                                        @Nome,
                                                        @Matricula,
                                                        @CPF
                                                    );";
    }
}
