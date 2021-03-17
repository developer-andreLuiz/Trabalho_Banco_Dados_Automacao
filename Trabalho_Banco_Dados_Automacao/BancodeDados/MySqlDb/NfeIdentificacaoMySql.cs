using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDataBase.BancodeDados.MySqlDb
{
    class NfeIdentificacaoMySql
    {
        MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

        #region Variaveis 
        public object id;
        public object cnpj;
        public object cod_fornecedor;
        public object nome_fornecedor;
        public object c_uf;
        public object c_nf;
        public object nat_op;
        public object ind_pad;
        public object new_mod;
        public object serie;
        public object n_nf;
        public object ind_pres;
        public object ind_final;
        public object id_dest;
        public object dh_cont;
        public object d_emi;
        public object d_sai_ent;
        public object h_sai_ent;
        public object tp_nf;
        public object c_mun_fg;
        public object dh_saient;
        public object tp_imp;
        public object tp_emis;
        public object d_hemi;
        public object c_dv;
        public object tp_amb;
        public object fin_nfe;
        public object proc_emi;
        public object ver_proc;
        public object v_bc;
        public object v_icms;
        public object v_bcst;
        public object v_st;
        public object v_prod;
        public object v_frete;
        public object v_seg;
        public object v_desc;
        public object v_ii;
        public object x_just;
        public object v_ipi;
        public object v_pis;
        public object v_confis;
        public object v_outro;
        public object v_nf;
        public object v_tot_trib;
        public object iss_qn_tot_v_serv;
        public object iss_qn_tot_v_bc;
        public object iss_qn_tot_v_iss;
        public object iss_qn_tot_v_pis;
        public object iss_qn_tot_v_cofins;
        public object fat_n_fat;
        public object fat_v_orig;
        public object fat_v_desc;
        public object fat_v_liq;
        public object num;
        public object confer;
        public object nota_br;
        public object iguala_nota;

        public int totalLinhasMySql;
        #endregion


        /// <summary>
        /// Insere novos dados na tabela tb_nfe_identificacao_nota
        /// </summary>
        public void InserirDados()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_nfe_identificacao_nota (id,cnpj,cod_fornecedor,nome_fornecedor,c_uf,c_nf,nat_op,ind_pad,new_mod,serie,n_nf,ind_pres,ind_final,id_dest,dh_cont,d_emi,d_sai_ent,h_sai_ent,tp_nf,c_mun_fg,dh_saient,tp_imp,tp_emis,d_hemi,c_dv,tp_amb,fin_nfe,proc_emi,ver_proc,v_bc,v_icms,v_bcst,v_st,v_prod,v_frete,v_seg,v_desc,v_ii,x_just,v_ipi,v_pis,v_confis,v_outro,v_nf,v_tot_trib,iss_qn_tot_v_serv,iss_qn_tot_v_bc,iss_qn_tot_v_iss,iss_qn_tot_v_pis,iss_qn_tot_v_cofins,fat_n_fat,fat_v_orig,fat_v_desc,fat_v_liq,num,confer,nota_br,iguala_nota) values (@id,@cnpj,@cod_fornecedor,@nome_fornecedor,@c_uf,@c_nf,@nat_op,@ind_pad,@new_mod,@serie,@n_nf,@ind_pres,@ind_final,@id_dest,@dh_cont,@d_emi,@d_sai_ent,@h_sai_ent,@tp_nf,@c_mun_fg,@dh_saient,@tp_imp,@tp_emis,@d_hemi,@c_dv,@tp_amb,@fin_nfe,@proc_emi,@ver_proc,@v_bc,@v_icms,@v_bcst,@v_st,@v_prod,@v_frete,@v_seg,@v_desc,@v_ii,@x_just,@v_ipi,@v_pis,@v_confis,@v_outro,@v_nf,@v_tot_trib,@iss_qn_tot_v_serv,@iss_qn_tot_v_bc,@iss_qn_tot_v_iss,@iss_qn_tot_v_pis,@iss_qn_tot_v_cofins,@fat_n_fat,@fat_v_orig,@fat_v_desc,@fat_v_liq,@num,@confer,@nota_br,@iguala_nota);";
               
                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("cnpj", cnpj);
                comando.Parameters.AddWithValue("cod_fornecedor", cod_fornecedor);
                comando.Parameters.AddWithValue("nome_fornecedor", nome_fornecedor);
                comando.Parameters.AddWithValue("c_uf", c_uf);
                comando.Parameters.AddWithValue("c_nf", c_nf);
                comando.Parameters.AddWithValue("nat_op", nat_op);
                comando.Parameters.AddWithValue("ind_pad", ind_pad);
                comando.Parameters.AddWithValue("new_mod", new_mod);
                comando.Parameters.AddWithValue("serie", serie);
                comando.Parameters.AddWithValue("n_nf", n_nf);
                comando.Parameters.AddWithValue("ind_pres", ind_pres);
                comando.Parameters.AddWithValue("ind_final", ind_final);
                comando.Parameters.AddWithValue("id_dest", id_dest);
                comando.Parameters.AddWithValue("dh_cont", dh_cont);
                comando.Parameters.AddWithValue("d_emi", d_emi);
                comando.Parameters.AddWithValue("d_sai_ent", d_sai_ent);
                comando.Parameters.AddWithValue("h_sai_ent", h_sai_ent);
                comando.Parameters.AddWithValue("tp_nf", tp_nf);
                comando.Parameters.AddWithValue("c_mun_fg", c_mun_fg);
                comando.Parameters.AddWithValue("dh_saient", dh_saient);
                comando.Parameters.AddWithValue("tp_imp", tp_imp);
                comando.Parameters.AddWithValue("tp_emis", tp_emis);
                comando.Parameters.AddWithValue("d_hemi", d_hemi);
                comando.Parameters.AddWithValue("c_dv", c_dv);
                comando.Parameters.AddWithValue("tp_amb", tp_amb);
                comando.Parameters.AddWithValue("fin_nfe", fin_nfe);
                comando.Parameters.AddWithValue("proc_emi", proc_emi);
                comando.Parameters.AddWithValue("ver_proc",ver_proc);
                comando.Parameters.AddWithValue("v_bc", v_bc);
                comando.Parameters.AddWithValue("v_icms", v_icms);
                comando.Parameters.AddWithValue("v_bcst", v_bcst);
                comando.Parameters.AddWithValue("v_st", v_st);
                comando.Parameters.AddWithValue("v_prod", v_prod);
                comando.Parameters.AddWithValue("v_frete",v_frete);
                comando.Parameters.AddWithValue("v_seg",v_seg);
                comando.Parameters.AddWithValue("v_desc", v_desc);
                comando.Parameters.AddWithValue("v_ii", v_ii);
                comando.Parameters.AddWithValue("x_just", x_just);
                comando.Parameters.AddWithValue("v_ipi", v_ipi);
                comando.Parameters.AddWithValue("v_pis", v_pis);
                comando.Parameters.AddWithValue("v_confis", v_confis);
                comando.Parameters.AddWithValue("v_outro", v_outro);
                comando.Parameters.AddWithValue("v_nf", v_nf);
                comando.Parameters.AddWithValue("v_tot_trib", v_tot_trib);
                comando.Parameters.AddWithValue("iss_qn_tot_v_serv", iss_qn_tot_v_serv);
                comando.Parameters.AddWithValue("iss_qn_tot_v_bc", iss_qn_tot_v_bc);
                comando.Parameters.AddWithValue("iss_qn_tot_v_iss", iss_qn_tot_v_iss);
                comando.Parameters.AddWithValue("iss_qn_tot_v_pis", iss_qn_tot_v_pis);
                comando.Parameters.AddWithValue("iss_qn_tot_v_cofins", iss_qn_tot_v_cofins);
                comando.Parameters.AddWithValue("fat_n_fat", fat_n_fat);
                comando.Parameters.AddWithValue("fat_v_orig", fat_v_orig);
                comando.Parameters.AddWithValue("fat_v_desc", fat_v_desc);
                comando.Parameters.AddWithValue("fat_v_liq", fat_v_liq);
                comando.Parameters.AddWithValue("num", num);
                comando.Parameters.AddWithValue("confer", confer);
                comando.Parameters.AddWithValue("nota_br", nota_br);
                comando.Parameters.AddWithValue("iguala_nota", iguala_nota);


                comando.ExecuteNonQuery();

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
        /// Exibe dados da tabela tb_nfe_identificacao_nota no DataGrid
        /// </summary>
        /// <param name="dataGridView"></param>
        public void CarregarDataGridMySql(DataGridView dataGridView)
        {
            try
            {
                string strgComando = "select * from tb_nfe_identificacao_nota order by num asc;";

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                MySqlCommand comando = new MySqlCommand(strgComando, conexao);


                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(comando);

                DataTable dtLista = new DataTable();

                sqlDataAdapter.Fill(dtLista);

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
        /// Reseta e deleta os dados na tabela tb_nfe_identificacao_nota
        /// </summary>
        public void TruncateTable()
        {
            try
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "truncate table tb_nfe_identificacao_nota;";
                comando.ExecuteNonQuery();


            }
            catch (Exception a)
            {
               // MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Retorna Total de linhas tb_nfe_identificacao_nota
        /// </summary>
        public void TotalLinhasMySql()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select count(num) as total FROM tb_nfe_identificacao_nota; ";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    totalLinhasMySql = int.Parse(reader["total"].ToString());
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
