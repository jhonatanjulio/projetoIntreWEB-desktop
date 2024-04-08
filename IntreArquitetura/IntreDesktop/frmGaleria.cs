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
        private List<byte[]> imgByteListTot = new List<byte[]>();
        private List<byte[]> imgByteListAdd = new List<byte[]>();
        private List<byte[]> imgByteListRemoved = new List<byte[]>();

        public frmGaleria()
        {
            InitializeComponent();
            desabBotoes();
            pesquisarCodImg(); // carregar codigo dos ultimos registros inseridos e atualizar a var global codImg para prox inserts
        }
        public frmGaleria(int cod, string tit, string desc, List<byte[]> bytesList)
        {
            InitializeComponent();
            habBotoes();
            txtTitulo.Text = tit;
            txtDescricao.Text = desc;
            codImg = cod;
            foreach (byte[] bytes in bytesList)
            {
                imgByteListTot.Add(bytes);
            }

            lstImagens.Items.Clear();
            for (int i = 0; i < imgByteListTot.Count; i++)
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

            imgByteListTot.Clear();
            imgByteListAdd.Clear();
            imgByteListRemoved.Clear();
            lstImagens.Items.Clear();
            pcbPreview.Image = null;

            pesquisarCodImg();
        }

        public void desabBotoes()
        {
            btnEnviar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            btnEnviar.Focus();
        }

        public void habBotoes()
        {
            btnEnviar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;

            btnAlterar.Focus();
        }

        // Pesquisar Codigo Img
        public void pesquisarCodImg()
        {
            try
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
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception) {
                MessageBox.Show("Ocorreu um erro ao carregar o último código da imagem! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        // Enviar Imagem
        public void cadastrarProjeto(byte[] img)
        {
            try
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
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception) {
                MessageBox.Show("Ocorreu um erro ao cadastrar o projeto! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void alterarProjeto()
        {
            try
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
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception) {
                MessageBox.Show("Ocorreu um erro ao alterar o projeto! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void inserirImagens(int codigoImg, byte[] img)
        {
            try
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
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception) {
                MessageBox.Show("Ocorreu um erro ao inserir a imagem! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        // deletar imagens
        public void deletarImagens(byte[] img)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "delete from tbGaleria where fotosGaleria = @foto;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@foto", MySqlDbType.Blob).Value = img;

                comm.Connection = Connection.abrirConexao();

                comm.ExecuteNonQuery();

                Connection.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a imagem! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        public void deletarProjeto()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "delete from tbGaleria where codImg = @codImg;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@codImg", MySqlDbType.Int32).Value = codImg;

                comm.Connection = Connection.abrirConexao();

                comm.ExecuteNonQuery();

                Connection.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception) {
                MessageBox.Show("Ocorreu um erro ao deletar o projeto! Contate o administrador do sistema.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabBotoes();
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
            if (txtTitulo.Text.Equals("") && txtDescricao.Text.Equals("") && imgByteListAdd.Count == 0)
            {
                MessageBox.Show("Erro! Preencha todos os campos e insira pelo menos uma imagem!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                foreach (byte[] byteImg in imgByteListAdd)
                {
                    cadastrarProjeto(byteImg);
                }
                MessageBox.Show("Inserido com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                pesquisarCodImg();
                limparCampos();
                desabBotoes();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
            {
                //Excluir
                deletarProjeto();
                MessageBox.Show("Excluído com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
                desabBotoes();
                
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
                try
                {
                    using (var stream = new FileStream(abrirImg.FileName, FileMode.Open, FileAccess.Read))
                    {
                        if (stream.Length > 16777216)
                            isBigger = true;
                        using (var reader = new BinaryReader(stream))
                        {
                            foto = reader.ReadBytes((int)stream.Length);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro! Não foi possível ler esta imagem.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                if (isBigger)
                {
                    MessageBox.Show("Erro! O tamanho da imagem deve ser no máximo de 16MB.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    imgByteListTot.Add(foto);
                    imgByteListAdd.Add(foto);
                    lstImagens.Items.Add("Imagem " + imgByteListTot.Count.ToString());
                    lstImagens.SelectedIndex = imgByteListTot.Count - 1;
                    try
                    {
                        pcbPreview.Image = ConvertToImage(foto);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro! Imagem inválida ou corrompida.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        imgByteListTot.Remove(foto);
                        imgByteListAdd.Remove(foto);
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
                    pcbPreview.Image = ConvertToImage(imgByteListTot[lstImagens.SelectedIndex]);
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
            
            if (!(txtTitulo.Text.Equals("") && txtDescricao.Text.Equals("") && imgByteListAdd.Count == 0))
            {
                DialogResult resp = MessageBox.Show("Deseja realmente alterar? (Ao confirmar, as alterações não poderão ser canceladas.)", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    alterarProjeto();
                    if (imgByteListAdd.Count > 0)
                    {
                        foreach (byte[] img in imgByteListAdd)
                        {
                            inserirImagens(codImg, img);
                        }
                    }
                    if (imgByteListRemoved.Count > 0)
                    {
                        foreach (byte[] img in imgByteListRemoved)
                        {
                            deletarImagens(img);
                        }
                    }
                    limparCampos();
                    desabBotoes();
                }
            }
            else
            {
                MessageBox.Show("Erro! Preencha todos os campos e insira pelo menos uma imagem!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDeletarImg_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente deletar essa imagem? (Ao confirmar, a imagem não poderá ser restituída.)", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
            {
                imgByteListRemoved.Add(imgByteListTot[lstImagens.SelectedIndex]);
                imgByteListAdd.Remove(imgByteListTot[lstImagens.SelectedIndex]);
                imgByteListTot.Remove(imgByteListTot[lstImagens.SelectedIndex]);
                lstImagens.Items.RemoveAt(lstImagens.SelectedIndex);

                lstImagens.Items.Clear();
                for (int i = 0; i < imgByteListTot.Count; i++)
                {
                    lstImagens.Items.Add("Imagem " + (i + 1).ToString());
                }

                if (lstImagens.Items.Count < 1)
                    pcbPreview.Image = null;

                lstImagens.SelectedIndex = lstImagens.Items.Count - 1;
            }
        }
    }
}
