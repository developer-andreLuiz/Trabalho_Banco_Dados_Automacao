using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDataBase.BancodeDados.AccessDB
{
    class NfEQuantidadeAccess
    {
        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        public object referencia_n;
        public object cod_produto;
        public object cod_fornecedor;
        public object quantidade;
        public int id;


        /// <summary>
        ///  Exibe dados da tabela NFe_Quantidade no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from NFe_Quantidade order by id asc ";
                //string comandoString = "select * from Itens_pedidos where Codigo_funcionario =81 and codigo = '11858' and quantidade=1 ";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(comando);

                DataTable dtLista = new DataTable();

                dataAdapter.Fill(dtLista);

                dataGridView.DataSource = dtLista;
            }
            catch (Exception a)
            {
                // MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }




        }

        /// <summary>
        /// Busca dados do cliente e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Clientes where Codigo = @codigo;";
                comando.Parameters.AddWithValue("codigo", x);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Referencia_N"] != null)
                    {
                        referencia_n = reader["Referencia_N"].ToString();
                        cod_produto = reader["Cod_Produto"].ToString();
                        cod_fornecedor = reader["Cod_Forn"].ToString();
                        quantidade = reader["Quantidade"].ToString();
                        id = int.Parse(reader["id"].ToString());
                      
                    }
                    else
                    {
                        MessageBox.Show("id Invalido");
                    }
                }
            }
            catch (Exception a)
            {
                // MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }

    }
}
