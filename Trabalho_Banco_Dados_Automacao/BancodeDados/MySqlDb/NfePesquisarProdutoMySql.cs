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
    class NfePesquisarProdutoMySql
    {
        public object codigo;
        public object referencia;
        public object codigo_forncedor;
        public object descricao;
        public object controle;

        MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

        /// <summary>
        /// Reseta e deleta os dados na tabela tb_Nfe_Pesq_Produto
        /// </summary>
        public void TruncateTable()
        {
            try
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "truncate table tb_nfe_pesquisa_produto;";
                comando.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                // MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        /// <summary>
        /// Insere novos dados na tabela tb_nfe_pesquisa_produto
        /// </summary>
        public void InserirDados()
        {

            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_nfe_pesquisa_produto (controle, codigo, descricao, referencia, codigo_fornecedor) values ('"+controle+"','"+codigo+"','"+descricao+"','"+referencia+"','"+codigo_forncedor+ "');";

                //comando.Parameters.AddWithValue("controle", controle);
                //comando.Parameters.AddWithValue("codigo", codigo);
                //comando.Parameters.AddWithValue("descricao", descricao);
                //comando.Parameters.AddWithValue("referencia", referencia);
                //comando.Parameters.AddWithValue("codigo_forncedor", codigo_forncedor);

                comando.ExecuteNonQuery();

            }
            catch(Exception a){ MessageBox.Show(a.Message); }finally {conexao.Close();}


        }
        /// <summary>
        /// Exibe dados da tabela  no DataGrid tb_nfe_pesquisa_produto
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridMySql(DataGridView dataGridView)
        {
            try
            {
                string strgComando = "select * from tb_nfe_pesquisa_produto;";
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                MySqlCommand comando = new MySqlCommand(strgComando, conexao);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(comando);
                DataTable dtLista = new DataTable();
                sqlDataAdapter.Fill(dtLista);
                dataGridView.DataSource = dtLista;
                
            }
            catch{}finally{conexao.Close();}
        }
    }
}
