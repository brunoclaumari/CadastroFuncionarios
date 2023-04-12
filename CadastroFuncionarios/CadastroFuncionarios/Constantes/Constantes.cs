using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Constantes
{
    public static class Constantes
    {        
        //Itens da entidade "Setor"
        public const string GERENCIA = "Gerência";
        public const string FINANCEIRO = "Financeiro";
        public const string TECNOLOGIA = "Tecnologia";
        public const string MARKETING = "Marketing";

        //Itens da entidade "Funcionario"
        public const string Id = "Id";
        public const string Nome = "Nome";

        //Itens da entidade "Usuario"
        public const string Descricao = "Descricao";

        public const int USUARIO_INVALIDO = -1;
        public const int SENHA_INVALIDA = 0;
        public const int USUARIO_SENHA_VALIDOS = 1;
        /*
            -se for igual a -1 usuario não cadastrado
            -se for igual a  0 senha invalida
            -se for igual a  1 vai logar
            */

    }
}
