using NDM_SoftwareV5.Formularios.F_Cliente;
using NDM_SoftwareV5.Formularios.Relatorios.Estoque;
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

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    public partial class MDI_estoque_index : Form
    {
        private int childFormNumber = 0;
        public static Estoquista estoquista = new Estoquista();
        public static bool acesso_adm = false;
        public MDI_estoque_index()
        {
            InitializeComponent();
        }

        private void MDI_estoque_index_Load(object sender, EventArgs e)
        {
            if (acesso_adm == true)
            {
                toolStripStatusLabel.Text = "Usuário conectado: Administrador";
            }
            else {
                var login = new frm_login();
                login.Close();

                toolStripStatusLabel.Text = "Usuário conectado: " + estoquista.Est_nome;
            }
           
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_posicao_estoque childForm = new frm_posicao_estoque();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void entrada_estoque_Click(object sender, EventArgs e)
        {
            frm_entrada_saida_produto childForm = new frm_entrada_saida_produto();
            frm_entrada_saida_produto.acao = "entrada";
            childForm.MdiParent = this;
            childForm.Size = new Size(846, 360);
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void saida_estoque_Click(object sender, EventArgs e)
        {
            frm_entrada_saida_produto childForm = new frm_entrada_saida_produto();
            frm_entrada_saida_produto.acao = "saida";
            childForm.MdiParent = this;
            childForm.Size = new Size(846, 360);
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void add_subcategoria_Click(object sender, EventArgs e)
        {
            frm_add_Subcategoria childForm = new frm_add_Subcategoria();

            childForm.MdiParent = this;

            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void menu_roteador_Click(object sender, EventArgs e)
        {
            frm_Roteador frm_roteador = new frm_Roteador();

            frm_roteador.MdiParent = this;

            //childForm.Text = "Window " + childFormNumber++;
            frm_roteador.Show();
        }

        private void MDI_estoque_index_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (acesso_adm == false)
            {
                var login = new frm_login();
                login.Show();
            }
        }

        private void menu_cad_fornecedor_Click(object sender, EventArgs e)
        {
            var add_fornecedor = new frm_forncedor();
            add_fornecedor.MdiParent = this;
            add_fornecedor.Show();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relatorio_estoque = new frm_reltatorio_estoque();
            frm_reltatorio_estoque.tipo_relatorio = "Controle_Geral";
            relatorio_estoque.ShowDialog();
        }

        private void somenteEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relatorio_estoque = new frm_reltatorio_estoque();
            frm_reltatorio_estoque.tipo_relatorio = "Controle_Entrada";
            relatorio_estoque.ShowDialog();
        }

        private void relatorio_estoque_saida_Click(object sender, EventArgs e)
        {
            var relatorio_estoque = new frm_reltatorio_estoque();
            frm_reltatorio_estoque.tipo_relatorio = "Controle_Saida";
            relatorio_estoque.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var relatorio_roteador = new frm_reltatorio_estoque();
            frm_reltatorio_estoque.tipo_relatorio = "Roteador_Geral";
            relatorio_roteador.ShowDialog();
        }
    }
}
