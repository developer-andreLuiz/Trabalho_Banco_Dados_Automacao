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
    class ProdutoAccess
    {
        //string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\Banco_Dados\Soft.mdb";
        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

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


        public int totalLinhasProdutosAccess;


        public int totalLinhasProdutosCodigoAccess;



        public object codigoCodigo;
        public object descricaoCodigo;
        public object controleCodigo;
        public object referenciaCodigo;
        public object idCodigo;


        #endregion

        /// <summary>
        /// Insere um novo cadastro no Access
        /// </summary>
        public void InsertAccess()
        {
            //MessageBox.Show("insert no access");
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "insert into Produtos (Referencia, iguala1, Descricao, embalagem, quantidade, CustoUnitario, Margem, ValorVenda, margOnline, valvenda_online, ItensPedido, Codigo, Quant, Numero, Unidade, nome, grama, anulado, colocar, Multiplicar, ValorCesta, MargCesta, Quant_cesta, NumCest, Num, iguala, ValorPromocao, MargPromocao, margAvista, margCartao, margCheque, avista, cartao, cheque, Vender, CD_Balanco, Categoria ,UltimaEntrada, Peso, valCartao, QuantCx, IgualaCx, ChCaixa, Validade, Controle, QuantForn, QuantKg, Cx_Fechada ,Tot_meses, Quant_fardo, Quant_desc, liberar_decer, Quant_Avista) values (@referencia, @iguala1, @descricao, @embalagem, @quantidade, @custoUnitario, @margem, @valorVenda, @margemOnline, @valorVendaOnline, @itensPedido, @codigo, @quant, @numero, @unidade, @nome, @grama, @anulado, @colocar, @multiplicar, @valorCesta, @margemCesta, @quantidadeCesta, @numeroCesta, @num, @iguala, @valorPromocao, @margemPromocao, @margemAvista, @margemCartao, @margemCheque, @avista, @cartao, @cheque, @vender, @cdBalanco, @categoria, @ultimaEntrada, @peso, @valorCartao, @quantidadeCaixa, @igualaCaixa, @chCaixa, @validade, @controle, @quantidadeForn, @quantidadeKg, @cxFechado, @totalMeses, @quantidadeFardo, @quantidadeDescer, @liberarDescer, @quantidadeAvista);";   
           


            OleDbCommand comando = new OleDbCommand(comandoString, conexao);
            
            comando.Parameters.AddWithValue("referencia", referencia);
            comando.Parameters.AddWithValue("iguala1", iguala1);
            comando.Parameters.AddWithValue("descricao", descricao);
            comando.Parameters.AddWithValue("embalagem", embalagem);
            comando.Parameters.AddWithValue("quantidade", quantidade);
            comando.Parameters.AddWithValue("custoUnitario", custoUnitario);
            comando.Parameters.AddWithValue("margem", margem);
            comando.Parameters.AddWithValue("valorVenda", valorVenda);
            comando.Parameters.AddWithValue("margemOnline", margemOnline);
            comando.Parameters.AddWithValue("valorVendaOnline", valorVendaOnline);
            comando.Parameters.AddWithValue("itensPedido", itensPedido);
            comando.Parameters.AddWithValue("codigo", codigo);
            comando.Parameters.AddWithValue("quant", quant);
            comando.Parameters.AddWithValue("numero", numero);
            comando.Parameters.AddWithValue("unidade", unidade);
            comando.Parameters.AddWithValue("nome", nome);
            comando.Parameters.AddWithValue("grama", grama);
            comando.Parameters.AddWithValue("anulado", anulado);
            comando.Parameters.AddWithValue("colocar", colocar);
            comando.Parameters.AddWithValue("multiplicar", multiplicar);
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




            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                if (comando.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("sucesso insert");
                }


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
        ///Reseta e atualiza o banco de dados Access 
        /// </summary>
        public void TruncateTable()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);

            try
            {
                string comandoString = "delete * from  Produtos;";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

                comandoString = "Alter Table Produtos Alter Column Codigo Counter(1, 1);";
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
        /// Busca dados do Produtos e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosProdutosAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Produtos where Codigo = @codigo;";
                comando.Parameters.AddWithValue("codigo", x);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {

                        codigo = reader["Codigo"].ToString();
                        referencia = reader["Referencia"].ToString();
                        iguala1 = reader["iguala1"].ToString();
                        descricao = reader["Descricao"].ToString();
                        embalagem = reader["embalagem"].ToString();
                        quantidade = reader["quantidade"].ToString();
                        custoUnitario = reader["CustoUnitario"].ToString();
                        margem = reader["Margem"].ToString();
                        valorVenda = reader["ValorVenda"].ToString();
                        margemOnline = reader["margOnline"].ToString();
                        valorVendaOnline = reader["valvenda_online"].ToString();
                        itensPedido = reader["ItensPedido"].ToString();
                        quant = reader["Quant"].ToString();
                        numero = reader["Numero"].ToString();
                        unidade = reader["Unidade"].ToString();
                        nome = reader["nome"].ToString();
                        grama = reader["grama"].ToString();
                        anulado = reader["anulado"].ToString();
                        colocar = reader["colocar"].ToString();
                        multiplicar = reader["Multiplicar"].ToString();
                        valorCesta = reader["ValorCesta"].ToString();
                        margemCesta = reader["MargCesta"].ToString();
                        quantidadeCesta = reader["Quant_cesta"].ToString();
                        numeroCesta = reader["NumCest"].ToString();
                        num = reader["Num"].ToString();
                        iguala = reader["iguala"].ToString();
                        valorPromocao = reader["ValorPromocao"].ToString();
                        margemPromocao = reader["MargPromocao"].ToString();
                        margemAvista = reader["margAvista"].ToString();
                        margemCartao = reader["margCartao"].ToString();
                        margemCheque = reader["margCheque"].ToString();
                        avista = reader["avista"].ToString();
                        cartao = reader["cartao"].ToString();
                        cheque = reader["cheque"].ToString();
                        vender = reader["Vender"].ToString();
                        cdBalanco = reader["CD_Balanco"].ToString();
                        categoria = reader["Categoria"].ToString();
                        ultimaEntrada = reader["UltimaEntrada"].ToString();
                        peso = reader["Peso"].ToString();
                        valorCartao = reader["valCartao"].ToString();
                        quantidadeCaixa = reader["QuantCx"].ToString();
                        igualaCaixa = reader["IgualaCx"].ToString();
                        chCaixa = reader["ChCaixa"].ToString();
                        validade = reader["Validade"].ToString();
                        controle = reader["Controle"].ToString();
                        quantidadeForn = reader["QuantForn"].ToString();
                        quantidadeKg = reader["QuantKg"].ToString();
                        cxFechado = reader["Cx_Fechada"].ToString();
                        totalMeses = reader["Tot_meses"].ToString();
                        quantidadeFardo = reader["Quant_fardo"].ToString();
                        quantidadeDescer = reader["Quant_desc"].ToString();
                        liberarDescer = reader["liberar_decer"].ToString();
                        quantidadeAvista = reader["Quant_Avista"].ToString();




                    }
                    else
                    {
                        //MessageBox.Show("id Invalido");
                    }
                }
            }
            catch (Exception a)
            {
              //  MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }
        /// <summary>
        ///  Exibe dados da tabela Produtos no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from Produtos order by Codigo asc ";
               
               
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
        /// Retorna Total de linhas produtos
        /// </summary>
        public void TotalLinhasProdutos()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = " SELECT count (Codigo) from Produtos as total"; 
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasProdutosAccess = int.Parse(reader["Expr1000"].ToString());
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




        // tabela produto codigo
        /// <summary>
        /// Retorna Total de linhas Produto Codigo
        /// </summary>
        public void TotalLinhasProdutoCodigo()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "SELECT count (id) from Prod_Codigo";
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasProdutosCodigoAccess = int.Parse(reader["Expr1000"].ToString());
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
        /// Busca dados do Produto codigo e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosProdutoCodigoAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Prod_Codigo where id = @id;";
                comando.Parameters.AddWithValue("id", idCodigo);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["referencia"] != null)
                    {
                        idCodigo = reader["id"].ToString();
                        codigoCodigo = reader["Codigo"].ToString();
                        descricaoCodigo = reader["descriçao"].ToString();
                        referenciaCodigo = reader["referencia"].ToString();
                        controleCodigo = reader["Controle"].ToString();
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
        /// Insere um novo cadastro no Access Codigo
        /// </summary>
        public void InsertAccessCodigo()
        {

            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "insert into Prod_Codigo ( Codigo, Controle, referencia, descriçao) values (@Codigo, @Controle, @referencia, @descricao);";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);

            comando.Parameters.AddWithValue("Codigo", codigoCodigo);
            comando.Parameters.AddWithValue("Controle", controleCodigo);
            comando.Parameters.AddWithValue("referencia", referenciaCodigo);
            comando.Parameters.AddWithValue("descricao", descricaoCodigo);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();

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
        public void ObjVazio()
        {
            nome = null;

        }
        public void ObjVazioCodigo()
        {
            descricaoCodigo = null;

        }




        /// <summary>
        /// Atualiza o Access partindo do MySql
        /// </summary>
        /// <param name="x"></param>
        public void UpdateAccess(string x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            
            try
            {
                conexao.Open();
                string comandoString = " update Produtos set Referencia = @referencia, iguala1 = @iguala1, Descricao = @descricao, embalagem = @embalagem, quantidade = @quantidade, CustoUnitario = @custoUnitario, Margem = @margem, ValorVenda = @valorVenda, margOnline = @margemOnline, valvenda_online = @valorVendaOnline, ItensPedido = @itensPedido,  Quant = @quant, Numero = @numero, Unidade = @unidade, nome = @nome, grama = @grama, anulado = @anulado, colocar = @colocar, Multiplicar = @multiplicar, ValorCesta = @valorCesta, MargCesta = @margemCesta, Quant_cesta = @quantidadeCesta, NumCest = @numeroCesta, Num = @num, iguala = @iguala, ValorPromocao = @valorPromocao, MargPromocao = @margemPromocao, margAvista = @margemAvista, margCartao = @margemCartao, margCheque = @margemCheque, avista = @avista, cartao = @cartao, cheque = @cheque, Vender = @vender, CD_Balanco = @cdBalanco, Categoria = @categoria, UltimaEntrada = @ultimaEntrada, Peso = @peso, valCartao = @valorCartao, QuantCx = @quantidadeCaixa, IgualaCx = @igualaCaixa, ChCaixa = @chCaixa, Validade = @validade, QuantForn = @quantidadeForn, QuantKg = @quantidadeKg, Cx_Fechada = @cxFechado, Tot_meses = @totalMeses, Quant_fardo = @quantidadeFardo, Quant_desc = @quantidadeDescer,  liberar_decer = @liberarDescer,  Quant_Avista = @quantidadeAvista where Codigo ='" + x + "';";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);
                comando.Parameters.AddWithValue("referencia", referencia);
                comando.Parameters.AddWithValue("iguala1", iguala1);
                comando.Parameters.AddWithValue("descricao", descricao);
                comando.Parameters.AddWithValue("embalagem", embalagem);
                comando.Parameters.AddWithValue("quantidade", quantidade);
                comando.Parameters.AddWithValue("custoUnitario", custoUnitario);
                comando.Parameters.AddWithValue("margem", margem);
                comando.Parameters.AddWithValue("valorVenda", valorVenda);
                comando.Parameters.AddWithValue("margemOnline", margemOnline);
                comando.Parameters.AddWithValue("valorVendaOnline", valorVendaOnline);
                comando.Parameters.AddWithValue("itensPedido", itensPedido);
                comando.Parameters.AddWithValue("quant", quant);
                comando.Parameters.AddWithValue("numero", numero);
                comando.Parameters.AddWithValue("unidade", unidade);
                comando.Parameters.AddWithValue("nome", nome);
                comando.Parameters.AddWithValue("grama", grama);
                comando.Parameters.AddWithValue("anulado", anulado);
                comando.Parameters.AddWithValue("colocar", colocar);
                comando.Parameters.AddWithValue("multiplicar", multiplicar);
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
               // MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        /// <summary>
        /// Atualiza o iguala Access partindo do MySql
        /// </summary>
        /// <param name="x"></param>
        public void UpdateAccessIguala(int x)
        {

            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                conexao.Open();
                string comandoString = " update Produtos set embalagem = @embalagem, Margem = @margem, ValorVenda = @valorVenda, grama = @grama, Multiplicar = @multiplicar, ValorPromocao = @valorPromocao, MargPromocao = @margemPromocao, margAvista = @margemAvista, avista = @avista, Categoria = @categoria, Cx_Fechada = @cxFechado, Quant_Avista = @quantidadeAvista where iguala ="+ x +";";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);
                comando.Parameters.AddWithValue("embalagem", embalagem);
                comando.Parameters.AddWithValue("margem", margem);
                comando.Parameters.AddWithValue("valorVenda", valorVenda);
                comando.Parameters.AddWithValue("grama", grama);
                comando.Parameters.AddWithValue("multiplicar", multiplicar);
                comando.Parameters.AddWithValue("valorPromocao", valorPromocao);
                comando.Parameters.AddWithValue("margemPromocao", margemPromocao);
                comando.Parameters.AddWithValue("margemAvista", margemAvista);
                comando.Parameters.AddWithValue("avista", avista);
                comando.Parameters.AddWithValue("categoria", categoria);
                comando.Parameters.AddWithValue("cxFechado", cxFechado);
                comando.Parameters.AddWithValue("quantidadeAvista", quantidadeAvista);
                comando.ExecuteNonQuery();
               
            }
            catch (Exception a)
            {
              //  MessageBox.Show("Erro iguala"+a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        /// <summary>
        /// Atualiza o iguala Access partindo do MySql
        /// </summary>
        /// <param name="x"></param>
        public void UpdateAccessIgualaFardo(int x)
        {
            float tempMargem = float.Parse(margem.ToString());
            float tempvalorVenda = float.Parse(valorVenda.ToString());
            float tempvalorPromocao = float.Parse(valorPromocao.ToString());
            float tempmargemPromocao = float.Parse(margemPromocao.ToString());
            float tempmargemAvista = float.Parse(margemAvista.ToString());
            float tempavista = float.Parse(avista.ToString());
            bool tempMultiplicar = bool.Parse(multiplicar.ToString());
            bool tempcxFechado = bool.Parse(cxFechado.ToString());

            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                conexao.Open();
                string comandoString = " update Produtos set embalagem = @embalagem, Margem = @margem, ValorVenda = @valorVenda, grama = @grama, Multiplicar = @multiplicar, ValorPromocao = @valorPromocao, MargPromocao = @margemPromocao, margAvista = @margemAvista, avista = @avista, Categoria = @categoria, Cx_Fechada = @cxFechado where iguala =" + x + ";";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);
                comando.Parameters.AddWithValue("embalagem", embalagem);
                comando.Parameters.AddWithValue("margem", tempMargem);
                comando.Parameters.AddWithValue("valorVenda", tempvalorVenda);
                comando.Parameters.AddWithValue("grama", grama);
                comando.Parameters.AddWithValue("multiplicar", tempMultiplicar);
                comando.Parameters.AddWithValue("valorPromocao", tempvalorPromocao);
                comando.Parameters.AddWithValue("margemPromocao", tempmargemPromocao);
                comando.Parameters.AddWithValue("margemAvista", tempmargemAvista);
                comando.Parameters.AddWithValue("avista", tempavista);
                comando.Parameters.AddWithValue("categoria", categoria);
                comando.Parameters.AddWithValue("cxFechado", tempcxFechado);
                if (comando.ExecuteNonQuery() > 0)
                {
                  //  MessageBox.Show("iguala Fardo");
                }
            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro iguala Fardo" + a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }




        /// <summary>
        /// Busca dados do Produtos e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosProdutosCxAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select Top 1 * from Produtos where IgualaCx = " +x+ " order by CustoUnitario desc ;";
                

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                        codigo = reader["Codigo"].ToString();
                        iguala = reader["iguala"].ToString();
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
        /// Atualiza o iguala Access partindo do MySql
        /// </summary>
        /// <param name="x"></param>
        public void UpdateAccessIgualaCx(string x, int quant)
        {

            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                conexao.Open();
                string comandoString = " update  Produtos set  Margem = @margem, ValorVenda = @valorVenda, ValorPromocao = @valorPromocao, MargPromocao = @margemPromocao, margAvista = @margemAvista, avista = @avista, Categoria = @categoria where Codigo ='" + x + "';";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);
               
                comando.Parameters.AddWithValue("margem", margem);
                comando.Parameters.AddWithValue("valorVenda", quant * float.Parse(valorVenda.ToString()));
                comando.Parameters.AddWithValue("valorPromocao", quant * float.Parse(valorPromocao.ToString()));
                comando.Parameters.AddWithValue("margemPromocao", margemPromocao);
                comando.Parameters.AddWithValue("margemAvista", margemAvista);
                comando.Parameters.AddWithValue("avista", quant * float.Parse(avista.ToString()));
                comando.Parameters.AddWithValue("categoria", categoria);

                if(comando.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("iguala cx");
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
        ///Deletar Produto Codigo
        /// </summary>
        public void DeleteProdutoCodigo(string referenciaCodigo)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "DELETE FROM Prod_Codigo where referencia = @referencia;";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);
            comando.Parameters.AddWithValue("referencia", referenciaCodigo);

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
