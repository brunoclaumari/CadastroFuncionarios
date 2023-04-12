using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionarios.Servicos
{
    public class UtilService
    {

		/// <summary>
		/// Código para validar CPF. 
		/// <para>Obtido no site https://www.macoratti.net/11/09/c_val1.htm </para>
		/// </summary>
		/// <param name="cpf"></param>
		/// <returns></returns>
		public static bool CpfEhValido(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}

		public static void LimparControles(XtraForm form)
		{			
			foreach (Control ctrl in form.Controls)
			{
				if (ctrl is BaseEdit)
					(ctrl as BaseEdit).EditValue = null;
			}
		}

		public static void LimparErrosDosControles(XtraForm form, ref ErrorProvider errorProvider)
		{
			foreach (Control ctrl in form.Controls)
			{
				if (ctrl is BaseEdit)
					errorProvider.SetError(ctrl,string.Empty);
			}
		}

		public static void MostraMensagemErro(string titulo, string mensagem)
        {
			MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void MostraMensagemInformacao(string titulo, string mensagem)
		{
			MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void MostraMensagemAlerta(string titulo, string mensagem)
		{
			MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public static void MostraMensagemAlertaSimNao(string titulo, string mensagem)
		{
			MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
		}
	}
}
