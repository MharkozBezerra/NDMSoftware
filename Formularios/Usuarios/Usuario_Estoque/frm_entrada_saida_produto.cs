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
using Controlador.Controle.DataGrid_Config.DataGrid_Estoque;
using Controlador.Controle.ComboBox_Config;
using Regras_N.Regra_N_Estoque;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    public partial class frm_entrada_saida_produto : Form
    {
        public static string acao;
        public static Filial filial_statica = new Filial();
        RN_Estoque regra_estoque = new RN_Estoque();
        DataGrid_Estoque dg_config = new DataGrid_Estoque();
        ComboBox_Usuarios cb_config = new ComboBox_Usuarios();
        Usuario usuario = new Usuario();
        Estoque estoque = null;
        //Usado para pegar o ID do estoque no form list.
        public static int get_id_estoque = 0; 
        public frm_entrada_saida_produto()
        {
            InitializeComponent();
        }

        private void frm_entrada_saida_produto_Load(object sender, EventArgs e)
        {
            var data_sistema = DateTime.Now.ToString("dd/MM/yyyy");
            if (acao == "entrada") {
                grp_saida.Visible = false;
                cx_data_entrada.Text = data_sistema;
            }
            if (acao == "saida")
            {
                grp_saida.Location = grp_entrada.Location;
                grp_entrada.Visible = false;
                cx_data_saida.Text = data_sistema;
                cb_config.combox_Usuario(cb_usuario_saida, filial_statica);
            }
            lbl_descricao.Text = "Descrição de " + acao + "(s) de produto(s).";
            cx_ID.Text = "Digite : " + acao +" - "+ data_sistema + ", para pesquisar!!";
            cx_id_estoque.Focus();
        }

        private void bt_bucar_produto_Click(object sender, EventArgs e)
        {
            string codigo = cx_id_estoque.Text;

            if (!String.IsNullOrWhiteSpace(codigo)) {
                try
                {
                    //->´pega código número
                    var id = Convert.ToInt32(codigo);
                    estoque = new Estoque();
                    estoque.Est_ID = id;
                    get_id_estoque = regra_estoque.get_id_estoque(estoque);
                    estoque = null;
                }
                catch
                {
                    get_id_estoque = 0;
                    var lista_produto = new frm_lista_produto_estoque();
                    frm_lista_produto_estoque.filial_static = filial_statica;
                    lista_produto.ShowDialog();
                }
               
            }
            if (get_id_estoque == 0) {

                get_id_estoque = 0;
                var lista_produto = new frm_lista_produto_estoque();
                frm_lista_produto_estoque.filial_static = filial_statica;
                lista_produto.ShowDialog();
            }
            

            if (get_id_estoque > 0) {
                //Cria-se o objeto estoque
                estoque = new Estoque();

                //Seta id do estoque.
                estoque.Est_ID = get_id_estoque;
                //Procura por esse objeto no banco de dados
                estoque = regra_estoque.recuperar_estoque(estoque);

                //->Carrega informações do estoque, recuperada do banco de dados.
                cx_id_estoque.Text  = estoque.Est_ID.ToString();
                cx_cod_interno.Text = estoque.produto.Prod_codigo_interno;
                cx_cod_externo.Text = estoque.produto.Prod_codigo_externo;
                cx_unidade.Text     = estoque.produto.unidade.descricao;
                cx_qtd_atual.Text   = estoque.Qtd_atual.ToString();
                cx_descricao.Text   = estoque.produto.Prod_descricao;

            }
            codigo = "";
        }
        private void limpa_caixas() {
            //Entrada
            cx_id_estoque.Text  = "";
            cx_cod_interno.Text = "";
            cx_cod_externo.Text = "";
            cx_unidade.Text     = "";
            cx_qtd_atual.Text   = "";
            cx_descricao.Text   = "";
            cb_motivo_entrada.Text = "";
            cx_qtd_entrada.Text = "0";
            //Saida
            cb_motivo_saida.Text = "";
            cx_qtd_saida.Text = "0";
            estoque = null;

        }

        private void bt_gravar_entrada_Click(object sender, EventArgs e)
        {


            //Dá entrada no produto.

            if (acao == "entrada" && estoque != null)
            {
                if (cb_motivo_entrada.Text != "" && cx_qtd_entrada.Text != "")
                {
                    string nota_f = "Entrada - " + cx_data_entrada.Text;
                    double qtd = Convert.ToDouble(cx_qtd_entrada.Text);
                    var data = Convert.ToDateTime(cx_data_entrada.Text).ToString("yyyy-MM-dd");
                    var acao_entrada = regra_estoque.estoque_entrada_saida(estoque, 1, qtd, nota_f, cb_motivo_entrada.Text, null);
                    dg_mostra_entrada_saida.DataSource = dg_config.mostra_Estoque_entrada_saida(dg_mostra_entrada_saida, filial_statica, nota_f, 1);
                    if (acao_entrada == 63)
                    {
                        MessageBox.Show("[63]-Ocorreu um erro durante o processo, comunicque o desenvolvedor.");
                    }
                }
            }
            else {

                MessageBox.Show("Erro: Item não informado");
            }
               
                
                //Atualiza  o grid Identificação.

                //Atualiza o grid de entrada.
                limpa_caixas();
            }
        

        private void cx_qtd_entrada_Leave(object sender, EventArgs e)
        {
            double qtd = 0;
            try
            {

                qtd = Convert.ToDouble(cx_qtd_entrada.Text);
                if (qtd <= 0) {

                    MessageBox.Show("A Entrada não pode ser menor ou igual a Zero.","Atenção");
                    cx_qtd_entrada.Text = "1";
                    cx_qtd_entrada.Focus();
                }
            }
            catch {
                MessageBox.Show("Valor informado está incorreto.");
                cx_qtd_entrada.Text = "1";
                cx_qtd_entrada.Focus();
            }
        }

        private void cx_data_entrada_Leave(object sender, EventArgs e)
        {
            try {
                DateTime data_validade = Convert.ToDateTime(cx_data_entrada.Text);
                cx_data_entrada.Text = data_validade.ToString("dd/MM/yyyy");
                if (data_validade.Year < 2000)
                {
                    MessageBox.Show("Atenção: Valor abaixo de 2000 não é aceito", " ~[Ano inválido]~ ");
                    cx_data_entrada.Focus();

                }
            }
            catch {
                MessageBox.Show("Erro: Data informada é invalida!");
                cx_data_entrada.Focus();

            }
        }

        private void bt_buscar_identificacao_Click(object sender, EventArgs e)
        {
            int i_acao = 0;
            if (acao == "entrada") { i_acao = 1; }
            else if (acao == "saida") { i_acao = 0; }
            string texto_pesquisa = cx_ID.Text;
            if (!String.IsNullOrEmpty(texto_pesquisa))
            {
                dg_mostra_entrada_saida.DataSource = dg_config.mostra_Estoque_entrada_saida(dg_mostra_entrada_saida, filial_statica, texto_pesquisa, i_acao);
            }
            }

        private void cx_qtd_saida_Leave(object sender, EventArgs e)
        {
            double qtd_atual = 0;
            double qtd = 0;
            try
            {
                qtd_atual = Convert.ToDouble(cx_qtd_atual.Text);
                qtd = Convert.ToDouble(cx_qtd_saida.Text);
                if (qtd >  qtd_atual)
                {

                    MessageBox.Show("Valor solicitado é maior que a quantidade que tem no estoque", "Atenção");
                    cx_qtd_saida.Text = cx_qtd_atual.Text;
                    cx_qtd_saida.Focus();
                }
                if (qtd < 0) {

                    MessageBox.Show("Não pode realizar solicitação abaixo de 0", "Atenção");
                    cx_qtd_saida.Text = "0";
                    cx_qtd_saida.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Valor informado está incorreto.");
                cx_qtd_saida.Text = "0";
                cx_qtd_saida.Focus();
            }
        }

        private void cx_ID_Enter(object sender, EventArgs e)
        {
            var data_sistema = DateTime.Now.ToString("dd/MM/yyyy");
            string msg = "Digite : " + acao + " - " + data_sistema + ", para pesquisar!!";
            if (cx_ID.Text == msg)
            {
                cx_ID.Text = "";
            }
            
        }

        private void cx_ID_Leave(object sender, EventArgs e)
        {
            string texto = cx_ID.Text;
            var data_sistema = DateTime.Now.ToString("dd/MM/yyyy");
            string msg = "Digite : " + acao + " - " + data_sistema + ", para pesquisar!!";

            if (String.IsNullOrEmpty(texto) || String.IsNullOrWhiteSpace(texto)) {
                cx_ID.Text = msg;
            }
        }

        private void cb_usuario_saida_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuario.Usu_ID = ((Usuario)cb_usuario_saida.SelectedItem).Usu_ID;
        }

        private void bt_gravar_saida_Click(object sender, EventArgs e)
        {
            double qtd = 0;
            try { qtd = Convert.ToDouble(cx_qtd_saida.Text); }
            catch { qtd = 0; }
            if (qtd >= 1)
            {

                if (acao == "saida" && estoque != null)
                {
                    string nota_f = "Saida - " + cx_data_saida.Text;

                    var acao_saida = regra_estoque.estoque_entrada_saida(estoque, 0, qtd, nota_f, cb_motivo_saida.Text, usuario);
                    dg_mostra_entrada_saida.DataSource = dg_config.mostra_Estoque_entrada_saida(dg_mostra_entrada_saida, filial_statica, nota_f, 0);
                    if (acao_saida == 65)
                    {
                        MessageBox.Show("[65]-Ocorreu um erro durante o processo, comunicque o desenvolvedor.");
                    }
                    else if (acao_saida == 64)
                    {
                        MessageBox.Show("[64]-Erro: Item não pode ser removido, pois é menor que a quantidade atual.\r\nSolicite uma quantidade menor ou igual a que está no estoque.", "Atenção!!");
                    }
                }
                else
                {

                    MessageBox.Show("Erro: Item não informado.");
                }
            }
            else {
                MessageBox.Show("Erro: Não podem remover do estoque valor igual a zero.");

            }
            //Atualiza  o grid Identificação.

            //Atualiza o grid de entrada.
            limpa_caixas();
        }

        private void cb_motivo_saida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_motivo_saida.Text != "")
            {
                bt_gravar_saida.Enabled = true;
            }
            else { bt_gravar_saida.Enabled = false; }
        }

        private void cb_motivo_entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_motivo_entrada.Text != "")
            {
                bt_gravar_entrada.Enabled = true;
            }
            else { bt_gravar_entrada.Enabled = false; }
        }

        private void bt_cancelar_saida_Click(object sender, EventArgs e)
        {
            limpa_caixas();
            Close();
        }

        private void bt_canelar_entrada_Click(object sender, EventArgs e)
        {
            limpa_caixas();
            Close();
        }

        private void cx_data_saida_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime data_validade = Convert.ToDateTime(cx_data_saida.Text);
                if (data_validade.Year < 2000) {
                    MessageBox.Show("Atenção: Valor abaixo de 2000 não é aceito"," ~[Ano inválido]~ ");
                    cx_data_saida.Focus();

                }
                cx_data_saida.Text = data_validade.ToString("dd/MM/yyyy");
            }
            catch
            {
                MessageBox.Show("Erro: Data informada é invalida!");
                cx_data_saida.Focus();

            }
        }
    }
}
