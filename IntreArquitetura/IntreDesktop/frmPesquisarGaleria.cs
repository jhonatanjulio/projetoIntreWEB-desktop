using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IntreDesktop
{
    public partial class frmPesquisarGaleria : IntreDesktop.frmPesquisar
    {

        private int codImg = 0;
        private string tituloGal;
        private string descricaoGal;

        public frmPesquisarGaleria()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtCampoTexto.Clear();
            dgvPesquisa.Rows.Clear();
            rdbDescPesq.Checked = false;
            rdbTituloPesq.Checked = false;
        }

        // Pesquisar por Titulo:
        public void pesquisarGalTitulo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codImg, tituloGal, descricaoGal from tbGaleria where tituloGal like @titulo ";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = "%" + txtCampoTexto.Text + "%";

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            int cod = 0;
            dgvPesquisa.Rows.Clear();
            while (DR.Read())
            {
                if (Convert.ToInt32(DR.GetString("codImg")) != cod)
                {
                    dgvPesquisa.Rows.Add(DR.GetString("codImg"), DR.GetString("tituloGal"), DR.GetString("descricaoGal"));
                    cod = Convert.ToInt32(DR.GetString("codImg"));
                }
            }
            Connection.fecharConexao();
        }

        // Pesquisar por Descrição:
        public void pesquisarGalDesc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codImg, tituloGal, descricaoGal from tbGaleria where descricaoGal like @desc ";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@desc", MySqlDbType.VarChar).Value = "%" + txtCampoTexto.Text + "%";

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            int cod = 0;
            dgvPesquisa.Rows.Clear();
            while (DR.Read())
            {
                if (Convert.ToInt32(DR.GetString("codImg")) != cod)
                {
                    dgvPesquisa.Rows.Add(DR.GetString("codImg"), DR.GetString("tituloGal"), DR.GetString("descricaoGal"));
                    cod = Convert.ToInt32(DR.GetString("codImg"));
                }
            }
            Connection.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtCampoTexto.Text.Equals(""))
            {
                if (rdbTituloPesq.Checked)
                {
                    pesquisarGalTitulo();
                }
                else if (rdbDescPesq.Checked)
                {
                    pesquisarGalDesc();
                }
                else
                {
                    MessageBox.Show("Selecione uma opção de Pesquisa!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvPesquisa.Rows[e.RowIndex].Cells.Count; i++)
            {
                string columnName = dgvPesquisa.Columns[dgvPesquisa.Rows[e.RowIndex].Cells[i].ColumnIndex].Name;

                switch (columnName)
                {
                    case "dgvCodImg":
                        codImg = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells[i].Value);
                        break;
                    case "dgvTituloGal": 
                        tituloGal = Convert.ToString(dgvPesquisa.Rows[e.RowIndex].Cells[i].Value);
                        break;
                    case "dgvDescGal": 
                        descricaoGal = Convert.ToString(dgvPesquisa.Rows[e.RowIndex].Cells[i].Value);
                        break;
                }
            }

            MessageBox.Show(codImg.ToString() + " " + tituloGal + " " + descricaoGal);
        }
    }
}
