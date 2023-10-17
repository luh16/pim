using classesDeControle;
using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Empresas
{
    public partial class frmAddEmpresa : Form
    {
        public frmAddEmpresa()
        {
            InitializeComponent();
        }

    //metodo que pega o valor no re
    public void GetEmpresa(int id)
        {/*
            
            string conexaoSql = @"Data Source=DESKTOP-NH2G201\SQLEXPRESS;Initial Catalog=BdFolhaFacil;Integrated Security=True";

            SqlConnection conexaoBd = new SqlConnection(conexaoSql);


            try
            {
                string query = @"SELECT*FROM TBempresa WHERE idEmpresa =" + id;
                SqlCommand cmd = new SqlCommand(query, conexaoBd);

                conexaoBd.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        txtEmpresa.Text = dr["nomeEmpresa"].ToString();
                        mskCnpj.Text = dr["cnpj"].ToString();
                        txtEndereco.Text = dr["logradouro"].ToString();
                        msktxtTelefone.Text = dr["telefone"].ToString();
                        txtEmail.Text = dr["email"].ToString();

                        btnLimparEmpresa.Visible = false;
                        btnCadstrarEmpresa.Text = "Salvar";
                    }
                }

            }catch(Exception ex)
            {
                conexaoBd.Close();
                throw new Exception("Erro não foi possivel abrir os dados da Empresa" + ex.Message);
            }*/
        }

        //Botão ´para quando o usuraio clicar em adicionar
        public void btnCadstrarEmpresa_Click(object sender, EventArgs e)
        {
            /*
            if (this.id == 0)
            {
                cltEmpresa _cltEmpresa = new cltEmpresa();

                if (mskCnpj.Text == "" || txtEmpresa.Text == "" || txtEndereco.Text == "" || txtEmail.Text == "" || msktxtTelefone.Text == "")
                {
                    MessageBox.Show("Erro dados em branco", "atenção");
                    return;
                }



                _cltEmpresa.IncluirEmpresa(mskCnpj.Text, txtEmpresa.Text, txtEndereco.Text, msktxtTelefone.Text, txtEmail.Text);
                MessageBox.Show("Empresa Cadastrada !");
            }
            else
            {
                cltEmpresa updateEmpresa = new cltEmpresa();
                updateEmpresa.AlterarEmpresa(this.id, mskCnpj.Text, txtEmpresa.Text, txtEndereco.Text, msktxtTelefone.Text, txtEmail.Text);
                MessageBox.Show("Empresa Atualizada !");
            }*/
        }

        //botão disponivel quando o formulario for de adicionar, limpa os dados 
        private void btnLimparEmpresa_Click(object sender, EventArgs e)
        {
            txtEmpresa.Text = "";
            mskCnpj.Text = "";
            msktxtTelefone.Text = "";
            txtEmail.Text = "";            
            txtEndereco.Text = "";       
        }
    }
}
