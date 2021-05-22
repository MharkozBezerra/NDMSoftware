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
using Controlador.Controle.DataGrid_Config.DataGrid_Estoque;
using Regras_N.Regra_N_Usuario;
using Regras_N.Regra_N_Estoque;
using NDM_SoftwareV5.Formularios.F_Cliente;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    public partial class frm_Roteador : Form
    {
        private Empresa empresa = null;
        private Filial filial = null;
        private ComboBox_Filial cb_config_filial = new ComboBox_Filial();
        private DataGrid_Estoque dg_config = new DataGrid_Estoque();
        private Cliente cliente_aluguel = null;
        private RN_Atendimento regra_atendimento = new RN_Atendimento();
        public static TecnicoRua tecnico_staico = null;
        private Aluguel_Roteador roteador_aluguel = null;
        private Aluguel_Roteador roteador_alugado = null;
        private Aluguel_Roteador roteador_tenico = null;
        private RN_Estoque regra_estoque = new RN_Estoque();
        //-------[Variavel de usu único]
        int id_estoque_para_aluguel = 0;
        int id_estoque_alugado = 0;
        int id_user_tecnico_alugado = 0;
        double estoque_qtd_alugado = 0;
        double estoque_qtd_aluguel = 0;
        public frm_Roteador()
        {
            InitializeComponent();
        }
        private void frm_Roteador_Load(object sender, EventArgs e)
        {
            empresa = new Empresa();
            filial =  new Filial();
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            cb_config_filial.combox_Carregado_Filial(cb_filial, empresa);

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cb_filial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                filial.Fili_ID = ((Filial)cb_filial.SelectedItem).Fili_ID;
               
            }
            catch { dg_mudar_cor_linha(dg_mostra_geral); }
       }
        private void mostrar_roteador_geral(Filial fill, string texto, string pesquisar)
        {
            try
            {
                dg_mostra_geral.DataSource = dg_config.mostra_Roteador(dg_mostra_geral,fill, texto, pesquisar, 0);
                dg_mudar_cor_linha(dg_mostra_geral);
            }
            catch { }
            }
        private void mostrar_roteador_soDisponivel(Filial fill, string texto, string pesquisar)
        {
            try
            {
                dg_mostra_disponivel.DataSource = dg_config.mostra_Roteador(dg_mostra_disponivel, fill, texto, pesquisar, 1);
                dg_mudar_cor_linha(dg_mostra_disponivel);
            }
            catch { }
            }
        private void mostrar_roteador_soAlugado(Filial fill, string texto, string pesquisar)
        {
            try
            {
                dg_mostra_alugado.DataSource = dg_config.mostra_Roteador(dg_mostra_alugado,fill, texto, pesquisar, 2);
                dg_mudar_cor_linha(dg_mostra_alugado);
            }
            catch { }
        }
        private void mostrar_roteador_soTecnico(Filial fill, string texto, string pesquisar)
        {
            try
            {
                dg_mostra_roteador_tecnico.DataSource = dg_config.mostra_Roteador(dg_mostra_roteador_tecnico,fill, texto, pesquisar, 3);
                dg_mudar_cor_linha(dg_mostra_roteador_tecnico);
            }
            catch { }
            }
        private void dg_mudar_cor_linha(DataGridView dg) {

            foreach (DataGridViewRow row in dg.Rows)
            {
                int status = Convert.ToInt32(row.Cells[10].Value);
                switch (status)
                {

                    case 0: 
                    case 1: row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00FF00");  break; //Verde
                    case 2: row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F08080"); break; //Vermelho
                    case 3: row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F0E68C"); break; //Amerelo
                }
                
            }
        }

        private void bt_confirma_base_Click(object sender, EventArgs e)
        {
            if (filial.Fili_ID > 0)
            {
                tab_Controle.Enabled = true;
                mostrar_roteador_geral(filial, "", "");
                
            }
            else {
                tab_Controle.Enabled = false;
            }
        }
        private void bt_pesquisar_2_Click(object sender, EventArgs e)
        {
            string texto = "", pesquisa = "";
            texto = cb_texto_2.Text;
            pesquisa = cx_pesquisar_2.Text;
            if ((!String.IsNullOrEmpty(texto) && !String.IsNullOrWhiteSpace(texto)) )
            {
                if ( (String.IsNullOrEmpty(pesquisa) ) || (String.IsNullOrWhiteSpace(pesquisa)) )
                    { pesquisa = "a"; }
                mostrar_roteador_soDisponivel(filial, texto, pesquisa);
            }
            else
            {

                MessageBox.Show("Não é permitido realizado pesquisa com informações ausênte", "Erro!!");
            }
        }
        private void bt_pesquisar_1_MouseClick(object sender, MouseEventArgs e)
        {
            string texto = "", pesquisa = "";
            texto = cb_texto_1.Text;
            pesquisa = cx_pesquisar_1.Text;
            if ((!String.IsNullOrEmpty(texto) && !String.IsNullOrWhiteSpace(texto)) && (!String.IsNullOrEmpty(pesquisa) && !String.IsNullOrWhiteSpace(pesquisa)))
            {
                mostrar_roteador_geral(filial, texto, pesquisa);
            }
            else {

                MessageBox.Show("Não é permitido realizado pesquisa com informações ausênte","Erro!!");
            }
                

        }

        private void cx_pesquisar_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cx_pesquisar_2_TextChanged(object sender, EventArgs e)
        {
            if (cx_pesquisar_2.TextLength > 0) {
                bt_pesquisar_2.Text = "Procurar....";
            }
            else if (cx_pesquisar_2.TextLength < 1) {
                bt_pesquisar_2.Text = "Listar....";
            }
        }

        private void cb_texto_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_texto_2.Text == "") { cx_pesquisar_2.ReadOnly = true; cx_pesquisar_2.Focus(); }
            else { cx_pesquisar_2.ReadOnly = false; }
        }

        private void dg_mostra_disponivel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pega id
            try {

                int id = 0;
                id_estoque_para_aluguel = 0;
                estoque_qtd_aluguel = 0;
                roteador_aluguel = new Aluguel_Roteador();
                id = Convert.ToInt32(dg_mostra_disponivel.SelectedCells[0].Value.ToString());
                if(id > 0)
                {
                    gp_dados_aluguel.Enabled = true;
                    lbl_mac.Text = dg_mostra_disponivel.SelectedCells[4].Value.ToString();
                    lbl_modelo.Text = dg_mostra_disponivel.SelectedCells[3].Value.ToString();
                    lbl_num_serie.Text = dg_mostra_disponivel.SelectedCells[5].Value.ToString();
                    lbl_patrimonio.Text = dg_mostra_disponivel.SelectedCells[6].Value.ToString();
                    lbl_preset.Text = dg_mostra_disponivel.SelectedCells[9].Value.ToString();
                    roteador_aluguel.alu_ID = id;
                    id_estoque_para_aluguel = Convert.ToInt32(dg_mostra_disponivel.SelectedCells[11].Value.ToString());
                    estoque_qtd_aluguel = Convert.ToDouble(dg_mostra_disponivel.SelectedCells[12].Value.ToString());
                    cx_cod_cliente.Focus();

                }
                    }
            catch {

                gp_dados_aluguel.Enabled = false;
                lbl_mac.Text        = "???";
                lbl_modelo.Text     = "???";
                lbl_num_serie.Text  = "???";
                lbl_patrimonio.Text = "??";
                lbl_preset.Text     = "???";
            }
           
        }

        private void cx_cod_cliente_Leave(object sender, EventArgs e)
        {

        }

        private void bt_buscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (cx_cod_cliente.Text != "" || cx_cod_cliente.Text != String.Empty)
                {
                    var codigo = Convert.ToInt32(cx_cod_cliente.Text);
                    cliente_aluguel             = new Cliente();
                    cliente_aluguel.Fili_ID     = filial.Fili_ID;
                    cliente_aluguel.Clie_codigo = codigo;
                    cliente_aluguel.Clie_nome   = null;
                    cliente_aluguel.Clie_ID     = 0;

                    if (regra_atendimento.validar_cliente(cliente_aluguel) == true)
                    {
                        cx_nome_cliente.Text = "";
                        cliente_aluguel      = regra_atendimento.puxar_cliente(cliente_aluguel);
                        cx_nome_cliente.Text = cliente_aluguel.Clie_nome;
                        filial.Fili_ID       = filial.Fili_ID;
                        bt_gravar_aluguel.Enabled = true;
                    }
                    else
                    {
                        DialogResult pergunta = MessageBox.Show("Atenção: Cliente não encontrado! \r\nDeseja cadastrar esse novo código agora?", "Código inválido", MessageBoxButtons.YesNo);
                        if (pergunta == DialogResult.Yes)
                        {
                            var add_cliente = new frm_add_cliente();
                            cliente_aluguel.Fili_ID = filial.Fili_ID;
                            cliente_aluguel.Fili_descricao = cb_filial.Text;
                            cliente_aluguel.Clie_codigo = codigo;
                            cliente_aluguel.Clie_ID = 0;
                            cx_nome_cliente.Text = "";
                            frm_add_cliente.acao = 1;
                            frm_add_cliente.cliente_statico = cliente_aluguel;
                            add_cliente.ShowDialog();

                            //Rete a ação.
                            if (regra_atendimento.validar_cliente(cliente_aluguel) == true)
                            {
                                cx_nome_cliente.Text = "";
                                cliente_aluguel = regra_atendimento.puxar_cliente(cliente_aluguel);
                                cx_nome_cliente.Text = cliente_aluguel.Clie_nome;
                                filial.Fili_ID = filial.Fili_ID;
                                bt_gravar_aluguel.Enabled = true;
                            }
                        }
                        else
                        {
                            cx_nome_cliente.Text = "";
                            cliente_aluguel = null;
                            bt_gravar_aluguel.Enabled = false;

                        }

                    }


                }
            }
            catch

            {
                MessageBox.Show("O código do cliente é no formato númerico \r\nEx: 00001, utilize esse formato para digitar.", "Valor não aceito.");
                cx_cod_cliente.Text = 0.ToString();
                cx_cod_cliente.Focus();
                cx_nome_cliente.Text = "";
            }
        }

        private void bt_gravar_aluguel_Click(object sender, EventArgs e)
        {
            tecnico_staico = new TecnicoRua();
            Usuario user = new Usuario();
            
            //Verifica se roteador está  foi levado pelo cliente ou por técnico.
            //Nota: 99% dos caso será pelo cliente.
            if (chk_tecnico.Checked == true)
            {

                frm_buscar_tecnico tec_rua = new frm_buscar_tecnico();
                frm_buscar_tecnico.filial_statico = filial;
                frm_buscar_tecnico.is_atendimento_help = false;
                tec_rua.ShowDialog();
                //Confirma se há técnico escolhido
                if (tecnico_staico.Tec_ID == 0 || tecnico_staico == null)
                {
                    tecnico_staico.Usu_ID = 0;
                    roteador_aluguel.status = 2;
                    user.Usu_ID = 32;//SYSTEM_INTERNO ID INTERNO
                }
                else {
                    user.Usu_ID = tecnico_staico.Usu_ID;
                    roteador_aluguel.status = 3;
                }

            }
            else if (chk_tecnico.Checked == false)
            {
                user.Usu_ID = 32;//SYSTEM_INTERNO ID INTERNO
                roteador_aluguel.status = 2;
            }
           
            //Ordem de serviço
          
            //-> Dá seguimento ao salvamento.
            roteador_aluguel.cliente = cliente_aluguel;
           


            roteador_aluguel.Est_ID         = id_estoque_para_aluguel;
            roteador_aluguel.Qtd_atual      = estoque_qtd_aluguel;

            //Dados do roteador.
            roteador_aluguel.usuario        = user;
            roteador_aluguel.modelo         = lbl_modelo.Text;
            roteador_aluguel.mac_adress     = lbl_mac.Text;
            roteador_aluguel.num_serie      = lbl_num_serie.Text;
            roteador_aluguel.num_patrimonio = lbl_patrimonio.Text;
            roteador_aluguel.data_saida     = DateTime.Now.ToString("yyyy-MM-dd");
            roteador_aluguel.preset         = lbl_preset.Text;

            
           
                string s_os = cx_os.Text;
                int os = 0;
                if (!String.IsNullOrEmpty(s_os) && !String.IsNullOrWhiteSpace(s_os))
                {
                    os = Convert.ToInt32(s_os);
                }
                else { os = 0; }
            if ( cliente_aluguel.Clie_ID > 0 || cliente_aluguel != null)
            {
                if (os > 0)
                {
                    roteador_aluguel.codigoOS = os;

                    int acao = 0;
                    if (estoque_qtd_aluguel > 0) { acao = regra_estoque.roteador_alugar_devolver(roteador_aluguel, user); }
                    else { MessageBox.Show("[Estoque baixo]-> Equipamento não disponível para locação, comunique o estoquista."); }
                    
                    if (acao == 68)
                    {
                        mostrar_roteador_geral(filial, "", "");
                        mostrar_roteador_soDisponivel(filial, "", "");
                        //mostrar_roteador_soAlugado(filial, "", "");
                        //mostrar_roteador_soTecnico(filial, "", "");
                        //Limpa informações
                        lbl_mac.Text = "???";
                        lbl_modelo.Text = "???";
                        lbl_num_serie.Text = "???";
                        lbl_patrimonio.Text = "??";
                        lbl_preset.Text = "???";
                        cx_cod_cliente.Text = "";
                        cx_nome_cliente.Text = "";
                        cliente_aluguel = null;
                        tecnico_staico = null;
                        roteador_aluguel = null;
                        cx_os.Text = "";
                        chk_tecnico.Checked = false;
                        bt_gravar_aluguel.Enabled = false;
                        estoque_qtd_aluguel = 0;
                        id_estoque_para_aluguel = 0;
                    }
                    else { MessageBox.Show("[Desconhecido] : Ocorreu um erro durante o processo, \r\ncontato do desenvolvedor comunicando o código: [desconhecido]-Roteador"); }
                }
                else
                {
                    MessageBox.Show("Informe o código da ordem de serviço para continuar", "Código da O.S Inválido");
                    cx_os.Focus();
                }
            }
            else { MessageBox.Show("[Cliente]: Erro, cliente não informado!","Cliente inválido"); }
           
           
        }

        private void chk_tecnico_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_tecnico.Checked == true) { chk_tecnico.ForeColor = Color.Red; }
            else { chk_tecnico.ForeColor = Color.Black; }
        }

        private void bt_pesquisa_alugado_Click(object sender, EventArgs e)
        {
            string texto = "", pesquisa = "";
            texto = cb_texto_3.Text;
            pesquisa = cx_pesquisar_3.Text;
            if ((!String.IsNullOrEmpty(texto) && !String.IsNullOrWhiteSpace(texto)))
            {
                if ((String.IsNullOrEmpty(pesquisa)) || (String.IsNullOrWhiteSpace(pesquisa)))
                { pesquisa = "a"; }
                mostrar_roteador_soAlugado(filial, texto, pesquisa);
            }
            else
            {

                MessageBox.Show("Não é permitido realizado pesquisa com informações ausênte", "Erro!!");
            }
        }

        private void cb_texto_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_texto_3.Text == "") { cx_pesquisar_3.ReadOnly = true; cx_pesquisar_3.Focus(); }
            else { cx_pesquisar_3.ReadOnly = false; }
        }

        private void dg_mostra_alugado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pega id
            try
            {
                roteador_alugado = new Aluguel_Roteador();
                int id = 0;
                id = Convert.ToInt32(dg_mostra_alugado.SelectedCells[0].Value.ToString());
                if (id > 0)
                {
                    gp_alugado.Enabled          = true;
                    lbl_mac_alugado.Text        = dg_mostra_alugado.SelectedCells[4].Value.ToString();
                    lbl_modelo_alugado.Text     = dg_mostra_alugado.SelectedCells[3].Value.ToString();
                    lbl_num_serie_alugado.Text  = dg_mostra_alugado.SelectedCells[5].Value.ToString();
                    lbl_patrimonio_alugado.Text = dg_mostra_alugado.SelectedCells[6].Value.ToString();
                    lbl_preset_alugado.Text     = dg_mostra_alugado.SelectedCells[9].Value.ToString();
                    lbl_codigo_cliente.Text     = dg_mostra_alugado.SelectedCells[1].Value.ToString();
                    lbl_nome_cliente.Text       = dg_mostra_alugado.SelectedCells[2].Value.ToString();
                    lbl_tecnico_alugado.Text    = dg_mostra_alugado.SelectedCells[13].Value.ToString();
                    lbl_os_alugado.Text         = dg_mostra_alugado.SelectedCells[16].Value.ToString();
                    roteador_alugado.alu_ID     = id;
                    id_estoque_alugado          = Convert.ToInt32(dg_mostra_alugado.SelectedCells[11].Value.ToString());
                    estoque_qtd_alugado         = Convert.ToDouble(dg_mostra_alugado.SelectedCells[12].Value.ToString());
                    try { id_user_tecnico_alugado = Convert.ToInt32(dg_mostra_alugado.SelectedCells[14].Value.ToString()); }
                    catch { id_user_tecnico_alugado = 0; }
                   

                }
            }
            catch
            {

                gp_alugado.Enabled = false;
                lbl_mac_alugado.Text        = "???";
                lbl_modelo_alugado.Text     = "???";
                lbl_num_serie_alugado.Text  = "???";
                lbl_patrimonio_alugado.Text = "???";
                lbl_preset_alugado.Text     = "???";
                lbl_codigo_cliente.Text     = "???";
                lbl_nome_cliente.Text       = "???";
                lbl_tecnico_alugado.Text    = "???";
                roteador_alugado.alu_ID     = 0;
                id_estoque_alugado          = 0;
                estoque_qtd_alugado         = 0;
                id_user_tecnico_alugado     = 0;
                lbl_os_alugado.Text         = "";
            }
        }

        private void rb_cliente_cancelou_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cliente_cancelou.Checked == true)
            {
                rb_cliente_cancelou.ForeColor = Color.Red;
            }
            else { rb_cliente_cancelou.ForeColor = Color.Black; }
        }

        private void rb_cliente_devolveu_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cliente_devolveu.Checked == true)
            {
                rb_cliente_devolveu.ForeColor = Color.Red;
            }
            else { rb_cliente_devolveu.ForeColor = Color.Black; }
        }

        private void bt_gravar_devolução_Click(object sender, EventArgs e)
        {
            string motivo = "";
            //Verifica motivo da devolução.
            if (rb_cliente_cancelou.Checked == true) { motivo = "Devolução de equipamento: " + lbl_modelo_alugado.Text + " por cancelamento em:" + DateTime.Now; }
            else if (rb_cliente_devolveu.Checked == true) { motivo = "Devolução de equipamento: " + lbl_modelo_alugado.Text + " em:" + DateTime.Now; }
            //Realiza a devolução
            if (roteador_alugado.alu_ID > 0)
            {
                roteador_alugado.mac_adress = lbl_mac_alugado.Text;
                roteador_alugado.modelo = lbl_modelo_alugado.Text;
                roteador_alugado.num_serie = lbl_num_serie_alugado.Text;
                roteador_alugado.num_patrimonio = lbl_patrimonio_alugado.Text;
                roteador_alugado.preset = lbl_preset_alugado.Text;
                roteador_alugado.cliente = null;
                roteador_alugado.usuario = null;
                roteador_alugado.data_entrada = DateTime.Now.ToString("yyyy-MM-dd");
                roteador_alugado.Est_ID = id_estoque_alugado;
                roteador_alugado.Qtd_atual = estoque_qtd_alugado;

                roteador_alugado.status = 1;

                regra_estoque.roteador_alugar_devolver(roteador_alugado, null);

                mostrar_roteador_geral(filial, "", "");
                mostrar_roteador_soDisponivel(filial, "", "");
                mostrar_roteador_soAlugado(filial, "", "");
                //mostrar_roteador_soTecnico(filial, "", "");

                gp_alugado.Enabled = false;
                lbl_mac_alugado.Text = "???";
                lbl_modelo_alugado.Text = "???";
                lbl_num_serie_alugado.Text = "???";
                lbl_patrimonio_alugado.Text = "???";
                lbl_preset_alugado.Text = "???";
                lbl_codigo_cliente.Text = "???";
                lbl_nome_cliente.Text = "???";
                lbl_tecnico_alugado.Text = "???";
                roteador_alugado.alu_ID = 0;
                id_estoque_alugado = 0;
                estoque_qtd_alugado = 0;
                id_user_tecnico_alugado = 0;
                lbl_os_alugado.Text = "";
                roteador_alugado = null;
            }
            else {

                MessageBox.Show("Opção não informada","Erro!!!");
            }
            

        }

        private void rb_instalado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_instalado.Checked == true)
            {
                rb_instalado.ForeColor = Color.Red;
            }
            else { rb_instalado.ForeColor = Color.Black; }
        }

        private void rb_nao_instalado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nao_instalado.Checked == true)
            {
                rb_nao_instalado.ForeColor = Color.Red;
            }
            else { rb_nao_instalado.ForeColor = Color.Black; }
        }

        private void dg_mostra_roteador_tecnico_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pega id
            try
            {
                roteador_tenico = new Aluguel_Roteador();
                int id = 0;
                id = Convert.ToInt32(dg_mostra_roteador_tecnico.SelectedCells[0].Value.ToString());
                if (id > 0)
                {
                    //Define as label's
                    grp_roteador_tecnico.Enabled = true;
                    lbl_mac_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[4].Value.ToString();
                    lbl_modelo_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[3].Value.ToString();
                    lbl_numeroserie_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[5].Value.ToString();
                    lbl_patrimonio_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[6].Value.ToString();
                    lbl_preset_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[9].Value.ToString();
                    lbl_codigo_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[1].Value.ToString();
                    lbl_nome_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[2].Value.ToString();
                    lbl_nome_user_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[13].Value.ToString();
                    lbl_ordemservico_tecnico.Text = dg_mostra_roteador_tecnico.SelectedCells[16].Value.ToString();

                    //seta objeto roteador_tenico
                    roteador_tenico.alu_ID        = id;
                    roteador_tenico.Est_ID         = Convert.ToInt32(dg_mostra_roteador_tecnico.SelectedCells[11].Value.ToString());
                    roteador_tenico.Qtd_atual      = Convert.ToDouble(dg_mostra_roteador_tecnico.SelectedCells[12].Value.ToString());
                    Usuario user = new Usuario();
                    try { user.Usu_ID = Convert.ToInt32(dg_mostra_roteador_tecnico.SelectedCells[14].Value.ToString()); }
                    catch { user.Usu_ID = 0; }
                    roteador_tenico.usuario        = user;
                    roteador_tenico.mac_adress     = lbl_mac_tecnico.Text;
                    roteador_tenico.modelo         = lbl_modelo_tecnico.Text;
                    roteador_tenico.num_serie      = lbl_numeroserie_tecnico.Text;
                    roteador_tenico.num_patrimonio = lbl_patrimonio_tecnico.Text;
                    roteador_tenico.preset         = lbl_preset_tecnico.Text;
                    roteador_tenico.data_entrada   = dg_mostra_roteador_tecnico.SelectedCells[7].Value.ToString();
                    roteador_tenico.data_saida     = dg_mostra_roteador_tecnico.SelectedCells[8].Value.ToString();
                    Cliente clie = new Cliente();
                    clie.Clie_ID = Convert.ToInt32(dg_mostra_roteador_tecnico.SelectedCells[15].Value.ToString());
                    roteador_tenico.cliente        = clie;
                }
            }
            catch
            {

                grp_roteador_tecnico.Enabled  = false;
                lbl_mac_tecnico.Text          = "???";
                lbl_modelo_tecnico.Text       = "???";
                lbl_numeroserie_tecnico.Text  = "???";
                lbl_patrimonio_tecnico.Text   = "???";
                lbl_preset_tecnico.Text       = "???";
                lbl_codigo_tecnico.Text       = "???";
                lbl_nome_tecnico.Text         = "???";
                lbl_nome_user_tecnico.Text    = "???";
                lbl_ordemservico_tecnico.Text = "???";
            }
        }

        private void bt_pesquisar_4_Click(object sender, EventArgs e)
        {
            string texto = "", pesquisa = "";
            texto = cb_texto_4.Text;
            pesquisa = cx_pesquisar_4.Text;
            if ((!String.IsNullOrEmpty(texto) && !String.IsNullOrWhiteSpace(texto)))
            {
                if ((String.IsNullOrEmpty(pesquisa)) || (String.IsNullOrWhiteSpace(pesquisa)))
                { pesquisa = "a"; }
                mostrar_roteador_soTecnico(filial, texto, pesquisa);
            }
            else
            {

                MessageBox.Show("Não é permitido realizado pesquisa com informações ausênte", "Erro!!");
            }
        }

        private void cb_texto_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_texto_4.Text == "") { cx_pesquisar_4.ReadOnly = true; cx_pesquisar_4.Focus(); }
            else { cx_pesquisar_4.ReadOnly = false; }
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            int acao = 0;
            if (rb_instalado.Checked == true) {

                roteador_tenico.status = 2;
                roteador_tenico.data_saida = DateTime.Now.ToString("yyyy-MM-dd");
                roteador_tenico.data_entrada = null;
                user = roteador_tenico.usuario;
                acao = regra_estoque.roteador_alugar_devolver(roteador_tenico, user);
            }
            if (rb_nao_instalado.Checked == true) {
                roteador_tenico.status = 1;
                roteador_tenico.data_entrada = DateTime.Now.ToString("yyyy-MM-dd");
                roteador_tenico.data_saida = null;
                acao =  regra_estoque.roteador_alugar_devolver(roteador_tenico, null);
            }
            if (acao == 68)
            {
                grp_roteador_tecnico.Enabled = false;
                lbl_mac_tecnico.Text = "???";
                lbl_modelo_tecnico.Text = "???";
                lbl_numeroserie_tecnico.Text = "???";
                lbl_patrimonio_tecnico.Text = "???";
                lbl_preset_tecnico.Text = "???";
                lbl_codigo_tecnico.Text = "???";
                lbl_nome_tecnico.Text = "???";
                lbl_nome_user_tecnico.Text = "???";
                lbl_ordemservico_tecnico.Text = "???";

                mostrar_roteador_geral(filial, "", "");
                mostrar_roteador_soDisponivel(filial, "", "");
                mostrar_roteador_soAlugado(filial, "", "");
                mostrar_roteador_soTecnico(filial, "", "");
                roteador_tenico = null;
            }
            else { MessageBox.Show("[Desconhecido] - Erro, entre em contato com o desenvolvedor!","Erro!!!"); }
        }

        private void bt_pesquisar_1_Click(object sender, EventArgs e)
        {

        }

        private void cb_texto_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            
            var add_roteador = new frm_add_roteador();
            frm_add_roteador.filial_static = filial;
            add_roteador.ShowDialog();
            mostrar_roteador_geral(filial, "", "");
        }
    }
}
