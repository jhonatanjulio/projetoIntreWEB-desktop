
namespace IntreDesktop
{
    partial class frmProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjetos));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblFormaContato = new System.Windows.Forms.Label();
            this.txtFormaContato = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.cbbTipoImovel = new System.Windows.Forms.ComboBox();
            this.lblTipoImovel = new System.Windows.Forms.Label();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.cbbTipoServico = new System.Windows.Forms.ComboBox();
            this.lblMetragem = new System.Windows.Forms.Label();
            this.lblRevestimento = new System.Windows.Forms.Label();
            this.cbbRevestimento = new System.Windows.Forms.ComboBox();
            this.lblMarcenaria = new System.Windows.Forms.Label();
            this.cbbMarcenaria = new System.Windows.Forms.ComboBox();
            this.lblDescricaoAmbiente = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.nudMetragem = new System.Windows.Forms.NumericUpDown();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.cbbAmbiente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetragem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(939, 570);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(133, 67);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(642, 570);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(133, 67);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(345, 570);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 67);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(199, 570);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 67);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(54, 570);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(133, 67);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblFormaContato
            // 
            this.lblFormaContato.AutoSize = true;
            this.lblFormaContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaContato.Location = new System.Drawing.Point(78, 104);
            this.lblFormaContato.Name = "lblFormaContato";
            this.lblFormaContato.Size = new System.Drawing.Size(186, 25);
            this.lblFormaContato.TabIndex = 27;
            this.lblFormaContato.Text = "Forma de contato:";
            // 
            // txtFormaContato
            // 
            this.txtFormaContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaContato.Location = new System.Drawing.Point(82, 131);
            this.txtFormaContato.Name = "txtFormaContato";
            this.txtFormaContato.Size = new System.Drawing.Size(460, 30);
            this.txtFormaContato.TabIndex = 28;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(83, 211);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(460, 30);
            this.txtRua.TabIndex = 30;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(79, 184);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(57, 25);
            this.lblRua.TabIndex = 29;
            this.lblRua.Text = "Rua:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(83, 291);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(460, 30);
            this.txtBairro.TabIndex = 32;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(79, 264);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(75, 25);
            this.lblBairro.TabIndex = 31;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(83, 374);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(460, 30);
            this.txtEstado.TabIndex = 34;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(79, 347);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(85, 25);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(83, 461);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(460, 30);
            this.txtCidade.TabIndex = 36;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(79, 434);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(86, 25);
            this.lblCidade.TabIndex = 35;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(623, 57);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(460, 30);
            this.txtComplemento.TabIndex = 38;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(619, 30);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(150, 25);
            this.lblComplemento.TabIndex = 37;
            this.lblComplemento.Text = "Complemento:";
            // 
            // cbbTipoImovel
            // 
            this.cbbTipoImovel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoImovel.FormattingEnabled = true;
            this.cbbTipoImovel.Items.AddRange(new object[] {
            "a"});
            this.cbbTipoImovel.Location = new System.Drawing.Point(624, 131);
            this.cbbTipoImovel.Name = "cbbTipoImovel";
            this.cbbTipoImovel.Size = new System.Drawing.Size(460, 33);
            this.cbbTipoImovel.TabIndex = 39;
            // 
            // lblTipoImovel
            // 
            this.lblTipoImovel.AutoSize = true;
            this.lblTipoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoImovel.Location = new System.Drawing.Point(620, 104);
            this.lblTipoImovel.Name = "lblTipoImovel";
            this.lblTipoImovel.Size = new System.Drawing.Size(158, 25);
            this.lblTipoImovel.TabIndex = 40;
            this.lblTipoImovel.Text = "Tipo de imóvel:";
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServico.Location = new System.Drawing.Point(620, 184);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(165, 25);
            this.lblTipoServico.TabIndex = 42;
            this.lblTipoServico.Text = "Tipo de serviço:";
            // 
            // cbbTipoServico
            // 
            this.cbbTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoServico.FormattingEnabled = true;
            this.cbbTipoServico.Items.AddRange(new object[] {
            "a"});
            this.cbbTipoServico.Location = new System.Drawing.Point(624, 211);
            this.cbbTipoServico.Name = "cbbTipoServico";
            this.cbbTipoServico.Size = new System.Drawing.Size(460, 33);
            this.cbbTipoServico.TabIndex = 41;
            // 
            // lblMetragem
            // 
            this.lblMetragem.AutoSize = true;
            this.lblMetragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetragem.Location = new System.Drawing.Point(620, 264);
            this.lblMetragem.Name = "lblMetragem";
            this.lblMetragem.Size = new System.Drawing.Size(114, 25);
            this.lblMetragem.TabIndex = 44;
            this.lblMetragem.Text = "Metragem:";
            // 
            // lblRevestimento
            // 
            this.lblRevestimento.AutoSize = true;
            this.lblRevestimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevestimento.Location = new System.Drawing.Point(859, 264);
            this.lblRevestimento.Name = "lblRevestimento";
            this.lblRevestimento.Size = new System.Drawing.Size(149, 25);
            this.lblRevestimento.TabIndex = 46;
            this.lblRevestimento.Text = "Revestimento:";
            // 
            // cbbRevestimento
            // 
            this.cbbRevestimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRevestimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRevestimento.FormattingEnabled = true;
            this.cbbRevestimento.Items.AddRange(new object[] {
            "a"});
            this.cbbRevestimento.Location = new System.Drawing.Point(863, 291);
            this.cbbRevestimento.Name = "cbbRevestimento";
            this.cbbRevestimento.Size = new System.Drawing.Size(220, 33);
            this.cbbRevestimento.TabIndex = 45;
            // 
            // lblMarcenaria
            // 
            this.lblMarcenaria.AutoSize = true;
            this.lblMarcenaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcenaria.Location = new System.Drawing.Point(620, 347);
            this.lblMarcenaria.Name = "lblMarcenaria";
            this.lblMarcenaria.Size = new System.Drawing.Size(126, 25);
            this.lblMarcenaria.TabIndex = 48;
            this.lblMarcenaria.Text = "Marcenaria:";
            // 
            // cbbMarcenaria
            // 
            this.cbbMarcenaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMarcenaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMarcenaria.FormattingEnabled = true;
            this.cbbMarcenaria.Items.AddRange(new object[] {
            "a"});
            this.cbbMarcenaria.Location = new System.Drawing.Point(624, 374);
            this.cbbMarcenaria.Name = "cbbMarcenaria";
            this.cbbMarcenaria.Size = new System.Drawing.Size(460, 33);
            this.cbbMarcenaria.TabIndex = 47;
            // 
            // lblDescricaoAmbiente
            // 
            this.lblDescricaoAmbiente.AutoSize = true;
            this.lblDescricaoAmbiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoAmbiente.Location = new System.Drawing.Point(620, 434);
            this.lblDescricaoAmbiente.Name = "lblDescricaoAmbiente";
            this.lblDescricaoAmbiente.Size = new System.Drawing.Size(238, 25);
            this.lblDescricaoAmbiente.TabIndex = 49;
            this.lblDescricaoAmbiente.Text = "Descrição do ambiente:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(790, 570);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 67);
            this.btnLimpar.TabIndex = 53;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnArquivar
            // 
            this.btnArquivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnArquivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArquivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivar.Image = ((System.Drawing.Image)(resources.GetObject("btnArquivar.Image")));
            this.btnArquivar.Location = new System.Drawing.Point(494, 570);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(133, 67);
            this.btnArquivar.TabIndex = 54;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArquivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArquivar.UseVisualStyleBackColor = false;
            // 
            // nudMetragem
            // 
            this.nudMetragem.DecimalPlaces = 2;
            this.nudMetragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMetragem.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudMetragem.Location = new System.Drawing.Point(624, 292);
            this.nudMetragem.Name = "nudMetragem";
            this.nudMetragem.Size = new System.Drawing.Size(217, 30);
            this.nudMetragem.TabIndex = 55;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(77, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(85, 25);
            this.lblCliente.TabIndex = 56;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbbCliente
            // 
            this.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Items.AddRange(new object[] {
            "a"});
            this.cbbCliente.Location = new System.Drawing.Point(82, 54);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(460, 33);
            this.cbbCliente.TabIndex = 57;
            this.cbbCliente.SelectedIndexChanged += new System.EventHandler(this.cbbCliente_SelectedIndexChanged);
            // 
            // cbbAmbiente
            // 
            this.cbbAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAmbiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAmbiente.FormattingEnabled = true;
            this.cbbAmbiente.Location = new System.Drawing.Point(623, 462);
            this.cbbAmbiente.Name = "cbbAmbiente";
            this.cbbAmbiente.Size = new System.Drawing.Size(460, 33);
            this.cbbAmbiente.TabIndex = 58;
            this.cbbAmbiente.SelectedIndexChanged += new System.EventHandler(this.cbbAmbiente_SelectedIndexChanged);
            // 
            // frmProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1127, 649);
            this.Controls.Add(this.cbbAmbiente);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.nudMetragem);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDescricaoAmbiente);
            this.Controls.Add(this.lblMarcenaria);
            this.Controls.Add(this.cbbMarcenaria);
            this.Controls.Add(this.lblRevestimento);
            this.Controls.Add(this.cbbRevestimento);
            this.Controls.Add(this.lblMetragem);
            this.Controls.Add(this.lblTipoServico);
            this.Controls.Add(this.cbbTipoServico);
            this.Controls.Add(this.lblTipoImovel);
            this.Controls.Add(this.cbbTipoImovel);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtFormaContato);
            this.Controls.Add(this.lblFormaContato);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProjetos";
            ((System.ComponentModel.ISupportInitialize)(this.nudMetragem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblFormaContato;
        private System.Windows.Forms.TextBox txtFormaContato;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.ComboBox cbbTipoImovel;
        private System.Windows.Forms.Label lblTipoImovel;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.ComboBox cbbTipoServico;
        private System.Windows.Forms.Label lblMetragem;
        private System.Windows.Forms.Label lblRevestimento;
        private System.Windows.Forms.ComboBox cbbRevestimento;
        private System.Windows.Forms.Label lblMarcenaria;
        private System.Windows.Forms.ComboBox cbbMarcenaria;
        private System.Windows.Forms.Label lblDescricaoAmbiente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.NumericUpDown nudMetragem;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.ComboBox cbbAmbiente;
    }
}