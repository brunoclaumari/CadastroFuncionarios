using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Entidades
{
    public class Funcionario : GenericClass
    {
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
