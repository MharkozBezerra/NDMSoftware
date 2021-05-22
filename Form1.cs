using NDM_SoftwareV5.Formularios.Config_Sistemas;
using NDM_SoftwareV5.Formularios.F_Cliente;
using NDM_SoftwareV5.Formularios.Ordem_Servicos;
using NDM_SoftwareV5.Formularios.Usuarios;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente;
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

namespace NDM_SoftwareV5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_configuracoes_Click(object sender, EventArgs e)
        {
            var config = new frm_configuracao_sistema();
            config.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = new frm_login();
            frm_login.acessando_root = true;
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var helpdesk = new frm_HelpDesk();
            helpdesk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var add_atendimento = new frm_add_Atendimento();
            add_atendimento.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var inf_atend_solicitado = new frm_inf_atendimento_solicitado();
            inf_atend_solicitado.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pesquisa_cliente = new frm_pesquisa_cliente();
            pesquisa_cliente.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frm_os = new frm_abertura_OS_Atendimento();
            frm_os.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var frm_recepcao = new frm_index_solicitacao();
            frm_recepcao.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var frm_estoque = new MDI_estoque_index();
            frm_estoque.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var fmr_gerente = new frm_MDIParent_ADM();
            fmr_gerente.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var fmr_endereco = new frm_add_endereco();
            fmr_endereco.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var googleMaps = new frm_mostra_GoogleMaps();
            googleMaps.Show();
        }
    }
}
