using classesDeControle;
using Projeto.Modelo;
using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace PrototipoRH.Funcionarios
{
    public partial class frmAddFuncionario : Form
    {
        public frmAddFuncionario()
        {
            InitializeComponent();
        }

        private void frmAddFuncionario_Load(object sender, EventArgs e)
        {
            btnAddFuncionario.Left = (this.Width - btnAddFuncionario.Width) / 2; // Centraliza o componente
            cbEmpresa.DataSource = ctlEmpresa.listarEmpresa();
            cbEmpresa.Text = "[Selecionar]";
            cboStatus.DataSource = getListStatus();

        }

        private static List<string> getListStatus()
        {
            List<string> list = new List<string>();
            list.Add("ATIVO");
            list.Add("DESLIGADO");
            return list;
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {/*
            mdlFuncionario _mdlFuncionario = new mdlFuncionario();
            ctlFuncionario _ctlFuncionario = new ctlFuncionario();
            string completarData = mskDataAdmissao.Text + " 00:00:00";
            var dataAdimissao = DateTime.Parse(completarData);

            _mdlFuncionario.NomeFuncionario = txtNomeFuncionario.Text;
            _mdlFuncionario.cpf = mskCpf.Text;
            _mdlFuncionario.salarioHora= Convert.ToDecimal(txtSalarioPorHora.Text);
            _mdlFuncionario.salarioTotal=Convert.ToDecimal(txtSalarioTotal.Text);
            _mdlFuncionario.eMail=txtEMail.Text;
            _mdlFuncionario.Departamento=txtDepartamento.Text;
            _mdlFuncionario.DataAdimissao = dataAdimissao;
            _mdlFuncionario.horaEntrada = mskHoraEntrada.Text;
            _mdlFuncionario.horaSaida = mskHoraSaida.Text;
            _mdlFuncionario.usuario = txtUsuario.Text;
            _mdlFuncionario.senha = txtSenha.Text;

            string empresaFuncionario = cbEmpresa.Text;

            _ctlFuncionario.incluirFuncionario(_mdlFuncionario, empresaFuncionario);

            if(_ctlFuncionario.incluirFuncionario(_mdlFuncionario, empresaFuncionario) ==true)
            {
                MessageBox.Show("Funcionario Cadastrado com Sucesso !");

                frmAddFuncionario _frmAddFuncionario = new frmAddFuncionario();

                _frmAddFuncionario.Close();
            }
            else
            {
                MessageBox.Show("Funcionario Não Cadastrado, algo deu errado !");
            }*/
        }
    }
}
