namespace nano9
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnApontamentoHoras = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFolhaPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFuncionario,
            this.consultarFuncionarioToolStripMenuItem,
            this.btnApontamentoHoras,
            this.btnFolhaPagamento,
            this.btnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1294, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnApontamentoHoras
            // 
            this.btnApontamentoHoras.Name = "btnApontamentoHoras";
            this.btnApontamentoHoras.Size = new System.Drawing.Size(248, 36);
            this.btnApontamentoHoras.Text = "Apontamento de Horas";
            this.btnApontamentoHoras.Click += new System.EventHandler(this.btnApontamentoHoras_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(233, 36);
            this.btnFuncionario.Text = "Cadastrar Funcionario";
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnFolhaPagamento
            // 
            this.btnFolhaPagamento.Name = "btnFolhaPagamento";
            this.btnFolhaPagamento.Size = new System.Drawing.Size(224, 36);
            this.btnFolhaPagamento.Text = "Folha De Pagamento";
            this.btnFolhaPagamento.Click += new System.EventHandler(this.btnFolhaPagamento_Click);
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(65, 36);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // consultarFuncionarioToolStripMenuItem
            // 
            this.consultarFuncionarioToolStripMenuItem.Name = "consultarFuncionarioToolStripMenuItem";
            this.consultarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.consultarFuncionarioToolStripMenuItem.Text = "Consultar funcionario";
            this.consultarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.consultarFuncionarioToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 987);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnApontamentoHoras;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionario;
        private System.Windows.Forms.ToolStripMenuItem btnFolhaPagamento;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionarioToolStripMenuItem;
    }
}