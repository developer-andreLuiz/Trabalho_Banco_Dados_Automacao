namespace RoboDataBase.Formularios
{
    partial class FrmNfEProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntAtualizacao = new System.Windows.Forms.Button();
            this.btnLimparMySql = new System.Windows.Forms.Button();
            this.btnMantemAtualizado = new System.Windows.Forms.Button();
            this.btnInsertAccessforMySQL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMySql = new System.Windows.Forms.DataGridView();
            this.btnBuscarMySql = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAccess = new System.Windows.Forms.DataGridView();
            this.btnBuscarAccess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAtualizacao
            // 
            this.bntAtualizacao.BackColor = System.Drawing.Color.Transparent;
            this.bntAtualizacao.Location = new System.Drawing.Point(528, 508);
            this.bntAtualizacao.Name = "bntAtualizacao";
            this.bntAtualizacao.Size = new System.Drawing.Size(136, 50);
            this.bntAtualizacao.TabIndex = 49;
            this.bntAtualizacao.Text = "Apaga e Atualiza";
            this.bntAtualizacao.UseVisualStyleBackColor = false;
            this.bntAtualizacao.Click += new System.EventHandler(this.bntAtualizacao_Click);
            // 
            // btnLimparMySql
            // 
            this.btnLimparMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparMySql.Location = new System.Drawing.Point(916, 439);
            this.btnLimparMySql.Name = "btnLimparMySql";
            this.btnLimparMySql.Size = new System.Drawing.Size(77, 24);
            this.btnLimparMySql.TabIndex = 48;
            this.btnLimparMySql.Text = "Limpar";
            this.btnLimparMySql.UseVisualStyleBackColor = false;
            this.btnLimparMySql.Click += new System.EventHandler(this.btnLimparMySql_Click);
            // 
            // btnMantemAtualizado
            // 
            this.btnMantemAtualizado.BackColor = System.Drawing.Color.Transparent;
            this.btnMantemAtualizado.Location = new System.Drawing.Point(352, 508);
            this.btnMantemAtualizado.Name = "btnMantemAtualizado";
            this.btnMantemAtualizado.Size = new System.Drawing.Size(136, 50);
            this.btnMantemAtualizado.TabIndex = 46;
            this.btnMantemAtualizado.Text = "Mantem Atualizado";
            this.btnMantemAtualizado.UseVisualStyleBackColor = false;
            this.btnMantemAtualizado.Click += new System.EventHandler(this.btnMantemAtualizado_Click);
            // 
            // btnInsertAccessforMySQL
            // 
            this.btnInsertAccessforMySQL.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertAccessforMySQL.Location = new System.Drawing.Point(23, 508);
            this.btnInsertAccessforMySQL.Name = "btnInsertAccessforMySQL";
            this.btnInsertAccessforMySQL.Size = new System.Drawing.Size(136, 50);
            this.btnInsertAccessforMySQL.TabIndex = 45;
            this.btnInsertAccessforMySQL.Text = "Insert Access-->MySql";
            this.btnInsertAccessforMySQL.UseVisualStyleBackColor = false;
            this.btnInsertAccessforMySQL.Click += new System.EventHandler(this.btnInsertAccessforMySQL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(672, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Banco de Dados MySql";
            // 
            // dataGridViewMySql
            // 
            this.dataGridViewMySql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySql.Location = new System.Drawing.Point(528, 100);
            this.dataGridViewMySql.Name = "dataGridViewMySql";
            this.dataGridViewMySql.Size = new System.Drawing.Size(465, 333);
            this.dataGridViewMySql.TabIndex = 43;
            // 
            // btnBuscarMySql
            // 
            this.btnBuscarMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMySql.Location = new System.Drawing.Point(528, 439);
            this.btnBuscarMySql.Name = "btnBuscarMySql";
            this.btnBuscarMySql.Size = new System.Drawing.Size(136, 50);
            this.btnBuscarMySql.TabIndex = 42;
            this.btnBuscarMySql.Text = "Buscar MySql";
            this.btnBuscarMySql.UseVisualStyleBackColor = false;
            this.btnBuscarMySql.Click += new System.EventHandler(this.btnBuscarMySql_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 55);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nf-E-Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Banco de Dados Access";
            // 
            // dataGridViewAccess
            // 
            this.dataGridViewAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccess.Location = new System.Drawing.Point(23, 100);
            this.dataGridViewAccess.Name = "dataGridViewAccess";
            this.dataGridViewAccess.Size = new System.Drawing.Size(465, 333);
            this.dataGridViewAccess.TabIndex = 39;
            // 
            // btnBuscarAccess
            // 
            this.btnBuscarAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAccess.Location = new System.Drawing.Point(23, 439);
            this.btnBuscarAccess.Name = "btnBuscarAccess";
            this.btnBuscarAccess.Size = new System.Drawing.Size(136, 50);
            this.btnBuscarAccess.TabIndex = 38;
            this.btnBuscarAccess.Text = "Buscar Access";
            this.btnBuscarAccess.UseVisualStyleBackColor = false;
            this.btnBuscarAccess.Click += new System.EventHandler(this.btnBuscarAccess_Click);
            // 
            // FrmNfEProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RoboDataBase.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 575);
            this.Controls.Add(this.bntAtualizacao);
            this.Controls.Add(this.btnLimparMySql);
            this.Controls.Add(this.btnMantemAtualizado);
            this.Controls.Add(this.btnInsertAccessforMySQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMySql);
            this.Controls.Add(this.btnBuscarMySql);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAccess);
            this.Controls.Add(this.btnBuscarAccess);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmNfEProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robo Banco de Dados NfEProdutos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNfEProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAtualizacao;
        private System.Windows.Forms.Button btnLimparMySql;
        private System.Windows.Forms.Button btnMantemAtualizado;
        private System.Windows.Forms.Button btnInsertAccessforMySQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMySql;
        private System.Windows.Forms.Button btnBuscarMySql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAccess;
        private System.Windows.Forms.Button btnBuscarAccess;
    }
}