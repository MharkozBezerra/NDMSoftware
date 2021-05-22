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
using Controlador.Controle.DataGrid_Config.DataGrid_Endereco;
using Regras_N.Regra_N_Usuario;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente
{
    public partial class frm_add_endereco : Form
    {
        private Filial filial = null;
        private ComboBox_Filial config_cb_filial = new ComboBox_Filial();
        private ComboBox_Endereco config_cb_endereco = new ComboBox_Endereco();
        private DataGrid_Endereco dg_config = new DataGrid_Endereco();
        private Cidade cidade_add_bairro = null;
        private Bairro_vila bairro_add_rua = null;
        private RN_Endereco regra_endereco = new RN_Endereco();
        private Rua rua_upt = null;
        private Bairro_vila bairro_upt = null;
        public frm_add_endereco()
        {
            InitializeComponent();
        }

        private void frm_add_endereco_Load(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            config_cb_filial.combox_Carregado_Filial(cb_provedor, empresa);
            

        }

        private void cb_provedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial = new Filial();
            try {
                filial.Fili_ID = ((Filial)cb_provedor.SelectedItem).Fili_ID;
                var cb_x = new ComboBox();
                config_cb_endereco.combox_Cidade(cb_cidade, cb_x, filial);
                config_cb_endereco.combox_Cidade(cb_cidade_alterar, cb_x, filial);
                mostra_cidade_grid(filial);
                cidade_add_bairro = null;
                bairro_add_rua = null;
            }
            catch { filial.Fili_ID = 0; }
            bt_incluir_rua.Enabled = false;
        }
        private void cb_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cidade city = new Cidade();
            try
            {
                city.Cid_ID = ((Cidade)cb_cidade.SelectedItem).Cid_ID;
            }
            catch { city.Cid_ID = 0; }
            mostra_bairro_grid(city);
            bt_incluir_rua.Enabled = false;
        }
        private void mostra_cidade_grid(Filial fill) { dg_config.mostra_Cidade(dg_mostra_cidade, fill); }
        private void mostra_bairro_grid(Cidade city) { dg_config.mostra_Bairro(dg_mostra_bairro, city, null); }
        private void mostra_rua_grid(Bairro_vila bairro) { dg_config.mostra_Rua(dg_mostra_rua, bairro, null); }
        private void mostra_bairro_rua_grid(Bairro_vila bairro,Rua rua) { dg_config.mostra_BairoRua(dg_atualizar_endereco, bairro, rua); }
        private void dg_mostra_cidade_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {

                int cidade_id = Convert.ToInt32(dg_mostra_cidade.SelectedCells[0].Value.ToString());

                if (cidade_id > 0) {

                    cidade_add_bairro = new Cidade();
                    cidade_add_bairro.Cid_ID = cidade_id;
                    cidade_add_bairro.Fili_ID = filial.Fili_ID;
                    cidade_add_bairro.Cid_nome = dg_mostra_cidade.SelectedCells[1].Value.ToString();
                    bt_gravar_bairro.Enabled = true;
                   
                    if (cidade_add_bairro.Cid_ID > 0) {
                        mostra_bairro_grid(cidade_add_bairro);
                        cx_pesquisa_bairro.Enabled = true;

                    }
                    else
                    {
                        cidade_add_bairro = null;
                        cx_pesquisa_bairro.Enabled = false;
                    }
                   
                }
            }
            catch {
                bt_gravar_bairro.Enabled = false;
            }
        }
        private void dg_mostra_bairro_rua_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int bairro_id = 0;
                bairro_id = Convert.ToInt32(dg_mostra_bairro_rua.SelectedCells[0].Value.ToString());

                if (bairro_id > 0)
                {

                    bairro_add_rua = new Bairro_vila();
                    bairro_add_rua.Bai_ID = bairro_id;
                    bairro_add_rua.Bai_descricao = dg_mostra_bairro_rua.SelectedCells[1].Value.ToString();

                    if (bairro_add_rua.Bai_ID > 0)
                    {
                        mostra_rua_grid(bairro_add_rua);
                        cx_pesquisa_rua.Text = "";
                        
                        cb_pesquisa_rua.Enabled = true;
                       
                        bt_incluir_rua.Enabled = true;
                    }
                    else
                    {
                        cx_pesquisa_rua.Text = "";
                        cx_pesquisa_rua.Enabled = false;
                        cb_pesquisa_rua.Enabled = false;
                       
                        bt_incluir_rua.Enabled = false;
                    }

                }

            }
            catch
            {
                cx_pesquisa_rua.Text = "";
                cx_pesquisa_rua.Enabled = false;
                cb_pesquisa_rua.Enabled = false;
                bt_pesquisa_rua.Enabled = false;
                bt_incluir_rua.Enabled = false;
                bairro_add_rua = null;
            }
        }
       

        private void bt_pesquisar_bairro_2_Click(object sender, EventArgs e)
        {
            Cidade city = new Cidade();
            try
            {
                city.Cid_ID = ((Cidade)cb_cidade.SelectedItem).Cid_ID;
                Bairro_vila bairro = new Bairro_vila();
                bairro.Bai_descricao = cx_pesquisa_bairro_2.Text;
                dg_config.mostra_Bairro(dg_mostra_bairro_rua, city, bairro);
            }
            catch { }
        }
        private void bt_pesquisa_rua_Click(object sender, EventArgs e)
        {
            string rua = cx_pesquisa_rua.Text;
            Rua r = new Rua();
            if (cb_pesquisa_rua.Text == "RUA")
            {
                r.Rua_descricao = rua;
            }
            else if (cb_pesquisa_rua.Text == "CEP") {
                r.Rua_cep = rua;
            }
            dg_config.mostra_Rua(dg_mostra_rua, bairro_add_rua, r);
        }
        private void bt_gravar_bairro_Click(object sender, EventArgs e)
        {
            if (cidade_add_bairro != null) {

                var frm_add_bairro = new frm_add_endereco_bairro_rua();
                frm_add_endereco_bairro_rua.static_cidade = cidade_add_bairro;
                frm_add_endereco_bairro_rua.o_que_sera_salvo = "salvar_novo_bairro";
                frm_add_bairro.ShowDialog();
                mostra_bairro_grid(cidade_add_bairro);
                cidade_add_bairro = null;
                bt_gravar_bairro.Enabled = false;
            }
        }

        private void bt_incluir_rua_Click(object sender, EventArgs e)
        {
            if (bairro_add_rua != null) {

                var frm_add_rua = new frm_add_endereco_bairro_rua();
                var cidade = new Cidade();
                cidade.Cid_ID = ((Cidade)cb_cidade.SelectedItem).Cid_ID;
                cidade.Cid_nome = cb_cidade.Text;
                frm_add_endereco_bairro_rua.static_cidade = cidade;
                frm_add_endereco_bairro_rua.static_bairro = bairro_add_rua;
                frm_add_endereco_bairro_rua.o_que_sera_salvo = "salvar_nova_rua";
                frm_add_rua.ShowDialog();
                mostra_rua_grid(bairro_add_rua);
                bairro_add_rua = null;
                bt_incluir_rua.Enabled = false;
            }
        }

        private void bt_pesquisar_bairro_Click(object sender, EventArgs e)
        {
            var bairro = new Bairro_vila();
            bairro.Bai_descricao = cx_pesquisa_bairro.Text;
            dg_config.mostra_Bairro(dg_mostra_bairro, cidade_add_bairro, bairro);
        }

        private void cx_pesquisa_bairro_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = cx_pesquisa_bairro.Text;

            if (!String.IsNullOrEmpty(pesquisa) || !String.IsNullOrWhiteSpace(pesquisa)) {
                if (cx_pesquisa_bairro.TextLength > 3)
                {
                    bt_pesquisar_bairro.Enabled = true;
                }
                else { bt_pesquisar_bairro.Enabled = false; }
            }
            else { bt_pesquisar_bairro.Enabled = false; }
        }

        private void cx_pesquisa_rua_TextChanged(object sender, EventArgs e)
        {
            string text = cx_pesquisa_rua.Text;
            if (!String.IsNullOrEmpty(text) || !String.IsNullOrWhiteSpace(text))
            {

                if (cx_pesquisa_rua.TextLength > 2)
                {

                    bt_pesquisa_rua.Enabled = true;
                }
                else { bt_pesquisa_rua.Enabled = false; }
            }
            else { bt_pesquisa_rua.Enabled = false; }
        }

        private void cb_pesquisa_rua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pesquisa_rua.Text != "")
            {
                cx_pesquisa_rua.ReadOnly = false;
                cx_pesquisa_rua.Enabled = true;
            }
            else
            {
                cx_pesquisa_rua.ReadOnly = true;
                cx_pesquisa_rua.Text = "";
            }
        }

        private void cb_cidade_alterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bairro_vila bairro = new Bairro_vila();
            Rua rua = new Rua();
            try
            {
               
                bairro.Cid_ID = ((Bairro_vila)cb_cidade_alterar.SelectedItem).Cid_ID;
                rua.Rua_descricao = "";
                rua.Rua_cep = "";
               
            }
            catch (Exception)
            {
                bairro.Cid_ID = 0;
                rua.Rua_descricao = "";
                rua.Rua_cep = "";
            }
            mostra_bairro_rua_grid(bairro, rua);
        }

        private void dg_atualizar_endereco_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rua_upt = new Rua();
            bairro_upt = new Bairro_vila();
            try
            {
                

                bairro_upt.Bai_descricao = dg_atualizar_endereco.SelectedCells[0].Value.ToString();
                rua_upt.Rua_descricao    = dg_atualizar_endereco.SelectedCells[1].Value.ToString();
                rua_upt.Rua_cep          = dg_atualizar_endereco.SelectedCells[2].Value.ToString();
                bairro_upt.Bai_ID        = Convert.ToInt32(dg_atualizar_endereco.SelectedCells[4].Value.ToString());
                rua_upt.Rua_ID           = Convert.ToInt32(dg_atualizar_endereco.SelectedCells[3].Value.ToString());
                bt_atualizar.Enabled     = true;
                bt_cancelar.Enabled      = true;

                cx_atualizar_bairro.ReadOnly = false;
                cx_atualizar_rua.ReadOnly = false;
                cx_atualizar_cep.ReadOnly = false;

            }
            catch (Exception)
            {

                bairro_upt.Bai_descricao    = "";
                rua_upt.Rua_descricao       = "";
                rua_upt.Rua_cep             = "";
                bairro_upt.Bai_ID           = 0;
                rua_upt.Rua_ID              = 0;
                bt_atualizar.Enabled        = false;
                bt_cancelar.Enabled         = false;

                cx_atualizar_bairro.ReadOnly = true;
                cx_atualizar_rua.ReadOnly   = true;
                cx_atualizar_cep.ReadOnly   = true;

            }

            cx_atualizar_bairro.Text = bairro_upt.Bai_descricao;
            cx_atualizar_rua.Text = rua_upt.Rua_descricao;
            cx_atualizar_cep.Text = rua_upt.Rua_cep;

        }

        private void bt_pesquisar_endereco_Click(object sender, EventArgs e)
        {
            string procurar = cb_pesquisar_endereco.Text;
            pequisar_atualizar_endereço(procurar);
        }
        private void pequisar_atualizar_endereço(string procurar) {

            Cidade cidade = new Cidade();
            
            try
            {
                switch (procurar)
                {
                    case "": break;
                    case "BAIRRO":

                        Bairro_vila bairro = new Bairro_vila();
                        cidade.Cid_ID = ((Cidade)cb_cidade_alterar.SelectedItem).Cid_ID;
                        bairro.Cid_ID = cidade.Cid_ID;
                        bairro.Bai_descricao = cx_pesquisar_endereco.Text;
                        mostra_bairro_rua_grid(bairro, null);
                        break;
                    case "RUA":

                        var rua = new Rua();

                        cidade.Cid_ID = ((Cidade)cb_cidade_alterar.SelectedItem).Cid_ID;
                        rua.Cid_ID = cidade.Cid_ID;
                        rua.Rua_descricao = cx_pesquisar_endereco.Text;
                        rua.Rua_cep = "";
                        mostra_bairro_rua_grid(null, rua);
                        break;
                    case "CEP":
                        var rua_c = new Rua();
                        cidade.Cid_ID = ((Cidade)cb_cidade_alterar.SelectedItem).Cid_ID;
                        rua_c.Cid_ID = cidade.Cid_ID;
                        rua_c.Rua_descricao = "";
                        rua_c.Rua_cep = cx_pesquisar_endereco.Text;
                        mostra_bairro_rua_grid(null, rua_c);

                        break;
                    case null:
                    default:
                        break;
                }
            }
            catch { }

        }

        private void cb_pesquisar_endereco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pesquisar_endereco.Text != "") { cx_pesquisar_endereco.ReadOnly = false; }
            else {
                cx_pesquisar_endereco.ReadOnly = true;
                cx_pesquisar_endereco.Text = "";
            }
        }

        private void cx_pesquisar_endereco_TextChanged(object sender, EventArgs e)
        {
            string text = cx_pesquisar_endereco.Text;
            if (!String.IsNullOrEmpty(text) || !String.IsNullOrWhiteSpace(text)) {

                if (cx_pesquisar_endereco.TextLength > 3)
                {
                    bt_pesquisar_endereco.Enabled = true;

                }
                else { bt_pesquisar_endereco.Enabled = false; }
            }
            else { bt_pesquisar_endereco.Enabled = false; }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            string msg = "[ATENÇÃO!!] Você está preste a realizar uma modificação importante no sistema.\r\n Mesmo assim deseja continuar?";

            DialogResult pergunta = MessageBox.Show(msg,"Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (pergunta == DialogResult.Yes) {

              bairro_upt.Bai_descricao = cx_atualizar_bairro.Text;
              rua_upt.Rua_descricao    = cx_atualizar_rua.Text;
              rua_upt.Rua_cep          = cx_atualizar_cep.Text;
                int[] acao = new int[2];
                msg = "Alterar nome do Bairro / Vila para: " + bairro_upt.Bai_descricao + " ?";
                pergunta = MessageBox.Show(msg, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pergunta == DialogResult.Yes)
                {
                    acao[0] = regra_endereco.atualizar_bairro(bairro_upt);


                }
                else { acao[0] = 1; }
                msg = "Alterar nome da Rua / Avenida Travessa para: " + rua_upt.Rua_descricao + " - "+rua_upt.Rua_cep+" ?";
                pergunta = MessageBox.Show(msg, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pergunta == DialogResult.Yes)
                {
                    acao[1] = regra_endereco.atualizar_rua(rua_upt);

                }
                else { acao[1] = 1; }


                //os dois foram atualizado
                if (acao[0] == 78 && acao[1] == 83)
                {

                    MessageBox.Show("Dados Atualizado com sucesso");

                }
                else if (acao[0] == 79 && acao[1] == 83)
                {
                    //Erro no Bairro.
                    MessageBox.Show("Não foi possível atualizar as informações do bairro, comunique o desenvolverdor sobre [Erro 79]! \r\n Porem houve a atualização da Rua para :" + rua_upt.Rua_descricao + "CEP :" + rua_upt.Rua_cep);

                }
                else if (acao[0] == 78 && acao[1] == 84)
                {
                    //Somente Bairro
                    MessageBox.Show("Não foi possível atualizar as informações da rua, comunique o desenvolverdor sobre [Erro 84]! \r\n Porem houve a atualização do bairro para :" + bairro_upt.Bai_descricao);
                }
                else if (acao[0] == 79 && acao[1] == 84) {
                    MessageBox.Show("Não foi possível atualizar as informações da rua e do bairro, comunique o desenvolverdor sobre [Erro 79] e [Erro 84]! ");
                }
                else if (acao[0] == 1 && (acao[1] == 84 || acao[1]==83))
                {
                    if (acao[1] == 83 ) MessageBox.Show("Rua atualizado com sucesso!");
                    if (acao[1] == 84) MessageBox.Show("Erro: Comunique o desenvolvedor sobre o [ERROR 84]!");
                }
                else if (acao[1] == 1 && (acao[0] == 78 || acao[0] == 79))
                {
                    if (acao[1] == 78) MessageBox.Show("Bairro atualizado com sucesso!");
                    if (acao[1] == 79) MessageBox.Show("Erro: Comunique o desenvolvedor sobre o [ERROR 79]!");
                }

                
                

            }
            string procurar = cb_pesquisar_endereco.Text;
            pequisar_atualizar_endereço(procurar);

            bairro_upt = null;
            rua_upt = null;

           
            bt_atualizar.Enabled = false;
            bt_cancelar.Enabled = false;

            cx_atualizar_bairro.ReadOnly = true;
            cx_atualizar_rua.ReadOnly = true;
            cx_atualizar_cep.ReadOnly = true;

            cx_atualizar_bairro.Text = "";
            cx_atualizar_rua.Text = "";
            cx_atualizar_cep.Text = "";

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            bairro_upt = null;
            rua_upt = null;


            bt_atualizar.Enabled = false;
            bt_cancelar.Enabled = false;

            cx_atualizar_bairro.ReadOnly = true;
            cx_atualizar_rua.ReadOnly = true;
            cx_atualizar_cep.ReadOnly = true;

            cx_atualizar_bairro.Text = "";
            cx_atualizar_rua.Text = "";
            cx_atualizar_cep.Text = "";
        }
    }
}
