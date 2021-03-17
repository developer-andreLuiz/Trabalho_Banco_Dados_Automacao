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
    class NfEProdutosAccess
    {
        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        #region variaveis 

        public object auto;
        public object ID;
        public object cnpj;
        public object Item;
        public object COD_FORNECEDOR;
        public object cod_produto;
        public object cProd;
        public object xProd;
        public object cEAN;
        public object NCM;
        public object CFOP;
        public object uCom;
        public object QtdProdCompra;
        public object vUnCom;
        public object vProd;
        public object cEANTrib;
        public object uTrib;
        public object qTrib;
        public object vUnTrib;
        public object vDesc;
        public object vOutro;
        public object vFrete;
        public object vSeg;
        public object ICMS_orig;
        public object ICMS_CST;
        public object ICMS_CSOSN;
        public object ICMS_pCredSN;
        public object ICMS_vCredICMSSN;
        public object ICMS_modBC;
        public object ICMS_pRedBC;
        public object ICMS_vBC;
        public object ICMS_pICMS;
        public object ICMS_vICMS;
        public object ICMS_modBCST;
        public object ICMS_pMVAST;
        public object ICMS_pRedBCST;
        public object ICMS_vBCST;
        public object ICMS_pICMSST;
        public object ICMS_vICMSST;
        public object ICMS_motDesICMS;
        public object ICMS_vBCSTRet;
        public object ICMS_vICMSSTRet;
        public object IPI_clEnq;
        public object IPI_CNPJProd;
        public object IPI_cSelo;
        public object IPI_qSelo;
        public object IPI_cEnq;
        public object IPI_CST;
        public object IPI_vBC;
        public object IPI_pIPI;
        public object IPI_qUnid;
        public object IPI_vUnid;
        public object IPI_vIPI;
        public object II_vBC;
        public object II_vDespAdu;
        public object II_vII;
        public object II_vIOF;
        public object PIS_CST;
        public object PIS_vBC;
        public object PIS_pPIS;
        public object PIS_vPIS;
        public object PIS_qBCProd;
        public object PIS_vAliqProd;
        public object COFINS_CST;
        public object COFINS_vBC;
        public object COFINS_pCOFINS;
        public object COFINS_vCOFINS;
        public object COFINS_qBCProd;
        public object COFINS_vAliqProd;
        public object ISSQN_vBC;
        public object vAliq;
        public object vISSQN;
        public object cMunFG;
        public object cListServ;
        public object cSitTrib;
        public object Codigo;
        public object Bipado;
        public object Iguala_Nota;

        public int totalLinhasAccess;
      



        #endregion

        public void ObjVazio()
        {
            ID = null;

        }

        /// <summary>
        /// Busca dados do NfEProdutos e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosNfEProdutosAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from NFeProdutos where auto = @auto;";
                comando.Parameters.AddWithValue("auto", x);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["ID"] != null)
                    {
                        auto = reader["auto"].ToString();
                        ID = reader["ID"].ToString();
                        cnpj = reader["cnpj"].ToString();
                        Item = reader["Item"].ToString();
                        COD_FORNECEDOR = reader["COD_FORNECEDOR"].ToString();
                        cod_produto = reader["cod_produto"].ToString();
                        cProd = reader["cProd"].ToString();
                        xProd = reader["xProd"].ToString();
                        cEAN = reader["cEAN"].ToString();
                        NCM = reader["NCM"].ToString();
                        CFOP = reader["CFOP"].ToString();
                        uCom = reader["uCom"].ToString();
                        QtdProdCompra = reader["QtdProdCompra"].ToString();
                        vUnCom = reader["vUnCom"].ToString();
                        vProd = reader["vProd"].ToString();
                        cEANTrib = reader["cEANTrib"].ToString();
                        uTrib = reader["uTrib"].ToString();
                        qTrib = reader["qTrib"].ToString();
                        vUnTrib = reader["vUnTrib"].ToString();
                        vDesc = reader["vDesc"].ToString();
                        vOutro = reader["vOutro"].ToString();
                        vFrete = reader["vFrete"].ToString();
                        vSeg = reader["vSeg"].ToString();
                        ICMS_orig = reader["ICMS_orig"].ToString();
                        ICMS_CST = reader["ICMS_CST"].ToString();
                        ICMS_CSOSN = reader["ICMS_CSOSN"].ToString();
                        ICMS_pCredSN = reader["ICMS_pCredSN"].ToString();
                        ICMS_vCredICMSSN = reader["ICMS_vCredICMSSN"].ToString();
                        ICMS_modBC = reader["ICMS_modBC"].ToString();
                        ICMS_pRedBC = reader["ICMS_pRedBC"].ToString();
                        ICMS_vBC = reader["ICMS_vBC"].ToString();
                        ICMS_pICMS = reader["ICMS_pICMS"].ToString();
                        ICMS_vICMS = reader["ICMS_vICMS"].ToString();
                        ICMS_modBCST = reader["ICMS_modBCST"].ToString();
                        ICMS_pMVAST = reader["ICMS_pMVAST"].ToString();
                        ICMS_pRedBCST = reader["ICMS_pRedBCST"].ToString();
                        ICMS_vBCST = reader["ICMS_vBCST"].ToString();
                        ICMS_pICMSST = reader["ICMS_pICMSST"].ToString();
                        ICMS_vICMSST = reader["ICMS_vICMSST"].ToString();
                        ICMS_motDesICMS = reader["ICMS_motDesICMS"].ToString();
                        ICMS_vBCSTRet = reader["ICMS_vBCSTRet"].ToString();
                        ICMS_vICMSSTRet = reader["ICMS_vICMSSTRet"].ToString();
                        IPI_clEnq = reader["IPI_clEnq"].ToString();
                        IPI_CNPJProd = reader["IPI_CNPJProd"].ToString();
                        IPI_cSelo = reader["IPI_cSelo"].ToString();
                        IPI_qSelo = reader["IPI_qSelo"].ToString();
                        IPI_cEnq = reader["IPI_cEnq"].ToString();
                        IPI_CST = reader["IPI_CST"].ToString();
                        IPI_vBC = reader["IPI_vBC"].ToString();
                        IPI_pIPI = reader["IPI_pIPI"].ToString();
                        IPI_qUnid = reader["IPI_qUnid"].ToString();
                        IPI_vUnid = reader["IPI_vUnid"].ToString();
                        IPI_vIPI = reader["IPI_vIPI"].ToString();
                        II_vBC = reader["II_vBC"].ToString();
                        II_vDespAdu = reader["II_vDespAdu"].ToString();
                        II_vII = reader["II_vII"].ToString();
                        II_vIOF = reader["II_vIOF"].ToString();
                        PIS_CST = reader["PIS_CST"].ToString();
                        PIS_vBC = reader["PIS_vBC"].ToString();
                        PIS_pPIS = reader["PIS_pPIS"].ToString();
                        PIS_vPIS = reader["PIS_vPIS"].ToString();
                        PIS_qBCProd = reader["PIS_qBCProd"].ToString();
                        PIS_vAliqProd = reader["PIS_vAliqProd"].ToString();
                        COFINS_CST = reader["COFINS_CST"].ToString();
                        COFINS_vBC = reader["COFINS_vBC"].ToString();
                        COFINS_pCOFINS = reader["COFINS_pCOFINS"].ToString();
                        COFINS_vCOFINS = reader["COFINS_vCOFINS"].ToString();
                        COFINS_qBCProd = reader["COFINS_qBCProd"].ToString();
                        COFINS_vAliqProd = reader["COFINS_vAliqProd"].ToString();
                        ISSQN_vBC = reader["ISSQN_vBC"].ToString();
                        vAliq = reader["vAliq"].ToString();
                        vISSQN = reader["vISSQN"].ToString();
                        cMunFG = reader["cMunFG"].ToString();
                        cListServ = reader["cListServ"].ToString();
                        cSitTrib = reader["cSitTrib"].ToString();
                        Codigo = reader["Codigo"].ToString();
                        Bipado = reader["Bipado"].ToString();
                        Iguala_Nota = reader["Iguala_Nota"].ToString();




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
        ///  Exibe dados da tabela NfEProdutos no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from NFeProdutos order by auto asc ";

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
              //  MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }




        }

        /// <summary>
        /// Retorna Total de linhas NfEProdutos
        /// </summary>
        public void TotalLinhasAccess()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = " SELECT count (auto) from NFeProdutos as total";
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasAccess = int.Parse(reader["Expr1000"].ToString());
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
        /// Busca dados ultimo do NFeProdutos e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosNFeProdutosAccessUltimo()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select TOP 1 * from NFeProdutos order by auto desc;";


                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["ID"] != null)
                    {
                        auto = reader["auto"].ToString();
                        ID = reader["ID"].ToString();
                        cnpj = reader["cnpj"].ToString();
                        Item = reader["Item"].ToString();
                        COD_FORNECEDOR = reader["COD_FORNECEDOR"].ToString();
                        cod_produto = reader["cod_produto"].ToString();
                        cProd = reader["cProd"].ToString();
                        xProd = reader["xProd"].ToString();
                        cEAN = reader["cEAN"].ToString();
                        NCM = reader["NCM"].ToString();
                        CFOP = reader["CFOP"].ToString();
                        uCom = reader["uCom"].ToString();
                        QtdProdCompra = reader["QtdProdCompra"].ToString();
                        vUnCom = reader["vUnCom"].ToString();
                        vProd = reader["vProd"].ToString();
                        cEANTrib = reader["cEANTrib"].ToString();
                        uTrib = reader["uTrib"].ToString();
                        qTrib = reader["qTrib"].ToString();
                        vUnTrib = reader["vUnTrib"].ToString();
                        vDesc = reader["vDesc"].ToString();
                        vOutro = reader["vOutro"].ToString();
                        vFrete = reader["vFrete"].ToString();
                        vSeg = reader["vSeg"].ToString();
                        ICMS_orig = reader["ICMS_orig"].ToString();
                        ICMS_CST = reader["ICMS_CST"].ToString();
                        ICMS_CSOSN = reader["ICMS_CSOSN"].ToString();
                        ICMS_pCredSN = reader["ICMS_pCredSN"].ToString();
                        ICMS_vCredICMSSN = reader["ICMS_vCredICMSSN"].ToString();
                        ICMS_modBC = reader["ICMS_modBC"].ToString();
                        ICMS_pRedBC = reader["ICMS_pRedBC"].ToString();
                        ICMS_vBC = reader["ICMS_vBC"].ToString();
                        ICMS_pICMS = reader["ICMS_pICMS"].ToString();
                        ICMS_vICMS = reader["ICMS_vICMS"].ToString();
                        ICMS_modBCST = reader["ICMS_modBCST"].ToString();
                        ICMS_pMVAST = reader["ICMS_pMVAST"].ToString();
                        ICMS_pRedBCST = reader["ICMS_pRedBCST"].ToString();
                        ICMS_vBCST = reader["ICMS_vBCST"].ToString();
                        ICMS_pICMSST = reader["ICMS_pICMSST"].ToString();
                        ICMS_vICMSST = reader["ICMS_vICMSST"].ToString();
                        ICMS_motDesICMS = reader["ICMS_motDesICMS"].ToString();
                        ICMS_vBCSTRet = reader["ICMS_vBCSTRet"].ToString();
                        ICMS_vICMSSTRet = reader["ICMS_vICMSSTRet"].ToString();
                        IPI_clEnq = reader["IPI_clEnq"].ToString();
                        IPI_CNPJProd = reader["IPI_CNPJProd"].ToString();
                        IPI_cSelo = reader["IPI_cSelo"].ToString();
                        IPI_qSelo = reader["IPI_qSelo"].ToString();
                        IPI_cEnq = reader["IPI_cEnq"].ToString();
                        IPI_CST = reader["IPI_CST"].ToString();
                        IPI_vBC = reader["IPI_vBC"].ToString();
                        IPI_pIPI = reader["IPI_pIPI"].ToString();
                        IPI_qUnid = reader["IPI_qUnid"].ToString();
                        IPI_vUnid = reader["IPI_vUnid"].ToString();
                        IPI_vIPI = reader["IPI_vIPI"].ToString();
                        II_vBC = reader["II_vBC"].ToString();
                        II_vDespAdu = reader["II_vDespAdu"].ToString();
                        II_vII = reader["II_vII"].ToString();
                        II_vIOF = reader["II_vIOF"].ToString();
                        PIS_CST = reader["PIS_CST"].ToString();
                        PIS_vBC = reader["PIS_vBC"].ToString();
                        PIS_pPIS = reader["PIS_pPIS"].ToString();
                        PIS_vPIS = reader["PIS_vPIS"].ToString();
                        PIS_qBCProd = reader["PIS_qBCProd"].ToString();
                        PIS_vAliqProd = reader["PIS_vAliqProd"].ToString();
                        COFINS_CST = reader["COFINS_CST"].ToString();
                        COFINS_vBC = reader["COFINS_vBC"].ToString();
                        COFINS_pCOFINS = reader["COFINS_pCOFINS"].ToString();
                        COFINS_vCOFINS = reader["COFINS_vCOFINS"].ToString();
                        COFINS_qBCProd = reader["COFINS_qBCProd"].ToString();
                        COFINS_vAliqProd = reader["COFINS_vAliqProd"].ToString();
                        ISSQN_vBC = reader["ISSQN_vBC"].ToString();
                        vAliq = reader["vAliq"].ToString();
                        vISSQN = reader["vISSQN"].ToString();
                        cMunFG = reader["cMunFG"].ToString();
                        cListServ = reader["cListServ"].ToString();
                        cSitTrib = reader["cSitTrib"].ToString();
                        Codigo = reader["Codigo"].ToString();
                        Bipado = reader["Bipado"].ToString();
                        Iguala_Nota = reader["Iguala_Nota"].ToString();
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
