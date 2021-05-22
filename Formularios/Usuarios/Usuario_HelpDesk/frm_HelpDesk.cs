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
using Controlador.Controle.DataGrid_Config.DataGrid_Atendimento;
using Controlador.Controle.ComboBox_Config;
using Regras_N.Regra_N_Usuario;
using NDM_SoftwareV5.Formularios.F_Cliente;
using NDM_SoftwareV5.Formularios.Ordem_Servicos;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    public partial class frm_HelpDesk : Form
    {
        public static string sexo_usuario;
        public static HelpDesk help_atendimento              = new HelpDesk();
        Filial filial                                        = new Filial();
        Empresa empresa                                      = new Empresa();
        DataGrid_Atendimento dg_config_atendimento           = new DataGrid_Atendimento();
        ComboBox_Filial cb_config_filial                     = new ComboBox_Filial();
        Atendimento atendimentos                             = new Atendimento();
        RN_Atendimento regra_atendimento                     = new RN_Atendimento();
        string data_de_hoje                                  = DateTime.Now.ToString("yyyy-MM-dd");
        int mes_consolidado = 0;
        int ano_consolidado = 0;
        public static bool acesso_adm = false;

        public frm_HelpDesk()
        {
            InitializeComponent();
        }

        private void frm_HelpDesk_Load(object sender, EventArgs e)
        {
            if (acesso_adm == false)
            {
                var login = new frm_login();
                login.Close();
            }
            else {
                help_atendimento.help_ID = 4;
                help_atendimento.help_Nome = "Admistrador";
                help_atendimento.Usu_ID = 17;
            }
                empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            
                cb_config_filial.combox_Carregado_Filial(cb_provedor_atendimento_descricao, empresa);
                lbl_usuario.Text = "Usuário: " + help_atendimento.help_Nome;
                lbl_base.Text = cb_provedor_atendimento_descricao.Text;

                if (mes_consolidado == 0)
                {
                    mes_consolidado = Convert.ToInt32(DateTime.Now.Month);
                    set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
                }
                if (ano_consolidado == 0)
                {
                    ano_consolidado = Convert.ToInt32(DateTime.Now.Year);
                    cx_ano.Text = ano_consolidado.ToString();
                }
                Tempo.Start();
                defini_sexo_imagen(sexo_usuario);
            
        }
        private void defini_sexo_imagen(string sexo)
        {

            if (help_atendimento.help_ID != 1)
            {
                if (sexo == "H") { img_sexo.Image = Properties.Resources.atendimento_homem_com_cor; }
                if (sexo == "M") { img_sexo.Image = Properties.Resources.atendimento_mulher_com_cor; }
            }
        }
        private void frm_HelpDesk_FormClosing(object sender, FormClosingEventArgs e)
        {
            help_atendimento = null;
            if (acesso_adm == false)
            {
                var login = new frm_login();
                login.Show();
            }
        }

        private void img_novo_atendimento_MouseClick(object sender, MouseEventArgs e)
        {
            var add_atendimento = new frm_add_Atendimento();
            frm_add_Atendimento.helpdek_statico = help_atendimento;
            frm_add_Atendimento.atendimento_solicitado = false;
            
            add_atendimento.ShowDialog();
            carrega_grid_mostrar_atendimento(filial);

        }

        private void carrega_grid_mostrar_atendimento(Filial fil) {
           
            mostra_atendimento.DataSource = dg_config_atendimento.mostrar_atendimentos_help(mostra_atendimento,fil , help_atendimento, data_de_hoje);
            var a = DateTime.Now.ToString("yyyy-MM-dd");
            var b = DateTime.Now.ToString("yyyy-MM-dd");
            dg_mostra_Historico.DataSource  = dg_config_atendimento.mostra_HistoricoAtendimento(dg_mostra_Historico, fil, help_atendimento, a, b);
            mostraAcompanhamento.DataSource = dg_config_atendimento.mostra_Acompanhamento(mostraAcompanhamento, fil, help_atendimento);
            conta_atendimento();
        }

        private void cb_provedor_atendimento_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void mostra_atendimento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(mostra_atendimento.SelectedCells[0].Value.ToString()) > 0)
            {
                atendimentos.Aten_ID          = Convert.ToInt32(mostra_atendimento.SelectedCells[0].Value.ToString());
                atendimentos.Is_OS            = Convert.ToInt32(mostra_atendimento.SelectedCells[12].Value.ToString());
                cx_historico_atendimento.Text = mostra_atendimento.SelectedCells[13].Value.ToString();
                bt_excluir.Enabled            = true;
            }
            else {
                cx_historico_atendimento.Text = "";
                bt_excluir.Enabled            = false;
            }
            
        }
        private void conta_atendimento()
        {
            /*
             * MÉTODO RESPONSÁVEL POR REALIZAR A CONTAGEM DOS ATENDIMENTO 
             * atendimentoNomal = CONTAGEM GERAL DO ATENDIMENTO REALIZADO NO DIA,
             * atendimentoOS    = CONTAGEM SOMENTE DAS ORDEM DE SERVIÇO ABERTO NO DIA.
             * atendimentoSoli  = CONTAGEM SOMENTE DAS SOLICITAÇÕES REALIZADO NO DIA.
             *  CRIADO : 19/12/2019 - MARCOS BEZERRA.
             */
            int atendimentoNomal = 0;
            int atendimentoOS = 0;
            int atendimentoSoli = 0;

            atendimentoNomal = mostra_atendimento.Rows.Count;               //RECEBE TOTAL DE DADOS DO DATAGRIDVIEW

            //Para cada linha do dataGridview com valores:
            foreach (DataGridViewRow linhaGrid in mostra_atendimento.Rows)
            {
                try
                {
                    //VERIFICA O VALOR DA COLUNA SOLICITAÇÃO DE ATENDIMENTO NÃO É NULA E SE SUA CELULA NÃO É NULA
                    if (linhaGrid.Cells[12].Value != null)
                    {
                        // SETA O VALOR EM UMA VARIÁVEL LOCAL RECEBENDO O VALOR DA CÉLULA
                        int valor = Convert.ToInt32(linhaGrid.Cells[12].Value.ToString());
                        // VERIFICA SE VALOR É MAIOR QUE ZERO E ADICINA UM INCREMENTO
                        if (valor > 0) { atendimentoOS++; }
                    }
                }
                catch { }
                //VERIFICA SE O VALOR DA COLUNA  ORDEM DE SERVIÇO NÃO É NULA
                if (linhaGrid.Cells[9].Value != null)
                {

                    // SETA O VALOR EM UMA VARIÁVEL LOCAL RECEBENDO O VALOR DA CÉLULA
                    string valor = linhaGrid.Cells[9].Value.ToString();
                    if (valor != "")
                    {
                        //ADICIONA UM INCREMENTO AO VALOR
                        atendimentoSoli++;
                    }
                }

            }

            lbl_qtd_atendimento.Text = atendimentoNomal.ToString();  //CONTA QUANTIDADE DE ATENDIMENTO EM GERAL
            lbl_os_aberta.Text = atendimentoOS.ToString();     //CONTA QUANTIDADE DE ATENDIMENTO COM OS.ABERTAS
            lbl_soma_Atendimento_Historico.Text = dg_mostra_Historico.RowCount.ToString();
            
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (atendimentos.Aten_ID > 0) {
                DialogResult p = MessageBox.Show("Excluir atendimento?","Atenção",MessageBoxButtons.YesNo);
                if (p == DialogResult.Yes) { regra_atendimento.del_atendimento_help(atendimentos); }
            }
            atendimentos.Aten_ID = 0;
            bt_excluir.Enabled = false;
            cx_historico_atendimento.Text = "";
            carrega_grid_mostrar_atendimento(filial);
        }

        private void img_solicitacoes_MouseClick(object sender, MouseEventArgs e)
        {
            //Regra, só será possível abrir se houver atendimento.
            if (lbl_inf_solicitacoes.Text != "0")
            {
                frm_inf_atendimento_solicitado.help = help_atendimento;
                var frm_solicitacao = new frm_inf_atendimento_solicitado();
                frm_solicitacao.ShowDialog();

                carrega_grid_mostrar_atendimento(filial);
                cx_historico_atendimento.Text = "";

                lbl_inf_solicitacoes.Text = puxaListaAtendimento(lbl_inf_solicitacoes);
                if (lbl_inf_solicitacoes.Text != "0" && lbl_inf_solicitacoes.Text != "[49]-Sem conexão")
                {
                    img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_Cor;
                }
                else
                {
                    img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_SCor;
                }
            }
            else {

                MessageBox.Show("Não há atendimento solicitados no momento!");
            }
        }

        private void mostra_atendimento_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var codigo_ID = mostra_atendimento.SelectedCells[0].Value.ToString();
            if (codigo_ID != null && Convert.ToInt32(codigo_ID) > 0)
            {
                var add_atendimento = new frm_add_Atendimento();
                frm_add_Atendimento.atendimento_solicitado = true;
                frm_add_Atendimento.helpdek_statico = help_atendimento;
                atendimentos.Aten_ID = Convert.ToInt32(codigo_ID);
                frm_add_Atendimento.atendimento_statico = atendimentos;
                add_atendimento.ShowDialog();
            }
            carrega_grid_mostrar_atendimento(filial);
        }

        private void img_clientes_MouseClick(object sender, MouseEventArgs e)
        {
            var frm_cliente = new frm_pesquisa_cliente();
            frm_cliente.ShowDialog();
        }

        private void img_os_MouseClick(object sender, MouseEventArgs e)
        {
            var frm_os = new frm_abertura_OS_Atendimento();
            frm_abertura_OS_Atendimento.usuario.Usu_ID = help_atendimento.Usu_ID;
            frm_os.ShowDialog();
        }

        private void btn_pesquisa_Historico_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var a = Convert.ToDateTime(cx_data_1_Historico.Text).ToString("yyyy-MM-dd");
                var b = Convert.ToDateTime(cx_data_2_Historico.Text).ToString("yyyy-MM-dd");
                dg_mostra_Historico.DataSource = dg_config_atendimento.mostra_HistoricoAtendimento(dg_mostra_Historico, filial, help_atendimento, a, b);
                cx_historicos.Text = "";
            }
            catch {
                MessageBox.Show("Data Incorreta");
                var a = DateTime.Now.ToString("dd/MM/yyyy");
                var b = DateTime.Now.ToString("dd/MM/yyyy");
                cx_data_1_Historico.Text = a;
                cx_data_2_Historico.Text = b;
                
            }
            lbl_soma_Atendimento_Historico.Text = dg_mostra_Historico.RowCount.ToString();
        }

        private void dg_mostra_Historico_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = 0;
            cx_historicos.Text = "";
            try
            {
                id = Convert.ToInt32(dg_mostra_Historico.SelectedCells[0].Value.ToString());
                if (id > 0)
                {

                    cx_historicos.Text = dg_mostra_Historico.SelectedCells[5].Value.ToString();

                }
            }
            catch { cx_historicos.Text = ""; }
        }

        private void mostraAcompanhamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = 0;
            cx_acompanhamento.Text = "";
            try
            {
                id = Convert.ToInt32(mostraAcompanhamento.SelectedCells[0].Value.ToString());
                if (id > 0)
                {

                    cx_acompanhamento.Text = mostraAcompanhamento.SelectedCells[5].Value.ToString();
                    bt_finalizar.Enabled = true;
                }
                else {
                    cx_acompanhamento.Text = "";
                    bt_finalizar.Enabled = false;
                }
            }
            catch
            {
                cx_acompanhamento.Text = "";
                bt_finalizar.Enabled = false;
            }
        }
        private void rb_jan_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 1;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_fev_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 2;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_mar_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 3;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_abr_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 4;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_mai_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 5;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_jun_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 6;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_jul_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 7;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_ago_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 8;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_set_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 9;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_out_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 10;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_nov_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 11;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }

        private void rb_dez_CheckedChanged(object sender, EventArgs e)
        {
            mes_consolidado = 12;
            set_Mes_Atual_Consolida_Atendimento(mes_consolidado);
        }
        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            Atendimento atendimento_f = new Atendimento();
            int id = 0;
            try
            {
                id = Convert.ToInt32(mostraAcompanhamento.SelectedCells[0].Value.ToString());
                if (id > 0)
                {
                    atendimento_f.Aten_ID = id;
                    regra_atendimento.finalizar_acompanhamento(atendimento_f);
 
                }

            }
            catch { MessageBox.Show("Atendimento não pode ser finalizado."); }
            mostraAcompanhamento.DataSource = dg_config_atendimento.mostra_Acompanhamento(mostraAcompanhamento, filial, help_atendimento);
            cx_acompanhamento.Text = "";
            bt_finalizar.Enabled = false;
        }

        private void carrega_Consolida_Atendimento_Hora(int mes, int ano,Filial fil)
        {
         //   var id_help = tecnico_help.buscar_ID_help(usuario.ID_user_DB());
         //- Não será mais usado aqui. 28/05/2020 - Marcos Bezerra
         
            if (mes > 0 && (ano > 2000))
            {
                /*
                 string[] horas_a = new string[7];
                 string[] horas_b = new string[7];
                 //-> Horas entradas
                 horas_a[0] = "01:00:00";
                 horas_a[1] = "10:00:00";
                 horas_a[2] = "12:00:00";
                 horas_a[3] = "14:00:00";
                 horas_a[4] = "16:00:00";
                 horas_a[5] = "20:00:00";
                 horas_a[6] = "21:30:59";
                 //-> Horas sáidas
                 horas_b[0] = "09:59:59";
                 horas_b[1] = "11:59:59";
                 horas_b[2] = "13:59:59";
                 horas_b[3] = "15:59:59";
                 horas_b[4] = "17:59:59";
                 horas_b[5] = "19:59:59";
                 horas_b[6] = "23:59:59";

                 int horasTrabalhada = 7;
                 int[] soma = new int[7];
                 for (int qtd = 0; qtd < horasTrabalhada; qtd++)
                 {
                     soma[qtd] = regra_atendimento.get_Pesquisa_Horas_Atendimento(help_atendimento, fil, horas_a[qtd], horas_b[qtd], mes, ano);

                 }

                 int total = (soma[0] + soma[1] + soma[2] + soma[3] + soma[4] + soma[5] + soma[6]);

                 //REPASSA VALORES A LABEL
                 lbl_total_atendimento.Text = total.ToString();

                 //PUXA PRÓXIMA PESQUISA {carrega_Consolida_Cliente_Tecnico() }
                 */
                //carrega_Consolida_Cliente_Tecnico(mes, ano, fil);
                carrega_TOP5_Rank(mes, ano, filial);
            }
            else { MessageBox.Show("Erro: Ano menor que 2000 não é aceito!"); }
        }
        /*  private void carrega_Consolida_Cliente_Tecnico(int mes, int ano, Filial fill)
          {

             lbl_qtd_Cliente.Text = "Você realizou {" + regra_atendimento.get_Pesquisa_Cliente_Tecnico(help_atendimento, fill, "Cliente", mes, ano).ToString() + "}  atendimento(os) para clientes.";
             lbl_qtd_Tecnico.Text = "Você realizou {" + regra_atendimento.get_Pesquisa_Cliente_Tecnico(help_atendimento, fill, "Técnico", mes, ano).ToString() + "}  atendimento(os) para técnicos.";
              //-> PROCURA POR ATENDIMENTO SOLICITADOS.
             // { 0/0 } foram de atendimento solicitados.
             lbl_qtd_Solicitacoes.Text = " De { " + lbl_total_atendimento.Text + "} - { " + regra_atendimento.get_Pesquisa_Solicitacao(help_atendimento, fill, mes, ano).ToString() + " } foram de atendimentos solicitados.";

              //-> BASEANDO NOS VALORES {0 = NÃO ABERTO | 1 = ABERTO }.
             lbl_Sem_OS.Text = regra_atendimento.get_Pesquisa_Atendimento_OS_Aberta_fechada(help_atendimento, fill, mes, ano, 0).ToString();
             lbl_com_OS.Text = regra_atendimento.get_Pesquisa_Atendimento_OS_Aberta_fechada(help_atendimento, fill, mes, ano, 1).ToString();



              //-> CARREGA O RANK TOP 5 CLIENTE ATENDIDOS.
              //carrega_TOP5_Rank(mes, ano, filial);

          }*/
        private void set_Mes_Atual_Consolida_Atendimento(int mesAtual)
        {

            var mes =  mesAtual;
            switch (mes)
            {
                case (1):
                    rb_jan.ForeColor = Color.Red; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}

                    break;
                case (2):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Red; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (3):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Red; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (4):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Red; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (5):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Red; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (6):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Red; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (7):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Red; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (8):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Red; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (9):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Red; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (10):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Red; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (11):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Red; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Black;   //  - MÊS{DEZEMBRO}
                    break;
                case (12):
                    rb_jan.ForeColor = Color.Black; //  - MÊS{JANEIRO}
                    rb_fev.ForeColor = Color.Black; //  - MÊS{FEVEREIRO}
                    rb_mar.ForeColor = Color.Black; //  - MÊS{MARÇO}
                    rb_abr.ForeColor = Color.Black; //  - MÊS{ABRIL}
                    rb_mai.ForeColor = Color.Black; //  - MÊS{MAIO}
                    rb_jun.ForeColor = Color.Black; //  - MÊS{JUNHO}
                    rb_jul.ForeColor = Color.Black; //  - MÊS{JULHO}
                    rb_ago.ForeColor = Color.Black; //  - MÊS{AGOSTO}
                    rb_set.ForeColor = Color.Black; //  - MÊS{SETEMBRO}
                    rb_out.ForeColor = Color.Black; //  - MÊS{OUTUBRO}
                    rb_nov.ForeColor = Color.Black; //  - MÊS{NOVEMBRO}
                    rb_dez.ForeColor = Color.Red;   //  - MÊS{DEZEMBRO}
                    break;
            }
        }

        private void carrega_TOP5_Rank(int mes, int ano, Filial fill)
        {

            //-> RANK CLIENTES
            mostra_rank_clientes.DataSource = dg_config_atendimento.mostra_Rank_Cliente(mostra_rank_clientes, fill, mes, ano, help_atendimento);
            //-> RANK ATENDIMENTOS
            mostra_rank_atendimento.DataSource= dg_config_atendimento.mostra_Rank_Atendimento(mostra_rank_atendimento, fill, mes, ano, help_atendimento);
            //-> RANK TÉCNICOS - Removido 27/05/2020
            //dg_config_atendimento.mostra_Rank_Tecnico(mostra_rank_tecnico, fill, mes, ano, help_atendimento);
            //->RANK CATEGORIA ATENDIMENTO - ADCIONADO 28/05/2020
            mostra_atendimento_geral.DataSource = dg_config_atendimento.mostra_Rank_Atendimento_Categoria(mostra_atendimento_geral, fill, mes, ano, help_atendimento);

            //Aplica função de Soma de atendimentos.
            int total = 0;
            foreach (DataGridViewRow row in mostra_atendimento_geral.Rows.Cast<DataGridViewRow>()
                //Busca pelas vores que não estão preenchido na coluna do grid e elima da lista de soma
           .Where(t => !string.IsNullOrEmpty(t.Cells["QTD"].Value?.ToString())))
            {
                total += Convert.ToInt32(row.Cells["QTD"].Value);
            }
            lbl_total_atendimento.Text = total.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var valor = cx_ano.Text.Replace("_", "");
            
            try
            {
               
                ano_consolidado = Convert.ToInt32(valor);
            }
            catch { ano_consolidado = DateTime.Now.Year; }

            if (valor != "")
            {
                if (mes_consolidado > 0 && Convert.ToUInt32(cx_ano.Text) > 2000)
                {
                    carrega_Consolida_Atendimento_Hora(mes_consolidado, ano_consolidado, filial);
                    grp_top5.Text = "Top 5 - " + filial.Fili_descricao;
                }
                else
                {
                    MessageBox.Show("Erro: Ano deve ser mair que 2000");
                }
            }
            else
            {
                MessageBox.Show("Erro: Ano não informado");
                cx_ano.Focus();
            }
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            int alarmCounter = 1;
           

            //// Displays a message box asking whether to continue running the timer.
            //if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
            //   MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // Restarts the timer and increments the counter.
            alarmCounter += 1;
            this.pg_procura_atendimento.Increment(alarmCounter);

            if (pg_procura_atendimento.Value == 100) {
                //Paro o tempo de processamento
                Tempo.Stop();
                //Desabilita o tempo.
                Tempo.Enabled = false;
                //Faz a contagem das informações do banco de dados.
                lbl_inf_solicitacoes.Text = puxaListaAtendimento(lbl_inf_solicitacoes);
                //zero o processo
                pg_procura_atendimento.Value = 0;
                //Habilita o tempo
                Tempo.Enabled = true;
                if (lbl_inf_solicitacoes.Text != "0" && lbl_inf_solicitacoes.Text != "[49]-Sem conexão")
                {
                    img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_Cor;
                }
                else {
                    img_solicitacoes.Image = Properties.Resources.SolicitarAtendimento_SCor;
                }
            }
           
            
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
             * MODIFICADO  28/05/2020
             */
            return regra_atendimento.get_QTD_Atendimento_HelpDesk(help_atendimento);

        }

        private void cb_provedor_atendimento_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filial.Fili_ID = ((Filial)cb_provedor_atendimento_descricao.SelectedItem).Fili_ID;
                filial.Fili_descricao = cb_provedor_atendimento_descricao.Text;
                carrega_grid_mostrar_atendimento(filial);
                lbl_base.Text = filial.Fili_descricao;
            }
            catch
            {
                mostra_atendimento.DataSource = null;
                conta_atendimento();
                lbl_base.Text = "???";
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Roteador frm_roteador = new frm_Roteador();
            //childForm.Text = "Window " + childFormNumber++;
            frm_roteador.ShowDialog();
        }
    }
}
