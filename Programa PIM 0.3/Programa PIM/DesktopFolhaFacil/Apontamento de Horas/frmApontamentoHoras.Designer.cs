namespace PrototipoRH.Apontamento_de_Horas
{
    partial class frmApontamentoHoras
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
            this.maskedTextBox_DataFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_DataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Remover = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_Incluir = new System.Windows.Forms.Button();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.dataGridView_Consulta = new System.Windows.Forms.DataGridView();
            this.textBox_Funcionario = new System.Windows.Forms.TextBox();
            this.label_Funcionario = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.comboBox_Empresa = new System.Windows.Forms.ComboBox();
            this.radioButton_Nome = new System.Windows.Forms.RadioButton();
            this.radioButton_CPF = new System.Windows.Forms.RadioButton();
            this.radioButton_RG = new System.Windows.Forms.RadioButton();
            this.radioButton_Matrícula = new System.Windows.Forms.RadioButton();
            this.lblFiltroFuncionario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox_DataFim
            // 
            this.maskedTextBox_DataFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox_DataFim.Location = new System.Drawing.Point(589, 418);
            this.maskedTextBox_DataFim.Mask = "00/00/0000";
            this.maskedTextBox_DataFim.Name = "maskedTextBox_DataFim";
            this.maskedTextBox_DataFim.Size = new System.Drawing.Size(72, 20);
            this.maskedTextBox_DataFim.TabIndex = 31;
            this.maskedTextBox_DataFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_DataInicio
            // 
            this.maskedTextBox_DataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox_DataInicio.Location = new System.Drawing.Point(460, 418);
            this.maskedTextBox_DataInicio.Mask = "00/00/0000";
            this.maskedTextBox_DataInicio.Name = "maskedTextBox_DataInicio";
            this.maskedTextBox_DataInicio.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox_DataInicio.TabIndex = 30;
            this.maskedTextBox_DataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblData.Location = new System.Drawing.Point(441, 381);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 25);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "Data:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(557, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(430, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "De:";
            // 
            // button_Remover
            // 
            this.button_Remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.button_Remover.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Remover.FlatAppearance.BorderSize = 0;
            this.button_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remover.ForeColor = System.Drawing.Color.White;
            this.button_Remover.Location = new System.Drawing.Point(296, 394);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(104, 36);
            this.button_Remover.TabIndex = 25;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = false;
            // 
            // button_Editar
            // 
            this.button_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.button_Editar.FlatAppearance.BorderSize = 0;
            this.button_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Editar.ForeColor = System.Drawing.Color.White;
            this.button_Editar.Location = new System.Drawing.Point(176, 394);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(104, 36);
            this.button_Editar.TabIndex = 24;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = false;
            // 
            // button_Incluir
            // 
            this.button_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Incluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.button_Incluir.FlatAppearance.BorderSize = 0;
            this.button_Incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Incluir.ForeColor = System.Drawing.Color.White;
            this.button_Incluir.Location = new System.Drawing.Point(56, 394);
            this.button_Incluir.Name = "button_Incluir";
            this.button_Incluir.Size = new System.Drawing.Size(104, 36);
            this.button_Incluir.TabIndex = 23;
            this.button_Incluir.Text = "Incluir";
            this.button_Incluir.UseVisualStyleBackColor = false;
            // 
            // button_Consultar
            // 
            this.button_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.button_Consultar.FlatAppearance.BorderSize = 0;
            this.button_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Consultar.Location = new System.Drawing.Point(692, 394);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(115, 36);
            this.button_Consultar.TabIndex = 22;
            this.button_Consultar.Text = "Consultar";
            this.button_Consultar.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Consulta
            // 
            this.dataGridView_Consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consulta.Location = new System.Drawing.Point(411, 34);
            this.dataGridView_Consulta.Name = "dataGridView_Consulta";
            this.dataGridView_Consulta.RowHeadersWidth = 51;
            this.dataGridView_Consulta.Size = new System.Drawing.Size(414, 330);
            this.dataGridView_Consulta.TabIndex = 21;
            // 
            // textBox_Funcionario
            // 
            this.textBox_Funcionario.Location = new System.Drawing.Point(31, 140);
            this.textBox_Funcionario.Name = "textBox_Funcionario";
            this.textBox_Funcionario.Size = new System.Drawing.Size(345, 20);
            this.textBox_Funcionario.TabIndex = 20;
            // 
            // label_Funcionario
            // 
            this.label_Funcionario.AutoSize = true;
            this.label_Funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label_Funcionario.Location = new System.Drawing.Point(26, 112);
            this.label_Funcionario.Name = "label_Funcionario";
            this.label_Funcionario.Size = new System.Drawing.Size(114, 25);
            this.label_Funcionario.TabIndex = 19;
            this.label_Funcionario.Text = "Funcionário";
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label_Empresa.Location = new System.Drawing.Point(26, 36);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(90, 25);
            this.label_Empresa.TabIndex = 18;
            this.label_Empresa.Text = "Empresa";
            this.label_Empresa.Click += new System.EventHandler(this.label_Empresa_Click);
            // 
            // comboBox_Empresa
            // 
            this.comboBox_Empresa.FormattingEnabled = true;
            this.comboBox_Empresa.Location = new System.Drawing.Point(31, 64);
            this.comboBox_Empresa.Name = "comboBox_Empresa";
            this.comboBox_Empresa.Size = new System.Drawing.Size(345, 21);
            this.comboBox_Empresa.TabIndex = 17;
            this.comboBox_Empresa.SelectedIndexChanged += new System.EventHandler(this.comboBox_Empresa_SelectedIndexChanged);
            // 
            // radioButton_Nome
            // 
            this.radioButton_Nome.AutoSize = true;
            this.radioButton_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_Nome.Location = new System.Drawing.Point(41, 229);
            this.radioButton_Nome.Name = "radioButton_Nome";
            this.radioButton_Nome.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Nome.TabIndex = 0;
            this.radioButton_Nome.TabStop = true;
            this.radioButton_Nome.Text = "Nome";
            this.radioButton_Nome.UseVisualStyleBackColor = true;
            // 
            // radioButton_CPF
            // 
            this.radioButton_CPF.AutoSize = true;
            this.radioButton_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_CPF.Location = new System.Drawing.Point(40, 252);
            this.radioButton_CPF.Name = "radioButton_CPF";
            this.radioButton_CPF.Size = new System.Drawing.Size(45, 17);
            this.radioButton_CPF.TabIndex = 1;
            this.radioButton_CPF.TabStop = true;
            this.radioButton_CPF.Text = "CPF";
            this.radioButton_CPF.UseVisualStyleBackColor = true;
            // 
            // radioButton_RG
            // 
            this.radioButton_RG.AutoSize = true;
            this.radioButton_RG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_RG.Location = new System.Drawing.Point(40, 275);
            this.radioButton_RG.Name = "radioButton_RG";
            this.radioButton_RG.Size = new System.Drawing.Size(41, 17);
            this.radioButton_RG.TabIndex = 2;
            this.radioButton_RG.TabStop = true;
            this.radioButton_RG.Text = "RG";
            this.radioButton_RG.UseVisualStyleBackColor = true;
            // 
            // radioButton_Matrícula
            // 
            this.radioButton_Matrícula.AutoSize = true;
            this.radioButton_Matrícula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_Matrícula.Location = new System.Drawing.Point(41, 298);
            this.radioButton_Matrícula.Name = "radioButton_Matrícula";
            this.radioButton_Matrícula.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Matrícula.TabIndex = 3;
            this.radioButton_Matrícula.TabStop = true;
            this.radioButton_Matrícula.Text = "Matrícula";
            this.radioButton_Matrícula.UseVisualStyleBackColor = true;
            // 
            // lblFiltroFuncionario
            // 
            this.lblFiltroFuncionario.AutoSize = true;
            this.lblFiltroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblFiltroFuncionario.Location = new System.Drawing.Point(28, 200);
            this.lblFiltroFuncionario.Name = "lblFiltroFuncionario";
            this.lblFiltroFuncionario.Size = new System.Drawing.Size(73, 17);
            this.lblFiltroFuncionario.TabIndex = 32;
            this.lblFiltroFuncionario.Text = "Filtrar por:";
            // 
            // frmApontamentoHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 464);
            this.Controls.Add(this.lblFiltroFuncionario);
            this.Controls.Add(this.radioButton_Matrícula);
            this.Controls.Add(this.radioButton_RG);
            this.Controls.Add(this.maskedTextBox_DataFim);
            this.Controls.Add(this.radioButton_CPF);
            this.Controls.Add(this.maskedTextBox_DataInicio);
            this.Controls.Add(this.radioButton_Nome);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_Incluir);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.dataGridView_Consulta);
            this.Controls.Add(this.textBox_Funcionario);
            this.Controls.Add(this.label_Funcionario);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.comboBox_Empresa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmApontamentoHoras";
            this.Text = "APONTAMENTO DE HORAS";
            this.Load += new System.EventHandler(this.frmApontamentoHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Remover;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Incluir;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.DataGridView dataGridView_Consulta;
        private System.Windows.Forms.TextBox textBox_Funcionario;
        private System.Windows.Forms.Label label_Funcionario;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.ComboBox comboBox_Empresa;
        private System.Windows.Forms.RadioButton radioButton_Nome;
        private System.Windows.Forms.RadioButton radioButton_CPF;
        private System.Windows.Forms.RadioButton radioButton_RG;
        private System.Windows.Forms.RadioButton radioButton_Matrícula;
        private System.Windows.Forms.Label lblFiltroFuncionario;
    }
}