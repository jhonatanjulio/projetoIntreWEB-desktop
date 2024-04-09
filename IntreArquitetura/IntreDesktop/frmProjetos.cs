using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IntreDesktop
{
    public partial class frmProjetos : Form
    {
        private int codCli;
        private int codAmb = 1;
        List<string> listAmb = new List<string>() { null };
        string nomesAmb;
        string nomesAmbAlte;
        string selectNomesAmb;

        string nomeCliAlte;
        string tipoImoAlte;
        string tipoSerALte;
        string statusAlte;
        int codProje;


        private int codAmbAlte;

        private int codCliAlte;


        public frmProjetos()
        {
            InitializeComponent();
            carregaNomeCLi();
            codigoAmbiente();
            Utilities.habilitarDesabBotaoGeral(this, "Inicio");
            desabilitarCampos();
        }


        public frmProjetos(string nomeCli, string tipoImovel, string tipoServico, string status, int codCli, int codProj)
        {
            InitializeComponent();
            carregaNomeCLi();
            habilitarCampos();

            nomeCliAlte = nomeCli;
            tipoImoAlte = tipoImovel;
            tipoSerALte = tipoServico;
            statusAlte = status;
            codCliAlte = codCli;
            codProje = codProj;

            buscarCodAmb();
            carregaInfos();
            alterarCkb();
        }



        //verificando as checkBox
        public void verificandoCkb()
        {
            listAmb.Clear();

            // sala de estar
            if (ckbSalaEstar.Checked)
            {
                listAmb.Add("sala_de_estar");
            }
            else
            {
                if (listAmb.Contains("sala_de_estar"))
                {
                    listAmb.Remove("sala_de_estar");
                }
            }

            // sala de jantar
            if (ckbSalaJantar.Checked)
            {
                listAmb.Add("sala_de_jantar");
            }
            else
            {
                if (listAmb.Contains("sala_de_jantar"))
                {
                    listAmb.Remove("sala_de_jantar");
                }
            }

            // cozinha
            if (ckbCozinhas.Checked)
            {
                listAmb.Add("cozinha");
            }
            else
            {
                if (listAmb.Contains("cozinha"))
                {
                    listAmb.Remove("cozinha");
                }
            }

            // suite
            if (ckbSuite.Checked)
            {
                listAmb.Add("suite");
            }
            else
            {
                if (listAmb.Contains("suite"))
                {
                    listAmb.Remove("suite");
                }
            }

            // varanda
            if (ckbVaranda.Checked)
            {
                listAmb.Add("varanda");
            }
            else
            {
                if (listAmb.Contains("varanda"))
                {
                    listAmb.Remove("varanda");
                }
            }

            // quarto
            if (ckbQuarto.Checked)
            {
                listAmb.Add("quarto");
            }
            else
            {
                if (listAmb.Contains("quarto"))
                {
                    listAmb.Remove("quarto");
                }
            }

            // dois quartos
            if (ckbDoisQuarto.Checked)
            {
                listAmb.Add("2_quartos");
            }
            else
            {
                if (listAmb.Contains("2_quartos"))
                {
                    listAmb.Remove("2_quartos");
                }
            }

            // tres quartos
            if (ckbTresQuarto.Checked)
            {
                listAmb.Add("3_quartos");
            }
            else
            {
                if (listAmb.Contains("3_quartos"))
                {
                    listAmb.Remove("3_quartos");
                }
            }

            // banheiro
            if (ckbBanheiro.Checked)
            {
                listAmb.Add("banheiro_social");
            }
            else
            {
                if (listAmb.Contains("banheiro_social"))
                {
                    listAmb.Remove("banheiro_social");
                }
            }

            // escritorio
            if (ckbEscritorio.Checked)
            {
                listAmb.Add("escritorio");
            }
            else
            {
                if (listAmb.Contains("escritorio"))
                {
                    listAmb.Remove("escritorio");
                }
            }

            // area servico
            if (ckbAreaServico.Checked)
            {
                listAmb.Add("area_de_servico");
            }
            else
            {
                if (listAmb.Contains("area_de_servico"))
                {
                    listAmb.Remove("area_de_servico");
                }
            }

            // outros
            if (ckbOutros.Checked)
            {
                if (!txtOutros.Text.Equals(""))
                {
                    listAmb.Add(("*." + txtOutros.Text.Replace(" ", "_")).ToLower());
                }
            }
            else
            {
                if (listAmb.Contains(("*." + txtOutros.Text.Replace(" ", "_")).ToLower()))
                {
                    listAmb.Remove(("*." + txtOutros.Text.Replace(" ", "_")).ToLower());
                }
            }

            nomesAmb = String.Join(" ", listAmb.ToArray());
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
            txtOutros.Clear();

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
            txtOutros.Clear();
            btnNovo.Enabled = true;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            carregaNomeCLi();
            if (cbbCliente.Items.Count == 0)
            {
                MessageBox.Show("Nenhum cliente cadastrado! Cadastre um cliente antes para prosseguir.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Utilities.habilitarDesabBotaoGeral(this, "Novo");
                habilitarCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
            Utilities.habilitarDesabBotaoGeral(this, "Limpar");
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
            comm.CommandText = "SELECT nomeCli FROM `tbClientes`;";
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
            comm.CommandText = "SELECT codCli FROM tbClientes WHERE nomeCli = @cliente";
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
            verificandoCkb();

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbAmbientes(nomeAmb)values(@nomesAmb);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomesAmb", MySqlDbType.VarChar, 100).Value = nomesAmb;

            comm.Connection = Connection.abrirConexao();

            int res = comm.ExecuteNonQuery();

            Connection.fecharConexao();

            codigoAmbiente();
            codAmb -= 1;
            return res;
        }


        //Carrega codigo do ambiente
        public void codigoAmbiente()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codAmb+1 FROM tbAmbientes ORDER BY codAmb DESC;";
            comm.CommandType = CommandType.Text;


            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();



            if (DR.Read())
            {
                codAmb = DR.GetInt32(0);
            }

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
                    Utilities.habilitarDesabBotaoGeral(this, "Cadastrar");
                    desabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
            if (txtRua.Text.Equals(" ") || txtFormaContato.Text.Equals("") || cbbCliente.Text.Equals("") || txtEstado.Text.Equals("") || txtComplemento.Text.Equals("")
                || txtCidade.Text.Equals("") || txtBairro.Text.Equals("") || cbbMarcenaria.Text.Equals("") || cbbRevestimento.Text.Equals("")
                || cbbTipoImovel.Text.Equals("") || cbbTipoServico.Text.Equals("") || txtComplemento.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
            else
            {
                if (alterarProjetos(codProje) == 1 && alterarAmbientes(codAmbAlte) == 1)
                {
                    MessageBox.Show("Alterado com sucesso!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limparCampos();
                    Utilities.habilitarDesabBotaoGeral(this, "Alterar");
                    desabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
            listAmb.Clear();
        }

        private void ckbOutros_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();

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

        //select codAmb
        public void buscarCodAmb()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codAmb FROM tbprojetos WHERE codProj = @codProj;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProj", MySqlDbType.Int32).Value = codProje;


            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            codAmbAlte = DR.GetInt32(0);


            Connection.fecharConexao();
        }

        //select nome ambientes
        public void buscarAmb()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT nomeAmb FROM tbAmbientes where codAmb = @codAmb;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codAmb", MySqlDbType.Int32).Value = codAmbAlte;


            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            selectNomesAmb = DR.GetString(0);

            Connection.fecharConexao();
        }


        //Alteração
        public void carregaInfos()
        {
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "SELECT * from tbProjetos WHERE codCli = @codCli and tipoImovel = @tipoImo and tipoServico = @tipoServ and codProj = @codProj";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@codCli", MySqlDbType.VarChar, 100).Value = codCliAlte;
                comm.Parameters.Add("@tipoImo", MySqlDbType.VarChar, 100).Value = tipoImoAlte;
                comm.Parameters.Add("@tipoServ", MySqlDbType.VarChar, 100).Value = tipoSerALte;
                comm.Parameters.Add("@codProj", MySqlDbType.Int32).Value = codProje;

                comm.Connection = Connection.abrirConexao();

                MySqlDataReader DR;
                DR = comm.ExecuteReader();
                DR.Read();

                txtFormaContato.Text = DR.GetString(1);
                txtRua.Text = DR.GetString(2);
                txtBairro.Text = DR.GetString(3);
                txtEstado.Text = DR.GetString(4);
                txtCidade.Text = DR.GetString(5);
                txtComplemento.Text = DR.GetString(6);
                cbbTipoImovel.SelectedItem = tipoImoAlte;
                cbbTipoServico.SelectedItem = tipoSerALte;
                nudMetragem.Value = DR.GetInt32(9);
                cbbRevestimento.SelectedItem = DR.GetString(10);
                cbbMarcenaria.SelectedItem = DR.GetString(11);
                txtDescricaoAmbiente.Text = DR.GetString(12);
                cbbCliente.Text = nomeCliAlte;

                Connection.fecharConexao();
            }
        }

        //Alterar Checkbox amb
        public void alterarCkb()
        {
            buscarAmb();
            char delimiter = ' ';
            List<string> stringList = selectNomesAmb.Split(delimiter).ToList();


            foreach (string item in stringList)
            {
                if (item.StartsWith("*"))
                {
                    ckbOutros.Checked = true;
                    char caractere = '.';
                    List<string> lista = item.Split(caractere).ToList();
                    txtOutros.Text = lista[1].Replace("_", " ");
                }

                switch (item)
                {
                    case "sala_de_estar":
                        ckbSalaEstar.Checked = true;
                        break;
                    case "sala_de_jantar":
                        ckbSalaJantar.Checked = true;
                        break;
                    case "cozinha":
                        ckbCozinhas.Checked = true;
                        break;
                    case "suite":
                        ckbSuite.Checked = true;
                        break;
                    case "varanda":
                        ckbVaranda.Checked = true;
                        break;
                    case "quarto":
                        ckbQuarto.Checked = true;
                        break;
                    case "2_quartos":
                        ckbDoisQuarto.Checked = true;
                        break;
                    case "3_quartos":
                        ckbTresQuarto.Checked = true;
                        break;
                    case "banheiro_social":
                        ckbBanheiro.Checked = true;
                        break;
                    case "escritorio":
                        ckbEscritorio.Checked = true;
                        break;
                    case "area_de_servico":
                        ckbAreaServico.Checked = true;
                        break;
                }
            }
        }


        //update projetos
        public int alterarProjetos(int cod)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbProjetos set formaContato = @formaContato, logradouro = @rua, bairro = @bairro, estado = @estado, cidade = @cidade, complemento = @complemento, tipoImovel = @tipoImovel, tipoServico = @tipoServico, metragem = @metragem, revestimentos = @revestimento, marcenaria = @marcenaria, descricaoAmbiente = @descricaoAmbiente where codProj = @codProj;";
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
            comm.Parameters.Add("@codProj", MySqlDbType.Int32).Value = cod;


            comm.Connection = Connection.abrirConexao();

            int res = 0;
            res = comm.ExecuteNonQuery();

            Connection.fecharConexao();

            return res;
            
        }

        //update ambientes
        public int alterarAmbientes(int cod)
        {

            verificandoCkb();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbAmbientes set nomeAmb = @nomeAmb where codAmb = @codAmb;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeAmb", MySqlDbType.VarChar).Value = nomesAmb;
            comm.Parameters.Add("@codAmb", MySqlDbType.Int32).Value = cod;

            comm.Connection = Connection.abrirConexao();

            comm.Connection = Connection.abrirConexao();

            int res = 0;
            res = comm.ExecuteNonQuery();

            Connection.fecharConexao();

            return res; 
        }


        //Arquivar projeto
        public int arquivarProje()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbProjetos set status = 0 where codProj = @codProj;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProj", MySqlDbType.Int32).Value = codProje;

            comm.Connection = Connection.abrirConexao();

            int res = comm.ExecuteNonQuery();
            
            Connection.fecharConexao();

            return res;
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {

            if (arquivarProje() == 1)
            {
                MessageBox.Show("Arquivado com sucesso!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
                desabilitarCampos();
            }
            else
            {
                MessageBox.Show("Erro ao arquivar!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limparCampos();
                desabilitarCampos();
            }
        }
        private void ckbQuarto_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbVaranda_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbBanheiro_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbSalaJantar_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbSalaEstar_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbEscritorio_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbCozinhas_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbDoisQuarto_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbAreaServico_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbSuite_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }

        private void ckbTresQuarto_CheckedChanged(object sender, EventArgs e)
        {
            verificandoCkb();
        }
    }

}


