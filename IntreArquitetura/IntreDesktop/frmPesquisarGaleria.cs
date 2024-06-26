﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private List<byte[]> imgByteList = new List<byte[]>();

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
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select codImg, tituloGal, descricaoGal, fotosGaleria from tbGaleria where tituloGal like @titulo ";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = "%" + txtCampoTexto.Text + "%";

                comm.Connection = Connection.abrirConexao();
                MySqlDataReader DR;

                DR = comm.ExecuteReader();
                List<int> cod = new List<int>();
                dgvPesquisa.Rows.Clear();
                while (DR.Read())
                {
                    if (DR.HasRows)
                    {
                        if (!cod.Contains((int)DR.GetValue(0)))
                        {
                            dgvPesquisa.Rows.Add(DR.GetString("codImg"), DR.GetString("tituloGal"), DR.GetString("descricaoGal"));
                            cod.Add((int)DR.GetValue(0));
                        }
                    }
                }
                Connection.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os projetos! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        // Pesquisar por Descrição:
        public void pesquisarGalDesc()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select codImg, tituloGal, descricaoGal from tbGaleria where descricaoGal like @desc ";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@desc", MySqlDbType.VarChar).Value = "%" + txtCampoTexto.Text + "%";

                comm.Connection = Connection.abrirConexao();
                MySqlDataReader DR;

                DR = comm.ExecuteReader();
                List<int> cod = new List<int>();
                dgvPesquisa.Rows.Clear();
                while (DR.Read())
                {
                    if (DR.HasRows)
                    {
                        if (!cod.Contains((int)DR.GetValue(0)))
                        {
                            dgvPesquisa.Rows.Add(DR.GetString("codImg"), DR.GetString("tituloGal"), DR.GetString("descricaoGal"));
                            cod.Add((int)DR.GetValue(0));
                        }
                    }
                }
                Connection.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os projetos! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
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

        private void pesquisarBytes() //função sql para pesquisar os bytes das fotos inseridas
        {

            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select fotosGaleria from tbGaleria where codImg = @codImg";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@codImg", MySqlDbType.Int32).Value = codImg;

                comm.Connection = Connection.abrirConexao();
                MySqlDataReader DR;

                DR = comm.ExecuteReader();
                byte[] byteImg = null;
                imgByteList.Clear();
                while (DR.Read())
                {
                    if (DR.HasRows)
                    {
                        byteImg = (byte[])DR.GetValue(0);
                        imgByteList.Add(byteImg);

                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar as imagens! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
            Connection.fecharConexao();
        }
        public static Image ConvertToImage(System.Data.Linq.Binary iBinary) // função converter o byte[] em img
        {

            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {

                rImage = Image.FromStream(ms);
            }
            return rImage;
        }

        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                pesquisarBytes();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecione um registro!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (imgByteList.Count > 0)
            {
                frmGaleria abrir = new frmGaleria(codImg, tituloGal, descricaoGal, imgByteList);
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um registro!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGaleria abrir = new frmGaleria();
            abrir.Show();
            this.Hide();
        }
    }
}
