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
    public partial class frm_add_Categoria : Form
    {
        /*
         * SERÁ RESPONSÁVEL POR TODA ADIÇÃO/ ATUALIZAÇÃO DAS CATEGORIAS DO SOFTWARE
         * DEVE SEGUIR ESSE MODELO PARA APRESENTAÇÃO DO GRID AO USUÁRIO:
         * 0 = CATEGORIA ATENDIMENTO.
         * 1 = CATEGORIA ATENDIMENTO OS.
         * 2 = CATEGORIA PRODUTO.
         * SUBCATEGORIA DEVE SEGUIR A MESMA LÓGICA.
         * MARCOS BEZERRA 11/06/2020
         * 
         */

        public static int tipo_de_acesso = 0;
        public static Filial filial_statica = new Filial();

        //------[Tipos de categorias]--------------------//
        Categoria_Atendimento categoria_atendimento = null;
        Categoria_Atendimento_OS categoria_atendimento_os = null;
        Categoria_Produto categoria_produto = null;
        //------[Tipos de DataGrid]--------------------//
        DataGrid_Atendimento dg_config_atendimento = null;
        DataGrid_Atendimento_OS dg_config_atedimento_os = null;
        DataGrid_Estoque dg_config_estoque = null;
        //------[Tipos de Categoria]--------------------//
        //------[Tipos de DataGrid]--------------------//
        RN_Produtos regra_produto = null;
        RN_Atendimento regra_atendimento = null;
        RN_Atendimento_OS regra_atendimento_os = null;
        

        public frm_add_Categoria()
        {
            InitializeComponent();
        }

        private void frm_Add_Categoria_Load(object sender, EventArgs e)
        {

            incio_form(tipo_de_acesso);

        }

        public void incio_form(int tipo) {
            lbl_base_descricao.Text = filial_statica.Fili_descricao;
            switch (tipo) {

                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    carrega_grids_categoria(tipo);
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    carrega_grids_categoria(tipo);
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.
                    carrega_grids_categoria(tipo);
                    break;
                default:
                    MessageBox.Show("tipo de acesso não informado, contate o desenvolvedor","Error!!");
                    Close();
                    break;
                    
            }

        }
        private void carrega_grids_categoria(int tipo) {
            dg_mostrar_categoria.DataSource = null;
            dg_mostra_Up.DataSource = null;
            switch (tipo)
            {
                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.
                    dg_config_estoque = new DataGrid_Estoque();
                    
                    dg_mostrar_categoria.DataSource = dg_config_estoque.mostra_Categoria_Subcategoria_Produto(dg_mostrar_categoria, filial_statica, 0, "", "", 0);
                    //dg_mostra_Up.DataSource = dg_config_estoque.mostra_Categoria_Subcategoria_Produto(dg_mostra_Up, filial_statica, 0, "", "", 0);
                    break;
            }
        }

        private void dg_mostra_Up_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = 0;
            try
            {
                switch (tipo_de_acesso)
                {
                    case 0:
                        // 0 = CATEGORIA ATENDIMENTO.
                        break;
                    case 1:
                        //1 = CATEGORIA ATENDIMENTO OS.
                        break;
                    case 2:
                        //2 = CATEGORIA PRODUTO.
                        id = Convert.ToInt32(dg_mostra_Up.SelectedCells[0].Value.ToString());
                        categoria_produto = new Categoria_Produto();
                        categoria_produto.Cate_ID = id;
                        categoria_produto.Cate_descricao = dg_mostra_Up.SelectedCells[1].Value.ToString();
                        categoria_produto.Fili_ID = Convert.ToInt32(dg_mostra_Up.SelectedCells[2].Value.ToString());
                        categoria_produto.Cate_isAtivo = Convert.ToInt32(dg_mostra_Up.SelectedCells[3].Value.ToString());
                        if (categoria_produto.Cate_isAtivo == 0)
                        {
                            chk_habilitar.Checked = false;
                        }
                        else if (categoria_produto.Cate_isAtivo == 1) {
                            chk_habilitar.Checked = true;
                            chk_habilitar.ForeColor = Color.Red;
                        }
                        cx_desc_antiga.Text = categoria_produto.Cate_descricao;
                        cx_desc_nova.Text = cx_desc_antiga.Text;
                        cx_desc_nova.ReadOnly = false;
                        cx_desc_nova.Focus();
                        break;

                }
            }
            catch { }           
        }

        private void bt_cancelar_ADD_Click(object sender, EventArgs e)
        {
            cx_desc_antiga.Text = "";
            cx_desc_nova.Text = "";
            bt_editar.Enabled = false;
            switch (tipo_de_acesso)
            {
                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    categoria_atendimento = null;
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    categoria_atendimento_os = null;
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.
                    categoria_produto = null;
                    //dg_mostra_Up.DataSource = dg_config_estoque.mostra_Categoria_Subcategoria_Produto(dg_mostra_Up, filial_statica, 0, "", "", 0);
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void bt_salvar_ADD_Click(object sender, EventArgs e)
        {
            int acao = 0;
            switch (tipo_de_acesso)
            {
                case 0: break;
                case 1: break;
                case 2:
                    categoria_produto = new Categoria_Produto();
                    categoria_produto.Fili_ID = filial_statica.Fili_ID;
                    categoria_produto.Cate_descricao = cx_descricao_ADD.Text;
                    acao = regra_produto.cadastrar_categoria_produto(categoria_produto);
                    if (acao == 17)
                    {
                        MessageBox.Show("[17]-> Vá em editar e habilite essa categoria para começar usa-la!");
                        cx_descricao_ADD.Text = "";
                        carrega_grids_categoria(tipo_de_acesso);
                        categoria_produto = null;
                    }
                    else if (acao == 20)
                    {
                        MessageBox.Show("Error[20]-> Categoria de Produta já está cadastrada no banco de dados !", "Atenção!!");
                    }
                    else if (acao == 18) {
                        MessageBox.Show("Erro[18]-> Contate o desenvolvedor informando erro categoria nº 18!","Erro!!");
                    }
                    break;
                default:
                    break;
            }
           

        }

        private void cx_descricao_ADD_TextChanged(object sender, EventArgs e)
        {
            string texto = cx_descricao_ADD.Text;
            if (!String.IsNullOrEmpty(texto) || !String.IsNullOrWhiteSpace(texto))
            {
                if (cx_descricao_ADD.TextLength > 3)
                {
                    bt_salvar_ADD.Enabled = true;
                }
                else { bt_salvar_ADD.Enabled = false; }
            }
            else {

                bt_salvar_ADD.Enabled = false;
            }
        }

        private void chk_habilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_habilitar.Checked == true) { chk_habilitar.ForeColor = Color.Red; }
            else { chk_habilitar.ForeColor = Color.Black; }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            int acao = 0;
            switch (tipo_de_acesso)
            {
                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.

                    categoria_produto.Cate_descricao = cx_desc_nova.Text;                   
                    categoria_produto.Cate_isAtivo = Convert.ToInt32(dg_mostra_Up.SelectedCells[3].Value.ToString());
                    if (chk_habilitar.Checked == false)
                    {
                        categoria_produto.Cate_isAtivo = 0;
                    }
                    else { categoria_produto.Cate_isAtivo = 1; }
                    acao = regra_produto.atualizar_categoria_produto(categoria_produto);
                    if (acao == 21)
                    {

                        carrega_grids_categoria(tipo_de_acesso);
                        cx_desc_antiga.Text = "";
                        cx_desc_nova.Text = "";
                        cx_desc_nova.ReadOnly = true;
                        bt_editar.Enabled = false;
                        chk_habilitar.Checked = false;
                        categoria_produto = null;
                    }
                    else if (acao == 22) {
                        MessageBox.Show("Erro[22]-> Contate o desenvolvedor informando erro categoria nº 22!", "Erro!!");
                    }
                    break;

            }
        }

        private void bt_bucar_Click(object sender, EventArgs e)
        {
            string procura = cx_pesquisar.Text;
            switch (tipo_de_acesso)
            {
                case 0:
                    // 0 = CATEGORIA ATENDIMENTO.
                    break;
                case 1:
                    //1 = CATEGORIA ATENDIMENTO OS.
                    break;
                case 2:
                    //2 = CATEGORIA PRODUTO.
                    dg_mostra_Up.DataSource = dg_config_estoque.mostra_Categoria_Subcategoria_Produto(dg_mostra_Up, filial_statica, 0, "", procura, 0);

                    break;

            }
        }

        private void cx_desc_nova_TextChanged(object sender, EventArgs e)
        {
            if (cx_desc_nova.TextLength > 3)
            {
                bt_editar.Enabled = true;

            }
            else { bt_editar.Enabled = false; }
        }
    }
}
