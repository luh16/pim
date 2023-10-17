using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Apontamento_de_Horas
{
    public partial class frmApontamentoHoras : Form
    {
        public frmApontamentoHoras()
        {
            InitializeComponent();
        }

        private void frmApontamentoHoras_Load(object sender, EventArgs e)
        {
            funcionarios.Add(new Funcionario("João de Paulo Freitas", "1", "2023-08-31", "9:01", "11:58", "13:10", "17:50", "Abracadabra"));
            funcionarios.Add(new Funcionario("Julia de Almeida Souza", "2", "2023-08-31", "7:30", "12:00", "12:20", "15:30", "Abracadabra"));
            funcionarios.Add(new Funcionario("Pedro Barros Santos", "3", "2023-08-31", "8:00", "12:00", "13:00", "16:02", "Abracadabra"));
            funcionarios.Add(new Funcionario("Neymar Guedes Augusto", "4", "2023-08-31", "8:00", "12:00", "12:59", "16:00", "Abracadabra"));

            DateTime hoje = DateTime.Now;
            maskedTextBox_DataInicio.Text = hoje.ToString("dd/MM/yyyy");
            maskedTextBox_DataFim.Text = hoje.ToString("dd/MM/yyyy");
            comboBox_Empresa.DataSource = ctlEmpresa.listarEmpresa();
            comboBox_Empresa.Text = "[Selecionar]";

            radioButton_Nome.Checked = true;

            AtualizarListaFuncionarios();
        }

        class Funcionario
        {
            public String nome { get; set; }
            public String matricula { get; set; }
            public String data { get; set; }
            public String entrada { get; set; }
            public String ida { get; set; }
            public String volta { get; set; }
            public String saida { get; set; }
            public String Empresa { get; set; }

            public Funcionario(String nome, String matricula, String data, String entrada, String ida, String volta, String saida, string empresa)
            {
                this.nome = nome;
                this.matricula = matricula;
                this.data = data;
                this.entrada = entrada;
                this.ida = ida;
                this.volta = volta;
                this.saida = saida;
                this.Empresa = empresa;
            }
        }

        private List<Funcionario> funcionarios = new List<Funcionario>();

        private void ApontamentoHoras_Load(object sender, EventArgs e)
        {
            
        }

        private void AtualizarListaFuncionarios()
        {
            this.dataGridView_Consulta.DataSource = funcionarios;
        }

        private void btnFecharAba_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_Empresa_Click(object sender, EventArgs e)
        {

        }
    }
}

