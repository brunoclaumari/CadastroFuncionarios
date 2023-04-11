using CadastroFuncionarios.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CadastroFuncionarios.DAO
{
    public abstract class GenericDAO<T> where T:GenericClass
    {
        
        protected string Tabela { get; set; }

        protected string ProcedureInsert { get; set; }

        protected string ProcedureUpdate{ get; set; }

        public string ProcedureDelete { get; set; }

        public string ProcedureListagem { get; set; }

        protected abstract void SetParametrosDaTabela();

        protected abstract T MontaEntidade(DataRow linhaDeDados);

        protected abstract SqlParameter[] CriaParametros(T entidade);

        protected GenericDAO()
        {
            SetParametrosDaTabela();
            ProcedureDelete = "spDelete";
            ProcedureListagem = "spListagem";
        }

        public virtual SqlParameter[] ObtemParametrosParaListagem(string parametroParaOrdenacao)
        {
            SqlParameter[] parametros =
{
                new SqlParameter("@TABELA",Tabela),
                new SqlParameter("@ORDEM",parametroParaOrdenacao),
            };

            return parametros;
        }

        public virtual List<T> ListaRegistros()
        {
            var parametros = ObtemParametrosParaListagem("1");
            var tabela = HelperDAO.ExecutaProcedureSelect("spListagem", parametros);
            List<T> lista = new List<T>();
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaEntidade(registro));
            }
            return lista;
        }
    }
}
