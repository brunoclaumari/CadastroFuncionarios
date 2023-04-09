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
    public class FuncionarioDAO
    {

        public string Tabela = "tbFuncionario";

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

        /*

         FUN_ID INT 
         FUN_NOME 
         FUN_CARGO
         FUN_DATA_ADMISSAO 
         FUN_CPF 
         FUN_SALARIO 
         NIC_ID 
         STR_ID 
         USU_ID 
         */

        public FuncionarioDAO()
        {
        }

        public List<Funcionario> ListaRegistros()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            string sql = $"select * from {Tabela}";
            DataTable dados = HelperDAO.ExecutaSelect(sql, null);
            for (int i = 0; i < dados.Rows.Count; i++)
            {
                listaFuncionarios.Add(MontaEntidade(dados.Rows[i]));
            }

            return listaFuncionarios;
        }

        public SqlParameter[] CriaParametros(Funcionario model)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter(CAMPOS.FUN_ID,model.Id),
                 new SqlParameter(CAMPOS.FUN_NOME,model.Nome),
                 new SqlParameter(CAMPOS.FUN_CARGO,model.Cargo),
                 new SqlParameter(CAMPOS.FUN_DATA_ADMISSAO,model.DataAdmissao),
                 new SqlParameter(CAMPOS.FUN_CPF,model.Cpf),
                 new SqlParameter(CAMPOS.FUN_SALARIO,model.Salario),
                 new SqlParameter(CAMPOS.NIC_ID,model.NivelId),
                 new SqlParameter(CAMPOS.STR_ID,model.SetorId),
                 new SqlParameter(CAMPOS.USU_ID,model.UsuarioId)
            };

            return parametros;
        }



        public Funcionario MontaEntidade(DataRow linhaDeDados)
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
                SetorId = Convert.ToInt32(linhaDeDados[CAMPOS.STR_ID]),
                UsuarioId = linhaDeDados[CAMPOS.STR_ID] == null ? 0 : Convert.ToInt32(linhaDeDados[CAMPOS.USU_ID])

            };
            //string sql = $"select * from {Tabela}";
            //DataTable dados = HelperDAO.ExecutaSelect(sql, null);
            //for (int i = 0; i < dados.Rows.Count; i++)
            //{

            //}


            return funcionario;
        }
    }
}
