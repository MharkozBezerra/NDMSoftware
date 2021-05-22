using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.Controle;
using Modelo.Classes;
using NDM_SoftwareV5.Formularios.Administrador;
using System.Configuration;

namespace NDM_SoftwareV5.Formularios.Config_Sistemas
{
    public partial class frm_configuracao_sistema : Form
    {
        public static Empresa empresa = new Empresa();
        public frm_configuracao_sistema()
        {
            InitializeComponent();
        }
        void salvar_Dados_DB()
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                //-- Responsável por salvar os dados na setting do software.
                settings["IP_Server"].Value   = cx_ip.Text;
                settings["PORT_Server"].Value = cx_porta.Text;
                settings["DB_Server"].Value   = cx_db.Text;
                settings["LOG_Server"].Value  = cx_user.Text;
                settings["PWD_Server"].Value  = cx_senha.Text;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch { MessageBox.Show("Ocorreu um erro durante o salvamento."); }
        }
        void salvar_Dados_Update()
        {
            var severHost          = cx_SeverHost.Text;
            var linkServer         = cx_LinkServer.Text;
            var arquivoNomeCliente = cx_ArquivoNomeCliente.Text;
            var arquivoNomeServer  = cx_ArquivoNomeServer.Text;
            //config_update.add_Config(arquivoNomeServer, severHost, arquivoNomeCliente, linkServer);

        }
        void carregar_Dados_DB()
        {
            /*
            //-- Responsável por carregar os dados na setting do software.
            cx_ip.Text = Properties.Settings.Default.IP_Server;
            cx_porta.Text = Properties.Settings.Default.PORT_Server;
            cx_db.Text = Properties.Settings.Default.DB_Server;
            cx_user.Text = Properties.Settings.Default.LOG_Server;
            cx_senha.Text = Properties.Settings.Default.PWD_Server;
            //-- Responsável por carregar dados do root do sistema
            cx_login_ROOT.Text = Properties.Settings.Default.login_app;
            cx_senha_ROOT.Text = Properties.Settings.Default.pwd_app;
         */
            try {

                var appSettings = ConfigurationManager.AppSettings;
                
                cx_ip.Text    = appSettings["IP_Server"]   ?? "Não Informado";
                cx_porta.Text = appSettings["PORT_Server"] ?? "Não Informado";
                cx_db.Text    = appSettings["DB_Server"]   ?? "Não Informado";
                cx_user.Text  = appSettings["LOG_Server"]  ?? "Não Informado";
                cx_senha.Text = appSettings["PWD_Server"]  ?? "Não Informado";
                //-- Responsável por carregar dados do root do sistema
                cx_login_ROOT.Text = Properties.Settings.Default.login_app;
                cx_senha_ROOT.Text = Properties.Settings.Default.senha_app;
                //-- Empresa
                cx_empresa_desc.Text = Properties.Settings.Default.EMPRESA_DESCRICAO;
                cx_empresa_ID.Text   = Properties.Settings.Default.EMPRESA_ID.ToString();
                cx_desc_Empresa.Text = Properties.Settings.Default.EMPRESA_OBS;

            }
            catch { MessageBox.Show("Erro!!"); }    
    }
        void carrega_Dados_Update()
        {

            //config_update.get_Config();
            //cx_SeverHost.Text = config_update.SeverHost;
            //cx_LinkServer.Text = config_update.LinkServer;
            //cx_ArquivoNomeCliente.Text = config_update.ArquivoNomeCliente;
            //cx_ArquivoNomeServer.Text = config_update.ArquivoNomeServer;
        }

        void salvar_ROOT()
        {
            string login = cx_login_ROOT.Text;
            string senha = cx_senha_ROOT.Text;

            if ((login != String.Empty || login != "") && (senha != String.Empty || senha != ""))
            {

                Properties.Settings.Default.login_app = login;
                Properties.Settings.Default.senha_app = senha;
                Properties.Settings.Default.Save();
            }
            else {
                MessageBox.Show("Erro: Deve ser informando um usuário e senha root!");
            }
        }
        void salvar_Empresa()
        {
            try
            {
                Properties.Settings.Default.EMPRESA_DESCRICAO = cx_empresa_desc.Text;
                Properties.Settings.Default.EMPRESA_ID = Convert.ToInt32(cx_empresa_ID.Text);
                Properties.Settings.Default.EMPRESA_OBS = cx_desc_Empresa.Text;
                Properties.Settings.Default.Save();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao definir a empresa principal, contate o desenvolvedor!");
            }
            }
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            salvar_Dados_DB();

            //trava as caixas para edição
            cx_ip.ReadOnly = true;
            cx_db.ReadOnly = true;
            cx_porta.ReadOnly = true;
            cx_senha.ReadOnly = true;
            cx_user.ReadOnly = true;
            //Libera opções para novo cadastro
            //bt_novo.Enabled = true;
            bt_editar.Enabled = true;
            bt_testart.Enabled = true;
            bt_salvar.Enabled = false;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            //Libera as caixas para edição
            cx_ip.ReadOnly = false;
            cx_db.ReadOnly = false;
            cx_porta.ReadOnly = false;
            cx_senha.ReadOnly = false;
            cx_user.ReadOnly = false;
            cx_ip.Focus();
            //bt_novo.Enabled = false;
            bt_editar.Enabled = false;
            bt_testart.Enabled = false;
            bt_salvar.Enabled = true;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            //Libera as caixas para edição
            cx_ip.ReadOnly = true;
            cx_db.ReadOnly = true;
            cx_porta.ReadOnly = true;
            cx_senha.ReadOnly = true;
            cx_user.ReadOnly = true;

            //bt_novo.Enabled = true;
            bt_editar.Enabled = true;
            bt_testart.Enabled = true;
            bt_salvar.Enabled = false;
        }

        private void bt_testart_Click(object sender, EventArgs e)
        {
            testar_Conexao();
        }

        private void bt_salvar_2_Click(object sender, EventArgs e)
        {
            salvar_ROOT();

            cx_login_ROOT.ReadOnly = true;
            cx_senha_ROOT.ReadOnly = true;
            bt_salvar_2.Enabled = false;
            bt_editar_2.Enabled = true;
        }

        private void bt_editar_2_Click(object sender, EventArgs e)
        {
            cx_login_ROOT.ReadOnly = false;
            cx_senha_ROOT.ReadOnly = false;
            cx_login_ROOT.Focus();
            bt_salvar_2.Enabled = true;
            bt_editar_2.Enabled = false;
        }

        private void bt_cancelar_2_Click(object sender, EventArgs e)
        {
            cx_login_ROOT.ReadOnly = true;
            cx_senha_ROOT.ReadOnly = true;
            bt_salvar_2.Enabled = false;
            bt_editar_2.Enabled = true;
        }

        private void frm_configuracao_sistema_Load(object sender, EventArgs e)
        {
            carregar_Dados_DB();
            testar_Conexao();
             //carrega_Empresa();
            carrega_Dados_Update();
        }
        private void testar_Conexao() {
            ConexaoDB conexao = new ConexaoDB();
            var conectado = conexao.testar_conexao();

            if (conectado == true)
            {
                img_status.Image = Properties.Resources.verde_25x25;
                lbl_on_off.Text = "Online";
            }
            else
            {
                img_status.Image = Properties.Resources.vermelho_25x25;
                lbl_on_off.Text = "Offline";
            }
        }

        private void bt_incluir_empresa_Click(object sender, EventArgs e)
        {
            bt_incluir_empresa.Enabled = false;
            var add_empresa = new frm_empresa();
            add_empresa.ShowDialog();
            bt_incluir_empresa.Enabled = true;
            //----------------[Carrega dados da empresa selecionada.]------------------//
            cx_empresa_desc.Text = empresa.Emp_descricao;
            cx_empresa_ID.Text   = empresa.Emp_ID.ToString();
            if (empresa.Emp_ID > 0)
            {
                bt_salvar_empresa.Enabled = true;
                cx_desc_Empresa.ReadOnly = false;
                cx_desc_Empresa.Focus();
            }
            else {
                bt_salvar_empresa.Enabled = false;
                cx_desc_Empresa.ReadOnly = true;
            }
        }

         static void adicionar_atualizar_SettinsApp(string chave, string valor) {

            try
            {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationManager.GetSection("") );
                //var settings = configFile.AppSettings.Settings;

                //Remove a chave
                config.AppSettings.Settings.Remove(chave);
                //Adiciona a nova configuração.
                config.AppSettings.Settings.Add(chave, valor);
                //Salva modificação.
                config.Save(ConfigurationSaveMode.Modified);
                //configFile.Save(ConfigurationSaveMode.Modified);
                //Renicia e Recarrega a configuração realizada.
                ConfigurationManager.RefreshSection("appSettings");

                //configFile.Save(ConfigurationSaveMode.Modified);
                //ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Ocorreu um erro ao salvar informações");
            }
        }

        private void bt_salvar_empresa_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show("Fixar essa empresa como principal?","Definir empresa",MessageBoxButtons.YesNo);
            if (pergunta == DialogResult.Yes)
            {
                salvar_Empresa();
                bt_salvar_empresa.Enabled = false;
                cx_desc_Empresa.ReadOnly = true;
            }
        }

        private void bt_cancelar_3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cx_empresa_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_editar_3_Click(object sender, EventArgs e)
        {
            bt_editar_3.Enabled = false;
            var add_empresa = new frm_empresa();
            add_empresa.ShowDialog();
            bt_editar_3.Enabled = true;
            //----------------[Carrega dados da empresa selecionada.]------------------//
            cx_empresa_desc.Text = empresa.Emp_descricao;
            cx_empresa_ID.Text = empresa.Emp_ID.ToString();
            if (empresa.Emp_ID > 0)
            {
                bt_salvar_empresa.Enabled = true;
                cx_desc_Empresa.ReadOnly = false;
                cx_desc_Empresa.Focus();
            }
            else
            {
                bt_salvar_empresa.Enabled = false;
                cx_desc_Empresa.ReadOnly = true;
            }
        }
    }
}
