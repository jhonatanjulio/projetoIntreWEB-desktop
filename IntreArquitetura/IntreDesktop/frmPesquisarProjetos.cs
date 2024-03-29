﻿using System;
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
    public partial class frmPesquisarProjetos : IntreDesktop.frmPesquisar
    {
        private string nomeCli;
        private string tipoImovel;
        private string tipoServico;
        private string status;


        public frmPesquisarProjetos()
        {
            InitializeComponent();
        }

        //limpar
        public void limpar()
        {
            dgvPesquisa.Rows.Clear();
            rdbAndamento.Checked = false;
            rdbArquivados.Checked = false;
        }




        //carregar info dos projetos
        public void carregaInfosAtivo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT tbclientes.nomeCli, tipoImovel, tipoServico, status FROM `tbprojetos` inner join tbclientes on tbprojetos.codCli = tbclientes.codCli where status = 1;";
            comm.CommandType = CommandType.Text;



            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            dgvPesquisa.Rows.Clear();

            string status = "Arquivado";
            
            while (DR.Read())
            {
                if (DR.GetString("status").Equals("True"))
                {
                    status = "Ativo";
                }

                dgvPesquisa.Rows.Add(DR.GetString("nomeCli"), DR.GetString("tipoImovel"), DR.GetString("tipoServico"), status);

                


            }


            Connection.fecharConexao();
        }



        public void carregaInfosArquivados()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT tbclientes.nomeCli, tipoImovel, tipoServico, status FROM `tbprojetos` inner join tbclientes on tbprojetos.codCli = tbclientes.codCli where status = 0;";
            comm.CommandType = CommandType.Text;



            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            dgvPesquisa.Rows.Clear();

            string status = "Arquivado";
            

            while (DR.Read())
            {
                if (DR.GetString("status").Equals("True"))
                {
                    status = "Ativo";
                }

                dgvPesquisa.Rows.Add(DR.GetString("nomeCli"), DR.GetString("tipoImovel"), DR.GetString("tipoServico"), status);


            }


            Connection.fecharConexao();
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbAndamento.Checked)
            {
                carregaInfosAtivo();

            }
            else if (rdbArquivados.Checked)
            {
                carregaInfosArquivados();
            }
            else
            {
                MessageBox.Show("Selecione umas das opções acima!");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }


        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvPesquisa.Rows[e.RowIndex].Cells.Count; i++)
            {
                string columnName = dgvPesquisa.Columns[dgvPesquisa.Rows[e.RowIndex].Cells[i].ColumnIndex].Name;

                switch (columnName)
                {
                    case "coluna1":
                        nomeCli = Convert.ToString(dgvPesquisa.Rows[e.RowIndex].Cells[i].Value);
                        break;
                    case "coluna2":
                        tipoImovel = Convert.ToString(dgvPesquisa.Rows[e.RowIndex].Cells[i].Value);
                        break;
                    case "coluna3":
                        tipoServico = Convert.ToString(dgvPesquisa.Rows[e.RowIndex].Cells[i].Value);
                        break;
                    case "coluna4":
                        status = Convert.ToString(dgvPesquisa.Rows[e.RowIndex].Cells[i].Value);
                        break;
                }
            }

            MessageBox.Show(nomeCli.ToString() + " " + tipoImovel + " " + tipoImovel + " " + status);
        }
    }
}
