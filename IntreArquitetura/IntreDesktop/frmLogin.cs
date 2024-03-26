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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool autenticarUsuario(string usuario, string senha )
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select * from tbUsuarios where login = @usuario and senha = @senha;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 8).Value = usuario;
            comm.Parameters.Add("senha", MySqlDbType.VarChar, 8).Value = senha;

            comm.Connection = Connection.abrirConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            bool validar = DR.HasRows;

            Connection.fecharConexao();

            return validar;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string userName, userSenha;

            userName = txtUsuario.Text;
            userSenha = txtSenha.Text;

            if(autenticarUsuario(userName,userSenha))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }
    }
}
