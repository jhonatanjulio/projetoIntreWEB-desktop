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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProjetos_Click(object sender, EventArgs e)
        {
            frmProjetos abrir = new frmProjetos();
            abrir.Show();
            this.Hide();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            frmGaleria abrir = new frmGaleria();
            abrir.Show();
            this.Hide();
        }
    }
}
