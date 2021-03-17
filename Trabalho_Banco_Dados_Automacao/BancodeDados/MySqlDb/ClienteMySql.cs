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
    class ClienteMySql
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
        public object pontoReferencia;
        public object cor;
        public object lado;
        public object posicao;
        public object ruaEntrada;
        public object dataNascimento;

        public int codigoClienteAtualizado;
        public int totalLinhasClienteRegistro;
        public int totalLinhasClienteMySql;
       




        /// <summary>
        /// Reseta e deleta os dados na tabela tb_cliente
        /// </summary>
        public void TruncateTable()
        {
            try
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "truncate table tb_cliente;";
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
        /// Insere novos dados na tabela tb_cliente
        /// </summary>
        public void InserirDados()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_cliente ( codigo, nome, endereco, bairro, cidade, estado, cep, telefone, telefone1, cnpj_cpf, ponto_referencia, cor, lado, posicao, rua_entrada, data_nascimento ) values (@codigo, @nome,@endereco,@bairro,@cidade,@estado,@cep,@telefone,@telefone1,@cpf,@pontoReferencia,@cor,@lado,@posicao,@ruaEntrada,@dataNascimento);";

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
                comando.Parameters.AddWithValue("pontoReferencia", pontoReferencia);
                comando.Parameters.AddWithValue("cor", cor);
                comando.Parameters.AddWithValue("lado", lado);
                comando.Parameters.AddWithValue("posicao", posicao);
                comando.Parameters.AddWithValue("ruaEntrada", ruaEntrada);
                comando.Parameters.AddWithValue("dataNascimento", dataNascimento);
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
                comando.CommandText = "select count(codigo) as total FROM tb_atualizacao_cliente; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasClienteRegistro = int.Parse(reader["total"].ToString());
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
        /// Identifica o Codigo do Cliente que foi Alterado
        /// </summary>
        public void ClienteAlterado()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * FROM tb_atualizacao_cliente order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    codigoClienteAtualizado = int.Parse(reader["codigo_cliente"].ToString());
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
        /// Busca dados do cliente e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosClientesMySql(int x)
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
                    if (reader["nome"] != null)
                    {

                        nome = reader["nome"].ToString();
                        endereco = reader["endereco"].ToString();
                        bairro = reader["bairro"].ToString();
                        cidade = reader["cidade"].ToString();
                        estado = reader["estado"].ToString();
                        cep = reader["cep"].ToString();
                        telefone1 = reader["telefone"].ToString();
                        telefone2 = reader["telefone1"].ToString();
                        cnpjCpf = reader["cnpj_cpf"].ToString();
                        pontoReferencia = reader["ponto_referencia"].ToString();
                        lado = reader["lado"].ToString();
                        posicao = reader["posicao"].ToString();
                        cor = reader["cor"].ToString();
                        dataNascimento = reader["data_nascimento"].ToString();
                        ruaEntrada = reader["rua_entrada"].ToString();



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
        /// Exibe dados da tabela tb_cliente no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridMySql(DataGridView dataGridView)
        {
            try
            {
                string strgComando = "select * from tb_cliente;";

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
        /// Retorna Total de linhas tb_cliente
        /// </summary>
        public void TotalLinhasClientes()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select codigo as 'total' FROM tb_cliente order by codigo desc limit 1; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasClienteMySql = int.Parse(reader["total"].ToString());
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
        /// Busca dados do ultimo cliente e grava dados no Obj
        /// </summary>
        public void UltimoCodigoCliente()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_cliente order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                        codigo= reader["codigo"].ToString();
                        nome = reader["nome"].ToString();
                        endereco = reader["endereco"].ToString();
                        bairro = reader["bairro"].ToString();
                        cidade = reader["cidade"].ToString();
                        estado = reader["estado"].ToString();
                        cep = reader["cep"].ToString();
                        telefone1 = reader["telefone"].ToString();
                        telefone2 = reader["telefone1"].ToString();
                        cnpjCpf = reader["cnpj_cpf"].ToString();
                        pontoReferencia = reader["ponto_referencia"].ToString();
                        lado = reader["lado"].ToString();
                        posicao = reader["posicao"].ToString();
                        cor = reader["cor"].ToString();
                        dataNascimento = reader["data_nascimento"].ToString();



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







    }
}
