
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
using Regras_N.Regra_N_Usuario;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    public partial class frm_encaminhar_atendimento_help : Form
    {
        // -> Pega dados do forme principal
        public static Atendimento atendimento_statico = new Atendimento();
        public static Filial filial_statico = new Filial();
        public static Cliente cliente_statico = new Cliente();
        public static HelpDesk helpdesk_solicitante = new HelpDesk();
        HelpDesk helpdesk_alvo = new HelpDesk();
        public static Categoria_Atendimento categoria_statico = new Categoria_Atendimento();
        private ComboBox_Usuarios cb_config_user = new ComboBox_Usuarios();
        public static Subcategoria_Atendimento subcategoria_statico = new Subcategoria_Atendimento();
        private RN_Atendimento regra_atendimento = new RN_Atendimento();

        //
        public static bool atendimento_Solicitado = false;


        ComboBox_Categorias_Subcategorias cb_config_categoria_subcategoria = new ComboBox_Categorias_Subcategorias();

      
        public frm_encaminhar_atendimento_help()
        {
            InitializeComponent();
        }

        private void frm_encaminhar_atendimento_help_Load(object sender, EventArgs e)
        {

            cx_ac_codCliente.Text = cliente_statico.Clie_codigo.ToString();
            cx_ac_nomeCliente.Text = cliente_statico.Clie_nome;

            cb_config_user.combox_HelpDesk(cb_helpDesk,filial_statico);
            cb_config_categoria_subcategoria.combox_Categoria_Atendimento(cb_categoria_descricao, filial_statico);



            

            set_dadosCombobox();
        }

        private void set_dadosCombobox() {

            cb_categoria_descricao.DropDownStyle         = ComboBoxStyle.Simple;
            cb_TipoAtendimento_ID.DropDownStyle          = ComboBoxStyle.Simple;


            cb_categoria_descricao.Text                  = categoria_statico.Cate_descricao;
            //cb_categoria_ID.Text                         = categoria_statico.Cate_ID.ToString();

            cx_ac_obs.Text                               = atendimento_statico.Atend_descricao;

            cb_categoria_descricao.DropDownStyle         = ComboBoxStyle.DropDownList;
            cb_TipoAtendimento_ID.DropDownStyle          = ComboBoxStyle.DropDownList;

            set_dadosSubcategoria();
        }
        private void set_dadosSubcategoria() {

            cb_subcategoria_descricao.DropDownStyle     = ComboBoxStyle.Simple;
            //cb_subcategoria_ID.DropDownStyle            = ComboBoxStyle.Simple;

            cb_subcategoria_descricao.Text              = subcategoria_statico.Sub_descricao;
            //cb_subcategoria_ID.Text                     = subcategoria_statico.Sub_ID.ToString();

            cb_subcategoria_descricao.DropDownStyle     = ComboBoxStyle.DropDownList;
            //cb_subcategoria_ID.DropDownStyle            = ComboBoxStyle.DropDownList;
        }
        private void encaminhar_Atendimento() {


            Categoria_Atendimento categoria = new Categoria_Atendimento();
            Subcategoria_Atendimento subcategoria = new Subcategoria_Atendimento();
           

            
            categoria.Cate_ID = categoria_statico.Cate_ID;
            subcategoria.Sub_ID = subcategoria_statico.Sub_ID;
            var hora_encaminhado = DateTime.Now.ToString("HH:mm:ss");
            var descricao = "";
            atendimento_statico.categoria = categoria;
            atendimento_statico.subcategoria = subcategoria;
            atendimento_statico.helpdesk = helpdesk_alvo;
            int acao = 0;
            descricao = "Atendimento reencaminhado de : { " + frm_HelpDesk.help_atendimento.help_Nome + " } para: { " + cb_helpDesk.Text + " } as: " + hora_encaminhado + " \r\n " + cx_ac_obs.Text;
            atendimento_statico.Atend_descricao = descricao;

            if (atendimento_Solicitado == true)
            {
                acao = regra_atendimento.upt_atendimento_help(atendimento_statico);
                limpa_DAdos();
                acao_atendimento(acao);
                this.Close();

            }
            else {
                var data_solicitadao = DateTime.Now.Date.ToString("yyyy-MM-dd");
                atendimento_statico.Atend_data_solicitado = data_solicitadao;
                acao = regra_atendimento.solicitar_atendimento_helpdesk(atendimento_statico);
                limpa_DAdos();
                acao_atendimento(acao);
                this.Close();
            }
           

        }
        private void acao_atendimento(int acao)
        {

            var msg = "";
            switch (acao)
            {
                case 6: msg = "Atendimento registrado com sucesso"; break;
                case 7: msg = "Atendimento não pode ser registrado \r\nSolução: Entre em contato com desenvovedor."; break;
                case 8: msg = "Atendimento atualizado!"; break;
                case 9: msg = "Atendimento não pode ser atualizado \r\nSolução: Entre em contato com desenvovedor"; break;
                default: msg = "Erro desconhecido \r\nSolução: Entre em contato com desenvovedor"; break;
            }
            MessageBox.Show(msg, "..:: NDM-Software ::..");
        }
        private  void limpa_DAdos() {

        cx_ac_codCliente.Text = "";
        cx_ac_nomeCliente.Text = "";
        atendimento_Solicitado = false;
    }

        private void bt_ac_salvar_sem_finalizar_Click(object sender, EventArgs e)
        {
            DialogResult per_en = MessageBox.Show("Encaminhar atendimento?","..:: Atenção ::..",MessageBoxButtons.YesNo);
            if (per_en == DialogResult.Yes)
            {
                encaminhar_Atendimento();
                //frm_index_atendimentoHelp.atendimento_encaminhado = true;
            }
            else {
                cb_helpDesk.Focus();
            }
        }

        private void bt_ac_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult per_en = MessageBox.Show("Cancelar encaminhamento?", "..:: Atenção ::..", MessageBoxButtons.YesNo);
            if (per_en == DialogResult.Yes)
            {
                limpa_DAdos();
                
                this.Close();
            }
            else
            {
                cb_helpDesk.Focus();
            }
           
        }

        private void cx_ac_obs_TextChanged(object sender, EventArgs e)
        {
            lbl_texto_max.Text = "Max.Texto "+ cx_ac_obs.TextLength + "/180";
        }

        private void cb_categoria_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                cb_config_categoria_subcategoria.combox_Subcategoria_Atendimento(cb_subcategoria_descricao, categoria_statico);
                categoria_statico.Cate_ID = ((Categoria_Atendimento)cb_categoria_descricao.SelectedItem).Cate_ID;
                categoria_statico.Cate_descricao = cb_categoria_descricao.Text;
            }
            catch
            {
                cb_subcategoria_descricao.Text = "";
                
            }
        }

        private void cb_subcategoria_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                subcategoria_statico.Cate_ID = ((Subcategoria_Atendimento)cb_subcategoria_descricao.SelectedItem).Sub_ID;
                subcategoria_statico.Sub_descricao = cb_subcategoria_descricao.Text;
            }
            catch
            {
                subcategoria_statico.Cate_ID = 0;
                subcategoria_statico.Sub_descricao = "";
            }
        }

        private void cb_helpDesk_SelectedIndexChanged(object sender, EventArgs e)
        {
            helpdesk_alvo.help_ID = ((HelpDesk)cb_helpDesk.SelectedItem).help_ID;
        }
    }
}
