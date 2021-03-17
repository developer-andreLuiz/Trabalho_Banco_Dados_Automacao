namespace RoboDataBase.Formularios
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCliente = new System.Windows.Forms.Button();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFuncionario = new System.Windows.Forms.CheckBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.chkFornecedor = new System.Windows.Forms.CheckBox();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMarcaTodos = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.btnIniciarWindows = new System.Windows.Forms.Button();
            this.btnSumir = new System.Windows.Forms.Button();
            this.chkProduto = new System.Windows.Forms.CheckBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.chkNfEIdentificacao = new System.Windows.Forms.CheckBox();
            this.btnNfEIdentificacaoNota = new System.Windows.Forms.Button();
            this.chkNfEProdutos = new System.Windows.Forms.CheckBox();
            this.btnNfEProdutos = new System.Windows.Forms.Button();
            this.chkPesqProdutos = new System.Windows.Forms.CheckBox();
            this.btnPesqProdutos = new System.Windows.Forms.Button();
            this.chkQuant = new System.Windows.Forms.CheckBox();
            this.btnQuantProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(27, 57);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 38);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.ForeColor = System.Drawing.Color.White;
            this.chkCliente.Location = new System.Drawing.Point(6, 70);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(15, 14);
            this.chkCliente.TabIndex = 1;
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Automação Banco de Dados";
            // 
            // chkFuncionario
            // 
            this.chkFuncionario.AutoSize = true;
            this.chkFuncionario.ForeColor = System.Drawing.Color.White;
            this.chkFuncionario.Location = new System.Drawing.Point(6, 125);
            this.chkFuncionario.Name = "chkFuncionario";
            this.chkFuncionario.Size = new System.Drawing.Size(15, 14);
            this.chkFuncionario.TabIndex = 4;
            this.chkFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(27, 112);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(100, 38);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // chkFornecedor
            // 
            this.chkFornecedor.AutoSize = true;
            this.chkFornecedor.ForeColor = System.Drawing.Color.White;
            this.chkFornecedor.Location = new System.Drawing.Point(6, 182);
            this.chkFornecedor.Name = "chkFornecedor";
            this.chkFornecedor.Size = new System.Drawing.Size(15, 14);
            this.chkFornecedor.TabIndex = 6;
            this.chkFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(27, 169);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(100, 38);
            this.btnFornecedor.TabIndex = 5;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMarcaTodos
            // 
            this.btnMarcaTodos.Location = new System.Drawing.Point(27, 425);
            this.btnMarcaTodos.Name = "btnMarcaTodos";
            this.btnMarcaTodos.Size = new System.Drawing.Size(100, 38);
            this.btnMarcaTodos.TabIndex = 7;
            this.btnMarcaTodos.Text = "Marcar Todos";
            this.btnMarcaTodos.UseVisualStyleBackColor = true;
            this.btnMarcaTodos.Click += new System.EventHandler(this.btnMarcaTodos_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.BackColor = System.Drawing.Color.White;
            this.btnDesmarcarTodos.ForeColor = System.Drawing.Color.Black;
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(147, 425);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(100, 38);
            this.btnDesmarcarTodos.TabIndex = 8;
            this.btnDesmarcarTodos.Text = "Desmarcar Todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = false;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // btnIniciarWindows
            // 
            this.btnIniciarWindows.BackColor = System.Drawing.Color.White;
            this.btnIniciarWindows.Enabled = false;
            this.btnIniciarWindows.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarWindows.Location = new System.Drawing.Point(265, 425);
            this.btnIniciarWindows.Name = "btnIniciarWindows";
            this.btnIniciarWindows.Size = new System.Drawing.Size(116, 38);
            this.btnIniciarWindows.TabIndex = 9;
            this.btnIniciarWindows.Text = "Iniciar Com Windows";
            this.btnIniciarWindows.UseVisualStyleBackColor = false;
            this.btnIniciarWindows.Click += new System.EventHandler(this.btnIniciarWindows_Click);
            // 
            // btnSumir
            // 
            this.btnSumir.BackColor = System.Drawing.Color.White;
            this.btnSumir.ForeColor = System.Drawing.Color.Black;
            this.btnSumir.Location = new System.Drawing.Point(688, 425);
            this.btnSumir.Name = "btnSumir";
            this.btnSumir.Size = new System.Drawing.Size(100, 38);
            this.btnSumir.TabIndex = 10;
            this.btnSumir.Text = "Esconder";
            this.btnSumir.UseVisualStyleBackColor = false;
            this.btnSumir.Click += new System.EventHandler(this.btnSumir_Click);
            // 
            // chkProduto
            // 
            this.chkProduto.AutoSize = true;
            this.chkProduto.ForeColor = System.Drawing.Color.White;
            this.chkProduto.Location = new System.Drawing.Point(6, 237);
            this.chkProduto.Name = "chkProduto";
            this.chkProduto.Size = new System.Drawing.Size(15, 14);
            this.chkProduto.TabIndex = 12;
            this.chkProduto.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(27, 224);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(100, 38);
            this.btnProduto.TabIndex = 11;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // chkNfEIdentificacao
            // 
            this.chkNfEIdentificacao.AutoSize = true;
            this.chkNfEIdentificacao.ForeColor = System.Drawing.Color.White;
            this.chkNfEIdentificacao.Location = new System.Drawing.Point(643, 70);
            this.chkNfEIdentificacao.Name = "chkNfEIdentificacao";
            this.chkNfEIdentificacao.Size = new System.Drawing.Size(15, 14);
            this.chkNfEIdentificacao.TabIndex = 14;
            this.chkNfEIdentificacao.UseVisualStyleBackColor = true;
            // 
            // btnNfEIdentificacaoNota
            // 
            this.btnNfEIdentificacaoNota.Location = new System.Drawing.Point(664, 57);
            this.btnNfEIdentificacaoNota.Name = "btnNfEIdentificacaoNota";
            this.btnNfEIdentificacaoNota.Size = new System.Drawing.Size(112, 38);
            this.btnNfEIdentificacaoNota.TabIndex = 13;
            this.btnNfEIdentificacaoNota.Text = "NF-e-Identificacão-Nota";
            this.btnNfEIdentificacaoNota.UseVisualStyleBackColor = true;
            this.btnNfEIdentificacaoNota.Click += new System.EventHandler(this.btnNfEIdentificacaoNota_Click);
            // 
            // chkNfEProdutos
            // 
            this.chkNfEProdutos.AutoSize = true;
            this.chkNfEProdutos.ForeColor = System.Drawing.Color.White;
            this.chkNfEProdutos.Location = new System.Drawing.Point(643, 125);
            this.chkNfEProdutos.Name = "chkNfEProdutos";
            this.chkNfEProdutos.Size = new System.Drawing.Size(15, 14);
            this.chkNfEProdutos.TabIndex = 16;
            this.chkNfEProdutos.UseVisualStyleBackColor = true;
            // 
            // btnNfEProdutos
            // 
            this.btnNfEProdutos.Location = new System.Drawing.Point(664, 112);
            this.btnNfEProdutos.Name = "btnNfEProdutos";
            this.btnNfEProdutos.Size = new System.Drawing.Size(112, 38);
            this.btnNfEProdutos.TabIndex = 15;
            this.btnNfEProdutos.Text = "NF-e-Produtos";
            this.btnNfEProdutos.UseVisualStyleBackColor = true;
            this.btnNfEProdutos.Click += new System.EventHandler(this.btnNfEProdutos_Click);
            // 
            // chkPesqProdutos
            // 
            this.chkPesqProdutos.AutoSize = true;
            this.chkPesqProdutos.ForeColor = System.Drawing.Color.White;
            this.chkPesqProdutos.Location = new System.Drawing.Point(643, 182);
            this.chkPesqProdutos.Name = "chkPesqProdutos";
            this.chkPesqProdutos.Size = new System.Drawing.Size(15, 14);
            this.chkPesqProdutos.TabIndex = 18;
            this.chkPesqProdutos.UseVisualStyleBackColor = true;
            // 
            // btnPesqProdutos
            // 
            this.btnPesqProdutos.Location = new System.Drawing.Point(664, 169);
            this.btnPesqProdutos.Name = "btnPesqProdutos";
            this.btnPesqProdutos.Size = new System.Drawing.Size(112, 38);
            this.btnPesqProdutos.TabIndex = 17;
            this.btnPesqProdutos.Text = "NF-Pesq Produtos";
            this.btnPesqProdutos.UseVisualStyleBackColor = true;
            this.btnPesqProdutos.Click += new System.EventHandler(this.btnPesqProdutos_Click);
            // 
            // chkQuant
            // 
            this.chkQuant.AutoSize = true;
            this.chkQuant.ForeColor = System.Drawing.Color.White;
            this.chkQuant.Location = new System.Drawing.Point(643, 237);
            this.chkQuant.Name = "chkQuant";
            this.chkQuant.Size = new System.Drawing.Size(15, 14);
            this.chkQuant.TabIndex = 20;
            this.chkQuant.UseVisualStyleBackColor = true;
            // 
            // btnQuantProdutos
            // 
            this.btnQuantProdutos.Location = new System.Drawing.Point(664, 224);
            this.btnQuantProdutos.Name = "btnQuantProdutos";
            this.btnQuantProdutos.Size = new System.Drawing.Size(112, 38);
            this.btnQuantProdutos.TabIndex = 19;
            this.btnQuantProdutos.Text = "NF-Quant Produtos";
            this.btnQuantProdutos.UseVisualStyleBackColor = true;
            this.btnQuantProdutos.Click += new System.EventHandler(this.btnQuantProdutos_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.chkQuant);
            this.Controls.Add(this.btnQuantProdutos);
            this.Controls.Add(this.chkPesqProdutos);
            this.Controls.Add(this.btnPesqProdutos);
            this.Controls.Add(this.chkNfEProdutos);
            this.Controls.Add(this.btnNfEProdutos);
            this.Controls.Add(this.chkNfEIdentificacao);
            this.Controls.Add(this.btnNfEIdentificacaoNota);
            this.Controls.Add(this.chkProduto);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnSumir);
            this.Controls.Add(this.btnIniciarWindows);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnMarcaTodos);
            this.Controls.Add(this.chkFornecedor);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.chkFuncionario);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCliente);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automação MySql--Access";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFuncionario;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.CheckBox chkFornecedor;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnMarcaTodos;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Button btnIniciarWindows;
        private System.Windows.Forms.Button btnSumir;
        private System.Windows.Forms.CheckBox chkProduto;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.CheckBox chkNfEIdentificacao;
        private System.Windows.Forms.Button btnNfEIdentificacaoNota;
        private System.Windows.Forms.CheckBox chkNfEProdutos;
        private System.Windows.Forms.Button btnNfEProdutos;
        private System.Windows.Forms.CheckBox chkPesqProdutos;
        private System.Windows.Forms.Button btnPesqProdutos;
        private System.Windows.Forms.CheckBox chkQuant;
        private System.Windows.Forms.Button btnQuantProdutos;
    }
}