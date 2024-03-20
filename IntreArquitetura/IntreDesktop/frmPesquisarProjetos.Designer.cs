
namespace IntreDesktop
{
    partial class frmPesquisarProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarProjetos));
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbAndamento = new System.Windows.Forms.RadioButton();
            this.rdbArquivados = new System.Windows.Forms.RadioButton();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbTipoPesquisar.SuspendLayout();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(471, 484);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(171, 484);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(321, 484);
            // 
            // gpbTipoPesquisar
            // 
            this.gpbTipoPesquisar.Controls.Add(this.rdbAndamento);
            this.gpbTipoPesquisar.Controls.Add(this.rdbArquivados);
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.radioButton3);
            this.gpbPesquisar.Controls.Add(this.rdbNome);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPesquisa.Location = new System.Drawing.Point(107, 164);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(704, 302);
            this.dgvPesquisa.TabIndex = 61;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton3.Location = new System.Drawing.Point(417, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 24);
            this.radioButton3.TabIndex = 65;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbNome.Location = new System.Drawing.Point(209, 25);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(119, 24);
            this.rdbNome.TabIndex = 64;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "radioButton4";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbAndamento
            // 
            this.rdbAndamento.AutoSize = true;
            this.rdbAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbAndamento.Location = new System.Drawing.Point(209, 25);
            this.rdbAndamento.Name = "rdbAndamento";
            this.rdbAndamento.Size = new System.Drawing.Size(138, 24);
            this.rdbAndamento.TabIndex = 5;
            this.rdbAndamento.TabStop = true;
            this.rdbAndamento.Text = "Em Andamento";
            this.rdbAndamento.UseVisualStyleBackColor = true;
            // 
            // rdbArquivados
            // 
            this.rdbArquivados.AutoSize = true;
            this.rdbArquivados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbArquivados.Location = new System.Drawing.Point(417, 25);
            this.rdbArquivados.Name = "rdbArquivados";
            this.rdbArquivados.Size = new System.Drawing.Size(106, 24);
            this.rdbArquivados.TabIndex = 4;
            this.rdbArquivados.TabStop = true;
            this.rdbArquivados.Text = "Arquivados";
            this.rdbArquivados.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(620, 484);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 67);
            this.btnAlterar.TabIndex = 62;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome:";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo de imovel:";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de serviço:";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status:";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 170;
            // 
            // frmPesquisarProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 563);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvPesquisa);
            this.Name = "frmPesquisarProjetos";
            this.Text = "frmPesquisarProjetos";
            this.Controls.SetChildIndex(this.dgvPesquisa, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            this.Controls.SetChildIndex(this.btnAtivar, 0);
            this.Controls.SetChildIndex(this.gpbTipoPesquisar, 0);
            this.Controls.SetChildIndex(this.gpbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.gpbTipoPesquisar.ResumeLayout(false);
            this.gpbTipoPesquisar.PerformLayout();
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.RadioButton rdbAndamento;
        private System.Windows.Forms.RadioButton rdbArquivados;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}