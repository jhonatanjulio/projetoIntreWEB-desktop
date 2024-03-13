
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
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbAndamento = new System.Windows.Forms.RadioButton();
            this.rdbArquivados = new System.Windows.Forms.RadioButton();
            this.gpbTipoPesquisar.SuspendLayout();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
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
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // frmPesquisarProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 563);
            this.Controls.Add(this.dgvPesquisa);
            this.Name = "frmPesquisarProjetos";
            this.Text = "frmPesquisarProjetos";
            this.Controls.SetChildIndex(this.dgvPesquisa, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            this.Controls.SetChildIndex(this.btnAtivar, 0);
            this.Controls.SetChildIndex(this.gpbTipoPesquisar, 0);
            this.Controls.SetChildIndex(this.gpbPesquisar, 0);
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
    }
}