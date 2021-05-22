using Modelo.Classes;
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

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    public partial class frm_posicao_estoque : Form
    {
        Filial               filial            = new Filial();
        Estoque              estoque           = new Estoque();
        Produto              produto           = new Produto();
        Subcategoria_Produto subcategoria      = new Subcategoria_Produto();
        Categoria_Produto    categoria         = new Categoria_Produto();
        DataGrid_Estoque     dg_config_estoque = new DataGrid_Estoque();
        ComboBox_Filial      cb_config_filial  = new ComboBox_Filial();

        public frm_posicao_estoque()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cx_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_gravar_entrada_Click(object sender, EventArgs e)
        {
            frm_entrada_saida_produto childForm = new frm_entrada_saida_produto();
            frm_entrada_saida_produto.acao = "entrada";
            frm_entrada_saida_produto.filial_statica = filial;
            childForm.Size = new Size(846, 360);
            //childForm.Text = "Window " + childFormNumber++;
            childForm.ShowDialog();
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, "", "");
        }

        private void bt_gravar_saida_Click(object sender, EventArgs e)
        {
            frm_entrada_saida_produto childForm = new frm_entrada_saida_produto();
            frm_entrada_saida_produto.filial_statica = filial;
            frm_entrada_saida_produto.acao = "saida";
            childForm.Size = new Size(846, 360);
            childForm.ShowDialog();
            //childForm.Text = "Window " + childFormNumber++;
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, "", "");

        }

        private void bt_alocar_Click(object sender, EventArgs e)
        {
            frm_alocar_produtos alocar = new frm_alocar_produtos();
            frm_alocar_produtos.filial = filial;
            alocar.ShowDialog();
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, "", "");
        }

        private void bt_novo_produto_Click(object sender, EventArgs e)
        {
            frm_add_produto childForm = new frm_add_produto();
            
            //childForm.Text = "Window " + childFormNumber++;
            childForm.ShowDialog();
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, "", "");
        }

        private void frm_posicao_estoque_Load(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            cb_config_filial.combox_Carregado_Filial(cb_filial_descricao, empresa);
        }

        private void cb_filial_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial.Fili_ID = ((Filial)cb_filial_descricao.SelectedItem).Fili_ID;
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, "", "");
        }

        private void bt_procurar_Click(object sender, EventArgs e)
        {
            var buscar = cb_buscar.Text;
            var texto = cx_texto.Text;
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, buscar, texto);
            limpa_caixas();
        }

        private void mostra_estoque_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limpa_caixas();
            var id_estoque = mostra_estoque.SelectedCells[0].Value.ToString();
            if (id_estoque != null) {

                cx_categoria.Text = mostra_estoque.SelectedCells[4].Value.ToString();
                cx_subcategoria.Text = mostra_estoque.SelectedCells[5].Value.ToString();
                cx_fornecedor.Text = mostra_estoque.SelectedCells[10].Value.ToString();
                cx_cod_externo.Text = mostra_estoque.SelectedCells[1].Value.ToString();
                cx_cod_interno.Text = mostra_estoque.SelectedCells[2].Value.ToString();
                cx_unidade.Text = mostra_estoque.SelectedCells[11].Value.ToString();
                try { cx_valor.Text = Convert.ToDouble(mostra_estoque.SelectedCells[8].Value).ToString("C"); }
                catch { cx_valor.Text = "R$ 0,00"; }
                cx_descricao_produto.Text = mostra_estoque.SelectedCells[3].Value.ToString();
                cx_localizacao.Text = mostra_estoque.SelectedCells[7].Value.ToString();
                cx_qtd.Text = mostra_estoque.SelectedCells[6].Value.ToString();
                try { lbl_data.Text = Convert.ToDateTime(mostra_estoque.SelectedCells[9].Value.ToString()).ToString("dd/MM/yyyy"); }
                catch { lbl_data.Text = "Error!"; }
                }
        }
        private void limpa_caixas() {

            cx_categoria.Text = "";
            cx_subcategoria.Text = "";
            cx_fornecedor.Text = "";
            cx_cod_externo.Text = "";
            cx_cod_interno.Text = "";
            cx_unidade.Text = "";
            cx_valor.Text = "";
            cx_descricao_produto.Text = "";
            cx_localizacao.Text = "";
            cx_qtd.Text = "";
            lbl_data.Text = "00/00/0000";


        }

        private void bt_categoria_Click(object sender, EventArgs e)
        {
            frm_add_Categoria categoria = new frm_add_Categoria();
            frm_add_Categoria.filial_statica = filial;
            frm_add_Categoria.tipo_de_acesso = 2;
            categoria.ShowDialog();
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, "", "");
        }

        private void bt_subcategoria_Click(object sender, EventArgs e)
        {
            frm_add_Subcategoria subcategoria = new frm_add_Subcategoria();
            frm_add_Subcategoria.filial_statica = filial;
            frm_add_Subcategoria.tipo_de_acesso = 2;
            subcategoria.ShowDialog();
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial, null, "", "");
        }
    }
}
