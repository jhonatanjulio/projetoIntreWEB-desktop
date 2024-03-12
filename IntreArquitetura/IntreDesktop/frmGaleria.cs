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
    public partial class frmGaleria : Form
    {
        public frmGaleria()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtCarregarFotos.Clear();//Provavelmente isso aqui vai mudar
            txtTitulo.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Equals("") || txtDescricao.Text.Equals("") || txtCarregarFotos.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos o campos!");
            }
            else
            {
                MessageBox.Show("Inserido com sucesso!");
                limparCampos();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
            {
                //Excluir
                MessageBox.Show("Excluido com sucesso");
            }
            else
            {
                //Não excluir
            }
        }
    }
}
