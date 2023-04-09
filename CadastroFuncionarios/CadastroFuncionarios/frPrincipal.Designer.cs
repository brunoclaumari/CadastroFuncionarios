
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
            this.SuspendLayout();
            // 
            // btnCrudFuncionarios
            // 
            this.btnCrudFuncionarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCrudFuncionarios.Location = new System.Drawing.Point(27, 27);
            this.btnCrudFuncionarios.Name = "btnCrudFuncionarios";
            this.btnCrudFuncionarios.Size = new System.Drawing.Size(145, 76);
            this.btnCrudFuncionarios.TabIndex = 0;
            this.btnCrudFuncionarios.Text = "Funcionários";
            this.btnCrudFuncionarios.Click += new System.EventHandler(this.btnCrudFuncionarios_Click);
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 417);
            this.Controls.Add(this.btnCrudFuncionarios);
            this.Name = "frPrincipal";
            this.Text = "BR Tech Cadastros";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCrudFuncionarios;
    }
}