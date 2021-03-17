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
    class FuncionarioMySql
    {
        
        MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

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
        public object salario;
        public object dataAdmissao;



        public int codigoFuncionarioAtualizado;
        public int totalLinhasFuncionarioRegistro;
        public int totalLinhasFuncionarioMySql;
        
        /// <summary>
            /// Reseta e deleta os dados na tabela tb_funcionario
            /// </summary>
        public void TruncateTable()
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = conexao.CreateCommand();
                    comando.CommandText = "truncate table tb_funcionario;";
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

            }//
      
        /// <summary>
        /// Insere novos dados na tabela tb_funcionario
        /// </summary>
        public void InserirDados()
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = conexao.CreateCommand();
                    comando.CommandText = "insert into tb_funcionario (codigo, nome, senha, habilitado, nivel, cargo, endereco, bairro, cidade, telefone,telefone1,compras,observacao,apagador,senha_acesso,salario,data_admissao) values (@codigo,@nome,@senha,@habilitado,@nivel,@cargo,@endereco,@bairro,@cidade,@telefone,@telefone1,@compras,@observacao,@apagador,@senhaAcesso,@salario,@dataAdmissao);";
                    comando.Parameters.AddWithValue("codigo", codigo);
                    comando.Parameters.AddWithValue("nome", nome);
                    comando.Parameters.AddWithValue("senha", senha);
                    comando.Parameters.AddWithValue("habilitado", habilitado);
                    comando.Parameters.AddWithValue("nivel", nivel);
                    comando.Parameters.AddWithValue("cargo", cargo);
                    comando.Parameters.AddWithValue("endereco", endereco);
                    comando.Parameters.AddWithValue("bairro", bairro);
                    comando.Parameters.AddWithValue("cidade", cidade);
                    comando.Parameters.AddWithValue("telefone", telefone1);
                    comando.Parameters.AddWithValue("telefone1", telefone2);
                    comando.Parameters.AddWithValue("compras", compras);
                    comando.Parameters.AddWithValue("observacao", observacao);
                    comando.Parameters.AddWithValue("apagador", apagador);
                    comando.Parameters.AddWithValue("senhaAcesso", senhaAcesso);
                    comando.Parameters.AddWithValue("salario", salario);
                    comando.Parameters.AddWithValue("dataAdmissao", dataAdmissao);

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


            }//

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
                    comando.CommandText = "select count(codigo) as total FROM tb_atualizacao_funcionario; ";
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        totalLinhasFuncionarioRegistro = int.Parse(reader["total"].ToString());
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
            }//

        /// <summary>
        /// Identifica o Codigo do Funcionario que foi Alterado
        /// </summary>
        public void FuncionarioAlterado()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * FROM tb_atualizacao_funcionario order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    codigoFuncionarioAtualizado = int.Parse(reader["codigo_funcionario"].ToString());
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
        }//

        /// <summary>
        /// Busca dados do funcionario e grava dados no Obj
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
                comando.CommandText = "select * from tb_funcionario where Codigo = @codigo;";
                comando.Parameters.AddWithValue("codigo", x);

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {

                        nome = reader["nome"].ToString();
                        compras = reader["compras"].ToString();
                        endereco = reader["endereco"].ToString();
                        bairro = reader["bairro"].ToString();
                        salario = reader["salario"].ToString();
                        cidade = reader["cidade"].ToString();
                        telefone1 = reader["telefone"].ToString();
                        telefone2 = reader["telefone1"].ToString();
                        habilitado = reader["habilitado"].ToString();
                        cargo = reader["Cargo"].ToString();
                        senha = reader["senha"].ToString();
                        senhaAcesso = reader["senha_acesso"].ToString();
                        apagador = reader["apagador"].ToString();
                        nivel = reader["nivel"].ToString();
                        observacao = reader["observacao"].ToString();
                        codigo = reader["codigo"].ToString();
                        dataAdmissao = reader["data_admissao"].ToString();



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

        }//

        /// <summary>
        /// Exibe dados da tabela tb_funcionario no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridMySql(DataGridView dataGridView)
        {
            try
            {
                string strgComando = "select * from tb_funcionario;";

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

        }//

        /// <summary>
        /// Retorna Total de linhas tb_funcionario
        /// </summary>
        public void TotalLinhasFuncionario()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(codigo) as total FROM tb_funcionario; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasFuncionarioMySql = int.Parse(reader["total"].ToString());
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
        }//

        /// <summary>
        /// Busca dados do ultimo funcionario e grava dados no Obj
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
                comando.CommandText = "select * from tb_funcionario order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                        codigo = reader["codigo"].ToString();
                        nome = reader["nome"].ToString();
                        compras = reader["compras"].ToString();
                        endereco = reader["endereco"].ToString();
                        bairro = reader["bairro"].ToString();
                        salario = reader["salario"].ToString();
                        cidade = reader["cidade"].ToString();
                        telefone1 = reader["telefone"].ToString();
                        telefone2 = reader["telefone1"].ToString();
                        habilitado = reader["habilitado"].ToString();
                        cargo = reader["Cargo"].ToString();
                        senha = reader["senha"].ToString();
                        senhaAcesso = reader["senha_acesso"].ToString();
                        apagador = reader["apagador"].ToString();
                        nivel = reader["nivel"].ToString();
                        observacao = reader["observacao"].ToString();
                        dataAdmissao = reader["data_admissao"].ToString();



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
        }//








    }
}
