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
    public partial class FrmFuncionario : Form
    {
        FuncionarioMySql fMySql = new FuncionarioMySql(); 
        FuncionarioAccess fAccess = new FuncionarioAccess();
        public int totalLinhaInicialFuncionarioRegistro;
        public FrmFuncionario()
        {
            InitializeComponent();
            Iniciar();
        }

        #region BtnsAccess

        private void btnBuscarAccess_Click(object sender, EventArgs e)
        {
            fAccess.CarregarDataGridAccess(dataGridViewAccess);
        }

        private void btnInsertAccessforMySQL_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualização em Andamento";
            fAccess.ObjVazio();
            int rep = 0;
            fAccess.codigo = 0;
            while (fAccess.nome==null && rep < 100)
            {
                rep++;
                fAccess.codigo= int.Parse(fAccess.codigo.ToString()) + 1 ;
                fAccess.BuscarDadosFuncionarioAccess(int.Parse(fAccess.codigo.ToString()));
                if (fAccess.nome!=null)
                {
                    GravarObjMySql();
                    fMySql.InserirDados();
                    fAccess.ObjVazio();
                    rep = 0;
                }

            }

            lblStatus.Text = "Atualização Completa";

        }





        private void btnLimparAccess_Click(object sender, EventArgs e)
        {
            fAccess.TruncateTable();
            fAccess.CarregarDataGridAccess(dataGridViewAccess);
        }


        #endregion

        #region BtnsMySql

        private void btnBuscarMySql_Click(object sender, EventArgs e)
        {
            fMySql.CarregarDataGridMySql(dataGridViewMySql);
        }//

        private void btnLimparMySql_Click(object sender, EventArgs e)
        {
            fMySql.TruncateTable();
            fMySql.CarregarDataGridMySql(dataGridViewMySql);
        }//

        private void btnInsertMySqlforAccess_Click(object sender, EventArgs e)
        {
            InsertMySqlAccess();
        }//

        private void bntAtualizacaoMySqlAccess_Click(object sender, EventArgs e)
        {
            AtualizacaoMySqlAccess();
        }

       


        #endregion

        #region EventosForm

        private void FrmFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion

        #region Gravar dados para os objs no insert ou update

       public void GravarObjMySql()
        {
            fMySql.codigo = fAccess.codigo;
            fMySql.nome = fAccess.nome;
            fMySql.senha = fAccess.senha;
            if (fAccess.habilitado.ToString().Equals("False"))
            {
                fMySql.habilitado = "NÃO";
            }
            else
            {
                fMySql.habilitado = "SIM";
            }
            fMySql.nivel = fAccess.nivel;
            fMySql.cargo = fAccess.cargo;
            fMySql.endereco = fAccess.endereco;
            fMySql.bairro = fAccess.bairro;
            fMySql.cidade = fAccess.cidade;
            fMySql.telefone1 = fAccess.telefone1;
            fMySql.telefone2 = fAccess.telefone2;

            if (float.Parse(fAccess.compras.ToString()) <= 0 )
            {
                fMySql.compras = 0;
            }
            else
            {
                fMySql.compras = fAccess.compras;
            }
          
            fMySql.observacao = fAccess.observacao;
            fMySql.apagador = fAccess.apagador;
            fMySql.senhaAcesso = fAccess.senhaAcesso;
           

        }

       public void GravarObjAccess()
        {
            fAccess.codigo = fMySql.codigo;
            fAccess.nome = fMySql.nome;
            fAccess.senha = fMySql.senha;

            if (fMySql.habilitado.Equals("NÃO"))
            {
                fAccess.habilitado = false;
            }
            else
            {
                fAccess.habilitado = true;
            }
            


            fAccess.nivel = fMySql.nivel;
            fAccess.cargo = fMySql.cargo;
            fAccess.endereco = fMySql.endereco;
            fAccess.bairro = fMySql.bairro;
            fAccess.cidade = fMySql.cidade;
            fAccess.telefone1 = fMySql.telefone1;
            fAccess.telefone2 = fMySql.telefone2;
            fAccess.compras = fMySql.compras;
            fAccess.observacao = fMySql.observacao;
            fAccess.apagador = fMySql.apagador;
            fAccess.senhaAcesso = fMySql.senhaAcesso;

        }

       public void Iniciar()
        {
            fMySql.TotalLinhasAtualizacao();
            totalLinhaInicialFuncionarioRegistro = fMySql.totalLinhasFuncionarioRegistro;
        }
       



        #endregion

        #region EventosBtns

        public void AtualizacaoMySqlAccess()
        {
            fMySql.TotalLinhasAtualizacao();
            if (totalLinhaInicialFuncionarioRegistro != fMySql.totalLinhasFuncionarioRegistro)
            {
                fMySql.FuncionarioAlterado();
                fMySql.BuscarDadosClientesMySql(fMySql.codigoFuncionarioAtualizado);
                GravarObjAccess();
                fAccess.UpdateAccess(fMySql.codigoFuncionarioAtualizado);
                totalLinhaInicialFuncionarioRegistro = fMySql.totalLinhasFuncionarioRegistro;
            }
        }

        public void InsertMySqlAccess()
        {
            fAccess.TotalLinhasFuncionario();
            fMySql.TotalLinhasFuncionario();
            if (fAccess.totalLinhasFuncionarioAccess < fMySql.totalLinhasFuncionarioMySql)
            {
                fMySql.UltimoCodigoCliente();
                GravarObjAccess();
                fAccess.InsertAccess();
            }
        }

        #endregion
    }
}
