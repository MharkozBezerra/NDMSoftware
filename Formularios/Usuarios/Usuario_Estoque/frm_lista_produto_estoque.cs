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
    public partial class frm_lista_produto_estoque : Form
    {
        public static Filial filial_static = new Filial();
        DataGrid_Estoque dg_config_estoque = new DataGrid_Estoque();
        public frm_lista_produto_estoque()
        {
            InitializeComponent();
        }

        private void frm_lista_produto_estoque_Load(object sender, EventArgs e)
        {
            cb_categoria.Text = "";
            cx_texto.Text = "";
            bt_procurar.Enabled = false;
            cb_categoria.Focus();
        }

        private void cx_texto_TextChanged(object sender, EventArgs e)
        {
            if (cb_categoria.Text != "" && cx_texto.TextLength > 0)
            {
                bt_procurar.Enabled = true;
            }
            else {
                bt_procurar.Enabled = false;
            }
        }

        private void bt_procurar_Click(object sender, EventArgs e)
        {
            var buscar = cb_categoria.Text;
            var texto = cx_texto.Text;
            mostra_estoque.DataSource = dg_config_estoque.mostra_Estoque(mostra_estoque, filial_static, null, buscar, texto);
        }

        private void mostra_estoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int id_estoque = Convert.ToInt32(mostra_estoque.SelectedCells[0].Value.ToString());
                if (id_estoque > 0) { frm_entrada_saida_produto.get_id_estoque = id_estoque; }
                Close();   
            }
            catch { frm_entrada_saida_produto.get_id_estoque = 0; }
        }
    }
}
