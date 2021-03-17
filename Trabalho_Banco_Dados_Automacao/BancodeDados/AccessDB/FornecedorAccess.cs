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
    class FornecedorAccess
    {

        //string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\Banco_Dados\Soft.mdb";
        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        public object codigo;
        public object nome;
        public object endereco;
        public object bairro;
        public object cidade;
        public object uf;
        public object cep;
        public object telefone1;
        public object telefone2;
        public object cnpjCpf;
        public object observacao;
        public object registro;
        public object nota;
        public object representante;

        public object codigoCodigo;
        public object nomeCodigo;
        public object cnpjCodigo;
        public object id;


        public int totalLinhasFornecedorAccess;
        public int totalLinhasFornecedorCodigoAccess;

        /// <summary>
        /// Insere um novo cadastro no Access
        /// </summary>
        public void InsertAccess()
        {
            
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "insert into Fornecedores (Codigo, Nome, Endereco, Bairro, Cidade,Uf,Cep,Telefone1,Telefone2,Representante,CNPJ_CPF,Observacao,iestadual,nota) values (@Codigo, @Nome, @Endereco, @Bairro, @Cidade, @uf, @Cep, @Telefone1, @Telefone2, @Representante,@cnpjCpf, @Observacao, @registro, @nota);";
            
           
               
         
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);

            comando.Parameters.AddWithValue("Codigo", codigo);
            comando.Parameters.AddWithValue("Nome", nome);
            comando.Parameters.AddWithValue("Endereco", endereco);
            comando.Parameters.AddWithValue("Bairro", bairro);
            comando.Parameters.AddWithValue("Cidade", cidade);
            comando.Parameters.AddWithValue("uf", uf);
            comando.Parameters.AddWithValue("Cep", cep);
            comando.Parameters.AddWithValue("Telefone1", telefone1);
            comando.Parameters.AddWithValue("Telefone2", telefone2);
            comando.Parameters.AddWithValue("Representante", representante);
            comando.Parameters.AddWithValue("cnpjCpf", cnpjCpf);
            comando.Parameters.AddWithValue("Observacao", observacao);
            comando.Parameters.AddWithValue("registro", registro);
            comando.Parameters.AddWithValue("nota", nota);




            try
            {
                conexao.Open();
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
        }
        /// <summary>
        /// Atualiza o Access partindo do MySql
        /// </summary>
        /// <param name="x"></param>
        public void UpdateAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            //MessageBox.Show(nota.ToString());
         
            string comandoString = "update Fornecedores set Codigo = @Codigo, Nome = @Nome , Endereco = @Endereco ,Bairro = @Bairro , Cidade = @Cidade, Uf = @uf, CNPJ_CPF = @cnpjCpf, Cep = @Cep,  Telefone1 = @Telefone1, Telefone2 = @Telefone2,  Observacao = @Observacao,  iestadual = @registro, Representante = @Representante, nota = @nota where Codigo = " + x + ";";
          
           
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
            comando.Parameters.AddWithValue("Observacao", observacao);
            comando.Parameters.AddWithValue("registro", registro);
            comando.Parameters.AddWithValue("Representante", representante);
            comando.Parameters.AddWithValue("nota", nota);



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
                MessageBox.Show(a.Message);
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
                string comandoString = "delete * from  Fornecedores;";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

                comandoString = "Alter Table Fornecedores Alter Column Codigo Counter(1, 1);";
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









        }
        /// <summary>
        /// Busca dados do Fornecedores e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosFornecedoresAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Fornecedores where Codigo = @codigo;";
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
                        uf = reader["Uf"].ToString();
                        cep = reader["Cep"].ToString();
                        telefone1 = reader["Telefone1"].ToString();
                        telefone2 = reader["Telefone2"].ToString();
                        representante = reader["Representante"].ToString();
                        cnpjCpf = reader["CNPJ_CPF"].ToString();
                        observacao = reader["Observacao"].ToString();
                        registro = reader["iestadual"].ToString();
                        nota = reader["nota"].ToString();
                        



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

        }
        /// <summary>
        ///  Exibe dados da tabela Fornecedores no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from Fornecedores order by Codigo asc ";
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




        }
        /// <summary>
        /// Retorna Total de linhas Fornecedores
        /// </summary>
        public void TotalLinhasFornecedores()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = " SELECT count(Codigo) from Fornecedores as total;";


                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    totalLinhasFornecedorAccess = int.Parse(reader["Expr1000"].ToString());
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
        
        //tabela fornecedor codigo
        
        /// <summary>
        /// Retorna Total de linhas Fornecedor Codigo
        /// </summary>
        public void TotalLinhasFornecedorCodigo()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = " SELECT count(Codigo) from Fornec_codigo as total;";


                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    totalLinhasFornecedorCodigoAccess = int.Parse(reader["Expr1000"].ToString());
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
        /// Busca dados do FornecedorCodigo e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosFornecedorCodigoAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Fornec_codigo where id = @codigo;";
                comando.Parameters.AddWithValue("codigo", codigoCodigo);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Nome"] != null)
                    {
                        codigoCodigo = reader["Codigo"].ToString();
                        nomeCodigo = reader["Nome"].ToString();
                        cnpjCodigo = reader["Cnpj"].ToString();
                        id = reader["id"].ToString();




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

        }
        /// <summary>
        /// Insere um novo cadastro no Access Codigo
        /// </summary>
        public void InsertAccessCodigo()
        {

            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "insert into Fornec_codigo( codigo, nome, cnpj) values (@codigo, @nome, @cnpj);";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);

            comando.Parameters.AddWithValue("codigo", codigoCodigo);
            comando.Parameters.AddWithValue("nome", nomeCodigo);
            comando.Parameters.AddWithValue("cnpj", cnpjCodigo);

            




            try
            {
                conexao.Open();
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
        }


        public void ObjVazio()
        {
            nome = null;

        }
        public void ObjVazioCodigo()
        {
           nomeCodigo = null;
        }

        /// <summary>
        /// Deleta FornecedorCodigo
        /// </summary>
        public void DeleteFornecedorCodigo(string cnpfCodigo)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "DELETE FROM Fornec_codigo where Cnpj = @Cnpj;";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);
            comando.Parameters.AddWithValue("Cnpj", cnpfCodigo);
           
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
            
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
