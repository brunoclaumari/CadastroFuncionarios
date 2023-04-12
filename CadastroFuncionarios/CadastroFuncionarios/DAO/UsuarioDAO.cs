using CadastroFuncionarios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.DAO
{
    public class UsuarioDAO : GenericDAO<Usuario>
    {

        public struct CAMPOS
        {
            public static string USU_ID = "USU_ID";
            public static string USU_LOGIN = "USU_LOGIN";
            public static string USU_SENHA = "USU_SENHA";
            public static string FUN_ID = "FUN_ID";
            public static string PFU_ID = "PFU_ID";
        }

        protected override SqlParameter[] CriaParametros(Usuario entidade)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter(CAMPOS.USU_ID,entidade.Id),
                 new SqlParameter(CAMPOS.USU_LOGIN,entidade.Login),
                 new SqlParameter(CAMPOS.USU_SENHA,entidade.Senha),
                 new SqlParameter(CAMPOS.FUN_ID,entidade.FuncionarioId),
                 new SqlParameter(CAMPOS.PFU_ID,entidade.PerfilUsuarioId)   
            };

            return parametros;
        }

        protected override Usuario MontaEntidade(DataRow linhaDeDados)
        {
            Usuario usuario = new Usuario
            {
                Id = Convert.ToInt64(linhaDeDados[CAMPOS.USU_ID]),
                Login = linhaDeDados[CAMPOS.USU_LOGIN].ToString(),
                Senha = linhaDeDados[CAMPOS.USU_SENHA].ToString(),
                FuncionarioId = Convert.ToInt32(linhaDeDados[CAMPOS.FUN_ID]),
                PerfilUsuarioId = Convert.ToInt32(linhaDeDados[CAMPOS.PFU_ID]),

            };

            return usuario;
        }

        protected override void SetParametrosDaTabela()
        {
            Tabela = "tbUsuario";
            ProcedureInsert = "spInsertUsuario";
            //ProcedureUpdate = "spUpdateFuncionario"; //não foi criada ainda
        }

        public int SalvaInsert(Usuario entidade)
        {
            int retorno = HelperDAO.ExecutaProcedure(ProcedureInsert, CriaParametros(entidade));

            return retorno;
        }

        public int TestaUsuarioSenha(string login, string senha)
        {            
            var parametros = new SqlParameter[]
            {
                new SqlParameter(CAMPOS.USU_LOGIN,login),
                new SqlParameter(CAMPOS.USU_SENHA,senha)
            };
            var testeLogin = HelperDAO.ExecutaProcedureSelect("spValidaUsuario", parametros);
            
            return Convert.ToInt32(testeLogin.Rows[0][0]);
        }
    }
}
