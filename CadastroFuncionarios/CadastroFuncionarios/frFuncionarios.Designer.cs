
namespace CadastroFuncionarios
{
    partial class frFuncionarios
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnNovoFuncionario = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlFuncionarios = new DevExpress.XtraGrid.GridControl();
            this.gridViewFuncionario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuncionario)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFuncionario.Appearance.Options.UseFont = true;
            this.btnNovoFuncionario.Location = new System.Drawing.Point(3, 3);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(160, 79);
            this.btnNovoFuncionario.TabIndex = 0;
            this.btnNovoFuncionario.Text = "Novo funcionário";
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // gridControlFuncionarios
            // 
            this.gridControlFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlFuncionarios.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlFuncionarios.Location = new System.Drawing.Point(3, 88);
            this.gridControlFuncionarios.MainView = this.gridViewFuncionario;
            this.gridControlFuncionarios.Name = "gridControlFuncionarios";
            this.gridControlFuncionarios.Size = new System.Drawing.Size(849, 391);
            this.gridControlFuncionarios.TabIndex = 1;
            this.gridControlFuncionarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFuncionario});
            // 
            // gridViewFuncionario
            // 
            this.gridViewFuncionario.GridControl = this.gridControlFuncionarios;
            this.gridViewFuncionario.Name = "gridViewFuncionario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNovoFuncionario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlFuncionarios, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.84232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.15768F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 482);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // frFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frFuncionarios";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuncionario)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNovoFuncionario;
        private DevExpress.XtraGrid.GridControl gridControlFuncionarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFuncionario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

