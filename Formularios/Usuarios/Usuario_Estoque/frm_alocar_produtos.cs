using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.Controle.ComboBox_Config;
using Controlador.Controle.DataGrid_Config.DataGrid_Estoque;
using Regras_N.Regra_N_Estoque;
using Modelo.Classes;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    public partial class frm_alocar_produtos : Form
    {

        public static Filial filial = new Filial();
         Estoque estoque = null;
         Produto produto = new Produto();
         Subcategoria_Produto subcategoria = new Subcategoria_Produto();
         Categoria_Produto categoria = new Categoria_Produto();
         DataGrid_Estoque dg_config_estoque = new DataGrid_Estoque();
       
        RN_Produtos regras_produto = new RN_Produtos();
        RN_Estoque regra_estoque = new RN_Estoque();

        public frm_alocar_produtos()
        {
            InitializeComponent();
        }

        private void frm_alocar_produtos_Load(object sender, EventArgs e)
        {
            mostra_produtos.DataSource = dg_config_estoque.mostra_Produto(mostra_produtos, filial, null, 0);
        }

        private void limpa_caixas()
        {

            cx_categoria.Text = "";
            cx_subcategoria.Text = "";
            cx_fornecedor.Text = "";
            cx_cod_externo.Text = "";
            cx_cod_interno.Text = "";
            cx_unidade.Text = "";
            cx_valor.Text = "";
            cx_descricao_produto.Text = "";
            cx_localizacao.Text = "";
            cx_entrada.Text = "0";
            cx_qtd.Text = "";
            lbl_data.Text = "00/00/0000";


        }

        private void mostra_produtos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limpa_caixas();
            try
            {
                produto.Prod_ID = Convert.ToInt32(mostra_produtos.SelectedCells[0].Value.ToString());
                produto.Fili_ID = filial.Fili_ID;
                if (produto.Prod_ID > 0) {

                    produto = regras_produto.recuperar_produto(produto);

                    cx_categoria.Text = produto.categoria.Cate_descricao;
                    cx_subcategoria.Text = produto.subcategoria.Sub_descricao;
                    cx_fornecedor.Text = produto.fornecedor.for_nome;
                    cx_cod_externo.Text = produto.Prod_codigo_externo;
                    cx_cod_interno.Text = produto.Prod_codigo_interno;
                    cx_unidade.Text = produto.unidade.descricao;
                    cx_valor.Text = produto.Prod_valor_compra.ToString("C");
                    cx_descricao_produto.Text = produto.Prod_descricao;
                    cx_entrada.Focus();
                    bt_alocar.Enabled = true;

                }
                    }
            catch { limpa_caixas(); }
           
        }

        private void bt_alocar_Click(object sender, EventArgs e)
        {
            string qtd_entrada = cx_entrada.Text;
            string localizacao = cx_localizacao.Text;

            if (!String.IsNullOrEmpty(qtd_entrada) && !String.IsNullOrEmpty(localizacao))
            {

                DialogResult pergunta = MessageBox.Show("Confirma que ao item :" + produto.Prod_codigo_interno + "\r\n Está sendo alocado em:" + localizacao + "?", "Atenção!!!", MessageBoxButtons.YesNo);
                if (pergunta == DialogResult.Yes)
                {
                    estoque = new Estoque();
                    estoque.produto = produto;
                    double qtd = 0;
                    try { qtd = Convert.ToDouble(qtd_entrada); }
                    catch { qtd = 0; }
                    estoque.Qtd_atual = qtd;
                    estoque.Est_localizacao = localizacao;
                    estoque.Fili_ID = filial.Fili_ID;
                    estoque.Est_movimentada_data = DateTime.Now.ToString("yyyy-MM-dd");
                    var acao = regra_estoque.alocar_produto(estoque);
                    if (acao == 53)
                    {
                        MessageBox.Show("[53]-Produto cadastrado com sucesso.");
                        limpa_caixas();
                        bt_alocar.Enabled = false;
                        mostra_produtos.DataSource = dg_config_estoque.mostra_Produto(mostra_produtos, filial, null, 0);
                    }
                    if (acao == 54)
                    {
                        MessageBox.Show("[54]-Erro: Contate o desenvolvedor.");
                        limpa_caixas();
                        bt_alocar.Enabled = false;
                    }
                }
            }
            else {

                MessageBox.Show("Campos entrada e localização devem ser preenchidos");
                cx_qtd.Focus();
            }

        }

        private void cx_entrada_Leave(object sender, EventArgs e)
        {
            double qtd = 0;
            try
            {
                qtd = Convert.ToDouble(cx_entrada.Text.Replace(",", "."));
                cx_entrada.Text = qtd.ToString();
                cx_qtd.Text = cx_entrada.Text; 
            }
            catch {
                MessageBox.Show("Informação inserida é inválida");
                cx_entrada.Focus();
            }
        }
    }
}
