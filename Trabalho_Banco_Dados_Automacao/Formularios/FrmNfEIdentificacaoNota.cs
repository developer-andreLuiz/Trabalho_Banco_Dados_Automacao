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
    public partial class FrmNfEIdentificacaoNota : Form
    {
        NfeIdentificacaoAccess oAccess = new NfeIdentificacaoAccess();
        NfeIdentificacaoMySql oMySql = new NfeIdentificacaoMySql();
        
        public FrmNfEIdentificacaoNota()
        {
            InitializeComponent();
        }
        
        #region BtnsAccess

        private void btnBuscarAccess_Click(object sender, EventArgs e)
        {
            oAccess.CarregarDataGridAccess(dataGridViewAccess);
        }

        private void btnInsertAccessforMySQL_Click(object sender, EventArgs e)
        {
          
            oAccess.ObjVazio();
            int rep = 0;
            oAccess.num = 1000;
            while (oAccess.nom_fornecedor == null && rep < 1500)
            {
                rep++;
                oAccess.num = int.Parse(oAccess.num.ToString()) + 1;
                oAccess.BuscarDadosNfeIdentificacaoAccess(int.Parse(oAccess.num.ToString()));

                if (oAccess.nom_fornecedor != null)
                {
                    GravarObjMySql();
                    oMySql.InserirDados();
                    oAccess.ObjVazio();
                    rep = 0;
                }

            }
 
            oMySql.CarregarDataGridMySql(dataGridViewMySql);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MantemAtualizado();
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

        private void btnAtualizarTruncate_Click(object sender, EventArgs e)
        {
            MantemAtualizado2();
        }

        #endregion
        
        #region Gravar dados para os objs no insert ou update

      
       
        public void GravarObjMySql()
        {
            if (int.TryParse(oAccess.COD_FORNECEDOR.ToString(),out int a)==false)
            {
                oAccess.COD_FORNECEDOR = 0;
            }
            if (int.TryParse(oAccess.cUF.ToString(), out int b) == false)
            {
                oAccess.cUF = 0;
            }
            if (int.TryParse(oAccess.cNF.ToString(), out int c) == false)
            {
                oAccess.cNF = 0;
            }
            if (int.TryParse(oAccess.indPad.ToString(), out int d) == false)
            {
                oAccess.indPad = 0;
            }
            if (int.TryParse(oAccess.serie.ToString(), out int e) == false)
            {
                oAccess.serie = 0;
            }
            if (int.TryParse(oAccess.nNF.ToString(), out int f) == false)
            {
                oAccess.nNF = 0;
            }
            if (int.TryParse(oAccess.tpNF.ToString(), out int g) == false)
            {
                oAccess.tpNF = 0;
            }
            if (int.TryParse(oAccess.cMunFG.ToString(), out int h) == false)
            {
                oAccess.cMunFG = 0;
            }
            if (int.TryParse(oAccess.tpImp.ToString(), out int i) == false)
            {
                oAccess.tpImp = 0;
            }
            if (int.TryParse(oAccess.tpEmis.ToString(), out int j) == false)
            {
                oAccess.tpEmis = 0;
            }
            if (int.TryParse(oAccess.cDV.ToString(), out int l) == false)
            {
                oAccess.cDV = 0;
            }
            if (int.TryParse(oAccess.tpAmb.ToString(), out int m) == false)
            {
                oAccess.tpAmb = 0;
            }
            if (int.TryParse(oAccess.finNFe.ToString(), out int n) == false)
            {
                oAccess.finNFe = 0;
            }
            if (int.TryParse(oAccess.procEmi.ToString(), out int o) == false)
            {
                oAccess.procEmi = 0;
            }
            if (int.TryParse(oAccess.num.ToString(), out int p) == false)
            {
                oAccess.num = 0;
            }
            if (int.TryParse(oAccess.Iguala_Nota.ToString(), out int q) == false)
            {
                oAccess.Iguala_Nota = 0;
            }

            if (oAccess.Comfer.ToString().Equals("True"))
            {
                oAccess.Comfer= "Sim";
            }
            else
            {
                oAccess.Comfer = "Não";
            }

            if (oAccess.Nota_Br.ToString().Equals("True"))
            {
                oAccess.Nota_Br = "Sim";
            }
            else
            {
                oAccess.Nota_Br = "Não";
            }









            oMySql.id = oAccess.ID;
            oMySql.cnpj = oAccess.CNPJ;
            oMySql.cod_fornecedor = oAccess.COD_FORNECEDOR;
            oMySql.nome_fornecedor = oAccess.nom_fornecedor;
            oMySql.c_uf = oAccess.cUF;
            oMySql.c_nf = oAccess.cNF;
            oMySql.nat_op = oAccess.natOp;
            oMySql.ind_pad = oAccess.indPad;
            oMySql.new_mod = oAccess.mod;
            oMySql.serie = oAccess.serie;
            oMySql.n_nf = oAccess.nNF;
            oMySql.ind_pres = oAccess.indpres;
            oMySql.ind_final = oAccess.indfinal;
            oMySql.id_dest = oAccess.iddest;
            oMySql.dh_cont = oAccess.dhCont;
            oMySql.d_emi = oAccess.dEmi;
            oMySql.d_sai_ent = oAccess.dSaiEnt;
            oMySql.h_sai_ent = oAccess.hSaiEnt;
            oMySql.tp_nf = oAccess.tpNF;
            oMySql.c_mun_fg = oAccess.cMunFG;
            oMySql.dh_saient = oAccess.dhsaient;
            oMySql.tp_imp = oAccess.tpImp;
            oMySql.tp_emis = oAccess.tpEmis;
            oMySql.d_hemi = oAccess.dhemi;
            oMySql.c_dv = oAccess.cDV;
            oMySql.tp_amb = oAccess.tpAmb;
            oMySql.fin_nfe = oAccess.finNFe;
            oMySql.proc_emi = oAccess.procEmi;
            oMySql.ver_proc = oAccess.verProc;
            oMySql.v_bc = oAccess.vBC;
            oMySql.v_icms = oAccess.vICMS;
            oMySql.v_bcst = oAccess.vBCST;
            oMySql.v_st = oAccess.vST;
            oMySql.v_prod = oAccess.vProd;
            oMySql.v_frete = oAccess.vFrete;
            oMySql.v_seg = oAccess.vSeg;
            oMySql.v_desc = oAccess.vDesc;
            oMySql.v_ii = oAccess.vII;
            oMySql.x_just = oAccess.xJust;
            oMySql.v_ipi = oAccess.vIPI;
            oMySql.v_pis = oAccess.vPIS;
            oMySql.v_confis = oAccess.vCOFINS;
            oMySql.v_outro = oAccess.vOutro;
            oMySql.v_nf = oAccess.vNF;
            oMySql.v_tot_trib = oAccess.vTotTrib;
            oMySql.iss_qn_tot_v_serv = oAccess.ISSQNTOT_vServ;
            oMySql.iss_qn_tot_v_bc = oAccess.ISSQNTOT_vBC;
            oMySql.iss_qn_tot_v_iss = oAccess.ISSQNTOT_vISS;
            oMySql.iss_qn_tot_v_pis = oAccess.ISSQNTOT_vPIS;
            oMySql.iss_qn_tot_v_cofins = oAccess.ISSQNTOT_vCOFINS;
            oMySql.fat_n_fat = oAccess.FAT_nFat;
            oMySql.fat_v_orig = oAccess.FAT_vOrig;
            oMySql.fat_v_desc = oAccess.FAT_vDesc;
            oMySql.fat_v_liq = oAccess.FAT_vLiq;
            oMySql.num = oAccess.num;
            oMySql.confer = oAccess.Comfer;
            oMySql.nota_br = oAccess.Nota_Br;
            oMySql.iguala_nota = oAccess.Iguala_Nota;

        }

        public void Iniciar()
        {
           
        }




















        #endregion
        

        public void MantemAtualizado()
        {
            oMySql.TotalLinhasMySql();
            oAccess.TotalLinhasAccess();

            if (oMySql.totalLinhasMySql < oAccess.totalLinhasAccess)
            {
                oAccess.BuscarDadosNfeIdentificacaoAccessUltimo();
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
                oAccess.num = 1000;
                while (oAccess.nom_fornecedor == null && rep < 1500)
                {
                    rep++;
                    oAccess.num = int.Parse(oAccess.num.ToString()) + 1;
                    oAccess.BuscarDadosNfeIdentificacaoAccess(int.Parse(oAccess.num.ToString()));
                    if (oAccess.nom_fornecedor != null)
                    {
                        GravarObjMySql();
                        oMySql.InserirDados();
                        oAccess.ObjVazio();
                        rep = 0;
                    }
                }
            }
        }

        private void FrmNfEIdentificacaoNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
