
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Classes;
using Controlador.Controle;
using Controlador.Controle.ComboBox_Config;
using Regras_N.Regra_N_Usuario;
using System.Windows.Forms;
using NDM_SoftwareV5.Formularios.F_Cliente;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    public partial class frm_add_Atendimento : Form
    {
        string data_atual;
        public static bool atendimento_solicitado     = false;
        public static Atendimento atendimento_statico = new Atendimento();
        private Filial filial                         = new Filial();
        private Atendimento_OS atendimento_OS         = new Atendimento_OS();
        public static HelpDesk helpdek_statico        = new HelpDesk();
        private Empresa empresa                       = new Empresa();
        
        ComboBox_Filial config_cb_filail              = new ComboBox_Filial();
        Categoria_Atendimento categoria               = new Categoria_Atendimento();
        Subcategoria_Atendimento subcategoria         = new Subcategoria_Atendimento();
        public static TecnicoRua tecnico              = new TecnicoRua();
        RN_Atendimento regra_atendimento              = new RN_Atendimento();
        RN_Atendimento_OS regra_atendimento_OS        = new RN_Atendimento_OS();

        Cliente cliente                               = new Cliente();
        ComboBox_Categorias_Subcategorias config_combo_categoria_subcategoria = new ComboBox_Categorias_Subcategorias();

        public frm_add_Atendimento()
        {
            InitializeComponent();
        }

        private void frm_add_Atendimento_Load(object sender, EventArgs e)
        {
            data_atual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            cx_dataHora.Text = data_atual;
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            config_cb_filail.combox_Carregado_Filial(cb_provedor, empresa);
           

            if (atendimento_solicitado == true) {
                //Puxa dados do atendimento já aberto.
                //Atendimento atendimento_solicitado = atendimento_statico;
                distribui_atendimento_solicitado(atendimento_statico);
                cb_provedor.Enabled = false;
                var frm_solicitacao = new frm_inf_atendimento_solicitado();
                frm_solicitacao.Close();
               
            }
            cx_codCliente.Focus();
        }
        private void img_clientes_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var codigo          = Convert.ToInt32(cx_codCliente.Text);
                cliente.Fili_ID = filial.Fili_ID;
                cliente.Clie_codigo = codigo;
                cliente.Clie_nome   = null;
                cliente.Clie_ID     = 0;
                if (regra_atendimento.validar_cliente(cliente) == true)
                {

                    cliente                         = regra_atendimento.puxar_cliente(cliente);
                    frm_add_cliente.cliente_statico = cliente;
                    frm_add_cliente.acao            = 1;
                    var add_cliente                 = new frm_add_cliente();
                    add_cliente.ShowDialog();
                    cx_nomeCliente.Text = cliente.Clie_nome;
                    cx_codCliente.Focus();
                }
            }
            catch { }
           

        }
        private void cx_codCliente_Validated(object sender, EventArgs e)
        {
            try
            {
                if (cx_codCliente.Text != "" || cx_codCliente.Text != String.Empty)
                {
                    var codigo = Convert.ToInt32(cx_codCliente.Text);

                    cliente.Fili_ID = filial.Fili_ID;
                    cliente.Clie_codigo = codigo;
                    cliente.Clie_nome = null;
                    cliente.Clie_ID = 0;
                    if (regra_atendimento.validar_cliente(cliente) == true)
                    {
                        cx_nomeCliente.Text = "";
                        cliente = regra_atendimento.puxar_cliente(cliente);
                        cx_nomeCliente.Text = cliente.Clie_nome;
                        img_clientes.Visible = true;
                        lbl_clientes.Visible = true;
                        filial.Fili_ID = filial.Fili_ID;
                        liberar_categoria(true, filial);
                    }
                    else
                    {
                        do
                        {

                            DialogResult pergunta = MessageBox.Show("Atenção: Cliente não encontrado! \r\nDeseja cadastrar esse novo código agora?", "Código inválido", MessageBoxButtons.YesNo);
                            if (pergunta == DialogResult.Yes)
                            {
                                var add_cliente = new frm_add_cliente();
                                cliente.Fili_ID = filial.Fili_ID;
                                cliente.Fili_descricao = cb_provedor.Text;
                                cliente.Clie_codigo = codigo;
                                cliente.Clie_ID = 0;
                                cx_nomeCliente.Text = "";
                                frm_add_cliente.acao = 1;
                                frm_add_cliente.cliente_statico = cliente;
                                add_cliente.ShowDialog();

                                cx_nomeCliente.Text = "";
                                cliente = regra_atendimento.puxar_cliente(cliente);
                                cx_nomeCliente.Text = cliente.Clie_nome;
                                img_clientes.Visible = true;
                                lbl_clientes.Visible = true;
                                filial.Fili_ID = filial.Fili_ID;
                                liberar_categoria(true, filial);

                            }
                            else
                            {
                                cx_nomeCliente.Text = "";
                                cliente.Clie_nome = null;
                                cliente.Clie_ID = 0;
                                img_clientes.Visible = true;
                                lbl_clientes.Visible = true;
                                liberar_categoria(false, filial);
                                MessageBox.Show("Não é possível realizar um atendimento sem um cliente válido.","Atenção!!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                                Close();
                                break;

                            }

                           

                        } while (regra_atendimento.validar_cliente(cliente) == false);

                    }

                }
            }
            catch

            {
                MessageBox.Show("Aqui é aceito apenas números descimais!", "Valor não aceito.");
                cx_codCliente.Text = 0.ToString();
                cx_nomeCliente.Text = "";
            }
        
        
         }
        private void cb_provedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial.Fili_ID = ((Filial)cb_provedor.SelectedItem).Fili_ID;
            cx_codCliente.Text   = 0.ToString();
            cx_nomeCliente.Text  = "";
            img_clientes.Visible = false;
            lbl_clientes.Visible = false;
        }

        private void bt_buscar_tec_Click(object sender, EventArgs e)
        {
            tecnico.Tec_ID = 0;
            tecnico.Tec_nome = "";
            frm_buscar_tecnico tec_rua = new frm_buscar_tecnico();
            frm_buscar_tecnico.filial_statico = filial;
            frm_buscar_tecnico.is_atendimento_help = true;
            tec_rua.ShowDialog();
            cx_nome_tecnico.Text = tecnico.Tec_nome;
        }
        private void chk_OS_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_OS.Checked == true) { cx_codOS.Enabled = true;  }
            else { cx_codOS.Enabled = false; cx_codOS.Text = ""; }
        }
        private void cx_codOS_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void bt_gravar_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Gravar atendimento?", "Atenção", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes) { realizar_atendimento(); }

        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /////////////////////[Metodos internos]//////////////////////////////////////////////
        private void distribui_atendimento_solicitado(Atendimento atend) {

            if (atend.Aten_ID > 0)
            {
                atend = regra_atendimento.puxar_atendimento(atend);
                //DEFINE O PROVEDOR
                
                filial.Fili_ID                = atend.Fili_ID;
                cb_provedor.Text              = atend.Fili_descricao;
                //cb_provedor_ID.Text           = filial.Fili_ID.ToString();
                //DEFINO O CLIENTE
                cliente.Clie_ID               = atend.cliente.Clie_ID;
                cx_codCliente.Text            = atend.cliente.Clie_codigo.ToString();
                cx_nomeCliente.Text           = atend.cliente.Clie_nome;
                //DEFINE A CATEGORIA

                liberar_categoria(true, filial);
                
                cb_categoria_descricao.Text    = atend.categoria.Cate_descricao;
                //cb_categoria_ID.Text           = atend.categoria.Cate_ID.ToString();
                //DEFINE A SUBCATEGORIA
                categoria.Cate_ID              = atend.categoria.Cate_ID;
                liberar_subcategoria(categoria);
                cb_subcategoria_descricao.Text = atend.subcategoria.Sub_descricao;
                //cb_subcategoria_ID.Text        = atend.subcategoria.Sub_descricao;
                //DEFINE OBS...
                cx_obs.Text                    = atend.Atend_descricao;
                //INFORMA QUEM SOLICITOU
                
                cx_solicitado.Text             = atend.recepcao.Rec_nome;
                //Data da solicitação
                cx_dataHora.Text               = atend.Atend_data_solicitado;
            }
            

        }
        private void liberar_categoria(bool liberar,Filial fill) {
            if (liberar == true)
            {

                config_combo_categoria_subcategoria.combox_Categoria_Atendimento(cb_categoria_descricao,fill);
                cb_categoria_descricao.Enabled = true;
            }
            else {

                cb_categoria_descricao.Enabled = false;
                cb_subcategoria_descricao.Enabled = false;
                cb_subcategoria_descricao.Text = "";
                cb_categoria_descricao.Text = "";
            }
        }
        private void liberar_subcategoria(Categoria_Atendimento categoria) {

            if (categoria.Cate_ID > 0) {
                cb_subcategoria_descricao.Text = "";
               // cb_subcategoria_ID.Text = "0";
                config_combo_categoria_subcategoria.combox_Subcategoria_Atendimento(cb_subcategoria_descricao, categoria);
                cb_subcategoria_descricao.Enabled = true;

            }
        }
        private void realizar_atendimento() {
            var isOS = 0;
            var isAcompanhar = 0;
            var acao = 0;
            //Vericiar se foir aberto o.s.
            if (chk_OS.Checked == true) { isOS = 1; } else { isOS = 0; }
            if (chk_acompanhar.Checked == true) { isAcompanhar = 1; } else { isAcompanhar = 0; }


           
                Atendimento atendimento_finalizar     = new Atendimento();

                atendimento_finalizar.Fili_ID         = filial.Fili_ID;
                atendimento_finalizar.cliente         = cliente;
                atendimento_finalizar.categoria       = categoria;
                atendimento_finalizar.subcategoria    = subcategoria;
                atendimento_finalizar.helpdesk        = helpdek_statico;
                atendimento_finalizar.tecnico_rua     = tecnico;
                RecepcaoVendedor recepcao = new RecepcaoVendedor();
            try
            {
                if (atendimento_solicitado == false)
                {
                    atendimento_finalizar.recepcao = recepcao;
                    recepcao.Rec_ID = 0;

                }
                else
                {
                    
                    recepcao = atendimento_statico.recepcao;
                    
                }
            }
            catch(Exception er)
            {
                var e = er.Message;
                //Recebe valor de sistema. SYSTEM_RECEPCAO.
                //Não mudar.
                recepcao.Rec_ID = 4;
                recepcao.Rec_nome = "SYSTEM_RECEPCAO";
            }
                atendimento_finalizar.recepcao        = recepcao;
                atendimento_finalizar.Atend_data      = data_atual;
                atendimento_finalizar.Atend_hora      = DateTime.Now.ToString("HH:mm:ss");
                atendimento_finalizar.Atend_descricao = cx_obs.Text;
                atendimento_finalizar.Is_acompanhar   = isAcompanhar;
                atendimento_finalizar.Is_OS           = isOS;
                atendimento_finalizar.Is_finalizado   = 0;
                try
                {
                    if (isOS > 0) {atendimento_finalizar.Codigo_OS = Convert.ToInt32(cx_codOS.Text);}
                    else { atendimento_finalizar.Codigo_OS = 0; }
                }
                catch { atendimento_finalizar.Codigo_OS = 0; }

            //Adiciona um novo atendimento.
            if (atendimento_solicitado == true)
            {
                atendimento_finalizar.Aten_ID       = atendimento_statico.Aten_ID;
                atendimento_finalizar.prioridade_FK = atendimento_statico.prioridade_FK;
                try
                {
                    recepcao = atendimento_statico.recepcao;
                    atendimento_finalizar.recepcao = recepcao;
                }
                catch { recepcao.Rec_ID = 4; }
                acao = regra_atendimento.upt_atendimento_help(atendimento_finalizar);
            }
            else { acao = regra_atendimento.realizar_atendimento_help(atendimento_finalizar); }

            //Verifica se foi aberta o.s..
            if (chk_OS.Checked == true && Convert.ToInt32(cx_codOS.Text) > 0) {

                atendimento_OS.OS_codigo_OS = Convert.ToInt32(cx_codOS.Text);
                atendimento_OS.Fili_ID      = atendimento_finalizar.Fili_ID;
                atendimento_OS.OS_aten_data_abertura = atendimento_finalizar.Atend_data;
                atendimento_OS.Atend_descricao = atendimento_finalizar.Atend_descricao;
                regra_atendimento_OS.abrir_OS_atendimento_Help(atendimento_OS);
            }
            acao_atendimento(acao);
            this.Close();
        }
        private void acao_atendimento(int acao) {

            var msg = "";
            switch (acao)
            {
                case 6: msg  = "Atendimento registrado com sucesso"; break;
                case 7: msg  = "Atendimento não pode ser registrado \r\nSolução: Entre em contato com desenvovedor."; break;
                case 8: msg  = "Atendimento atualizado!"; break;
                case 9: msg  = "Atendimento não pode ser atualizado \r\nSolução: Entre em contato com desenvovedor"; break;
                default: msg = "Erro desconhecido \r\nSolução: Entre em contato com desenvovedor";break;
            }
            MessageBox.Show(msg,"..:: NDM-Software ::..");
        }

        private void cx_codOS_Leave(object sender, EventArgs e)
        {
            int codigo = 0;
            try
            {
                cx_codOS.Text = cx_codOS.Text.Replace(".", "");
                cx_codOS.Text = cx_codOS.Text.Replace(",", "");
                codigo = Convert.ToInt32(cx_codOS.Text);
                cx_codOS.Text = codigo.ToString();
            }
            catch
            {
                MessageBox.Show("Valor digitado não é válido!");
                cx_codOS.Text = "0";
                cx_codOS.Focus();
            }
        }

        private void img_passar_atendimento_MouseClick(object sender, MouseEventArgs e)
        {
            var frm_proximo_turno = new frm_encaminhar_atendimento_help();
            if (atendimento_solicitado == true)
            {
                DialogResult perguntar = MessageBox.Show("Atenção: Esse atendimento foi direcionado para você, mesmo assim quer repassar?","Proximo Turno",MessageBoxButtons.YesNo);
                if (perguntar == DialogResult.Yes)
                {
                    frm_encaminhar_atendimento_help.atendimento_statico = atendimento_statico;
                    atendimento_statico.Atend_descricao = cx_obs.Text;
                    frm_encaminhar_atendimento_help.helpdesk_solicitante = frm_HelpDesk.help_atendimento;
                    frm_encaminhar_atendimento_help.cliente_statico = cliente; 
                    frm_encaminhar_atendimento_help.filial_statico = filial;
                    frm_encaminhar_atendimento_help.categoria_statico = categoria;
                    frm_encaminhar_atendimento_help.subcategoria_statico = subcategoria;
                    frm_proximo_turno.ShowDialog();
                    Close();

                }
                

            }
            else
            {
                Atendimento aten_so = new Atendimento();
                aten_so.cliente = cliente;
                aten_so.categoria = categoria;
                aten_so.subcategoria = subcategoria;
                aten_so.Fili_ID = filial.Fili_ID;
                aten_so.helpdesk = frm_HelpDesk.help_atendimento;
                aten_so.Atend_descricao = cx_obs.Text;
                aten_so.Is_acompanhar = 0;
                aten_so.Is_OS = 0;
                frm_encaminhar_atendimento_help.atendimento_statico = aten_so;
                atendimento_statico.Atend_descricao = cx_obs.Text;
                frm_encaminhar_atendimento_help.helpdesk_solicitante = frm_HelpDesk.help_atendimento;
                frm_encaminhar_atendimento_help.cliente_statico = cliente;
                frm_encaminhar_atendimento_help.filial_statico = filial;
                frm_encaminhar_atendimento_help.categoria_statico = categoria;
                frm_encaminhar_atendimento_help.subcategoria_statico = subcategoria;
                frm_proximo_turno.ShowDialog();
                Close();
            }
        }

        private void cb_categoria_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                categoria.Cate_ID = ((Categoria_Atendimento)cb_categoria_descricao.SelectedItem).Cate_ID;
                categoria.Cate_descricao = cb_categoria_descricao.Text;
                tecnico.Tec_ID = 0;
                tecnico.Tec_nome = "";
                cx_nome_tecnico.Text = "";
                bt_buscar_tec.Visible = false;
                //-------------------------[ESCOLHA EQUIPE TÉCNICA]-------------------------------------------------//
                //-> RECEBE DO TEXTBOX cb_TipoAtendimento.Text A OPÇÃO ESCOLHIDA PELO USUÁRIO
                string palavraTecnico = categoria.Cate_descricao;
                // É NECESSÁRIO UM ARRAY PARA RECER AS STRING QUE SERÁ EXCLUIDO DA PESQUISA
                string[] procuraTecnico = palavraTecnico.Split(new char[] { ' ', '?', '!', '.', ',', ';' });
                //CRIA UMA VÁRIAVEL LOCAL PARA SETAR A FILIAL ESCOLHIDA



                //-> CASO A PROCURA ENCONTRADO A PALAVRA "Técnico"
                if (procuraTecnico.Contains("TÉCNICO"))
                {
                    //-> EM CASO DE ACHAR A PALAVRA, É LIBERADO O COMBOBOX cb_tecnico.
                    //cb_tecnico.Enabled = true;
                    //-> cb_tecnico RECEBE AS INFORMAÇÃO DOS TÉCNICOS DE RUA JÁ CADASTRADO NO SGBD
                    //-> MUDADO PARA MOSTRAR APENAS TÉCNICOS ATIVO : 02/01/2020-MARCOS BEZERRA
                    //config_ComboBox.combox_Tecnico(cb_tecnico, cb_tecnico_ID, filial, 1); -> CANCELADO POR ERRO DE SINTAXE
                    MessageBox.Show("Por favor, selecione um técnico!");


                    frm_buscar_tecnico tec_rua = new frm_buscar_tecnico();
                    frm_buscar_tecnico.filial_statico = filial;
                    tec_rua.ShowDialog();

                    cx_nome_tecnico.Text = tecnico.Tec_nome;

                    bt_buscar_tec.Visible = true;
                    //SERÁ FOCADO A TEXTOBOX CASO ESTEJA HABILIATADA
                    //if (cb_tecnico.Enabled == true) { cb_tecnico.Focus(); }

                    //->Libera subcategoria


                }
            }
            catch
            {
                bt_buscar_tec.Visible = false;
            }
            liberar_subcategoria(categoria);
        }

        private void cb_subcategoria_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cx_obs.Text = "";
            if (cb_subcategoria_descricao.Text != "")
            {
                cx_obs.Enabled = true;
                chk_acompanhar.Enabled = true;
                chk_OS.Enabled = true;
                bt_gravar.Enabled = true;
                lbl_proximo.Visible = true;
                img_passar_atendimento.Visible = true;
            }
            else
            {
                cx_obs.Enabled = false;
                chk_acompanhar.Enabled = false;
                chk_OS.Enabled = false;
                bt_gravar.Enabled = false;
                lbl_proximo.Visible = false; ;
                img_passar_atendimento.Visible = false;

            }
            try
            {
                subcategoria.Sub_ID = ((Subcategoria_Atendimento)cb_subcategoria_descricao.SelectedItem).Sub_ID;
                cx_obs.Text = regra_atendimento.puxa_texto_subcategoria(subcategoria);
                string palavraTecnico = categoria.Cate_descricao;
                // É NECESSÁRIO UM ARRAY PARA RECER AS STRING QUE SERÁ EXCLUIDO DA PESQUISA
                string[] procuraTecnico = palavraTecnico.Split(new char[] { ' ', '?', '!', '.', ',', ';' });
                //CRIA UMA VÁRIAVEL LOCAL PARA SETAR A FILIAL ESCOLHIDA



                //-> CASO A PROCURA ENCONTRADO A PALAVRA "Técnico"
                if (procuraTecnico.Contains("TÉCNICO"))
                {
                    cx_obs.Text = "";
                    cx_obs.Text = regra_atendimento.puxa_texto_subcategoria(subcategoria) + " " + cx_nome_tecnico.Text;
                }
            }
            catch { cx_obs.Text = ""; }
        }
    }
}
