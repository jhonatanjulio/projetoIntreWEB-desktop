
namespace IntreDesktop
{
    partial class frmUsuarios
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
            this.dgvFuncDisp = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.dgvCodFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNomeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.lblFunc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncDisp
            // 
            this.dgvFuncDisp.AllowUserToAddRows = false;
            this.dgvFuncDisp.AllowUserToDeleteRows = false;
            this.dgvFuncDisp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.dgvFuncDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodFunc,
            this.dgvNomeFunc});
            this.dgvFuncDisp.Location = new System.Drawing.Point(745, 95);
            this.dgvFuncDisp.Name = "dgvFuncDisp";
            this.dgvFuncDisp.ReadOnly = true;
            this.dgvFuncDisp.Size = new System.Drawing.Size(223, 359);
            this.dgvFuncDisp.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(933, 531);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 67);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(794, 531);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(130, 67);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnArquivar
            // 
            this.btnArquivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnArquivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArquivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivar.Location = new System.Drawing.Point(649, 531);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(130, 67);
            this.btnArquivar.TabIndex = 24;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.UseVisualStyleBackColor = false;
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(503, 531);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(130, 67);
            this.btnConcluir.TabIndex = 23;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(358, 531);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 67);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(212, 531);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(130, 67);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(67, 531);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 67);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(163, 231);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(414, 29);
            this.txtSenha.TabIndex = 18;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(158, 203);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 25);
            this.lblSenha.TabIndex = 17;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(163, 164);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(414, 29);
            this.txtNomeUser.TabIndex = 16;
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.Location = new System.Drawing.Point(158, 136);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(184, 25);
            this.lblNomeUser.TabIndex = 15;
            this.lblNomeUser.Text = "Nome do Usuário:";
            // 
            // dgvCodFunc
            // 
            this.dgvCodFunc.HeaderText = "Código";
            this.dgvCodFunc.Name = "dgvCodFunc";
            this.dgvCodFunc.ReadOnly = true;
            this.dgvCodFunc.Width = 80;
            // 
            // dgvNomeFunc
            // 
            this.dgvNomeFunc.HeaderText = "Nome";
            this.dgvNomeFunc.Name = "dgvNomeFunc";
            this.dgvNomeFunc.ReadOnly = true;
            // 
            // txtFunc
            // 
            this.txtFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunc.Location = new System.Drawing.Point(163, 300);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(414, 29);
            this.txtFunc.TabIndex = 28;
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.Location = new System.Drawing.Point(158, 272);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(131, 25);
            this.lblFunc.TabIndex = 27;
            this.lblFunc.Text = "Funcionário:";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1131, 653);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.dgvFuncDisp);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.lblNomeUser);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomeFunc;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Label lblFunc;
    }
}