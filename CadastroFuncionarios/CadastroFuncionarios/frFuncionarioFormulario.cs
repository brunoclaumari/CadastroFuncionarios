using CadastroFuncionarios.Enums;
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
    public partial class frFuncionarioFormulario : DevExpress.XtraEditors.XtraForm
    {
        private EnumTipoCrud _tipoCrud;

        public frFuncionarioFormulario(EnumTipoCrud enumTipoCrud)
        {
            InitializeComponent();
            _tipoCrud = enumTipoCrud;
        }
    }
}