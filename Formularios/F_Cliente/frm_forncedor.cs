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
using Regras_N.Regra_N_Estoque;
using Controlador.Controle.DataGrid_Config.DataGrid_Estoque;
using Controlador.Controle.ComboBox_Config;

namespace NDM_SoftwareV5.Formularios.F_Cliente
{
    public partial class frm_forncedor : Form
    {

        private Filial filial = new Filial();
        private Empresa empresa = new Empresa();
        private ComboBox_Filial cb_config_filial = new ComboBox_Filial();
        DataGrid_Estoque dg_config = new DataGrid_Estoque();
        private Fornecedor fornecedor = null;
        RN_Estoque regra_estoque = new RN_Estoque();

        public frm_forncedor()
        {
            InitializeComponent();
        }
        private void limpar_caixa() {

            cx_codigo_atual.Text = "";
            cx_nome_atual.Text = "";
            cx_rg_re.Text = "";
            cx_cpf_cnpj.Text = "";
            cx_telefone.Text = "";
            cx_celular.Text = "";
            cx_cidade.Text = "";
            cx_bairro.Text = "";
            cx_rua.Text = "";
            cx_numero_casa.Text = "";
            cx_cep.Text = "";
            bt_alterar.Enabled = false;
            bt_gravar.Enabled = false;
        }

        private void frm_forncedor_Load(object sender, EventArgs e)
        {
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            cb_config_filial.combox_Carregado_Filial(cb_proverdor, empresa);
            cb_proverdor.Focus();
            limpar_caixa();
        }
        void carrega_grid(string texto, string pesquisa) {
            dg_mostra_fornecedor.DataSource = null;
            dg_mostra_fornecedor.DataSource = dg_config.mostra_Fonecedor(dg_mostra_fornecedor, filial, texto, pesquisa);
        }

        private void cb_proverdor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial.Fili_ID = ((Filial)cb_proverdor.SelectedItem).Fili_ID;
            limpar_caixa();
            carrega_grid("", "");

        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            carrega_grid(cb_texto.Text, cx_pesquisar.Text);
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            string cpf = remove_string(cx_cpf_cnpj.Text);
            string rg = remove_string(cx_rg_re.Text);
            string nome = remove_string(cx_nome_atual.Text);

            if ((!String.IsNullOrEmpty(cpf) && !String.IsNullOrWhiteSpace(cpf)) &&
                (!String.IsNullOrEmpty(rg) && !String.IsNullOrWhiteSpace(rg)) &&
                (!String.IsNullOrEmpty(nome) && !String.IsNullOrWhiteSpace(nome)))
            {
                fornecedor = new Fornecedor();
                fornecedor.Fili_ID = filial.Fili_ID;
                fornecedor.for_nome = cx_nome_atual.Text;
                fornecedor.for_re_re = cx_rg_re.Text;
                fornecedor.for_cpf_cnpj = cx_cpf_cnpj.Text;
                fornecedor.for_telefone_1 = cx_celular.Text;
                fornecedor.for_telefone_2 = cx_telefone.Text;
                fornecedor.for_cidade = cx_cidade.Text;
                fornecedor.for_bairro_vila = cx_bairro.Text;
                fornecedor.for_av_rua = cx_rua.Text;
                fornecedor.for_numero_casa = cx_numero_casa.Text;
                fornecedor.for_cep = cx_cep.Text;

                int acao = regra_estoque.cadastrar_fornecedor(fornecedor);
                if (acao == 67)
                {
                    carrega_grid("", "");
                    limpar_caixa();
                    fornecedor = null;
                }
                else if (acao == 68)
                {
                    MessageBox.Show("Error[68]-> Existe dados salvo para esse [CNPJ / CPF] ou [RG /IE]!", "Forncedor, já está cadastrado!");
                    fornecedor = null;
                }
                else if (acao == 69)
                {
                    MessageBox.Show("Error[69]-> Contate o desenvolvedor, informando o código de erro Fornecedor-[69]!", "Erro");
                    fornecedor = null;
                }
            }
            else {

                MessageBox.Show("Por favor preencha os campos  obrigatórios! \r\n Eles contem [*] como identificação","Campos vazio");
                fornecedor = null;
            }

        }
        private string remove_string(string texto) {
            var txt = texto;

            txt = txt.Replace("'", "");
            txt = txt.Replace(",", "");
            txt = txt.Replace(".", "");
            txt = txt.Replace(":", "");
            txt = txt.Replace("@", "");
            txt = txt.Replace("-", "");
            txt = txt.Replace("_", "");
            txt = txt.Replace("\'", "");
            txt = txt.Replace("*", "");
            txt = txt.Replace("#", "");
            return txt;
        }

        private void chk_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cnpj.Checked == true)
            {

                var cnpj = cx_cpf_cnpj.Text;
                cx_cpf_cnpj.Mask = "00.000.000/0000-00";

                cx_cpf_cnpj.Text = cnpj;
            }
            else {
                var cpf = cx_cpf_cnpj.Text;
                cx_cpf_cnpj.Mask = "000.000.000-00";

                cx_cpf_cnpj.Text = cpf;
            }
        }

        private void chk_ie_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_ie.Checked == true)
            {

                var ie = cx_rg_re.Text;
                cx_rg_re.Mask = "000.000.000.000";
                cx_rg_re.Text = ie;
            }
            else {
                var rg = cx_rg_re.Text;
                cx_rg_re.Mask = "000.000.000-0";
                cx_rg_re.Text = rg;
            }
        }

        private void cx_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (cx_pesquisar.TextLength > 1) { bt_pesquisar.Enabled = true; }
            else { bt_pesquisar.Enabled = false; }
        }

        private void cx_nome_atual_TextChanged(object sender, EventArgs e)
        {
            string cpf = remove_string(cx_cpf_cnpj.Text);
            string rg = remove_string(cx_rg_re.Text);
            string nome = remove_string(cx_nome_atual.Text);

            if ((!String.IsNullOrEmpty(cpf) && !String.IsNullOrWhiteSpace(cpf)) &&
                (!String.IsNullOrEmpty(rg) && !String.IsNullOrWhiteSpace(rg)) &&
                (!String.IsNullOrEmpty(nome) && !String.IsNullOrWhiteSpace(nome)))
            { bt_gravar.Enabled = true; }
            else { bt_gravar.Enabled = false; }
            }

        private void cx_rg_re_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = remove_string(cx_cpf_cnpj.Text);
            string rg = remove_string(cx_rg_re.Text);
            string nome = remove_string(cx_nome_atual.Text);

            if ((!String.IsNullOrEmpty(cpf) && !String.IsNullOrWhiteSpace(cpf)) &&
                (!String.IsNullOrEmpty(rg) && !String.IsNullOrWhiteSpace(rg)) &&
                (!String.IsNullOrEmpty(nome) && !String.IsNullOrWhiteSpace(nome)))
            { bt_gravar.Enabled = true; }
            else { bt_gravar.Enabled = false; }
        }

        private void cx_cpf_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = remove_string(cx_cpf_cnpj.Text);
            string rg = remove_string(cx_rg_re.Text);
            string nome = remove_string(cx_nome_atual.Text);

            if ((!String.IsNullOrEmpty(cpf) && !String.IsNullOrWhiteSpace(cpf)) &&
                (!String.IsNullOrEmpty(rg) && !String.IsNullOrWhiteSpace(rg)) &&
                (!String.IsNullOrEmpty(nome) && !String.IsNullOrWhiteSpace(nome)))
            { bt_gravar.Enabled = true; }
            else { bt_gravar.Enabled = false; }
        }

        private void dg_mostra_fornecedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = 0;
            fornecedor = null;
            try {
                id = Convert.ToInt32(dg_mostra_fornecedor.SelectedCells[0].Value.ToString());
                if (id > 0) {
                    fornecedor = new Fornecedor();
                    fornecedor.for_ID = id;
                    fornecedor.for_nome        = dg_mostra_fornecedor.SelectedCells[1].Value.ToString();
                    fornecedor.Fili_ID         = Convert.ToInt32(dg_mostra_fornecedor.SelectedCells[2].Value.ToString());
                    fornecedor.for_cidade      = dg_mostra_fornecedor.SelectedCells[3].Value.ToString();
                    fornecedor.for_bairro_vila = dg_mostra_fornecedor.SelectedCells[4].Value.ToString();
                    fornecedor.for_av_rua      = dg_mostra_fornecedor.SelectedCells[5].Value.ToString();
                    fornecedor.for_numero_casa = dg_mostra_fornecedor.SelectedCells[6].Value.ToString();
                    fornecedor.for_telefone_1  = dg_mostra_fornecedor.SelectedCells[7].Value.ToString();
                    fornecedor.for_telefone_2  = dg_mostra_fornecedor.SelectedCells[8].Value.ToString();
                    fornecedor.for_re_re       = dg_mostra_fornecedor.SelectedCells[9].Value.ToString();
                    fornecedor.for_cpf_cnpj    = dg_mostra_fornecedor.SelectedCells[10].Value.ToString();
                    fornecedor.for_cep         = dg_mostra_fornecedor.SelectedCells[11].Value.ToString();

                    //limpa caixas;
                    limpar_caixa();

                    //preenche dados;
                    cx_codigo_atual.Text = fornecedor.for_ID.ToString();
                    cx_nome_atual.Text   = fornecedor.for_nome;
                    cx_rg_re.Text        = fornecedor.for_re_re;
                    cx_cpf_cnpj.Text     = fornecedor.for_cpf_cnpj;
                    cx_telefone.Text     = fornecedor.for_telefone_2;
                    cx_celular.Text      = fornecedor.for_telefone_1;
                    cx_cidade.Text       = fornecedor.for_cidade;
                    cx_bairro.Text       = fornecedor.for_bairro_vila;
                    cx_rua.Text          = fornecedor.for_av_rua;
                    cx_numero_casa.Text  = fornecedor.for_numero_casa;
                    cx_cep.Text          = fornecedor.for_cep;
                    bt_alterar.Enabled   = true;
                    bt_gravar.Enabled    = false;

                }

            }
            catch { }
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {

            string cpf = remove_string(cx_cpf_cnpj.Text);
            string rg = remove_string(cx_rg_re.Text);
            string nome = remove_string(cx_nome_atual.Text);

            if ((!String.IsNullOrEmpty(cpf) && !String.IsNullOrWhiteSpace(cpf)) &&
                (!String.IsNullOrEmpty(rg) && !String.IsNullOrWhiteSpace(rg)) &&
                (!String.IsNullOrEmpty(nome) && !String.IsNullOrWhiteSpace(nome)))
            {
                DialogResult pergunta = MessageBox.Show("Deseja realizar continuar com a alteração?", "Atenção!!", MessageBoxButtons.YesNo);

                if(pergunta == DialogResult.Yes) { 
                fornecedor.Fili_ID         = filial.Fili_ID;
                fornecedor.for_nome        = cx_nome_atual.Text;
                fornecedor.for_re_re       = cx_rg_re.Text;
                fornecedor.for_cpf_cnpj    = cx_cpf_cnpj.Text;
                fornecedor.for_telefone_1  = cx_celular.Text;
                fornecedor.for_telefone_2  = cx_telefone.Text;
                fornecedor.for_cidade      = cx_cidade.Text;
                fornecedor.for_bairro_vila = cx_bairro.Text;
                fornecedor.for_av_rua      = cx_rua.Text;
                fornecedor.for_numero_casa = cx_numero_casa.Text;
                fornecedor.for_cep         = cx_cep.Text;

                int acao = regra_estoque.atualizar_fornecedor(fornecedor);
                if (acao == 70)
                {
                    carrega_grid("", "");
                    limpar_caixa();
                    fornecedor = null;
                }
                else if (acao == 71)
                {
                    MessageBox.Show("Error[71]-> Contate o desenvolvedor informando o número do erro!", "Forncedor, já está cadastrado!");
                    fornecedor = null;
                }

            }


            }
            else
            {

                MessageBox.Show("Por favor preencha os campos  obrigatórios! \r\n Eles contem [*] como identificação", "Campos vazio");
                fornecedor = null;
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            limpar_caixa();
            fornecedor = null;

        }
    }
}
