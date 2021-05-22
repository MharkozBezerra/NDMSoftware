using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Classes_Relatorio;
using Modelo.Classes;
using Controlador.Controle.ComboBox_Config;
using Regras_N.Regra_N_Estoque;
using Microsoft.Reporting.WinForms;

namespace NDM_SoftwareV5.Formularios.Relatorios.Estoque
{
    public partial class frm_reltatorio_estoque : Form
    {
        int ano, mes;
        string data_1, data_2;
        public static string tipo_relatorio = null;
        private bool buscar_por_fornecedor = false;
        private bool buscar_por_usuario = false;
        private int tipo_busca_roteador = 0;

        Filial              filial = null;
        ComboBox_Filial cb_filial_config = new ComboBox_Filial();
        Fornecedor fornecedor = null;
        Usuario usuario = null;
        RN_Relatorio regra_relatorio = new RN_Relatorio();
        private void cb_provedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial = new Filial();
            filial.Fili_ID = ((Filial)cb_provedor.SelectedItem).Fili_ID;
        }
        private void rb_mensal_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_mensal.Checked == true)
            {

                gp_mensal.Visible = true;
                gp_mensal.Enabled = true;
                cx_ano.Text = DateTime.Now.Year.ToString();
                if (tipo_relatorio == "Controle_Entrada")
                { chk_fornecedor.Enabled = true; }
                else if (tipo_relatorio == "Controle_Saida")
                { chk_usuario.Enabled = true; }

                if (chk_usuario.Checked == true || chk_fornecedor.Checked == true)
                {
                    switch (tipo_relatorio)
                    {
                        case "Controle_Geral": break;
                        case "Controle_Entrada":
                        case "Controle_Saida":

                            gp_usuario.Location = gp_data.Location;
                            gp_fornecedor.Location = gp_data.Location;
                            gp_data.Visible = false;

                            break;
                        case "Roteador_Geral": 
                        case "Roteador_Alugado":
                        case "Roteador_Disponivel":
                        case "Roteador_Aguardando":
                            chk_usuario.Enabled = true;
                            gp_mensal.Enabled = false;
                            gp_usuario.Location = gp_data.Location;
                            gp_data.Visible = false;
                            gp_roteador.Enabled = true;

                            break;
                        default: break;
                    }

                }
            }
            else
            {
                gp_mensal.Enabled = false;
                gp_data.Visible = true;
            }
            if (tipo_relatorio == "Roteador_Geral" ||
                       tipo_relatorio == "Roteador_Alugado" ||
                       tipo_relatorio == "Roteador_Disponivel" ||
                       tipo_relatorio == "Roteador_Aguardando") {
                gp_roteador.Enabled = true;
                chk_usuario.Enabled = true;
            }


        }

        private void rb_data_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_data.Checked == true)
            {
                var data = DateTime.Now.ToString("dd/MM/yyyy");
               
                cx_data_1.Text = data;
                cx_data_2.Text = data;
                gp_data.Enabled = true;

                if (tipo_relatorio == "Controle_Entrada")
                { chk_fornecedor.Enabled = true; }
                else if (tipo_relatorio == "Controle_Saida")
                { chk_usuario.Enabled = true; }
                
                
                if (chk_usuario.Checked == true || chk_fornecedor.Checked == true)
                {
                    switch (tipo_relatorio)
                    {
                        case "Controle_Geral": break;
                        case "Controle_Entrada":
                        case "Controle_Saida":

                            gp_usuario.Location = gp_mensal.Location;
                            gp_fornecedor.Location = gp_mensal.Location;
                            gp_mensal.Visible = false;

                            break;
                        case "Roteador_Geral": break;
                        case "Roteador_Alugado":
                        case "Roteador_Disponivel":

                            gp_usuario.Location = gp_mensal.Location;
                            gp_fornecedor.Location = gp_mensal.Location;
                            gp_mensal.Visible = false;

                            break;
                        case "Roteador_Aguardando":

                            gp_usuario.Location = gp_data.Location;
                            gp_mensal.Visible = false;

                            break;
                        default: break;
                    }
                }
                
            }
            else {
                gp_data.Enabled = false;
                cx_data_1.Text = "";
                cx_data_2.Text = "";
            }
        }

        private void cb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cb_mes.Text) {

                case ("JANEIRO"):   mes = 1; break;
                case ("FEVEREIRO"): mes = 2; break;
                case ("MARÇO"):     mes = 3; break;
                case ("ABRIL"):     mes = 4; break;
                case ("MAIO"):      mes = 5; break;
                case ("JUNHO"):     mes = 6; break;
                case ("JULHO"):     mes = 7; break;
                case ("AGOSTO"):    mes = 8; break;
                case ("SETEMBRO"):  mes = 9; break;
                case ("OUTUBRO"):   mes = 10; break;
                case ("NOVEMBRO"):  mes = 11; break;
                case ("DEZEMBRO"):  mes = 12; break;
                default: mes = DateTime.Now.Month; break;
            }
        }

        public frm_reltatorio_estoque()
        {
            InitializeComponent();
        }

        private void bt_mensal_Click(object sender, EventArgs e)
        {
            carrega_relatorio_estoque(tipo_relatorio, 0);

        }

        private void bt_data_Click(object sender, EventArgs e)
        {

            carrega_relatorio_estoque(tipo_relatorio, 1);
           
            
        }

        private void frm_reltatorio_estoque_Load(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            cb_filial_config.combox_Carregado_Filial(cb_provedor, empresa);

            gp_relatorio.Size = new Size(781, 499);
            switch (tipo_relatorio)
            {
                case "Controle_Geral":  break;
                case "Controle_Entrada":
                case "Controle_Saida":
                    chk_usuario.Visible = true;
                    chk_fornecedor.Visible = true;
                    break;
                case "Roteador_Geral":
                case "Roteador_Alugado": 
                case "Roteador_Disponivel":
                case "Roteador_Aguardando":
                    gp_mensal.Enabled = false;
                    gp_data.Enabled = false;
                    rb_mensal.Text = "Liberar Pesquisa";
                    rb_data.Visible = false;
                    chk_usuario.Visible = true;
                    bt_buscar_roteador.Visible = true;
                    gp_roteador.Visible = true;   
                 
                        break;
                default:  break;
            }


            this.rpt_local.RefreshReport();
        }

        private void carrega_relatorio_estoque(string use_report,int tipo) {

            
           
            
            
            switch (tipo_relatorio)
            {
                case "Controle_Geral":   relatorio_Estoque_Geral(tipo);                               break;
                case "Controle_Entrada": relatorio_Estoque_Entrada(tipo, buscar_por_fornecedor);      break;
                case "Controle_Saida":   relatorio_Estoque_Saida(tipo,buscar_por_usuario);            break;
                case "Roteador_Geral":  
                case "Roteador_Alugado":   
                case "Roteador_Disponivel":
                case "Roteador_Aguardando":
                    relatorio_Roteador_Geral(tipo, buscar_por_usuario); break;
                default: relatorio_Estoque_Geral(tipo);         break;
            }
          
        }

        private void relatorio_Estoque_Geral(int tipo) {
            RLT_Estoque rlt_estoque = new RLT_Estoque();
            this.rpt_local.Reset();
            try
            {
                rlt_estoque.Fili_ID = filial.Fili_ID;

                string a = cx_ano.Text;
                if (rb_mensal.Checked == true)
                {
                    if (!String.IsNullOrEmpty(a) || !String.IsNullOrWhiteSpace(a))
                    {

                        ano = Convert.ToInt32(cx_ano.Text);
                        rlt_estoque.mes = mes;
                        rlt_estoque.ano = ano;

                    }
                    else { MessageBox.Show("Campo ano não pode estar vazio para realizar essa função"); }
                }
                else if (rb_data.Checked == true)
                {

                    try
                    {
                        data_1 = Convert.ToDateTime(cx_data_1.Text).ToString("yyyy-MM-dd");
                        data_2 = Convert.ToDateTime(cx_data_2.Text).ToString("yyyy-MM-dd");
                        rlt_estoque.data_1 = data_1;
                        rlt_estoque.data_2 = data_2;

                    }

                    catch {  MessageBox.Show("Erro: Campo data está incorreto para essa ação!");}

                    }
              


                    RLT_Filial rltfilial = new RLT_Filial();
                    rltfilial.filial_ID = filial.Fili_ID;

                    List<RLT_Estoque> DS_Controle = null;
                    List<RLT_Filial> DS_Filial    = null;

                    ReportDataSource rpt_NomeFilial = null;
                    ReportDataSource rpt_Controle = null;
                    string use_report = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_entrada_saida.rdlc";

                    this.rpt_local.LocalReport.ReportEmbeddedResource = use_report;
                    

                    DS_Controle = regra_relatorio.relatorio_entrada_saida_estoque(rlt_estoque, tipo);
                    DS_Filial = regra_relatorio.relatorio_nome_filial(rltfilial);
                    rpt_Controle = new ReportDataSource("DST_Controle_Estoque_EntradaSaida", DS_Controle);
                    rpt_NomeFilial = new ReportDataSource("DST_Filial", DS_Filial);

                    rpt_local.LocalReport.DataSources.Clear();
                    rpt_local.LocalReport.DataSources.Add(rpt_NomeFilial);
                    rpt_local.LocalReport.DataSources.Add(rpt_Controle);
                    rpt_local.RefreshReport();
                
               
            }
            catch { MessageBox.Show("Erro[Desconhecido]-> Contate o desenvolvedor"); }
        }
        private void relatorio_Estoque_Entrada(int tipo, bool porFornecedor) {

            RLT_Filial rltfilial = new RLT_Filial();
            rltfilial.filial_ID = filial.Fili_ID;
            RLT_Estoque_entrada rlt_entrda = new RLT_Estoque_entrada();
            RLT_Fornecedor rl_forncedor = new RLT_Fornecedor();
            this.rpt_local.Reset();
            try
            {
                rlt_entrda.Fili_ID = filial.Fili_ID;

                string a = cx_ano.Text;
                if (rb_mensal.Checked == true)
                {
                    if (!String.IsNullOrEmpty(a) || !String.IsNullOrWhiteSpace(a))
                    {

                        ano = Convert.ToInt32(cx_ano.Text);
                        rlt_entrda.mes = mes;
                        rlt_entrda.ano = ano;

                    }
                    else { MessageBox.Show("Campo ano não pode estar vazio para realizar essa função"); }
                }
                else if (rb_data.Checked == true)
                {

                    try
                    {
                        data_1 = Convert.ToDateTime(cx_data_1.Text).ToString("yyyy-MM-dd");
                        data_2 = Convert.ToDateTime(cx_data_2.Text).ToString("yyyy-MM-dd");
                        rlt_entrda.data_1 = data_1;
                        rlt_entrda.data_2 = data_2;

                    }

                    catch { MessageBox.Show("Erro: Campo data está incorreto para essa ação!"); }

                }

                try {
                    if (fornecedor != null)
                    {
                       
                        rl_forncedor.for_ID = fornecedor.for_ID;

                        if (porFornecedor == true)
                        {
                            rlt_entrda.fornecedor_ID = rl_forncedor.for_ID;


                        }
                    }
                    else { rl_forncedor.for_ID = 0; }
                    
                }
                catch {

                    rl_forncedor.for_ID = 0;
                    rlt_entrda.fornecedor_ID = rl_forncedor.for_ID;

                }
            rlt_entrda.mes = mes;
            rlt_entrda.ano = ano;
            rlt_entrda.data_1 = data_1;
            rlt_entrda.data_2 = data_2;

            List<RLT_Estoque_entrada> DS_Entrada = null;
            List<RLT_Filial> DS_Filial = null;
            List<RLT_Fornecedor> DS_Fornecedor = null;

            ReportDataSource rpt_NomeFilial = null;
            ReportDataSource rpt_Controle = null;
            ReportDataSource rpt_fornecedor = null;
            string use_report  = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_entrada.rdlc";

            this.rpt_local.LocalReport.ReportEmbeddedResource = use_report;





            DS_Entrada      = regra_relatorio.relatorio_controle_entrada(rlt_entrda, tipo, porFornecedor);
            DS_Filial       = regra_relatorio.relatorio_nome_filial(rltfilial);
            DS_Fornecedor   = regra_relatorio.relatorio_nome_Fornecedor(rl_forncedor, false);
            rpt_Controle    = new ReportDataSource("DST_Estoque_Entrada", DS_Entrada);
            rpt_NomeFilial  = new ReportDataSource("DST_Filial", DS_Filial);
            rpt_fornecedor  = new ReportDataSource("DST_Fornecedor", DS_Fornecedor);

            rpt_local.LocalReport.DataSources.Clear();
            rpt_local.LocalReport.DataSources.Add(rpt_NomeFilial);
            rpt_local.LocalReport.DataSources.Add(rpt_Controle);
            rpt_local.LocalReport.DataSources.Add(rpt_fornecedor);
            rpt_local.RefreshReport();
            }
            catch { MessageBox.Show("Erro[Desconhecido]-> Contate o desenvolvedor"); }
            fornecedor = null;
        }
        private void relatorio_Estoque_Saida(int tipo, bool porUsuario) {

            RLT_Filial rltfilial = new RLT_Filial();
            rltfilial.filial_ID = filial.Fili_ID;
            RLT_Estoque_saida rlt_saida = new RLT_Estoque_saida();
            RLT_Usuario rl_usuario = new RLT_Usuario();
            this.rpt_local.Reset();
            try
            {
                rlt_saida.Fili_ID = filial.Fili_ID;

                string a = cx_ano.Text;
                if (rb_mensal.Checked == true)
                {
                    if (!String.IsNullOrEmpty(a) || !String.IsNullOrWhiteSpace(a))
                    {

                        ano = Convert.ToInt32(cx_ano.Text);
                        rlt_saida.mes = mes;
                        rlt_saida.ano = ano;

                    }
                    else { MessageBox.Show("Campo ano não pode estar vazio para realizar essa função"); }
                }
                else if (rb_data.Checked == true)
                {

                    try
                    {
                        data_1 = Convert.ToDateTime(cx_data_1.Text).ToString("yyyy-MM-dd");
                        data_2 = Convert.ToDateTime(cx_data_2.Text).ToString("yyyy-MM-dd");
                        rlt_saida.data_1 = data_1;
                        rlt_saida.data_2 = data_2;

                    }

                    catch { MessageBox.Show("Erro: Campo data está incorreto para essa ação!"); }

                }

                try
                {
                    if (usuario != null)
                    {

                        rl_usuario.Usu_ID = usuario.Usu_ID;

                        if (porUsuario == true)
                        {
                            rlt_saida.id_pego_por = rl_usuario.Usu_ID;


                        }
                    }
                    else { rl_usuario.Usu_ID = 0; }

                }
                catch
                {

                    rl_usuario.Usu_ID = 0;
                    rlt_saida.id_pego_por = rl_usuario.Usu_ID;

                }
                rlt_saida.mes = mes;
                rlt_saida.ano = ano;
                rlt_saida.data_1 = data_1;
                rlt_saida.data_2 = data_2;

                List<RLT_Estoque_saida> DS_Saida = null;
                List<RLT_Filial> DS_Filial = null;
                List<RLT_Usuario> DS_Usuario = null;

                ReportDataSource rpt_NomeFilial = null;
                ReportDataSource rpt_Controle = null;
                ReportDataSource rpt_usuario = null;
                string use_report = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_saida.rdlc";

                this.rpt_local.LocalReport.ReportEmbeddedResource = use_report;





                DS_Saida = regra_relatorio.relatorio_controle_saida(rlt_saida, tipo, porUsuario);
                DS_Filial = regra_relatorio.relatorio_nome_filial(rltfilial);
                DS_Usuario = regra_relatorio.relatorio_nome_Usuario(rl_usuario, false);
                rpt_Controle = new ReportDataSource("DST_Estoque_Saida", DS_Saida);
                rpt_NomeFilial = new ReportDataSource("DST_Filial", DS_Filial);
                rpt_usuario = new ReportDataSource("DST_Usuario", DS_Usuario);

                rpt_local.LocalReport.DataSources.Clear();
                rpt_local.LocalReport.DataSources.Add(rpt_NomeFilial);
                rpt_local.LocalReport.DataSources.Add(rpt_Controle);
                rpt_local.LocalReport.DataSources.Add(rpt_usuario);
                rpt_local.RefreshReport();
            }
            catch { MessageBox.Show("Erro[Desconhecido]-> Contate o desenvolvedor"); }

            usuario = null;

        }
        private void relatorio_Roteador_Geral(int tipo, bool porUsuario)
        {

            RLT_Filial rltfilial = new RLT_Filial();
            rltfilial.filial_ID = filial.Fili_ID;
            RLT_Roteador rlt_roteador = new RLT_Roteador();
            RLT_Usuario rl_usuario = new RLT_Usuario();
            this.rpt_local.Reset();
            try
            {
                rlt_roteador.filial_codigo = filial.Fili_ID;

                string a = cx_ano.Text;
                if (rb_mensal.Checked == true)
                {
                    if (!String.IsNullOrEmpty(a) || !String.IsNullOrWhiteSpace(a))
                    {

                        ano = Convert.ToInt32(cx_ano.Text);
                        rlt_roteador.mes = mes;
                        rlt_roteador.ano = ano;

                    }
                    else { MessageBox.Show("Campo ano não pode estar vazio para realizar essa função"); }
                }
                else if (rb_data.Checked == true)
                {

                    try
                    {
                        data_1 = Convert.ToDateTime(cx_data_1.Text).ToString("yyyy-MM-dd");
                        data_2 = Convert.ToDateTime(cx_data_2.Text).ToString("yyyy-MM-dd");
                        rlt_roteador.data_1 = data_1;
                        rlt_roteador.data_2 = data_2;

                    }

                    catch { MessageBox.Show("Erro: Campo data está incorreto para essa ação!"); }

                }

                try
                {
                    if (usuario != null)
                    {

                        rl_usuario.Usu_ID = usuario.Usu_ID;

                        if (porUsuario == true)
                        {
                            rlt_roteador.tecnico_codigo = rl_usuario.Usu_ID;


                        }
                    }
                    else { rl_usuario.Usu_ID = 0; }

                }
                catch
                {

                    rl_usuario.Usu_ID = 0;
                    rlt_roteador.tecnico_codigo = rl_usuario.Usu_ID;

                }
                rlt_roteador.mes = mes;
                rlt_roteador.ano = ano;
                rlt_roteador.data_1 = data_1;
                rlt_roteador.data_2 = data_2;

                List<RLT_Roteador> DS_Roteador = null;
                List<RLT_Filial> DS_Filial = null;
                List<RLT_Usuario> DS_Usuario = null;

                ReportDataSource rpt_NomeFilial = null;
                ReportDataSource rpt_Controle = null;
                ReportDataSource rpt_usuario = null;

                string use_report = "";

                switch (tipo_relatorio)
                {

                    case "Roteador_Geral":      use_report = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_roteador.rdlc"; break;
                    case "Roteador_Alugado":    use_report = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_roteador_alugado.rdlc"; break;
                    case "Roteador_Disponivel": use_report = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_roteador_disponivel.rdlc"; break;
                    case "Roteador_Aguardando": use_report = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_roteador_aguardando.rdlc"; break;
                    default:                    use_report = "NDM_SoftwareV5.Formularios.Relatorios.Reports.RPT_Controle_estoque_roteador.rdlc"; break;
                }  

                        this.rpt_local.LocalReport.ReportEmbeddedResource = use_report;





                DS_Roteador = regra_relatorio.relatorio_controle_roteador(rlt_roteador, tipo, porUsuario);
                DS_Filial = regra_relatorio.relatorio_nome_filial(rltfilial);
                DS_Usuario = regra_relatorio.relatorio_nome_Usuario(rl_usuario, false);
                rpt_Controle = new ReportDataSource("DST_Roteador", DS_Roteador);
                rpt_NomeFilial = new ReportDataSource("DST_Filial", DS_Filial);
                rpt_usuario = new ReportDataSource("DST_Usuario", DS_Usuario);

                rpt_local.LocalReport.DataSources.Clear();
                rpt_local.LocalReport.DataSources.Add(rpt_NomeFilial);
                rpt_local.LocalReport.DataSources.Add(rpt_Controle);
                rpt_local.LocalReport.DataSources.Add(rpt_usuario);
                rpt_local.RefreshReport();
            }
            catch { MessageBox.Show("Erro[Desconhecido]-> Contate o desenvolvedor"); }

            usuario = null;

        }


        private void chk_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_usuario.Checked == true && (rb_data.Checked == true || rb_mensal.Checked == true))
            {
                gp_usuario.Visible = true;
                chk_fornecedor.Checked = false;
                if (rb_data.Checked == true)
                {
                    gp_data.Visible = true;
                    gp_usuario.Location = gp_mensal.Location;
                    gp_mensal.Visible = false;
                }
                if (rb_mensal.Checked == true)
                {
                    gp_usuario.Location = gp_data.Location;
                    gp_mensal.Visible = true;
                    gp_data.Visible = false;
                }
            }
            else {
                if (chk_fornecedor.Checked == false)
                {
                    if (tipo_relatorio != "Roteador_Geral" ||
                       tipo_relatorio != "Roteador_Alugado" ||
                       tipo_relatorio != "Roteador_Disponivel" ||
                       tipo_relatorio != "Roteador_Aguardando")
                    {
                        if (rb_data.Checked == true) { gp_data.Visible = true; }
                        if (rb_mensal.Checked == true) { gp_mensal.Visible = true; }
                    }
                }
                gp_usuario.Visible = false;

            }
            if (chk_usuario.Checked == true) {
                var cb_config = new ComboBox_Usuarios();
                cb_config.combox_Usuario(cb_usuario_retirada, filial);
                buscar_por_usuario = true; }
            else { buscar_por_usuario = false; }
        }

        private void chk_fornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_fornecedor.Checked == true && (rb_data.Checked == true || rb_mensal.Checked == true) )
            {
                if (rb_data.Checked == true)
                {
                    gp_fornecedor.Location = gp_mensal.Location;
                    gp_data.Visible = true;
                    gp_mensal.Visible = false;
                }
                if (rb_mensal.Checked == true)
                {
                    gp_fornecedor.Location = gp_data.Location;
                    gp_mensal.Visible = true;
                    gp_data.Visible = false;
                }
                gp_fornecedor.Visible = true;
                chk_usuario.Checked = false;
            }
            else {
                if (chk_usuario.Checked == false)
                {
                    if (rb_data.Checked == true) { gp_data.Visible = true; }
                    if (rb_mensal.Checked == true) { gp_mensal.Visible = true; }
                }
                    gp_fornecedor.Visible = false;
            }
            if (chk_fornecedor.Checked == true) {
                var cb_config = new ComboBox_Usuarios();
                cb_config.combox_Fornecedor(cb_fornecedor, filial);
                buscar_por_fornecedor = true; }
            else { buscar_por_fornecedor = false; }
        }

        private void cb_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            fornecedor = new Fornecedor();
            fornecedor.for_ID = ((Fornecedor)cb_fornecedor.SelectedItem).for_ID;
          
        }

        private void cb_usuario_retirada_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.Usu_ID = ((Usuario)cb_usuario_retirada.SelectedItem).Usu_ID;
        }

        private void bt_buscar_roteador_Click(object sender, EventArgs e)
        {
          
            carrega_relatorio_estoque(tipo_relatorio, tipo_busca_roteador); 
    
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipo_busca_roteador = 0;
            tipo_relatorio = "Roteador_Geral";
        }

        private void rb_roteador_disponivel_CheckedChanged(object sender, EventArgs e)
        {
            tipo_busca_roteador = 1;
            tipo_relatorio = "Roteador_Disponivel";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipo_busca_roteador = 2;
            tipo_relatorio = "Roteador_Alugado";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipo_busca_roteador = 3;
            tipo_relatorio = "Roteador_Aguardando";
        }

        
    }
}
