using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace nano9.Folha_Pagamento
{
    public partial class folhaPagamento : Form
    {
        public folhaPagamento()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Declaração de variáveis
            int codigo;
            float horasTrabalho, salario, valorHoraTrabalhada;

            // Verifica se o código do funcionário é um número inteiro válido
            if (!float.TryParse(valorHora.Text, out valorHoraTrabalhada))
            {
                MessageBox.Show("Código de funcionário inválido.");
                return;
            }

            // Verifica se as horas de trabalho são um número float válido
            if (!float.TryParse(horasTrab.Text, out horasTrabalho))
            {
                MessageBox.Show("Horas de trabalho inválidas.");
                return;
            }

            if (horasTrabalho > 1500)
            {
                float horasExtras = horasTrabalho - 50;
                float salarioBase = 1500 * valorHoraTrabalhada;
                float salarioExtra = horasExtras * 20.00f;
                salario = salarioBase + salarioExtra;

                MessageBox.Show($"O salário final é {salario:C2}");
                MessageBox.Show($"Hora Extra exedida {salarioExtra:C2}");
            }
            else
            {
                salario = horasTrabalho * valorHoraTrabalhada;
            }

            MessageBox.Show("Salário Do funcionario: " + salario.ToString("C2"));
        }
    }
}
