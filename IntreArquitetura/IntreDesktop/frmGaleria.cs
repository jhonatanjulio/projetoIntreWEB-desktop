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
        private int codImg = 1;
        private List<byte[]> imgByteList = new List<byte[]>();
        private List<byte[]> imgByteListRemoved = new List<byte[]>();

        public frmGaleria()
        {
            InitializeComponent();
            pesquisarCodImg(); // carregar codigo dos ultimos registros inseridos e atualizar a var global codImg para prox inserts
        }
        public frmGaleria(int cod, string tit, string desc, List<byte[]> bytesList)
        {
            InitializeComponent();
            txtTitulo.Text = tit;
            txtDescricao.Text = desc;
            codImg = cod;
            foreach (byte[] bytes in bytesList)
            {
                imgByteList.Add(bytes);
            }

            lstImagens.Items.Clear();
            for (int i = 0; i < imgByteList.Count; i++)
            {
                lstImagens.Items.Add("Imagem " + (i + 1).ToString());
            }
            lstImagens.SelectedIndex = 0;
        }

        public void limparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtTitulo.Focus();

            imgByteList.Clear();
            imgByteListRemoved.Clear();
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

            if (DR.Read())
            {
                codImg = Convert.ToInt32(DR.GetValue(0));
            }

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
            comm.Parameters.Add("@fotosGaleria", MySqlDbType.Blob).Value = img;

            comm.Connection = Connection.abrirConexao();

            comm.ExecuteNonQuery();

            Connection.fecharConexao();
        }

        public void alterarProjeto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbGaleria set tituloGal = @tituloGal, descricaoGal = @descricaoGal where codImg = @codImg ;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codImg", MySqlDbType.Int32).Value = codImg;
            comm.Parameters.Add("@tituloGal", MySqlDbType.VarChar, 50).Value = txtTitulo.Text;
            comm.Parameters.Add("@descricaoGal", MySqlDbType.VarChar, 50).Value = txtDescricao.Text;

            comm.Connection = Connection.abrirConexao();

            comm.ExecuteNonQuery();

            Connection.fecharConexao();
        }

        public void pesquisarImagens(int codigoImg)
        {
            MySqlCommand comm = new MySqlCommand();
            List<byte[]> listaImg = new List<byte[]>();
            comm.CommandText = "select fotosGaleria from tbGaleria where codImg = @codImg;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codImg", MySqlDbType.Int32).Value = codigoImg;

            comm.Connection = Connection.abrirConexao();
            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                if (DR.HasRows)
                {
                    listaImg.Add((byte[])DR.GetValue(0));
                    MessageBox.Show(codigoImg.ToString());
                }
            }

            Connection.fecharConexao();

            foreach (byte[] imgAdd in imgByteList)
            {
                if (!(listaImg.Contains(imgAdd)))
                {
                    inserirImagens(codigoImg, imgAdd);
                }
            }
        } // deu tudo errado aqui

        public void inserirImagens(int codigoImg, byte[] img)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbGaleria(codImg, tituloGal, descricaoGal, fotosGaleria) values(@codImg, @tituloGal, @descricaoGal, @fotosGaleria);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codImg", MySqlDbType.Int32).Value = codigoImg;
            comm.Parameters.Add("@tituloGal", MySqlDbType.VarChar, 50).Value = txtTitulo.Text;
            comm.Parameters.Add("@descricaoGal", MySqlDbType.VarChar, 50).Value = txtDescricao.Text;
            comm.Parameters.Add("@fotosGaleria", MySqlDbType.Blob).Value = img;

            comm.Connection = Connection.abrirConexao();

            comm.ExecuteNonQuery();

            Connection.fecharConexao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
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
                bool isBigger = false;
                using (var stream = new FileStream(abrirImg.FileName, FileMode.Open, FileAccess.Read))
                {
                    if (stream.Length > 16777216)
                        isBigger = true;
                    using (var reader = new BinaryReader(stream))
                    {
                        foto = reader.ReadBytes((int)stream.Length);
                    }
                }
                if (isBigger)
                {
                    MessageBox.Show("Erro! O tamanho da imagem deve ser no máximo de 16MB.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarGaleria abrir = new frmPesquisarGaleria();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarProjeto();
            pesquisarImagens(codImg);
        }

        private void btnDeletarImg_Click(object sender, EventArgs e)
        {
            imgByteListRemoved.Add(imgByteList[lstImagens.SelectedIndex]);
            imgByteList.RemoveAt(lstImagens.SelectedIndex);
            lstImagens.Items.RemoveAt(lstImagens.SelectedIndex);

            lstImagens.Items.Clear();
            for (int i = 0; i < imgByteList.Count; i++)
            {
                lstImagens.Items.Add("Imagem " + (i + 1).ToString());
            }

            if (lstImagens.Items.Count < 1)
                pcbPreview.Image = null;
        }
    }
}
