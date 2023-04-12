using CadastroFuncionarios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CadastroFuncionarios.DAO
{
    public class FuncionarioDAO : GenericDAO<Funcionario>
    {        

        protected override void SetParametrosDaTabela()
        {
            Tabela = "tbFuncionario";
            ProcedureInsert = "spInsertFuncionario";
            ProcedureUpdate = "spUpdateFuncionario";
        }

        public struct CAMPOS
        {
            public static string FUN_ID = "FUN_ID";
            public static string FUN_NOME = "FUN_NOME";
            public static string FUN_CARGO = "FUN_CARGO";
            public static string FUN_DATA_ADMISSAO = "FUN_DATA_ADMISSAO";
            public static string FUN_CPF = "FUN_CPF";
            public static string FUN_SALARIO = "FUN_SALARIO";
            public static string NIC_ID = "NIC_ID";
            public static string STR_ID = "STR_ID";
            public static string USU_ID = "USU_ID";
        }

        public int SalvaInsert(Funcionario entidade)
        {
            int retorno = -100;

            retorno = HelperDAO.ExecutaProcedure(ProcedureInsert, CriaParametros(entidade));

            return retorno;
        }

        public int SalvaEdicao(Funcionario entidade)
        {
            int retorno = -100;

            retorno = HelperDAO.ExecutaProcedure(ProcedureUpdate, CriaParametros(entidade));

            return retorno;
        }

        protected override SqlParameter[] CriaParametros(Funcionario entidade)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter(CAMPOS.FUN_ID,entidade.Id),
                 new SqlParameter(CAMPOS.FUN_NOME,entidade.Nome),
                 new SqlParameter(CAMPOS.FUN_CARGO,entidade.Cargo),
                 new SqlParameter(CAMPOS.FUN_DATA_ADMISSAO,entidade.DataAdmissao),
                 new SqlParameter(CAMPOS.FUN_CPF,entidade.Cpf),
                 new SqlParameter(CAMPOS.FUN_SALARIO,entidade.Salario),
                 new SqlParameter(CAMPOS.NIC_ID,entidade.NivelId),
                 new SqlParameter(CAMPOS.STR_ID,entidade.SetorId)
                 
            };

            return parametros;
        }

        public List<Funcionario> ListaRegistrosComDescricoes()
        {
            List<Funcionario> lista = ListaRegistros();
            foreach (var funcionario in lista)
            {
                funcionario.NivelDescricao = ObtemNivelDescricao(funcionario.NivelId);
                funcionario.SetorDescricao = ObtemSetorDescricao(funcionario.SetorId);
            }

            return lista;
        }

        private string ObtemSetorDescricao(long setorId)
        {
            SetorDAO setorDAO = new SetorDAO();

            return setorDAO.ListaRegistros().FirstOrDefault(x => x.Id == setorId).Descricao;
        }

        private string ObtemNivelDescricao(long nivelId)
        {
            NivelCargoDAO nivelDAO = new NivelCargoDAO();

            return nivelDAO.ListaRegistros().FirstOrDefault(x => x.Id == nivelId).Descricao;
        }

        protected override Funcionario MontaEntidade(DataRow linhaDeDados)
        {
            Funcionario funcionario = new Funcionario
            {
                Id = Convert.ToInt64(linhaDeDados[CAMPOS.FUN_ID]),
                Nome = linhaDeDados[CAMPOS.FUN_NOME].ToString(),
                Cargo = linhaDeDados[CAMPOS.FUN_CARGO].ToString(),
                Cpf = linhaDeDados[CAMPOS.FUN_CPF].ToString(),
                Salario = Convert.ToDouble(linhaDeDados[CAMPOS.FUN_SALARIO]),
                DataAdmissao = Convert.ToDateTime(linhaDeDados[CAMPOS.FUN_DATA_ADMISSAO]),
                NivelId = Convert.ToInt32(linhaDeDados[CAMPOS.NIC_ID]),
                SetorId = Convert.ToInt32(linhaDeDados[CAMPOS.STR_ID])
            };

            return funcionario;
        }

        public int ApagarDados(long id)
        {   
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_VALOR",id),
                new SqlParameter("@ID_PARAMETRO",CAMPOS.FUN_ID),
                new SqlParameter("@TABELA",Tabela)
            };
            int retorno = HelperDAO.ExecutaProcedure(ProcedureDelete, parametros);

            return retorno;
        }

        public List<Funcionario> ListaFuncionariosAutorizadosSemLogin()
        {   
            SqlParameter[] parametros =
            {
                new SqlParameter("@SETOR_GERENCIA",1),
                new SqlParameter("@SETOR_FINANCEIRO",2),
                
            };
            //STR_ID = 1 é de setor de Gerencia e STR_ID = 2 é do Financeiro. Apenas esses podem ter usuário cadastrado no sistema
            string comandoSql = $"SELECT tbFuncionario.* FROM tbFuncionario LEFT JOIN tbUsuario ON tbUsuario.FUN_ID = tbFuncionario.FUN_ID " +
                $"WHERE tbFuncionario.STR_ID IN (@SETOR_GERENCIA , @SETOR_FINANCEIRO) AND tbUsuario.FUN_ID IS NULL";
            
            DataTable tabela = HelperDAO.ExecutaSelect(comandoSql, parametros);

            List<Funcionario> lista = new List<Funcionario>();
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaEntidade(registro));
            }

            return lista;
        }
    }
}
