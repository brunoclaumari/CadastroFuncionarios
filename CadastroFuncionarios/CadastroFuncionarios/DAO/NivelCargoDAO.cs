using CadastroFuncionarios.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CadastroFuncionarios.DAO
{
    public class NivelCargoDAO : GenericDAO<NivelCargo>
    {

        /*
         NIC_ID INT NOT NULL,
	NIC_DESCRICAO varchar(255) NOT NULL,
         */
        public struct CAMPOS
        {
            public static string NIC_ID = "NIC_ID";
            public static string NIC_DESCRICAO = "NIC_DESCRICAO";
        }

        protected override SqlParameter[] CriaParametros(NivelCargo entidade)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter(CAMPOS.NIC_ID,entidade.Id),
                 new SqlParameter(CAMPOS.NIC_DESCRICAO,entidade.Descricao)
            };

            return parametros;
        }

        protected override NivelCargo MontaEntidade(DataRow linhaDeDados)
        {
            NivelCargo nivel = new NivelCargo
            {
                Id = Convert.ToInt64(linhaDeDados[CAMPOS.NIC_ID]),
                Descricao = linhaDeDados[CAMPOS.NIC_DESCRICAO].ToString()
            };

            return nivel;
        }

        protected override void SetParametrosDaTabela()
        {
            Tabela = "tbNivelCargo";
            //ProcedureInsert = "spInsertNivelCargo";
            //ProcedureUpdate = "spUpdateNivelCargo";
        }
    }
}
