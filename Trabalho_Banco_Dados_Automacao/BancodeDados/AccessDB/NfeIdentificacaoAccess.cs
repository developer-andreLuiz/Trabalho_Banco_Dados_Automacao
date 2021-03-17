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
    class NfeIdentificacaoAccess
    {
        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        #region Variaveis

        public object ID;
        public object CNPJ;
        public object COD_FORNECEDOR;
        public object nom_fornecedor;
        public object cUF;
        public object cNF;
        public object natOp;
        public object indPad;
        public object mod;
        public object serie;
        public object nNF;
        public object indpres;
        public object indfinal;
        public object iddest;
        public object dhCont;
        public object dEmi;
        public object dSaiEnt;
        public object hSaiEnt;
        public object tpNF;
        public object cMunFG;
        public object dhsaient;
        public object tpImp;
        public object tpEmis;
        public object dhemi;
        public object cDV;
        public object tpAmb;
        public object finNFe;
        public object procEmi;
        public object verProc;
        public object vBC;
        public object vICMS;
        public object vBCST;
        public object vST;
        public object vProd;
        public object vFrete;
        public object vSeg;
        public object vDesc;
        public object vII;
        public object xJust;
        public object vIPI;
        public object vPIS;
        public object vCOFINS;
        public object vOutro;
        public object vNF;
        public object vTotTrib;
        public object ISSQNTOT_vServ;
        public object ISSQNTOT_vBC;
        public object ISSQNTOT_vISS;
        public object ISSQNTOT_vPIS;
        public object ISSQNTOT_vCOFINS;
        public object FAT_nFat;
        public object FAT_vOrig;
        public object FAT_vDesc;
        public object FAT_vLiq;
        public object num;
        public object Comfer;
        public object Nota_Br;
        public object Iguala_Nota;

        public int totalLinhasAccess;

        #endregion


        public void ObjVazio()
        {
            nom_fornecedor = null;

        }

        /// <summary>
        /// Busca dados do NfeIdentificacao e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosNfeIdentificacaoAccess(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from NFeIdentificacaoNota where num = @num;";
                comando.Parameters.AddWithValue("num", x);

                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nom_fornecedor"] != null)
                    {
                        ID = reader["ID"].ToString();
                        CNPJ = reader["CNPJ"].ToString();
                        COD_FORNECEDOR = reader["COD_FORNECEDOR"].ToString();
                        nom_fornecedor = reader["nom_fornecedor"].ToString();
                        cUF = reader["cUF"].ToString();
                        cNF = reader["cNF"].ToString();
                        natOp = reader["natOp"].ToString();
                        indPad = reader["indPag"].ToString();
                        mod = reader["mod"].ToString();
                        serie = reader["serie"].ToString();
                        nNF = reader["nNF"].ToString();
                        indpres = reader["indpres"].ToString();
                        indfinal = reader["indfinal"].ToString();
                        iddest = reader["iddest"].ToString();
                        dhCont = reader["dhCont"].ToString();
                        dEmi = reader["dEmi"].ToString();
                        dSaiEnt = reader["dSaiEnt"].ToString();
                        hSaiEnt = reader["hSaiEnt"].ToString();
                        tpNF = reader["tpNF"].ToString();
                        cMunFG = reader["cMunFG"].ToString();
                        dhsaient = reader["dhsaient"].ToString();
                        tpImp = reader["tpImp"].ToString();
                        tpEmis = reader["tpEmis"].ToString();
                        dhemi = reader["dhemi"].ToString();
                        cDV = reader["cDV"].ToString();
                        tpAmb = reader["tpAmb"].ToString();
                        finNFe = reader["finNFe"].ToString();
                        procEmi = reader["procEmi"].ToString();
                        verProc = reader["verProc"].ToString();
                        vBC = reader["vBC"].ToString();
                        vICMS = reader["vICMS"].ToString();
                        vBCST = reader["vBCST"].ToString();
                        vST = reader["vST"].ToString();
                        vProd = reader["vProd"].ToString();
                        vFrete = reader["vFrete"].ToString();
                        vSeg = reader["vSeg"].ToString();
                        vDesc = reader["vDesc"].ToString();
                        vII = reader["vII"].ToString();
                        xJust = reader["xJust"].ToString();
                        vIPI = reader["vIPI"].ToString();
                        vPIS = reader["vPIS"].ToString();
                        vCOFINS = reader["vCOFINS"].ToString();
                        vOutro = reader["vOutro"].ToString();
                        vNF = reader["vNF"].ToString();
                        vTotTrib = reader["vTotTrib"].ToString();
                        ISSQNTOT_vServ = reader["ISSQNTOT_vServ"].ToString();
                        ISSQNTOT_vBC = reader["ISSQNTOT_vBC"].ToString();
                        ISSQNTOT_vISS = reader["ISSQNTOT_vISS"].ToString();
                        ISSQNTOT_vPIS = reader["ISSQNTOT_vPIS"].ToString();
                        ISSQNTOT_vCOFINS = reader["ISSQNTOT_vCOFINS"].ToString();
                        FAT_nFat = reader["FAT_nFat"].ToString();
                        FAT_vOrig = reader["FAT_vOrig"].ToString();
                        FAT_vDesc = reader["FAT_vDesc"].ToString();
                        FAT_vLiq = reader["FAT_vLiq"].ToString();
                        num = reader["num"].ToString();
                        Comfer = reader["Comfer"].ToString();
                        Nota_Br = reader["Nota_Br"].ToString();
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
        ///  Exibe dados da tabela NfeIdentificacao no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from NFeIdentificacaoNota order by num asc ";
                
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
        /// Retorna Total de linhas NFeIdentificacaoNota
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
                comando.CommandText = " SELECT count (num) from NFeIdentificacaoNota as total";
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasAccess = int.Parse(reader["Expr1000"].ToString());
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
        /// Busca dados ultimo do NfeIdentificacao e grava dados no Obj
        /// </summary>
        /// <param name="x"></param>
        public void BuscarDadosNfeIdentificacaoAccessUltimo()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select TOP 1 * from NFeIdentificacaoNota order by num desc;";


                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nom_fornecedor"] != null)
                    {
                        ID = reader["ID"].ToString(); 
                        CNPJ = reader["CNPJ"].ToString();
                        COD_FORNECEDOR = reader["COD_FORNECEDOR"].ToString();
                        nom_fornecedor = reader["nom_fornecedor"].ToString();
                        cUF = reader["cUF"].ToString();
                        cNF = reader["cNF"].ToString();
                        natOp = reader["natOp"].ToString();
                        indPad = reader["indPag"].ToString();
                        mod = reader["mod"].ToString();
                        serie = reader["serie"].ToString();
                        nNF = reader["nNF"].ToString();
                        indpres = reader["indpres"].ToString();
                        indfinal = reader["indfinal"].ToString();
                        iddest = reader["iddest"].ToString();
                        dhCont = reader["dhCont"].ToString();
                        dEmi = reader["dEmi"].ToString();
                        dSaiEnt = reader["dSaiEnt"].ToString();
                        hSaiEnt = reader["hSaiEnt"].ToString();
                        tpNF = reader["tpNF"].ToString();
                        cMunFG = reader["cMunFG"].ToString();
                        dhsaient = reader["dhsaient"].ToString();
                        tpImp = reader["tpImp"].ToString();
                        tpEmis = reader["tpEmis"].ToString();
                        dhemi = reader["dhemi"].ToString();
                        cDV = reader["cDV"].ToString();
                        tpAmb = reader["tpAmb"].ToString();
                        finNFe = reader["finNFe"].ToString();
                        procEmi = reader["procEmi"].ToString();
                        verProc = reader["verProc"].ToString();
                        vBC = reader["vBC"].ToString();
                        vICMS = reader["vICMS"].ToString();
                        vBCST = reader["vBCST"].ToString();
                        vST = reader["vST"].ToString();
                        vProd = reader["vProd"].ToString();
                        vFrete = reader["vFrete"].ToString();
                        vSeg = reader["vSeg"].ToString();
                        vDesc = reader["vDesc"].ToString();
                        vII = reader["vII"].ToString();
                        xJust = reader["xJust"].ToString();
                        vIPI = reader["vIPI"].ToString();
                        vPIS = reader["vPIS"].ToString();
                        vCOFINS = reader["vCOFINS"].ToString();
                        vOutro = reader["vOutro"].ToString();
                        vNF = reader["vNF"].ToString();
                        vTotTrib = reader["vTotTrib"].ToString();
                        ISSQNTOT_vServ = reader["ISSQNTOT_vServ"].ToString();
                        ISSQNTOT_vBC = reader["ISSQNTOT_vBC"].ToString();
                        ISSQNTOT_vISS = reader["ISSQNTOT_vISS"].ToString();
                        ISSQNTOT_vPIS = reader["ISSQNTOT_vPIS"].ToString();
                        ISSQNTOT_vCOFINS = reader["ISSQNTOT_vCOFINS"].ToString();
                        FAT_nFat = reader["FAT_nFat"].ToString();
                        FAT_vOrig = reader["FAT_vOrig"].ToString();
                        FAT_vDesc = reader["FAT_vDesc"].ToString();
                        FAT_vLiq = reader["FAT_vLiq"].ToString();
                        num = reader["num"].ToString();
                        Comfer = reader["Comfer"].ToString();
                        Nota_Br = reader["Nota_Br"].ToString();
                        Iguala_Nota = reader["Iguala_Nota"].ToString();


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



















    }
}
