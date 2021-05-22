
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

namespace NDM_SoftwareV5.Formularios.Ordem_Servicos
{
    public partial class frm_abertura_OS_Atendimento : Form
    {




        #region Variáveis
        //Classe de comboBox
        //ComboBox
        Empresa empresa = new Empresa();
        Filial filial = new Filial();
        ComboBox_Categorias_Subcategorias cb_config_cate_sub = new ComboBox_Categorias_Subcategorias();
        ComboBox_Filial cb_config_filial                     = new ComboBox_Filial();
        //DataGridView
        DataGrid_Atendimento_OS dg_config                    = new DataGrid_Atendimento_OS();
        //Clientes ou usuários
        Cliente cliente                                      = new Cliente();
        public static RecepcaoVendedor usuario_recepcao      = new RecepcaoVendedor();
        public static HelpDesk usuario_helpDesk              = new HelpDesk();
        public static Usuario usuario                        = new Usuario();
        public static TecnicoRua usuario_tecnico             = new TecnicoRua();
        //Atendimento - Antendimento Ordem de serviço.
        Atendimento atendimento                              = new Atendimento();
        Atendimento_OS atendimentoOS                         = new Atendimento_OS();
       //Regra de Negocio externo
        RN_Atendimento_OS envia_Dados                        = new RN_Atendimento_OS();
        //iNTERNAS
        int idGrid_Em_Atendimento,
            idGrid_pendente,
            idGrid_finalizar,
            idGrid_Concluido_SemExecucao,
            idTecnico;

        #endregion
        #region Métodos Internos
        public frm_abertura_OS_Atendimento()
        {
            InitializeComponent();
        }
        private void frm_abertura_OS_Atendimento_Load(object sender, EventArgs e)
        {
            //Carrega dados no combobox provedor
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            cb_config_filial.combox_Carregado_Filial(cb_finalizar_provedor,empresa);
            

        }
        private void cb_finalizar_provedor_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
           // try { filial.Fili_ID = Convert.ToInt32(cb_finalizar_provedor_ID.Text); }
           // catch { filial.Fili_ID = 0; }
        }
        private void bt_pesquisar_finalizar_Click(object sender, EventArgs e)
        {
            if (cb_finalizar_mes.Text != "")
            {
                carrega_DataGrid_Finalizar();
            }
            else { MessageBox.Show("Selecione um mês antes de continuar!"); cb_finalizar_mes.Focus(); }
        }
        private void bt_cancelar_finalizar_Click(object sender, EventArgs e)
        {
            cx_finalizar_cod_OS.Text = "";
            cx_finalizar_cod_cliente.Text = "";
            cx_finalizar_nome_cliente.Text = "";
            cx_finalizar_helpdesk.Text = "";
            cx_finalizar_categoria.Text = "";
            cx_finalizar_subcategoria.Text = "";
            cx_finalizar_obs.Text = "";
            cx_data_aberta.Text = "";
            cx_data_fechada.Text = "";

            bt_cancelar_finalizar.Enabled = false;
            bt_finalizar_fechar.Enabled = false;
            bt_finalizar_reabrir.Enabled = false;
        }
        private void mostra_atendimento_dg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            carregaEmAtendimento_Txt(motrsa_atendimento_dg);
        }
        private void mostra_agendamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregaAgendamentos_finalizar_Txt(mostra_agendamento);
        }
        private void concluidas_dg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limpaDados_Atendimento_Concluidos_SemExecucao();
            carregaConcluidos_SemExecucao(concluidas_dg);
            limpaDados_Atendimento_Concluidos_SemExecucao();
        }
        private void pendentes_dg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregaPendentes_Txt(pendentes_dg);
        }
        private void bt_finalizar_reabrir_Click(object sender, EventArgs e)
        {
            if (idGrid_finalizar > 0)
            {

                DialogResult per_reabrir = MessageBox.Show("Reabrir O.S ?", "Atenção", MessageBoxButtons.YesNo);
                if (per_reabrir == DialogResult.Yes)
                {
                    Atendimento_OS atendi_OS = new Atendimento_OS();
                    atendi_OS.OS_ID = idGrid_finalizar;
                    atendi_OS.OS_aten_data_fechamento = DateTime.Now.Date.ToString("yyyy-MM-dd");

                    var db = envia_Dados.reabrir_OS(atendi_OS);
                    if (db == 40) { MessageBox.Show("[41]-OS Re-aberta com sucesso!"); }
                    else if (db == 41) { MessageBox.Show("[42]-Erro: Falha na alteração ao reabrir atendimento. \r\nEntre em contato com o desenvolvedor"); }

                }

                carrega_DataGrid_Finalizar();
                
            }
        }
        private void pendentes_tecnico_MouseClick(object sender, MouseEventArgs e)
        {
            if (idGrid_pendente > 0)
            {

                frm_buscar_tecnico tec_rua = new frm_buscar_tecnico();
                frm_buscar_tecnico.filial_statico = filial;
                frm_buscar_tecnico.agendamento = true;
                tec_rua.ShowDialog();

                pendentes_tecnico.Text = usuario_tecnico.Tec_nome; ;
                idTecnico = usuario_tecnico.Tec_ID;
            
                }
        }
        
        private void concluida_chk_porCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (concluida_chk_porCodigo.Checked == true)
            {
                concluida_cx_buscar_codigo.Text = "";
                concluida_cx_buscar_codigo.ReadOnly = false;
                concluida_rb_data.Checked = false;
                concluida_cx_buscar_codigo.Focus();
            }
            else
            {
                concluida_cx_buscar_codigo.Text = "";
                concluida_cx_buscar_codigo.ReadOnly = true;
            }
        }
        private void concluida_rb_data_CheckedChanged(object sender, EventArgs e)
        {
            if (concluida_rb_data.Checked == true)
            {
                concluida_data_1.Text = "";
                concluida_data_2.Text = "";
                concluida_chk_porCodigo.Checked = false;
                concluida_data_1.ReadOnly = false;
                concluida_data_2.ReadOnly = false;
            }
            else
            {
                concluida_data_1.Text = "";
                concluida_data_2.Text = "";
                concluida_data_1.ReadOnly = true;
                concluida_data_2.ReadOnly = true;
            }
        }
        //------- Ordens de serviço - Encaminhar/Baixar /Finalizar sem execução
        private void pendentes_bt_semExecucao_Click(object sender, EventArgs e)
        {
            
            frm_fechar_agendamento_OS.texto_titulo = "Baixar sem execução O.S";
            frm_fechar_agendamento_OS.text_label_data = "Concluida:";
            frm_fechar_agendamento_OS.txt_botaoFinalizar = "Fechar O.S";
            frm_fechar_agendamento_OS.condicoes_externas = 2; //->Baixar sem execução
            frm_fechar_agendamento_OS fechar_os = new frm_fechar_agendamento_OS();
            fechar_os.ShowDialog();
            carrega_DataGrid_Finalizar();
            limpaDados_Pendentes();
        
            }
        private void pendentes_bt_agendar_Click(object sender, EventArgs e)
        {
            if (pendentes_tecnico.Text != "..:: Clique aqui! ::.." && idTecnico > 0)
            {
                
                frm_fechar_agendamento_OS.texto_titulo = "Agendamento de Ordem de Seviço";
                frm_fechar_agendamento_OS.text_label_data = "Agendamento:";
                frm_fechar_agendamento_OS.txt_botaoFinalizar = "Agendar O.S";
                frm_fechar_agendamento_OS.idTecnicoAgendado = idTecnico;
                frm_fechar_agendamento_OS.condicoes_externas = 1; //->Agendamento Técnico
                frm_fechar_agendamento_OS.filial_id = filial.Fili_ID;
                frm_fechar_agendamento_OS fechar_os = new frm_fechar_agendamento_OS();
                fechar_os.ShowDialog();
                carrega_DataGrid_Finalizar();
                limpaDados_Pendentes();
                
            }
            else {
                MessageBox.Show("Erro: Você não selecionou um técnico para esse serviço.","Técnico não selecionado!");
            }
        }
        private void bt_finalizar_fechar_Click(object sender, EventArgs e)
        {
            
            frm_fechar_agendamento_OS.texto_titulo = "Conclusão de Ordem de Seviço";
            frm_fechar_agendamento_OS.text_label_data = "Atendida :";
            frm_fechar_agendamento_OS.txt_botaoFinalizar = "Baixar O.S";
            frm_fechar_agendamento_OS fechar_os = new frm_fechar_agendamento_OS();
            frm_fechar_agendamento_OS.condicoes_externas = 0; //->Baixar.
            fechar_os.ShowDialog();
            carrega_DataGrid_Finalizar();
        
            }
        private void concluida_btn_pesquisar_Click(object sender, EventArgs e)
        {
            //0 ->Aguardando atendimento / 1-> Em execução / 2-> Finalizado / 3-> Ausente /->4 Sem Execução
            var isAberto = 0;
            concluida_bt_reabrir.Visible = false;
            limpaDados_Atendimento_Concluidos_SemExecucao();
            if (concluida_rb_baixada.Checked == true)
            {
                //Finalizadas
                isAberto = 2;
            }
            else
            {
                //Finalizada sem execução
                isAberto = 4;
            }

            //Tipo de pesquisa de acordo com a seleção do usuário.
            var isPesquisaCodigo = false;
            if (concluida_chk_porCodigo.Checked == true) { isPesquisaCodigo = true; }
            if (concluida_rb_data.Checked == true) { isPesquisaCodigo = false; }
            //Pega data1 e data 2
            var data_1 = ""; var data_2 = "";
            var codOS = 0;
            if (isPesquisaCodigo == false)
            {
                try
                {
                    data_1 = Convert.ToDateTime(concluida_data_1.Text).ToString("yyyy-MM-dd");
                    data_2 = Convert.ToDateTime(concluida_data_2.Text).ToString("yyyy-MM-dd");
                }
                catch
                {
                    MessageBox.Show("Erro: Há informação incorreta na data! \r\nData modificdas para data atual do sistema.");
                    concluida_data_1.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    concluida_data_2.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    data_1 = DateTime.Now.ToString("dd/MM/yyyy");
                    data_2 = DateTime.Now.ToString("dd/MM/yyyy");

                }
            }
            else
            {
                //Recebe informação para ser em código de OS.
                try
                {
                    var txt = concluida_cx_buscar_codigo.Text.Replace(".", "");
                    txt = txt.Replace("'", "");
                    txt = txt.Replace("-", "");
                    txt = txt.Replace(",", "");
                    codOS = Convert.ToInt32(txt);
                }
                catch
                {
                    //código os irá receber zero em caso de erro da converção
                    MessageBox.Show("Erro: Código digitado não é válido!");
                    codOS = 0;

                }

            }

            //   var user_help = usuario.ID_user_DB();
            //Carrega o data GridView com a informação encontra no banco de dados.
            concluidas_dg.DataSource= dg_config.mostra_Buscar_OS_Concluida_Nao_Concluida(concluidas_dg, usuario, filial, data_1, data_2, codOS, isAberto, isPesquisaCodigo);
            limpaDados_Atendimento_Concluidos_SemExecucao();
        }
        private void concluido_bt_cancelar_Click(object sender, EventArgs e)
        {
            limpaDados_Atendimento_Concluidos_SemExecucao();
            carrega_DataGrid_Finalizar();

        }
        private void atend_bt_sem_execucao_Click(object sender, EventArgs e)
        {
            
            frm_fechar_agendamento_OS.grid_cod = idGrid_Em_Atendimento;
            frm_fechar_agendamento_OS.texto_titulo = "Baixar sem execução O.S";
            frm_fechar_agendamento_OS.text_label_data = "Concluida:";
            frm_fechar_agendamento_OS.txt_botaoFinalizar = "Fechar O.S";
            frm_fechar_agendamento_OS.condicoes_externas = 2; //->Baixar sem execução
            frm_fechar_agendamento_OS fechar_os = new frm_fechar_agendamento_OS();
            fechar_os.ShowDialog();
            carrega_DataGrid_Finalizar();
            limpaDados_Atendimento();
        
            }
        private void atend_btn_baixar_Click(object sender, EventArgs e)
        {
            
            frm_fechar_agendamento_OS.grid_cod = idGrid_Em_Atendimento;
            frm_fechar_agendamento_OS.texto_titulo = "Conclusão de Ordem de Seviço";
            frm_fechar_agendamento_OS.text_label_data = "Atendida :";
            frm_fechar_agendamento_OS.txt_botaoFinalizar = "Baixar O.S";
            frm_fechar_agendamento_OS fechar_os = new frm_fechar_agendamento_OS();
            frm_fechar_agendamento_OS.condicoes_externas = 0; //->Baixar.
            fechar_os.ShowDialog();
            carrega_DataGrid_Finalizar();
            limpaDados_Atendimento();
            
        }
        private void atendi_btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaDados_Atendimento();
        }
        private void pendentes_bt_cancelar_Click(object sender, EventArgs e)
        {
            limpaDados_Pendentes();
        }
        private void concluidas_dg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idgrid = 0;
            try
            {
                idgrid = Convert.ToInt32(concluidas_dg.SelectedCells[0].Value.ToString());
            }
            catch { idgrid = 0; }
            if (idgrid > 0) { concluida_bt_reabrir.Visible = true; }
            else { concluida_bt_reabrir.Visible = false; }
        }
        private void concluida_bt_reabrir_Click(object sender, EventArgs e)
        {
            int idgrid = 0;
            DialogResult per = MessageBox.Show("Deseja reabrir esse atendimento? ", "Atenção!",MessageBoxButtons.YesNo);
            if (per == DialogResult.Yes)
            {

                try { idgrid = Convert.ToInt32(concluidas_dg.SelectedCells[0].Value.ToString()); }
                catch { idgrid = 0; }
                var regra = new RN_Atendimento_OS();
                atendimentoOS.OS_ID = idgrid;
                atendimentoOS.OS_desc_atendimento = concluida_cx_obs.Text;
                regra.reabrir_OS(atendimentoOS);
                concluida_bt_reabrir.Visible = false;
                carrega_DataGrid_Finalizar();
            }
        }
        //---------------------------------------------------------------------
        #endregion

        #region Métodos Criados

        private void carrega_DataGrid_Finalizar()
        {

            //Comando - mês & ano
            var mes = 0;
            var ano = 0;
            var aberta_fechada = 0;
            if (usuario_helpDesk.help_ID > 0)
            {
                usuario.Usu_ID = usuario_helpDesk.Usu_ID;
            } else if (usuario_recepcao.Usu_ID > 0)
            {
                usuario.Usu_ID = usuario_recepcao.Usu_ID;
            } else
            { usuario.Usu_ID = 0; }
            //Recebem dados do comboBox mês
            var mes_escolhido = cb_finalizar_mes.Text;

            //Verifica se a consulta será com os aberta ou fechadas.
            if (rb_aberta_finalizar.Checked == true) { aberta_fechada = 1; }
            if (rb_fechada_finalizar.Checked == true) { aberta_fechada = 0; }

            // valida mês e anos
            switch (mes_escolhido)
            {
                case ("JANEIRO"):  mes = 1;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("FEVEREIRO"):mes = 2;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("MARÇO"):    mes = 3;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("ABRIL"):    mes = 4;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("MAIO"):     mes = 5;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("JUNHO"):    mes = 6;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("JULHO"):    mes = 7;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("AGOSTO"):   mes = 8;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("SETEMBRO"): mes = 9;  try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("OUTUBRO"):  mes = 10; try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("NOVEMBRO"): mes = 11; try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                case ("DEZEMBRO"): mes = 12; try { ano = Convert.ToInt32(cx_data_finalizar.Text); } catch { ano = DateTime.Now.Year; cx_data_finalizar.Text = ano.ToString(); } break;
                default:
                    MessageBox.Show("Atenção: Dados passado para data e ano atual");
                    mes = DateTime.Now.Month;
                    ano = DateTime.Now.Year;
                    cb_finalizar_mes.Focus();
                    break;
            }




            //-> Comando ADM; concluidas_dg
            mostra_agendamento.DataSource = dg_config.mostra_Agendamento_OS_Recepcao(mostra_agendamento,filial, aberta_fechada, "", mes, ano, true);
            pendentes_dg.DataSource       = dg_config.mostra_Agendamento_OS_Recepcao(pendentes_dg, filial, 1, "", mes, ano, true);
            //--> DataGrig agendamento e finalizadas.
            concluidas_dg.DataSource      = dg_config.mostra_Agendamento_App(concluidas_dg, usuario, filial, mes, ano, 2, true);
            motrsa_atendimento_dg.DataSource = dg_config.mostra_Agendamento_App(motrsa_atendimento_dg, usuario, filial,mes,ano,1,true);
            //dg_config.mostra_Agendamento_App(atendimento_dg, 0,);
            lbl_total_agendamento.Text = mostra_agendamento.RowCount.ToString();


            // }
            //else
            //{

            //    //-> por data
            //    lbl_teste_finalizar.Text = data_pesquisa_agendamento.Value.ToString("yyyy-MM-dd");
            //    var data_agedamento = lbl_teste_finalizar.Text;
            //    dg_config.mostra_Agendamento_OS_Recepcao(mostra_agendamento, filial, aberta_fechada, data_agedamento, 0, 0, false);
            //    lbl_total_agendamento.Text = mostra_agendamento.RowCount.ToString();
            //}

            //limpa caixas para inserção de novos dados
            cx_finalizar_cod_OS.Text = "";
            cx_finalizar_cod_cliente.Text = "";
            cx_finalizar_nome_cliente.Text = "";
            cx_finalizar_helpdesk.Text = "";
            cx_finalizar_categoria.Text = "";
            cx_finalizar_subcategoria.Text = "";
            cx_finalizar_obs.Text = "";
            cx_data_aberta.Text = "";
            cx_data_fechada.Text = "";

            bt_finalizar_fechar.Enabled = false;
            bt_cancelar_finalizar.Enabled = false;
            bt_finalizar_reabrir.Enabled = false;

        }
        private void carregaAgendamentos_finalizar_Txt(DataGridView dg)
        {
            idGrid_finalizar = 0;
            try
            {
                idGrid_finalizar = Convert.ToInt32(dg.SelectedCells[0].Value.ToString());
            }
            catch
            {
                idGrid_finalizar = 0;

                cx_finalizar_cod_OS.Text = "";
                cx_finalizar_cod_cliente.Text = "";
                cx_finalizar_nome_cliente.Text = "";
                cx_finalizar_helpdesk.Text = "";
                cx_finalizar_categoria.Text = "";
                cx_finalizar_subcategoria.Text = "";
                cx_finalizar_obs.Text = "";
                cx_data_aberta.Text = "";
                cx_data_fechada.Text = "";
            }

            if (idGrid_finalizar > 0)
            {
                //Variáveis internas--------//

                var grid_codigo = "";
                var grid_nome = "";
                var grid_data_abertura = "";
                var grid_num_OS = "";
                var grid_data_fechamento = "";
                var grid_categoria = "";
                var grid_subcategoria = "";
                var grid_obs = "";
                var grid_helpdesk = "";
                var grid_obs_os = "";
                //Recebe dados do Gridview.

                grid_codigo = dg.SelectedCells[1].Value.ToString();
                grid_nome = dg.SelectedCells[2].Value.ToString();
                grid_data_abertura = Convert.ToDateTime(dg.SelectedCells[3].Value).ToString("dd/MM/yyyy");
                grid_num_OS = dg.SelectedCells[4].Value.ToString();
                try
                {
                    grid_data_fechamento = Convert.ToDateTime(dg.SelectedCells[5].Value).ToString("dd/MM/yyyy");
                }
                catch { grid_data_fechamento = ""; }
                grid_categoria = dg.SelectedCells[6].Value.ToString();
                grid_subcategoria = dg.SelectedCells[7].Value.ToString();
                grid_obs = dg.SelectedCells[8].Value.ToString();
                grid_helpdesk = dg.SelectedCells[9].Value.ToString();
                grid_obs_os = dg.SelectedCells[10].Value.ToString();
                //Seta dados ao textBox.
                cx_finalizar_cod_OS.Text = grid_num_OS;
                cx_finalizar_cod_cliente.Text = grid_codigo;
                cx_finalizar_nome_cliente.Text = grid_nome;
                cx_finalizar_helpdesk.Text = grid_helpdesk;
                cx_finalizar_categoria.Text = grid_categoria;
                cx_finalizar_subcategoria.Text = grid_subcategoria;

                //Mostra texto quando o.s. não foi finalizado.
                if (grid_data_fechamento == "" || grid_data_fechamento == null) { cx_finalizar_obs.Text = grid_obs; }
                //Mostra texto quando o.s. já foi finalizado
                else if (grid_data_fechamento != "" || grid_data_fechamento != null) { cx_finalizar_obs.Text = grid_obs_os; }
                cx_data_aberta.Text = grid_data_abertura;
                cx_data_fechada.Text = grid_data_fechamento;

                if (grid_data_fechamento == "" || grid_data_fechamento == null)
                {
                    //CARREGA DADOS PARA FECHAR ATENDIMENTO.
                    
                    frm_fechar_agendamento_OS.grid_cod = idGrid_finalizar;
                    frm_fechar_agendamento_OS.grid_num_OS = grid_num_OS;
                    frm_fechar_agendamento_OS.grid_codigo = grid_codigo;
                    frm_fechar_agendamento_OS.grid_nome = grid_nome;
                    frm_fechar_agendamento_OS.grid_helpdesk = grid_helpdesk;
                    frm_fechar_agendamento_OS.grid_categoria = grid_categoria;
                    frm_fechar_agendamento_OS.grid_subcategoria = grid_subcategoria;
                    frm_fechar_agendamento_OS.grid_obs = grid_obs;
                    frm_fechar_agendamento_OS.grid_data_abertura = grid_data_abertura;
                    bt_finalizar_fechar.Enabled = true;
                    bt_finalizar_reabrir.Enabled = false;
                
    }
                else {
                    bt_finalizar_fechar.Enabled = false;
                    bt_finalizar_reabrir.Enabled = true;
                }
                bt_cancelar_finalizar.Enabled = true;
            }
            else
            {

                MessageBox.Show("Erro em carregar informações!");

                cx_finalizar_cod_OS.Text = "";
                cx_finalizar_cod_cliente.Text = "";
                cx_finalizar_nome_cliente.Text = "";
                cx_finalizar_helpdesk.Text = "";
                cx_finalizar_categoria.Text = "";
                cx_finalizar_subcategoria.Text = "";
                cx_finalizar_obs.Text = "";
                cx_data_aberta.Text = "";
                cx_data_fechada.Text = "";
            }



        }
        private void carregaPendentes_Txt(DataGridView dg) {

            try
            {
                idGrid_pendente = Convert.ToInt32(dg.SelectedCells[0].Value.ToString());
            }
            catch
            {
                idGrid_pendente = 0;

                pendentes_codOS.Text = "";
                pendentes_dtSolicitacao.Text = "";
                pendentes_codCliente.Text = "";
                pendentes_nomeCliente.Text = "";
                pendentes_nomeHelp.Text = "";
                pendentes_categoriaOS.Text = "";
                pendentes_subcategoriaOS.Text = "";
                pendentes_tecnico.Text = "..:: Clique aqui! ::..";
                pendentes_cxDescricao.Text = "";

            }

            if (idGrid_pendente > 0) {
                //Variáveis internas--------//

                var grid_codigo = "";
                var grid_nome = "";
                var grid_data_abertura = "";
                var grid_num_OS = "";
                var grid_data_fechamento = "";
                var grid_categoria = "";
                var grid_subcategoria = "";
                var grid_obs = "";
                var grid_helpdesk = "";
                var grid_obs_os = "";
                //Recebe dados do Gridview.

                grid_codigo = dg.SelectedCells[1].Value.ToString();
                grid_nome = dg.SelectedCells[2].Value.ToString();
                grid_data_abertura = Convert.ToDateTime(dg.SelectedCells[3].Value).ToString("dd/MM/yyyy");
                grid_num_OS = dg.SelectedCells[4].Value.ToString();
                try
                {
                    grid_data_fechamento = Convert.ToDateTime(dg.SelectedCells[5].Value).ToString("dd/MM/yyyy");
                }
                catch { grid_data_fechamento = ""; }
                grid_categoria = dg.SelectedCells[6].Value.ToString();
                grid_subcategoria = dg.SelectedCells[7].Value.ToString();
                grid_obs = dg.SelectedCells[8].Value.ToString();
                grid_helpdesk = dg.SelectedCells[9].Value.ToString();
                grid_obs_os = dg.SelectedCells[10].Value.ToString();
                //Limpa informações:
                pendentes_codOS.Text = "";
                pendentes_codCliente.Text = "";
                pendentes_nomeCliente.Text = "";
                pendentes_nomeHelp.Text = "";
                pendentes_categoriaOS.Text = "";
                pendentes_subcategoriaOS.Text = "";
                pendentes_cxDescricao.Text = "";
                pendentes_dtSolicitacao.Text = "";

                //Seta dados ao textBox.
                pendentes_codOS.Text = grid_num_OS;
                pendentes_codCliente.Text = grid_codigo;
                pendentes_nomeCliente.Text = grid_nome;
                pendentes_nomeHelp.Text = grid_helpdesk;
                pendentes_categoriaOS.Text = grid_categoria;
                pendentes_subcategoriaOS.Text = grid_subcategoria;

                //Carrega dados para agendamento
                //CARREGA DADOS PARA FECHAR ATENDIMENTO.
                if (idGrid_pendente != 0)
                {
                    
                    frm_fechar_agendamento_OS.grid_cod = idGrid_pendente;
                    frm_fechar_agendamento_OS.grid_num_OS = grid_num_OS;
                    frm_fechar_agendamento_OS.grid_codigo = grid_codigo;
                    frm_fechar_agendamento_OS.grid_nome = grid_nome;
                    frm_fechar_agendamento_OS.grid_helpdesk = grid_helpdesk;
                    frm_fechar_agendamento_OS.grid_categoria = grid_categoria;
                    frm_fechar_agendamento_OS.grid_subcategoria = grid_subcategoria;
                    frm_fechar_agendamento_OS.grid_obs = grid_obs;
                    frm_fechar_agendamento_OS.grid_data_abertura = grid_data_abertura;
               
    }
                //Mostra texto quando o.s. não foi finalizado.
                if (grid_data_fechamento == "" || grid_data_fechamento == null) { pendentes_cxDescricao.Text = grid_obs; }
                //Mostra texto quando o.s. já foi finalizado
                //else if (grid_data_fechamento != "" || grid_data_fechamento != null) { cx_finalizar_obs.Text = grid_obs_os; }
                pendentes_dtSolicitacao.Text = grid_data_abertura;
                //cx_data_fechada.Text = grid_data_fechamento;

                pendentes_bt_agendar.Enabled = true;
                pendentes_bt_semExecucao.Enabled = true;
                pendentes_bt_cancelar.Enabled = true;
            }
            else
            {

                MessageBox.Show("Erro em carregar informações!");

                pendentes_codOS.Text             = "";
                pendentes_codCliente.Text        = "";
                pendentes_nomeCliente.Text       = "";
                pendentes_nomeHelp.Text          = "";
                pendentes_categoriaOS.Text       = "";
                pendentes_subcategoriaOS.Text    = "";
                pendentes_cxDescricao.Text       = "";
                pendentes_dtSolicitacao.Text     = "";
                //Botões
                pendentes_bt_agendar.Enabled     = false;
                pendentes_bt_semExecucao.Enabled = false;
                pendentes_bt_cancelar.Enabled    = false;
            }
        }
        private void carregaConcluidos_SemExecucao(DataGridView dg)
        {
            idGrid_Concluido_SemExecucao = 0;
            try
            {
                idGrid_Concluido_SemExecucao = Convert.ToInt32(dg.SelectedCells[0].Value.ToString());
            }
            catch
            {
                idGrid_Concluido_SemExecucao = 0;

                concluida_cx_codOS.Text = "";
                concluida_cx_agendamento.Text = "";
                concluida_cx_finalizada.Text = "";
                concluida_cx_codCliente.Text = "";
                concluida_cx_nomeCliente.Text = "";
                concluida_cx_abertaPor.Text = "";
                concluida_cx_categoriaOS.Text = "";
                concluida_cx_subcategoriaOS.Text = "";
                concluida_cx_paraTecnico.Text = "";
                concluida_cx_laudoTecnico.Text = "";
                concluida_cx_obs.Text = "";
                concluido_bt_cancelar.Visible = false;
            }

            if (idGrid_Concluido_SemExecucao > 0)
            {

                //Variáveis internas--------//
                var grid_codigoCliente = dg.SelectedCells[1].Value.ToString();
                var grid_nomeCliente = dg.SelectedCells[2].Value.ToString();
                var grid_dataAgendamento = dg.SelectedCells[3].Value.ToString();
                var grid_helpdeskNome = dg.SelectedCells[11].Value.ToString();
                var grid_dataFechamento = dg.SelectedCells[12].Value.ToString();
                var grid_categoriaOS = dg.SelectedCells[9].Value.ToString();
                var grid_subcategoriaOS = dg.SelectedCells[10].Value.ToString();
                var grid_descriaoOS = dg.SelectedCells[15].Value.ToString();
                var grid_servicoRealizado = dg.SelectedCells[16].Value.ToString();
                var grid_tecnicoRuaNome = dg.SelectedCells[17].Value.ToString();
                var grid_codOS = dg.SelectedCells[20].Value.ToString();

                //Seta dados no textBox.
                concluida_cx_codOS.Text = grid_codOS;
                 try { concluida_cx_agendamento.Text = Convert.ToDateTime(grid_dataAgendamento).ToString("dd/MM/yyyy"); }
                 catch { concluida_cx_agendamento.Text = ""; };
                 try { concluida_cx_finalizada.Text = Convert.ToDateTime(grid_dataFechamento).ToString("dd/MM/yyyy"); }
                 catch { concluida_cx_finalizada.Text = ""; };
               
                concluida_cx_codCliente.Text = grid_codigoCliente;
                concluida_cx_nomeCliente.Text = grid_nomeCliente;
                concluida_cx_abertaPor.Text = grid_helpdeskNome;
                concluida_cx_categoriaOS.Text = grid_categoriaOS;
                concluida_cx_subcategoriaOS.Text = grid_subcategoriaOS;
                concluida_cx_paraTecnico.Text = grid_tecnicoRuaNome;
                concluida_cx_laudoTecnico.Text = grid_servicoRealizado;
                concluida_cx_obs.Text = grid_descriaoOS;
                concluido_bt_cancelar.Visible = true;
                
            }

            }

        private void cb_finalizar_provedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial.Fili_ID = ((Filial)(cb_finalizar_provedor.SelectedItem)).Fili_ID;
        }

        private void carregaEmAtendimento_Txt(DataGridView dg)
        {
            idGrid_Em_Atendimento = 0;
            try
            {
                idGrid_Em_Atendimento = Convert.ToInt32(dg.SelectedCells[0].Value.ToString());
            }
            catch
            {
                idGrid_Em_Atendimento = 0;

                pendentes_codOS.Text = "";
                pendentes_dtSolicitacao.Text = "";
                pendentes_codCliente.Text = "";
                pendentes_nomeCliente.Text = "";
                pendentes_nomeHelp.Text = "";
                pendentes_categoriaOS.Text = "";
                pendentes_subcategoriaOS.Text = "";
                pendentes_tecnico.Text = "..:: Clique aqui! ::..";
                pendentes_cxDescricao.Text = "";

            }

            if (idGrid_Em_Atendimento > 0)
            {
   

                var grid_codigoCliente = "";
                var grid_nomeCliente = "";
                var grid_data_agendamento = "";
                var grid_categoriaOS = "";
                var grid_subcategoriaOS = "";
                var grid_aberto_por = "";
                var grid_servicoRealizado = "";
                var grid_tecnico = "";
                var grid_codOS = "";
                //Recebe dados do Gridview.
                grid_codOS = dg.SelectedCells[20].Value.ToString();
                grid_codigoCliente = dg.SelectedCells[1].Value.ToString();
                grid_nomeCliente = dg.SelectedCells[2].Value.ToString();
                grid_data_agendamento = Convert.ToDateTime(dg.SelectedCells[8].Value).ToString("dd/MM/yyyy");
                grid_categoriaOS = dg.SelectedCells[9].Value.ToString();
                grid_subcategoriaOS = dg.SelectedCells[10].Value.ToString();
                grid_aberto_por = dg.SelectedCells[11].Value.ToString();
                grid_servicoRealizado = dg.SelectedCells[15].Value.ToString();
                grid_tecnico = dg.SelectedCells[17].Value.ToString();


                //Limpa informações:
                atendi_codOS.Text = "";
                atendi_agendamento_data.Text = "";
                atend_codCliente.Text = "";
                atendi_nomeCliente.Text = "";
                atendi_aberta_por.Text = "";
                atendi_categoria.Text = "";
                atendi_subCategoria.Text = "";
                atendi_para_Tecnico.Text = "";
                atendi_por_help.Text = "";
                atendi_desc.Text = "";
                //Seta dados ao textBox.
                atendi_codOS.Text = grid_codOS;
                atendi_agendamento_data.Text = grid_data_agendamento;
                atend_codCliente.Text = grid_codigoCliente;
                atendi_nomeCliente.Text = grid_nomeCliente;
                atendi_aberta_por.Text = grid_aberto_por;
                atendi_categoria.Text = grid_categoriaOS;
                atendi_subCategoria.Text = grid_subcategoriaOS;
                atendi_para_Tecnico.Text = grid_tecnico;
                atendi_por_help.Text = grid_aberto_por;
                atendi_desc.Text = grid_servicoRealizado;

                //Carrega dados para agendamento
                //CARREGA DADOS PARA FECHAR ATENDIMENTO.
                if (idGrid_Em_Atendimento != 0)
                {
                    
                    frm_fechar_agendamento_OS.grid_cod = idGrid_pendente;
                    frm_fechar_agendamento_OS.grid_num_OS = grid_codOS;
                    frm_fechar_agendamento_OS.grid_codigo = grid_codigoCliente;
                    frm_fechar_agendamento_OS.grid_nome = grid_nomeCliente;
                    frm_fechar_agendamento_OS.grid_helpdesk = grid_aberto_por;
                    frm_fechar_agendamento_OS.grid_categoria = grid_categoriaOS;
                    frm_fechar_agendamento_OS.grid_subcategoria = grid_subcategoriaOS;
                    frm_fechar_agendamento_OS.grid_obs = grid_servicoRealizado;
                    frm_fechar_agendamento_OS.grid_data_abertura = grid_data_agendamento;
                    
                }



                atend_bt_sem_execucao.Enabled = true;
                atend_btn_baixar.Enabled = true;
                atendi_btn_cancelar.Enabled = true;
                 
            }
            else
            {

                MessageBox.Show("Erro em carregar informações!");

                atendi_codOS.Text = "";
                atendi_agendamento_data.Text = "";
                atend_codCliente.Text = "";
                atendi_nomeCliente.Text = "";
                atendi_aberta_por.Text = "";
                atendi_categoria.Text = "";
                atendi_subCategoria.Text = "";
                atendi_para_Tecnico.Text = "";
                atendi_por_help.Text = "";
                atendi_desc.Text = "";
                //Botões
                atend_bt_sem_execucao.Enabled = false;
                atend_btn_baixar.Enabled = false;
                atendi_btn_cancelar.Enabled = false;
            }
          
        }
        private void limpaDados_Pendentes() {

            idTecnico = 0;
            idGrid_pendente = 0;
            pendentes_codOS.Text = "";
            pendentes_codCliente.Text = "";
            pendentes_nomeCliente.Text = "";
            pendentes_nomeHelp.Text = "";
            pendentes_categoriaOS.Text = "";
            pendentes_subcategoriaOS.Text = "";
            pendentes_cxDescricao.Text = "";
            pendentes_dtSolicitacao.Text = "";
            pendentes_tecnico.Text = "..:: Clique aqui! ::..";
            //Botões
            pendentes_bt_agendar.Enabled = false;
            pendentes_bt_semExecucao.Enabled = false;
            pendentes_bt_cancelar.Enabled = false;

        }
        private void limpaDados_Atendimento() {

            idGrid_Em_Atendimento = 0;
            atendi_codOS.Text = "";
            atendi_agendamento_data.Text = "";
            atend_codCliente.Text = "";
            atendi_nomeCliente.Text = "";
            atendi_aberta_por.Text = "";
            atendi_categoria.Text = "";
            atendi_subCategoria.Text = "";
            atendi_para_Tecnico.Text = "";
            atendi_por_help.Text = "";
            atendi_desc.Text = "";
            //Botões
            atend_bt_sem_execucao.Enabled = false;
            atend_btn_baixar.Enabled = false;
            atendi_btn_cancelar.Enabled = false;
        }
        private void limpaDados_Atendimento_Concluidos_SemExecucao()
        {
            idGrid_Concluido_SemExecucao = 0;
            concluida_cx_codOS.Text = "";
            concluida_cx_agendamento.Text = "";
            concluida_cx_finalizada.Text = "";
            concluida_cx_codCliente.Text = "";
            concluida_cx_nomeCliente.Text = "";
            concluida_cx_abertaPor.Text = "";
            concluida_cx_categoriaOS.Text = "";
            concluida_cx_subcategoriaOS.Text = "";
            concluida_cx_paraTecnico.Text = "";
            concluida_cx_laudoTecnico.Text = "";
            concluida_cx_obs.Text = "";
            //Botões
            concluido_bt_cancelar.Visible = false;
        }

        #endregion


    }
}
