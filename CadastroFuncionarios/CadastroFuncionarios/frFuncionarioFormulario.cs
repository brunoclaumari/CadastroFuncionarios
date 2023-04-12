using CadastroFuncionarios.DAO;
using CadastroFuncionarios.Entidades;
using CadastroFuncionarios.Enums;
using CadastroFuncionarios.Servicos;
using DevExpress.Utils.Controls;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CadastroFuncionarios
{
    public partial class frFuncionarioFormulario : XtraForm
    {
        private readonly EnumTipoCrud _tipoCrud;

        private Funcionario _entidadeParaEdicao;
        

        public frFuncionarioFormulario(EnumTipoCrud enumTipoCrud, Funcionario funcionarioEdicao = null)
        {
            InitializeComponent();
            _tipoCrud = enumTipoCrud;
            _entidadeParaEdicao = funcionarioEdicao;
        }

        private void frFuncionarioFormulario_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                CarregaComboBoxes();                
                InicializaFormCarregadoParaEdicao();
            }
        }

        private void InicializaFormCarregadoParaEdicao()
        {
            if (_entidadeParaEdicao != null)
            {
                txtNomeFuncionario.Text = _entidadeParaEdicao.Nome;
                txtCpf.Text = _entidadeParaEdicao.Cpf;
                txtCargoFuncionario.Text = _entidadeParaEdicao.Cargo;
                cbNivelCargoFuncionario.SelectedValue = _entidadeParaEdicao.NivelId;
                cbSetorFuncionario.SelectedValue = _entidadeParaEdicao.SetorId;
                txtSalarioFuncionario.EditValue = _entidadeParaEdicao.Salario;
                dateTimeAdmissaoFuncionario.DateTimeOffset = _entidadeParaEdicao.DataAdmissao;

            }
            AlteraTextosConformeOperacao();
        }

        private void AlteraTextosConformeOperacao()
        {
            if (_entidadeParaEdicao != null && _tipoCrud == EnumTipoCrud.Alterar)
            {
                this.Text = "Editar funcionário";
                btnEditarFuncionario.Visible = true;
                btnCadastrarFuncionario.Visible = false;
            }
            else
            {
                this.Text = "Cadastrar funcionário";
                btnCadastrarFuncionario.Visible = true;
                btnEditarFuncionario.Visible = false;
            }
        }

        private Funcionario PreencheEntidadeComDadosDoForm()
        {
            Funcionario funcionario = new Funcionario
            {
                Nome = txtNomeFuncionario.Text.Trim(),
                Cpf = txtCpf.Text.Trim(),
                Cargo = txtCargoFuncionario.Text.Trim(),
                DataAdmissao = Convert.ToDateTime(dateTimeAdmissaoFuncionario.Text.Trim()),
                Salario = Convert.ToDouble(txtSalarioFuncionario.Text.Trim()),
                NivelId = Convert.ToInt32(cbNivelCargoFuncionario.SelectedValue),
                SetorId = Convert.ToInt32(cbSetorFuncionario.SelectedValue),                
            };

            if (_entidadeParaEdicao != null && _entidadeParaEdicao.Id > 0)
                funcionario.Id = _entidadeParaEdicao.Id;

            return funcionario;
        }

        private void SalvarFuncionario()
        {
            string verboOperacao = string.Empty;
            
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario funcionario = PreencheEntidadeComDadosDoForm();

            int retorno = FazInserirOuAlterarFuncionario(ref verboOperacao, dao, funcionario);
            string mensagem = $"Funcionário {funcionario.Nome} {verboOperacao} com sucesso!!";

            if (retorno > 0)
            {
                MessageBox.Show(this, mensagem, "Deu certo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UtilService.LimparControles(this);
                //LimparControles();
            }
        }

        private int FazInserirOuAlterarFuncionario(ref string verboOperacao, FuncionarioDAO dao, Funcionario funcionario)
        {
            int retorno = -100;
            switch (_tipoCrud)
            {
                case EnumTipoCrud.Inserir:
                    verboOperacao = "salvo";
                    retorno = dao.SalvaInsert(funcionario);
                    break;
                case EnumTipoCrud.Alterar:
                    verboOperacao = "alterado";
                    retorno = dao.SalvaEdicao(funcionario);
                    break;
            }
            return retorno;
        }

        private void CarregaComboBoxes()
        {
            CarregaComboNivelCargo();
            CarregaComboSetor();
        }

        private void CarregaComboNivelCargo()
        {            
            NivelCargoDAO dao = new NivelCargoDAO();
            cbNivelCargoFuncionario.ValueMember = "Id";
            cbNivelCargoFuncionario.DisplayMember = "Descricao";
            
            List<NivelCargo> listaNiveis = dao.ListaRegistros();
            cbNivelCargoFuncionario.DataSource = listaNiveis;
        }

        private void CarregaComboSetor()
        {
            SetorDAO dao = new SetorDAO();
            cbSetorFuncionario.ValueMember = "Id";
            cbSetorFuncionario.DisplayMember = "Descricao";

            List<Setor> listaSetores = dao.ListaRegistros();
            cbSetorFuncionario.DataSource = listaSetores;
        }

        private void btnCadastraUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"Abre cadastro de login","Olá",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if(ValidaDadosFormulario())
                SalvarFuncionario();
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (ValidaDadosFormulario())
                SalvarFuncionario();

        }

        void LimparControles()
        {
            //XtraForm
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is BaseEdit)
                    (ctrl as BaseEdit).EditValue = null;
            }
        }

        private bool ValidaDadosFormulario()
        {
            bool permiteSalvar = true;
            permiteSalvar = permiteSalvar && VerificaCamposVazios(txtNomeFuncionario);
            permiteSalvar = permiteSalvar && VerificaCamposVazios(txtCargoFuncionario);
            permiteSalvar = permiteSalvar && VerificaCamposVazios(txtSalarioFuncionario);
            permiteSalvar = permiteSalvar && CpfValido(txtCpf);
            //if (string.IsNullOrEmpty(txtNomeFuncionario.Text.Trim()))
            //{
            //    errorProviderFuncionario.SetError(txtNomeFuncionario, "Campo Obrigatório");
            //    permiteSalvar = false;
            //}            

            return permiteSalvar;
        }

        private bool CpfValido(TextEdit txtCpf)
        {
            bool cpfEhValido = UtilService.CpfEhValido(txtCpf.Text);
            if(!cpfEhValido)
                errorProviderFuncionario.SetError(txtCpf, "Valor CPF inválido");

            return cpfEhValido;
        }

        private bool VerificaCamposVazios(TextEdit textEdit)
        {
            bool permiteSalvar = true;
            if (string.IsNullOrEmpty(textEdit.Text.Trim()))
            {
                errorProviderFuncionario.SetError(textEdit, "Campo Obrigatório!!");
                permiteSalvar = false;
            }
            return permiteSalvar;
        }

        private void txtNomeFuncionario_EditValueChanged(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text != "")
                ApagaErrorProviderEspecifico(txtNomeFuncionario);
        }

        private void ApagaErrorProviderEspecifico(ControlBase control)
        {
            errorProviderFuncionario.SetError(control, string.Empty);
        }

        private void ApagaErrorProviderEspecifico(Control control)
        {
            errorProviderFuncionario.SetError(control, string.Empty);
        }

        private void cbNivelCargoFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtLoginUsuarioFuncionario.Enabled = 
        }

        private void cbSetorFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frFuncionarioFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            UtilService.LimparControles(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}