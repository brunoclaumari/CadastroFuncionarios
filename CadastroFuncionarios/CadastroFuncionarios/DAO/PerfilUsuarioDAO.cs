using CadastroFuncionarios.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CadastroFuncionarios.DAO
{
    public class PerfilUsuarioDAO : GenericDAO<PerfilUsuario>
    {
        public struct CAMPOS
        {
            public static string PFU_ID = "PFU_ID";
            public static string PFU_DESCRICAO = "PFU_DESCRICAO";
        }

        protected override SqlParameter[] CriaParametros(PerfilUsuario entidade)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter(CAMPOS.PFU_ID,entidade.Id),
                 new SqlParameter(CAMPOS.PFU_DESCRICAO,entidade.Descricao)
            };

            return parametros;
        }

        protected override PerfilUsuario MontaEntidade(DataRow linhaDeDados)
        {
            PerfilUsuario perfilUsuario = new PerfilUsuario
            {
                Id = Convert.ToInt64(linhaDeDados[CAMPOS.PFU_ID]),
                Descricao = linhaDeDados[CAMPOS.PFU_DESCRICAO].ToString()
            };

            return perfilUsuario;
        }

        protected override void SetParametrosDaTabela()
        {
            Tabela = "tbPerfilUsuario";
            //ProcedureInsert = "spInsertSetor";
            //ProcedureUpdate = "spUpdateSetor";            
        }
    }
}
