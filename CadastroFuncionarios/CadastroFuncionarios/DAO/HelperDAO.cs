using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
