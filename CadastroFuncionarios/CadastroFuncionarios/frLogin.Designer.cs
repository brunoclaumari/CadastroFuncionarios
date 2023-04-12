
namespace CadastroFuncionarios
{
    partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            this.btnSairUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogarNoSIstema = new DevExpress.XtraEditors.SimpleButton();
            this.lblSenha = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSairUsuario
            // 
            this.btnSairUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairUsuario.Appearance.Options.UseFont = true;
            this.btnSairUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSairUsuario.ImageOptions.Image")));
            this.btnSairUsuario.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSairUsuario.Location = new System.Drawing.Point(266, 199);
            this.btnSairUsuario.MaximumSize = new System.Drawing.Size(196, 62);
            this.btnSairUsuario.Name = "btnSairUsuario";
            this.btnSairUsuario.Size = new System.Drawing.Size(196, 62);
            this.btnSairUsuario.TabIndex = 28;
            this.btnSairUsuario.Text = "Sair";
            // 
            // btnLogarNoSIstema
            // 
            this.btnLogarNoSIstema.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogarNoSIstema.Appearance.Options.UseFont = true;
            this.btnLogarNoSIstema.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUsuario.ImageOptions.Image")));
            this.btnLogarNoSIstema.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogarNoSIstema.Location = new System.Drawing.Point(24, 199);
            this.btnLogarNoSIstema.MaximumSize = new System.Drawing.Size(196, 62);
            this.btnLogarNoSIstema.Name = "btnLogarNoSIstema";
            this.btnLogarNoSIstema.Size = new System.Drawing.Size(196, 62);
            this.btnLogarNoSIstema.TabIndex = 27;
            this.btnLogarNoSIstema.Text = "Entrar";
            // 
            // lblSenha
            // 
            this.lblSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Appearance.Options.UseFont = true;
            this.lblSenha.Location = new System.Drawing.Point(28, 72);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 18);
            this.lblSenha.TabIndex = 26;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(28, 96);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.MaxLength = 10;
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(264, 24);
            this.txtSenha.TabIndex = 25;
            this.txtSenha.ToolTip = "Digite de 6 a 10 caracteres";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(28, 39);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Size = new System.Drawing.Size(372, 24);
            this.txtLogin.TabIndex = 23;
            // 
            // lblLogin
            // 
            this.lblLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Appearance.Options.UseFont = true;
            this.lblLogin.Location = new System.Drawing.Point(28, 15);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(192, 18);
            this.lblLogin.TabIndex = 24;
            this.lblLogin.Text = "Login (nic name ou email)";
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 288);
            this.Controls.Add(this.btnSairUsuario);
            this.Controls.Add(this.btnLogarNoSIstema);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Name = "frLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSairUsuario;
        private DevExpress.XtraEditors.SimpleButton btnLogarNoSIstema;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LabelControl lblLogin;
    }
}

