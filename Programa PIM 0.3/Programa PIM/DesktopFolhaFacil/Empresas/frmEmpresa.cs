using projeto.Modelo;
using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Empresas
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
            //LoadGataGridView();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            RbtnNomeEmpresa.Checked = true;
        }

        private void btnPesquisarEmpresa_Click_1(object sender, EventArgs e)
        {
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();         
            if (RbtnNomeEmpresa.Checked == true)
            {
                _mdlEmpresa.nome = TxtPesquisarEmpresa.Text;
                dgvEmpresa.DataSource = ctlEmpresa.pesquisarEmpresaPeloNome(_mdlEmpresa);
            }

            if(RbtnCnpjEmpresa.Checked == true)
            {
                _mdlEmpresa.cnpj = TxtPesquisarEmpresa.Text;
                dgvEmpresa.DataSource = ctlEmpresa.pesquisarEmpresaPeloCNPJ(_mdlEmpresa);
            }
        }

        private void BtnAddEmpresa_Click_1(object sender, EventArgs e)
        {
            frmAddEmpresa frmAddempresa = new frmAddEmpresa();
            frmAddempresa.ShowDialog();
        }

        private void BtnEditarEmpresa_Click_1(object sender, EventArgs e)
        {
           // var id = Convert.ToInt32(dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[0].Value);
                                                                                                      /*pega o registro do
                                                                                                       * dgv a partir do id que 
                                                                                                       * esta na coluna 0*/
            /*frmAddEmpresa _frmUpdateEmpresa = new frmAddEmpresa(id);
            _frmUpdateEmpresa.ShowDialog();*/
        }

        private void btnRefreshEmpresa_Click_1(object sender, EventArgs e)
        {
            //LoadGataGridView();
        }

        private void BtnExcluirEmpresa_Click_1(object sender, EventArgs e)
        {/*
            var id = Convert.ToInt32(dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[0].Value);

            frmDeleteEmpresa _deleteEmpresa = new frmDeleteEmpresa(id);
            _deleteEmpresa.ShowDialog();*/
        }

    }
}

