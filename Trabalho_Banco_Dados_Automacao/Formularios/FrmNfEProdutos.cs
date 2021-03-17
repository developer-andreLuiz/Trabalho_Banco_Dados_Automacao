using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboDataBase.BancodeDados.AccessDB;
using RoboDataBase.BancodeDados.MySqlDb;

namespace RoboDataBase.Formularios
{
    public partial class FrmNfEProdutos : Form
    {
        NfEProdutosAccess oAccess = new NfEProdutosAccess();
        NfEProdutosMySql oMySql = new NfEProdutosMySql();

        public FrmNfEProdutos()
        {
            InitializeComponent();
        }


        #region BtnsAccess

        private void btnBuscarAccess_Click(object sender, EventArgs e)
        {
            oAccess.CarregarDataGridAccess(dataGridViewAccess);
        }

        private void btnMantemAtualizado_Click(object sender, EventArgs e)
        {
            MantemAtualizado();
           
        }

        private void btnInsertAccessforMySQL_Click(object sender, EventArgs e)
        {
            
            oAccess.ObjVazio();
            int rep = 0;
            oAccess.auto = 0;
            while (oAccess.ID == null && rep < 250)
            {
                rep++;
                oAccess.auto = int.Parse(oAccess.auto.ToString()) + 1;
                oAccess.BuscarDadosNfEProdutosAccess(int.Parse(oAccess.auto.ToString()));

                if (oAccess.ID != null)
                {
                    GravarObjMySql();
                    oMySql.InserirDados();
                    oAccess.ObjVazio();
                    rep = 0;
                }

            }

           
            oMySql.CarregarDataGridMySql(dataGridViewMySql);
        }
        
        #endregion

        #region BtnsMySql

        private void btnBuscarMySql_Click(object sender, EventArgs e)
        {
            oMySql.CarregarDataGridMySql(dataGridViewMySql);
        }

        private void btnLimparMySql_Click(object sender, EventArgs e)
        {
            oMySql.TruncateTable();
            oMySql.CarregarDataGridMySql(dataGridViewMySql);
        }

        private void bntAtualizacao_Click(object sender, EventArgs e)
        {
            MantemAtualizado2(); 
        }

        #endregion


        public void GravarObjMySql()
       {

            if (int.TryParse(oAccess.auto.ToString(), out int a) == false)
            {
                oAccess.auto = 0;
            }
            if (int.TryParse(oAccess.cnpj.ToString(), out int b) == false)
            {
                oAccess.cnpj = 0;
            }
            if (int.TryParse(oAccess.Item.ToString(), out int c) == false)
            {
                oAccess.Item = 0;
            }
            if (int.TryParse(oAccess.COD_FORNECEDOR.ToString(), out int d) == false)
            {
                oAccess.COD_FORNECEDOR = 0;
            }
            if (int.TryParse(oAccess.CFOP.ToString(), out int e) == false)
            {
                oAccess.CFOP = 0;
            }
            if (int.TryParse(oAccess.QtdProdCompra.ToString(), out int f) == false)
            {
                oAccess.QtdProdCompra = 0;
            }
            if (int.TryParse(oAccess.ICMS_modBC.ToString(), out int g) == false)
            {
                oAccess.ICMS_modBC = 0;
            }
            if (int.TryParse(oAccess.ICMS_modBCST.ToString(), out int h) == false)
            {
                oAccess.ICMS_modBCST = 0;
            }
            if (int.TryParse(oAccess.ICMS_motDesICMS.ToString(), out int i) == false)
            {
                oAccess.ICMS_motDesICMS = 0;
            }
            if (int.TryParse(oAccess.ICMS_vICMSSTRet.ToString(), out int j) == false)
            {
                oAccess.ICMS_vICMSSTRet = 0;
            }
            if (int.TryParse(oAccess.Iguala_Nota.ToString(), out int l) == false)
            {
                oAccess.Iguala_Nota = 0;
            }





            oMySql.auto = oAccess.auto;
            oMySql.id = oAccess.ID;
            oMySql.cnpj = oAccess.cnpj;
            oMySql.item = oAccess.Item;
            oMySql.cod_fornecedor = oAccess.COD_FORNECEDOR;
            oMySql.cod_produto = oAccess.cod_produto;
            oMySql.c_prod = oAccess.cProd;
            oMySql.x_prod = oAccess.xProd;
            oMySql.c_ean = oAccess.cEAN;
            oMySql.ncm = oAccess.NCM;
            oMySql.cfop = oAccess.CFOP;
            oMySql.u_com = oAccess.uCom;
            oMySql.qtd_prod_compra = oAccess.QtdProdCompra;
            oMySql.v_un_com = oAccess.vUnCom;
            oMySql.v_prod = oAccess.vProd;
            oMySql.c_ean_trib = oAccess.cEANTrib;
            oMySql.u_trib = oAccess.uTrib;
            oMySql.q_trib = oAccess.qTrib;
            oMySql.v_un_trib = oAccess.vUnTrib;
            oMySql.v_desc = oAccess.vDesc;
            oMySql.v_outro = oAccess.vOutro;
            oMySql.v_frete = oAccess.vFrete;
            oMySql.v_seg = oAccess.vSeg;
            oMySql.icms_orig = oAccess.ICMS_orig;
            oMySql.icms_cst = oAccess.ICMS_CST;
            oMySql.icms_csosn = oAccess.ICMS_CSOSN;
            oMySql.icms_p_cred_sn = oAccess.ICMS_pCredSN;
            oMySql.icms_v_cred_icmssn = oAccess.ICMS_vCredICMSSN;
            oMySql.icms_mod_bc = oAccess.ICMS_modBC;
            oMySql.icms_p_red_bc = oAccess.ICMS_pRedBC;
            oMySql.icms_v_bc = oAccess.ICMS_vBC;
            oMySql.icms_p_icms = oAccess.ICMS_pICMS;
            oMySql.icms_v_icms = oAccess.ICMS_vICMS;
            oMySql.icms_mod_bcst = oAccess.ICMS_modBCST;
            oMySql.icms_p_mvast = oAccess.ICMS_pMVAST;
            oMySql.icms_p_red_bcst = oAccess.ICMS_pRedBCST;
            oMySql.icms_v_bcst = oAccess.ICMS_vBCST;
            oMySql.icms_p_icmsst = oAccess.ICMS_pICMSST;
            oMySql.icms_v_icmsst = oAccess.ICMS_vICMSST;
            oMySql.icms_mot_desI_cms = oAccess.ICMS_motDesICMS;
            oMySql.icms_v_bcs_tret = oAccess.ICMS_vBCSTRet;
            oMySql.icms_v_icmss_tret = oAccess.ICMS_vICMSSTRet;
            oMySql.ipi_cl_enq = oAccess.IPI_clEnq;
            oMySql.ipi_cnpj_prod = oAccess.IPI_CNPJProd;
            oMySql.ipi_c_selo = oAccess.IPI_cSelo;
            oMySql.ipi_q_selo = oAccess.IPI_qSelo;
            oMySql.ipi_c_enq = oAccess.IPI_cEnq;
            oMySql.ipi_cst = oAccess.IPI_CST;
            oMySql.ipi_v_bc = oAccess.IPI_vBC;
            oMySql.ipi_p_ipi = oAccess.IPI_pIPI;
            oMySql.ipi_q_unid = oAccess.IPI_qUnid;
            oMySql.ipi_v_unid = oAccess.IPI_vUnid;
            oMySql.ipi_v_ipi = oAccess.IPI_vIPI;
            oMySql.ii_v_bc = oAccess.II_vBC;
            oMySql.ii_v_desp_adu = oAccess.II_vDespAdu;
            oMySql.ii_v_ii = oAccess.II_vII;
            oMySql.ii_v_iof = oAccess.II_vIOF;
            oMySql.pis_cst = oAccess.PIS_CST;
            oMySql.pis_v_bc = oAccess.PIS_vBC;
            oMySql.pis_p_pis = oAccess.PIS_pPIS;
            oMySql.pis_v_pis = oAccess.PIS_vPIS;
            oMySql.pis_q_bc_prod = oAccess.PIS_qBCProd;
            oMySql.pis_v_aliq_prod = oAccess.PIS_vAliqProd;
            oMySql.cofins_cst = oAccess.COFINS_CST;
            oMySql.cofins_v_bc = oAccess.COFINS_vBC;
            oMySql.cofins_p_cofins = oAccess.COFINS_pCOFINS;
            oMySql.cofins_v_cofins = oAccess.COFINS_vCOFINS;
            oMySql.cofins_q_bc_prod = oAccess.COFINS_qBCProd;
            oMySql.cofins_v_aliq_prod = oAccess.COFINS_vAliqProd;
            oMySql.issqn_v_bc = oAccess.ISSQN_vBC;
            oMySql.v_aliq = oAccess.vAliq;
            oMySql.v_issqn = oAccess.vISSQN;
            oMySql.c_mun_fg = oAccess.cMunFG;
            oMySql.c_list_serv = oAccess.cListServ;
            oMySql.c_sit_trib = oAccess.cSitTrib;
            oMySql.codigo = oAccess.Codigo;
            oMySql.bipado = oAccess.Bipado;
            oMySql.iguala_nota = oAccess.Iguala_Nota;


        }



        public void MantemAtualizado()
        {
            oMySql.TotalLinhasMySql();
            oAccess.TotalLinhasAccess();

            if (oMySql.totalLinhasMySql < oAccess.totalLinhasAccess)
            {
                oAccess.BuscarDadosNFeProdutosAccessUltimo();
                GravarObjMySql();
                oMySql.InserirDados();
            }
        }
        public void MantemAtualizado2()
        {
            oMySql.TotalLinhasMySql();
            oAccess.TotalLinhasAccess();

            if (oMySql.totalLinhasMySql > oAccess.totalLinhasAccess)
            {
                oMySql.TruncateTable();

                oAccess.ObjVazio();
                int rep = 0;
                oAccess.auto = 0;
                while (oAccess.ID == null && rep < 250)
                {
                    rep++;
                    oAccess.auto = int.Parse(oAccess.auto.ToString()) + 1;
                    oAccess.BuscarDadosNfEProdutosAccess(int.Parse(oAccess.auto.ToString()));

                    if (oAccess.ID != null)
                    {
                        GravarObjMySql();
                        oMySql.InserirDados();
                        oAccess.ObjVazio();
                        rep = 0;
                    }

                }
            }
        }

        private void FrmNfEProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
