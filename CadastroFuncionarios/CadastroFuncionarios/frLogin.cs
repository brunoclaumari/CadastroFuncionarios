using CadastroFuncionarios.DAO;
using CadastroFuncionarios.Entidades;
using CadastroFuncionarios.Servicos;
using DevExpress.XtraEditors;
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
    public partial class frLogin : XtraForm
    {
        private Usuario _usuarioLogado;

        public frLogin()
        {
            InitializeComponent();
        }

        public Usuario GetUsuarioLogado()
        {
            return _usuarioLogado;
        }

        private void btnLogarNoSIstema_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            int retornoValidacao = TestaUsuario();
            if (retornoValidacao == Constantes.Constantes.USUARIO_SENHA_VALIDOS)
            {
                _usuarioLogado = usuarioDAO.ListaRegistros().FirstOrDefault(x => x.Login == txtLogin.Text.Trim());
                DialogResult = DialogResult.OK;
            }
            else if (retornoValidacao == Constantes.Constantes.SENHA_INVALIDA)
            {
                UtilService.MostraMensagemErro("Erro!", "Senha inválida!");
            }
            else
            {                
                UtilService.MostraMensagemErro("Erro!", "Usuário inválido!");
            }
                
        }

        private int TestaUsuario()
        {            
            /*
            -se for igual a -1 usuario não cadastrado
            -se for igual a  0 senha invalida
            -se for igual a  1 vai logar
            */
            UsuarioDAO dao = new UsuarioDAO();
            int retorno = dao.TestaUsuarioSenha(txtLogin.Text, txtSenha.Text);            

            return retorno;
        }
    }
}
