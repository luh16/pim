using MySql.Data.MySqlClient;
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


namespace nano9.consultar_funcionarios
{
    public partial class consultaFuncionario : Form
    {

        MySqlConnection Conexao;
        public consultaFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consultarCpf_Click(object sender, EventArgs e)
        {

            try
            {
                string Data_source = "datasource=LocalHost;Username=root;password=123456;database=db_agenda";
                // Criar Conexao Com MySql
                Conexao = new MySqlConnection(Data_source);

                string sql = "SELECT nome,telefone,cpf,cep FROM db_agenda.contatos WHERE cpf = ('" + maskedTextBoxConsultaCpf.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridConsultaCpf.DataSource = dataTable;



                MessageBox.Show("Consulta feita com sucesso!");

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
