namespace RoboDataBase.Formularios
{
    partial class FrmFornecedor
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
            this.bntAtualizacaoMySqlAccess = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLimparMySql = new System.Windows.Forms.Button();
            this.btnInsertMySqlforAccess = new System.Windows.Forms.Button();
            this.btnInsertAccessforMySQL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMySql = new System.Windows.Forms.DataGridView();
            this.btnBuscarMySql = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAccess = new System.Windows.Forms.DataGridView();
            this.btnBuscarAccess = new System.Windows.Forms.Button();
            this.btnInsertFCodigoAccessforMySQL = new System.Windows.Forms.Button();
            this.btnInsertFCodigo = new System.Windows.Forms.Button();
            this.btnDeletarFCodigo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAtualizacaoMySqlAccess
            // 
            this.bntAtualizacaoMySqlAccess.BackColor = System.Drawing.Color.Transparent;
            this.bntAtualizacaoMySqlAccess.Location = new System.Drawing.Point(528, 434);
            this.bntAtualizacaoMySqlAccess.Name = "bntAtualizacaoMySqlAccess";
            this.bntAtualizacaoMySqlAccess.Size = new System.Drawing.Size(95, 35);
            this.bntAtualizacaoMySqlAccess.TabIndex = 38;
            this.bntAtualizacaoMySqlAccess.Text = "Atualização\r\n";
            this.bntAtualizacaoMySqlAccess.UseVisualStyleBackColor = false;
            this.bntAtualizacaoMySqlAccess.Click += new System.EventHandler(this.bntAtualizacaoMySqlAccess_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(17, 482);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 23);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "xxxxxxxxxxxxx";
            // 
            // btnLimparMySql
            // 
            this.btnLimparMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparMySql.Location = new System.Drawing.Point(527, 404);
            this.btnLimparMySql.Name = "btnLimparMySql";
            this.btnLimparMySql.Size = new System.Drawing.Size(77, 24);
            this.btnLimparMySql.TabIndex = 36;
            this.btnLimparMySql.Text = "Limpar";
            this.btnLimparMySql.UseVisualStyleBackColor = false;
            this.btnLimparMySql.Click += new System.EventHandler(this.btnLimparMySql_Click);
            // 
            // btnInsertMySqlforAccess
            // 
            this.btnInsertMySqlforAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertMySqlforAccess.Location = new System.Drawing.Point(429, 434);
            this.btnInsertMySqlforAccess.Name = "btnInsertMySqlforAccess";
            this.btnInsertMySqlforAccess.Size = new System.Drawing.Size(93, 35);
            this.btnInsertMySqlforAccess.TabIndex = 34;
            this.btnInsertMySqlforAccess.Text = "Insert ";
            this.btnInsertMySqlforAccess.UseVisualStyleBackColor = false;
            this.btnInsertMySqlforAccess.Click += new System.EventHandler(this.btnInsertMySqlforAccess_Click);
            // 
            // btnInsertAccessforMySQL
            // 
            this.btnInsertAccessforMySQL.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertAccessforMySQL.Location = new System.Drawing.Point(21, 434);
            this.btnInsertAccessforMySQL.Name = "btnInsertAccessforMySQL";
            this.btnInsertAccessforMySQL.Size = new System.Drawing.Size(101, 35);
            this.btnInsertAccessforMySQL.TabIndex = 33;
            this.btnInsertAccessforMySQL.Text = "Preencher";
            this.btnInsertAccessforMySQL.UseVisualStyleBackColor = false;
            this.btnInsertAccessforMySQL.Click += new System.EventHandler(this.btnInsertAccessforMySQL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(620, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Banco de Dados MySql";
            // 
            // dataGridViewMySql
            // 
            this.dataGridViewMySql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySql.Location = new System.Drawing.Point(429, 65);
            this.dataGridViewMySql.Name = "dataGridViewMySql";
            this.dataGridViewMySql.Size = new System.Drawing.Size(381, 333);
            this.dataGridViewMySql.TabIndex = 31;
            // 
            // btnBuscarMySql
            // 
            this.btnBuscarMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMySql.Location = new System.Drawing.Point(429, 404);
            this.btnBuscarMySql.Name = "btnBuscarMySql";
            this.btnBuscarMySql.Size = new System.Drawing.Size(92, 24);
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
            this.label3.Location = new System.Drawing.Point(294, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 55);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Banco de Dados Access";
            // 
            // dataGridViewAccess
            // 
            this.dataGridViewAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccess.Location = new System.Drawing.Point(21, 65);
            this.dataGridViewAccess.Name = "dataGridViewAccess";
            this.dataGridViewAccess.Size = new System.Drawing.Size(379, 333);
            this.dataGridViewAccess.TabIndex = 27;
            // 
            // btnBuscarAccess
            // 
            this.btnBuscarAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAccess.Location = new System.Drawing.Point(21, 404);
            this.btnBuscarAccess.Name = "btnBuscarAccess";
            this.btnBuscarAccess.Size = new System.Drawing.Size(101, 24);
            this.btnBuscarAccess.TabIndex = 26;
            this.btnBuscarAccess.Text = "Buscar Access";
            this.btnBuscarAccess.UseVisualStyleBackColor = false;
            this.btnBuscarAccess.Click += new System.EventHandler(this.btnBuscarAccess_Click);
            // 
            // btnInsertFCodigoAccessforMySQL
            // 
            this.btnInsertFCodigoAccessforMySQL.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertFCodigoAccessforMySQL.Location = new System.Drawing.Point(128, 434);
            this.btnInsertFCodigoAccessforMySQL.Name = "btnInsertFCodigoAccessforMySQL";
            this.btnInsertFCodigoAccessforMySQL.Size = new System.Drawing.Size(114, 35);
            this.btnInsertFCodigoAccessforMySQL.TabIndex = 39;
            this.btnInsertFCodigoAccessforMySQL.Text = "Preencher F.Codigo";
            this.btnInsertFCodigoAccessforMySQL.UseVisualStyleBackColor = false;
            this.btnInsertFCodigoAccessforMySQL.Click += new System.EventHandler(this.btnInsertFCodigoAccessforMySQL_Click);
            // 
            // btnInsertFCodigo
            // 
            this.btnInsertFCodigo.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertFCodigo.Location = new System.Drawing.Point(629, 434);
            this.btnInsertFCodigo.Name = "btnInsertFCodigo";
            this.btnInsertFCodigo.Size = new System.Drawing.Size(103, 35);
            this.btnInsertFCodigo.TabIndex = 40;
            this.btnInsertFCodigo.Text = "Insert F Codigo";
            this.btnInsertFCodigo.UseVisualStyleBackColor = false;
            this.btnInsertFCodigo.Click += new System.EventHandler(this.btnInsertFCodigo_Click);
            // 
            // btnDeletarFCodigo
            // 
            this.btnDeletarFCodigo.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletarFCodigo.Location = new System.Drawing.Point(739, 434);
            this.btnDeletarFCodigo.Name = "btnDeletarFCodigo";
            this.btnDeletarFCodigo.Size = new System.Drawing.Size(103, 35);
            this.btnDeletarFCodigo.TabIndex = 42;
            this.btnDeletarFCodigo.Text = "Deletar F Codigo\r\n";
            this.btnDeletarFCodigo.UseVisualStyleBackColor = false;
            this.btnDeletarFCodigo.Click += new System.EventHandler(this.btnDeletarFCodigo_Click);
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RoboDataBase.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.Controls.Add(this.btnDeletarFCodigo);
            this.Controls.Add(this.btnInsertFCodigo);
            this.Controls.Add(this.btnInsertFCodigoAccessforMySQL);
            this.Controls.Add(this.bntAtualizacaoMySqlAccess);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLimparMySql);
            this.Controls.Add(this.btnInsertMySqlforAccess);
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
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFornecedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFornecedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAtualizacaoMySqlAccess;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLimparMySql;
        private System.Windows.Forms.Button btnInsertMySqlforAccess;
        private System.Windows.Forms.Button btnInsertAccessforMySQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMySql;
        private System.Windows.Forms.Button btnBuscarMySql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAccess;
        private System.Windows.Forms.Button btnBuscarAccess;
        private System.Windows.Forms.Button btnInsertFCodigoAccessforMySQL;
        private System.Windows.Forms.Button btnInsertFCodigo;
        private System.Windows.Forms.Button btnDeletarFCodigo;
    }
}