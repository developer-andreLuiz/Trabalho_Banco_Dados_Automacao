using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDataBase.BancodeDados.MySqlDb
{
    class NfEQuantidadeMySql
    {
        MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

        public object referencia_n;
        public object cod_produto;
        public object cod_fornecedor;
        public object quantidade;
        public int id;


        /// <summary>
        /// Exibe dados da tabela tb_nfe_quantidade no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridMySql(DataGridView dataGridView)
        {
            try
            {
                string strgComando = "select * from tb_nfe_quantidade;";

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                MySqlCommand comando = new MySqlCommand(strgComando, conexao);


                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(comando);

                DataTable dtLista = new DataTable();

                sqlDataAdapter.Fill(dtLista);

                dataGridView.DataSource = dtLista;

                //dataGridView.Columns[0].Width = 50;
                //dataGridView.Columns[1].Width = 300;
                //dataGridView.Columns[2].Width = 200;
                //dataGridView.Columns[3].Width = 120;
                //dataGridView.Columns[4].Width = 120;


            }
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Busca dados do tb_nfe_quantidade e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosNfequantidadesMySql(int x)
        {

            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_cliente where Codigo = @codigo;";
                comando.Parameters.AddWithValue("codigo", x);

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["referencia_n"] != null)
                    {

                        referencia_n = reader["referencia_n"].ToString();
                        cod_produto = reader["cod_produto"].ToString();
                        cod_fornecedor = reader["cod_fornecedor"].ToString();
                        quantidade = reader["quantidade"].ToString();
                        id = int.Parse(reader["id"].ToString());
                      
                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }

        /// <summary>
        /// Insere novos dados na tabela tb_nfe_quantidade
        /// </summary>
        public void InserirDados()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_cliente (referencia_n, cod_produto, cod_fornecedor, quantidade, id) values (@referencia_n, @cod_produto, @cod_fornecedor, @quantidade, @id);";

                comando.Parameters.AddWithValue("referencia_n", referencia_n);
                comando.Parameters.AddWithValue("cod_produto", cod_produto);
                comando.Parameters.AddWithValue("cod_fornecedor", cod_fornecedor);
                comando.Parameters.AddWithValue("quantidade", quantidade);
                comando.Parameters.AddWithValue("cidade", id);
             
                comando.ExecuteNonQuery();

            }
            catch (Exception a)
            {

                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();

            }


        }

    }
}
