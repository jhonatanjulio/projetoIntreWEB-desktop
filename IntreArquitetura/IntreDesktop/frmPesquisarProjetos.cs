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
    public partial class frmPesquisarProjetos : IntreDesktop.frmPesquisar
    {
        private string nomeCli;
        private string tipoImovel;
        private string tipoServico;
        private string status;
        private int codCli;
        private int codProj;


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
            comm.CommandText = "SELECT tbClientes.nomeCli, tipoImovel, tipoServico, status FROM `tbProjetos` inner join tbClientes on tbProjetos.codCli = tbClientes.codCli where status = 1;";
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
            comm.CommandText = "SELECT tbClientes.nomeCli, tipoImovel, tipoServico, status FROM `tbProjetos` inner join tbClientes on tbProjetos.codCli = tbClientes.codCli where status = 0;";
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
                MessageBox.Show("Selecione umas das opções acima!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
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
                if (nomeCli.Equals("") && tipoImovel.Equals("") && tipoServico.Equals(""))
                {
                    MessageBox.Show("Selecione pelo menos um registro!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    buscaCodCli();
                    buscaCodProj();
                    //MessageBox.Show(nomeCli.ToString() + " " + tipoImovel + " " + tipoImovel + " " + status);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecione um registro!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }



        public void buscaCodCli()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select tbClientes.codCli FROM tbProjetos inner join tbClientes where tbClientes.nomeCli = @nome and tbProjetos.tipoImovel = @tipoImovel and tbProjetos.tipoServico = @tipoServico ;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nomeCli;
            comm.Parameters.Add("@tipoImovel", MySqlDbType.VarChar, 50).Value = tipoImovel;
            comm.Parameters.Add("@tipoServico", MySqlDbType.VarChar, 50).Value = tipoServico;



            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            codCli = DR.GetInt32(0);

            Connection.fecharConexao();
        }


        public void buscaCodProj()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codProj FROM tbProjetos inner join tbClientes where tbClientes.nomeCli = @nome and tipoImovel = @tipoImovel and tipoServico = @tipoServico;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nomeCli;
            comm.Parameters.Add("@tipoImovel", MySqlDbType.VarChar, 50).Value = tipoImovel;
            comm.Parameters.Add("@tipoServico", MySqlDbType.VarChar, 50).Value = tipoServico;



            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            codProj = DR.GetInt32(0);



            Connection.fecharConexao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (codCli > 0)
            {
                frmProjetos abrir = new frmProjetos(nomeCli, tipoImovel, tipoServico, status, codCli, codProj);
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
            frmProjetos abrir = new frmProjetos();
            abrir.Show();
            this.Hide();
        }


        //Ativar projeto 
        public int ativarProj()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbProjetos set status = 1 where codProj = @codProj;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProj", MySqlDbType.Int32).Value = codProj;

            comm.Connection = Connection.abrirConexao();

            int res = comm.ExecuteNonQuery();

            Connection.fecharConexao();

            return res;
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (ativarProj() == 1)
            {
                MessageBox.Show("Ativado com sucesso!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao ativar!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limpar();
            }
        }
    }
}
