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
using Controlador.Controle;
using Controlador.Controle.ComboBox_Config;
using Controlador.Controle.DataGrid_Config.DataGrid_Cliente;
using Regras_N.Regra_N_Usuario;
namespace NDM_SoftwareV5.Formularios.F_Cliente
{
    public partial class frm_add_cliente : Form
    {
        
        public static Cliente cliente_statico;
        
        public static int acao; // 0-> Adicionar Cliente / 1-> Alterar Dados.
        Filial         filial            = new Filial();
        Cliente        cliente           = new Cliente();
        RN_Atendimento regra_atendimento = new RN_Atendimento();
        RN_Telefone    regra_telefone    = new RN_Telefone();
        Telefone       telefone          = new Telefone();
        Endereco       endereco          = new Endereco();
        Cidade         cidade            = new Cidade();
        Bairro_vila    bairro            = new Bairro_vila();
        Rua            rua               = new Rua();
        ComboBox_Endereco cb_config_endereco = new ComboBox_Endereco();
        DataGrid_Cliente dg_config       = new DataGrid_Cliente();
        public frm_add_cliente()
        {
            InitializeComponent();
        }

        private void frm_add_cliente_Load(object sender, EventArgs e)
        {
           
            cx_base.Text        = cliente_statico.Fili_descricao;
            cx_codCliente.Text  = cliente_statico.Clie_codigo.ToString();
            cx_nomeCliente.Text = cliente_statico.Clie_nome;
            cx_nomeCliente.Focus();
            filial.Fili_ID = cliente_statico.Fili_ID;
            if (cliente_statico.Clie_ID == 0)
            {
                bt_gravar_1.Enabled      = true;
                grp_telefone.Enabled     = true;
                bt_atualizar.Enabled     = false;
                grp_add_endereco.Location = grp_endereco_ver.Location;
                grp_add_endereco.Visible = true;
                grp_endereco_ver.Visible = false;
                grp_endereco_ver.Enabled = false;

            }
            else
            {

                    bt_atualizar.Enabled     = true;
                    bt_gravar_1.Enabled      = false;
                    grp_telefone.Enabled     = true;
                carregar_cliente_inicio(cliente_statico);

            }
            carregar_comboBox(filial);
            dg_mostra_telefone.DataSource = dg_config.mostrar_Telefone_Cliente(dg_mostra_telefone, cliente_statico);
            
        }
        private void bt_atualizar_Click(object sender, EventArgs e)
        { atualizar_cliente(); }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_atualizar_1_Click(object sender, EventArgs e)
        {
            grp_add_endereco.Location = grp_endereco_ver.Location;
            grp_add_endereco.Visible = true; 
            grp_endereco_ver.Visible = false;
            grp_endereco_ver.Enabled = false;
            grp_add_endereco.Enabled = true;



        }
        private void cx_nomeCliente_Validated(object sender, EventArgs e)
        {
            if (cx_codCliente.TextLength > 2 && cx_nomeCliente.TextLength > 3)
            {
                bt_gravar_1.Enabled = true;
            }
            else { bt_gravar_1.Enabled = false; }
        }
        private void bt_cancelar_2_Click(object sender, EventArgs e)
        {
            grp_add_endereco.Location = new Point(4, 406);
            grp_add_endereco.Visible = false;
            grp_endereco_ver.Visible = true;
            grp_endereco_ver.Enabled = false;
            grp_endereco_ver.Enabled = true;
        }
        private void cx_codCliente_Validated(object sender, EventArgs e)
        {
            if (cx_codCliente.TextLength > 2 && cx_nomeCliente.TextLength > 3)
            {
                bt_gravar_1.Enabled = true;
            }
            else { bt_gravar_1.Enabled = false; }
        }
        private void bt_gravar_1_Click(object sender, EventArgs e)
        {  salvar_novo_cliente(); }

        //---Métodos criados.
        private string msg_resultado(int resultado) {
            var msg = "";
            switch (resultado)
            {
                case 1: msg = "[01]-Erro: Cliente já cadastrado no banco de dados."; break;
                case 2: msg = "[02]-Cliente cadastrado com sucesso!"; break;
                case 3: msg = "[03]-Erro: Esse cliente não pode ser salvo no momento."; break;
                case 4: msg = "[04]-Cliente atualizado com sucesso"; break;
                case 5: msg = "[05]-Erro: Dados do cliente inválidos"; break;
                case 25: msg = "[25]-Erro: Erro ao atualizar endereço - Cliente \r\nEntre em contato com desenvovedor."; break;
                case 26: msg = "[26]-Endereço atualizado com sucesso - Cliente"; break;
                case 27: msg = "[27]-Cliente - Endereço resgatado com sucesso"; break;
                case 28: msg = "[28]-Erro: Cliente- Erro ao resgatar endereço.\r\nEntre em contato com desenvovedor."; break;
                case 29: msg = "[29]-Cliente - Endereço salvo"; break;
                case 30: msg = "[30]-Erro: Endereço não pode ser falvo. \r\nEntre em contato com desenvovedor."; break;
                case 31: msg = "[31]-Erro: Cliente não está salvo no banco de dados \r\nSalve o novo cliente."; break;
                default: msg = "Erro desconhecido, comuniquie o desenvolvedor";break;
            }
            return msg;
        }
        private void salvar_novo_cliente() {
            var resultado = 0;
            try
            {
                cliente.Clie_codigo = Convert.ToInt32(cx_codCliente.Text);
                cliente.Fili_ID = cliente_statico.Fili_ID;
                cliente.Clie_nome = cx_nomeCliente.Text;
                cliente.Clie_cpf_cnpj = cx_cpf_cnpj.Text;
                cliente.Clie_rg_re = cx_rg_re.Text;
                resultado = regra_atendimento.cadastrar_cliente(cliente);
                MessageBox.Show(msg_resultado(resultado));

                //Pergunta se usuário quer continuar com a gravação dos dados do cliente.
                DialogResult per_01 = MessageBox.Show("Gostaria de continuar o cadastro desse cliente?", "Aviso!!", MessageBoxButtons.YesNo);
                if (per_01 == DialogResult.Yes)
                {
                    //libera as demais opções.
                    //Pega o ID do novo cliente cadastrado -> 
                    Cliente cli_endereco = new Cliente();
                    cli_endereco = regra_atendimento.puxar_cliente(cliente);
                    if (cli_endereco.Clie_ID > 0)
                    {
                        
                        //Troca posição dos grupos
                        grp_add_endereco.Location = grp_endereco_ver.Location;
                        grp_add_endereco.Visible = true;
                        grp_add_endereco.Enabled = true;

                        cliente_statico = cli_endereco;
                        grp_endereco_ver.Visible = false;
                    }
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(msg_resultado(resultado) + "\r\n" + erro.Message);
            }
        }
        private void atualizar_cliente() {
            var resultado = 0;
            Cliente_DAO cliente_dao = new Cliente_DAO();
            try
            {
                cliente.Clie_ID       = cliente_statico.Clie_ID;
                cliente.Clie_codigo   = Convert.ToInt32(cx_codCliente.Text);
                cliente.Fili_ID       = cliente_statico.Fili_ID;
                cliente.Clie_nome     = cx_nomeCliente.Text;
                cliente.Clie_cpf_cnpj = cx_cpf_cnpj.Text;
                cliente.Clie_rg_re    = cx_rg_re.Text;
                resultado             = cliente_dao.upt_cliente(cliente);
                MessageBox.Show(msg_resultado(resultado));

                //Pergunta se usuário quer continuar com a gravação dos dados do cliente.
                DialogResult per_01 = MessageBox.Show("Gostaria de continuar a atualização desse cliente?", "Aviso!!", MessageBoxButtons.YesNo);
                if (per_01 == DialogResult.Yes)
                {
                    //libera as demais opções.
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(msg_resultado(resultado) + "\r\n" + erro.Message);
            }

        }
        private void carregar_cliente_inicio(Cliente cliente)
        {
            Cliente novo_cliente = new Cliente();
            Cidade cidade = new Cidade();
            Endereco endereco = new Endereco();
            Bairro_vila bairro = new Bairro_vila();
            Rua rua = new Rua();

            novo_cliente = regra_atendimento.puxar_cliente(cliente);

            endereco = regra_atendimento.puxar_endereco_cliente(novo_cliente);

            //-----[LEVA DADOS PARA TEXTBOX ATUAL]-----------------------
            cx_codCliente.Text = novo_cliente.Clie_codigo.ToString();
            cx_nomeCliente.Text = novo_cliente.Clie_nome;
            cx_rg_re.Text = novo_cliente.Clie_rg_re;
            cx_cpf_cnpj.Text = novo_cliente.Clie_cpf_cnpj;

            if (endereco != null)
            {
                cidade = endereco.cidade;
                bairro = endereco.bairro;
                rua = endereco.rua;

                cx_cidade.Text = endereco.cidade.Cid_nome;
                cx_bairro.Text = endereco.bairro.Bai_descricao;
                cx_rua.Text = endereco.rua.Rua_descricao;
                cx_cep.Text = endereco.rua.Rua_cep;
                cx_numero_casa.Text = endereco.End_numero_casa;
                cx_numero_casa_2.Text = cx_numero_casa.Text;
            }
        }
        private void carregar_comboBox(Filial filial) {

            if (filial.Fili_ID != 0) {

                cb_config_endereco.combox_Cidade(cb_cidade_descricao,cb_cidade_ID, filial);
                
            }

        }
        private void salvar_endereco_cliente(Cliente cliente) {

            var acao = 0;
            Cidade cidade = new Cidade();
            Endereco endereco_novo = new Endereco();
            Bairro_vila bairro = new Bairro_vila();
            Rua rua = new Rua();
       

            cidade.Cid_ID = Convert.ToInt32(cb_cidade_ID.Text);
            bairro.Bai_ID = Convert.ToInt32(cb_bairro_ID.Text);
            rua.Rua_ID = Convert.ToInt32(cb_rua_ID.Text);
            
            try
            {

                
                endereco_novo.cidade = cidade;
                endereco_novo.bairro = bairro;
                endereco_novo.rua = rua;
                endereco_novo.End_numero_casa = cx_numero_casa_2.Text;

                    //Ação é para atualizar o endereço
                    acao = regra_atendimento.add_endereco_cliente(cliente,endereco_novo);

            }
            catch (Exception erro)
            {
                var r = erro.Message;

            }
            MessageBox.Show(msg_resultado(acao), "Atenção!!");

        }
        private void atualizar_endereco(Cliente cliente) {
            var acao = 0;
            Cidade cidade = new Cidade();
            Endereco endereco_novo = new Endereco();
            Endereco endereco_antigo = new Endereco();
            Bairro_vila bairro = new Bairro_vila();
            Rua rua = new Rua();


            cidade.Cid_ID = Convert.ToInt32(cb_cidade_ID.Text);
            bairro.Bai_ID = Convert.ToInt32(cb_bairro_ID.Text);
            rua.Rua_ID    = Convert.ToInt32(cb_rua_ID.Text);
            endereco_antigo = regra_atendimento.puxar_endereco_cliente(cliente);
            try {

                endereco_novo.End_ID = endereco_antigo.End_ID;
                endereco_novo.cidade = cidade;
                endereco_novo.bairro = bairro;
                endereco_novo.rua    = rua;
                endereco_novo.End_numero_casa = cx_numero_casa_2.Text;
                acao = regra_atendimento.upt_endereco_cliente(endereco_novo);

            }
            catch (Exception erro){
                var r = erro.Message;
                
            }
            MessageBox.Show(msg_resultado(acao), "Atenção!!");
        }
        private void cb_cidade_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cidade.Cid_ID = Convert.ToInt32(cb_cidade_ID.Text);
                cidade.Cid_nome = cb_cidade_descricao.Text;
            }
            catch { cidade.Cid_ID = 0; }
            cb_config_endereco.combox_Bairro(cb_bairro_descricao, cb_bairro_ID, cidade);
        }

        private void cb_bairro_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bairro.Bai_ID = Convert.ToInt32(cb_bairro_ID.Text);
                bairro.Bai_descricao = cb_bairro_descricao.Text;
            }
            catch { bairro.Bai_ID = 0; }
            cb_config_endereco.combox_Rua(cb_rua_descricao,cb_rua_ID,cb_rua_cep ,bairro);
        }

        private void cb_rua_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               rua.Rua_ID = Convert.ToInt32(cb_rua_ID.Text);
               rua.Rua_descricao = cb_rua_descricao.Text;
               rua.Rua_cep = cb_rua_cep.Text;
            }
            catch { rua.Rua_ID = 0; }
            
        }

        private void bt_gravar_2_Click(object sender, EventArgs e)
        {

            //Verifica se será update ou adicionamento.
            int acao = 0;


            try {
                Endereco end = regra_atendimento.puxar_endereco_cliente(cliente_statico);
                acao = end.End_ID;
            }
            catch { acao = 0; }

            //-> para atualizar
            if (acao >0)
            {
                DialogResult pergunta = MessageBox.Show("Atualizar endereço?", "Atenção!!", MessageBoxButtons.YesNo);
                if (pergunta == DialogResult.Yes)
                {

                    atualizar_endereco(cliente_statico);
                    carregar_cliente_inicio(cliente_statico);

                    grp_add_endereco.Location = new Point(4, 406);
                    grp_add_endereco.Visible = false;
                    grp_endereco_ver.Visible = true;
                    grp_endereco_ver.Enabled = false;
                    grp_endereco_ver.Enabled = true;
                }
            }
            //-> para salvar
            if (acao == 0) {

                DialogResult pergunta = MessageBox.Show("Salvar endereço?", "Atenção!!", MessageBoxButtons.YesNo);
                if (pergunta == DialogResult.Yes)
                {

                    salvar_endereco_cliente(cliente_statico);
                    carregar_cliente_inicio(cliente_statico);

                    grp_add_endereco.Location = new Point(4, 406);
                    grp_add_endereco.Visible = false;
                    grp_endereco_ver.Visible = true;
                    grp_endereco_ver.Enabled = false;
                    grp_endereco_ver.Enabled = true;
                }
            }
        }

        private void bt_incluir_numero_Click(object sender, EventArgs e)
        {
            add_Telefone_cliente add_telefone = new add_Telefone_cliente();
            add_Telefone_cliente.cliente_statico = cliente_statico;
            
            add_telefone.ShowDialog();
            
            dg_mostra_telefone.DataSource = dg_config.mostrar_Telefone_Cliente(dg_mostra_telefone, cliente_statico);
            
        }

        private void dg_mostra_telefone_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {
                telefone.Tele_ID = Convert.ToInt32(dg_mostra_telefone.SelectedCells[0].Value.ToString());
                bt_exluir_numero.Enabled = true;
            }
            catch {
                telefone.Tele_ID = 0;
                bt_exluir_numero.Enabled = true;
            }
        }

        private void bt_exluir_numero_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show("Excluir número?","Atenção",MessageBoxButtons.YesNo);
            if (pergunta == DialogResult.Yes)
            {
                regra_telefone.del_telefone_cliente(telefone);
            }
            dg_mostra_telefone.DataSource = dg_config.mostrar_Telefone_Cliente(dg_mostra_telefone, cliente_statico);
        }
    }
}
