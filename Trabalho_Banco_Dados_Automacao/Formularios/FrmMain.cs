using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboDataBase.Formularios;
using RoboDataBase.BancodeDados.AccessDB;
using RoboDataBase.BancodeDados.MySqlDb;
using System.IO;
using Microsoft.Win32;

namespace RoboDataBase.Formularios
{
    public partial class FrmMain : Form
    {
        bool sumir = true;
        #region Variaveis dos Forms

        FrmCliente frmCliente = new FrmCliente();
        FrmFuncionario frmFuncionario = new FrmFuncionario();
        FrmFornecedor frmFornecedor = new FrmFornecedor();
        FrmProduto frmProduto = new FrmProduto();
        FrmNfEIdentificacaoNota frmNfEIdentificacaoNota = new FrmNfEIdentificacaoNota();
        FrmNfEProdutos frmNfEProdutos = new FrmNfEProdutos();



        #endregion

        public FrmMain()
        {
            InitializeComponent();
            //DesmarcarTodosChkBox();
            //MarcarTodosChkBox();

            //frmCliente.Iniciar();
            //frmFuncionario.Iniciar();
            //frmFornecedor.Iniciar();
            //frmProduto.Iniciar();


        }

        #region BtnsForm
        //Abrir Tela de Cliente
        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente f = new FrmCliente();
            f.ShowDialog();
        }

        //Abrir Tela de Funcionario
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario f = new FrmFuncionario();
            f.ShowDialog();
        }

        //Abrir Tela de Fornecedor
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor f = new FrmFornecedor();
            f.ShowDialog();
        }

        //abrir Tela de Produto
        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmProduto f = new FrmProduto();
            f.ShowDialog();
        }

        //abrir Tela de NfEIdentificacaoNota
        private void btnNfEIdentificacaoNota_Click(object sender, EventArgs e)
        {
            FrmNfEIdentificacaoNota f = new FrmNfEIdentificacaoNota();
            f.ShowDialog();
        }

        //abrir Tela de NfEProdutos
        private void btnNfEProdutos_Click(object sender, EventArgs e)
        {
            FrmNfEProdutos f = new FrmNfEProdutos();
            f.ShowDialog();
        }

        //abrir Tela de PesqProdutos
        private void btnPesqProdutos_Click(object sender, EventArgs e)
        {
            FrmPesqProduto f = new FrmPesqProduto();
            f.ShowDialog();
        }

        #endregion

        #region Eventos Form

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                Close();
            }
        }

        private void btnMarcaTodos_Click(object sender, EventArgs e)
        {
            MarcarTodosChkBox();
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            DesmarcarTodosChkBox();
        }

        private void btnSumir_Click(object sender, EventArgs e)
        {
            sumir = true;
            Hide();
        }

        private void btnIniciarWindows_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                reg.SetValue("Automação MySql--Access", Application.ExecutablePath.ToString());
            }
            catch{}
        }


        #endregion

        #region Eventos de Clientes

        //busca cliente atualizado no mysql e atualiza o Access
        void atualizarClienteMain()
        {
            // MessageBox.Show("cliente atualizar");
            frmCliente.AtualizacaoMySqlAccess();
        }

        //busca cliente novo no mysql e insere o Access
        void InsertClienteMain()
        {
            //  MessageBox.Show("cliente inserir");
            frmCliente.InsertMySqlAccess();
        }

        #endregion

        #region Eventos de Funcionario

        //busca funcionario atualizado no mysql e atualiza o Access
        void atualizarFuncionarioMain()
        {
            // MessageBox.Show("Funcionario atualizar");
            frmFuncionario.AtualizacaoMySqlAccess();
        }

        //busca funcionario novo no mysql e insere o Access
        void InsertFuncionarioMain()
        {
            // MessageBox.Show("Funcionario atualizar");
            frmFuncionario.InsertMySqlAccess();
        }

        #endregion

        #region Eventos de Fornecedor
        //busca fornecedor atualizado no mysql e atualiza o Access
        void atualizarFornecedorMain()
        {
            // MessageBox.Show("Fornecedor atualizar");
            frmFornecedor.AtualizacaoMySqlAccess();
        }
        //busca fornecedor novo no mysql e insere o Access
        void InsertFornecedorMain()
        {
            //  MessageBox.Show("Fornecedor inserir");
            frmFornecedor.InsertMySqlAccess();
        }
        //busca fornecedor codigo novo no mysql e insere o Access
        void InsertFCodigoMain()
        {
            //  MessageBox.Show("Funcionario inserir codigo");
            frmFornecedor.InsertFCodigo();
        }
        //deletar fornecedor codigo
        void DeletarFCodigoMain()
        {
            frmFornecedor.DeletarFCodigo();
        }
        #endregion

        #region Eventos de Produto
        //busca produto atualizado no mysql e atualiza o Access
        void atualizarProdutoMain()
        {
            frmProduto.AtualizacaoMySqlAccess();
        }
        //busca produto novo no mysql e insere o Access
        void InsertProdutoMain()
        {
            frmProduto.InsertMySqlAccess();
        }
        //busca produto codigo novo no mysql e insere o Access
        void InsertPCodigoMain()
        {
            frmProduto.InsertPCodigo();
        }
        //deletar produto codigo
        void DeletarPCodigoMain()
        {
            frmProduto.DeletarPCodigo();
        }
        #endregion

        #region Eventos de NfEIdentificacao

        void MantenAtualizadoNfEIdentificacao()
        {
            frmNfEIdentificacaoNota.MantemAtualizado();
            frmNfEIdentificacaoNota.MantemAtualizado2();
        }

        #endregion

        #region Eventos de NfEProdutos

        void MantenAtualizadoNfeProdutos()
        {
            frmNfEProdutos.MantemAtualizado();
            frmNfEProdutos.MantemAtualizado2();
        }

        #endregion
        
        #region Regras do Form

        void MarcarTodosChkBox()
        {
            chkCliente.Checked = true;
            chkFuncionario.Checked = true;
            chkFornecedor.Checked = true;
            chkProduto.Checked = true;
            chkNfEIdentificacao.Checked = true;
            chkNfEProdutos.Checked = true;

        }

        void DesmarcarTodosChkBox()
        {
            chkCliente.Checked = false;
            chkFuncionario.Checked = false;
            chkFornecedor.Checked = false;
            chkProduto.Checked = false;
            chkNfEIdentificacao.Checked = false;
            chkNfEProdutos.Checked = false;
            chkPesqProdutos.Checked = false;

        }

        #endregion

        //Relogio 
        private void timer_Tick(object sender, EventArgs e)
        {
            ////verifica o check box cliente
            //if (chkCliente.Checked)
            //{
            //    atualizarClienteMain();
            //    InsertClienteMain();
            //}
            ////verifica o check box funcionario
            //if (chkFuncionario.Checked)
            //{
            //    atualizarFuncionarioMain();
            //    InsertFuncionarioMain();
            //}
            ////verifica o check box fornecedor
            //if (chkFornecedor.Checked)
            //{
            //    atualizarFornecedorMain();
            //    InsertFornecedorMain();
            //    InsertFCodigoMain();
            //    DeletarFCodigoMain();
            //}
            ////verifica o check box Produto
            //if (chkProduto.Checked)
            //{
            //    atualizarProdutoMain();
            //    InsertProdutoMain();
            //    InsertPCodigoMain();
            //    DeletarPCodigoMain();
            //}
            ////verifica o check box NfEIdentificacao
            //if (chkNfEIdentificacao.Checked)
            //{
            //    MantenAtualizadoNfEIdentificacao();
            //}
            ////verifica o check box NfEProdutos
            //if (chkNfEProdutos.Checked)
            //{
            //    MantenAtualizadoNfeProdutos();
            //}
        }

        private void btnQuantProdutos_Click(object sender, EventArgs e)
        {
            FrmNfEQuantidade f = new FrmNfEQuantidade();
            f.ShowDialog();
        }
    }
}
