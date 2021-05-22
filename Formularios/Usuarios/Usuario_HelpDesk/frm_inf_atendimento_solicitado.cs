
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
using Regras_N.Regra_N_Usuario;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    public partial class frm_inf_atendimento_solicitado : Form
    {
        Atendimento atendimento = new Atendimento();
        public static HelpDesk help = new HelpDesk();
        Filial filial_atendimento = new Filial();
        DataGrid_Atendimento dg_config_atendimento = new DataGrid_Atendimento();

        public frm_inf_atendimento_solicitado()
        {
            InitializeComponent();
        }

        private void frm_inf_atendimento_solicitado_Load(object sender, EventArgs e)
        {
            //Carrega dados no Grid.
            mostra_atendimento.DataSource = dg_config_atendimento.mostra_solicitacao_help(mostra_atendimento, help);
            lbl_qtd_atendimento.Text = mostra_atendimento.RowCount.ToString();
        }
        private void informa_dados_grid(DataGridView dg) {

            bt_finalizar.Enabled = false;
            bt_cancelar.Enabled = false;
            cx_dataHora.Text = "";
            cx_provedor.Text = "";
            cx_solicitado.Text = "";
            cx_codCliente.Text = "";
            cx_nomeCliente.Text = "";
            cx_help.Text = "";
            cx_categoria.Text = "";
            cx_Subcategoria.Text = "";
            cx_obs.Text = "";

            Cliente cliente = new Cliente();
            Subcategoria_Atendimento subcategoria = new Subcategoria_Atendimento();
            Categoria_Atendimento categoria = new Categoria_Atendimento();
            RecepcaoVendedor recepcao = new RecepcaoVendedor();
            atendimento.Aten_ID = 0;
            try { atendimento.Aten_ID = Convert.ToInt32(dg.SelectedCells[0].Value.ToString()); }
            catch { atendimento.Aten_ID = 0; }


            if (atendimento.Aten_ID > 0)
            {
                string data = "";
               cx_codCliente.Text   = dg.SelectedCells[1].Value.ToString();
                cx_nomeCliente.Text  = dg.SelectedCells[2].Value.ToString();
                cx_categoria.Text    = dg.SelectedCells[3].Value.ToString();
                cx_Subcategoria.Text = dg.SelectedCells[4].Value.ToString();
                lbl_prioridade.Text  = dg.SelectedCells[5].Value.ToString();
                try
                {
                    data = Convert.ToDateTime(dg.SelectedCells[6].Value).ToString("dd/MM/yyyy");
                }
                catch { data = DateTime.Now.ToString("dd/MM/yyyy"); }
                cx_dataHora.Text     = data;
                cx_help.Text         = dg.SelectedCells[8].Value.ToString();
                cx_solicitado.Text   = dg.SelectedCells[9].Value.ToString();
                categoria.Cate_ID    = Convert.ToInt32(dg.SelectedCells[10].Value.ToString());
                subcategoria.Sub_ID  = Convert.ToInt32(dg.SelectedCells[11].Value.ToString());
                cx_provedor.Text     = dg.SelectedCells[12].Value.ToString();
                cx_obs.Text          = dg.SelectedCells[14].Value.ToString();

                //Trata pioridade 0=Baixa | 1 = média | 2 Alta
                if (lbl_prioridade.Text == "BAIXA") { img_prioridade.Image = Properties.Resources.verde_25x25; }
                else if (lbl_prioridade.Text == "MÉDIA") { img_prioridade.Image = Properties.Resources.amarelo_25x25; }
                else if (lbl_prioridade.Text == "ALTA") { img_prioridade.Image = Properties.Resources.vermelho_25x25; }
                else { img_prioridade.Image = Properties.Resources.verde_25x25; lbl_prioridade.Text = "Baixo"; }
                
                bt_finalizar.Enabled = true;
                bt_cancelar.Enabled = true;
            }
            else {

                bt_finalizar.Enabled = false;
                bt_cancelar.Enabled = false;
                cx_dataHora.Text = "";
                cx_provedor.Text = "";
                cx_solicitado.Text = "";
                cx_codCliente.Text = "";
                cx_nomeCliente.Text = "";
                cx_help.Text = "";
                cx_categoria.Text = "";
                cx_Subcategoria.Text = "";
                cx_obs.Text = "";


            }

        }

        private void mostra_atendimento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            informa_dados_grid(mostra_atendimento); 
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            bt_finalizar.Enabled = false;
            bt_cancelar.Enabled = false;
            cx_dataHora.Text = "";
            cx_provedor.Text = "";
            cx_solicitado.Text = "";
            cx_codCliente.Text = "";
            cx_nomeCliente.Text = "";
            cx_help.Text = "";
            cx_categoria.Text = "";
            cx_Subcategoria.Text = "";
            cx_obs.Text = "";

            //dg_config.mostra_Atendimento_Solicitado(mostra_atendimento, usuario.ID_user_DB());
            lbl_qtd_atendimento.Text = mostra_atendimento.RowCount.ToString();
        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            if (atendimento.Aten_ID > 0)
            {
                DialogResult per_realizar_atendimento = MessageBox.Show("Realizar atendimento?", "Atendimento Solicitado", MessageBoxButtons.YesNo);

                if (per_realizar_atendimento == DialogResult.Yes) {

                    //Seta dados.
                    try
                    {
                        frm_add_Atendimento.atendimento_solicitado = true;
                        frm_add_Atendimento.atendimento_statico = atendimento;
                        frm_add_Atendimento.helpdek_statico = help;
                        //frm_add_Atendimento.filial = filial_atendimento;
                        this.Hide();
                        var fmr_atendimento = new frm_add_Atendimento();
                        fmr_atendimento.ShowDialog();
                        
                    }
                    catch {
                        MessageBox.Show("Erro na solicitação de dados.");
                       
                        return;
                    }

                }
                else {

                    bt_finalizar.Enabled = false;
                    bt_cancelar.Enabled = false;
                    cx_dataHora.Text = "";
                    cx_provedor.Text = "";
                    cx_solicitado.Text = "";
                    cx_codCliente.Text = "";
                    cx_nomeCliente.Text = "";
                    cx_help.Text = "";
                    cx_categoria.Text = "";
                    cx_Subcategoria.Text = "";
                    cx_obs.Text = "";



                    //Carrega dados no Grid.
                    //dg_config.mostra_Atendimento_Solicitado(mostra_atendimento, usuario.ID_user_DB());
                    lbl_qtd_atendimento.Text = mostra_atendimento.RowCount.ToString();
                }

            }
            else { MessageBox.Show("Atendimento não selecionado","Error");}
            }
    }
}
