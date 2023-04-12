using CadastroFuncionarios.DAO;
using CadastroFuncionarios.Entidades;
using CadastroFuncionarios.Enums;
using DevExpress.XtraEditors;
using System;
using System.Linq;

namespace CadastroFuncionarios
{
    public partial class frPrincipal : XtraForm
    {

        private Usuario _usuarioLogado = null;

        public frPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this._usuarioLogado = usuario;
        }

        private void btnCrudFuncionarios_Click(object sender, EventArgs e)
        {
            using (frFuncionarios frFuncionarios = new frFuncionarios())
            {
                frFuncionarios.ShowDialog(this);
            }
        }

        private void btnCrudUsuarios_Click(object sender, EventArgs e)
        {
            using (frUsuarioFormulario frUsuario = new frUsuarioFormulario(EnumTipoCrud.Inserir))
            {
                frUsuario.ShowDialog(this);
            }

        }

        private void frPrincipal_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if(_usuarioLogado != null)
                {
                    FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                    Funcionario funcionario = funcionarioDAO.ListaRegistrosComDescricoes()
                        .FirstOrDefault(x => x.Id == _usuarioLogado.FuncionarioId);
                    if(funcionario != null && funcionario.Id > 0)
                    {
                        string primeiroNome = funcionario.Nome.Substring(0, funcionario.Nome.IndexOf(" "));
                        lblUsuarioLogado.Visible = true;
                        lblUsuarioLogado.Text = $"Olá {primeiroNome}";

                    }
                }
            }
        }
    }
}