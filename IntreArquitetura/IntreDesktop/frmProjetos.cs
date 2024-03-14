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
            txtFormaContato.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            txtEstado.Enabled = true;
            txtDescricaoAmbiente.Enabled = true;
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
            txtFormaContato.Clear();
            txtRua.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtDescricaoAmbiente.Clear();
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


        //Cadastrar projeto 
        public void cadastrarProjeto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProjetos(formaContato,logradouro,bairro,estado,cidade,complemento,tipoImovel,tipoServico,metragem,revestimentos,marcenaria,descricaoAmbiente," +
                "codCli,codAmb) values(@formaContato,@rua,@bairro,@estado,@cidade,@complemento,@tipoImovel,@tipoServico,@metragem,@revestimento,@marcenaria,@descricaoAmbiente);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@formaContato",MySqlDbType.VarChar,50).Value = txtFormaContato.Text;
            comm.Parameters.Add("@rua",MySqlDbType.VarChar,50).Value = txtRua.Text;
            comm.Parameters.Add("@bairro",MySqlDbType.VarChar,50).Value = txtBairro.Text;
            comm.Parameters.Add("@estado",MySqlDbType.VarChar,2).Value = txtEstado.Text;
            comm.Parameters.Add("@cidade",MySqlDbType.VarChar,50).Value = txtCidade.Text;
            comm.Parameters.Add("@complemento",MySqlDbType.VarChar,50).Value = txtComplemento.Text;
            comm.Parameters.Add("@tipoImovel",MySqlDbType.VarChar,50).Value = cbbTipoImovel.Text;
            comm.Parameters.Add("@tipoServico",MySqlDbType.VarChar,50).Value = cbbTipoServico.Text;
            comm.Parameters.Add("@metragem",MySqlDbType.Decimal).Value = nudMetragem.Value;
            comm.Parameters.Add("@revestimento",MySqlDbType.VarChar,50).Value = cbbRevestimento.Text;
            comm.Parameters.Add("@marcenaria",MySqlDbType.VarChar,50).Value = cbbMarcenaria.Text;
            comm.Parameters.Add("@descricaoAmbiente",MySqlDbType.VarChar,50).Value = txtDescricaoAmbiente.Text;

            comm.Connection = Connection.abrirConexao();

            comm.ExecuteNonQuery();

            Connection.fecharConexao();
        }
    }
}
