using RoboDataBase.BancodeDados.AccessDB;
using RoboDataBase.BancodeDados.MySqlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDataBase.Formularios
{
    public partial class FrmPesqProduto : Form
    {
        NfePesquisarProdutoAccess pAccess = new NfePesquisarProdutoAccess();
        NfePesquisarProdutoMySql pMySql = new NfePesquisarProdutoMySql();

        public FrmPesqProduto()
        {
            InitializeComponent();
        }

        #region BtnMysql
        private void btnBuscarMySql_Click(object sender, EventArgs e)
        {
            pMySql.CarregarDataGridMySql(dataGridViewMySql);
        }
        private void btnLimparMySql_Click(object sender, EventArgs e)
        {
            pMySql.TruncateTable();
        }
        private void btnInsertMySqlforAccess_Click(object sender, EventArgs e)
        {

        }
        private void bntAtualizacaoMySqlAccess_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region BtnAccess

        private void btnBuscarAccess_Click(object sender, EventArgs e)
        {
            pAccess.CarregarDataGridAccess(dataGridViewAccess);
        }

        private void btnInsertAccessforMySQL_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualização em Andamento";
            pAccess.ObjVazio();
            int rep = 0;
            pAccess.controle = 0;
            while (pAccess.descricao == null && rep < 100)
            {
                rep++;
                pAccess.controle++;
                pAccess.BuscarDadosNFePesqProdutosAccess(pAccess.controle);

                if (pAccess.descricao != null)
                {
                    GravarObjAccessForMySql();
                    pMySql.InserirDados();
                    pAccess.ObjVazio();
                    rep = 0;
                }

            }

            lblStatus.Text = "Atualização Completa";
        }
        #endregion

        public void GravarObjAccessForMySql()
        {
            pMySql.controle = pAccess.controle;
            pMySql.descricao = pAccess.descricao;
            pMySql.codigo = pAccess.codigo;
            pMySql.codigo_forncedor = pAccess.codigo_forncedor;
            pMySql.referencia = pAccess.referencia;

        }

    }
}
