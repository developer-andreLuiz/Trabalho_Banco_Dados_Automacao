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
    class ProdutoMySql
    {
        MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

        #region Variaveis da Classe

        public object codigo;
        public object referencia;
        public object iguala1;
        public object descricao;
        public object embalagem;
        public object quantidade;
        public object custoUnitario;
        public object margem;
        public object valorVenda;
        public object margemOnline;
        public object valorVendaOnline;
        public object itensPedido;  //
        public object quant;
        public object numero;
        public object unidade;
        public object nome;
        public object grama;
        public object anulado;  //
        public object colocar;  //
        public object multiplicar;  //
        public object valorCesta;
        public object margemCesta;
        public object quantidadeCesta;
        public object numeroCesta;
        public object num;
        public object iguala;
        public object valorPromocao;
        public object margemPromocao;
        public object margemAvista;
        public object margemCartao;
        public object margemCheque;
        public object avista;
        public object cartao;
        public object cheque;
        public object vender;   //
        public object cdBalanco;    //
        public object categoria;
        public object ultimaEntrada;
        public object peso;
        public object valorCartao;
        public object quantidadeCaixa;
        public object igualaCaixa;
        public object chCaixa;  //
        public object validade;
        public object controle;
        public object quantidadeForn;
        public object quantidadeKg;
        public object cxFechado;    //
        public object totalMeses;
        public object quantidadeFardo;
        public object quantidadeDescer;
        public object liberarDescer;    //
        public object quantidadeAvista;

        public int codigoProdutoAtualizado;
        public int igualaProdutoAtualizado;
        public int igualaCaixaProdutoAtualizado;
        public string chCaixaProdutoAtualizado;

        public object codigoCodigo;
        public object referenciaCodigo;
        public object descricaoCodigo;
        public object controleCodigo;



        public int totalLinhasProdutoRegistro;
        public int totalLinhasProdutoMySql;
        public int totalLinhasProdutoCodigoMySql;
        public int quantUniAtualizado;
        public int totalLinhasProdutosCodigoDeleteMySql;

        #endregion
        
        /// <summary>
        /// Reseta e deleta os dados na tabela tb_produtos
        /// </summary>
        public void TruncateTable()
        {
            try
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "truncate table tb_produtos;";
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
        /// Insere novos dados na tabela tb_produtos
        /// </summary>
        public void InserirDados()
        {

            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_produtos (codigo, referencia, iguala1, descricao, embalagem, quantidade, custo_unitario, margem, valor_venda, margem_online, valor_venda_online, itens_pedido, quant, numero, unidade, nome, grama, anulado, colocar, multiplicar, valor_cesta, margem_cesta, quantidade_cesta, numero_cesta, num, iguala, valor_promocao, margem_promocao, margem_avista, margem_cartao, margem_cheque, avista, cartao, cheque, vender, cd_balanco, categoria ,ultima_entrada, peso, valor_cartao, quantidade_caixa, iguala_caixa, ch_caixa, validade, controle, quantForn, quantidade_kg, cx_fechado ,total_meses, quantidade_fardo, quantidade_descer, liberar_descer, quantidade_avista) values (@codigo, @referencia, @iguala1, @descricao, @embalagem, @quantidade, @custoUnitario, @margem, @valorVenda, @margemOnline, @valorVendaOnline, @itensPedido, @quant, @numero, @unidade, @nome, @grama, @anulado, @colocar, @multiplicar, @valorCesta, @margemCesta, @quantidadeCesta, @numeroCesta, @num, @iguala, @valorPromocao, @margemPromocao, @margemAvista, @margemCartao, @margemCheque, @avista, @cartao, @cheque, @vender, @cdBalanco, @categoria, @ultimaEntrada, @peso, @valorCartao, @quantidadeCaixa, @igualaCaixa, @chCaixa, @validade, @controle, @quantidadeForn, @quantidadeKg, @cxFechado, @totalMeses, @quantidadeFardo, @quantidadeDescer, @liberarDescer, @quantidadeAvista);";
               

                comando.Parameters.AddWithValue("codigo", codigo);//
                comando.Parameters.AddWithValue("referencia", referencia);//
                comando.Parameters.AddWithValue("iguala1", iguala1);
                comando.Parameters.AddWithValue("descricao", descricao);//
                comando.Parameters.AddWithValue("embalagem", embalagem);//
                comando.Parameters.AddWithValue("quantidade", quantidade);//
                comando.Parameters.AddWithValue("custoUnitario", custoUnitario);//
                comando.Parameters.AddWithValue("margem", margem);//
                comando.Parameters.AddWithValue("valorVenda", valorVenda);//
                comando.Parameters.AddWithValue("margemOnline", margemOnline);
                comando.Parameters.AddWithValue("valorVendaOnline", valorVendaOnline);
                comando.Parameters.AddWithValue("itensPedido", itensPedido);//
                comando.Parameters.AddWithValue("quant", quant);//
                comando.Parameters.AddWithValue("numero", numero);//
                comando.Parameters.AddWithValue("unidade", unidade);//
                comando.Parameters.AddWithValue("nome", nome);//
                comando.Parameters.AddWithValue("grama", grama);//
                comando.Parameters.AddWithValue("anulado", anulado);//
                comando.Parameters.AddWithValue("colocar", colocar);//
                comando.Parameters.AddWithValue("multiplicar", multiplicar);//
                comando.Parameters.AddWithValue("valorCesta", valorCesta);
                comando.Parameters.AddWithValue("margemCesta", margemCesta);
                comando.Parameters.AddWithValue("quantidadeCesta", quantidadeCesta);
                comando.Parameters.AddWithValue("numeroCesta", numeroCesta);
                comando.Parameters.AddWithValue("num", num);
                comando.Parameters.AddWithValue("iguala", iguala);
                comando.Parameters.AddWithValue("valorPromocao", valorPromocao);
                comando.Parameters.AddWithValue("margemPromocao", margemPromocao);
                comando.Parameters.AddWithValue("margemAvista", margemAvista);
                comando.Parameters.AddWithValue("margemCartao", margemCartao);
                comando.Parameters.AddWithValue("margemCheque", margemCheque);
                comando.Parameters.AddWithValue("avista", avista);
                comando.Parameters.AddWithValue("cartao", cartao);
                comando.Parameters.AddWithValue("cheque", cheque);
                comando.Parameters.AddWithValue("vender", vender);
                comando.Parameters.AddWithValue("cdBalanco", cdBalanco);
                comando.Parameters.AddWithValue("categoria", categoria);
                comando.Parameters.AddWithValue("ultimaEntrada", ultimaEntrada);
                comando.Parameters.AddWithValue("peso", peso);
                comando.Parameters.AddWithValue("valorCartao", valorCartao);
                comando.Parameters.AddWithValue("quantidadeCaixa", quantidadeCaixa);
                comando.Parameters.AddWithValue("igualaCaixa", igualaCaixa);
                comando.Parameters.AddWithValue("chCaixa", chCaixa);
                comando.Parameters.AddWithValue("validade", validade);
                comando.Parameters.AddWithValue("controle", controle);
                comando.Parameters.AddWithValue("quantidadeForn", quantidadeForn);
                comando.Parameters.AddWithValue("quantidadeKg", quantidadeKg);
                comando.Parameters.AddWithValue("cxFechado", cxFechado);
                comando.Parameters.AddWithValue("totalMeses", totalMeses);
                comando.Parameters.AddWithValue("quantidadeFardo", quantidadeFardo);
                comando.Parameters.AddWithValue("quantidadeDescer", quantidadeDescer);
                comando.Parameters.AddWithValue("liberarDescer", liberarDescer);
                comando.Parameters.AddWithValue("quantidadeAvista", quantidadeAvista);
              



                comando.ExecuteNonQuery();

            }
            catch (Exception a)
            {

                //MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                comando.CommandText = "select count(codigo) as total FROM tb_atualizacao_produto; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasProdutoRegistro = int.Parse(reader["total"].ToString());
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
        /// Identifica os dados do produto que foi Alterado
        /// </summary>
        public void ProdutoAlterado()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * FROM tb_atualizacao_produto order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    codigoProdutoAtualizado = int.Parse(reader["codigo_produto"].ToString());

                    igualaProdutoAtualizado = int.Parse(reader["iguala"].ToString());

                    igualaCaixaProdutoAtualizado = int.Parse(reader["iguala_caixa"].ToString());

                    chCaixaProdutoAtualizado = reader["ch_caixa"].ToString();

                    try
                    {
                        quantUniAtualizado = int.Parse(reader["numero"].ToString());
                    }
                    catch
                    {
                        quantUniAtualizado = 1;
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
        /// Busca dados do Produto e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosProdutosMySql(int x)
        {

            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_produtos where Codigo = @codigo;";
                comando.Parameters.AddWithValue("codigo", x);

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                       
                        codigo = reader["codigo"].ToString();
                        referencia = reader["referencia"].ToString();
                        iguala1 = reader["iguala1"].ToString();
                        descricao = reader["descricao"].ToString();
                        embalagem = reader["embalagem"].ToString();
                        quantidade = reader["quantidade"].ToString();
                        custoUnitario = reader["custo_unitario"].ToString();
                        margem = reader["margem"].ToString();
                        valorVenda = reader["valor_venda"].ToString();
                        margemOnline = reader["margem_online"].ToString();
                        valorVendaOnline = reader["valor_venda_online"].ToString();
                        itensPedido = reader["itens_pedido"].ToString();
                        quant = reader["quant"].ToString();
                        numero = reader["numero"].ToString();
                        unidade = reader["unidade"].ToString();
                        nome = reader["nome"].ToString();
                        grama = reader["grama"].ToString();
                        anulado = reader["anulado"].ToString();
                        colocar = reader["colocar"].ToString();
                        multiplicar = reader["multiplicar"].ToString();
                        valorCesta = reader["valor_cesta"].ToString();
                        margemCesta = reader["margem_cesta"].ToString();
                        quantidadeCesta = reader["quantidade_cesta"].ToString();
                        numeroCesta = reader["numero_cesta"].ToString();
                        num = reader["num"].ToString();
                        iguala = reader["iguala"].ToString();
                        valorPromocao = reader["valor_promocao"].ToString();
                        margemPromocao = reader["margem_promocao"].ToString();
                        margemAvista = reader["margem_avista"].ToString();
                        margemCartao = reader["margem_cartao"].ToString();
                        margemCheque = reader["margem_cheque"].ToString();
                        avista = reader["avista"].ToString();
                        cartao = reader["cartao"].ToString();
                        cheque = reader["cheque"].ToString();
                        vender = reader["vender"].ToString();
                        cdBalanco = reader["cd_balanco"].ToString();
                        categoria = reader["categoria"].ToString();
                        ultimaEntrada = reader["ultima_entrada"].ToString();
                        peso = reader["peso"].ToString();
                        valorCartao = reader["valor_cartao"].ToString();
                        quantidadeCaixa = reader["quantidade_caixa"].ToString();
                        igualaCaixa = reader["iguala_caixa"].ToString();
                        chCaixa = reader["ch_caixa"].ToString();
                        validade = reader["validade"].ToString();
                        controle = reader["controle"].ToString();
                        quantidadeForn = reader["quantForn"].ToString();
                        quantidadeKg = reader["quantidade_Kg"].ToString();
                        cxFechado = reader["cx_fechado"].ToString();
                        totalMeses = reader["total_meses"].ToString();
                        quantidadeFardo = reader["quantidade_fardo"].ToString();
                        quantidadeDescer = reader["quantidade_descer"].ToString();
                        liberarDescer = reader["liberar_descer"].ToString();
                        quantidadeAvista = reader["quantidade_avista"].ToString();





                    }

                }
            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }
        /// <summary>
        /// Exibe dados da tabela tb_produtos no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridMySql(DataGridView dataGridView)
        {
            try
            {
                string strgComando = "select * from tb_produtos;";

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
                //MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

        }
        /// <summary>
        /// Retorna Total de linhas tb_produtos
        /// </summary>
        public void TotalLinhasProdutos()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(codigo) as total FROM tb_produtos; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasProdutoMySql = int.Parse(reader["total"].ToString());
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
        /// Busca dados do ultimo produto e grava dados no Obj
        /// </summary>
        public void UltimoCodigoProdutos()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_produtos order by codigo desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {

                        codigo = reader["codigo"].ToString();
                        referencia = reader["referencia"].ToString();
                        iguala1 = reader["iguala1"].ToString();
                        descricao = reader["descricao"].ToString();
                        embalagem = reader["embalagem"].ToString();
                        quantidade = reader["quantidade"].ToString();
                        custoUnitario = reader["custo_unitario"].ToString();
                        margem = reader["margem"].ToString();
                        valorVenda = reader["valor_venda"].ToString();
                        margemOnline = reader["margem_online"].ToString();
                        valorVendaOnline = reader["valor_venda_online"].ToString();
                        itensPedido = reader["itens_pedido"].ToString();
                        quant = reader["quant"].ToString();
                        numero = reader["numero"].ToString();
                        unidade = reader["unidade"].ToString();
                        nome = reader["nome"].ToString();
                        grama = reader["grama"].ToString();
                        anulado = reader["anulado"].ToString();
                        colocar = reader["colocar"].ToString();
                        multiplicar = reader["multiplicar"].ToString();
                        valorCesta = reader["valor_cesta"].ToString();
                        margemCesta = reader["margem_cesta"].ToString();
                        quantidadeCesta = reader["quantidade_cesta"].ToString();
                        numeroCesta = reader["numero_cesta"].ToString();
                        num = reader["num"].ToString();
                        iguala = reader["iguala"].ToString();
                        valorPromocao = reader["valor_promocao"].ToString();
                        margemPromocao = reader["margem_promocao"].ToString();
                        margemAvista = reader["margem_avista"].ToString();
                        margemCartao = reader["margem_cartao"].ToString();
                        margemCheque = reader["margem_cheque"].ToString();
                        avista = reader["avista"].ToString();
                        cartao = reader["cartao"].ToString();
                        cheque = reader["cheque"].ToString();
                        vender = reader["vender"].ToString();
                        cdBalanco = reader["cd_balanco"].ToString();
                        categoria = reader["categoria"].ToString();
                        ultimaEntrada = reader["ultima_entrada"].ToString();
                        peso = reader["peso"].ToString();
                        valorCartao = reader["valor_cartao"].ToString();
                        quantidadeCaixa = reader["quantidade_caixa"].ToString();
                        igualaCaixa = reader["iguala_caixa"].ToString();
                        chCaixa = reader["ch_caixa"].ToString();
                        validade = reader["validade"].ToString();
                        controle = reader["controle"].ToString();
                        quantidadeForn = reader["quantForn"].ToString();
                        quantidadeKg = reader["quantidade_Kg"].ToString();
                        cxFechado = reader["cx_fechado"].ToString();
                        totalMeses = reader["total_meses"].ToString();
                        quantidadeFardo = reader["quantidade_fardo"].ToString();
                        quantidadeDescer = reader["quantidade_descer"].ToString();
                        liberarDescer = reader["liberar_descer"].ToString();
                        quantidadeAvista = reader["quantidade_avista"].ToString();

                    }

                }
            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }
        }

        //tabela produto codigo
        /// <summary>
        /// Insere novos dados na tabela tb_produto_codigo
        /// </summary>
        public void InserirDadosProdutoCodigo()
        {

            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_produto_codigo ( referencia_codigo, codigo_codigo, descricao_codigo, controle) values (@referencia_codigo, @codigo_codigo, @descricao_codigo, @controle_codigo);";

                comando.Parameters.AddWithValue("referencia_codigo", referenciaCodigo);
                comando.Parameters.AddWithValue("codigo_codigo", codigoCodigo);
                comando.Parameters.AddWithValue("descricao_codigo", descricaoCodigo);
                comando.Parameters.AddWithValue("controle_codigo", controleCodigo);



                comando.ExecuteNonQuery();

            }
            catch (Exception a)
            {

                //MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();

            }


        }
        /// <summary>
        /// Busca dados do ultimo ProdutoCodigo e grava dados no Obj
        /// </summary>
        public void UltimoCodigoProdutoCodigo()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_produto_codigo order by id desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["referencia_codigo"] != null)
                    {

                        referenciaCodigo = reader["referencia_codigo"].ToString();
                        codigoCodigo = reader["codigo_codigo"].ToString();
                        descricaoCodigo = reader["descricao_codigo"].ToString();

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
        /// Retorna Total de linhas tb_produto_codigo
        /// </summary>
        public void TotalLinhasProdutosCodigo()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(id) as total FROM tb_produto_codigo; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasProdutoCodigoMySql = int.Parse(reader["total"].ToString());
                }


            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }
        }


        //tabela atualização de Produto Delete
        /// <summary>
        /// Retorna Total de linhas tb_atualizacao_Produto_codigo
        /// </summary>
        public void TotalLinhasProdutoCodigoDelete()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(id) as total FROM tb_atualizacao_produto_codigo; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasProdutosCodigoDeleteMySql = int.Parse(reader["total"].ToString());
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
        /// <summary>
        /// Buscar id do Produto codigo deletado
        /// </summary>
        public void UltimoIdProdutoCodigoDelete()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from tb_atualizacao_produto_codigo order by id desc limit 1;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["referencia_codigo"] != null)
                    {
                        referenciaCodigo = reader["referencia_codigo"].ToString();
                    }

                }
            }
            catch { }
            finally
            {
                conexao.Close();
            }
        }
    }
}
