namespace nano9.consultar_funcionarios
{
    partial class consultaFuncionario
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
            this.consultaCpfFuncionario = new System.Windows.Forms.Label();
            this.maskedTextBoxConsultaCpf = new System.Windows.Forms.MaskedTextBox();
            this.consultarCpf = new System.Windows.Forms.Button();
            this.dataGridConsultaCpf = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaCpf)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaCpfFuncionario
            // 
            this.consultaCpfFuncionario.AutoSize = true;
            this.consultaCpfFuncionario.Location = new System.Drawing.Point(59, 47);
            this.consultaCpfFuncionario.Name = "consultaCpfFuncionario";
            this.consultaCpfFuncionario.Size = new System.Drawing.Size(235, 25);
            this.consultaCpfFuncionario.TabIndex = 0;
            this.consultaCpfFuncionario.Text = "Digite o cpf do funcionario";
            this.consultaCpfFuncionario.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBoxConsultaCpf
            // 
            this.maskedTextBoxConsultaCpf.Location = new System.Drawing.Point(302, 47);
            this.maskedTextBoxConsultaCpf.Mask = "000.000.000-00";
            this.maskedTextBoxConsultaCpf.Name = "maskedTextBoxConsultaCpf";
            this.maskedTextBoxConsultaCpf.Size = new System.Drawing.Size(163, 29);
            this.maskedTextBoxConsultaCpf.TabIndex = 1;
            this.maskedTextBoxConsultaCpf.ValidatingType = typeof(int);
            // 
            // consultarCpf
            // 
            this.consultarCpf.Location = new System.Drawing.Point(64, 150);
            this.consultarCpf.Name = "consultarCpf";
            this.consultarCpf.Size = new System.Drawing.Size(202, 62);
            this.consultarCpf.TabIndex = 2;
            this.consultarCpf.Text = "Consultar";
            this.consultarCpf.UseVisualStyleBackColor = true;
            this.consultarCpf.Click += new System.EventHandler(this.consultarCpf_Click);
            // 
            // dataGridConsultaCpf
            // 
            this.dataGridConsultaCpf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaCpf.Location = new System.Drawing.Point(64, 287);
            this.dataGridConsultaCpf.Name = "dataGridConsultaCpf";
            this.dataGridConsultaCpf.RowHeadersWidth = 72;
            this.dataGridConsultaCpf.RowTemplate.Height = 31;
            this.dataGridConsultaCpf.Size = new System.Drawing.Size(1003, 142);
            this.dataGridConsultaCpf.TabIndex = 3;
            // 
            // consultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 660);
            this.Controls.Add(this.dataGridConsultaCpf);
            this.Controls.Add(this.consultarCpf);
            this.Controls.Add(this.maskedTextBoxConsultaCpf);
            this.Controls.Add(this.consultaCpfFuncionario);
            this.Name = "consultaFuncionario";
            this.Text = "consultaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaCpf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consultaCpfFuncionario;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxConsultaCpf;
        private System.Windows.Forms.Button consultarCpf;
        private System.Windows.Forms.DataGridView dataGridConsultaCpf;
    }
}