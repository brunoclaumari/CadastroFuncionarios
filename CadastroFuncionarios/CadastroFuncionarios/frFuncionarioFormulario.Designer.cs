
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFuncionarioFormulario));
            this.txtNomeFuncionario = new DevExpress.XtraEditors.TextEdit();
            this.lblNome = new DevExpress.XtraEditors.LabelControl();
            this.lblCpf = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeAdmissaoFuncionario = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.lblDataAdmissao = new DevExpress.XtraEditors.LabelControl();
            this.lblSalario = new DevExpress.XtraEditors.LabelControl();
            this.lblNivelCargo = new DevExpress.XtraEditors.LabelControl();
            this.lblSetor = new DevExpress.XtraEditors.LabelControl();
            this.lblCargo = new DevExpress.XtraEditors.LabelControl();
            this.txtCargoFuncionario = new DevExpress.XtraEditors.TextEdit();
            this.cbNivelCargoFuncionario = new System.Windows.Forms.ComboBox();
            this.cbSetorFuncionario = new System.Windows.Forms.ComboBox();
            this.btnCadastrarFuncionario = new DevExpress.XtraEditors.SimpleButton();
            this.errorProviderFuncionario = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCpf = new DevExpress.XtraEditors.TextEdit();
            this.txtSalarioFuncionario = new DevExpress.XtraEditors.TextEdit();
            this.btnEditarFuncionario = new DevExpress.XtraEditors.SimpleButton();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeAdmissaoFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioFuncionario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(49, 40);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Properties.Appearance.Options.UseFont = true;
            this.txtNomeFuncionario.Size = new System.Drawing.Size(596, 24);
            this.txtNomeFuncionario.TabIndex = 0;
            this.txtNomeFuncionario.EditValueChanged += new System.EventHandler(this.txtNomeFuncionario_EditValueChanged);
            // 
            // lblNome
            // 
            this.lblNome.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Appearance.Options.UseFont = true;
            this.lblNome.Location = new System.Drawing.Point(49, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Appearance.Options.UseFont = true;
            this.lblCpf.Location = new System.Drawing.Point(49, 73);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(29, 18);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // dateTimeAdmissaoFuncionario
            // 
            this.dateTimeAdmissaoFuncionario.EditValue = null;
            this.dateTimeAdmissaoFuncionario.Location = new System.Drawing.Point(49, 412);
            this.dateTimeAdmissaoFuncionario.Name = "dateTimeAdmissaoFuncionario";
            this.dateTimeAdmissaoFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAdmissaoFuncionario.Properties.Appearance.Options.UseFont = true;
            this.dateTimeAdmissaoFuncionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeAdmissaoFuncionario.Size = new System.Drawing.Size(364, 24);
            this.dateTimeAdmissaoFuncionario.TabIndex = 8;
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAdmissao.Appearance.Options.UseFont = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(49, 386);
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
            this.lblSalario.Location = new System.Drawing.Point(49, 323);
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
            this.lblNivelCargo.Location = new System.Drawing.Point(49, 196);
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
            this.lblSetor.Location = new System.Drawing.Point(49, 258);
            this.lblSetor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(41, 18);
            this.lblSetor.TabIndex = 8;
            this.lblSetor.Text = "Setor";
            // 
            // lblCargo
            // 
            this.lblCargo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Appearance.Options.UseFont = true;
            this.lblCargo.Location = new System.Drawing.Point(49, 136);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 18);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargoFuncionario
            // 
            this.txtCargoFuncionario.Location = new System.Drawing.Point(49, 163);
            this.txtCargoFuncionario.Name = "txtCargoFuncionario";
            this.txtCargoFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoFuncionario.Properties.Appearance.Options.UseFont = true;
            this.txtCargoFuncionario.Size = new System.Drawing.Size(597, 24);
            this.txtCargoFuncionario.TabIndex = 2;
            // 
            // cbNivelCargoFuncionario
            // 
            this.cbNivelCargoFuncionario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelCargoFuncionario.FormattingEnabled = true;
            this.cbNivelCargoFuncionario.Location = new System.Drawing.Point(49, 223);
            this.cbNivelCargoFuncionario.Name = "cbNivelCargoFuncionario";
            this.cbNivelCargoFuncionario.Size = new System.Drawing.Size(277, 26);
            this.cbNivelCargoFuncionario.TabIndex = 3;
            this.cbNivelCargoFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbNivelCargoFuncionario_SelectedIndexChanged);
            // 
            // cbSetorFuncionario
            // 
            this.cbSetorFuncionario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetorFuncionario.FormattingEnabled = true;
            this.cbSetorFuncionario.Location = new System.Drawing.Point(49, 285);
            this.cbSetorFuncionario.Name = "cbSetorFuncionario";
            this.cbSetorFuncionario.Size = new System.Drawing.Size(277, 26);
            this.cbSetorFuncionario.TabIndex = 4;
            this.cbSetorFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbSetorFuncionario_SelectedIndexChanged);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Appearance.Options.UseFont = true;
            this.btnCadastrarFuncionario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarFuncionario.ImageOptions.Image")));
            this.btnCadastrarFuncionario.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(152, 474);
            this.btnCadastrarFuncionario.MaximumSize = new System.Drawing.Size(239, 62);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(239, 62);
            this.btnCadastrarFuncionario.TabIndex = 18;
            this.btnCadastrarFuncionario.Text = "Inserir Funcionário";
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // errorProviderFuncionario
            // 
            this.errorProviderFuncionario.ContainerControl = this;
            // 
            // txtCpf
            // 
            this.errorProviderFuncionario.SetIconAlignment(this.txtCpf, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtCpf.Location = new System.Drawing.Point(48, 98);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Properties.Appearance.Options.UseFont = true;
            this.txtCpf.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtCpf.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d-\\d\\d");
            this.txtCpf.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtCpf.Properties.MaskSettings.Set("placeholder", '_');
            this.txtCpf.Size = new System.Drawing.Size(279, 24);
            this.txtCpf.TabIndex = 1;
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(48, 350);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFuncionario.Properties.Appearance.Options.UseFont = true;
            this.txtSalarioFuncionario.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSalarioFuncionario.Properties.MaskSettings.Set("mask", "c");
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(279, 24);
            this.txtSalarioFuncionario.TabIndex = 7;
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFuncionario.Appearance.Options.UseFont = true;
            this.btnEditarFuncionario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarFuncionario.ImageOptions.Image")));
            this.btnEditarFuncionario.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditarFuncionario.Location = new System.Drawing.Point(152, 474);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(239, 62);
            this.btnEditarFuncionario.TabIndex = 19;
            this.btnEditarFuncionario.Text = "Editar Funcionário";
            this.btnEditarFuncionario.Visible = false;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // btnSair
            // 
            this.btnSair.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Appearance.Options.UseFont = true;
            this.btnSair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.ImageOptions.Image")));
            this.btnSair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSair.Location = new System.Drawing.Point(447, 474);
            this.btnSair.MaximumSize = new System.Drawing.Size(239, 62);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(239, 62);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frFuncionarioFormulario
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 570);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtSalarioFuncionario);
            this.Controls.Add(this.cbSetorFuncionario);
            this.Controls.Add(this.cbNivelCargoFuncionario);
            this.Controls.Add(this.txtCargoFuncionario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblNivelCargo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.dateTimeAdmissaoFuncionario);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.btnEditarFuncionario);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(812, 602);
            this.Name = "frFuncionarioFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Funcionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frFuncionarioFormulario_FormClosing);
            this.Load += new System.EventHandler(this.frFuncionarioFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeAdmissaoFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioFuncionario.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblCargo;
        private DevExpress.XtraEditors.TextEdit txtCargoFuncionario;
        private System.Windows.Forms.ComboBox cbNivelCargoFuncionario;
        private System.Windows.Forms.ComboBox cbSetorFuncionario;
        private DevExpress.XtraEditors.SimpleButton btnCadastrarFuncionario;
        private System.Windows.Forms.ErrorProvider errorProviderFuncionario;
        private DevExpress.XtraEditors.TextEdit txtSalarioFuncionario;
        private DevExpress.XtraEditors.TextEdit txtCpf;
        private DevExpress.XtraEditors.SimpleButton btnEditarFuncionario;
        private DevExpress.XtraEditors.SimpleButton btnSair;
    }
}