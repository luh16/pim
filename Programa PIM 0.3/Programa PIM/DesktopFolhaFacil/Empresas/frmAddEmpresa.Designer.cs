namespace PrototipoRH.Empresas
{
    partial class frmAddEmpresa
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblEnderecp = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCadstrarEmpresa = new System.Windows.Forms.Button();
            this.btnLimparEmpresa = new System.Windows.Forms.Button();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(59, 49);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(558, 49);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 1;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblEnderecp
            // 
            this.lblEnderecp.AutoSize = true;
            this.lblEnderecp.Location = new System.Drawing.Point(53, 192);
            this.lblEnderecp.Name = "lblEnderecp";
            this.lblEnderecp.Size = new System.Drawing.Size(53, 13);
            this.lblEnderecp.TabIndex = 2;
            this.lblEnderecp.Text = "Endereço";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(54, 121);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(256, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(112, 189);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(600, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(109, 118);
            this.msktxtTelefone.Mask = "(00) 00000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.msktxtTelefone.TabIndex = 4;
            this.msktxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(415, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // btnCadstrarEmpresa
            // 
            this.btnCadstrarEmpresa.Location = new System.Drawing.Point(146, 297);
            this.btnCadstrarEmpresa.Name = "btnCadstrarEmpresa";
            this.btnCadstrarEmpresa.Size = new System.Drawing.Size(145, 54);
            this.btnCadstrarEmpresa.TabIndex = 6;
            this.btnCadstrarEmpresa.Text = "Cadastrar";
            this.btnCadstrarEmpresa.UseVisualStyleBackColor = true;
            this.btnCadstrarEmpresa.Click += new System.EventHandler(this.btnCadstrarEmpresa_Click);
            // 
            // btnLimparEmpresa
            // 
            this.btnLimparEmpresa.Location = new System.Drawing.Point(400, 297);
            this.btnLimparEmpresa.Name = "btnLimparEmpresa";
            this.btnLimparEmpresa.Size = new System.Drawing.Size(145, 54);
            this.btnLimparEmpresa.TabIndex = 7;
            this.btnLimparEmpresa.Text = "Limpar Campos";
            this.btnLimparEmpresa.UseVisualStyleBackColor = true;
            this.btnLimparEmpresa.Click += new System.EventHandler(this.btnLimparEmpresa_Click);
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(595, 46);
            this.mskCnpj.Margin = new System.Windows.Forms.Padding(2);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(118, 20);
            this.mskCnpj.TabIndex = 2;
            this.mskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(109, 46);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(407, 20);
            this.txtEmpresa.TabIndex = 9;
            // 
            // frmAddEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.mskCnpj);
            this.Controls.Add(this.btnLimparEmpresa);
            this.Controls.Add(this.btnCadstrarEmpresa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.msktxtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEnderecp);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblEnderecp;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCadstrarEmpresa;
        private System.Windows.Forms.Button btnLimparEmpresa;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.TextBox txtEmpresa;
    }
}