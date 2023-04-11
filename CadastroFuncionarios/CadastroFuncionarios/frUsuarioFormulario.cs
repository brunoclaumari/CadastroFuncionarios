using CadastroFuncionarios.DAO;
using CadastroFuncionarios.Enums;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;

namespace CadastroFuncionarios
{
    public partial class frUsuarioFormulario : XtraForm
    {

        private EnumTipoCrud enumTipoCrud;

        public frUsuarioFormulario(EnumTipoCrud enumTipoCrud)
        {
            InitializeComponent();
            this.enumTipoCrud = enumTipoCrud;
        }

        private void frUsuarioFormulario_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                PreencheComboFuncionariosAutorizados();
            }
        }

        private void PreencheComboFuncionariosAutorizados()
        {
            /*
             Gerência
                Financeiro
             */
            ConfiguraComboFuncionariosAutorizados();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            var listaFuncionariosAutorizados = funcionarioDAO.ListaRegistrosComDescricoes();
            if(listaFuncionariosAutorizados != null)
            {
                cbFuncionariosAutorizados.DataSource = listaFuncionariosAutorizados
                    .Where(x => x.SetorDescricao == Constantes.Constantes.GERENCIA).ToList();
            }
        }

        private void ConfiguraComboFuncionariosAutorizados()
        {
            cbFuncionariosAutorizados.ValueMember = Constantes.Constantes.Id;
            cbFuncionariosAutorizados.DisplayMember = Constantes.Constantes.Nome;
        }

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}