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
    class FornecedorMySql
    {
        MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

        public object codigo;
        public object nome;
        public object endereco;
        public object bairro;
        public object cidade;
        public object estado;
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


        public int codigoFornecedorAtualizado;
        public int totalLinhasFornecedorRegistro;
        public int totalLinhasFornecedorMySql;
        public int totalLinhasFornecedorCodigoMySql;
        public int totalLinhasFornecedorCodigoDeleteMySql;



        /// <summary>
        /// Reseta e deleta os dados na tabela tb_forcenedor
        /// </summary>
        public void TruncateTable()
        {
            try
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "truncate table tb_fornecedor;";
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

        }////////////////////////////////////////
        /// <summary>
        /// Insere novos dados na tabela tb_fornecedor
        /// </summary>
        public void InserirDados()
        {

            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_fornecedor (codigo, nome, endereco, bairro, cidade, estado, cep, telefone, telefone1,representante, cnpj_cpf, observacao, registro, nota) values (@codigo, @nome,@endereco,@bairro,@cidade,@estado,@cep,@telefone,@telefone1,@representante,@cpf,@observacao,@registro,@nota);";

                comando.Parameters.AddWithValue("codigo", codigo);
                comando.Parameters.AddWithValue("nome", nome);
                comando.Parameters.AddWithValue("endereco", endereco);
                comando.Parameters.AddWithValue("bairro", bairro);
                comando.Parameters.AddWithValue("cidade", cidade);
                comando.Parameters.AddWithValue("estado", estado);
                comando.Parameters.AddWithValue("cep", cep);
                comando.Parameters.AddWithValue("telefone", telefone1);
                comando.Parameters.AddWithValue("telefone1", telefone2);
                comando.Parameters.AddWithValue("cpf", cnpjCpf);
                comando.Parameters.AddWithValue("observacao", observacao);
                comando.Parameters.AddWithValue("registro", registro);
                comando.Parameters.AddWithValue("nota", nota);
                comando.Parameters.AddWithValue("representante", representante);


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


        }/////////////////////////////////////////
        /// <summary>
        /// Verifica se tem Atualização Disponivel
        /// </summary>
        public void TotalLinhasAtualizacao()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(codigo) as total FROM tb_atualizacao_fornecedor; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasFornecedorRegistro = int.Parse(reader["total"].ToString());
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
        }/////////////////////////////
        /// <summary>
        /// Identifica o Codigo do Fornecedor que foi Alterado
        /// </summary>
        public void FornecedorAlterado()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * FROM tb_atualizacao_fornecedor order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    codigoFornecedorAtualizado = int.Parse(reader["codigo_fornecedor"].ToString());
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
        /// <summary>
        /// Busca dados do Fornecedor e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosFornecedorMySql(int x)
        {

            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_fornecedor where Codigo = @codigo;";
                comando.Parameters.AddWithValue("codigo", x);

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                        codigo = reader["codigo"].ToString();
                        nome = reader["nome"].ToString();
                        endereco = reader["endereco"].ToString();
                        bairro = reader["bairro"].ToString();
                        cidade = reader["cidade"].ToString();
                        estado = reader["estado"].ToString();
                        cep = reader["cep"].ToString();
                        telefone1 = reader["telefone"].ToString();
                        telefone2 = reader["telefone1"].ToString();
                        cnpjCpf = reader["cnpj_cpf"].ToString();
                        observacao = reader["observacao"].ToString();
                        registro = reader["registro"].ToString();
                        nota = reader["nota"].ToString();
                        representante = reader["representante"].ToString();




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

        }////////////////////////////////
        /// <summary>
        /// Exibe dados da tabela tb_forncedor no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridMySql(DataGridView dataGridView)
        {
            try
            {
                string strgComando = "select * from tb_fornecedor;";

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
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

        }/////////////////
        /// <summary>
        /// Retorna Total de linhas tb_fornecedor
        /// </summary>
        public void TotalLinhasFornecedor()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(codigo) as total FROM tb_fornecedor; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasFornecedorMySql = int.Parse(reader["total"].ToString());
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
        }///////////////////////////
        /// <summary>
        /// Busca dados do ultimo fornecedor e grava dados no Obj
        /// </summary>
        public void UltimoCodigoFornecedor()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_fornecedor order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                        codigo = reader["codigo"].ToString();
                        nome = reader["nome"].ToString();
                        endereco = reader["endereco"].ToString();
                        bairro = reader["bairro"].ToString();
                        cidade = reader["cidade"].ToString();
                        estado = reader["estado"].ToString();
                        cep = reader["cep"].ToString();
                        telefone1 = reader["telefone"].ToString();
                        telefone2 = reader["telefone1"].ToString();
                        cnpjCpf = reader["cnpj_cpf"].ToString();
                        observacao = reader["observacao"].ToString();
                        registro = reader["registro"].ToString();
                        nota = reader["nota"].ToString();
                        representante = reader["representante"].ToString();




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
        }////////////////////////////////







        //tabela fornecedor codigo

        /// <summary>
        /// Insere novos dados na tabela tb_fornecedor_codigo
        /// </summary>
        public void InserirDadosFornecedorCodigo()
        {

            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_fornecedor_codigo ( codigo_codigo, nome_codigo, cnpj_codigo) values (@codigo_codigo, @nome_codigo, @cnpj_codigo);";

                comando.Parameters.AddWithValue("codigo_codigo", codigoCodigo);
                comando.Parameters.AddWithValue("nome_codigo", nomeCodigo);
                comando.Parameters.AddWithValue("cnpj_codigo", cnpjCodigo);
               


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


        }/////////////////////////////////////////
        /// <summary>
        /// Busca dados do ultimo fornecedorCodigo e grava dados no Obj
        /// </summary>
        public void UltimoCodigoFornecedorCodigo()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_fornecedor_codigo order by id desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome_codigo"] != null)
                    {
                       
                        codigoCodigo = reader["codigo_codigo"].ToString();
                        nomeCodigo = reader["nome_codigo"].ToString();
                        cnpjCodigo = reader["cnpj_codigo"].ToString();

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
        }////////////////////////////////////////
        /// <summary>
        /// Retorna Total de linhas tb_fornecedor_codigo
        /// </summary>
        public void TotalLinhasFornecedorCodigo()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(id) as total FROM tb_fornecedor_codigo; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasFornecedorCodigoMySql = int.Parse(reader["total"].ToString());
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
        }///////////////////////////


        //tabela atualização de fornecedor Delete
        /// <summary>
        /// Retorna Total de linhas tb_atualizacao_fornecedor_codigo
        /// </summary>
        public void TotalLinhasFornecedorCodigoDelete()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(id) as total FROM tb_atualizacao_fornecedor_codigo; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasFornecedorCodigoDeleteMySql = int.Parse(reader["total"].ToString());
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
        /// Buscar id do fornecedor codigo deletado
        /// </summary>
        public void UltimoIdFornecedorCodigoDelete()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_atualizacao_fornecedor_codigo order by id desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["cpf_codigo"] != null)
                    {
                        cnpjCodigo = reader["cpf_codigo"].ToString();
                    }

                }
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
