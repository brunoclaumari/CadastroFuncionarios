using CadastroFuncionarios.DAO;
using CadastroFuncionarios.Entidades;
using CadastroFuncionarios.Enums;
using CadastroFuncionarios.Servicos;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroFuncionarios
{
    public partial class frFuncionarios : DevExpress.XtraEditors.XtraForm
    {
        public frFuncionarios()
        {
            InitializeComponent();
        }



        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {            
            AbreFormularioFuncionario(EnumTipoCrud.Inserir);
        }

        private void AbreFormularioFuncionario(EnumTipoCrud enumTipoCrud, Funcionario funcionario = null)
        {
            using (frFuncionarioFormulario form = new frFuncionarioFormulario(enumTipoCrud, funcionario))
            {
                form.ShowDialog(this);
            }
            CarregaDados();
        }

        private void frFuncionarios_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                CarregaDados();
            }

        }

        private void CarregaDados()
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();
            FuncionarioDAO funcDAO = new FuncionarioDAO();
            //listaFuncionario = funcDAO.ListaRegistros();
            listaFuncionario = funcDAO.ListaRegistrosComDescricoes();

            gridControlFuncionarios.DataSource = listaFuncionario;

        }

        private void gridViewFuncionario_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView grid = sender as GridView;
            Funcionario funcionario = (Funcionario)grid.FocusedRowObject;
            if(e.Column.Name == colBotaoDeletar.Name)
            {
                FazPerguntaAntesDeApagarFuncionario(funcionario);
            }
            else if (e.Column.Name == colBotaoEditar.Name)
            {
                AbreFormularioFuncionario(EnumTipoCrud.Alterar, funcionario);
            }

        }

        private void FazPerguntaAntesDeApagarFuncionario(Funcionario funcionario)
        {
            string mensagem = $"Tem certeza que deseja apagar o funcionário \"{funcionario.Nome}\"?";

            DialogResult result = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int retorno = ApagarFuncionario(funcionario);
                
                if (retorno > 0)
                    UtilService.MostraMensagemInformacao("Ok!", $"\"{funcionario.Nome}\" apagado com sucesso");
                else if(retorno < 0)
                {
                    mensagem = $"Não foi possível apagar o funcionário \"{funcionario.Nome}\".";                    
                    UtilService.MostraMensagemErro("Ocorreu um erro ao tentar excluir!!", mensagem);
                }
                CarregaDados();
            }            
        }

        private int ApagarFuncionario(Funcionario funcionario)
        {
            int retorno;
            try
            {
                FuncionarioDAO funcDAO = new FuncionarioDAO();
                retorno = funcDAO.ApagarDados(funcionario.Id);

            }
            catch (Exception e)
            {                
                retorno = -100;
            }

            return retorno;
        }
    }
}
