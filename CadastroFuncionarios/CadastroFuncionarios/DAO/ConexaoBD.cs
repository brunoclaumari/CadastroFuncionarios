using System.Data.SqlClient;

namespace CadastroFuncionarios.DAO
{
    public class ConexaoBD
    {
        private static SqlConnection _conexao;



        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=localhost;Initial Catalog=dbCadastroFuncionarios;user id=sa; password=123456";

            _conexao = new SqlConnection(strCon);            
            _conexao.Open();

            return _conexao;
        }
    }
}
