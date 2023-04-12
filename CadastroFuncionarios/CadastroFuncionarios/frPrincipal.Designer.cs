
namespace CadastroFuncionarios
{
    partial class frPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
            this.btnCrudFuncionarios = new DevExpress.XtraEditors.SimpleButton();
            this.btnCrudUsuarios = new DevExpress.XtraEditors.SimpleButton();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrudFuncionarios
            // 
            this.btnCrudFuncionarios.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrudFuncionarios.Appearance.Options.UseFont = true;
            this.btnCrudFuncionarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCrudFuncionarios.ImageOptions.Image")));
            this.btnCrudFuncionarios.Location = new System.Drawing.Point(113, 113);
            this.btnCrudFuncionarios.MaximumSize = new System.Drawing.Size(225, 120);
            this.btnCrudFuncionarios.Name = "btnCrudFuncionarios";
            this.btnCrudFuncionarios.Size = new System.Drawing.Size(225, 120);
            this.btnCrudFuncionarios.TabIndex = 0;
            this.btnCrudFuncionarios.Text = "Funcionários";
            this.btnCrudFuncionarios.Click += new System.EventHandler(this.btnCrudFuncionarios_Click);
            // 
            // btnCrudUsuarios
            // 
            this.btnCrudUsuarios.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrudUsuarios.Appearance.Options.UseFont = true;
            this.btnCrudUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCrudUsuarios.ImageOptions.Image")));
            this.btnCrudUsuarios.Location = new System.Drawing.Point(387, 113);
            this.btnCrudUsuarios.MaximumSize = new System.Drawing.Size(225, 120);
            this.btnCrudUsuarios.Name = "btnCrudUsuarios";
            this.btnCrudUsuarios.Size = new System.Drawing.Size(225, 120);
            this.btnCrudUsuarios.TabIndex = 1;
            this.btnCrudUsuarios.Text = "Usuários";
            this.btnCrudUsuarios.Click += new System.EventHandler(this.btnCrudUsuarios_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(47, 21);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(66, 18);
            this.lblUsuarioLogado.TabIndex = 2;
            this.lblUsuarioLogado.Text = "Usuário";
            this.lblUsuarioLogado.Visible = false;
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 417);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.btnCrudUsuarios);
            this.Controls.Add(this.btnCrudFuncionarios);
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BR Tech Cadastros";
            this.Load += new System.EventHandler(this.frPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCrudFuncionarios;
        private DevExpress.XtraEditors.SimpleButton btnCrudUsuarios;
        private System.Windows.Forms.Label lblUsuarioLogado;
    }
}