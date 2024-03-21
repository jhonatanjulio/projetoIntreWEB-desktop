
namespace IntreDesktop
{
    partial class frmPesquisarGaleria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarGaleria));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.rdbTituloPesq = new System.Windows.Forms.RadioButton();
            this.rdbDescPesq = new System.Windows.Forms.RadioButton();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.dgvCodImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTituloGal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescGal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCampoTexto = new System.Windows.Forms.TextBox();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(401, 484);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(253, 484);
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Enabled = false;
            this.btnAtivar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtivar.Image")));
            this.btnAtivar.Location = new System.Drawing.Point(841, 484);
            this.btnAtivar.Size = new System.Drawing.Size(150, 67);
            this.btnAtivar.Text = "Desarquivar";
            this.btnAtivar.Visible = false;
            // 
            // gpbTipoPesquisar
            // 
            this.gpbTipoPesquisar.Location = new System.Drawing.Point(898, 12);
            this.gpbTipoPesquisar.Visible = false;
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.rdbDescPesq);
            this.gpbPesquisar.Controls.Add(this.rdbTituloPesq);
            this.gpbPesquisar.Location = new System.Drawing.Point(109, 12);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(550, 484);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 67);
            this.btnAlterar.TabIndex = 63;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // rdbTituloPesq
            // 
            this.rdbTituloPesq.AutoSize = true;
            this.rdbTituloPesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbTituloPesq.Location = new System.Drawing.Point(221, 25);
            this.rdbTituloPesq.Name = "rdbTituloPesq";
            this.rdbTituloPesq.Size = new System.Drawing.Size(65, 24);
            this.rdbTituloPesq.TabIndex = 0;
            this.rdbTituloPesq.TabStop = true;
            this.rdbTituloPesq.Text = "Título";
            this.rdbTituloPesq.UseVisualStyleBackColor = true;
            // 
            // rdbDescPesq
            // 
            this.rdbDescPesq.AutoSize = true;
            this.rdbDescPesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDescPesq.Location = new System.Drawing.Point(401, 25);
            this.rdbDescPesq.Name = "rdbDescPesq";
            this.rdbDescPesq.Size = new System.Drawing.Size(98, 24);
            this.rdbDescPesq.TabIndex = 1;
            this.rdbDescPesq.TabStop = true;
            this.rdbDescPesq.Text = "Descrição";
            this.rdbDescPesq.UseVisualStyleBackColor = true;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodImg,
            this.dgvTituloGal,
            this.dgvDescGal});
            this.dgvPesquisa.Location = new System.Drawing.Point(296, 147);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(343, 302);
            this.dgvPesquisa.TabIndex = 64;
            this.dgvPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellClick);
            // 
            // dgvCodImg
            // 
            this.dgvCodImg.HeaderText = "Código";
            this.dgvCodImg.Name = "dgvCodImg";
            this.dgvCodImg.ReadOnly = true;
            // 
            // dgvTituloGal
            // 
            this.dgvTituloGal.HeaderText = "Título";
            this.dgvTituloGal.Name = "dgvTituloGal";
            this.dgvTituloGal.ReadOnly = true;
            // 
            // dgvDescGal
            // 
            this.dgvDescGal.HeaderText = "Descrição";
            this.dgvDescGal.Name = "dgvDescGal";
            this.dgvDescGal.ReadOnly = true;
            // 
            // txtCampoTexto
            // 
            this.txtCampoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampoTexto.Location = new System.Drawing.Point(234, 86);
            this.txtCampoTexto.Name = "txtCampoTexto";
            this.txtCampoTexto.Size = new System.Drawing.Size(460, 30);
            this.txtCampoTexto.TabIndex = 65;
            // 
            // frmPesquisarGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 563);
            this.Controls.Add(this.txtCampoTexto);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.btnAlterar);
            this.Name = "frmPesquisarGaleria";
            this.Text = "frmPesquisarGaleria";
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            this.Controls.SetChildIndex(this.btnAtivar, 0);
            this.Controls.SetChildIndex(this.gpbTipoPesquisar, 0);
            this.Controls.SetChildIndex(this.gpbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.dgvPesquisa, 0);
            this.Controls.SetChildIndex(this.txtCampoTexto, 0);
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbDescPesq;
        private System.Windows.Forms.RadioButton rdbTituloPesq;
        private System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTituloGal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescGal;
        private System.Windows.Forms.TextBox txtCampoTexto;
    }
}