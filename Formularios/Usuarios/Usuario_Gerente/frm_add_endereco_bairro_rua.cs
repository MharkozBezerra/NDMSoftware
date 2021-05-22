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
using Regras_N.Regra_N_Usuario;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente
{
    public partial class frm_add_endereco_bairro_rua : Form
    {
        public static Cidade static_cidade = new Cidade();
        public static Bairro_vila static_bairro = new Bairro_vila();
        public static Rua static_rua = new Rua();
        public RN_Endereco regra_endereco = new RN_Endereco();
        public static string o_que_sera_salvo = "";
        public frm_add_endereco_bairro_rua()
        {
            InitializeComponent();
        }

        private void frm_add_endereco_bairro_rua_Load(object sender, EventArgs e)
        {
            iniciar_forme_dados(o_que_sera_salvo);
        }
        private void iniciar_forme_dados(string comeco) {


            switch (comeco)
            {
                case "": this.Close(); break;
                case "salvar_novo_bairro":
                    cx_cidade.Text = static_cidade.Cid_nome;
                    cx_cidade.Enabled = false;
                    lbl_bairro.ForeColor = Color.Red;
                    cx_bairro.Text = "";
                   
                    cx_rua.Enabled = false;
                    cx_cep.Enabled = false;
                    cx_bairro.Focus();
                    break;
                case "salvar_nova_rua":
                    cx_cidade.Text = static_cidade.Cid_nome;
                    cx_cidade.Enabled = false;
                    cx_bairro.Text = static_bairro.Bai_descricao;
                    cx_bairro.Enabled = false;
                    cx_rua.Text = "";
                    cx_cep.Text = "";
                    lbl_rua.ForeColor = Color.Red;
                    lbl_cep.ForeColor = Color.Red;
                    cx_rua.Focus();
                    
                   
                    break;
                default:
                    break;
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void funcao_SalvarDados(string sera_salvo) {

            int acao = 0;

            switch (sera_salvo) {


                case "":
                    break;
                case "salvar_novo_bairro":
                    static_bairro.Cid_ID = static_cidade.Cid_ID;
                    static_bairro.Bai_descricao = cx_bairro.Text;
                    acao = regra_endereco.cadastrar_bairro(static_bairro);
                    if (acao == 75) {   Close(); }
                    else if (acao ==76) { MessageBox.Show("Error[76]: Bairro já está cadastrado no banco de dados"); }
                    else if(acao ==77) { MessageBox.Show("Error[77]:Comunique o desenvolver, informando o número do erro -> 76","Erro Sintaxe"); }
                    break;
                case "salvar_nova_rua":
                    static_rua.Bai_ID = static_bairro.Bai_ID;
                    static_rua.Rua_descricao = cx_rua.Text;
                    static_rua.Rua_cep = cx_cep.Text;
                    acao = regra_endereco.cadastrar_rua(static_rua);
                    if (acao == 80) {  Close(); }
                    else if (acao == 81) { MessageBox.Show("Error[81]: Rua e CEP já está cadastrado no banco de dados!"); }
                    else if (acao == 82) { MessageBox.Show("Error[82]: Comunique o desenvolver, informando o número do erro -> 82", "Erro Sintaxe"); }
                    break;
                case "atualizar_bairro":
                    static_bairro.Bai_descricao = cx_bairro.Text;
                    if (static_bairro.Bai_ID > 0)
                    {
                        acao = regra_endereco.atualizar_bairro(static_bairro);
                        if (acao == 78) {   Close(); }
                        else if (acao == 79) { MessageBox.Show("Error[79]:Comunique o desenvolver, informando o número do erro -> 79", "Erro Sintaxe"); }
                    }
                        break;
                case "atualizar_rua":
                    static_rua.Bai_ID = static_bairro.Bai_ID;
                    static_rua.Rua_descricao = cx_rua.Text;
                    static_rua.Rua_cep = cx_cep.Text;
                    if (static_rua.Rua_ID > 0)
                    {
                        acao = regra_endereco.atualizar_rua(static_rua);
                        if (acao == 83) {  Close(); }
                        else if (acao == 84) { MessageBox.Show("Error[84]:Comunique o desenvolver, informando o número do erro -> 84", "Erro Sintaxe"); }
                    }
                    break;
            }

        }

        private void bt_atualizar_1_Click(object sender, EventArgs e)
        {
            funcao_SalvarDados(o_que_sera_salvo);
        }
    }
}
