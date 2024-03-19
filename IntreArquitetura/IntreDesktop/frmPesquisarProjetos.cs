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
        public frmPesquisarProjetos()
        {
            InitializeComponent();
        }

        //carregar info dos projetos

        public void carregaInfos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT tbclientes.nomeCli, tipoImovel, tipoServico, status FROM `tbprojetos` inner join tbclientes on tbprojetos.codCli = tbclientes.codCli where status = 1;";
            comm.CommandType = CommandType.Text;


/*
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbPesquisa.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisa.Items.Add("R$" + DR.GetString(0) + " | " + DR.GetString(1) + " | " + Convert.ToDateTime(DR.GetString(2)).ToShortDateString());
                total = total + Convert.ToDouble(DR.GetString(0));
            }
            txtTotal.Text = Convert.ToString(total);

            Conexao.fecharConexao();*/
        }


    }
}
