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
    class ClienteAccess
    {
        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\BancodeDados111\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";
        
        public object codigo;
        public object nome;
        public object endereco;
        public object bairro;
        public object cidade;
        public object uf;
        public object cep;
        public object cnpjCpf;
        public object telefone1;
        public object telefone2;
        public object observacao;
        public object lado;
        public object posicao;
        public object cor;
        public object dataNascimento;
        public object representante;


        public int totalLinhasClienteAccess;




        /// <summary>
        /// Insere um novo cadastro no Access
        /// </summary>
        public void InsertAccess()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "insert into Clientes (Codigo, Nome, Endereco, Bairro, Cidade, uf, CNPJ_CPF, Cep, Telefone1, Telefone2, Representante, Observacao, lado, posiçao, cor, dataNascimento) values (@Codigo, @Nome, @Endereco, @Bairro, @Cidade, @uf, @cnpjCpf, @Cep, @Telefone1, @Telefone2, @Representante, @Observacao, @lado, @posicao, @cor, @dataNascimento);";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);
            comando.Parameters.AddWithValue("Codigo", codigo);
            comando.Parameters.AddWithValue("Nome", nome);
            comando.Parameters.AddWithValue("Endereco", endereco);
            comando.Parameters.AddWithValue("Bairro", bairro);
            comando.Parameters.AddWithValue("Cidade", cidade);
            comando.Parameters.AddWithValue("uf", uf);
            comando.Parameters.AddWithValue("cnpjCpf", cnpjCpf);
            comando.Parameters.AddWithValue("Cep", cep);
            comando.Parameters.AddWithValue("Telefone1", telefone1);
            comando.Parameters.AddWithValue("Telefone2", telefone2);
            comando.Parameters.AddWithValue("Representante", representante);
            comando.Parameters.AddWithValue("Observacao", observacao);
            comando.Parameters.AddWithValue("lado", lado);
            comando.Parameters.AddWithValue("posicao", posicao);
            comando.Parameters.AddWithValue("cor", cor);
            comando.Parameters.AddWithValue("dataNascimento", dataNascimento);
           



            try
            {
                conexao.Open();
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
        /// Atualiza o Access partindo do MySql
        /// </summary>
        /// <param name="x"></param>
        public void UpdateAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "update Clientes set Codigo = @Codigo ,Nome = @nome, Endereco = @endereco, Bairro = @bairro, Cidade = @cidade, uf = @uf,  CNPJ_CPF = @cnpjCpf, Cep = @cep, Telefone1 = @Telefone1, Telefone2 = @Telefone2, Representante = @Representante, Observacao = @Observacao, lado = @lado, posiçao = @posicao, cor = @cor, dataNascimento = @dataNascimento where Codigo = " + x + ";";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);
            comando.Parameters.AddWithValue("Codigo", x);
            comando.Parameters.AddWithValue("Nome", nome);
            comando.Parameters.AddWithValue("Endereco", endereco);
            comando.Parameters.AddWithValue("Bairro", bairro);
            comando.Parameters.AddWithValue("Cidade", cidade);
            comando.Parameters.AddWithValue("uf", uf);
            comando.Parameters.AddWithValue("CNPJ_CPF", cnpjCpf);
            comando.Parameters.AddWithValue("Cep", cep);
            comando.Parameters.AddWithValue("Telefone1", telefone1);
            comando.Parameters.AddWithValue("Telefone2", telefone2);
            comando.Parameters.AddWithValue("Representante", representante);
            comando.Parameters.AddWithValue("Observacao", observacao);
            comando.Parameters.AddWithValue("lado", lado);
            comando.Parameters.AddWithValue("posicao", posicao);
            comando.Parameters.AddWithValue("cor", cor);
            comando.Parameters.AddWithValue("dataNascimento", dataNascimento);
           


            try
            {
                conexao.Open();
                if (comando.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("atualizado");
                }


            }
            catch (Exception a)
            {
                //MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        /// <summary>
        ///Reseta e atualiza o banco de dados Access 
        /// </summary>
        public void TruncateTable()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
           
            try
            {
                string comandoString = "delete * from  Clientes;";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

                comandoString = "Alter Table Clientes Alter Column Codigo Counter(1, 1);";
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
        /// Busca dados do cliente e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosClientesAccess(int x)
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
                    if (reader["nome"] != null)
                    {
                        codigo = reader["Codigo"].ToString();
                        nome = reader["Nome"].ToString();
                        endereco = reader["Endereco"].ToString();
                        bairro = reader["Bairro"].ToString();
                        cidade = reader["Cidade"].ToString();
                        uf = reader["uf"].ToString();
                        cep = reader["Cep"].ToString();
                        telefone1 = reader["Telefone1"].ToString();
                        telefone2 = reader["Telefone2"].ToString();
                        representante = reader["Representante"].ToString();
                        cnpjCpf = reader["CNPJ_CPF"].ToString();
                        //distancia = reader["Distancia"].ToString();
                        observacao = reader["Observacao"].ToString();
                        //iEstadual = reader["Iestadual"].ToString();
                        //ddd = reader["DDD"].ToString();
                        lado = reader["lado"].ToString();
                        posicao = reader["posiçao"].ToString();
                        cor = reader["cor"].ToString();
                        dataNascimento = reader["dataNascimento"].ToString();



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
        /// <summary>
        ///  Exibe dados da tabela Clientes no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from Clientes order by Codigo asc ";
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
        /// Retorna Total de linhas Clientes
        /// </summary>
        public void TotalLinhasClientes()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select top 1 * from Clientes order by Codigo desc;";
               

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                  totalLinhasClienteAccess = int.Parse(reader["Codigo"].ToString()); 
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


        public void ObjVazio()
        {
            nome = null;

        }




    }
}
