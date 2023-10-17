using projeto.Modelo;
using Projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle
{
    public class ctlEmpresa
    {
        public static List<mdlEmpresa> listarEmpresa()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            List<mdlEmpresa> empresas = new List<mdlEmpresa>();

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Empresa;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlEmpresa empresa = new mdlEmpresa();
                        empresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        empresa.nome = cursor["nome"].ToString();
                        empresa.cnpj = cursor["cnpj"].ToString();
                        empresa.telefone = cursor["telefone"].ToString();
                        empresa.email = cursor["email"].ToString();
                        empresa.endereco = cursor["endereco"].ToString();
                        empresas.Add(empresa);
                    }
                }
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
            }
            return empresas;
        }

        public static List<mdlEmpresa> pesquisarEmpresaPeloNome(mdlEmpresa _mdlEmpresa)
        {

            List<mdlEmpresa> listEmpresa = new List<mdlEmpresa>();

            string[] nomeSeparado = _mdlEmpresa.nome.Split();
            string parametrosNome = "";
            for (int i = 0; i < nomeSeparado.Length; i++)
            {
                if (i == 0)
                {
                    parametrosNome += $"nome LIKE '%{nomeSeparado[i]}%";
                }
                else
                {
                    parametrosNome += $"%{nomeSeparado[i]}%";
                }
            }
            if(parametrosNome.Length > 0)
            {
                parametrosNome += "'";
            }           

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "";
                if (parametrosNome.Length > 0)
                {
                    sqlQuery = $"SELECT * FROM Empresa WHERE {parametrosNome};";
                }
                else
                {
                    sqlQuery = $"SELECT * FROM Empresa;";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlEmpresa empresa = new mdlEmpresa();
                        empresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        empresa.nome = cursor["nome"].ToString();
                        empresa.cnpj = cursor["cnpj"].ToString();
                        empresa.telefone = cursor["telefone"].ToString();
                        empresa.email = cursor["email"].ToString();
                        empresa.endereco = cursor["endereco"].ToString();
                        listEmpresa.Add(empresa);
                    }
                }

                return listEmpresa;
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listEmpresa;
            }
        }

        public static List<mdlEmpresa> pesquisarEmpresaPeloCNPJ(mdlEmpresa _mdlEmpresa)
        {
            List<mdlEmpresa> listEmpresa = new List<mdlEmpresa>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Empresa WHERE cnpj LIKE @cnpj + '%';";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtCNPJ = command.CreateParameter();
                pmtCNPJ.ParameterName = "@cnpj";
                pmtCNPJ.DbType = DbType.String;
                pmtCNPJ.Value = _mdlEmpresa.cnpj;
                command.Parameters.Add(pmtCNPJ);

                SqlDataReader cursor = command.ExecuteReader();

                if(cursor.HasRows)
                {
                    while(cursor.Read())
                    {
                        mdlEmpresa empresa = new mdlEmpresa();
                        empresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        empresa.nome = cursor["nome"].ToString();
                        empresa.cnpj = cursor["cnpj"].ToString();
                        empresa.telefone = cursor["telefone"].ToString();
                        empresa.email = cursor["email"].ToString();
                        empresa.endereco = cursor["endereco"].ToString();
                        listEmpresa.Add(empresa);
                    }
                }
                return listEmpresa;
            }
            catch(Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listEmpresa;
            }
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
