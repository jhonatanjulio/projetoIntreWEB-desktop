
namespace IntreDesktop
{
    partial class frmOrcamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamentos));
            this.dgvCarrinhoExtra = new System.Windows.Forms.DataGridView();
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.pnlOptionsCarrinho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdeExtra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblItemExtra = new System.Windows.Forms.Label();
            this.txtValorExtraTotal = new System.Windows.Forms.TextBox();
            this.txtValorExtra = new System.Windows.Forms.TextBox();
            this.nudMetragem = new System.Windows.Forms.NumericUpDown();
            this.cbbItemExtra = new System.Windows.Forms.ComboBox();
            this.pnlCarrinho = new System.Windows.Forms.Panel();
            this.cbbOrcamento = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlCalculoValores = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoExtra)).BeginInit();
            this.pnlOptionsCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetragem)).BeginInit();
            this.pnlCarrinho.SuspendLayout();
            this.pnlCalculoValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarrinhoExtra
            // 
            this.dgvCarrinhoExtra.AllowUserToAddRows = false;
            this.dgvCarrinhoExtra.AllowUserToDeleteRows = false;
            this.dgvCarrinhoExtra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.dgvCarrinhoExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinhoExtra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigo,
            this.dgvDescricao,
            this.dgvValorUnit});
            this.dgvCarrinhoExtra.Location = new System.Drawing.Point(-1, -1);
            this.dgvCarrinhoExtra.Name = "dgvCarrinhoExtra";
            this.dgvCarrinhoExtra.ReadOnly = true;
            this.dgvCarrinhoExtra.Size = new System.Drawing.Size(340, 359);
            this.dgvCarrinhoExtra.TabIndex = 2;
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.HeaderText = "Código";
            this.dgvCodigo.Name = "dgvCodigo";
            this.dgvCodigo.ReadOnly = true;
            this.dgvCodigo.Width = 80;
            // 
            // dgvDescricao
            // 
            this.dgvDescricao.HeaderText = "Descrição";
            this.dgvDescricao.Name = "dgvDescricao";
            this.dgvDescricao.ReadOnly = true;
            // 
            // dgvValorUnit
            // 
            this.dgvValorUnit.HeaderText = "Valor Unitário";
            this.dgvValorUnit.Name = "dgvValorUnit";
            this.dgvValorUnit.ReadOnly = true;
            this.dgvValorUnit.Width = 120;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(100, 56);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(177, 25);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(283, 54);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(269, 30);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(745, 56);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(269, 30);
            this.txtEmailCliente.TabIndex = 5;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(558, 58);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(181, 25);
            this.lblEmailCliente.TabIndex = 4;
            this.lblEmailCliente.Text = "E-mail do Cliente:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluir.Image")));
            this.btnConcluir.Location = new System.Drawing.Point(210, 566);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(133, 67);
            this.btnConcluir.TabIndex = 10;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConcluir.UseVisualStyleBackColor = false;
            // 
            // btnArquivar
            // 
            this.btnArquivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnArquivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArquivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivar.Image = ((System.Drawing.Image)(resources.GetObject("btnArquivar.Image")));
            this.btnArquivar.Location = new System.Drawing.Point(488, 566);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(133, 67);
            this.btnArquivar.TabIndex = 11;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArquivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArquivar.UseVisualStyleBackColor = false;
            // 
            // pnlOptionsCarrinho
            // 
            this.pnlOptionsCarrinho.Controls.Add(this.label2);
            this.pnlOptionsCarrinho.Controls.Add(this.label1);
            this.pnlOptionsCarrinho.Controls.Add(this.lblQtdeExtra);
            this.pnlOptionsCarrinho.Controls.Add(this.button1);
            this.pnlOptionsCarrinho.Controls.Add(this.button2);
            this.pnlOptionsCarrinho.Controls.Add(this.lblItemExtra);
            this.pnlOptionsCarrinho.Controls.Add(this.txtValorExtraTotal);
            this.pnlOptionsCarrinho.Controls.Add(this.txtValorExtra);
            this.pnlOptionsCarrinho.Controls.Add(this.nudMetragem);
            this.pnlOptionsCarrinho.Controls.Add(this.cbbItemExtra);
            this.pnlOptionsCarrinho.Location = new System.Drawing.Point(339, 0);
            this.pnlOptionsCarrinho.Name = "pnlOptionsCarrinho";
            this.pnlOptionsCarrinho.Size = new System.Drawing.Size(210, 358);
            this.pnlOptionsCarrinho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(10, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor Extra (Total):";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(10, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor Extra (Unitário):";
            // 
            // lblQtdeExtra
            // 
            this.lblQtdeExtra.AutoEllipsis = true;
            this.lblQtdeExtra.AutoSize = true;
            this.lblQtdeExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblQtdeExtra.Location = new System.Drawing.Point(12, 73);
            this.lblQtdeExtra.Name = "lblQtdeExtra";
            this.lblQtdeExtra.Size = new System.Drawing.Size(113, 24);
            this.lblQtdeExtra.TabIndex = 12;
            this.lblQtdeExtra.Text = "Quantidade:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(48, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblItemExtra
            // 
            this.lblItemExtra.AutoSize = true;
            this.lblItemExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblItemExtra.Location = new System.Drawing.Point(12, 11);
            this.lblItemExtra.Name = "lblItemExtra";
            this.lblItemExtra.Size = new System.Drawing.Size(98, 24);
            this.lblItemExtra.TabIndex = 11;
            this.lblItemExtra.Text = "Item Extra:";
            // 
            // txtValorExtraTotal
            // 
            this.txtValorExtraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorExtraTotal.Location = new System.Drawing.Point(14, 218);
            this.txtValorExtraTotal.Name = "txtValorExtraTotal";
            this.txtValorExtraTotal.Size = new System.Drawing.Size(180, 29);
            this.txtValorExtraTotal.TabIndex = 3;
            this.txtValorExtraTotal.Text = "R$";
            // 
            // txtValorExtra
            // 
            this.txtValorExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorExtra.Location = new System.Drawing.Point(15, 159);
            this.txtValorExtra.Name = "txtValorExtra";
            this.txtValorExtra.Size = new System.Drawing.Size(180, 29);
            this.txtValorExtra.TabIndex = 2;
            this.txtValorExtra.Text = "R$";
            // 
            // nudMetragem
            // 
            this.nudMetragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMetragem.Location = new System.Drawing.Point(16, 100);
            this.nudMetragem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMetragem.Name = "nudMetragem";
            this.nudMetragem.Size = new System.Drawing.Size(181, 29);
            this.nudMetragem.TabIndex = 1;
            // 
            // cbbItemExtra
            // 
            this.cbbItemExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbItemExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbItemExtra.FormattingEnabled = true;
            this.cbbItemExtra.Items.AddRange(new object[] {
            "Teste",
            "TESTE 2",
            "TESATE 4"});
            this.cbbItemExtra.Location = new System.Drawing.Point(16, 38);
            this.cbbItemExtra.Name = "cbbItemExtra";
            this.cbbItemExtra.Size = new System.Drawing.Size(181, 32);
            this.cbbItemExtra.TabIndex = 0;
            // 
            // pnlCarrinho
            // 
            this.pnlCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCarrinho.Controls.Add(this.dgvCarrinhoExtra);
            this.pnlCarrinho.Controls.Add(this.pnlOptionsCarrinho);
            this.pnlCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCarrinho.Location = new System.Drawing.Point(99, 143);
            this.pnlCarrinho.Name = "pnlCarrinho";
            this.pnlCarrinho.Size = new System.Drawing.Size(550, 359);
            this.pnlCarrinho.TabIndex = 1;
            // 
            // cbbOrcamento
            // 
            this.cbbOrcamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbbOrcamento.FormattingEnabled = true;
            this.cbbOrcamento.Items.AddRange(new object[] {
            "Teste",
            "TESTE 2",
            "TESATE 4"});
            this.cbbOrcamento.Location = new System.Drawing.Point(27, 24);
            this.cbbOrcamento.Name = "cbbOrcamento";
            this.cbbOrcamento.Size = new System.Drawing.Size(216, 32);
            this.cbbOrcamento.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Teste",
            "TESTE 2",
            "TESATE 4"});
            this.comboBox2.Location = new System.Drawing.Point(27, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 32);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Tag = "";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblValorInicial.Location = new System.Drawing.Point(22, 157);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(111, 24);
            this.lblValorInicial.TabIndex = 8;
            this.lblValorInicial.Text = "Valor Inicial:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblValorTotal.Location = new System.Drawing.Point(22, 234);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(105, 24);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(26, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "R$";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(27, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 29);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "R$";
            // 
            // pnlCalculoValores
            // 
            this.pnlCalculoValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalculoValores.Controls.Add(this.textBox2);
            this.pnlCalculoValores.Controls.Add(this.textBox1);
            this.pnlCalculoValores.Controls.Add(this.lblValorTotal);
            this.pnlCalculoValores.Controls.Add(this.lblValorInicial);
            this.pnlCalculoValores.Controls.Add(this.comboBox2);
            this.pnlCalculoValores.Controls.Add(this.cbbOrcamento);
            this.pnlCalculoValores.Location = new System.Drawing.Point(745, 157);
            this.pnlCalculoValores.Name = "pnlCalculoValores";
            this.pnlCalculoValores.Size = new System.Drawing.Size(269, 329);
            this.pnlCalculoValores.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(766, 566);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 67);
            this.btnLimpar.TabIndex = 54;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(905, 566);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(133, 67);
            this.btnVoltar.TabIndex = 57;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(627, 566);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(133, 67);
            this.btnPesquisar.TabIndex = 56;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(71, 566);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(133, 67);
            this.btnNovo.TabIndex = 55;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(349, 566);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 67);
            this.btnAlterar.TabIndex = 58;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // frmOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1123, 645);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.pnlCalculoValores);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.pnlCarrinho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmOrcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoExtra)).EndInit();
            this.pnlOptionsCarrinho.ResumeLayout(false);
            this.pnlOptionsCarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetragem)).EndInit();
            this.pnlCarrinho.ResumeLayout(false);
            this.pnlCalculoValores.ResumeLayout(false);
            this.pnlCalculoValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.DataGridView dgvCarrinhoExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorUnit;
        private System.Windows.Forms.Panel pnlOptionsCarrinho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdeExtra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblItemExtra;
        private System.Windows.Forms.TextBox txtValorExtraTotal;
        private System.Windows.Forms.TextBox txtValorExtra;
        private System.Windows.Forms.NumericUpDown nudMetragem;
        private System.Windows.Forms.ComboBox cbbItemExtra;
        private System.Windows.Forms.Panel pnlCarrinho;
        private System.Windows.Forms.ComboBox cbbOrcamento;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlCalculoValores;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
    }
}

