
namespace CadastroFuncionarios
{
    partial class frUsuarioFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frUsuarioFormulario));
            this.cbFuncionariosAutorizados = new System.Windows.Forms.ComboBox();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionariosAutorizados = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.lblSenha = new DevExpress.XtraEditors.LabelControl();
            this.btnSairUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.btnCadastrarUsuario = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFuncionariosAutorizados
            // 
            this.cbFuncionariosAutorizados.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionariosAutorizados.FormattingEnabled = true;
            this.cbFuncionariosAutorizados.Location = new System.Drawing.Point(44, 52);
            this.cbFuncionariosAutorizados.Name = "cbFuncionariosAutorizados";
            this.cbFuncionariosAutorizados.Size = new System.Drawing.Size(372, 26);
            this.cbFuncionariosAutorizados.TabIndex = 12;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(44, 111);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Size = new System.Drawing.Size(372, 24);
            this.txtLogin.TabIndex = 11;
            // 
            // lblLogin
            // 
            this.lblLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Appearance.Options.UseFont = true;
            this.lblLogin.Location = new System.Drawing.Point(44, 87);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(192, 18);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Login (nic name ou email)";
            // 
            // lblFuncionariosAutorizados
            // 
            this.lblFuncionariosAutorizados.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionariosAutorizados.Appearance.Options.UseFont = true;
            this.lblFuncionariosAutorizados.Location = new System.Drawing.Point(44, 27);
            this.lblFuncionariosAutorizados.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblFuncionariosAutorizados.Name = "lblFuncionariosAutorizados";
            this.lblFuncionariosAutorizados.Size = new System.Drawing.Size(188, 18);
            this.lblFuncionariosAutorizados.TabIndex = 13;
            this.lblFuncionariosAutorizados.Text = "Funcionários autorizados";
            this.lblFuncionariosAutorizados.ToolTip = "Apenas Gerentes e pessoas do financeiro";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(44, 168);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.MaxLength = 8;
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(264, 24);
            this.txtSenha.TabIndex = 15;
            // 
            // lblSenha
            // 
            this.lblSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Appearance.Options.UseFont = true;
            this.lblSenha.Location = new System.Drawing.Point(44, 144);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 18);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha";
            // 
            // btnSairUsuario
            // 
            this.btnSairUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairUsuario.Appearance.Options.UseFont = true;
            this.btnSairUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.ImageOptions.Image")));
            this.btnSairUsuario.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSairUsuario.Location = new System.Drawing.Point(325, 228);
            this.btnSairUsuario.MaximumSize = new System.Drawing.Size(196, 62);
            this.btnSairUsuario.Name = "btnSairUsuario";
            this.btnSairUsuario.Size = new System.Drawing.Size(196, 62);
            this.btnSairUsuario.TabIndex = 22;
            this.btnSairUsuario.Text = "Sair";
            this.btnSairUsuario.Click += new System.EventHandler(this.btnSairUsuario_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.Appearance.Options.UseFont = true;
            this.btnCadastrarUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarFuncionario.ImageOptions.Image")));
            this.btnCadastrarUsuario.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(44, 228);
            this.btnCadastrarUsuario.MaximumSize = new System.Drawing.Size(196, 62);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(196, 62);
            this.btnCadastrarUsuario.TabIndex = 21;
            this.btnCadastrarUsuario.Text = "Inserir usuário";
            // 
            // frUsuarioFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 342);
            this.Controls.Add(this.btnSairUsuario);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.cbFuncionariosAutorizados);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblFuncionariosAutorizados);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.Name = "frUsuarioFormulario";
            this.Text = "Cadastro de usuários";
            this.Load += new System.EventHandler(this.frUsuarioFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFuncionariosAutorizados;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LabelControl lblLogin;
        private DevExpress.XtraEditors.LabelControl lblFuncionariosAutorizados;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.SimpleButton btnSairUsuario;
        private DevExpress.XtraEditors.SimpleButton btnCadastrarUsuario;
    }
}