
namespace IntreDesktop
{
    partial class frmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.gpbTipoPesquisar = new System.Windows.Forms.GroupBox();
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(551, 484);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 67);
            this.btnLimpar.TabIndex = 55;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(251, 484);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(133, 67);
            this.btnPesquisar.TabIndex = 54;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnAtivar
            // 
            this.btnAtivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtivar.Image")));
            this.btnAtivar.Location = new System.Drawing.Point(401, 484);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(133, 67);
            this.btnAtivar.TabIndex = 56;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtivar.UseVisualStyleBackColor = false;
            // 
            // gpbTipoPesquisar
            // 
            this.gpbTipoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpbTipoPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoPesquisar.Location = new System.Drawing.Point(107, 16);
            this.gpbTipoPesquisar.Name = "gpbTipoPesquisar";
            this.gpbTipoPesquisar.Size = new System.Drawing.Size(704, 68);
            this.gpbTipoPesquisar.TabIndex = 59;
            this.gpbTipoPesquisar.TabStop = false;
            this.gpbTipoPesquisar.Text = "Tipo de Pesquisa:";
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbPesquisar.Location = new System.Drawing.Point(107, 90);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(704, 68);
            this.gpbPesquisar.TabIndex = 60;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por:";
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(915, 563);
            this.Controls.Add(this.gpbPesquisar);
            this.Controls.Add(this.gpbTipoPesquisar);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisar";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btnAtivar;
        public System.Windows.Forms.GroupBox gpbTipoPesquisar;
        public System.Windows.Forms.GroupBox gpbPesquisar;
    }
}