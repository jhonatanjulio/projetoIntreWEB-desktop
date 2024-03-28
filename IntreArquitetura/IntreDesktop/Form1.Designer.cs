
namespace IntreDesktop
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pnlCarrinho = new System.Windows.Forms.Panel();
            this.pnlOptionsCarrinho = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValorExtraTotal = new System.Windows.Forms.TextBox();
            this.txtValorExtra = new System.Windows.Forms.TextBox();
            this.nudMetragem = new System.Windows.Forms.NumericUpDown();
            this.cbbItemExtra = new System.Windows.Forms.ComboBox();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.pnlCalculoValores = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbbOrcamento = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlCarrinho.SuspendLayout();
            this.pnlOptionsCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetragem)).BeginInit();
            this.pnlCalculoValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCarrinho
            // 
            this.pnlCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCarrinho.Controls.Add(this.pnlOptionsCarrinho);
            this.pnlCarrinho.Controls.Add(this.lstItens);
            this.pnlCarrinho.Location = new System.Drawing.Point(99, 155);
            this.pnlCarrinho.Name = "pnlCarrinho";
            this.pnlCarrinho.Size = new System.Drawing.Size(550, 329);
            this.pnlCarrinho.TabIndex = 1;
            // 
            // pnlOptionsCarrinho
            // 
            this.pnlOptionsCarrinho.Controls.Add(this.button2);
            this.pnlOptionsCarrinho.Controls.Add(this.button1);
            this.pnlOptionsCarrinho.Controls.Add(this.txtValorExtraTotal);
            this.pnlOptionsCarrinho.Controls.Add(this.txtValorExtra);
            this.pnlOptionsCarrinho.Controls.Add(this.nudMetragem);
            this.pnlOptionsCarrinho.Controls.Add(this.cbbItemExtra);
            this.pnlOptionsCarrinho.Location = new System.Drawing.Point(339, 0);
            this.pnlOptionsCarrinho.Name = "pnlOptionsCarrinho";
            this.pnlOptionsCarrinho.Size = new System.Drawing.Size(210, 329);
            this.pnlOptionsCarrinho.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(47, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtValorExtraTotal
            // 
            this.txtValorExtraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorExtraTotal.Location = new System.Drawing.Point(16, 171);
            this.txtValorExtraTotal.Name = "txtValorExtraTotal";
            this.txtValorExtraTotal.Size = new System.Drawing.Size(180, 29);
            this.txtValorExtraTotal.TabIndex = 3;
            this.txtValorExtraTotal.Text = "R$";
            // 
            // txtValorExtra
            // 
            this.txtValorExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorExtra.Location = new System.Drawing.Point(16, 121);
            this.txtValorExtra.Name = "txtValorExtra";
            this.txtValorExtra.Size = new System.Drawing.Size(180, 29);
            this.txtValorExtra.TabIndex = 2;
            this.txtValorExtra.Text = "R$";
            // 
            // nudMetragem
            // 
            this.nudMetragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMetragem.Location = new System.Drawing.Point(16, 72);
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
            this.cbbItemExtra.Location = new System.Drawing.Point(16, 24);
            this.cbbItemExtra.Name = "cbbItemExtra";
            this.cbbItemExtra.Size = new System.Drawing.Size(181, 32);
            this.cbbItemExtra.TabIndex = 0;
            // 
            // lstItens
            // 
            this.lstItens.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItens.FormattingEnabled = true;
            this.lstItens.ItemHeight = 18;
            this.lstItens.Location = new System.Drawing.Point(0, 0);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(340, 328);
            this.lstItens.TabIndex = 3;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(94, 67);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(177, 25);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(98, 95);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(269, 29);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(390, 95);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(269, 29);
            this.txtEmailCliente.TabIndex = 5;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(385, 67);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(181, 25);
            this.lblEmailCliente.TabIndex = 4;
            this.lblEmailCliente.Text = "E-mail do Cliente:";
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
            this.pnlCalculoValores.Location = new System.Drawing.Point(745, 155);
            this.pnlCalculoValores.Name = "pnlCalculoValores";
            this.pnlCalculoValores.Size = new System.Drawing.Size(269, 329);
            this.pnlCalculoValores.TabIndex = 6;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(26, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "R$";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblValorTotal.Location = new System.Drawing.Point(28, 234);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(100, 24);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblValorInicial.Location = new System.Drawing.Point(22, 157);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(106, 24);
            this.lblValorInicial.TabIndex = 8;
            this.lblValorInicial.Text = "Valor Inicial";
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
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(64, 538);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 67);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(209, 538);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(130, 67);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(355, 538);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 67);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(500, 538);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(130, 67);
            this.btnConcluir.TabIndex = 10;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            // 
            // btnArquivar
            // 
            this.btnArquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivar.Location = new System.Drawing.Point(646, 538);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(130, 67);
            this.btnArquivar.TabIndex = 11;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(791, 538);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(130, 67);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(930, 538);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 67);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 645);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pnlCalculoValores);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.pnlCarrinho);
            this.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlCarrinho.ResumeLayout(false);
            this.pnlOptionsCarrinho.ResumeLayout(false);
            this.pnlOptionsCarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetragem)).EndInit();
            this.pnlCalculoValores.ResumeLayout(false);
            this.pnlCalculoValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel pnlCarrinho;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Panel pnlOptionsCarrinho;
        private System.Windows.Forms.Panel pnlCalculoValores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValorExtraTotal;
        private System.Windows.Forms.TextBox txtValorExtra;
        private System.Windows.Forms.NumericUpDown nudMetragem;
        private System.Windows.Forms.ComboBox cbbItemExtra;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbbOrcamento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
    }
}

