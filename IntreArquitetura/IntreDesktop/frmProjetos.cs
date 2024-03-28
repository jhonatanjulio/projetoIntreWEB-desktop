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
        List<string> listAmb = new List<string>() {null};
        string nomesAmb;
        string selectNomesAmb;
       
        string nomeCliAlte;
        string tipoImoAlte;
        string tipoSerALte;
        string statusAlte;
       

        public frmProjetos()
        {
            InitializeComponent();
            carregaNomeCLi();
            codigoAmbiente();
            desabilitarCampos();

        } 
        

        public frmProjetos(string nomeCli, string tipoImovel, string tipoServico, string status)
        {
            InitializeComponent();

            nomeCliAlte = nomeCli;
            tipoImoAlte = tipoImovel;
            tipoSerALte = tipoServico;
            statusAlte = status;

        }

        

        //verificando as checkBox
        public void verificando()
        {

            if (ckbSalaEstar.Checked)
            {
                listAmb.Add("sala_de_estar");
            }
            if (ckbSalaJantar.Checked)
            {
                listAmb.Add("sala_de_jantar");
            }
            if (ckbCozinhas.Checked)
            {
                listAmb.Add("cozinha");
            }
            if (ckbSuite.Checked)
            {
                listAmb.Add("suite");
            }
            if (ckbVaranda.Checked)
            {
                listAmb.Add("varanda");
            }
            if (ckbQuarto.Checked)
            {
                listAmb.Add("quarto");
            }
            if (ckbDoisQuarto.Checked)
            {
                listAmb.Add("2_quartos");
            }
            if (ckbTresQuarto.Checked)
            {
                listAmb.Add("3_quartos");
            }
            if (ckbBanheiro.Checked)
            {
                listAmb.Add("banheiro_social");
            }
            if (ckbEscritorio.Checked)
            {
                listAmb.Add("escritorio");
            }

            if (ckbAreaServico.Checked)
            {
                listAmb.Add("area_de_servico");
            }
            if (ckbOutros.Checked)
            {
                listAmb.Add(txtOutros.Text);
            }
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
            gpbAmbientes.Enabled = false;
            cbbMarcenaria.Enabled = false;
            nudMetragem.Enabled = false;
            cbbRevestimento.Enabled = false;
            cbbTipoImovel.Enabled = false;
            cbbTipoServico.Enabled = false;
            txtDescricaoAmbiente.Enabled = false;

            btnAlterar.Enabled = true;
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
            gpbAmbientes.Enabled = true;
            cbbMarcenaria.Enabled = true;
            nudMetragem.Enabled = true;
            cbbRevestimento.Enabled = true;
            cbbTipoImovel.Enabled = true;
            cbbTipoServico.Enabled = true;
            txtDescricaoAmbiente.Enabled = true;

            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtFormaContato.Focus();
        }

        public void limparCampos()
        {
            cbbCliente.SelectedIndex = -1;
            txtFormaContato.Clear();
            txtRua.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtDescricaoAmbiente.Clear();

            nudMetragem.ResetText();
            cbbMarcenaria.SelectedIndex = -1;
            cbbRevestimento.SelectedIndex = -1;
            cbbTipoImovel.SelectedIndex = -1;
            cbbTipoServico.SelectedIndex = -1;

            ckbSalaEstar.Checked = false;
            ckbSalaJantar.Checked = false;
            ckbCozinhas.Checked = false;
            ckbSuite.Checked = false;
            ckbVaranda.Checked = false;
            ckbQuarto.Checked = false;
            ckbDoisQuarto.Checked = false;
            ckbTresQuarto.Checked = false;
            ckbBanheiro.Checked = false;
            ckbEscritorio.Checked = false;
            ckbAreaServico.Checked = false;
            ckbOutros.Checked = false;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Utilities.limparCamposGeral(this);
            limparCampos();
            //Utilities.habilitarDesabBotaoGeral(this,"Limpar");
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

            

            if (cbbCliente.SelectedIndex != -1)
            {
                codCli = DR.GetInt16(0);
            }


            Connection.fecharConexao();
        }


        //Insert tabela ambientes
        public int insertAmbiente()
        {
            verificando();
            nomesAmb = String.Join(" ", listAmb.ToArray());

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbAmbientes(nomeAmb)values(@nomesAmb);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomesAmb", MySqlDbType.VarChar, 100).Value = nomesAmb;

            comm.Connection = Connection.abrirConexao();

            int res = comm.ExecuteNonQuery();

            Connection.fecharConexao();

            return res;
        }


        //Carrega codigo do ambiente
        public void codigoAmbiente()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codAmb FROM tbambientes ORDER BY codAmb DESC;";
            comm.CommandType = CommandType.Text;


            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            codAmb = DR.GetInt32(0) + 1;
            


            Connection.fecharConexao();
        }

        //Cadastrar projeto 
        public int cadastrarProjeto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProjetos(formaContato,logradouro,bairro,estado,cidade,complemento,tipoImovel,tipoServico,metragem,revestimentos,marcenaria,descricaoAmbiente,status," +
                "codCli,codAmb) values(@formaContato,@rua,@bairro,@estado,@cidade,@complemento,@tipoImovel,@tipoServico,@metragem,@revestimento,@marcenaria,@descricaoAmbiente,@status,@codCli,@codAmb);";
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
            comm.Parameters.Add("@descricaoAmbiente", MySqlDbType.VarChar, 50).Value = txtDescricaoAmbiente.Text;
            comm.Parameters.Add("@status", MySqlDbType.Bit).Value = true;
            comm.Parameters.Add("@codCli", MySqlDbType.Int16).Value = codCli;
            comm.Parameters.Add("@codAmb", MySqlDbType.Int32).Value = codAmb;

            comm.Connection = Connection.abrirConexao();

            int res = comm.ExecuteNonQuery();

            Connection.fecharConexao();

            return res;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            if (txtRua.Text.Equals(" ") || txtFormaContato.Text.Equals("") || cbbCliente.Text.Equals("") || txtEstado.Text.Equals("") || txtComplemento.Text.Equals("")
                || txtCidade.Text.Equals("") || txtBairro.Text.Equals("") || cbbMarcenaria.Text.Equals("") || cbbRevestimento.Text.Equals("")
                || cbbTipoImovel.Text.Equals("") || cbbTipoServico.Text.Equals("") || txtComplemento.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                
            }
            else
            {
                if (insertAmbiente() == 1 && cadastrarProjeto() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCampos();
                }

            }
            listAmb.Clear();

        }




        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoCliente();
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarProjetos abrir = new frmPesquisarProjetos();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            buscarAmb();
            char delimiter = ' ';
            List<string> stringList = selectNomesAmb.Split(delimiter).ToList();
            

            foreach (string item in stringList)
            {
                MessageBox.Show(item);

            }
        }

        private void ckbOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOutros.Checked)
            {
                lblOutros.Enabled = true;
                txtOutros.Enabled = true;
            }
            else
            {
                lblOutros.Enabled = false;
                txtOutros.Enabled = false;
            }
        }




        //select nome ambientes
        public void buscarAmb()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT nomeAmb FROM tbambientes where codAmb = 2;";
            comm.CommandType = CommandType.Text;


            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            selectNomesAmb = DR.GetString(0);



            Connection.fecharConexao();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nomeCliAlte);
            MessageBox.Show(tipoImoAlte);
            MessageBox.Show(tipoSerALte);
            MessageBox.Show(statusAlte);
        }




        /*
        private void button1_Click(object sender, EventArgs e)
        {
            verificando();
            foreach (string item in listAmb)
            {
                MessageBox.Show(item);

            }
        }
        */
    }
}
