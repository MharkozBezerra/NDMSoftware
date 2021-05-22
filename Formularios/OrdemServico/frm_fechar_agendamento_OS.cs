
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
using Controlador.Controle.DataGrid_Config.DataGrid_Atendimento_OS;
using Regras_N.Regra_N_Usuario;
using NDM_SoftwareV5.Formularios.OrdemServico;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk;

namespace NDM_SoftwareV5.Formularios.OrdemServico
{
    public partial class frm_fechar_agendamento_OS : Form
    {
        public frm_fechar_agendamento_OS()
        {
            InitializeComponent();
        }
        /*----------[valores statticos]----------*/
        public static int grid_cod;
        public static string grid_codigo        = "";
        public static string grid_nome          = "";
        public static string grid_data_abertura = "";
        public static string grid_num_OS        = "";
        public static string grid_categoria     = "";
        public static string grid_subcategoria  = "";
        public static string grid_obs           = "";
        public static string grid_helpdesk      = "";
        public static string texto_titulo       = "";
        public static string text_label_data    = "";
        public static int idTecnicoAgendado     = 0;
        public static int condicoes_externas   = 0;
        public static int filial_id = 0;
        public static string txt_botaoFinalizar = "";
        //private int cat_id_os = 0;
        private int sub_id_os = 0;
        Atendimento_OS atendimento = new Atendimento_OS();
        RN_Atendimento_OS regra_atendimento = new RN_Atendimento_OS();
        ComboBox_Categorias_Subcategorias cb_config = new ComboBox_Categorias_Subcategorias();
        Categoria_Atendimento_OS categoria = new Categoria_Atendimento_OS();
        Subcategoria_Atendimento_OS subcategoria = new Subcategoria_Atendimento_OS();
        Filial filial = new Filial();
        private void frm_fechar_agendamento_OS_Load(object sender, EventArgs e)
        {
            lbl_titullo.Text  = texto_titulo;
            lbl_data_txt.Text = text_label_data;
            bt_age_concluir.Text = txt_botaoFinalizar;
            carrega_valores();
            filial.Fili_ID = filial_id;
            carregar_comboBox_Iniciar(condicoes_externas, filial);
        }

        void carrega_valores() {

            cx_ag_cod_OS.Text = grid_num_OS;
            cx_age_cod_cliente.Text = grid_codigo;
            cx_age_nome_cliente.Text = grid_nome;
            cx_age_helpdesk.Text = grid_helpdesk;
            cx_age_categoria.Text = grid_categoria;
            cx_age_subcategoria.Text = grid_subcategoria;
            cx_age_obs.Text = grid_obs;
            cx_data_aberta.Text = grid_data_abertura;
            cx_data_fechada.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            cx_data_fechada.Focus();

        }

        private void cx_data_fechada_Leave(object sender, EventArgs e)
        {
            try
            {
                int data_aceitavel = Convert.ToInt32(cx_data_aberta.Text.Replace("/", ""));
                int data_digitada = Convert.ToInt32(cx_data_fechada.Text.Replace("/", ""));
                if (data_aceitavel >= data_digitada) { }
                else if (data_digitada < data_aceitavel) {
                    MessageBox.Show("Valor inserido está abaixo do permitido");
                    cx_data_fechada.Focus();
                }
            }
            catch {

                MessageBox.Show("Valor incorreto, será inserido data atual no lugar.");
                cx_data_fechada.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            }
         }

        private void bt_age_concluir_Click(object sender, EventArgs e)
        {
            //condicoes_externas = 
            //{ 
                //0 ->DÁ BAIXA NA ORDEM DE SERVIÇO-finaliza 
                //1 ->REALIZA O AGENDAMENTO DO ATENDIMENTO 
                //2 ->DÁ BAIXA NA ORDEM DE SERVIÇO-Sem Execução 
            //}
            acoes_bt_finalizar(condicoes_externas);
            Close();

        }

        private void bt_age_cancelar_Click(object sender, EventArgs e)
        {
            grid_cod = 0;
            grid_codigo = null;
            grid_nome = null;
            grid_data_abertura = null;
            grid_num_OS = null;
            grid_categoria = null;
            grid_subcategoria = null;
            grid_obs = null;
            grid_helpdesk = null;

            Close();
        }

        private void frm_fechar_agendamento_OS_FormClosed(object sender, FormClosedEventArgs e)
        {
            grid_cod = 0;
            grid_codigo = null;
            grid_nome = null;
            grid_data_abertura = null;
            grid_num_OS = null;
            grid_categoria = null;
            grid_subcategoria = null;
            grid_obs = null;
            grid_helpdesk = null;
        }

        private void cx_data_fechada_Validated(object sender, EventArgs e)
        {
            try
            {
                int data_aceitavel = Convert.ToInt32(cx_data_aberta.Text.Replace("/", ""));
                int data_digitada = Convert.ToInt32(cx_data_fechada.Text.Replace("/", ""));

                if (data_digitada < data_aceitavel)
                {
                    MessageBox.Show("Valor inserido está abaixo do permitido");
                    cx_data_fechada.Focus();
                }
            }
            catch
            {

                MessageBox.Show("Valor incorreto, será inserido data atual no lugar.");
                cx_data_fechada.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            }
        }

        private void cx_age_obs_TextChanged(object sender, EventArgs e)
        {
            lbl_texto_maximo.Text = "Texto : " + cx_age_obs.TextLength.ToString() + " / 970";
        }

        private void acoes_bt_finalizar(int condicoes) {


            switch (condicoes) {
                //DÁ BAIXA NA ORDEM DE SERVIÇO-finaliza
                case 0:
                    var fechamento = cx_data_fechada.Text;
                    try   { fechamento = Convert.ToDateTime(fechamento).ToString("yyyy-MM-dd"); }
                    catch { fechamento = DateTime.Now.Date.ToString("yyyy-MM-dd"); }

                    lbl_mudeAqui.Location = new Point(243, 51);
                    cx_data_fechada.Location = new Point(239, 69);
                    var obs = cx_age_obs.Text;
                    DialogResult per_fechar = MessageBox.Show("Concluir O.S de nº " + grid_num_OS + " Agora?", "..:: FINALIZAR AGENDAMENTO ::..", MessageBoxButtons.YesNo);
                    if (per_fechar == DialogResult.Yes)
                    {
                        obs = obs + " \r\nATENDIMENTO CONCLUIDO EM :" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ".";
                        //atendimento.alterar_Agendamento_Concluir_OS(grid_cod, fechamento, obs,2);
                        atendimento.OS_ID = grid_cod;
                        atendimento.OS_aten_data_fechamento = fechamento;
                        atendimento.OS_desc_atendimento = obs;
                        regra_atendimento.fechar_OS(atendimento);

                        grid_cod = 0;
                        grid_codigo = null;
                        grid_nome = null;
                        grid_data_abertura = null;
                        grid_num_OS = null;
                        grid_categoria = null;
                        grid_subcategoria = null;
                        grid_obs = null;
                        grid_helpdesk = null;

                        
                    }
                    else
                    {
                        grid_cod = 0;
                        grid_codigo = null;
                        grid_nome = null;
                        grid_data_abertura = null;
                        grid_num_OS = null;
                        grid_categoria = null;
                        grid_subcategoria = null;
                        grid_obs = null;
                        grid_helpdesk = null;
                       
                    }
                    break;

                //REALIZA O AGENDAMENTO DO ATENDIMENTO
                case 1:
                    var agendamento = cx_data_fechada.Text;
                    try   { agendamento = Convert.ToDateTime(agendamento).ToString("yyyy-MM-dd"); }
                    catch { agendamento = DateTime.Now.Date.ToString("yyyy-MM-dd"); }
                        var age_obs = cx_age_obs.Text;
                    lbl_mudeAqui.Location = new Point(274, 51);
                    cx_data_fechada.Location = new Point(270, 69);
                    sub_id_os = subcategoria.Sub_ID;
                    DialogResult per_agendar = MessageBox.Show("Agendar O.S de nº " + grid_num_OS + " Agora?", "..:: REALIZAR AGENDAMENTO ::..", MessageBoxButtons.YesNo);
                    if (per_agendar == DialogResult.Yes)
                    {
                        //atendimento.alterar_Agendamento_Tecnico_OS(grid_cod, agendamento, age_obs, idTecnicoAgendado,1,cat_id_os,sub_id_os);
                        atendimento.OS_ID = grid_cod;
                        atendimento.OS_data_agendamento = agendamento;
                        atendimento.OS_desc_atendimento = age_obs;
                        TecnicoRua tecnico = new TecnicoRua();
                        tecnico.Tec_ID = idTecnicoAgendado;
                        atendimento.OS_categoria = categoria;
                        atendimento.OS_subcategoria = subcategoria;
                        atendimento.tecnico = tecnico;
                        regra_atendimento.encaminhar_para_tecnico_OS(atendimento);

                        grid_cod = 0;
                        grid_codigo = null;
                        grid_nome = null;
                        grid_data_abertura = null;
                        grid_num_OS = null;
                        grid_categoria = null;
                        grid_subcategoria = null;
                        grid_obs = null;
                        grid_helpdesk = null;

                        
                    }
                    else
                    {
                        grid_cod = 0;
                        grid_codigo = null;
                        grid_nome = null;
                        grid_data_abertura = null;
                        grid_num_OS = null;
                        grid_categoria = null;
                        grid_subcategoria = null;
                        grid_obs = null;
                        grid_helpdesk = null;
                       
                    }

                    break;
                    case 2:
                    //BAIXA SEM EXECUÇÃO
                    var fechamento_S = cx_data_fechada.Text;
                    try   { fechamento_S = Convert.ToDateTime(fechamento_S).ToString("yyyy-MM-dd"); }
                    catch { fechamento_S = DateTime.Now.Date.ToString("yyyy-MM-dd"); }
                    
                    var obs_S = cx_age_obs.Text;
                    lbl_mudeAqui.Location = new Point(243, 51);
                    cx_data_fechada.Location = new Point(239, 69);
                    DialogResult per_S = MessageBox.Show("Concluir O.S de nº " + grid_num_OS + " Agora?", "..:: FINALIZAR AGENDAMENTO ::..", MessageBoxButtons.YesNo);
                    if (per_S == DialogResult.Yes)
                    {
                        obs_S = obs_S + "\r\n BAIXADO SEM EXECUÇÃO EM :" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ".";
                        //atendimento.alterar_Agendamento_Concluir_OS(grid_cod, fechamento_S, obs_S,4);
                        atendimento.OS_ID = grid_cod;
                        atendimento.OS_aten_data_fechamento = fechamento_S;
                        atendimento.OS_desc_atendimento = obs_S;

                        regra_atendimento.fechar_OS_sem_execucao(atendimento);

                        grid_cod = 0;
                        grid_codigo = null;
                        grid_nome = null;
                        grid_data_abertura = null;
                        grid_num_OS = null;
                        grid_categoria = null;
                        grid_subcategoria = null;
                        grid_obs = null;
                        grid_helpdesk = null;


                    }
                    else
                    {
                        grid_cod = 0;
                        grid_codigo = null;
                        grid_nome = null;
                        grid_data_abertura = null;
                        grid_num_OS = null;
                        grid_categoria = null;
                        grid_subcategoria = null;
                        grid_obs = null;
                        grid_helpdesk = null;

                    }
                    break;
                //FINALIZA A ORDEM DE SERVIÇO SEM EXECUÇÃO
                default:
                    MessageBox.Show("Opção não informado");
                    break;

            }
        }
        private void carregar_comboBox_Iniciar(int codicao_agendamento,Filial fill) {
            //DEVE SER CARREGADO ANTES DE INICIAR, POIS AS INFORMAÇÕES DEVEM SER MOSTRADAS PARA DAR CONTINUIDADE NO PROCESSO.
            if (codicao_agendamento == 1)
            {

                //MUDA O TAMANHO DO TEXTBOX cx_age_obs.
                cx_age_obs.Size = new Size(432, 115);
                cx_age_obs.Location = new Point(3, 279);
                //Torna visível o grupo_os
                grupo_os.Visible = true;
                //Carrega combox
                cb_config.combox_Categoria_OS(cb_categoria_os_desc,  fill);

                

            }
            else {
                //Volta ao tamanho normal
                cx_age_obs.Size = new Size(432, 203);
                cx_age_obs.Location = new Point(3, 191);
                //Torna invisível o grupo_os
                grupo_os.Visible = false;

            }
        }

        private void cb_categoria_os_desc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { categoria.Cate_ID = ((Categoria_Atendimento_OS)cb_categoria_os_desc.SelectedItem).Cate_ID; }
            catch { categoria.Cate_ID = 0; }
            cb_config.combox_Subcategoria_OS(cb_subcategoria_os_desc, categoria);
        }

        private void cb_subcategoria_os_desc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { subcategoria.Sub_ID = ( (Subcategoria_Atendimento_OS) cb_subcategoria_os_desc.SelectedItem).Sub_ID; }
            catch { subcategoria.Sub_ID = 0; }
        }
    }
}
