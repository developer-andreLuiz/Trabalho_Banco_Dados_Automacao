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
    class NfePesquisarProdutoAccess
    {

        public object codigo;
        public int controle;
        public object referencia;
        public object codigo_forncedor;
        public object descricao;

        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        public void BuscarDadosNFePesqProdutosAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from NFePesq_Prod where Controle = @controle;";
                comando.Parameters.AddWithValue("controle", x);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["descriçao"] != null)
                    {
                        controle = int.Parse(reader["Controle"].ToString());
                        codigo = reader["Codigo"].ToString();
                        referencia = reader["Referencia"].ToString();
                        descricao = reader["descriçao"].ToString();
                        codigo_forncedor = reader["Cod_Forn"].ToString();

                    }
                }
            }
            catch(Exception a){ MessageBox.Show(a.Message); }finally{conexao.Close();}

        }
      
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from NFePesq_Prod order by Codigo asc ";


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
            catch{}finally{conexao.Close();}




        }

        public void ObjVazio()
        {
            
            codigo = null;
            referencia = null;
            codigo_forncedor = null;
            descricao = null;
        }
    }

    
}
