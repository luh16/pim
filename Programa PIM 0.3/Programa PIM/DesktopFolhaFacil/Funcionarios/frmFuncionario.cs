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

namespace PrototipoRH.Funcionarios
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            comboBox_Empresa.DataSource = ctlEmpresa.listarEmpresa();
            comboBox_Empresa.Text = "[Selecionar]";
            radioButton_Nome.Checked = true;
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            frmAddFuncionario _frmAddFuncionario = new frmAddFuncionario();

            _frmAddFuncionario.ShowDialog();

        }
    }
}
