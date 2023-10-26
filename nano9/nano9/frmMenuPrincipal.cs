using nano9.Apontamento_de_Horas;
using nano9.consultar_funcionarios;
using nano9.Folha_Pagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste;

namespace nano9
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnApontamentoHoras_Click(object sender, EventArgs e)
        {
            apontamentoHoras _apontamentoHoras = new apontamentoHoras();

            _apontamentoHoras.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            addFuncionarios _addfuncionarios = new addFuncionarios ();

            _addfuncionarios.ShowDialog();
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            folhaPagamento _folhaPagamento = new folhaPagamento();

            _folhaPagamento.ShowDialog();

        }

        private void consultarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaFuncionario _consultaFuncionario = new consultaFuncionario();

            _consultaFuncionario.ShowDialog();
        }
    }
}
