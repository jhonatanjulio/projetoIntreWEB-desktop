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
        public int codImg = 1;
        public List<byte[]> imgByteList = new List<byte[]>();

        public frmGaleria()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtTitulo.Focus();

            imgByteList.Clear();
            lstImagens.Items.Clear();
            pcbPreview.Image = null;
        }

        // Pesquisar Codigo Img
        public void pesquisarCodImg()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codImg+1 from tbGaleria order by codImg desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            codImg = Convert.ToInt32(DR.GetValue(0));

            Connection.fecharConexao();
        }

        // Enviar Imagem
        public void cadastrarProjeto(byte[] img)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbGaleria(codImg, tituloGal, descricaoGal, fotosGaleria) values(@codImg, @tituloGal, @descricaoGal, @fotosGaleria);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codImg", MySqlDbType.Int32).Value = codImg;
            comm.Parameters.Add("@tituloGal", MySqlDbType.VarChar, 50).Value = txtTitulo.Text;
            comm.Parameters.Add("@descricaoGal", MySqlDbType.VarChar, 50).Value = txtDescricao.Text;
            comm.Parameters.Add("@fotosGaleria", MySqlDbType.VarBinary).Value = img;

            comm.Connection = Connection.abrirConexao();

            comm.ExecuteNonQuery();

            Connection.fecharConexao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public static Image ConvertToImage(System.Data.Linq.Binary iBinary)
        {
            
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {

                rImage = Image.FromStream(ms);
            }
            return rImage;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Equals("") || txtDescricao.Text.Equals("") || imgByteList.Count == 0)
            {
                MessageBox.Show("Preencha todos o campos!");
            }
            else
            {
                foreach (byte[] byteImg in imgByteList)
                {
                    cadastrarProjeto(byteImg);
                }
                MessageBox.Show("Inserido com sucesso!");
                pesquisarCodImg();
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
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImg = new OpenFileDialog();
            abrirImg.InitialDirectory = ("d:\\imagens\\");
            abrirImg.FileName = "Imagem";
            abrirImg.Title = "Procurar Imagem";
            abrirImg.Filter = ("Arquivos de imagem .jpg e .png|*.jpg; *png|*jpg|*.jpg|*jpeg|*.jpeg|*jfif|*.jfif|*png|*.png");
            abrirImg.Multiselect = false;
            
            if (abrirImg.ShowDialog() == DialogResult.OK) // converter a foto inserida em bytes[] e add o byte da foto na lista de bytes (imagens) img
            {
                byte[] foto = null;
                using (var stream = new FileStream(abrirImg.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        foto = reader.ReadBytes((int)stream.Length);
                    }
                }
                imgByteList.Add(foto);
                lstImagens.Items.Add("Imagem " + imgByteList.Count.ToString());
                lstImagens.SelectedIndex = imgByteList.Count - 1;
                try
                {
                    pcbPreview.Image = ConvertToImage(foto);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro! Imagem inválida ou corrompida.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    imgByteList.RemoveAt(imgByteList.Count - 1);
                    lstImagens.Items.RemoveAt(lstImagens.Items.Count - 1);
                }
            }
        }

        private void btnTeste_Click(object sender, EventArgs e) // ação de carregar lista quando pesquisar (já pronto pra quando implementar o select do mysql)
        {
            lstImagens.Items.Clear();
            for (int i = 0; i < imgByteList.Count; i++)
            {
                lstImagens.Items.Add("Imagem " + (i + 1).ToString());
            }
        }

        private void lstImagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstImagens.Items.Count > 0)
                    pcbPreview.Image = ConvertToImage(imgByteList[lstImagens.SelectedIndex]);
            }
            catch (Exception)
            {
                lstImagens.SelectedIndex = lstImagens.Items.Count - 1;
            }
            
        }

        private void frmGaleria_Load(object sender, EventArgs e) // carregar codigo dos ultimos registros inseridos e atualizar a var global codImg para prox inserts
        {
            pesquisarCodImg();
        }
    }
}
