
using NDM_SoftwareV5.Formularios.Administrador;
using NDM_SoftwareV5.Formularios.F_Cliente;
using NDM_SoftwareV5.Formularios.Ordem_Servicos;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Recepcao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente
{
    public partial class frm_MDIParent_ADM : Form
    {
        private int childFormNumber = 0;

        public frm_MDIParent_ADM()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            frm_HelpDesk frm_help = new frm_HelpDesk();
            frm_HelpDesk.acesso_adm = true;
			frm_help.MdiParent = this;
			frm_help.Show(); 
			          
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_index_solicitacao frm_recepcao = new frm_index_solicitacao();
            frm_index_solicitacao.acesso_adm = true;
            frm_recepcao.MdiParent = this;
            frm_recepcao.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            

            frm_abertura_OS_Atendimento frm_os = new frm_abertura_OS_Atendimento();
            frm_abertura_OS_Atendimento.usuario.Usu_ID = 32;
            frm_os.MdiParent = this;
            frm_os.Show();

        }

        private void frm_MDIParent_ADM_Load(object sender, EventArgs e)
        {
            menuStrip.ForeColor = ColorTranslator.FromHtml("#010822");
            var login = new frm_login();
            login.Close();
        }

        private void frm_MDIParent_ADM_FormClosed(object sender, FormClosedEventArgs e)
        {
            var login = new frm_login();
            login.Show();
        }

        private void meu_provedor_alterar_Click(object sender, EventArgs e)
        {
            frm_empresa frm_filial = new frm_empresa();
            frm_empresa.acesso_gerente = true;
            frm_filial.MdiParent = this;
            frm_filial.Show();
        }

        private void menu_usuario_add_Click(object sender, EventArgs e)
        {
         
        }

        private void menu_usuario_root_Click(object sender, EventArgs e)
        {

           
        }

        private void menu_relatorio_Geral_Click(object sender, EventArgs e)
        {
          
        }

        private void menu_relatorio_HelpDesk_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void menu_subcategoria_Click(object sender, EventArgs e)
        {

        }

        private void menu_add_helpdesk_Click(object sender, EventArgs e)
        {


        }

        private void menu_estoque_Click(object sender, EventArgs e)
        {
            var frm_estoque = new MDI_estoque_index();
            MDI_estoque_index.acesso_adm = true;
          
            frm_estoque.ShowDialog();
        }

        private void menu_cadastrarCliente_Click(object sender, EventArgs e)
        {
            frm_pesquisa_cliente frm_cliente = new frm_pesquisa_cliente();
            frm_cliente.MdiParent = this;
            frm_cliente.Show();
        }

        private void menu_cadastrarEndereco_Click(object sender, EventArgs e)
        {
            frm_add_endereco frm_endereco = new frm_add_endereco();
            frm_endereco.MdiParent = this;
            frm_endereco.Show();
        }
    }
}
