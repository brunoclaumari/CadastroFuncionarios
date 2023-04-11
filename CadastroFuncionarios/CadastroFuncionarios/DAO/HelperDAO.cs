using System.Data;
using System.Data.SqlClient;

namespace CadastroFuncionarios.DAO
{
    public class HelperDAO
    {

        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            SqlConnection conexao;
            using (conexao = ConexaoBD.GetConexao())
            {
                //conexao = ConexaoBD.GetConexao();
                //conexao.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    conexao.Close();
                    return tabela;
                }
            }
        }

        public static int ExecutaProcedure(string nomeProcedure,
                                SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    return comando.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecutaProcedureSelect(string nomeProcedure, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(nomeProcedure, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    conexao.Close();
                    return tabela;
                }
            }
        }

    }
}
