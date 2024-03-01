using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntreDesktop
{
    class Utilities
    {
        public static void limparCampos(Control listaItens)
        {
            // Itera os controles da janela passada no parâmetro,
            // caso o item sendo iterado for do tipo "TextBox", sua propriedade "text" é limpa.
            foreach (Control item in listaItens.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = "";
                }
            }
        }

        // Função para habilitar e desabilitar os botões
        public static void habilitarDesabBotao(Control listaItens, string botao)
        {
            foreach (Control item in listaItens.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    switch (botao)
                    {
                        case "Inicio": //padrão
                            switch (item.Name)
                            {
                                case "btnNovo":
                                    item.Enabled = true;
                                    item.Focus();
                                    break;
                                case "btnCadastrar":
                                case "btnConcluir":
                                    item.Enabled = false;
                                    break;
                                case "btnAlterar":
                                    item.Enabled = false;
                                    break;
                                case "btnArquivar":
                                case "btnDesativar":
                                    item.Enabled = false;
                                    break;
                                case "btnPesquisar":
                                    item.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Novo":
                            switch (item.Name)
                            {
                                case "btnNovo":
                                    item.Enabled = false;
                                    break;
                                case "btnCadastrar":
                                case "btnConcluir":
                                    item.Enabled = true;
                                    item.Focus();
                                    break;
                                case "btnAlterar":
                                    item.Enabled = false;
                                    break;
                                case "btnArquivar":
                                case "btnDesativar":
                                    item.Enabled = false;
                                    break;
                                case "btnPesquisar":
                                    item.Enabled = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Cadastrar":
                        case "Concluir":
                            switch (item.Name)
                            {
                                case "btnNovo":
                                    item.Enabled = true;
                                    item.Focus();
                                    break;
                                case "btnCadastrar":
                                case "btnConcluir":
                                    item.Enabled = false;
                                    break;
                                case "btnAlterar":
                                    item.Enabled = false;
                                    break;
                                case "btnArquivar":
                                case "btnDesativar":
                                    item.Enabled = false;
                                    break;
                                case "btnPesquisar":
                                    item.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Alterar":
                            switch (item.Name)
                            {
                                case "btnNovo":
                                    item.Enabled = true;
                                    item.Focus();
                                    break;
                                case "btnCadastrar":
                                case "btnConcluir":
                                    item.Enabled = false;
                                    break;
                                case "btnAlterar":
                                    item.Enabled = false;
                                    break;
                                case "btnArquivar":
                                case "btnDesativar":
                                    item.Enabled = false;
                                    break;
                                case "btnPesquisar":
                                    item.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Arquivar":
                        case "Desativar":
                            switch (item.Name)
                            {
                                case "btnNovo":
                                    item.Enabled = true;
                                    item.Focus();
                                    break;
                                case "btnCadastrar":
                                case "btnConcluir":
                                    item.Enabled = false;
                                    break;
                                case "btnAlterar":
                                    item.Enabled = false;
                                    break;
                                case "btnArquivar":
                                case "btnDesativar":
                                    item.Enabled = false;
                                    break;
                                case "btnPesquisar":
                                    item.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Pesquisar":
                            switch (item.Name)
                            {
                                case "btnNovo":
                                    item.Enabled = false;
                                    break;
                                case "btnCadastrar":
                                case "btnConcluir":
                                    item.Enabled = false;
                                    break;
                                case "btnAlterar":
                                    item.Enabled = true;
                                   // item.Focus();
                                    break;
                                case "btnArquivar":
                                case "btnDesativar":
                                    item.Enabled = true;
                                    break;
                                case "btnPesquisar":
                                    item.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Limpar":
                            switch (item.Name)
                            {
                                case "btnNovo":
                                    item.Enabled = true;
                                    item.Focus();
                                    break;
                                case "btnCadastrar":
                                case "btnConcluir":
                                    item.Enabled = false;
                                    break;
                                case "btnAlterar":
                                    item.Enabled = false;
                                    break;
                                case "btnArquivar":
                                case "btnDesativar":
                                    item.Enabled = false;
                                    break;
                                case "btnPesquisar":
                                    item.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
