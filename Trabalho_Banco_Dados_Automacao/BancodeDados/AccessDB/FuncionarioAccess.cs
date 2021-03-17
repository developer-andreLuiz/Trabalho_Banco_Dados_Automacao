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
    class FuncionarioAccess
    {
        //string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\Banco_Dados\Soft.mdb";
        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        public object codigo;
        public object nome;
        public object senha;
        public object habilitado;
        public object nivel;
        public object cargo;
        public object endereco;
        public object bairro;
        public object cidade;
        public object telefone1;
        public object telefone2;
        public object compras;
        public object observacao;
        public object apagador;
        public object senhaAcesso;
       
     

        public int totalLinhasFuncionarioAccess;

        /// <summary>
        /// Insere um novo cadastro no Access
        /// </summary>
        public void InsertAccess()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "insert into Funcionario (Codigo, Nome, Senha, Habilitado, Nivel, Cargo, endereço, bairro, cidade, telefone, telefone1, observaçao, Senha_acesso, Compras, Apagador ) values (@codigo, @nome, @senha, @habilitado, @nivel, @cargo, @endereco, @bairro, @cidade, @telefone1, @telefone2, @observacao, @senhaAcesso, @compras, @apagador );";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);
            comando.Parameters.AddWithValue("codigo", codigo);
            comando.Parameters.AddWithValue("nome", nome);
            comando.Parameters.AddWithValue("senha", senha);
            comando.Parameters.AddWithValue("habilitado", habilitado);
            comando.Parameters.AddWithValue("nivel", nivel);
            comando.Parameters.AddWithValue("cargo", cargo);
            comando.Parameters.AddWithValue("endereco", endereco);
            comando.Parameters.AddWithValue("bairro", bairro);
            comando.Parameters.AddWithValue("cidade", cidade);
            comando.Parameters.AddWithValue("telefone1", telefone1);
            comando.Parameters.AddWithValue("telefone2", telefone2);
            comando.Parameters.AddWithValue("observacao", observacao);
            comando.Parameters.AddWithValue("senhaAcesso", senhaAcesso);
            comando.Parameters.AddWithValue("compras", compras);
            comando.Parameters.AddWithValue("apagador", apagador);




            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                //MessageBox.Show("insert");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }
        }//////////////////////////////////////////////
        

        /// <summary>
        /// Atualiza o Access partindo do MySql
        /// </summary>
        /// <param name="x"></param>
        public void UpdateAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
          
            string comandoString = "update Funcionario set Codigo = @Codigo, Nome = @nome, Senha = @senha, Habilitado = @habilitado, Nivel = @nivel, Cargo = @cargo, endereço = endereco, bairro = @bairro, cidade = @cidade, telefone = @telefone1, telefone1 = @telefone2, observaçao = @observacao, Senha_acesso = @senhaAcesso, Compras = @compras, Apagador = @apagador   where Codigo = " + x + ";";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);
            comando.Parameters.AddWithValue("Codigo", codigo);
            comando.Parameters.AddWithValue("nome", nome);
            comando.Parameters.AddWithValue("senha", senha);
            comando.Parameters.AddWithValue("habilitado", habilitado);
            comando.Parameters.AddWithValue("nivel", nivel);
            comando.Parameters.AddWithValue("cargo", cargo);
            comando.Parameters.AddWithValue("endereco", endereco);
            comando.Parameters.AddWithValue("bairro", bairro);
            comando.Parameters.AddWithValue("cidade", cidade);
            comando.Parameters.AddWithValue("telefone1", telefone1);
            comando.Parameters.AddWithValue("telefone2", telefone2);
            comando.Parameters.AddWithValue("observacao", observacao);
            comando.Parameters.AddWithValue("senhaAcesso", senhaAcesso);
            comando.Parameters.AddWithValue("compras", compras);
            comando.Parameters.AddWithValue("apagador", apagador);



            try
            {
                conexao.Open();
                if (comando.ExecuteNonQuery() > 0)
                {
                  //  MessageBox.Show("atualizado");
                }


            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }///////////////////////////////////////

        /// <summary>
        ///Reseta e atualiza o banco de dados Access 
        /// </summary>
        public void TruncateTable()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);

            try
            {
                string comandoString = "delete * from  Funcionario;";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

                comandoString = "Alter Table Funcionario Alter Column Codigo Counter(1, 1);";
                comando.ExecuteNonQuery();



            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }









            }///////////////////////////////////////////

        /// <summary>
        /// Busca dados do Funcionario e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosFuncionarioAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Funcionario where Codigo = @codigo;";
                comando.Parameters.AddWithValue("codigo", x);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                        codigo= reader["Codigo"].ToString();
                        nome = reader["Nome"].ToString();
                        senha = reader["Senha"].ToString();
                        habilitado = reader["Habilitado"].ToString();
                        nivel = reader["Nivel"].ToString();
                        cargo = reader["Cargo"].ToString();
                        endereco = reader["endereço"].ToString();
                        bairro = reader["bairro"].ToString();
                        cidade = reader["cidade"].ToString();
                        telefone1 = reader["telefone"].ToString();
                        telefone2 = reader["telefone1"].ToString();
                        observacao = reader["observaçao"].ToString();
                        senhaAcesso = reader["Senha_acesso"].ToString();
                        compras = reader["Compras"].ToString();
                        apagador = reader["Apagador"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("id Invalido");
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

        }/////////////////////////

        /// <summary>
        ///  Exibe dados da tabela Funcionario no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from Funcionario order by Codigo asc ";
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
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }




        }//////////////////

        /// <summary>
        /// Retorna Total de linhas Funcionario
        /// </summary>
        public void TotalLinhasFuncionario()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
              
                comando.CommandText = " SELECT count(Codigo) from Funcionario as total;";


                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    totalLinhasFuncionarioAccess = int.Parse(reader["Expr1000"].ToString());
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
        }//////////////////////////////////

        public void ObjVazio()
        {
            nome = null;
            
        }




    }
}
