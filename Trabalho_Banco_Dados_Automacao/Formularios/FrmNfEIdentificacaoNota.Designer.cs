namespace RoboDataBase.Formularios
{
    partial class FrmNfEIdentificacaoNota
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
            this.btnLimparMySql = new System.Windows.Forms.Button();
            this.btnInsertAccessforMySQL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMySql = new System.Windows.Forms.DataGridView();
            this.btnBuscarMySql = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAccess = new System.Windows.Forms.DataGridView();
            this.btnBuscarAccess = new System.Windows.Forms.Button();
            this.btnAtualizarTruncate = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimparMySql
            // 
            this.btnLimparMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparMySql.Location = new System.Drawing.Point(916, 426);
            this.btnLimparMySql.Name = "btnLimparMySql";
            this.btnLimparMySql.Size = new System.Drawing.Size(77, 24);
            this.btnLimparMySql.TabIndex = 36;
            this.btnLimparMySql.Text = "Limpar";
            this.btnLimparMySql.UseVisualStyleBackColor = false;
            this.btnLimparMySql.Click += new System.EventHandler(this.btnLimparMySql_Click);
            // 
            // btnInsertAccessforMySQL
            // 
            this.btnInsertAccessforMySQL.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertAccessforMySQL.Location = new System.Drawing.Point(23, 485);
            this.btnInsertAccessforMySQL.Name = "btnInsertAccessforMySQL";
            this.btnInsertAccessforMySQL.Size = new System.Drawing.Size(136, 50);
            this.btnInsertAccessforMySQL.TabIndex = 33;
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
            this.label2.Location = new System.Drawing.Point(672, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Banco de Dados MySql";
            // 
            // dataGridViewMySql
            // 
            this.dataGridViewMySql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySql.Location = new System.Drawing.Point(528, 87);
            this.dataGridViewMySql.Name = "dataGridViewMySql";
            this.dataGridViewMySql.Size = new System.Drawing.Size(465, 333);
            this.dataGridViewMySql.TabIndex = 31;
            // 
            // btnBuscarMySql
            // 
            this.btnBuscarMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMySql.Location = new System.Drawing.Point(528, 426);
            this.btnBuscarMySql.Name = "btnBuscarMySql";
            this.btnBuscarMySql.Size = new System.Drawing.Size(136, 50);
            this.btnBuscarMySql.TabIndex = 30;
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
            this.label3.Location = new System.Drawing.Point(323, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 55);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nf-E-Identificação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Banco de Dados Access";
            // 
            // dataGridViewAccess
            // 
            this.dataGridViewAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccess.Location = new System.Drawing.Point(23, 87);
            this.dataGridViewAccess.Name = "dataGridViewAccess";
            this.dataGridViewAccess.Size = new System.Drawing.Size(465, 333);
            this.dataGridViewAccess.TabIndex = 27;
            // 
            // btnBuscarAccess
            // 
            this.btnBuscarAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAccess.Location = new System.Drawing.Point(23, 426);
            this.btnBuscarAccess.Name = "btnBuscarAccess";
            this.btnBuscarAccess.Size = new System.Drawing.Size(136, 50);
            this.btnBuscarAccess.TabIndex = 26;
            this.btnBuscarAccess.Text = "Buscar Access";
            this.btnBuscarAccess.UseVisualStyleBackColor = false;
            this.btnBuscarAccess.Click += new System.EventHandler(this.btnBuscarAccess_Click);
            // 
            // btnAtualizarTruncate
            // 
            this.btnAtualizarTruncate.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizarTruncate.Location = new System.Drawing.Point(528, 482);
            this.btnAtualizarTruncate.Name = "btnAtualizarTruncate";
            this.btnAtualizarTruncate.Size = new System.Drawing.Size(136, 50);
            this.btnAtualizarTruncate.TabIndex = 39;
            this.btnAtualizarTruncate.Text = "Atualizar";
            this.btnAtualizarTruncate.UseVisualStyleBackColor = false;
            this.btnAtualizarTruncate.Click += new System.EventHandler(this.btnAtualizarTruncate_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Location = new System.Drawing.Point(352, 485);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(136, 50);
            this.btnAtualizar.TabIndex = 42;
            this.btnAtualizar.Text = "atualizar Access-->MySql";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmNfEIdentificacaoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RoboDataBase.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 575);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAtualizarTruncate);
            this.Controls.Add(this.btnLimparMySql);
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
            this.Name = "FrmNfEIdentificacaoNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robo Banco de Dados NfEIdentificacaoNota";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNfEIdentificacaoNota_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimparMySql;
        private System.Windows.Forms.Button btnInsertAccessforMySQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMySql;
        private System.Windows.Forms.Button btnBuscarMySql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAccess;
        private System.Windows.Forms.Button btnBuscarAccess;
        private System.Windows.Forms.Button btnAtualizarTruncate;
        private System.Windows.Forms.Button btnAtualizar;
    }
}