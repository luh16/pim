﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teste
{
    public partial class addFuncionarios : Form
    {
        private readonly object txtNome;
        MySqlConnection Conexao;
        public addFuncionarios()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Data_source = "datasource=LocalHost;Username=root;password=123456;database=db_agenda";
                // Criar Conexao Com MySql
                Conexao = new MySqlConnection(Data_source);

                string sql = "INSERT INTO contatos (nome,telefone,cpf,cep) VALUES ('" + txtName.Text + "','" + TxtTelefone.Text + "','" + Txt_Cpf.Text + "','" + Text_Cep.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastro feito com sucesso!");

                //Execultar Comando Insert


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();


            }
        }

        private void Txt_Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    
}
