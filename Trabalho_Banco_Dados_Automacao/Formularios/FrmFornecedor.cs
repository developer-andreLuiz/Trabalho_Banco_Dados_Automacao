using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboDataBase.BancodeDados.AccessDB;
using RoboDataBase.BancodeDados.MySqlDb;

namespace RoboDataBase.Formularios
{
    public partial class FrmFornecedor : Form
    {

        FornecedorAccess fAccess = new FornecedorAccess();
        FornecedorMySql fMySql = new FornecedorMySql();
        public int totalLinhaInicialFornecedorRegistro;
        public int totalLinhaInicialFornecedorCodigoAtualizacao;

        public FrmFornecedor()
        {
            InitializeComponent();
            Iniciar();
        }
        #region BtnsMySql

        //carregar dados no mysql
        private void btnBuscarMySql_Click(object sender, EventArgs e)
        {
            fMySql.CarregarDataGridMySql(dataGridViewMySql);
        }///
        //reseta a tabela mysql
        private void btnLimparMySql_Click(object sender, EventArgs e)
        {
            fMySql.TruncateTable();
            fMySql.CarregarDataGridMySql(dataGridViewMySql);
        }//
        //insere dados no access partindo do mysql
        private void btnInsertMySqlforAccess_Click(object sender, EventArgs e)
        {
            fAccess.TotalLinhasFornecedores();
            fMySql.TotalLinhasFornecedor();
           // MessageBox.Show("Access " + fAccess.totalLinhasFornecedorAccess + "   MySql " + fMySql.totalLinhasFornecedorMySql);
            if (fAccess.totalLinhasFornecedorAccess < fMySql.totalLinhasFornecedorMySql)
            {
                fMySql.UltimoCodigoFornecedor();
                GravarObjAccess();
                fAccess.InsertAccess();
            }
        }
        //verifica atualização no mysql e atualiza o access
        private void bntAtualizacaoMySqlAccess_Click(object sender, EventArgs e)
        {
            fMySql.TotalLinhasAtualizacao();
            if (totalLinhaInicialFornecedorRegistro != fMySql.totalLinhasFornecedorRegistro)
            {
                fMySql.FornecedorAlterado();
                fMySql.BuscarDadosFornecedorMySql(fMySql.codigoFornecedorAtualizado);
                GravarObjAccess();
                fAccess.UpdateAccess(fMySql.codigoFornecedorAtualizado);
                totalLinhaInicialFornecedorRegistro = fMySql.totalLinhasFornecedorRegistro;
            }
        }
        //insere dados no fornecedor codigo no access partindo do mysql
        private void btnInsertFCodigo_Click(object sender, EventArgs e)
        {
            fAccess.TotalLinhasFornecedorCodigo();
            fMySql.TotalLinhasFornecedorCodigo();
           // MessageBox.Show("Access " + fAccess.totalLinhasFornecedorCodigoAccess + "   MySql " + fMySql.totalLinhasFornecedorCodigoMySql);
            if (fAccess.totalLinhasFornecedorCodigoAccess < fMySql.totalLinhasFornecedorCodigoMySql)
            {
                fMySql.UltimoCodigoFornecedorCodigo();
                GravarObjAccessCodigo();
                fAccess.InsertAccessCodigo();
            }
        }
        private void btnDeletarFCodigo_Click(object sender, EventArgs e)
        {
            fMySql.TotalLinhasFornecedorCodigoDelete();
            if (totalLinhaInicialFornecedorCodigoAtualizacao < fMySql.totalLinhasFornecedorCodigoDeleteMySql)
            {
                fMySql.UltimoIdFornecedorCodigoDelete();
                fAccess.DeleteFornecedorCodigo(fMySql.cnpjCodigo.ToString());
                totalLinhaInicialFornecedorCodigoAtualizacao = fMySql.totalLinhasFornecedorCodigoDeleteMySql;
            }
        }
       
        #endregion
        #region BtnsAccess
        private void btnInsertAccessforMySQL_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualização em Andamento";
            fAccess.ObjVazio();
            int rep = 0;
            fAccess.codigo = 0;
            while (fAccess.nome == null && rep < 100)
            {
                rep++;
                fAccess.codigo = int.Parse(fAccess.codigo.ToString()) + 1;
                fAccess.BuscarDadosFornecedoresAccess(int.Parse(fAccess.codigo.ToString()));
                if (fAccess.nome != null)
                {
                    GravarObjMySql();
                    fMySql.InserirDados();
                    fAccess.ObjVazio();
                    rep = 0;
                }

            }

            lblStatus.Text = "Atualização Completa";
        }
        private void btnBuscarAccess_Click(object sender, EventArgs e)
        {
            fAccess.CarregarDataGridAccess(dataGridViewAccess);
        }
        private void btnLimparAccess_Click(object sender, EventArgs e)
        {
            fAccess.TruncateTable();

        }
        private void btnInsertFCodigoAccessforMySQL_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualização em Andamento";
            fAccess.ObjVazioCodigo();
            int rep = 0;
            fAccess.id = 0;
            fAccess.codigoCodigo = 0;
            while (fAccess.nomeCodigo == null && rep < 100)
            {
                rep++;
                fAccess.codigoCodigo = int.Parse(fAccess.id.ToString()) + 1;
                fAccess.BuscarDadosFornecedorCodigoAccess(int.Parse(fAccess.codigoCodigo.ToString()));
                if (fAccess.nomeCodigo != null)
                {
                    GravarObjMySqlCodigo();
                    fMySql.InserirDadosFornecedorCodigo();
                    fAccess.ObjVazioCodigo();
                    rep = 0;
                }
            }
            lblStatus.Text = "Atualização Fornecedor codigo Completa";
        }
        #endregion
        #region EventosForm

        private void FrmFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        #endregion
        #region Gravar dados para os objs no insert ou update
        public void Iniciar()
        {
            fMySql.TotalLinhasAtualizacao();
            totalLinhaInicialFornecedorRegistro = fMySql.totalLinhasFornecedorRegistro;

            fMySql.TotalLinhasFornecedorCodigoDelete();
            totalLinhaInicialFornecedorCodigoAtualizacao = fMySql.totalLinhasFornecedorCodigoDeleteMySql;

        }
        public void GravarObjMySql()
        {
            fMySql.codigo = fAccess.codigo;
            fMySql.nome = fAccess.nome;
            fMySql.endereco = fAccess.endereco;
            fMySql.bairro = fAccess.bairro;
            fMySql.cidade = fAccess.cidade;
            fMySql.estado = fAccess.uf;
            fMySql.telefone1 = fAccess.telefone1;
            fMySql.telefone2 = fAccess.telefone2;
            fMySql.cnpjCpf = fAccess.cnpjCpf;
            fMySql.observacao = fAccess.observacao;
            fMySql.registro = fAccess.registro;
            if (fAccess.nota.ToString().Equals("False"))
            {
                fMySql.nota = "NÃO";
            }
            else
            {
                fMySql.nota = "SIM";
            }
            fMySql.representante = fAccess.representante;
          
        }
        public void GravarObjMySqlCodigo()
        {

            fMySql.codigoCodigo = fAccess.codigoCodigo;
            fMySql.nomeCodigo = fAccess.nomeCodigo;
            fMySql.cnpjCodigo = fAccess.cnpjCodigo;

        }
        public void GravarObjAccess()
        {
            fAccess.codigo = fMySql.codigo;
            fAccess.nome = fMySql.nome;
            fAccess.endereco = fMySql.endereco;
            fAccess.bairro = fMySql.bairro;
            fAccess.cidade = fMySql.cidade;
            fAccess.uf = fMySql.estado;
            fAccess.cep = fMySql.cep;
            fAccess.telefone1 = fMySql.telefone1;
            fAccess.telefone2 = fMySql.telefone2;
            fAccess.cnpjCpf = fMySql.cnpjCpf;
            fAccess.observacao = fMySql.observacao;
            fAccess.registro = fMySql.registro;
            if (fMySql.nota.Equals("NÃO"))
            {
                fAccess.nota = false;
            }
            else
            {
                fAccess.nota = true;
            }
            fAccess.representante = fMySql.representante;


        }
        public void GravarObjAccessCodigo()
        {
            fAccess.codigoCodigo = fMySql.codigoCodigo;
            fAccess.nomeCodigo = fMySql.nomeCodigo;
            fAccess.cnpjCodigo = fMySql.cnpjCodigo;
        }
       #endregion
        #region EventosBtns
        public void AtualizacaoMySqlAccess()
        {
            fMySql.TotalLinhasAtualizacao();
            if (totalLinhaInicialFornecedorRegistro != fMySql.totalLinhasFornecedorRegistro)
            {
                fMySql.FornecedorAlterado();
                fMySql.BuscarDadosFornecedorMySql(fMySql.codigoFornecedorAtualizado);
                GravarObjAccess();
                fAccess.UpdateAccess(fMySql.codigoFornecedorAtualizado);
                totalLinhaInicialFornecedorRegistro = fMySql.totalLinhasFornecedorRegistro;
            }
        }
        public void InsertMySqlAccess()
        {
            fAccess.TotalLinhasFornecedores();
            fMySql.TotalLinhasFornecedor();
            //MessageBox.Show("Access " + fAccess.totalLinhasFornecedorAccess + "   MySql " + fMySql.totalLinhasFornecedorMySql);
            if (fAccess.totalLinhasFornecedorAccess < fMySql.totalLinhasFornecedorMySql)
            {
                fMySql.UltimoCodigoFornecedor();
                GravarObjAccess();
                fAccess.InsertAccess();
            }
        }
        public void InsertFCodigo()
        {
            fAccess.TotalLinhasFornecedorCodigo();
            fMySql.TotalLinhasFornecedorCodigo();
            // MessageBox.Show("Access " + fAccess.totalLinhasFornecedorCodigoAccess + "   MySql " + fMySql.totalLinhasFornecedorCodigoMySql);
            if (fAccess.totalLinhasFornecedorCodigoAccess < fMySql.totalLinhasFornecedorCodigoMySql)
            {
                fMySql.UltimoCodigoFornecedorCodigo();
                GravarObjAccessCodigo();
                fAccess.InsertAccessCodigo();
            }
        }
        public void DeletarFCodigo()
        {
            fMySql.TotalLinhasFornecedorCodigoDelete();
            if (totalLinhaInicialFornecedorCodigoAtualizacao < fMySql.totalLinhasFornecedorCodigoDeleteMySql)
            {
                fMySql.UltimoIdFornecedorCodigoDelete();
                fAccess.DeleteFornecedorCodigo(fMySql.cnpjCodigo.ToString());
                totalLinhaInicialFornecedorCodigoAtualizacao = fMySql.totalLinhasFornecedorCodigoDeleteMySql;
            }
        }
       #endregion

       
    }
}
