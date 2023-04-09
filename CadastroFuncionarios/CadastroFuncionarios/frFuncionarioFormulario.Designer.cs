
namespace CadastroFuncionarios
{
    partial class frFuncionarioFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFuncionarioFormulario));
            this.txtNomeFuncionario = new DevExpress.XtraEditors.TextEdit();
            this.lblNome = new DevExpress.XtraEditors.LabelControl();
            this.lblCpf = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeAdmissaoFuncionario = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.lblDataAdmissao = new DevExpress.XtraEditors.LabelControl();
            this.lblSalario = new DevExpress.XtraEditors.LabelControl();
            this.lblNivelCargo = new DevExpress.XtraEditors.LabelControl();
            this.lblSetor = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblCargo = new DevExpress.XtraEditors.LabelControl();
            this.txtCpfFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtCargoFuncionario = new DevExpress.XtraEditors.TextEdit();
            this.cbNivelCargoFuncionario = new System.Windows.Forms.ComboBox();
            this.cbSetorFuncionario = new System.Windows.Forms.ComboBox();
            this.txtLoginUsuarioFuncionario = new DevExpress.XtraEditors.TextEdit();
            this.txtSalarioFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastraUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.btnCadastrarFuncionario = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeAdmissaoFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginUsuarioFuncionario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(42, 37);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Properties.Appearance.Options.UseFont = true;
            this.txtNomeFuncionario.Size = new System.Drawing.Size(511, 24);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Appearance.Options.UseFont = true;
            this.lblNome.Location = new System.Drawing.Point(42, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Appearance.Options.UseFont = true;
            this.lblCpf.Location = new System.Drawing.Point(42, 68);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(29, 18);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // dateTimeAdmissaoFuncionario
            // 
            this.dateTimeAdmissaoFuncionario.EditValue = null;
            this.dateTimeAdmissaoFuncionario.Location = new System.Drawing.Point(42, 437);
            this.dateTimeAdmissaoFuncionario.Name = "dateTimeAdmissaoFuncionario";
            this.dateTimeAdmissaoFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAdmissaoFuncionario.Properties.Appearance.Options.UseFont = true;
            this.dateTimeAdmissaoFuncionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeAdmissaoFuncionario.Size = new System.Drawing.Size(312, 24);
            this.dateTimeAdmissaoFuncionario.TabIndex = 4;
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAdmissao.Appearance.Options.UseFont = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(42, 412);
            this.lblDataAdmissao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(131, 18);
            this.lblDataAdmissao.TabIndex = 5;
            this.lblDataAdmissao.Text = "Data de admissão";
            // 
            // lblSalario
            // 
            this.lblSalario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Appearance.Options.UseFont = true;
            this.lblSalario.Location = new System.Drawing.Point(42, 354);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(93, 18);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário (R$)";
            // 
            // lblNivelCargo
            // 
            this.lblNivelCargo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelCargo.Appearance.Options.UseFont = true;
            this.lblNivelCargo.Location = new System.Drawing.Point(42, 182);
            this.lblNivelCargo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblNivelCargo.Name = "lblNivelCargo";
            this.lblNivelCargo.Size = new System.Drawing.Size(108, 18);
            this.lblNivelCargo.TabIndex = 7;
            this.lblNivelCargo.Text = "Nível do cargo";
            // 
            // lblSetor
            // 
            this.lblSetor.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Appearance.Options.UseFont = true;
            this.lblSetor.Location = new System.Drawing.Point(42, 240);
            this.lblSetor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(41, 18);
            this.lblSetor.TabIndex = 8;
            this.lblSetor.Text = "Setor";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.Options.UseFont = true;
            this.lblUsuario.Location = new System.Drawing.Point(42, 298);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 18);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblCargo
            // 
            this.lblCargo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Appearance.Options.UseFont = true;
            this.lblCargo.Location = new System.Drawing.Point(42, 126);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 18);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCpfFuncionario
            // 
            this.txtCpfFuncionario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfFuncionario.Location = new System.Drawing.Point(42, 93);
            this.txtCpfFuncionario.Mask = "999.999.999-99";
            this.txtCpfFuncionario.Name = "txtCpfFuncionario";
            this.txtCpfFuncionario.Size = new System.Drawing.Size(142, 26);
            this.txtCpfFuncionario.TabIndex = 11;
            // 
            // txtCargoFuncionario
            // 
            this.txtCargoFuncionario.Location = new System.Drawing.Point(42, 151);
            this.txtCargoFuncionario.Name = "txtCargoFuncionario";
            this.txtCargoFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoFuncionario.Properties.Appearance.Options.UseFont = true;
            this.txtCargoFuncionario.Size = new System.Drawing.Size(512, 24);
            this.txtCargoFuncionario.TabIndex = 12;
            // 
            // cbNivelCargoFuncionario
            // 
            this.cbNivelCargoFuncionario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelCargoFuncionario.FormattingEnabled = true;
            this.cbNivelCargoFuncionario.Location = new System.Drawing.Point(42, 207);
            this.cbNivelCargoFuncionario.Name = "cbNivelCargoFuncionario";
            this.cbNivelCargoFuncionario.Size = new System.Drawing.Size(238, 26);
            this.cbNivelCargoFuncionario.TabIndex = 13;
            // 
            // cbSetorFuncionario
            // 
            this.cbSetorFuncionario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetorFuncionario.FormattingEnabled = true;
            this.cbSetorFuncionario.Location = new System.Drawing.Point(42, 265);
            this.cbSetorFuncionario.Name = "cbSetorFuncionario";
            this.cbSetorFuncionario.Size = new System.Drawing.Size(238, 26);
            this.cbSetorFuncionario.TabIndex = 14;
            // 
            // txtLoginUsuarioFuncionario
            // 
            this.txtLoginUsuarioFuncionario.Location = new System.Drawing.Point(42, 323);
            this.txtLoginUsuarioFuncionario.Name = "txtLoginUsuarioFuncionario";
            this.txtLoginUsuarioFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuarioFuncionario.Properties.Appearance.Options.UseFont = true;
            this.txtLoginUsuarioFuncionario.Size = new System.Drawing.Size(238, 24);
            this.txtLoginUsuarioFuncionario.TabIndex = 15;
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(42, 379);
            this.txtSalarioFuncionario.Mask = "*.99";
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(223, 26);
            this.txtSalarioFuncionario.TabIndex = 16;
            // 
            // btnCadastraUsuario
            // 
            this.btnCadastraUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraUsuario.Appearance.Options.UseFont = true;
            this.btnCadastraUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCadastraUsuario.Location = new System.Drawing.Point(307, 319);
            this.btnCadastraUsuario.Name = "btnCadastraUsuario";
            this.btnCadastraUsuario.Size = new System.Drawing.Size(219, 33);
            this.btnCadastraUsuario.TabIndex = 17;
            this.btnCadastraUsuario.Text = "Cadastrar login de usuário";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Appearance.Options.UseFont = true;
            this.btnCadastrarFuncionario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarFuncionario.ImageOptions.Image")));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(289, 481);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(205, 58);
            this.btnCadastrarFuncionario.TabIndex = 18;
            this.btnCadastrarFuncionario.Text = "Inserir Funcionário";
            // 
            // frFuncionarioFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 568);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.btnCadastraUsuario);
            this.Controls.Add(this.txtSalarioFuncionario);
            this.Controls.Add(this.txtLoginUsuarioFuncionario);
            this.Controls.Add(this.cbSetorFuncionario);
            this.Controls.Add(this.cbNivelCargoFuncionario);
            this.Controls.Add(this.txtCargoFuncionario);
            this.Controls.Add(this.txtCpfFuncionario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblNivelCargo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.dateTimeAdmissaoFuncionario);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeFuncionario);
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.Name = "frFuncionarioFormulario";
            this.Text = "Adicionar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeAdmissaoFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginUsuarioFuncionario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNomeFuncionario;
        private DevExpress.XtraEditors.LabelControl lblNome;
        private DevExpress.XtraEditors.LabelControl lblCpf;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeAdmissaoFuncionario;
        private DevExpress.XtraEditors.LabelControl lblDataAdmissao;
        private DevExpress.XtraEditors.LabelControl lblSalario;
        private DevExpress.XtraEditors.LabelControl lblNivelCargo;
        private DevExpress.XtraEditors.LabelControl lblSetor;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.LabelControl lblCargo;
        private System.Windows.Forms.MaskedTextBox txtCpfFuncionario;
        private DevExpress.XtraEditors.TextEdit txtCargoFuncionario;
        private System.Windows.Forms.ComboBox cbNivelCargoFuncionario;
        private System.Windows.Forms.ComboBox cbSetorFuncionario;
        private DevExpress.XtraEditors.TextEdit txtLoginUsuarioFuncionario;
        private System.Windows.Forms.MaskedTextBox txtSalarioFuncionario;
        private DevExpress.XtraEditors.SimpleButton btnCadastraUsuario;
        private DevExpress.XtraEditors.SimpleButton btnCadastrarFuncionario;
    }
}