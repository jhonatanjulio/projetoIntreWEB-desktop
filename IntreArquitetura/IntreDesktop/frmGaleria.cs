using System;
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
    public partial class frmGaleria : Form
    {
        public int codImg { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public List<string> caminhoImg = new List<string>();
        public byte[] img { get; set; }

        public frmGaleria()
        {
            InitializeComponent();
        }

    public void limparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtTitulo.Focus();
        }

        //Enviar Imagem
        //public void cadastrarProjeto()
        //{
        //    MySqlCommand comm = new MySqlCommand();
        //    comm.CommandText = "insert into tbProjetos(formaContato,logradouro,bairro,estado,cidade,complemento,tipoImovel,tipoServico,metragem,revestimentos,marcenaria,descricaoAmbiente," +
        //        "codCli,codAmb) values(@formaContato,@rua,@bairro,@estado,@cidade,@complemento,@tipoImovel,@tipoServico,@metragem,@revestimento,@marcenaria,@descricaoAmbiente);";
        //    comm.CommandType = CommandType.Text;

        //    comm.Parameters.Clear();
        //    comm.Parameters.Add("@formaContato", MySqlDbType.VarChar, 50).Value = txtFormaContato.Text;
        //    comm.Parameters.Add("@rua", MySqlDbType.VarChar, 50).Value = txtRua.Text;
        //    comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = txtBairro.Text;
        //    comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = txtEstado.Text;
        //    comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = txtCidade.Text;
        //    comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 50).Value = txtComplemento.Text;
        //    comm.Parameters.Add("@tipoImovel", MySqlDbType.VarChar, 50).Value = cbbTipoImovel.Text;
        //    comm.Parameters.Add("@tipoServico", MySqlDbType.VarChar, 50).Value = cbbTipoServico.Text;
        //    comm.Parameters.Add("@metragem", MySqlDbType.Decimal).Value = nudMetragem.Value;
        //    comm.Parameters.Add("@revestimento", MySqlDbType.VarChar, 50).Value = cbbRevestimento.Text;
        //    comm.Parameters.Add("@marcenaria", MySqlDbType.VarChar, 50).Value = cbbMarcenaria.Text;
        //    comm.Parameters.Add("@descricaoAmbiente", MySqlDbType.VarChar, 50).Value = txtDescricaoAmbiente.Text;

        //    comm.Connection = Connection.abrirConexao();

        //    comm.ExecuteNonQuery();

        //    Connection.fecharConexao();
        //}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Equals("") || txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos o campos!");
            }
            else
            {
                byte[] foto;

                // ler bytes da foto
                foreach(string caminho in this.caminhoImg)
                {
                    using (var stream = new FileStream(caminho, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {
                            foto = reader.ReadBytes((int)stream.Length);
                        }
                    }
                }
                
                MessageBox.Show("Inserido com sucesso!");
                limparCampos();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
            {
                //Excluir
                MessageBox.Show("Excluido com sucesso");
            }
            else
            {
                //Não excluir
            }
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImg = new OpenFileDialog();
            abrirImg.InitialDirectory = ("d:\\imagens\\");
            abrirImg.FileName = "Imagem";
            abrirImg.Title = "Procurar Imagem";
            abrirImg.Filter = ("Arquivos de imagem .jpg e .png|*.jpg; *png|*jpg|*.jpg|*jpeg|*.jpeg|*jfif|*.jfif|*png|*.png");
            abrirImg.Multiselect = false;
            if (abrirImg.ShowDialog() == DialogResult.OK)
                this.caminhoImg.Add(abrirImg.FileName);

            if (this.caminhoImg.Count > 0)
                pcbPreview.Load(this.caminhoImg[0]);

            lstImagens.Items.Clear();
            foreach (string nomeArq in this.caminhoImg)
            {
                lstImagens.Items.Add(Path.GetFileName(nomeArq)); //PEGAR PELO INDEX DA LISTA MESMO INDEX DA LISTA CAMINHOIMG
            }
        }
    }
}
