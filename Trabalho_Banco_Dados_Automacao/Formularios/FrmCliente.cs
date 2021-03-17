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

namespace RoboDataBase
{
    public partial class FrmCliente : Form
    {
        ClienteAccess clienteAccess = new ClienteAccess();
        ClienteMySql clienteMySql = new ClienteMySql();
        public  int totalLinhaInicialClienteRegistro;

        public FrmCliente()
        {
            InitializeComponent();
            Iniciar();
        }

        #region BtnsMySql

        private void btnBuscarMySql_Click(object sender, EventArgs e)
        {
            clienteMySql.CarregarDataGridMySql(dataGridViewMySql);
        }

        private void btnLimparMySql_Click(object sender, EventArgs e)
        {
            clienteMySql.TruncateTable();
            clienteMySql.CarregarDataGridMySql(dataGridViewMySql);

        }

        private void bntAtualizacaoMySqlAccess_Click(object sender, EventArgs e)
        {
            AtualizacaoMySqlAccess();
        }//

        private void btnInsertMySqlforAccess_Click(object sender, EventArgs e)
        {

            InsertMySqlAccess();
        }



        #endregion

        #region BtnsAccess

        private void btnInsertAccessforMySQL_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualização em Andamento";
            clienteAccess.ObjVazio();
            int rep = 0;
            clienteAccess.codigo = 0;
            while (clienteAccess.nome == null && rep < 100)
            {
                rep++;
                clienteAccess.codigo = int.Parse(clienteAccess.codigo.ToString()) + 1;
                clienteAccess.BuscarDadosClientesAccess(int.Parse(clienteAccess.codigo.ToString()));
                if (clienteAccess.nome != null)
                {
                    GravarObjAccessForMySql();
                    clienteMySql.InserirDados();
                    clienteAccess.ObjVazio();
                    rep = 0;
                }

            }

            lblStatus.Text = "Atualização Completa";

        }   
        private void btnBuscarAccess_Click(object sender, EventArgs e)
        {
            clienteAccess.CarregarDataGridAccess(dataGridViewAccess);
        }

        private void btnLimparAccess_Click(object sender, EventArgs e)
        {
            clienteAccess.TruncateTable();

        }

        #endregion

        #region EventosForm

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.F1)
            {

            }
            
        }

        #endregion


        #region Gravar dados para os objs no insert ou update
       public  void GravarObjAccessForMySql()
        {
            clienteMySql.codigo = clienteAccess.codigo;
            clienteMySql.nome = clienteAccess.nome;
            clienteMySql.endereco = clienteAccess.endereco;
            clienteMySql.bairro = clienteAccess.bairro;
            clienteMySql.cidade = clienteAccess.cidade;
            clienteMySql.estado = clienteAccess.uf;
            clienteMySql.cep = clienteAccess.cep;
            clienteMySql.cnpjCpf = clienteAccess.cnpjCpf;
            clienteMySql.telefone1 = clienteAccess.telefone1;
            clienteMySql.telefone2 = clienteAccess.telefone2;
            clienteMySql.pontoReferencia = clienteAccess.observacao;
            clienteMySql.lado = clienteAccess.lado;
            clienteMySql.posicao = clienteAccess.posicao;
            clienteMySql.cor = clienteAccess.cor;
            clienteMySql.dataNascimento = clienteAccess.dataNascimento;
            clienteMySql.ruaEntrada = clienteAccess.representante;
        }

       public  void GravarObjMySqlForAccess()
        {
            clienteAccess.codigo = clienteMySql.codigo;
            clienteAccess.nome = clienteMySql.nome;
            clienteAccess.endereco = clienteMySql.endereco;
            clienteAccess.bairro = clienteMySql.bairro;
            clienteAccess.cidade = clienteMySql.cidade;
            clienteAccess.uf = clienteMySql.estado;
            clienteAccess.cep = clienteMySql.cep;
            clienteAccess.cnpjCpf = clienteMySql.cnpjCpf;
            clienteAccess.telefone1 = clienteMySql.telefone1;
            clienteAccess.telefone2 = clienteMySql.telefone2;
            clienteAccess.observacao = clienteMySql.pontoReferencia;
            clienteAccess.lado = clienteMySql.lado;
            clienteAccess.posicao = clienteMySql.posicao;
            clienteAccess.cor = clienteMySql.cor;
            clienteAccess.dataNascimento = clienteMySql.dataNascimento;
            clienteAccess.representante = clienteMySql.ruaEntrada;
        }

       public  void Iniciar()
        {
            clienteMySql.TotalLinhasAtualizacao();
            totalLinhaInicialClienteRegistro = clienteMySql.totalLinhasClienteRegistro;
        }



        #endregion



        #region EventosBtns

       public void AtualizacaoMySqlAccess()
        {
            clienteMySql.TotalLinhasAtualizacao();
            if (totalLinhaInicialClienteRegistro != clienteMySql.totalLinhasClienteRegistro)
            {
                clienteMySql.ClienteAlterado();
                clienteMySql.BuscarDadosClientesMySql(clienteMySql.codigoClienteAtualizado);
                GravarObjMySqlForAccess();
                clienteAccess.UpdateAccess(clienteMySql.codigoClienteAtualizado);
                totalLinhaInicialClienteRegistro = clienteMySql.totalLinhasClienteRegistro;
            }
        }

        public void InsertMySqlAccess()
        {
            clienteAccess.TotalLinhasClientes();
            clienteMySql.TotalLinhasClientes();
            // MessageBox.Show("Access "+ clienteAccess.totalLinhasClienteAccess + "   MySql "+ clienteMySql.totalLinhasClienteMySql);
            if (clienteAccess.totalLinhasClienteAccess < clienteMySql.totalLinhasClienteMySql)
            {
                clienteMySql.UltimoCodigoCliente();
                GravarObjMySqlForAccess();
                clienteAccess.InsertAccess();
            }
        }
            


         #endregion


}
}
