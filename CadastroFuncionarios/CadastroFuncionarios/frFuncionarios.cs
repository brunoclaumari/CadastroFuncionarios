using CadastroFuncionarios.DAO;
using CadastroFuncionarios.Entidades;
using CadastroFuncionarios.Enums;
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
            //MessageBox.Show("Vai cadastrar novo funcionário");
            AbreFormularioFuncionario(EnumTipoCrud.Inserir);
        }

        private void AbreFormularioFuncionario(EnumTipoCrud enumTipoCrud)
        {
            using (frFuncionarioFormulario form = new frFuncionarioFormulario(enumTipoCrud))
            {
                form.ShowDialog(this);
            }
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
            listaFuncionario = funcDAO.ListaRegistros();
            gridControlFuncionarios.DataSource = listaFuncionario;
            //string msg = string.Empty;
            //for (int i = 0; i < listaFuncionario.Count; i++)
            //{
            //    msg += listaFuncionario[i];
            //}

            //MessageBox.Show(msg);

        }
    }
}
