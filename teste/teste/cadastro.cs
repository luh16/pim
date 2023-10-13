using System;
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
    public partial class cadastro : Form
    {
        private readonly object txtNome;
        MySqlConnection Conexao;
        public cadastro()
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

                string sql = "INSERT INTO contato (nome,email,telefone) VALUES ('" + txtName.Text + "','" + txtEmail.Text + "','" + TxtTelefone.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu bom");

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

    }
    
}
