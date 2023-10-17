namespace PrototipoRH.Ferias
{
    partial class frmFerias
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
            this.lblPeriodoFimFerias = new System.Windows.Forms.Label();
            this.lblPeriodoFerias = new System.Windows.Forms.Label();
            this.lblCargoFerias = new System.Windows.Forms.Label();
            this.lblSalarioFerias = new System.Windows.Forms.Label();
            this.lblSalarioHoraFerias = new System.Windows.Forms.Label();
            this.lblCpfFerias = new System.Windows.Forms.Label();
            this.mtxtCpfFerias = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarFerias = new System.Windows.Forms.Button();
            this.btnCalcularFerias = new System.Windows.Forms.Button();
            this.txtCargoFerias = new System.Windows.Forms.TextBox();
            this.mtxtPeriodoFerias = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPeriodoFimFerias = new System.Windows.Forms.MaskedTextBox();
            this.txtSalarioBrutoFerias = new System.Windows.Forms.TextBox();
            this.txtSalarioHoraFerias = new System.Windows.Forms.TextBox();
            this.lblFuncionarioFerias = new System.Windows.Forms.Label();
            this.lblCnpjFerias = new System.Windows.Forms.Label();
            this.cbNomeFunFerias = new System.Windows.Forms.ComboBox();
            this.lblEmpresaFerias = new System.Windows.Forms.Label();
            this.txtCnpjFerias = new System.Windows.Forms.TextBox();
            this.cbEmpresaFerias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPeriodoFimFerias
            // 
            this.lblPeriodoFimFerias.AutoSize = true;
            this.lblPeriodoFimFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblPeriodoFimFerias.Location = new System.Drawing.Point(349, 325);
            this.lblPeriodoFimFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodoFimFerias.Name = "lblPeriodoFimFerias";
            this.lblPeriodoFimFerias.Size = new System.Drawing.Size(27, 16);
            this.lblPeriodoFimFerias.TabIndex = 41;
            this.lblPeriodoFimFerias.Text = "Até";
            // 
            // lblPeriodoFerias
            // 
            this.lblPeriodoFerias.AutoSize = true;
            this.lblPeriodoFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblPeriodoFerias.Location = new System.Drawing.Point(84, 321);
            this.lblPeriodoFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodoFerias.Name = "lblPeriodoFerias";
            this.lblPeriodoFerias.Size = new System.Drawing.Size(82, 16);
            this.lblPeriodoFerias.TabIndex = 40;
            this.lblPeriodoFerias.Text = "Periodo (de)";
            // 
            // lblCargoFerias
            // 
            this.lblCargoFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargoFerias.AutoSize = true;
            this.lblCargoFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblCargoFerias.Location = new System.Drawing.Point(816, 236);
            this.lblCargoFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargoFerias.Name = "lblCargoFerias";
            this.lblCargoFerias.Size = new System.Drawing.Size(44, 16);
            this.lblCargoFerias.TabIndex = 39;
            this.lblCargoFerias.Text = "Cargo";
            // 
            // lblSalarioFerias
            // 
            this.lblSalarioFerias.AutoSize = true;
            this.lblSalarioFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblSalarioFerias.Location = new System.Drawing.Point(499, 236);
            this.lblSalarioFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioFerias.Name = "lblSalarioFerias";
            this.lblSalarioFerias.Size = new System.Drawing.Size(50, 16);
            this.lblSalarioFerias.TabIndex = 38;
            this.lblSalarioFerias.Text = "Salario";
            // 
            // lblSalarioHoraFerias
            // 
            this.lblSalarioHoraFerias.AutoSize = true;
            this.lblSalarioHoraFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblSalarioHoraFerias.Location = new System.Drawing.Point(65, 236);
            this.lblSalarioHoraFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioHoraFerias.Name = "lblSalarioHoraFerias";
            this.lblSalarioHoraFerias.Size = new System.Drawing.Size(99, 16);
            this.lblSalarioHoraFerias.TabIndex = 37;
            this.lblSalarioHoraFerias.Text = "Salario (a hora)";
            // 
            // lblCpfFerias
            // 
            this.lblCpfFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpfFerias.AutoSize = true;
            this.lblCpfFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblCpfFerias.Location = new System.Drawing.Point(911, 162);
            this.lblCpfFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfFerias.Name = "lblCpfFerias";
            this.lblCpfFerias.Size = new System.Drawing.Size(33, 16);
            this.lblCpfFerias.TabIndex = 36;
            this.lblCpfFerias.Text = "CPF";
            // 
            // mtxtCpfFerias
            // 
            this.mtxtCpfFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtCpfFerias.Location = new System.Drawing.Point(955, 159);
            this.mtxtCpfFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtCpfFerias.Mask = "000-000-000-00";
            this.mtxtCpfFerias.Name = "mtxtCpfFerias";
            this.mtxtCpfFerias.Size = new System.Drawing.Size(147, 22);
            this.mtxtCpfFerias.TabIndex = 4;
            // 
            // btnCancelarFerias
            // 
            this.btnCancelarFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnCancelarFerias.FlatAppearance.BorderSize = 0;
            this.btnCancelarFerias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(91)))));
            this.btnCancelarFerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFerias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarFerias.Location = new System.Drawing.Point(611, 420);
            this.btnCancelarFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarFerias.Name = "btnCancelarFerias";
            this.btnCancelarFerias.Size = new System.Drawing.Size(193, 66);
            this.btnCancelarFerias.TabIndex = 11;
            this.btnCancelarFerias.Text = "Cancelar";
            this.btnCancelarFerias.UseVisualStyleBackColor = false;
            // 
            // btnCalcularFerias
            // 
            this.btnCalcularFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalcularFerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnCalcularFerias.FlatAppearance.BorderSize = 0;
            this.btnCalcularFerias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(91)))));
            this.btnCalcularFerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularFerias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcularFerias.Location = new System.Drawing.Point(337, 420);
            this.btnCalcularFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularFerias.Name = "btnCalcularFerias";
            this.btnCalcularFerias.Size = new System.Drawing.Size(193, 66);
            this.btnCalcularFerias.TabIndex = 10;
            this.btnCalcularFerias.Text = "Calcular Ferias";
            this.btnCalcularFerias.UseVisualStyleBackColor = false;
            // 
            // txtCargoFerias
            // 
            this.txtCargoFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargoFerias.Location = new System.Drawing.Point(871, 233);
            this.txtCargoFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCargoFerias.Name = "txtCargoFerias";
            this.txtCargoFerias.Size = new System.Drawing.Size(132, 22);
            this.txtCargoFerias.TabIndex = 7;
            // 
            // mtxtPeriodoFerias
            // 
            this.mtxtPeriodoFerias.Location = new System.Drawing.Point(177, 318);
            this.mtxtPeriodoFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtPeriodoFerias.Mask = "00/00/0000";
            this.mtxtPeriodoFerias.Name = "mtxtPeriodoFerias";
            this.mtxtPeriodoFerias.Size = new System.Drawing.Size(128, 22);
            this.mtxtPeriodoFerias.TabIndex = 8;
            this.mtxtPeriodoFerias.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtPeriodoFimFerias
            // 
            this.mtxtPeriodoFimFerias.Location = new System.Drawing.Point(401, 321);
            this.mtxtPeriodoFimFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtPeriodoFimFerias.Mask = "00/00/0000";
            this.mtxtPeriodoFimFerias.Name = "mtxtPeriodoFimFerias";
            this.mtxtPeriodoFimFerias.Size = new System.Drawing.Size(128, 22);
            this.mtxtPeriodoFimFerias.TabIndex = 9;
            this.mtxtPeriodoFimFerias.ValidatingType = typeof(System.DateTime);
            // 
            // txtSalarioBrutoFerias
            // 
            this.txtSalarioBrutoFerias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalarioBrutoFerias.Location = new System.Drawing.Point(564, 233);
            this.txtSalarioBrutoFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioBrutoFerias.Name = "txtSalarioBrutoFerias";
            this.txtSalarioBrutoFerias.Size = new System.Drawing.Size(211, 22);
            this.txtSalarioBrutoFerias.TabIndex = 6;
            // 
            // txtSalarioHoraFerias
            // 
            this.txtSalarioHoraFerias.Location = new System.Drawing.Point(177, 233);
            this.txtSalarioHoraFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioHoraFerias.MaxLength = 10000;
            this.txtSalarioHoraFerias.Name = "txtSalarioHoraFerias";
            this.txtSalarioHoraFerias.Size = new System.Drawing.Size(283, 22);
            this.txtSalarioHoraFerias.TabIndex = 5;
            // 
            // lblFuncionarioFerias
            // 
            this.lblFuncionarioFerias.AutoSize = true;
            this.lblFuncionarioFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblFuncionarioFerias.Location = new System.Drawing.Point(25, 162);
            this.lblFuncionarioFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncionarioFerias.Name = "lblFuncionarioFerias";
            this.lblFuncionarioFerias.Size = new System.Drawing.Size(136, 16);
            this.lblFuncionarioFerias.TabIndex = 27;
            this.lblFuncionarioFerias.Text = "Nome do Funcionario";
            // 
            // lblCnpjFerias
            // 
            this.lblCnpjFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCnpjFerias.AutoSize = true;
            this.lblCnpjFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblCnpjFerias.Location = new System.Drawing.Point(647, 86);
            this.lblCnpjFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnpjFerias.Name = "lblCnpjFerias";
            this.lblCnpjFerias.Size = new System.Drawing.Size(42, 16);
            this.lblCnpjFerias.TabIndex = 26;
            this.lblCnpjFerias.Text = "CNPJ";
            // 
            // cbNomeFunFerias
            // 
            this.cbNomeFunFerias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNomeFunFerias.FormattingEnabled = true;
            this.cbNomeFunFerias.Location = new System.Drawing.Point(177, 159);
            this.cbNomeFunFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNomeFunFerias.MaxLength = 100;
            this.cbNomeFunFerias.Name = "cbNomeFunFerias";
            this.cbNomeFunFerias.Size = new System.Drawing.Size(703, 24);
            this.cbNomeFunFerias.TabIndex = 3;
            // 
            // lblEmpresaFerias
            // 
            this.lblEmpresaFerias.AutoSize = true;
            this.lblEmpresaFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblEmpresaFerias.Location = new System.Drawing.Point(95, 86);
            this.lblEmpresaFerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresaFerias.Name = "lblEmpresaFerias";
            this.lblEmpresaFerias.Size = new System.Drawing.Size(62, 16);
            this.lblEmpresaFerias.TabIndex = 24;
            this.lblEmpresaFerias.Text = "Empresa";
            // 
            // txtCnpjFerias
            // 
            this.txtCnpjFerias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCnpjFerias.Location = new System.Drawing.Point(700, 82);
            this.txtCnpjFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCnpjFerias.MaxLength = 14;
            this.txtCnpjFerias.Name = "txtCnpjFerias";
            this.txtCnpjFerias.Size = new System.Drawing.Size(424, 22);
            this.txtCnpjFerias.TabIndex = 2;
            // 
            // cbEmpresaFerias
            // 
            this.cbEmpresaFerias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmpresaFerias.FormattingEnabled = true;
            this.cbEmpresaFerias.Location = new System.Drawing.Point(177, 82);
            this.cbEmpresaFerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmpresaFerias.MaxLength = 45;
            this.cbEmpresaFerias.Name = "cbEmpresaFerias";
            this.cbEmpresaFerias.Size = new System.Drawing.Size(445, 24);
            this.cbEmpresaFerias.TabIndex = 1;
            // 
            // frmFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 571);
            this.Controls.Add(this.lblPeriodoFimFerias);
            this.Controls.Add(this.lblPeriodoFerias);
            this.Controls.Add(this.lblCargoFerias);
            this.Controls.Add(this.lblSalarioFerias);
            this.Controls.Add(this.lblSalarioHoraFerias);
            this.Controls.Add(this.lblCpfFerias);
            this.Controls.Add(this.mtxtCpfFerias);
            this.Controls.Add(this.btnCancelarFerias);
            this.Controls.Add(this.btnCalcularFerias);
            this.Controls.Add(this.txtCargoFerias);
            this.Controls.Add(this.mtxtPeriodoFerias);
            this.Controls.Add(this.mtxtPeriodoFimFerias);
            this.Controls.Add(this.txtSalarioBrutoFerias);
            this.Controls.Add(this.txtSalarioHoraFerias);
            this.Controls.Add(this.lblFuncionarioFerias);
            this.Controls.Add(this.lblCnpjFerias);
            this.Controls.Add(this.cbNomeFunFerias);
            this.Controls.Add(this.lblEmpresaFerias);
            this.Controls.Add(this.txtCnpjFerias);
            this.Controls.Add(this.cbEmpresaFerias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFerias";
            this.Text = "RECIBO DE FERIAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeriodoFimFerias;
        private System.Windows.Forms.Label lblPeriodoFerias;
        private System.Windows.Forms.Label lblCargoFerias;
        private System.Windows.Forms.Label lblSalarioFerias;
        private System.Windows.Forms.Label lblSalarioHoraFerias;
        private System.Windows.Forms.Label lblCpfFerias;
        private System.Windows.Forms.MaskedTextBox mtxtCpfFerias;
        private System.Windows.Forms.Button btnCancelarFerias;
        private System.Windows.Forms.Button btnCalcularFerias;
        private System.Windows.Forms.TextBox txtCargoFerias;
        private System.Windows.Forms.MaskedTextBox mtxtPeriodoFerias;
        private System.Windows.Forms.MaskedTextBox mtxtPeriodoFimFerias;
        private System.Windows.Forms.TextBox txtSalarioBrutoFerias;
        private System.Windows.Forms.TextBox txtSalarioHoraFerias;
        private System.Windows.Forms.Label lblFuncionarioFerias;
        private System.Windows.Forms.Label lblCnpjFerias;
        private System.Windows.Forms.ComboBox cbNomeFunFerias;
        private System.Windows.Forms.Label lblEmpresaFerias;
        private System.Windows.Forms.TextBox txtCnpjFerias;
        private System.Windows.Forms.ComboBox cbEmpresaFerias;
    }
}