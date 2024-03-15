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
    public partial class frmProjetos : Form
    {
        private int codCli;
        private int codAmb;

        public frmProjetos()
        {
            InitializeComponent();
            carregaNomeCLi();
            carregaAmb();
            desabilitarCampos();
        }

        public void desabilitarCampos()
        {
            cbbCliente.Enabled = false;
            txtFormaContato.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtComplemento.Enabled = false;
            txtEstado.Enabled = false;
            cbbAmbiente.Enabled = false;
            cbbMarcenaria.Enabled = false;
            nudMetragem.Enabled = false;
            cbbRevestimento.Enabled = false;
            cbbTipoImovel.Enabled = false;
            cbbTipoServico.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnArquivar.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Focus();
        }

        public void habilitarCampos()
        {
            cbbCliente.Enabled = true;
            txtFormaContato.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            txtEstado.Enabled = true;
            cbbAmbiente.Enabled = true;
            cbbMarcenaria.Enabled = true;
            nudMetragem.Enabled = true;
            cbbRevestimento.Enabled = true;
            cbbTipoImovel.Enabled = true;
            cbbTipoServico.Enabled = true;

            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtFormaContato.Focus();
        }

        public void limparCampos()
        {
            cbbCliente.Text = "";
            txtFormaContato.Clear();
            txtRua.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            cbbAmbiente.Text = "";
            nudMetragem.ResetText();
            cbbMarcenaria.Text = "";

            cbbRevestimento.Text = "";
            cbbTipoImovel.Text = "";
            cbbTipoServico.Text = "";
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {

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


        //Carrega nome dos clientes na ccb
        public void carregaNomeCLi()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT nomeCli FROM `tbclientes`;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            cbbCliente.Items.Clear();

            while (DR.Read())
            {
                cbbCliente.Items.Add(DR.GetString(0));
            }

            Connection.fecharConexao();
        }

        //Carrega nome ambiente ccb
        public void carregaAmb()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT nomeAmb FROM `tbambientes`;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

           cbbAmbiente.Items.Clear();

            while (DR.Read())
            {
                cbbAmbiente.Items.Add(DR.GetString(0));
            }

            Connection.fecharConexao();
        }




        //carrega codigo do cliente;
        public void codigoCliente()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codCli FROM tbclientes WHERE nomeCli = @cliente";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@cliente", MySqlDbType.VarChar, 50).Value = cbbCliente.SelectedItem;

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            //txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            codCli = DR.GetInt16(0);

            Connection.fecharConexao();
        }

        //Carrega codigo do ambiente
        public void codigoAmbiente()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codAmb FROM `tbambientes` WHERE nomeAmb = @ambiente;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@ambiente", MySqlDbType.VarChar, 50).Value = cbbAmbiente.SelectedItem;

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            //txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            codAmb = DR.GetInt16(0);

            Connection.fecharConexao();
        }

        //Cadastrar projeto 
        public void cadastrarProjeto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProjetos(formaContato,logradouro,bairro,estado,cidade,complemento,tipoImovel,tipoServico,metragem,revestimentos,marcenaria,descricaoAmbiente," +
                "codCli,codAmb) values(@formaContato,@rua,@bairro,@estado,@cidade,@complemento,@tipoImovel,@tipoServico,@metragem,@revestimento,@marcenaria,@descricaoAmbiente,@codCli,@codAmb);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@formaContato", MySqlDbType.VarChar, 50).Value = txtFormaContato.Text;
            comm.Parameters.Add("@rua", MySqlDbType.VarChar, 50).Value = txtRua.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = txtBairro.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = txtEstado.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = txtCidade.Text;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 50).Value = txtComplemento.Text;
            comm.Parameters.Add("@tipoImovel", MySqlDbType.VarChar, 50).Value = cbbTipoImovel.Text;
            comm.Parameters.Add("@tipoServico", MySqlDbType.VarChar, 50).Value = cbbTipoServico.Text;
            comm.Parameters.Add("@metragem", MySqlDbType.Decimal).Value = nudMetragem.Value;
            comm.Parameters.Add("@revestimento", MySqlDbType.VarChar, 50).Value = cbbRevestimento.Text;
            comm.Parameters.Add("@marcenaria", MySqlDbType.VarChar, 50).Value = cbbMarcenaria.Text;
            comm.Parameters.Add("@descricaoAmbiente", MySqlDbType.VarChar, 50).Value = cbbAmbiente.Text;
            comm.Parameters.Add("@codCli", MySqlDbType.Int16).Value = codCli;
            comm.Parameters.Add("@codAmb", MySqlDbType.Int16).Value = codAmb;

            comm.Connection = Connection.abrirConexao();

            comm.ExecuteNonQuery();

            Connection.fecharConexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarProjeto();
            limparCampos();
        }

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoCliente();
        }

        private void cbbAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoAmbiente();
        }
    }
}
