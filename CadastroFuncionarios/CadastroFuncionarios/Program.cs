using CadastroFuncionarios.Entidades;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CadastroFuncionarios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Abre a tela de login
            frLogin frLogin = new frLogin();
            if (frLogin.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = frLogin.GetUsuarioLogado();
                frLogin.Dispose();
                Application.Run(new frPrincipal(usuario));
            }

                     
        }
    }
}
