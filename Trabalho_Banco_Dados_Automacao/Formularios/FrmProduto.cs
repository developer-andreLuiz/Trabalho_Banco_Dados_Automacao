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
    public partial class FrmProduto : Form
    {
        ProdutoAccess pAccess = new ProdutoAccess();
        ProdutoMySql pMySql = new ProdutoMySql();
        public int totalLinhaInicialProdutoRegistro;
        public int totalLinhaInicialProdutoCodigoAtualizacao;

        public FrmProduto()
        {
            InitializeComponent();
            Iniciar();
        }

        #region BtnsMySql
        //carregar dados no mysql
        private void btnBuscarMySql_Click(object sender, EventArgs e)
        {
            pMySql.CarregarDataGridMySql(dataGridViewMySql);
        }///
        //reseta a tabela mysql
        private void btnLimparMySql_Click(object sender, EventArgs e)
        {
            pMySql.TruncateTable();
            pMySql.CarregarDataGridMySql(dataGridViewMySql);
        }//
        //insere dados no access partindo do mysql
        private void btnInsertMySqlforAccess_Click(object sender, EventArgs e)
        {
            InsertMySqlAccess();
        }
        //verifica atualização no mysql e atualiza o access
        private void bntAtualizacaoMySqlAccess_Click(object sender, EventArgs e)
        {
            AtualizacaoMySqlAccess();
        }
        //insere dados no fornecedor codigo no access partindo do mysql
        private void btnInsertPCodigo_Click(object sender, EventArgs e)
        {
            InsertPCodigo();
        }
        //Deleta produto Codigo
        private void btnDeletarFC_Click(object sender, EventArgs e)
        {
            DeletarPCodigo();
        }

        #endregion
        #region BtnsAccess

        private void btnInsertAccessforMySQL_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualização em Andamento";
            pAccess.ObjVazio();
            int rep = 0;
            pAccess.codigo = 0;
            while (pAccess.nome == null && rep < 100)
            {
                rep++;
                pAccess.codigo = int.Parse(pAccess.codigo.ToString()) + 1;
                pAccess.BuscarDadosProdutosAccess(int.Parse(pAccess.codigo.ToString()));
                if (pAccess.nome != null)
                {
                    GravarObjMySql();
                    pMySql.InserirDados();
                    pAccess.ObjVazio();
                    rep = 0;
                }

            }

            lblStatus.Text = "Atualização Completa";
        }

        private void btnBuscarAccess_Click(object sender, EventArgs e)
        {
            pAccess.CarregarDataGridAccess(dataGridViewAccess);
        }

        private void btnLimparAccess_Click(object sender, EventArgs e)
        {
            pAccess.TruncateTable();

        }

        private void btnInsertPCodigoAccessforMySQL_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualização em Andamento";
            pAccess.ObjVazioCodigo();
            int rep = 0;
            pAccess.idCodigo = 0;
            while (pAccess.descricaoCodigo == null && rep < 500)
            {
                rep++;
                pAccess.idCodigo = int.Parse(pAccess.idCodigo.ToString()) + 1;
                pAccess.BuscarDadosProdutoCodigoAccess(int.Parse(pAccess.idCodigo.ToString()));
                if (pAccess.descricaoCodigo != null)
                {
                    GravarObjMySqlCodigo();
                    pMySql.InserirDadosProdutoCodigo();
                    pAccess.ObjVazioCodigo();
                    rep = 0;
                }
            }
            lblStatus.Text = "Atualização Produto codigo Completa";
        }


        #endregion
        #region EventosForm

        private void FrmProduto_KeyDown(object sender, KeyEventArgs e)
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
            pMySql.TotalLinhasAtualizacao();
            totalLinhaInicialProdutoRegistro = pMySql.totalLinhasProdutoRegistro;

            pMySql.TotalLinhasProdutoCodigoDelete();
            totalLinhaInicialProdutoCodigoAtualizacao = pMySql.totalLinhasProdutosCodigoDeleteMySql;
        }

        public void GravarObjMySql()
        {

            try
            {
                pMySql.iguala1 = int.Parse(pAccess.iguala1.ToString());//
            }
            catch
            {
                pMySql.iguala1 = 0;
            }
            try
            {
                pMySql.custoUnitario = float.Parse(pAccess.custoUnitario.ToString());//
            }
            catch
            {
                pMySql.custoUnitario = 0f;//
            }
            try
            {
                pMySql.margem = float.Parse(pAccess.margem.ToString());//
            }
            catch
            {
                pMySql.margem = 0f;
            }
            try
            {
                pMySql.valorVenda = float.Parse(pAccess.valorVenda.ToString());//
            }
            catch
            {
                pMySql.valorVenda = 0f;//
            }
            try
            {
                pMySql.valorVenda = float.Parse(pAccess.valorVenda.ToString());//
            }
            catch
            {
                pMySql.valorVenda = 0f;//
            }
            try
            {
                pMySql.margemOnline = float.Parse(pAccess.margemOnline.ToString());//
            }
            catch
            {
                pMySql.margemOnline = 0f;//
            }
            try
            {
                pMySql.valorVendaOnline = float.Parse(pAccess.valorVendaOnline.ToString());//
            }
            catch
            {
                pMySql.valorVendaOnline = 0f;//
            }
            try
            {
                pMySql.valorCesta = float.Parse(pAccess.valorCesta.ToString());//
            }
            catch
            {
                pMySql.valorCesta = 0f;//
            }
            try
            {
                pMySql.valorPromocao = float.Parse(pAccess.valorPromocao.ToString());//
            }

            catch
            {
                pMySql.valorPromocao = 0f;//
            }
            try
            {
                pMySql.margemPromocao = float.Parse(pAccess.margemPromocao.ToString());//
            }

            catch
            {
                pMySql.margemPromocao = 0f;//
            }
            try
            {
                pMySql.margemAvista = float.Parse(pAccess.margemAvista.ToString());//
            }

            catch
            {
                pMySql.margemAvista = 0f;//
            }
            try
            {
                pMySql.margemCartao = float.Parse(pAccess.margemCartao.ToString());//
            }

            catch
            {
                pMySql.margemCartao = 0f;//
            }
            try
            {
                pMySql.margemCheque = float.Parse(pAccess.margemCheque.ToString());//
            }

            catch
            {
                pMySql.margemCheque = 0f;//
            }
            try
            {
                pMySql.avista = float.Parse(pAccess.avista.ToString());//
            }

            catch
            {
                pMySql.avista = 0f;//
            }
            try
            {
                pMySql.cartao = float.Parse(pAccess.cartao.ToString());//
            }

            catch
            {
                pMySql.cartao = 0f;//
            }
            try
            {
                pMySql.cheque = float.Parse(pAccess.cheque.ToString());//
            }

            catch
            {
                pMySql.cheque = 0f;//
            }
            try
            {
                pMySql.valorCartao = float.Parse(pAccess.valorCartao.ToString());//
            }

            catch
            {
                pMySql.valorCartao = 0f;//
            }
            try
            {
                pMySql.iguala = int.Parse(pAccess.iguala.ToString());
            }
            catch
            {
                pMySql.iguala = 0;
            }
            try
            {
                pMySql.igualaCaixa = int.Parse(pAccess.igualaCaixa.ToString());
            }
            catch
            {
                pMySql.igualaCaixa = 0f;
            }
            try
            {
                pMySql.codigo = int.Parse(pAccess.codigo.ToString());
            }
            catch
            {
                pMySql.codigo = 0;
            }
            try
            {
                pMySql.quantidade = int.Parse(pAccess.quantidade.ToString());
            }
            catch
            {
                pMySql.quantidade = 0;
            }
            try
            {
                pMySql.quant = int.Parse(pAccess.quant.ToString());
            }
            catch
            {
                pMySql.quant = 0;
            }
            try
            {
                pMySql.numero = int.Parse(pAccess.numero.ToString());
            }
            catch
            {
                pMySql.numero = 0;
            }
            try
            {
                pMySql.unidade = int.Parse(pAccess.unidade.ToString());
            }
            catch
            {
                pMySql.unidade = 0;
            }
            try
            {
                pMySql.quantidadeCesta = int.Parse(pAccess.quantidadeCesta.ToString());
            }
            catch
            {
                pMySql.quantidadeCesta = 0;
            }
            try
            {
                pMySql.numeroCesta = int.Parse(pAccess.numeroCesta.ToString());
            }
            catch
            {
                pMySql.numeroCesta = 0;
            }
            try
            {
                pMySql.num = int.Parse(pAccess.num.ToString());
            }
            catch
            {
                pMySql.num =0;
            }
            try
            {
                pMySql.quantidadeCaixa = int.Parse(pAccess.quantidadeCaixa.ToString());
            }
            catch
            {
                pMySql.quantidadeCaixa = 0;
            }
            try
            {
                pMySql.quantidadeFardo = int.Parse(pAccess.quantidadeFardo.ToString());
            }
            catch
            {
                pMySql.quantidadeFardo = 0;
            }
            try
            {
                pMySql.quantidadeDescer = int.Parse(pAccess.quantidadeDescer.ToString());
            }
            catch
            {
                pMySql.quantidadeDescer =0;
            }
            try
            {
                pMySql.quantidadeAvista = int.Parse(pAccess.quantidadeAvista.ToString());
            }
            catch
            {
                pMySql.quantidadeAvista = 0;
            }
            try
            {
                pMySql.controle = int.Parse(pAccess.controle.ToString());
            }
            catch
            {
                pMySql.controle = 0;
            }
            try
            {
                pMySql.quantidadeForn = int.Parse(pAccess.quantidadeForn.ToString());
            }
            catch
            {
                pMySql.quantidadeForn = 0;
            }
            try
            {
                pMySql.quantidadeKg = int.Parse(pAccess.quantidadeKg.ToString());
            }
            catch
            {
                pMySql.quantidadeKg = 0;
            }
            try
            {
                pMySql.totalMeses = int.Parse(pAccess.totalMeses.ToString());
            }
            catch
            {
                pMySql.totalMeses = 0;
            }


            pMySql.referencia = pAccess.referencia;
            pMySql.descricao = pAccess.descricao;
            pMySql.embalagem = pAccess.embalagem;
            pMySql.nome = pAccess.nome;
            pMySql.grama = pAccess.grama;
            pMySql.categoria = pAccess.categoria;
            try
            {
                pMySql.ultimaEntrada = pAccess.ultimaEntrada.ToString().Substring(0, 10).ToString();
            }
            catch(Exception a)
            {
                pMySql.ultimaEntrada = "00/00/0000";
            }
           
            pMySql.peso = pAccess.peso;
            pMySql.validade = pAccess.validade;
            
           
           
           
          
          
            



            //////////////////////////////////////////////////////
            if (pAccess.itensPedido.ToString().Equals("False"))
            {
                pMySql.itensPedido = "NÃO";
            }
            else
            {
                pMySql.itensPedido = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.anulado.ToString().Equals("False"))
            {
                pMySql.anulado = "NÃO";
            }
            else
            {
                pMySql.anulado = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.colocar.ToString().Equals("False"))
            {
                pMySql.colocar = "NÃO";
            }
            else
            {
                pMySql.colocar = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.multiplicar.ToString().Equals("False"))
            {
                pMySql.multiplicar = "NÃO";
            }
            else
            {
                pMySql.multiplicar = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.vender.ToString().Equals("False"))
            {
                pMySql.vender = "NÃO";
            }
            else
            {
                pMySql.vender = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.cdBalanco.ToString().Equals("False"))
            {
                pMySql.cdBalanco = "NÃO";
            }
            else
            {
                pMySql.cdBalanco = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.chCaixa.ToString().Equals("False"))
            {
                pMySql.chCaixa = "NÃO";
            }
            else
            {
                pMySql.chCaixa = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.cxFechado.ToString().Equals("False"))
            {
                pMySql.cxFechado = "NÃO";
            }
            else
            {
                pMySql.cxFechado = "SIM";
            }
            //////////////////////////////////////////////////////
            if (pAccess.liberarDescer.ToString().Equals("False"))
            {
                pMySql.liberarDescer = "NÃO";
            }
            else
            {
                pMySql.liberarDescer = "SIM";
            }
            ///////////////////////////////////////////////////////
           









        }


        public void GravarObjMySqlCodigo()
        {

            pMySql.codigoCodigo = pAccess.codigoCodigo;
            pMySql.descricaoCodigo = pAccess.descricaoCodigo;
            pMySql.referenciaCodigo = pAccess.referenciaCodigo;
            pMySql.controleCodigo = pAccess.controleCodigo;


        }

        public void GravarObjAccess()
        {
            pAccess.nome = pMySql.nome;
            pAccess.codigo = pMySql.codigo;
            pAccess.grama = pMySql.grama;
            pAccess.referencia = pMySql.referencia;
            pAccess.descricao = pMySql.descricao;
            pAccess.embalagem = pMySql.embalagem;
            pAccess.categoria = pMySql.categoria;
            try
            {
                pAccess.ultimaEntrada = pMySql.ultimaEntrada.ToString().Substring(0, 19).ToString();
            }
           catch(Exception a)
            {
                pAccess.ultimaEntrada = "11/11/1111 11:11:11";
            }//ultimaEntrada
            try
            {
                pAccess.iguala1 = int.Parse(pMySql.iguala1.ToString());
            }
            catch
            {
                pAccess.iguala1 = 0;
            }//iguala1
            try
            {
                pAccess.quantidade = int.Parse(pMySql.quantidade.ToString());
            }
            catch
            {
                pAccess.quantidade = 0;
            }//quantidade
            try
            {
                pAccess.custoUnitario = float.Parse(pMySql.custoUnitario.ToString());
            }
            catch
            {
                pAccess.custoUnitario = 0.00f;
            }//custoUnitario
            try
            {
                pAccess.margem = float.Parse(pMySql.margem.ToString());
            }
            catch
            {
                pAccess.margem = 0;
            }//margem
            try
            {
                pAccess.valorVenda = float.Parse(pMySql.valorVenda.ToString());
            }
            catch
            {
                pAccess.valorVenda = 0.00f;
            }//valorVenda
            try
            {
                pAccess.margemOnline = float.Parse(pMySql.margemOnline.ToString());
            }
            catch
            {
                pAccess.margemOnline = 0;
            }//margemOnline
            try
            {
                pAccess.valorVendaOnline = float.Parse(pMySql.valorVendaOnline.ToString());
            }
            catch
            {
                pAccess.valorVendaOnline = 0.00f;
            }//valorVendaOnline
            try
            {
                pAccess.quant = int.Parse(pMySql.quant.ToString());
            }
            catch
            {
                pAccess.quant = 0;
            }//quant
            try
            {
                pAccess.numero = int.Parse(pMySql.numero.ToString());
            }
            catch
            {
                pAccess.numero = 0;
            }//numero
            try
            {
                pAccess.unidade = int.Parse(pMySql.unidade.ToString());
            }
            catch
            {
                pAccess.unidade = 0;
            }//unidade
            try
            {
                pAccess.valorCesta = float.Parse(pMySql.valorCesta.ToString());
            }
            catch
            {
                pAccess.valorCesta = 0.00f;
            }//valorCesta
            try
            {
                pAccess.margemCesta = int.Parse(pMySql.margemCesta.ToString());
            }
            catch
            {
                pAccess.margemCesta = 0;
            }//margemCesta
            try
            {
                pAccess.quantidadeCesta = int.Parse(pMySql.quantidadeCesta.ToString());
            }
            catch
            {
                pAccess.quantidadeCesta = 0;
            }//quantidadeCesta
            try
            {
                pAccess.numeroCesta = int.Parse(pMySql.numeroCesta.ToString());
            }
            catch
            {
                pAccess.numeroCesta = 0;
            }//numeroCesta
            try
            {
                pAccess.num = int.Parse(pMySql.num.ToString());
            }
            catch
            {
                pAccess.num = 0;
            }//num
            try
            {
                pAccess.iguala = int.Parse(pMySql.iguala.ToString());
            }
            catch
            {
                pAccess.iguala = 0;
            }//iguala
            try
            {
                pAccess.valorPromocao = float.Parse(pMySql.valorPromocao.ToString());
            }
            catch
            {
                pAccess.valorPromocao = 0.00f;
            }//valorPromocao
            try
            {
                pAccess.margemPromocao = float.Parse(pMySql.margemPromocao.ToString());
            }
            catch
            {
                pAccess.margemPromocao = 0;
            }//margemPromocao
            try
            {
                pAccess.margemAvista = int.Parse(pMySql.margemAvista.ToString());
            }
            catch
            {
                pAccess.margemAvista = 0;
            }//margemAvista
            try
            {
                pAccess.margemCartao = int.Parse(pMySql.margemCartao.ToString());
            }
            catch
            {
                pAccess.margemCartao = 0;
            }//margemCartao
            try
            {
                pAccess.margemCheque = int.Parse(pMySql.margemCheque.ToString());
            }
            catch
            {
                pAccess.margemCheque = 0;
            }//margemCheque
            try
            {
                pAccess.avista = float.Parse(pMySql.avista.ToString());
            }
            catch
            {
                pAccess.avista = 0.00f;
            }//avista
            try
            {
                pAccess.cartao = float.Parse(pMySql.cartao.ToString());
            }
            catch
            {
                pAccess.cartao = 0.00f;
            }//cartao
            try
            {
                pAccess.cheque = float.Parse(pMySql.cheque.ToString());
            }
            catch
            {
                pAccess.cheque = 0.00f;
            }//cheque
            try
            {
                pAccess.peso = int.Parse(pMySql.peso.ToString());
            }
            catch
            {
                pAccess.peso = 0;
            }//peso
            try
            {
                pAccess.valorCartao = float.Parse(pMySql.valorCartao.ToString());
            }
            catch
            {
                pAccess.valorCartao = 0.00f;
            }//valorCartao
            try
            {
                pAccess.quantidadeCaixa = int.Parse(pMySql.quantidadeCaixa.ToString());
            }
            catch
            {
                pAccess.quantidadeCaixa = 0;
            }//quantCx
            try
            {
                pAccess.igualaCaixa = int.Parse(pMySql.igualaCaixa.ToString());
            }
            catch
            {
                pAccess.igualaCaixa = 0;
            }//igualaCx
            try
            {
                pAccess.validade = int.Parse(pMySql.validade.ToString());
            }
            catch
            {
                pAccess.validade = 0;
            }//Validade
            try
            {
                pAccess.controle = int.Parse(pMySql.controle.ToString());
            }
            catch
            {
                pAccess.controle = 0;
            }//Controle
            try
            {
                pAccess.quantidadeForn = int.Parse(pMySql.quantidadeForn.ToString());
            }
            catch
            {
                pAccess.quantidadeForn = 0;
            }//QuantForn
            try
            {
                pAccess.quantidadeKg = int.Parse(pMySql.quantidadeKg.ToString());
            }
            catch
            {
                pAccess.quantidadeKg = 0;
            }//QuantKg
            try
            {
                pAccess.totalMeses = int.Parse(pMySql.totalMeses.ToString());
            }
            catch
            {
                pAccess.totalMeses = 0;
            }//totalMeses
            try
            {
                pAccess.quantidadeFardo = int.Parse(pMySql.quantidadeFardo.ToString());
            }
            catch
            {
                pAccess.quantidadeFardo =0;
            }//QuantidadeFardo
            try
            {
                pAccess.quantidadeDescer = int.Parse(pMySql.quantidadeDescer.ToString());
            }
            catch
            {
                pAccess.quantidadeDescer = 0;
            }//QuantidadeDescer
            try
            {
                pAccess.quantidadeAvista = int.Parse(pMySql.quantidadeAvista.ToString());
            }
            catch
            {
                pAccess.quantidadeAvista =0;
            }//QuantidadeAvista
           
           
          
           
           
          
          

            if (pMySql.itensPedido.Equals("NÃO"))
            {
                pAccess.itensPedido = false;
            }
            else
            {
                pAccess.itensPedido = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.anulado.Equals("NÃO"))
            {
                pAccess.anulado = false;
            }
            else
            {
                pAccess.anulado = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.colocar.Equals("NÃO"))
            {
                pAccess.colocar = false;
            }
            else
            {
                pAccess.colocar = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.multiplicar.Equals("NÃO"))
            {
                pAccess.multiplicar = false;
            }
            else
            {
                pAccess.multiplicar = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.vender.Equals("NÃO"))
            {
                pAccess.vender = false;
            }
            else
            {
                pAccess.vender = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.cdBalanco.Equals("NÃO"))
            {
                pAccess.cdBalanco = false;
            }
            else
            {
                pAccess.cdBalanco = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.chCaixa.Equals("NÃO"))
            {
                pAccess.chCaixa = false;
            }
            else
            {
                pAccess.chCaixa = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.cxFechado.Equals("NÃO"))
            {
                pAccess.cxFechado = false;
            }
            else
            {
                pAccess.cxFechado = true;
            }
            //////////////////////////////////////////////////////////////////
            if (pMySql.liberarDescer.Equals("NÃO"))
            {
                pAccess.liberarDescer = false;
            }
            else
            {
                pAccess.liberarDescer = true;
            }
          



        }

        public void GravarObjAccessCodigo()
        {
            pAccess.codigoCodigo = pMySql.codigoCodigo;
            pAccess.descricaoCodigo = pMySql.descricaoCodigo;
            pAccess.controleCodigo = pMySql.controleCodigo;
            pAccess.referenciaCodigo = pMySql.referenciaCodigo;
        }


        #endregion
        #region EventosBtns
        public void AtualizacaoMySqlAccess()
        {
            pMySql.TotalLinhasAtualizacao();

            if (totalLinhaInicialProdutoRegistro != pMySql.totalLinhasProdutoRegistro)
            {
                pMySql.ProdutoAlterado();
                pMySql.BuscarDadosProdutosMySql(pMySql.codigoProdutoAtualizado);
                GravarObjAccess();
                pAccess.UpdateAccess(pMySql.codigoProdutoAtualizado.ToString());

                if (pMySql.igualaProdutoAtualizado > 0 && pMySql.chCaixaProdutoAtualizado.ToString().Equals("NÃO") && pMySql.igualaCaixaProdutoAtualizado == 0)
                {
                  pAccess.UpdateAccessIguala(pMySql.igualaProdutoAtualizado);
                }
                if (pMySql.igualaCaixaProdutoAtualizado > 0 && pMySql.chCaixaProdutoAtualizado.ToString().Equals("NÃO") && pMySql.igualaProdutoAtualizado == 0)
                {
                   
                    pAccess.BuscarDadosProdutosCxAccess(pMySql.igualaCaixaProdutoAtualizado);
                   
                    pAccess.UpdateAccessIgualaCx(pAccess.codigo.ToString(),pMySql.quantUniAtualizado);

                }

                if (pMySql.igualaProdutoAtualizado > 0 && pMySql.igualaCaixaProdutoAtualizado > 0 && pMySql.chCaixaProdutoAtualizado.ToString().Equals("NÃO"))
                {
                    pAccess.UpdateAccessIguala(pMySql.igualaProdutoAtualizado);
                    pAccess.BuscarDadosProdutosCxAccess(pMySql.igualaCaixaProdutoAtualizado);
                    pAccess.UpdateAccessIgualaCx(pAccess.codigo.ToString(), pMySql.quantUniAtualizado);
                    //busco iguala do meu fardo --- e aplico iguala nos fardos
                    pAccess.BuscarDadosProdutosAccess(int.Parse(pAccess.codigo.ToString()));

                    if (int.Parse(pAccess.iguala.ToString())>0)
                    {
                        int z = int.Parse(pAccess.iguala.ToString());
                        pAccess.UpdateAccessIgualaFardo(z);
                    }
                  
                }

                totalLinhaInicialProdutoRegistro = pMySql.totalLinhasProdutoRegistro;
            }
        
        }
        public void InsertMySqlAccess()
        {
            pAccess.TotalLinhasProdutos();
            pMySql.TotalLinhasProdutos();
            // MessageBox.Show("Access " + fAccess.totalLinhasFornecedorAccess + "   MySql " + fMySql.totalLinhasFornecedorMySql);
            if (pAccess.totalLinhasProdutosAccess < pMySql.totalLinhasProdutoMySql)
            {
                pMySql.UltimoCodigoProdutos();
                GravarObjAccess();
                pAccess.InsertAccess();
            }
        }
        public void InsertPCodigo()
        {
            pAccess.TotalLinhasProdutoCodigo();
            pMySql.TotalLinhasProdutosCodigo();
            // MessageBox.Show("Access " + fAccess.totalLinhasFornecedorCodigoAccess + "   MySql " + fMySql.totalLinhasFornecedorCodigoMySql);
            if (pAccess.totalLinhasProdutosCodigoAccess < pMySql.totalLinhasProdutoCodigoMySql)
            {
                pMySql.UltimoCodigoProdutoCodigo();
                GravarObjAccessCodigo();
                pAccess.InsertAccessCodigo();
            }
        }
        public void DeletarPCodigo()
        {
            pMySql.TotalLinhasProdutoCodigoDelete();
            if (totalLinhaInicialProdutoCodigoAtualizacao < pMySql.totalLinhasProdutosCodigoDeleteMySql)
            {
                pMySql.UltimoIdProdutoCodigoDelete();
                pAccess.DeleteProdutoCodigo(pMySql.referenciaCodigo.ToString());
                totalLinhaInicialProdutoCodigoAtualizacao = pMySql.totalLinhasProdutosCodigoDeleteMySql;
            }
        }
        #endregion

       
    }
}
