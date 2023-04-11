using CadastroFuncionarios.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CadastroFuncionarios.DAO
{
    public class SetorDAO : GenericDAO<Setor>
    {
        /*
         STR_ID INT NOT NULL,
	STR_DESCRICAO varchar(255) NOT NULL,
         */

        public class CAMPOS
        {
            public static string STR_ID = "STR_ID";
            public static string STR_DESCRICAO = "STR_DESCRICAO";
        }

        protected override SqlParameter[] CriaParametros(Setor entidade)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter(CAMPOS.STR_ID,entidade.Id),
                 new SqlParameter(CAMPOS.STR_DESCRICAO,entidade.Descricao)
            };

            return parametros;
        }

        protected override Setor MontaEntidade(DataRow linhaDeDados)
        {
            Setor setor = new Setor
            {
                Id = Convert.ToInt64(linhaDeDados[CAMPOS.STR_ID]),
                Descricao = linhaDeDados[CAMPOS.STR_DESCRICAO].ToString()
            };

            return setor;
        }

        protected override void SetParametrosDaTabela()
        {
            Tabela = "tbSetor";
            //ProcedureInsert = "spInsertSetor";
            //ProcedureUpdate = "spUpdateSetor";            
        }
    }
}
