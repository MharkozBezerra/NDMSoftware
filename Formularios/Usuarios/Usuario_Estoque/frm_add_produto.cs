using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Classes;
using Controlador.Controle.ComboBox_Config;
using Controlador.Controle.DataGrid_Config.DataGrid_Estoque;
using Regras_N.Regra_N_Estoque;


namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    public partial class frm_add_produto : Form
    {
        ComboBox_Filial   cb_conf_filial = new ComboBox_Filial();
        ComboBox_Usuarios cb_conf_fornecedor = new ComboBox_Usuarios();
        ComboBox_Categorias_Subcategorias cb_config_cate_sub = new ComboBox_Categorias_Subcategorias();

        //
        Fornecedor fornecedor = new Fornecedor();
        Categoria_Produto categoria = new Categoria_Produto();
        Subcategoria_Produto subcategoria = new Subcategoria_Produto();
        DataGrid_Estoque dg_config_produto = new DataGrid_Estoque(); 
        Unidade_medida unidade = new Unidade_medida();
        Produto produto = null;
        Filial filial = new Filial();
        RN_Produtos regra_produto = new RN_Produtos();
        Estoquista estoquista = new Estoquista();

        public frm_add_produto()
        {
            InitializeComponent();
        }

        private void frm_add_produto_Load(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            cb_conf_filial.combox_Carregado_Filial(cb_filial_descricao, empresa);
            cx_valor.Text = "R$ 0,00";
        }



        private void cb_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Teste
            fornecedor.for_ID = ((Fornecedor)(cb_fornecedor.SelectedItem)).for_ID;
        }

        private void cb_filial_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial.Fili_ID = ((Filial)(cb_filial_descricao.SelectedItem)).Fili_ID;
            cb_conf_fornecedor.combox_Fornecedor(cb_fornecedor, filial);

            unidade.unid_ID = 0;
            categoria.Cate_ID = 0;
            subcategoria.Sub_ID = 0;

            cb_config_cate_sub.combox_Categoria_UN(cb_unidade_medidas, filial);
            cb_config_cate_sub.combox_Categoria_Produtos(cb_categoria, filial);
            cb_config_cate_sub.combox_Subcategoria_Produtos(cb_subcategoria, categoria);
            dg_mostra_produto.DataSource = dg_config_produto.mostra_Produto(dg_mostra_produto, filial, null, 0);
            lbl_total.Text = dg_mostra_produto.RowCount.ToString();
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            categoria.Cate_ID = ((Categoria_Produto)cb_categoria.SelectedItem).Cate_ID;
            cb_config_cate_sub.combox_Subcategoria_Produtos(cb_subcategoria, categoria);
        }

        private void cb_unidade_medidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            unidade.unid_ID = ((Unidade_medida)cb_unidade_medidas.SelectedItem).unid_ID;
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            produto = new Produto();
            string externo = cx_cod_externo.Text;
            string interno = cx_cod_interno.Text;
            int aluguavel = 0;
            if (chk_aluguel.Checked == true) { aluguavel = 1; }
            else { aluguavel = 0; }
            try
            {
                if (!String.IsNullOrEmpty(interno) && !String.IsNullOrEmpty(externo))
                {
                    produto.categoria           = categoria;
                    produto.subcategoria        = subcategoria;
                    produto.unidade             = unidade;
                    produto.fornecedor          = fornecedor;
                    produto.Prod_codigo_externo = cx_cod_externo.Text;
                    produto.Prod_codigo_interno = cx_cod_interno.Text;
                    produto.Prod_valor_compra   = Convert.ToDouble(cx_valor.Text.Replace("R$", ""));
                    produto.Fili_ID             = filial.Fili_ID;
                    produto.Prod_descricao      = cx_descricao_produto.Text;
                    produto.Prod_is_alugavel    = aluguavel;
                    var acao = regra_produto.cadastrar_produto(produto);
                    if (acao == 53)
                    {
                        cx_cod_externo.Text = "";
                        cx_cod_interno.Text = "";
                        cx_valor.Text = "0,00";
                        cx_descricao_produto.Text = "";
                        if (chk_aluguel.Checked == true) { chk_aluguel.Checked = false; }
                        MessageBox.Show("[53]-Cadastro realizado!");
                        dg_mostra_produto.DataSource = dg_config_produto.mostra_Produto(dg_mostra_produto, filial, null, 0);
                        lbl_total.Text = dg_mostra_produto.RowCount.ToString();
                        produto = null;

                    }
                    if (acao == 52) { MessageBox.Show("[52]- Há um Produto já cadastrado no banco de dados"); }
                    
                }
            }
            catch {
                MessageBox.Show("Erro: Algo não está informado corretamente, caso o problema continue comunique o desenvolvedor");
            }
        }

        private void cx_valor_Leave(object sender, EventArgs e)
        {
            double valor = 0;
            try {
                valor = Convert.ToDouble(cx_valor.Text.Replace(",", ""));
                cx_valor.Text = valor.ToString("C");
            }
            catch {
                MessageBox.Show("Valor informado não é válido aqui!");
                cx_valor.Focus();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            if (bt_salvar.Enabled == false)
            {
                produto = null;
                bt_remover.Enabled = false;
                bt_salvar.Enabled = true;
            }
            else
            {
                Close();
            }
        }

        private void dg_mostra_produto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            produto                  = new Produto();
            produto.Prod_ID          = Convert.ToInt32(dg_mostra_produto.SelectedCells[0].Value.ToString());
            produto.Prod_is_alocado  = Convert.ToInt32(dg_mostra_produto.SelectedCells[5].Value.ToString());
            produto.Prod_is_alugavel = Convert.ToInt32(dg_mostra_produto.SelectedCells[10].Value.ToString());


            if (produto.Prod_ID > 0) {
                bt_remover.Enabled = true;
                bt_salvar.Enabled = false;

                if (produto.Prod_is_alugavel > 0) { lbl_aluguel.Text = "Item Alugavel [ Sim ]"; }
                else { lbl_aluguel.Text = "Item Alugavel [ Não ]"; }
                
            }
            

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (produto.Prod_ID > 0) {

                DialogResult per = MessageBox.Show("Remover esse item?","Atenção",MessageBoxButtons.YesNo);
                if (per == DialogResult.Yes)
                {

                    var acao =regra_produto.deletar_produto(produto);
                    bt_remover.Enabled = false;
                    bt_salvar.Enabled = true;
                    dg_mostra_produto.DataSource = dg_config_produto.mostra_Produto(dg_mostra_produto, filial, null, 0);
                    lbl_total.Text = dg_mostra_produto.RowCount.ToString();
                    if (acao == 58)
                    {
                        MessageBox.Show("[58]-Produto Removido");
                    }
                    if (acao == 57) {
                        MessageBox.Show("[57]-Equipamento não pode ser removido.");
                    }
                }
                else {
                    bt_remover.Enabled = false;
                    bt_salvar.Enabled = true;
                    produto = null;
                }
            }
        }

        private void cb_subcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            subcategoria.Sub_ID = ((Subcategoria_Produto)cb_subcategoria.SelectedItem).Sub_ID;
        }

        private void chk_aluguel_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_aluguel.Checked == true)
            {
                chk_aluguel.ForeColor = Color.Red;
            }
            else { chk_aluguel.ForeColor = Color.Black; }
        }
    }
}
