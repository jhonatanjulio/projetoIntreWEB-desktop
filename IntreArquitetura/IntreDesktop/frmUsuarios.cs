﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntreDesktop
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            Utilities.habilitarDesabBotaoGeral(this, "Inicio");
        }

        // evento de clique botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilities.habilitarDesabBotaoGeral(this, "Novo");
        }

        // evento de clique botão Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Utilities.habilitarDesabBotaoGeral(this, "Cadastrar");
        }

        // evento de clique botão Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Utilities.habilitarDesabBotaoGeral(this, "Alterar");
        }

        // evento de clique botão Desativar
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            Utilities.habilitarDesabBotaoGeral(this, "Desativar");
        }

        // evento de clique botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Utilities.habilitarDesabBotaoGeral(this, "Pesquisar");
        }

        // evento de clique botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Utilities.limparCamposGeral(this);
            Utilities.habilitarDesabBotaoGeral(this, "Limpar");
        }

        
    }
}
