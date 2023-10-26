namespace nano9.Folha_Pagamento
{
    partial class folhaPagamento
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
            this.Txt_HrTrabalhada = new System.Windows.Forms.Label();
            this.horasTrab = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valorHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_HrTrabalhada
            // 
            this.Txt_HrTrabalhada.AutoSize = true;
            this.Txt_HrTrabalhada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_HrTrabalhada.Location = new System.Drawing.Point(52, 271);
            this.Txt_HrTrabalhada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_HrTrabalhada.Name = "Txt_HrTrabalhada";
            this.Txt_HrTrabalhada.Size = new System.Drawing.Size(246, 32);
            this.Txt_HrTrabalhada.TabIndex = 2;
            this.Txt_HrTrabalhada.Text = "Horas trabalhadas";
            // 
            // horasTrab
            // 
            this.horasTrab.Location = new System.Drawing.Point(324, 275);
            this.horasTrab.Margin = new System.Windows.Forms.Padding(4);
            this.horasTrab.Name = "horasTrab";
            this.horasTrab.Size = new System.Drawing.Size(247, 29);
            this.horasTrab.TabIndex = 9;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calcular.Location = new System.Drawing.Point(58, 372);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(282, 92);
            this.btn_calcular.TabIndex = 10;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor da Hora";
            // 
            // valorHora
            // 
            this.valorHora.Location = new System.Drawing.Point(324, 176);
            this.valorHora.Margin = new System.Windows.Forms.Padding(4);
            this.valorHora.Name = "valorHora";
            this.valorHora.Size = new System.Drawing.Size(247, 29);
            this.valorHora.TabIndex = 12;
            // 
            // folhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.valorHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.horasTrab);
            this.Controls.Add(this.Txt_HrTrabalhada);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "folhaPagamento";
            this.Text = "Folha_Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Txt_HrTrabalhada;
        private System.Windows.Forms.TextBox horasTrab;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorHora;
    }
}