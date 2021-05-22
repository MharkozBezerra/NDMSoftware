using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regras_N.Regra_N_Estoque;
using Controlador.Controle.ComboBox_Config;
using Controlador.Controle.DataGrid_Config.DataGrid_Estoque;
using Modelo.Classes;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{

    public partial class frm_add_roteador : Form
    {
        public static Filial filial_static = new Filial();
        private DataGrid_Estoque dg_config = new DataGrid_Estoque();
        private ComboBox_Estoque_Equipamentos cb_config_estoque = new ComboBox_Estoque_Equipamentos();
        private Aluguel_Roteador roteador = null;
        private Estoque estoque = null;
        private RN_Estoque regra_estoque = new RN_Estoque();
        public frm_add_roteador()
        {
            InitializeComponent();
        }

        private void frm_add_roteador_Load(object sender, EventArgs e)
        {
            mostrar_roteador_soDisponivel(filial_static, "", "");
        }
        private void dg_mudar_cor_linha(DataGridView dg)
        {

            foreach (DataGridViewRow row in dg.Rows)
            {
                int status = Convert.ToInt32(row.Cells[10].Value);
                switch (status)
                {

                    case 0:
                    case 1: row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00FF00"); break; //Verde
                    case 2: row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F08080"); break; //Vermelho
                    case 3: row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F0E68C"); break; //Amerelo
                }

            }
        }
        private void mostrar_roteador_soDisponivel(Filial fill, string texto, string pesquisar)
        {
            try
            {
                dg_mostra_geral.DataSource = dg_config.mostra_Roteador(dg_mostra_geral, fill, texto, pesquisar, 1);
                dg_mudar_cor_linha(dg_mostra_geral);
            }
            catch { }
        }

        private void bt_pesquisar_1_Click(object sender, EventArgs e)
        {
            string texto = "", pesquisa = "";
            texto = cb_texto_1.Text;
            pesquisa = cx_pesquisar_1.Text;
            if ((!String.IsNullOrEmpty(texto) && !String.IsNullOrWhiteSpace(texto)) && (!String.IsNullOrEmpty(pesquisa) && !String.IsNullOrWhiteSpace(pesquisa)))
            {
                mostrar_roteador_soDisponivel(filial_static, texto, pesquisa);
            }
            else
            {

                MessageBox.Show("Não é permitido realizado pesquisa com informações ausênte", "Erro!!");
            }
        }

        private void cb_texto_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_texto_1.Text == "") { cx_pesquisar_1.ReadOnly = true; cx_pesquisar_1.Focus(); }
            else { cx_pesquisar_1.ReadOnly = false; }
        }

        private void cx_pesquisar_1_TextChanged(object sender, EventArgs e)
        {
            if (cx_pesquisar_1.TextLength > 0)
            {
                bt_pesquisar_1.Text = "Procurar....";
            }
            else if (cx_pesquisar_1.TextLength < 1)
            {
                bt_pesquisar_1.Text = "Listar....";
            }
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            grp_equipamento.Enabled = true;
            cb_config_estoque.combox_Estoque_Roteador(cb_modelo, filial_static);
            bt_novo.Enabled = false;
            bt_gravar_devolução.Enabled = true;
            bt_atualizar.Enabled = false;
        }

        private void bt_gravar_devolução_Click(object sender, EventArgs e)
        {
            //Verifica se há campo vazio.
            string[] campos = new string[4];
            //Seta compos.
            campos[0] = cx_mac.Text.Replace(":","");
            campos[1] = cx_num_serie.Text;
            campos[2] = cx_patrimonio.Text;
            campos[3] = cx_preset.Text;

            bool continuar = false;



            if (String.IsNullOrEmpty(campos[0]) || String.IsNullOrWhiteSpace(campos[0]))
            {
                cx_mac.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");
            }
            else if (String.IsNullOrEmpty(campos[1]) || String.IsNullOrWhiteSpace(campos[1]))
            {
                cx_num_serie.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");
            }
            else if (String.IsNullOrEmpty(campos[2]) || String.IsNullOrWhiteSpace(campos[2]))
            {
                cx_patrimonio.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");
            }
            else if (String.IsNullOrEmpty(campos[3]) || String.IsNullOrWhiteSpace(campos[3]))
            {
                cx_preset.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");

            }
            else { continuar = true; }


            if (continuar == true && estoque != null) {

                roteador = new Aluguel_Roteador();

                roteador.Est_ID         = estoque.Est_ID;
                roteador.modelo         = cb_modelo.Text;
                roteador.num_patrimonio = cx_patrimonio.Text;
                roteador.num_serie      = cx_num_serie.Text;
                roteador.preset         = cx_preset.Text;
                roteador.Fili_ID        = filial_static.Fili_ID;
                roteador.mac_adress     = cx_mac.Text;
                roteador.data_entrada   = DateTime.Now.ToString("yyyy-MM-dd");
                roteador.status         = 1;

                var acao = regra_estoque.add_a_roteador(roteador);

                if (acao == 53)
                {

                    roteador = null;
                    cx_mac.Text = "";
                    cx_num_serie.Text = "";
                    cx_patrimonio.Text = "";
                    cx_preset.Text = "";
                    mostrar_roteador_soDisponivel(filial_static, "", "");

                }
                else if (acao == 66)
                {
                    MessageBox.Show("Error [66]-> Equipamento já encontra-se cadastrado no banco de dados.");
                }
                else if (acao == 67) {
                    MessageBox.Show("Error [67]-> Entre em contato com o desenvolvedor.");
                }

            }
            
          
        }

        private void cb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            estoque = new Estoque();
            estoque.Est_ID = ((Estoque)cb_modelo.SelectedItem).Est_ID;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            roteador = null;
            cx_mac.Text = "";
            cx_num_serie.Text = "";
            cx_patrimonio.Text = "";
            cx_preset.Text = "";
            estoque = null;
            cb_modelo.Text = "";
            grp_equipamento.Enabled = false;
            bt_novo.Enabled = true;
            if (cb_modelo.Visible == false) {
                cb_modelo.Visible = true;
                lbl_modeloDescricao.Visible = false;
            }
            mostrar_roteador_soDisponivel(filial_static, "", "");
        }

        private void dg_mostra_geral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                int id = Convert.ToInt32(dg_mostra_geral.SelectedCells[0].Value.ToString());
                if (id > 0)
                {
                    bt_novo.Enabled = false;
                    bt_gravar_devolução.Enabled = false;
                    bt_atualizar.Enabled = true;
                    cb_modelo.Visible = false;
                    lbl_modeloDescricao.Visible = true;
                    lbl_modeloDescricao.Location = cb_modelo.Location;
                    grp_equipamento.Enabled = true;

                    roteador = new Aluguel_Roteador();
                    roteador.alu_ID = id;
                    roteador.modelo          = dg_mostra_geral.SelectedCells[3].Value.ToString();
                    roteador.mac_adress      = dg_mostra_geral.SelectedCells[4].Value.ToString();
                    roteador.num_serie       = dg_mostra_geral.SelectedCells[5].Value.ToString();
                    roteador.num_patrimonio  = dg_mostra_geral.SelectedCells[6].Value.ToString();
                    roteador.preset          = dg_mostra_geral.SelectedCells[9].Value.ToString();
                    roteador.status          = Convert.ToInt32(dg_mostra_geral.SelectedCells[10].Value.ToString());
                    roteador.Est_ID          = Convert.ToInt32(dg_mostra_geral.SelectedCells[11].Value.ToString());

                    lbl_modeloDescricao.Text = roteador.modelo;
                    cx_mac.Text              = roteador.mac_adress;
                    cx_num_serie.Text        = roteador.num_serie;
                    cx_patrimonio.Text       = roteador.num_patrimonio;
                    cx_preset.Text           = roteador.preset;
                    

                }
            }
            catch { }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            //Verifica se há campo vazio.
            string[] campos = new string[4];
            //Seta compos.
            campos[0] = cx_mac.Text.Replace(":", "");
            campos[1] = cx_num_serie.Text;
            campos[2] = cx_patrimonio.Text;
            campos[3] = cx_preset.Text;

            bool continuar = false;



            if (String.IsNullOrEmpty(campos[0]) || String.IsNullOrWhiteSpace(campos[0]))
            {
                cx_mac.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");
            }
            else if (String.IsNullOrEmpty(campos[1]) || String.IsNullOrWhiteSpace(campos[1]))
            {
                cx_num_serie.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");
            }
            else if (String.IsNullOrEmpty(campos[2]) || String.IsNullOrWhiteSpace(campos[2]))
            {
                cx_patrimonio.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");
            }
            else if (String.IsNullOrEmpty(campos[3]) || String.IsNullOrWhiteSpace(campos[3]))
            {
                cx_preset.Focus();
                continuar = false;
                MessageBox.Show("Campo obrigatório!");

            }
            else { continuar = true; }

            DialogResult per = MessageBox.Show("Alterar informações desse equipamento?","Atenção",MessageBoxButtons.YesNo);
            if (per == DialogResult.Yes)
            {
                if (continuar == true && (roteador.alu_ID > 0 || roteador != null) )
                {
                    
                    //roteador.modelo = cb_modelo.Text;
                    roteador.num_patrimonio = cx_patrimonio.Text;
                    roteador.num_serie = cx_num_serie.Text;
                    roteador.preset = cx_preset.Text;
                    roteador.Fili_ID = filial_static.Fili_ID;
                    roteador.mac_adress = cx_mac.Text;
                    roteador.data_entrada = DateTime.Now.ToString("yyyy-MM-dd");

                    int acao = regra_estoque.upt_a_roteador(roteador);

                    if (acao == 68) {

                        roteador = null;
                        cx_mac.Text = "";
                        cx_num_serie.Text = "";
                        cx_patrimonio.Text = "";
                        cx_preset.Text = "";
                        mostrar_roteador_soDisponivel(filial_static, "", "");

                        per = MessageBox.Show("Deseja realizar outra modificação?","Continuar",MessageBoxButtons.YesNo);
                        if (per == DialogResult.No)
                        {

                            bt_novo.Enabled = true;
                            bt_gravar_devolução.Enabled = true;
                            bt_atualizar.Enabled = false;
                            cb_modelo.Visible = true;
                            lbl_modeloDescricao.Visible = false;
                            //lbl_modeloDescricao.Location = cb_modelo.Location;
                            grp_equipamento.Enabled = false;
                        }
                        else {

                            MessageBox.Show("Selecione o próximo produto/equipamento!");
                        }
                    }
                }
            }
            }
    }
}
