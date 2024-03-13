using System;
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
    public partial class frmProjetos : Form
    {
        public frmProjetos()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public void desabilitarCampos()
        {
            txtFormaContato.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtComplemento.Enabled = false;
            txtEstado.Enabled = false;
            txtDescricaoAmbiente.Enabled = false;
            txtFotosAmbiente.Enabled = false;
            cbbMarcenaria.Enabled = false;
            cbbMetragem.Enabled = false;
            cbbRevestimento.Enabled = false;
            cbbTipoImovel.Enabled = false;
            cbbTipoServico.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnDesativar.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Focus();
        }

        public void habilitarCampos()
        {
            txtFormaContato.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            txtEstado.Enabled = true;
            txtDescricaoAmbiente.Enabled = true;
            txtFotosAmbiente.Enabled = true;
            cbbMarcenaria.Enabled = true;
            cbbMetragem.Enabled = true;
            cbbRevestimento.Enabled = true;
            cbbTipoImovel.Enabled = true;
            cbbTipoServico.Enabled = true;

            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtFormaContato.Focus();
        }

        public void limparCampos()
        {
            txtFormaContato.Clear();
            txtRua.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtDescricaoAmbiente.Clear();
            txtFotosAmbiente.Clear();

            cbbMarcenaria.Text = "";
            cbbMetragem.Text = "";
            cbbRevestimento.Text = "";
            cbbTipoImovel.Text = "";
            cbbTipoServico.Text = "";
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            Connection.abrirConexao();
            habilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
