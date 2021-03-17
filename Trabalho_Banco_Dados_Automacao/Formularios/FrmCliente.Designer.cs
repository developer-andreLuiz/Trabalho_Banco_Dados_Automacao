namespace RoboDataBase
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAccess = new System.Windows.Forms.DataGridView();
            this.btnBuscarAccess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMySql = new System.Windows.Forms.DataGridView();
            this.btnBuscarMySql = new System.Windows.Forms.Button();
            this.btnInsertAccessforMySQL = new System.Windows.Forms.Button();
            this.btnInsertMySqlforAccess = new System.Windows.Forms.Button();
            this.btnLimparMySql = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bntAtualizacaoMySqlAccess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(410, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 55);
            this.label3.TabIndex = 15;
            this.label3.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Banco de Dados Access";
            // 
            // dataGridViewAccess
            // 
            this.dataGridViewAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccess.Location = new System.Drawing.Point(21, 66);
            this.dataGridViewAccess.Name = "dataGridViewAccess";
            this.dataGridViewAccess.Size = new System.Drawing.Size(465, 333);
            this.dataGridViewAccess.TabIndex = 10;
            // 
            // btnBuscarAccess
            // 
            this.btnBuscarAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAccess.Location = new System.Drawing.Point(21, 405);
            this.btnBuscarAccess.Name = "btnBuscarAccess";
            this.btnBuscarAccess.Size = new System.Drawing.Size(136, 50);
            this.btnBuscarAccess.TabIndex = 9;
            this.btnBuscarAccess.Text = "Buscar Access";
            this.btnBuscarAccess.UseVisualStyleBackColor = false;
            this.btnBuscarAccess.Click += new System.EventHandler(this.btnBuscarAccess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(670, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Banco de Dados MySql";
            // 
            // dataGridViewMySql
            // 
            this.dataGridViewMySql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySql.Location = new System.Drawing.Point(526, 66);
            this.dataGridViewMySql.Name = "dataGridViewMySql";
            this.dataGridViewMySql.Size = new System.Drawing.Size(465, 333);
            this.dataGridViewMySql.TabIndex = 17;
            // 
            // btnBuscarMySql
            // 
            this.btnBuscarMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMySql.Location = new System.Drawing.Point(526, 405);
            this.btnBuscarMySql.Name = "btnBuscarMySql";
            this.btnBuscarMySql.Size = new System.Drawing.Size(136, 50);
            this.btnBuscarMySql.TabIndex = 16;
            this.btnBuscarMySql.Text = "Buscar MySql";
            this.btnBuscarMySql.UseVisualStyleBackColor = false;
            this.btnBuscarMySql.Click += new System.EventHandler(this.btnBuscarMySql_Click);
            // 
            // btnInsertAccessforMySQL
            // 
            this.btnInsertAccessforMySQL.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertAccessforMySQL.Location = new System.Drawing.Point(21, 474);
            this.btnInsertAccessforMySQL.Name = "btnInsertAccessforMySQL";
            this.btnInsertAccessforMySQL.Size = new System.Drawing.Size(136, 50);
            this.btnInsertAccessforMySQL.TabIndex = 19;
            this.btnInsertAccessforMySQL.Text = "Insert Clientes\r\nAccess-->MySql";
            this.btnInsertAccessforMySQL.UseVisualStyleBackColor = false;
            this.btnInsertAccessforMySQL.Click += new System.EventHandler(this.btnInsertAccessforMySQL_Click);
            // 
            // btnInsertMySqlforAccess
            // 
            this.btnInsertMySqlforAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertMySqlforAccess.Location = new System.Drawing.Point(526, 474);
            this.btnInsertMySqlforAccess.Name = "btnInsertMySqlforAccess";
            this.btnInsertMySqlforAccess.Size = new System.Drawing.Size(136, 50);
            this.btnInsertMySqlforAccess.TabIndex = 20;
            this.btnInsertMySqlforAccess.Text = "Insert Clientes\r\nMySql-->Access";
            this.btnInsertMySqlforAccess.UseVisualStyleBackColor = false;
            this.btnInsertMySqlforAccess.Click += new System.EventHandler(this.btnInsertMySqlforAccess_Click);
            // 
            // btnLimparMySql
            // 
            this.btnLimparMySql.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparMySql.Location = new System.Drawing.Point(914, 405);
            this.btnLimparMySql.Name = "btnLimparMySql";
            this.btnLimparMySql.Size = new System.Drawing.Size(77, 24);
            this.btnLimparMySql.TabIndex = 22;
            this.btnLimparMySql.Text = "Limpar";
            this.btnLimparMySql.UseVisualStyleBackColor = false;
            this.btnLimparMySql.Click += new System.EventHandler(this.btnLimparMySql_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(6, 548);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 23);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "xxxxxxxxxxxxx";
            // 
            // bntAtualizacaoMySqlAccess
            // 
            this.bntAtualizacaoMySqlAccess.BackColor = System.Drawing.Color.Transparent;
            this.bntAtualizacaoMySqlAccess.Location = new System.Drawing.Point(687, 474);
            this.bntAtualizacaoMySqlAccess.Name = "bntAtualizacaoMySqlAccess";
            this.bntAtualizacaoMySqlAccess.Size = new System.Drawing.Size(136, 50);
            this.bntAtualizacaoMySqlAccess.TabIndex = 25;
            this.bntAtualizacaoMySqlAccess.Text = "Atualização\r\nMySql-->Access";
            this.bntAtualizacaoMySqlAccess.UseVisualStyleBackColor = false;
            this.bntAtualizacaoMySqlAccess.Click += new System.EventHandler(this.bntAtualizacaoMySqlAccess_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 575);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robo Banco de Dados Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAccess;
        private System.Windows.Forms.Button btnBuscarAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMySql;
        private System.Windows.Forms.Button btnBuscarMySql;
        private System.Windows.Forms.Button btnInsertAccessforMySQL;
        private System.Windows.Forms.Button btnInsertMySqlforAccess;
        private System.Windows.Forms.Button btnLimparMySql;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button bntAtualizacaoMySqlAccess;
    }
}

