using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IntreDesktop
{
    class Connection
    {
        private static string userPass = "Server=localhost;Port=3306;Database=dbintre;Uid=admindb;Pwd=123456";
        private static MySqlConnection con = null;

        public static MySqlConnection abrirConexao()
        {
            try
            {
                con = new MySqlConnection(userPass);
                con.Open();
            }
            catch (MySqlException ex)
            {
                con = null;
                switch (ex.Number)
                {
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário/Senha do servidor inválido, por favor tente novamente.", 
                            "Mensagem do Sistema", 
                            System.Windows.Forms.MessageBoxButtons.OK, 
                            System.Windows.Forms.MessageBoxIcon.Error, 
                            System.Windows.Forms.MessageBoxDefaultButton.Button1);
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("Não foi possível conectar-se ao servidor.  Contate o administrador do sistema.\n" + "Erro: " + ex.Number.ToString(),
                            "Mensagem do Sistema",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error,
                            System.Windows.Forms.MessageBoxDefaultButton.Button1);
                        break;
                }
            }
            return con;
        }

        public static void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
