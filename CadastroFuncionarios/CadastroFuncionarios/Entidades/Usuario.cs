using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Entidades
{
    public class Usuario
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public int PerfilUsuarioId { get; set; }
    }
}
