using CadastroFuncionarios.DAO;
using CadastroFuncionarios.Entidades;
using CadastroFuncionarios.Enums;
using CadastroFuncionarios.Servicos;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

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
                CarregaDadosIniciaisDoForm();
            }
        }

        private void CarregaDadosIniciaisDoForm()
        {
            ConfiguraComboFuncionariosAutorizados();
            PreencheComboFuncionariosAutorizados();
            ConfiguraComboPerfilUsuario();
            PreencheComboPerfilUsuario();
        }

        private void PreencheComboPerfilUsuario()
        {
            PerfilUsuarioDAO dao = new PerfilUsuarioDAO();
            cbPerfilUsuario.DataSource = dao.ListaRegistros();
        }

        private void ConfiguraComboPerfilUsuario()
        {
            cbPerfilUsuario.ValueMember = Constantes.Constantes.Id;
            cbPerfilUsuario.DisplayMember = Constantes.Constantes.Descricao;
        }

        private void PreencheComboFuncionariosAutorizados()
        {
            /*
             Gerência, Financeiro são os setores que permitem ao funcionário ter login
             */
            
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            var listaFuncionariosAutorizados = funcionarioDAO.ListaFuncionariosAutorizadosSemLogin();
            cbFuncionariosAutorizados.DataSource = listaFuncionariosAutorizados;
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

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            UtilService.LimparErrosDosControles(this, ref errorProviderUsuario);

            if (ValidaDados() && LoginPermitido())
                SalvarUsuario();                
        }


        private bool LoginPermitido()
        {
            bool loginPermitido = false;
            string loginDigitado = txtLogin.EditValue.ToString();

            UsuarioDAO dao = new UsuarioDAO();
            var usuarioExistente = dao.ListaRegistros().FindAll(x => x.Login == loginDigitado);
            //Se a lista de usuário vier 
            if (usuarioExistente is null || usuarioExistente.Count == 0)
                loginPermitido = true;
            else
                errorProviderUsuario.SetError(txtLogin, "Este login, nic-name ou email já está cadastrado para outro usuário. Digite outro!");

            return loginPermitido;
        }

        private bool ValidaDados()
        {
            bool retornoValido = true;
            if (txtLogin.EditValue is null || string.IsNullOrEmpty(txtLogin.EditValue.ToString()))
            {
                errorProviderUsuario.SetError(txtLogin, "O campo login não pode ser vazio!!");
                retornoValido = false;
            }
            if (txtSenha.EditValue is null || string.IsNullOrEmpty(txtSenha.EditValue.ToString()) || txtSenha.EditValue.ToString().Length < 6)
            {
                errorProviderUsuario.SetError(txtSenha, "Senha deve ter de 6 a 10 caracteres!!");
                retornoValido = false;
            }            

            return retornoValido;
        }

        private void SalvarUsuario()
        {//Deixa o método preparado para mudar, caso futuramente seja possível alterar um usuário. No momento só será possível inserir
            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                Usuario usuarioForm = PreencheEntidadeComDadosDoForm();

                int retorno = InserirUsuario(dao, usuarioForm);
                string mensagem = $"Usuário \"{usuarioForm.Login}\" inserido com sucesso!!";

                if (retorno > 0)
                {                    
                    UtilService.MostraMensagemInformacao("Deu certo!", mensagem);
                    UtilService.LimparControles(this);
                    CarregaDadosIniciaisDoForm();
                }

            }
            catch (Exception e)
            {                
                UtilService.MostraMensagemErro("Erro!", "Ocorreu um erro ao tentar inserir o Usuário");
            }
        }

        private int InserirUsuario(UsuarioDAO dao, Usuario usuario)
        {
            return dao.SalvaInsert(usuario);            
        }

        private Usuario PreencheEntidadeComDadosDoForm()
        {
            Usuario usuario = new Usuario
            {
                Login = txtLogin.EditValue.ToString(),
                Senha = txtSenha.EditValue.ToString(),
                FuncionarioId = Convert.ToInt32(cbFuncionariosAutorizados.SelectedValue),
                PerfilUsuarioId = Convert.ToInt32(cbPerfilUsuario.SelectedValue)
            };

            //if (_entidadeParaEdicao != null && _entidadeParaEdicao.Id > 0)
            //    funcionario.Id = _entidadeParaEdicao.Id;

            return usuario;
        }

        private void txtLogin_EditValueChanged(object sender, EventArgs e)
        {
            UtilService.LimparErrosDosControles(this, ref errorProviderUsuario);
        }

        private void txtSenha_EditValueChanged(object sender, EventArgs e)
        {
            UtilService.LimparErrosDosControles(this, ref errorProviderUsuario);
        }
    }
}