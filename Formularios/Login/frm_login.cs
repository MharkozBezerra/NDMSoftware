using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regras_N.Regra_N_Usuario;
using Modelo.Classes;
using NDM_SoftwareV5.Formularios.Config_Sistemas;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Recepcao;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque;

namespace NDM_SoftwareV5.Formularios.Usuarios
{
    public partial class frm_login : Form
    {
        Usuario user = null;
        RN_Usuario regra_user = new RN_Usuario();
        public static bool acessando_root = false;
        string login_root = Properties.Settings.Default.login_app;
        string senha_root = Properties.Settings.Default.senha_app;
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            string login = cx_login.Text;
            string senha = cx_senha.Text;
            
            //-> Define login e senha para o usuário.

            if (login != String.Empty && senha != String.Empty)
            {
                if (login != login_root && senha != senha_root)
                {
                    user.Chave_cod_acesso = 0;
                    user.Usu_login = login;
                    user.Usu_senha = senha;
                    user = regra_user.login(user);
                    chave(user);
                }
                else {
                    img_login.Image = Properties.Resources.Raposa;
                    var config = new frm_configuracao_sistema();
                    config.ShowDialog();
                    cx_login.Text = "";
                    cx_senha.Text = "";
                    img_login.Image = Properties.Resources.usuario_Comun;
                    cx_login.Focus();
                }
            }
            else {
                MessageBox.Show("Campo: login ou senha está vazio!");

            }

            user = null;

        }
        private void chave(Usuario acesso_user) {
            switch (acesso_user.Chave_cod_acesso) {
                case 0: MessageBox.Show("Usuário bloqueado / Usuário invalido / Senha incorreta"); break;
                case 1:
                    var form_gerente = new frm_MDIParent_ADM();
                    form_gerente.Show();
                    this.Hide();
                    break;
                case 2:    
                case 3:
                    var recepcao_forme = new frm_index_solicitacao();
                    RecepcaoVendedor recepcao = new RecepcaoVendedor();
                    recepcao.Usu_ID = acesso_user.Usu_ID;
                    recepcao = regra_user.login_recepcao(recepcao);

                    frm_index_solicitacao.recepcao_statica = recepcao;
                    frm_index_solicitacao.recepcao_sexo = acesso_user.Sexo;
                    recepcao_forme.Show();
                    this.Hide();

                    break;
                case 4:
                    var helpdesk_forme = new frm_HelpDesk();
                    var helpdesk = new HelpDesk();
                    helpdesk.Usu_ID = acesso_user.Usu_ID;
                    helpdesk = regra_user.login_help(helpdesk);

                    frm_HelpDesk.help_atendimento = helpdesk;
                    frm_HelpDesk.sexo_usuario = acesso_user.Sexo;
                    helpdesk_forme.Show();
                    this.Hide();
                    ; break;
                case 5: MessageBox.Show("Usuário Técnico-Campo, acesso não permitido aqui!"); break;
                case 7:
                    var estoque_forme = new NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque.MDI_estoque_index();
                    
                    Estoquista estoquista = new Estoquista();
                    estoquista.Usu_ID = acesso_user.Usu_ID;
                    estoquista = regra_user.login_estoquista(estoquista);

                    MDI_estoque_index.estoquista = estoquista;
                    estoque_forme.Show();
                    this.Hide();
                     break;
                default: MessageBox.Show("Usuário bloqueado / Usuário invalido / Senha incorreta"); break;
            }

        }

        private void cx_login_TextChanged(object sender, EventArgs e)
        {
            if (cx_login.TextLength >= 3 && cx_senha.TextLength >= 3)
            {
                bt_login.Enabled = true;
               
            }
            else {
                bt_login.Enabled = false;
            }
           
           
        }

        private void cx_senha_TextChanged(object sender, EventArgs e)
        {
            if (cx_login.TextLength >= 3 && cx_senha.TextLength >= 3)
            {
                bt_login.Enabled = true;
               
            }
            else
            {
                bt_login.Enabled = false;
            }
           
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            cx_login.Text = "";
            cx_senha.Text = "";
            cx_login.Focus();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (acessando_root == false) {
                Application.Exit();
            }
        }
    }
}
