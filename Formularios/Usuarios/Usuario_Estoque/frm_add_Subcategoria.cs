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
using Controlador.Controle.DataGrid_Config.DataGrid_Atendimento;
using Controlador.Controle.DataGrid_Config.DataGrid_Atendimento_OS;
using Modelo.Classes;
using Regras_N.Regra_N_Estoque;
using Regras_N.Regra_N_Usuario;


namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    public partial class frm_add_Subcategoria : Form
    {

        /*
         * SERÁ RESPONSÁVEL POR TODA ADIÇÃO/ ATUALIZAÇÃO DAS SUBCATEGORIAS DO SOFTWARE
         * DEVE SEGUIR ESSE MODELO PARA APRESENTAÇÃO DO GRID AO USUÁRIO:
         * 0 = SUBCATEGORIA ATENDIMENTO.
         * 1 = SUBCATEGORIA ATENDIMENTO OS.
         * 2 = SUBCATEGORIA PRODUTO.
         * CATEGORIA DEVE SEGUIR A MESMA LÓGICA.
         * MARCOS BEZERRA 11/06/2020
         * 
         */
        public static int tipo_de_acesso = 0;
        public static Filial filial_statica = new Filial();
        //------[Tipos de categorias]--------------------//
        Categoria_Atendimento categoria_atendimento = null;
        Categoria_Atendimento_OS categoria_atendimento_os = null;
        Categoria_Produto categoria_produto = null;
        //------[Tipos de subcategorias]--------------------//
        Subcategoria_Atendimento subcategoria_atendimento = null;
        Subcategoria_Atendimento_OS subcategoria_atendimento_os = null;
        Subcategoria_Produto subcategoria_produto = null;
        //------[Tipos de DataGrid]--------------------//
        DataGrid_Atendimento dg_config_atendimento = null;
        DataGrid_Atendimento_OS dg_config_atedimento_os = null;
        DataGrid_Estoque dg_config_estoque = null;
        //------[Tipos de ComboBox]--------------------//
        ComboBox_Categorias_Subcategorias cb_config_categoria_subcategoria = new ComboBox_Categorias_Subcategorias();
        //------[Tipos de DataGrid]--------------------//
        RN_Produtos regra_produto = null;
        RN_Atendimento regra_atendimento = null;
        RN_Atendimento_OS regra_atendimento_os = null;

        public frm_add_Subcategoria()
        {
            InitializeComponent();
        }
        private void frm_ADD_Subcategoria_Load(object sender, EventArgs e)
        {
            incio_form(tipo_de_acesso);
        }
        public void incio_form(int tipo)
        {
            lbl_base_descricao.Text = filial_statica.Fili_descricao;
            switch (tipo)
            {

                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    cb_config_categoria_subcategoria.combox_Categoria_Atendimento(cb_categoria, filial_statica);
                    cb_config_categoria_subcategoria.combox_Categoria_Atendimento(cb_categoria_UPDATE, filial_statica);
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    cb_config_categoria_subcategoria.combox_Categoria_OS(cb_categoria, filial_statica);
                    cb_config_categoria_subcategoria.combox_Categoria_OS(cb_categoria_UPDATE, filial_statica);
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.
                    cb_config_categoria_subcategoria.combox_Categoria_Produtos(cb_categoria, filial_statica);
                    cb_config_categoria_subcategoria.combox_Categoria_Produtos(cb_categoria_UPDATE, filial_statica);
                    break;
                default:
                    MessageBox.Show("tipo de acesso não informado, contate o desenvolvedor", "Error!!");
                    Close();
                    break;

            }

        }
        private void carrega_grids_categoria(int tipo)
        {
            dg_mostrar_categoria.DataSource = null;
            dg_mostra_Up.DataSource = null;
            int cate_id = 0;
            switch (tipo)
            {
                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    cate_id = categoria_atendimento.Cate_ID;
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    cate_id = categoria_atendimento_os.Cate_ID;
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.
                    dg_config_estoque = new DataGrid_Estoque();
                    cate_id = categoria_produto.Cate_ID;
                    dg_mostrar_categoria.DataSource = dg_config_estoque.mostra_Categoria_Subcategoria_Produto(dg_mostrar_categoria, filial_statica, cate_id, "", "", 1);
                    //dg_mostra_Up.DataSource = dg_config_estoque.mostra_Categoria_Subcategoria_Produto(dg_mostra_Up, filial_statica, 0, "", "", 0);
                    break;
            }
        }
        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipo_de_acesso)
            {

                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    categoria_atendimento = new Categoria_Atendimento();
                    categoria_atendimento.Cate_ID = ((Categoria_Atendimento)cb_categoria.SelectedItem).Cate_ID;
                    carrega_grids_categoria(tipo_de_acesso);
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    categoria_atendimento_os = new Categoria_Atendimento_OS();
                    categoria_atendimento_os.Cate_ID = ((Categoria_Atendimento_OS)cb_categoria.SelectedItem).Cate_ID;
                    carrega_grids_categoria(tipo_de_acesso);
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.
                    categoria_produto = new Categoria_Produto();
                    categoria_produto.Cate_ID = ((Categoria_Produto)cb_categoria.SelectedItem).Cate_ID;
                    carrega_grids_categoria(tipo_de_acesso);
                    break;
                default:
                    MessageBox.Show("tipo de acesso não informado, contate o desenvolvedor", "Error!!");
                    Close();
                    break;

            }
        }


        private void cx_descricao_ADD_TextChanged(object sender, EventArgs e)
        {
        }

        private void bt_salvar_ADD_Click(object sender, EventArgs e)
        {
           

            }

        private void bt_cancelar_ADD_Click(object sender, EventArgs e)
        {
            cx_descricao_ADD.Text = "";
        }

     

        private void cb_categoria_UPDATE_Leave(object sender, EventArgs e)
        {
            
        }

        private void dg_mostra_Up_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void cx_desc_nova_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dg_mostrar_categoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cx_desc_nova.Text = "";
            cx_desc_antiga.Text = "";
            
            cx_desc_nova.ReadOnly = true;
        }

       
    }
}
