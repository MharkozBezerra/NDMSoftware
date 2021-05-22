
using NDM_SoftwareV5.Formularios.Ordem_Servicos;
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
using Controlador.Controle.ComboBox_Config;
using Controlador.Controle.DataGrid_Config.DataGrid_Atendimento;
using Modelo.Classes;
using NDM_SoftwareV5.Formularios.F_Cliente;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Recepcao
{
    public partial class frm_index_solicitacao : Form
    {

        #region Variáveis

        // 0 = Solicitação | 1 = Clientes | 2 = O.S. | 3 = Equipe HelpDesk               
        bool opcao_Solicitacao,opcao_Cliente,opcao_OS, opcao_EquipeHelpDesk;
        int idGrid;
        private Cliente cliente = new Cliente();
        private Atendimento atendimento = new Atendimento();
        private Filial filial = new Filial();
        private Categoria_Atendimento categoria = new Categoria_Atendimento();
        private Subcategoria_Atendimento subcategoria = new Subcategoria_Atendimento();
        private HelpDesk helpdesk = new HelpDesk();
        private ComboBox_Filial   cb_config_filial = new ComboBox_Filial();
        private ComboBox_Usuarios cb_config_user   = new ComboBox_Usuarios();
        private ComboBox_Categorias_Subcategorias cb_config_cate_sub = new ComboBox_Categorias_Subcategorias();
        private DataGrid_Atendimento dg_config = new DataGrid_Atendimento();
        private Empresa empresa = new Empresa();
        public static RecepcaoVendedor recepcao_statica = new RecepcaoVendedor();
        private RN_Atendimento regra_atendimento = new RN_Atendimento();
        public static string recepcao_sexo;

        string codCliente_Grid, nomeCliente_Grid, tec_help_Grid;
        bool excluirSolicitacao = false;
        bool opcaoGrande = false;
        public static bool acesso_adm = false;


            #endregion

        #region Metodos Criados
        void cancelar_Solicitacao() {

            // MOSTRA AO USUÁRIO
            //Limpa comboBox - DataSource
            cb_provedor.DataSource              = null;
            cb_categoria.DataSource       = null;
            cb_tecnico.DataSource               = null;
            cb_subcategoria.DataSource  = null;
            //Limpa comboBox - Items.Clear
            cb_provedor.Items.Clear();
            cb_categoria.Items.Clear();
            cb_tecnico.Items.Clear();
            cb_subcategoria.Items.Clear();
            //Limpa comboBox - Text
            cb_provedor.Text             = "";
            cb_categoria.Text      = "";
            cb_tecnico.Text              = "";
            cb_subcategoria.Text = "";
            //LIMPA TEXTE
            cx_dataHora.Text    = "";
            cx_codCliente.Text  = "";
            cx_nomeCliente.Text = "";
            cx_obs.Text         = "";
            cx_dataHora.Text    = "";
            // OCULTO DO USUÁRIO
            //Limpa comboBox - DataSource
            //cb_provedor_ID.DataSource             = null;
           // cb_categoria_ID.DataSource      = null;
            //cb_tecnico_ID.DataSource              = null;
           // cb_subcategoria_ID.DataSource = null;
            //Limpa comboBox - Items.Clear
            //cb_provedor_ID.Items.Clear();
           // cb_categoria_ID.Items.Clear();
           // cb_tecnico_ID.Items.Clear();
           // cb_subcategoria.Items.Clear();
            //Limpa comboBox - Text
           // cb_provedor_ID.Text             = "";
           // cb_categoria_ID.Text      = "";
           // cb_tecnico_ID.Text              = "";
           // cb_subcategoria_ID.Text = "";

            //Desabilita toda inserção de dados
            cb_provedor.Enabled             = false;
            cb_subcategoria.Enabled = false;
            cb_tecnico.Enabled              = false;
            cb_subcategoria.Enabled = false;
            cx_dataHora.Enabled             = false;
            cx_codCliente.Enabled           = false;
            cx_nomeCliente.Enabled          = false;
            cx_obs.Enabled                  = false;

            rb_alta.Checked                 = false;
            rb_media.Checked                = false;
            rb_baixo.Checked                = false;

            rb_alta.Enabled                 = false;
            rb_media.Enabled                = false;
            rb_baixo.Enabled                = false;
            img_solicitacoes.Enabled = true;
        }
        void enviar_Solicitacao() {
            /*
           * ESSE EVENTO IRÁ FICAR RESPOSÁVEL POR SALVAR AS INFORMAÇÃO DO CLIENTE PARA O SERVIDOR.
           * REGRAS:
           * ATENDIMENTO SÓ PODERÁ SER SALVO CASO SEJA SOLICITAÇÃO, CASO CONTRARIO DEVE SER FINALIZADO O PROCEDIMENTO SEM SALVAR.
           * APÓS VALIDAR DADOS TODAS INFORMAÇÕES DEVEM SER APAGADAS.
           * O DATAGRIDVIEW RESPONSÁVEL POR MOSTRAR ANDAMENTO DE ATENDIMENTO DEVE SER ATUALIZADO.
           * 
           */
            
            string obs              = ""; // RESPONSÁVEL POR SETAR AS INFORMAÇÕES SETADAS NO TEXTBOX OBSERVAÇÃO.
            int grau_Prioridade     = 0;  // RESPONSÁVEL POR SETAR O GRAU DO ATENDIMENTO {0 = BAIXA | 1 = MÉDIA | 2 = ALTA | 3 = URGENTE }
            
            try
            {

                obs = cx_obs.Text;

                //Recebe prioridade.
                if (rb_baixo.Checked == true) { grau_Prioridade = 0; }
                else if (rb_media.Checked == true) { grau_Prioridade = 1; }
                else if (rb_alta.Checked == true) { grau_Prioridade = 2; }

                //Realiza o salvamento
                //Define o atendimento.
                atendimento.categoria             = categoria;
                atendimento.subcategoria          = subcategoria;
                atendimento.helpdesk              = helpdesk;
                atendimento.recepcao              = recepcao_statica;
                atendimento.cliente               = cliente;
                atendimento.prioridade_FK         = grau_Prioridade;
                atendimento.Atend_descricao       = obs;
                atendimento.Atend_data_solicitado = DateTime.Now.ToString("yyyy-MM-dd");
                atendimento.Atend_data            = null;
                atendimento.Atend_hora            = DateTime.Now.ToString("HH:mm:ss");
                atendimento.Fili_ID               = filial.Fili_ID;
                regra_atendimento.solicitar_atendimento_helpdesk(atendimento);

                //Atualiza Grids
                var hoje = DateTime.Now.Date.ToString("yyyy-MM-dd");
                mostra_solicitacao.DataSource         = dg_config.mostra_Solicitacao_Recepcao(mostra_solicitacao, filial, recepcao_statica, hoje, 0);
                lbl_atendimento_solicitado.Text       = mostra_solicitacao.RowCount.ToString();
                mostraSolicitacaoAtendidas.DataSource = dg_config.mostra_Solicitacao_Recepcao(mostraSolicitacaoAtendidas, filial, recepcao_statica, hoje, 1);
                lbl_qtd_acompanhar.Text               = mostraSolicitacaoAtendidas.RowCount.ToString();


               

                //Cancela todas opções aberta
                cancelar_Solicitacao();

            }
            catch { MessageBox.Show("Erro : Comunique o desenvolvedor"); return; }
            lbl_atendimento_solicitado.Text = mostra_solicitacao.RowCount.ToString();
            
        }
        void carregaSolicitacoesFinalizadas_Txt(DataGridView dg) {

            //Variáveis internas--------//

            var grid_codigo = "";
            var grid_nome = "";
            var grid_nome_Tecnico = "";
            var grid_data_solicitacao = "";
            var grid_obs = "";
            var grid_hora = "";
            var grid_categoria = "";
            var grid_subcategoria = "";
            
            //Recebe dados do Gridview.
            grid_codigo            = dg.SelectedCells[1].Value.ToString();
            grid_nome              = dg.SelectedCells[2].Value.ToString();
            grid_categoria         = dg.SelectedCells[3].Value.ToString();
            grid_subcategoria      = dg.SelectedCells[4].Value.ToString();
            grid_nome_Tecnico      = dg.SelectedCells[9].Value.ToString();
            grid_data_solicitacao  = Convert.ToDateTime (dg.SelectedCells[7].Value).ToString("dd/MM/yyyy");
            grid_obs               = dg.SelectedCells[11].Value.ToString();
            grid_hora              = dg.SelectedCells[8].Value.ToString();
            //Seta dados ao textBox.
            cx_ac_data.Text = grid_data_solicitacao + grid_hora;
            cx_ac_provedor.Text = filial.Fili_descricao;
            cx_ac_solictado.Text = grid_nome_Tecnico;
            cx_ac_codCliente.Text = grid_codigo;
            cx_ac_nomeCliente.Text = grid_nome;
            cx_ac_obs.Text = grid_obs;
            cx_categoria.Text = grid_categoria;
            cx_Subcategoria.Text = grid_subcategoria;
            
        }
        void carregaAgendamentos_Txt(DataGridView dg)
        {
           

        }
        void carrega_DataGrid_Agendamento(string hoje) {

            mostra_solicitacao.DataSource = dg_config.mostra_Solicitacao_Recepcao(mostra_solicitacao, filial, recepcao_statica, hoje, 0);
            lbl_atendimento_solicitado.Text = mostra_solicitacao.RowCount.ToString();
            mostraSolicitacaoAtendidas.DataSource = dg_config.mostra_Solicitacao_Recepcao(mostraSolicitacaoAtendidas, filial, recepcao_statica, hoje, 1);
            lbl_qtd_acompanhar.Text = mostraSolicitacaoAtendidas.RowCount.ToString();

        }
        #endregion

        #region Métodos Internos

        //------------------- Eventos textbox cx_cod_cliente -----------------//
        private void cx_codCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!cx_codCliente.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }
        private void cx_codCliente_Leave(object sender, EventArgs e)
        {
            //-----------Aceita apenas número
            if (cx_codCliente.Text != "")
            {
                try { cx_codCliente.Text = Convert.ToInt32(cx_codCliente.Text).ToString(); }
                catch (Exception er)
                {
                    MessageBox.Show("Atenção : Esse campo só aceita adição númericas de 0 a 9.\n" + er.Message);
                    cx_codCliente.Text = 0.ToString();
                }
            }
            else { cx_codCliente.Text = 0.ToString(); }
            //---------------------------------------------
            //------------Puxa nome-----------------------------------//
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
                        //filial.Fili_ID = Convert.ToInt32(cb_provedor_ID.Text);
                        liberar_categoria(true, filial);
                    }
                    else
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

                            //Rete a ação.
                            if (regra_atendimento.validar_cliente(cliente) == true)
                            {
                                cx_nomeCliente.Text = "";
                                cliente = regra_atendimento.puxar_cliente(cliente);
                                cx_nomeCliente.Text = cliente.Clie_nome;
                                //filial.Fili_ID = Convert.ToInt32(cb_provedor_ID.Text);
                                liberar_categoria(true, filial);
                            }
                        }
                        else
                        {
                            cx_nomeCliente.Text = "";
                            cliente.Clie_nome = null;
                            cliente.Clie_ID = 0;
                            img_clientes.Visible = true;
                            lbl_clientes.Visible = true;
                            liberar_categoria(false, filial);

                        }

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
        private void cx_codCliente_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= cx_codCliente.Text.Length - 1; i++)
            {
                if ((cx_codCliente.Text[i] >= '0' &&
                    cx_codCliente.Text[i] <= '9') ||
                    cx_codCliente.Text[i] == ',')
                {
                    x += cx_codCliente.Text[i];
                }
            }
            cx_codCliente.Text = x;
            cx_codCliente.SelectAll();
        }
        private void cx_codCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int filial_ID = 0;

                if (cx_nomeCliente.TextLength >= 2 && cx_codCliente.TextLength >= 1)
                {
                    /*
                     * USUÁRIO DEVE INFORMAR O CÓDIGO DO CLIENTE:
                     * CASO O CÓDIGO SEJA VÁLIDO É RETORNADO O NOME DO CLIENTE.
                     * É LIBERADO AS DEMAIS FUNÇÕES PARA SER PREENCHIDO NESSA ORDEM
                     * 1º É LIBERADO O COMBOBOX cb_TipoAtendimento
                     * NESSE CASO É VERIFICADO SE  O ATENDIMENTO SERÁ DO TIPO TÉCNICO OU DE CLIENTE.
                     * EM CASO DE TÉCNICO O COMBOBOX cb_tecnico É LIBERADO E CARREGADO COM AS INFORMAÇÕES VINDA DO SGBD MySQL.
                     * EM CASO DE CLIENTE O COMBOBOX cb_tecnico CONTINUA  DESABILITADO.
                     * 2º É  LIBERADO O COMBOBOX cb_atendimentoRealizado PARA SER INFORMADO QUAL SERÁ A SUB CATEGORIA DO ATENDIMENTO.
                     * NESSE TEMPO O TEXTBOX cx_obs JÁ DEVE ESTAR LIBERADO.
                     * COM TODOS OS DADOS INSERIDOS CORRETAMENTE O ATENDIMENTO PODE SER SALVO E TODOS CAMPOS PODERÁ SER RETORNADOS AO
                     * SEUS VALORES PADRÃO
                     * //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                     * CASO O CÓDIGO NÃO SEJA VÁLIDO O TEXTBOX cx_nomeCliente É LIBERADO PARA CADASTRAR UM NOVO CLIENTE.
                     * É LIBERADO AS DEMAIS FUNÇÕES PARA SER PREENCHIDO NESSA ORDEM
                     * 1º O TEXTBOX cx_nomeCliente PARA SER PREENCHICO COM O NOME DO CLIENTE
                     * 2º O COMBOBOX cb_TipoAtendimento PARA SER SETADO O TIPO DE ATENDIMENTO QUE SERÁ REALIZADO.
                     * NESSE CASO É VERIFICADO SE  O ATENDIMENTO SERÁ DO TIPO TÉCNICO OU DE CLIENTE.
                     * EM CASO DE TÉCNICO O COMBOBOX cb_tecnico É LIBERADO E CARREGADO COM AS INFORMAÇÕES VINDA DO SGBD MySQL.
                     * EM CASO DE CLIENTE O COMBOBOX cb_tecnico CONTINUA  DESABILITADO.
                     * 3º É  LIBERADO O COMBOBOX cb_atendimentoRealizado PARA SER INFORMADO QUAL SERÁ A SUB CATEGORIA DO ATENDIMENTO.
                     * NESSE TEMPO O TEXTBOX cx_obs JÁ DEVE ESTAR LIBERADO.
                     * COM TODOS OS DADOS INSERIDOS CORRETAMENTE O ATENDIMENTO PODE SER SALVO E TODOS CAMPOS PODERÁ SER RETORNADOS AO
                     * SEUS VALORES PADRÃO
                     */
                    try { filial_ID = filial.Fili_ID; }
                    catch { filial_ID = 0; }
                    //cb_config.combox_Categoria_Atendimento(cb_TipoAtendimento, cb_TipoAtendimento_ID, filial_ID);
                    cx_obs.Enabled = true;

                }
                else
                {

                    cb_categoria.Enabled = false;
                    cb_categoria.DataSource = null;
                    cb_categoria.DropDownStyle = ComboBoxStyle.Simple;
                    cb_categoria.Text = "";
                    cb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb_categoria.Text = "";
                    //ID
                    //cb_categoria_ID.Enabled = false;
                    //cb_categoria_ID.DataSource = null;
                    //cb_categoria_ID.DropDownStyle = ComboBoxStyle.Simple;
                    //cb_categoria_ID.Text = "";
                    //cb_categoria_ID.DropDownStyle = ComboBoxStyle.DropDownList;

                    // ATENDIMENTO REALIZADO - SUB CATEGORIA
                    cb_subcategoria.Enabled = false;
                    cb_subcategoria.DataSource = null;
                    cb_subcategoria.DropDownStyle = ComboBoxStyle.Simple;
                    cb_subcategoria.Text = "";
                    cb_subcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb_subcategoria.Text = "";
                    //ID
                    //cb_subcategoria_ID.Enabled = false;
                    //cb_subcategoria_ID.DataSource = null;
                    //cb_subcategoria_ID.DropDownStyle = ComboBoxStyle.Simple;
                    //cb_subcategoria_ID.Text = "";
                    //cb_subcategoria_ID.DropDownStyle = ComboBoxStyle.DropDownList;

                  
                    cx_obs.Enabled = false;
                    cx_obs.Text = "";
                }
            }
        }
        // ---------------- Evento textebox cx_clienteNome ------------------//

        //---------------- Evento Mudança na pictureBox --------------------//
        #region Evento Mudança na pictureBox
        private void img_clientes_MouseEnter(object sender, EventArgs e)
        {
            img_clientes.Image = Properties.Resources.Cliente_Cor;

        }
        private void img_clientes_MouseLeave(object sender, EventArgs e)
        {
            if (opcao_Cliente == false)
            {
                img_clientes.Image = Properties.Resources.Cliente_SCor;
            }
        }
        private void img_helpdesk_inf_MouseEnter(object sender, EventArgs e)
        {
            img_helpdesk_inf.Image = Properties.Resources.HelpDesk_Cor;
        }
        private void img_helpdesk_inf_MouseLeave(object sender, EventArgs e)
        {
            if (opcao_EquipeHelpDesk == false)
            {
                img_helpdesk_inf.Image = Properties.Resources.HelpDesk_SCor;
            }
            else { img_helpdesk_inf.Image = Properties.Resources.HelpDesk_Cor; }
        }
        private void img_solicitacoes_MouseEnter(object sender, EventArgs e)
        {
            //AO PASSAR  O MOUSE
            if (opcao_Solicitacao == false)
            {
                img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_Cor;
            }
        }
        private void img_solicitacoes_MouseLeave(object sender, EventArgs e)
        {
            if (opcao_Solicitacao == false)
            {
                //AO SAIR O MOUSE.
                img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_SCor;
            }
        }
        private void img_os_MouseEnter(object sender, EventArgs e)
        {
            img_os.Image = Properties.Resources.reparar_1_;
        }
        private void img_os_MouseLeave(object sender, EventArgs e)
        {
            if (opcao_OS == false)
            {
                img_os.Image = Properties.Resources.reparar;
            }

        }
        #endregion
        //---------------- Evento Click --------------------//
        #region Evento Click


        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            cancelar_Solicitacao();
            opcao_Solicitacao = false;
            img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_SCor;
            bt_cancelar.Enabled = false;
            bt_finalizar.Enabled = false;
            lbl_atendimento_solicitado.Text = mostra_solicitacao.RowCount.ToString();
        }
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            int filial_ID = 0;
            try { filial_ID = filial.Fili_ID; }
            catch
            {
                MessageBox.Show("Provedor não informado");
                filial_ID = 0;
            }

            if (idGrid > 0 && excluirSolicitacao == true && filial_ID > 0)
            {

                //Atendimento atendimento = new Atendimento();
                try
                {


                    //atendimento.deletar_Solicitacao_Atendimento(idGrid);
                    bt_excluir.Enabled = false;

                    excluirSolicitacao = false;
                    var hoje = DateTime.Now.Date.ToString("yyyy-MM-dd");
                  //  dg_config.mostra_Solicitacao_Sem_Realizar(mostra_solicitacao, filial_ID, usuario.ID_user_DB(), hoje);

                    var msgLog = "Usuário {" + 1 /*usuario.NomeCompleto_DB()*/ + "} excluiu a solicitação de atendimento de nº: " + idGrid + " para o cliente " + codCliente_Grid + " - " + nomeCliente_Grid + "  do provedor:{ " + cb_tecnico.Text + " } que estava para o técnico HelpDesk: " + tec_help_Grid + "."; //-> Carrega mensagem para o novo log
                    cb_provedor.Enabled = true;                                           //-> Habilita a comboBox cb_provedor
                    bt_cancelar.Enabled = true;                                           //-> Habilita Botão Cancelar
                   // envia_Dados.Envia_LOGS_DB(3, msgLog, usuario.ID_user_DB());
                    idGrid = 0;

                }
                catch { }
            }
            else
            {
                MessageBox.Show("Solicitação não pode ser excluida.");
            }
        }
        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            enviar_Solicitacao();
            opcao_Solicitacao = false;
            img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_SCor;
            bt_cancelar.Enabled = false;
            bt_finalizar.Enabled = false;
        }
        private void bt_pesquisar_agendamento_OS_Click(object sender, EventArgs e)
        {
            string data = data_pesquisa.Value.ToString("yyyy-MM-dd");
            carrega_DataGrid_Agendamento(data);
        }

        private void img_buscar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbl_teste.Text = data_pesquisa.Value.ToString("yyyy-MM-dd");
                //var data_pesquisa = lbl_teste.Text;
                mostraSolicitacaoAtendidas.DataSource = dg_config.mostra_Solicitacao_Recepcao(mostraSolicitacaoAtendidas, filial, recepcao_statica, lbl_teste.Text, 1);
                lbl_qtd_acompanhar.Text = mostraSolicitacaoAtendidas.RowCount.ToString();

            }
            catch { return; }
        }
        private void img_clientes_MouseClick(object sender, MouseEventArgs e)
        {
            opcao_Cliente = true;

            img_clientes.Image = Properties.Resources.Cliente_Cor;              //-> Altera a  imagens do pictureBox
            img_clientes.Enabled = false;                                          //-> Mantem a pictureBox em estado desativado
                                                                                   // lbl_cliente.Visible = true;                                           //-> Labael lbl_novo_atendimento fica com estado visível
                                                                                   // lbl_cliente.Text = "->Cliente.";              //-> Labael lbl_novo_atendimento fica com estado visível
            var msgLog = "Usuário {" + 1/*usuario.NomeCompleto_DB()*/ + "} acessou a opção:{ Cliente }"; //-> Carrega mensagem para o novo log
            cb_provedor.Enabled = true;                                           //-> Habilita a comboBox cb_provedor
            bt_cancelar.Enabled = true;                                           //-> Habilita Botão Cancelar
           // envia_Dados.Envia_LOGS_DB(2, msgLog, usuario.ID_user_DB());                       //-> Salva o Log no banco de dados

          frm_pesquisa_cliente cliente = new frm_pesquisa_cliente();
          cliente.ShowDialog();

            img_clientes.Image = Properties.Resources.Cliente_SCor;                //-> Altera a  imagens do pictureBox
            img_clientes.Enabled = true;                                           //-> Mantem a pictureBox em estado desativado
                                                                                   //  lbl_cliente.Visible = false;                                           //-> Labael lbl_novo_atendimento fica com estado visível
                                                                                   //  lbl_cliente.Text = "Cliente.";                                         //-> Labael lbl_novo_atendimento fica com estado visível
            opcao_Cliente = false;
        }
        private void img_helpdesk_inf_MouseClick(object sender, MouseEventArgs e)
        {
            opcao_EquipeHelpDesk = true;

            img_helpdesk_inf.Image = Properties.Resources.HelpDesk_Cor;              //-> Altera a  imagens do pictureBox
            img_helpdesk_inf.Enabled = false;                                          //-> Mantem a pictureBox em estado desativado
                                                                                   // lbl_cliente.Visible = true;                                           //-> Labael lbl_novo_atendimento fica com estado visível
                                                                                   // lbl_cliente.Text = "->Cliente.";              //-> Labael lbl_novo_atendimento fica com estado visível
            var msgLog = "Usuário {" + 1/*usuario.NomeCompleto_DB()*/ + "} acessou a opção:{ Informações-HelpDesk }"; //-> Carrega mensagem para o novo log
                                          //-> Habilita Botão Cancelar
           // envia_Dados.Envia_LOGS_DB(2, msgLog, usuario.ID_user_DB());                       //-> Salva o Log no banco de dados

            //frm_info_helpdesk helpDesk = new frm_info_helpdesk();
           // helpDesk.ShowDialog();

            img_helpdesk_inf.Image = Properties.Resources.HelpDesk_SCor;                 //-> Altera a  imagens do pictureBox
            img_helpdesk_inf.Enabled = true;                                           //-> Mantem a pictureBox em estado desativado
                                                                                   //  lbl_cliente.Visible = false;                                           //-> Labael lbl_novo_atendimento fica com estado visível
                                                                                   //  lbl_cliente.Text = "Cliente.";                                         //-> Labael lbl_novo_atendimento fica com estado visível
            opcao_EquipeHelpDesk = false;
        }
        private void img_os_MouseClick(object sender, MouseEventArgs e)
        {

            opcao_Solicitacao = false;
            opcao_Cliente = false;
            opcao_OS = true;
            img_os.Image = Properties.Resources.reparar_1_;                                   //-> Altera a  imagens do pictureBox para colorido
            img_os.Enabled = false;                                                           //-> Mantem a pictureBox em estado desativado
            var msgLog = "Usuário {" + /*usuario.NomeCompleto_DB() */1+ "} acessou a opção:{ Ordem de Serviço }"; //-> Carrega mensagem para o novo log
            //envia_Dados.Envia_LOGS_DB(2, msgLog, usuario.ID_user_DB());                       //-> Salva o Log no banco de dados
            frm_abertura_OS_Atendimento abertura_os = new frm_abertura_OS_Atendimento();      //-> Cria Objeto do formulário
            abertura_os.ShowDialog();                                                         //-> Abre o fomulário como objeto statico e sem alterações no fundo.

            opcao_OS = false;                                                                //-> Seta Opção O.Serviço como Falso.                                                      
            img_os.Image = Properties.Resources.reparar;                                      //-> Altera a  imagens do pictureBox para branco e preto
            img_os.Enabled = true;
        }
        private void img_solicitacoes_MouseClick(object sender, MouseEventArgs e)
        {
            /*
             * AQUI SERÁ SETADO AS SEGUINTES FUNÇÕES:
             * SE opcao_Solicitacao = FALSE IRÁ RECEBER TRUE
             * IRÁ CHAMAR DADOS PARA O COMBOBOX PROVEDOR E PROVEDOR ID
             * IRÁ PUXA DADOS DO DATAGRID COM DATA ATUAL DO COMPUTADOR/ E PROVEDOR ESCOLHIDO.
             * 
             */

            cb_config_filial.combox_Carregado_Filial(cb_provedor, empresa);
            
            if (opcao_Solicitacao == false) { opcao_Solicitacao = true; }
            try
            {
                
                var hoje = DateTime.Now.Date.ToString("yyyy-MM-dd");
                mostra_solicitacao.DataSource= dg_config.mostra_Solicitacao_Recepcao(mostra_solicitacao, filial, recepcao_statica, hoje,0);
                lbl_atendimento_solicitado.Text = mostra_solicitacao.RowCount.ToString();
                mostraSolicitacaoAtendidas.DataSource = dg_config.mostra_Solicitacao_Recepcao(mostraSolicitacaoAtendidas, filial, recepcao_statica, hoje,1);
                lbl_qtd_acompanhar.Text = mostraSolicitacaoAtendidas.RowCount.ToString();

                cb_provedor.Enabled = true;
                cx_codCliente.Enabled = true;
               
                cx_dataHora.Text = Convert.ToDateTime(hoje).ToString("dd/MM/yyyy");
                opcao_Solicitacao = true;
                img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_Cor;
                bt_cancelar.Enabled = true;
                rb_baixo.Checked = true;

                rb_alta.Enabled = true;
                rb_media.Enabled = true;
                rb_baixo.Enabled = true;
                img_solicitacoes.Enabled = false;

            }
            catch { MessageBox.Show("Erro: Tente novamente!"); }
        }

        private void mostraSolicitacaoAtendidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid_I = 0;
            try
            {
                grid_I = Convert.ToInt32(mostraSolicitacaoAtendidas.SelectedCells[0].Value);
                if (grid_I > 0)
                {
                    carregaSolicitacoesFinalizadas_Txt(mostraSolicitacaoAtendidas);
                }
                else
                {
                    MessageBox.Show("Opção invalida!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                cx_ac_data.Text = "";
                cx_ac_provedor.Text = "";
                cx_ac_solictado.Text = "";
                cx_ac_codCliente.Text = "";
                cx_ac_nomeCliente.Text = "";
                cx_ac_obs.Text = "";
                cx_categoria.Text = "";
                cx_Subcategoria.Text = "";
            }
        }
        private void mostra_agendamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        #endregion


        private void cx_nomeCliente_TextChanged(object sender, EventArgs e)
        {
            int filial_ID = 0;

            if (cx_nomeCliente.TextLength >= 2 && cx_codCliente.TextLength >= 1)
            {
                /*
                 * USUÁRIO DEVE INFORMAR O CÓDIGO DO CLIENTE:
                 * CASO O CÓDIGO SEJA VÁLIDO É RETORNADO O NOME DO CLIENTE.
                 * É LIBERADO AS DEMAIS FUNÇÕES PARA SER PREENCHIDO NESSA ORDEM
                 * 1º É LIBERADO O COMBOBOX cb_TipoAtendimento
                 * NESSE CASO É VERIFICADO SE  O ATENDIMENTO SERÁ DO TIPO TÉCNICO OU DE CLIENTE.
                 * EM CASO DE TÉCNICO O COMBOBOX cb_tecnico É LIBERADO E CARREGADO COM AS INFORMAÇÕES VINDA DO SGBD MySQL.
                 * EM CASO DE CLIENTE O COMBOBOX cb_tecnico CONTINUA  DESABILITADO.
                 * 2º É  LIBERADO O COMBOBOX cb_atendimentoRealizado PARA SER INFORMADO QUAL SERÁ A SUB CATEGORIA DO ATENDIMENTO.
                 * NESSE TEMPO O TEXTBOX cx_obs JÁ DEVE ESTAR LIBERADO.
                 * COM TODOS OS DADOS INSERIDOS CORRETAMENTE O ATENDIMENTO PODE SER SALVO E TODOS CAMPOS PODERÁ SER RETORNADOS AO
                 * SEUS VALORES PADRÃO
                 * //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                 * CASO O CÓDIGO NÃO SEJA VÁLIDO O TEXTBOX cx_nomeCliente É LIBERADO PARA CADASTRAR UM NOVO CLIENTE.
                 * É LIBERADO AS DEMAIS FUNÇÕES PARA SER PREENCHIDO NESSA ORDEM
                 * 1º O TEXTBOX cx_nomeCliente PARA SER PREENCHICO COM O NOME DO CLIENTE
                 * 2º O COMBOBOX cb_TipoAtendimento PARA SER SETADO O TIPO DE ATENDIMENTO QUE SERÁ REALIZADO.
                 * NESSE CASO É VERIFICADO SE  O ATENDIMENTO SERÁ DO TIPO TÉCNICO OU DE CLIENTE.
                 * EM CASO DE TÉCNICO O COMBOBOX cb_tecnico É LIBERADO E CARREGADO COM AS INFORMAÇÕES VINDA DO SGBD MySQL.
                 * EM CASO DE CLIENTE O COMBOBOX cb_tecnico CONTINUA  DESABILITADO.
                 * 3º É  LIBERADO O COMBOBOX cb_atendimentoRealizado PARA SER INFORMADO QUAL SERÁ A SUB CATEGORIA DO ATENDIMENTO.
                 * NESSE TEMPO O TEXTBOX cx_obs JÁ DEVE ESTAR LIBERADO.
                 * COM TODOS OS DADOS INSERIDOS CORRETAMENTE O ATENDIMENTO PODE SER SALVO E TODOS CAMPOS PODERÁ SER RETORNADOS AO
                 * SEUS VALORES PADRÃO
                 */
                try { filial_ID = filial.Fili_ID; }
                catch { filial_ID = 0; }
                //cb_config.combox_Categoria_Atendimento(cb_TipoAtendimento, cb_TipoAtendimento_ID, filial_ID);
                cb_categoria.Enabled = true;
                cx_obs.Enabled = true;
            }
            else
            {
                // TIPO ATENDIMENTO - CATEGORIA
                cb_categoria.Enabled = false;
                cb_categoria.DataSource = null;
                cb_categoria.DropDownStyle = ComboBoxStyle.Simple;
                cb_categoria.Text = "";
                cb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_categoria.Text = "";
                //ID
                //cb_categoria_ID.Enabled = false;
               // cb_categoria_ID.DataSource = null;
                //cb_categoria_ID.DropDownStyle = ComboBoxStyle.Simple;
                //cb_categoria_ID.Text = "";
               // cb_categoria_ID.DropDownStyle = ComboBoxStyle.DropDownList;

                // ATENDIMENTO REALIZADO - SUB CATEGORIA
                cb_subcategoria.Enabled = false;
                cb_subcategoria.DataSource = null;
                cb_subcategoria.DropDownStyle = ComboBoxStyle.Simple;
                cb_subcategoria.Text = "";
                cb_subcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_subcategoria.Text = "";
                //ID
                //cb_subcategoria_ID.Enabled = false;
                //cb_subcategoria_ID.DataSource = null;
                //cb_subcategoria_ID.DropDownStyle = ComboBoxStyle.Simple;
                //cb_subcategoria_ID.Text = "";
                //cb_subcategoria_ID.DropDownStyle = ComboBoxStyle.DropDownList;

                // CHCKBOX

                cx_obs.Text = "";
            }
        }

        private void frm_index_solicitacao_Load(object sender, EventArgs e)
        {
                 data_pesquisa.Value = DateTime.Now.Date;
            
                try
                {


                //LIBERA ACESSO IMSG
                //config_ComboBox.combox_Carregado_Filial(cb_provedor_acompanhamento, cb_provedor_acompanhamento_ID);
                if (acesso_adm == false)
                {
                    //FECHA Login.
                    frm_login espera = new frm_login();
                    espera.Close();

                    // RECEBE NOME DO USUÁRIO.

                }
                else {
                    recepcao_statica.Rec_nome = "Administrador";
                    recepcao_statica.Rec_ID = 4;
                    recepcao_statica.Usu_ID = 32;
                }

                lbl_usuario.Text = "Olá " + recepcao_statica.Rec_nome + " !";
                if (recepcao_sexo == "H") { img_sexo.Image = Properties.Resources.atendimento_homem_com_cor; }
                if (recepcao_sexo == "M") { img_sexo.Image = Properties.Resources.atendimento_mulher_com_cor; }
                //

                empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
                    //Carrega comboBoc provedor acompanhamento
                    cb_config_filial.combox_Carregado_Filial(cb_provedor, empresa);
                    //Carrega comboBoc provedor agendamento.
                    //  cb_config.combox_Carregado_Filial(cb_provedor_agendamento, cb_provedor_agendamento_ID);

                }
                catch
                {

                    MessageBox.Show("Ocorreu um erro, comunique o desenvolverdor!");
                }
            

            //---> Inicia evento para receber dados do sgbd
           // tempo.Tick += new EventHandler(TimerEventProcessor);

            // Seta tempo para rodar a cada 15 segundos
           // tempo.Interval = 15000; //Verifica se há dados para atendimento
           // tempo.Start();
           

        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
           // int alarmCounter = 1;
           // tempo.Stop();

            //// Displays a message box asking whether to continue running the timer.
            //if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
            //   MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // Restarts the timer and increments the counter.
           // alarmCounter += 1;
           // tempo.Enabled = true;
           
            //}
            //else
            //{
            //    // Stops the timer.
            //    exitFlag = true;
            //}
        }
        private string puxaListaAtendimento(Label lbl)
        {

            /*
             * É PASSADO PARA UM SUB MÉTODO O VALOR DO USUÁRIO QUE SERÁ SOLICITADO.
             * LOGO APÓS  É VERIFICADO NO SGBD SE HÁ ATENDIMENTO PARA ESSE USUÁRIO, E RETORNADO A INFORMAÇÃO.
             * 
             
            string qtd = "";
            try
            {
                var filial = Convert.ToInt32(cb_provedor_ID.Text);
                int mes = Convert.ToInt32(DateTime.Now.Month);
                int ano = Convert.ToInt32(DateTime.Now.Year);
                qtd = "";//solicitacaoAtendimento.get_QTD_Atendimento_OS_Aberta(filial, mes, ano).ToString();
            lbl.Text = qtd;
            }
            catch {
                qtd = 0.ToString();
            } 
            */
            return "";

        }
        private void chk_mes_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void cb_provedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filial.Fili_ID = ((Filial)(cb_provedor.SelectedItem)).Fili_ID;
                cx_codCliente.Text = "";
                cx_nomeCliente.Text = "";
                cx_codCliente.Focus();
            }
            catch {

                
            }


        }

        private void img_mostra_esconde_MouseClick(object sender, MouseEventArgs e)
        {
            ////VARIÁVEL opcaoGrande IRÁ RECEBER VALOR DIFEREMTE DA ATUAL.
            //if (opcaoGrande == true) { opcaoGrande = false; }
            //else if (opcaoGrande == false) { opcaoGrande = true; }
            opcaoGrande = !opcaoGrande;
            recolhe_Opcoes(opcaoGrande);
        }
        private void recolhe_Opcoes(bool opcao)
        {

            if (opcao == false)
            {
                lbl_mostra_esconde.Text = "Mostrar";
                grp_opcoes.Size = new Size(120, 75); // menor
              
                img_mostra_esconde.Image = Properties.Resources.img_down;
            }
            else
            {

                lbl_mostra_esconde.Text = "Esconder";
                img_mostra_esconde.Image = Properties.Resources.img_up;
                grp_opcoes.Size = new Size(120, 328);// maior
               

            }
        }
        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //------------------[CONFIGURAÇÃO DE SOLICITAÇÃO DE ATENDIMENTO] -----------------//
            //-------------------------[ESCOLHA SUB CATEGORIA]-------------------------------------------------//
            //-> VARIÁVEL LOCAL QUE RECEBERÁ O ID DA CATEGORIA.

            if (cb_categoria.Text != "" && cb_categoria.Text != null)
            {
                //----------------------[Escolha do técnico]---------------------------------
                //-------------------------[ESCOLHA EQUIPE TÉCNICA]-------------------------------------------------//
                //-> RECEBE DO TEXTBOX cb_TipoAtendimento.Text A OPÇÃO ESCOLHIDA PELO USUÁRIO
                string palavraTecnico = cb_categoria.Text;
                // É NECESSÁRIO UM ARRAY PARA RECER AS STRING QUE SERÁ EXCLUIDO DA PESQUISA
                string[] procuraTecnico = palavraTecnico.Split(new char[] { ' ', '?', '!', '.', ',', ';' });

                //-> CASO A PROCURA ENCONTRADO A PALAVRA "Técnico"
                if (procuraTecnico.Contains("Solicitação"))
                {
                    //-> EM CASO DE ACHAR A PALAVRA, É LIBERADO O COMBOBOX cb_tecnico.
                    cb_tecnico.Enabled = true;
                    //-> cb_tecnico RECEBE AS INFORMAÇÃO DOS TÉCNICOS DE RUA JÁ CADASTRADO NO SGBD
                    cb_config_user.combox_HelpDesk(cb_tecnico, filial);
                    if (bt_finalizar.Enabled == false) { bt_finalizar.Enabled = true; }


                }
                else
                {
                    //-> EM CASO DE NÃO ACHAR A PALAVRA, É TRAVADO O COMBOBOX (cb_tecnico e cb_tecnico_ID) E REMOVIDO QUALQUER INFORMAÇÃO PRESENTE NELE.
                    cb_tecnico.Enabled = false;
                    cb_tecnico.DataSource = null;
                    cb_tecnico.Items.Clear();
                    cb_tecnico.Text = "";

                   // cb_tecnico_ID.DataSource = null;
                    //cb_tecnico_ID.Items.Clear();
                   // cb_tecnico_ID.Text = "";
                    bt_finalizar.Enabled = false;
                    MessageBox.Show("Por favor, escolha a opção : Solicitação de Atendimento Cliente SCRP ou R.Claro \r\n Para continuar", "Opção inválida!");
                    if (bt_finalizar.Enabled == true) { bt_finalizar.Enabled = false; }
                    cb_categoria.Focus();
                }
                try
                {
                    
                    categoria.Cate_ID = ((Categoria_Atendimento)cb_categoria.SelectedItem).Cate_ID;
                    categoria.Cate_descricao = cb_categoria.Text;
                    liberar_subcategoria(categoria);
                }
                catch { categoria.Cate_ID = 0; }
            }
        }

        private void cb_tecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tecnico.Text != "")
            {
                try
                {
                    helpdesk.help_ID = ((HelpDesk)cb_tecnico.SelectedItem).help_ID;
                    helpdesk.help_Nome = cb_tecnico.Text;
                }
                catch { }
            }
        }

        private void cb_subcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_subcategoria.Text != "")
            {
                try
                {
                    subcategoria.Sub_ID = ((Subcategoria_Atendimento)cb_subcategoria.SelectedItem).Sub_ID;
                    subcategoria.Sub_descricao = cb_subcategoria.Text;
                }
                catch
                {

                }
            }
        }

        private void bt_aluguelRoteador_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Roteador frm_roteador = new frm_Roteador();
            //childForm.Text = "Window " + childFormNumber++;
            frm_roteador.ShowDialog();
        }

        //-> Corrigir essa opção com a base de acesso.
        private void frm_index_solicitacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (acesso_adm == false)
            {
                //var msgLog = "Usuário {" + usuario.NomeCompleto_DB() + "} saiu da opção:{Formulário HelpDesk - Atendimento} ";
                //envia_Dados.Envia_LOGS_DB(2, msgLog, usuario.ID_user_DB());
                frm_login login = new frm_login();
                login.Show();
            }
        }

        private void mostra_solicitacao_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid_ID = 0;
            var dataAtendimento = "";
            
            try
            {
                grid_ID = Convert.ToInt32(mostra_solicitacao.SelectedCells[0].Value);
                dataAtendimento = mostra_solicitacao.SelectedCells[6].Value.ToString();
                codCliente_Grid = mostra_solicitacao.SelectedCells[1].Value.ToString(); 
                nomeCliente_Grid = mostra_solicitacao.SelectedCells[2].Value.ToString();
                tec_help_Grid = mostra_solicitacao.SelectedCells[9].Value.ToString();

                if (grid_ID > 0 && (dataAtendimento == null || dataAtendimento == ""))
                {

                    idGrid = grid_ID;
                    bt_excluir.Enabled = true;
                    excluirSolicitacao = true;
                }
                else {
                    idGrid = 0;
                    bt_excluir.Enabled = false;
                    excluirSolicitacao = false;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public frm_index_solicitacao()
        {
            InitializeComponent();
        }

        private void liberar_categoria(bool liberar, Filial fill)
        {
            if (liberar == true)
            {

                cb_config_cate_sub.combox_Categoria_Atendimento(cb_categoria,  fill);
                cb_categoria.Enabled = true;
            }
            else
            {

                cb_categoria.Enabled = false;
                cb_subcategoria.Enabled = false;
                cb_categoria.Text = "";
                cb_subcategoria.Text = "";
            }
        }
        private void liberar_subcategoria(Categoria_Atendimento cat)
        {

            if (cat.Cate_ID > 0)
            {
                cb_subcategoria.Text = "";
                //cb_subcategoria_ID.Text = "0";
                cb_config_cate_sub.combox_Subcategoria_Atendimento(cb_subcategoria,  cat);
                cb_subcategoria.Enabled = true;

            }
        }

        #endregion


    }
}
