using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Entidades
{
    public class Funcionario : GenericClass
    {
        /*
         	FUN_ID INT IDENTITY (1,1) NOT NULL,
	        FUN_NOME VARCHAR(MAX) NOT NULL,
            FUN_CARGO VARCHAR(MAX) NOT NULL,
	        FUN_DATA_ADMISSAO DATETIME NOT NULL,
	        FUN_CPF VARCHAR(20) NOT NULL,
	        FUN_SALARIO DECIMAL(10,2) NOT NULL,
	        NIC_ID INT NOT NULL,
	        STR_ID INT NOT NULL,
	        USU_ID INT NULL
         */
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Cpf { get; set; }
        public Double Salario { get; set; }
        public long NivelId { get; set; }
        //Esse dado não será persistido
        public string NivelDescricao { get; set; }
        public long SetorId { get; set; }
        //Esse dado não será persistido
        public string SetorDescricao { get; set; }

        public override string ToString()
        {

            return $"Id: {Id}, Nome: {Nome}, Cargo: {Cargo}, CPF: {Cpf}, Data de admissão: {DataAdmissao}, " +
                $"Salario: {Salario.ToString("#.00")}";
        }
    }
}
