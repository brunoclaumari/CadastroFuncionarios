using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionarios
{
    public partial class frPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrudFuncionarios_Click(object sender, EventArgs e)
        {
            using (frFuncionarios frFuncionarios = new frFuncionarios())
            {
                frFuncionarios.ShowDialog(this);
            }

        }
    }
}