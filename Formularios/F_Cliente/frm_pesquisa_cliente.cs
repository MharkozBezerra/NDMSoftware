
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
using Controlador.Controle.DataGrid_Config.DataGrid_Cliente;
using Controlador.Controle.ComboBox_Config;
namespace NDM_SoftwareV5.Formularios.F_Cliente
{
    public partial class frm_pesquisa_cliente : Form
    {
        private Filial filial = new Filial();
        private Cliente cliente = new Cliente();
        private Empresa empresa = new Empresa();
        RN_Atendimento regra_atendimento = new RN_Atendimento();
        private ComboBox_Filial cb_config_filial = new ComboBox_Filial();
        private DataGrid_Cliente dg_config = new DataGrid_Cliente();

        public frm_pesquisa_cliente()
        {
            InitializeComponent();
        }

        private void frm_pesquisa_cliente_Load(object sender, EventArgs e)
        {
            empresa.Emp_ID = Properties.Settings.Default.EMPRESA_ID;
            cb_config_filial.combox_Carregado_Filial(cb_proverdor, empresa);
            cb_proverdor.Focus();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            String nomeCliente = cx_nomeCliente.Text;
            int codigoCliente = Convert.ToInt32(cx_codCliente.Text);
            if (!String.IsNullOrEmpty(nomeCliente) && codigoCliente > 0 && filial.Fili_ID > 0)
            {

                salvar_novo_cliente();

                dg_mostra_pesquisa.DataSource = dg_config.mostrar_Pesquisa_Cliente(dg_mostra_pesquisa, filial, cliente);
                cx_codCliente.Text = "";
                cx_nomeCliente.Text = "";
            }
            else { MessageBox.Show("Há campos com valores incorretos!", "Atenção!!!"); }

        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            if (filial != null)
            {
                //int codigo = Convert.ToInt32(cb_proverdor_ID.Text);
                //filial.Fili_ID =codigo;

                dgCliente_1.DataSource = dg_config.mostrar_Cliente(dgCliente_1, filial);
                cliente.Clie_codigo = 0;
                cliente.Clie_nome = "";
                if (cliente.Clie_codigo > 0)
                {
                    dg_Atendimento.DataSource = dg_config.mostrar_Atendimento_Cliente(cliente, dg_Atendimento);
                }
                cx_obs.Text = "";

                if (gp_salvar.Enabled == false)
                {
                    gp_salvar.Enabled = true;
                }
                if (grp_pesquisa_1.Enabled == false) { grp_pesquisa_1.Enabled = true; }

                // if (usuario.Chave_Acesso_DB() == 1) { grp_importart.Enabled = true; }
                grp_importart.Enabled = false;
            }
            else { MessageBox.Show("Provedor não informado."); }
        }

        private void dgCliente_1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                cliente.Clie_ID = Convert.ToInt32(dgCliente_1.SelectedCells[0].Value.ToString());
                dg_Atendimento.DataSource = dg_config.mostrar_Atendimento_Cliente(cliente, dg_Atendimento);
            }
            catch { MessageBox.Show("Opção invalida."); cliente.Clie_ID = 0; }
            cx_obs.Text = "";
            //dg_Atendimento.DataSource = dg_config.mostrar_Atendimento_Cliente(cliente, dg_Atendimento);
        }

        private void dg_Atendimento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cx_obs.Text = "";
            cx_obs.Text = dg_Atendimento.SelectedCells[4].Value.ToString();
        }

        private void cb_codigo_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_codigo_1.Checked == true) {
                cx_pesquisa.Text = "";
                cx_pesquisa.MaxLength = 5;
            }
        }

        private void cx_codCliente_TextChanged(object sender, EventArgs e)
        {
            int numero = 0;
            cx_codCliente.Text = cx_codCliente.Text;
            try { numero = Convert.ToInt32(cx_codCliente.Text); }
            catch {
                MessageBox.Show("Digite apenas número de 0 a 9", "Valor incorreto");
                cx_codCliente.Focus();
            }
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {



            if (cx_pesquisa_cliente.Text != "")
            {
                pesquisar_cliente_add();

            }
            else { MessageBox.Show("Não há informações para ser pesquisado!","Campo vazio"); }
        }
        private void puxa_Dados_Clientes_DB() {

            var novo_cliente = new Cliente();
            
            Cidade cidade      = new Cidade();
            Endereco endereco  = new Endereco();
            Bairro_vila bairro = new Bairro_vila();
            Rua rua            = new Rua();

            try
            {
                novo_cliente.Clie_ID = Convert.ToInt32(dg_mostra_pesquisa.SelectedCells[0].Value);
                novo_cliente.Fili_ID = filial.Fili_ID;
                novo_cliente = regra_atendimento.puxar_cliente(novo_cliente);

                endereco = regra_atendimento.puxar_endereco_cliente(novo_cliente);
                
                //-----[LEVA DADOS PARA TEXTBOX ATUAL]-----------------------
                cx_codigo_atual.Text     = novo_cliente.Clie_codigo.ToString();
                cx_nome_atual.Text       = novo_cliente.Clie_nome;
                cx_rg_re.Text            = novo_cliente.Clie_rg_re;
                cx_cpf_cnpj.Text         = novo_cliente.Clie_cpf_cnpj;
                if (endereco != null)
                {
                    cidade              = endereco.cidade;
                    bairro              = endereco.bairro;
                    rua                 = endereco.rua;

                    cx_cidade.Text      = endereco.cidade.Cid_nome;
                    cx_bairro.Text      = endereco.bairro.Bai_descricao;
                    cx_rua.Text         = endereco.rua.Rua_descricao;
                    cx_cep.Text         = endereco.rua.Rua_cep;
                    cx_numero_casa.Text = endereco.End_numero_casa;
                }
                    lbl_qtd_atendimento.Text = novo_cliente.Qtd_atendimento.ToString();
                if (novo_cliente.Clie_codigo > 0) { bt_alterar.Enabled = true; }
                else { bt_alterar.Enabled = false; }
            }
            catch(Exception err) {
                var e = err.Message;
                cx_codigo_atual.Text     = "";
                cx_nome_atual.Text       = "";
                cx_rg_re.Text            = "";
                cx_cpf_cnpj.Text         = "";
                cx_cidade.Text           = "";
                cx_bairro.Text           = "";
                cx_rua.Text              = "";
                cx_cep.Text              = "";
                cx_numero_casa.Text      = "";
                lbl_qtd_atendimento.Text = "0";

            }
            }
        private void pesquisar_cliente_add() {

            try
            {

                if (rb_codigo.Checked == true)
                {
                    string codigo = cx_pesquisa_cliente.Text;
                    if (!String.IsNullOrEmpty(codigo) || !string.IsNullOrWhiteSpace(codigo))
                    {
                        try { cliente.Clie_codigo = Convert.ToInt32(cx_pesquisa_cliente.Text); }
                        catch
                        {
                            MessageBox.Show("Código Invalido!");
                            cliente.Clie_codigo = 0;
                        }
                        cliente.Clie_nome = "";
                    }
                }
                else if (rb_nome.Checked == true)
                {
                    cliente.Clie_codigo = 0;
                    cliente.Clie_nome = cx_pesquisa_cliente.Text;
                }
                dg_mostra_pesquisa.DataSource = dg_config.mostrar_Pesquisa_Cliente(dg_mostra_pesquisa, filial, cliente);

            }
            catch (Exception)
            {

                MessageBox.Show("Erro"); ;
            }
        }
        
        

        private void dg_mostra_pesquisa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int chave = 4;//usuario.Chave_Acesso_DB();
            puxa_Dados_Clientes_DB();
            liberar_Alteracao(chave);
           

            

        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            Cliente novo_cliente = new Cliente();
            novo_cliente.Clie_ID = Convert.ToInt32(dg_mostra_pesquisa.SelectedCells[0].Value);
            novo_cliente.Fili_ID = filial.Fili_ID;
            novo_cliente.Fili_descricao = cb_proverdor.Text;
            novo_cliente = regra_atendimento.puxar_cliente(novo_cliente);
            frm_add_cliente.acao = 1;
            frm_add_cliente.cliente_statico = novo_cliente;
            var add_cliente = new frm_add_cliente();
            add_cliente.ShowDialog();
            bt_alterar.Enabled = false;
            pesquisar_cliente_add();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
           
            //var pesquisaCodigo = 0;
           

            if (cx_pesquisa.Text != "")
            {



                if (cb_codigo_1.Checked == true)
                {

                    try
                    {
                       
                      

                        //filial.Fili_ID = Convert.ToInt32(cb_proverdor_ID.Text);
                        cliente.Clie_codigo = Convert.ToInt32(cx_pesquisa.Text);
                        cliente.Clie_nome = "";
                        dgCliente_1.DataSource = dg_config.mostrar_Pesquisa_Cliente(dgCliente_1, filial, cliente);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Erro: Digite apenas número quando a opção código estiver selecionada", "Atenção");
                    }
                }
                if (rb_nome_1.Checked == true)
                {

                    try
                    {
                        //filial.Fili_ID = Convert.ToInt32(cb_proverdor_ID.Text);
                        cliente.Clie_codigo = 0;
                        cliente.Clie_nome = cx_pesquisa.Text;
                        dgCliente_1.DataSource = dg_config.mostrar_Pesquisa_Cliente(dgCliente_1, filial, cliente);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Erro"); ;
                    }
                }
            }
            else { MessageBox.Show("Não há informações para ser pesquisado!", "Campo vazio"); }
        }

        private void rb_nome_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nome.Checked == true)
            {
                cx_pesquisa_cliente.Text = "";
                cx_pesquisa_cliente.MaxLength = 100;
            }
        }

        private void bt_exp_buscar_Click(object sender, EventArgs e)
        {
            /*
            if (usuario.Chave_Acesso_DB() == 1)
            {
                OpenFileDialog abrirAquivo = new OpenFileDialog();
                if (abrirAquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.cx_caminho.Text = abrirAquivo.FileName;
                }
            }
            else {
                MessageBox.Show("Acesso negado");
            }
            */
        }

       

        private void bt_caregar_Click(object sender, EventArgs e)
        {
            /*
            if (usuario.Chave_Acesso_DB() == 1)
            {
                CarregarDadosNoGridView();
            }
            else { MessageBox.Show("Acesso negado!"); }
        */
            }

        private void bt_importar_Click(object sender, EventArgs e)
        {
            SalvarClientes();
        }
       
        public void LimpaDataGrid(DataGridView dg, TextBox valorTotal)
        {

            dg.DataSource = null;
            dg.Rows.Clear();
            valorTotal.Text = 0.ToString();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            LimpaDataGrid(mostra_lista, cxQtd);
            cx_caminho.Text = "";
            cx_aba.Text = "";
        }

        private void cx_caminho_TextChanged(object sender, EventArgs e)
        {
            if (cx_caminho.TextLength > 2)
            {

                cx_aba.ReadOnly = false;
                cx_aba.Focus();
            }
            else
            {
                cx_aba.ReadOnly = true;

            }
        }

        private void cx_aba_TextChanged(object sender, EventArgs e)
        {
            if (cx_aba.TextLength > 1) { bt_caregar.Enabled = true; }
            else { bt_caregar.Enabled = false; }
        }

        private void rb_codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_codigo.Checked == true)
            {
                cx_pesquisa_cliente.Text = "";
                cx_pesquisa_cliente.MaxLength = 5;
            }
        }

        private void rb_nome_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nome_1.Checked == true)
            {
                cx_pesquisa.Text = "";
                cx_pesquisa.MaxLength = 100;
            }
        }

        //Metodos criados.
        private void salvar_novo_cliente()
        {
            
            var resultado = 0;
            try
            {
                //filial.Fili_ID = Convert.ToInt32(cb_proverdor_ID.Text);
                //cliente.Clie_codigo = Convert.ToInt32(cx_codCliente.Text);
                //liente.Fili_ID = filial.Fili_ID;
                //cliente.Clie_nome = cx_nomeCliente.Text;
                //cliente.Clie_cpf_cnpj = cx_cpf_cnpj.Text;
                //cliente.Clie_rg_re = cx_rg_re.Text;
                //resultado = regra_atendimento.cadastrar_cliente(cliente);
                //MessageBox.Show(msg_resultado(resultado));

                Cliente novo_cliente = new Cliente();
                novo_cliente.Fili_descricao = cb_proverdor.Text;
                novo_cliente.Fili_ID = filial.Fili_ID;
                novo_cliente.Clie_codigo = Convert.ToInt32(cx_codCliente.Text);
                novo_cliente.Clie_nome = cx_nomeCliente.Text;
                frm_add_cliente.acao = 0;
                frm_add_cliente.cliente_statico = novo_cliente;
                var add_cliente = new frm_add_cliente();
                add_cliente.ShowDialog();


                //Pergunta se usuário quer continuar com a gravação dos dados do cliente.
                DialogResult per_01 = MessageBox.Show("Gostaria de continuar o cadastro desse cliente?", "Aviso!!", MessageBoxButtons.YesNo);
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
        private void alterar_Cliente(int id, int codigo, int filial, string nome)
        {

            if (1 > 2)
            {

            }
            else { MessageBox.Show("Erro: A dados em falta!"); }

        }
        private string msg_resultado(int resultado)
        {
            var msg = "";
            switch (resultado)
            {
                case 1: msg = "Erro: Cliente já cadastrado no banco de dados."; break;
                case 2: msg = "Cliente cadastrado com sucesso!"; break;
                case 3: msg = "Erro: Esse cliente não pode ser salvo no momento."; break;
                case 4: msg = "Cliente atualizado com sucesso"; break;
                case 5: msg = "Dados do cliente inválidos"; break;
                default: msg = "Erro desconhecido, comuniquie o desenvolvedor"; break;
            }
            return msg;
        }
        void SalvarClientes()
        {
            img_status.Image = Properties.Resources.amarelo_25x25;
            lbl_msg.Text = "Aguarde...";
            if (mostra_lista.RowCount > 0)
            {
                DialogResult per = MessageBox.Show("Você está preste a inserir dados no banco de dados, deseja continuar ?", "..:: Atenção::..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                img_status.Image = Properties.Resources.amarelo_25x25;
                lbl_msg.Text = "Carregando...";

                if (per == DialogResult.Yes)
                {


                    try
                    {
                        /*Cria a váriavel para armazenar os dados*/
                        var codCliente = 0;
                        var nomeCliente = "";
                        var provedor_ID = 0;
                        var qtd_Clientes_Atual = mostra_lista.RowCount;
                        var lista_clientes = new List<String>();
                        /*Varre o data  grid para procurar por dados*/

                        //PARA CADA LINHA = 0| ENQUANTO LINHA FOR MENOS QUE QTD DE CLIENTE ATUAL| LINHA RECE +1
                        for (int linha = 0; linha < qtd_Clientes_Atual; linha++)
                        {
                            var qtd_Cliente_salvo = (qtd_Clientes_Atual - mostra_lista.RowCount);
                            /*Armazena um dados paras as váriaeis*/
                            codCliente = Convert.ToInt32(mostra_lista.SelectedCells[0].Value.ToString());
                            nomeCliente =/*-----------*/ mostra_lista.SelectedCells[1].Value.ToString();
                            provedor_ID =/*-----*/ filial.Fili_ID;
                            /*Realiza o procedimento de salvamento de dados*/
                            try
                            {
                                /*
                                if (cliente.valida_Cliente_Existente_Importe(codCliente, nomeCliente, provedor_ID) == false)
                                {
                                    cliente.importar_Novo_Cliente(codCliente, nomeCliente, provedor_ID); // Salva o dados
                                    img_status.Image = Properties.Resources.gravar;                      // -> Muda o ícone de salvamento
                                    lbl_msg.Text = "Salvo!";                                             // -> Altera o texto
                                    lbl_importado.Text = "Foram passado " + qtd_Cliente_salvo + " / " + qtd_Clientes_Atual + " Clientes";
                                }
                                else {

                                    img_status.Image = Properties.Resources.vermelho_25x25; lbl_msg.Text = "Error : Cliente já cadastrado";
                                    mostra_lista.Rows.RemoveAt(mostra_lista.CurrentRow.Index);      // -> Remove alinha atual
                                }
                                */

                            }
                            catch { img_status.Image = Properties.Resources.vermelho_25x25; lbl_msg.Text = "Error..."; }

                        } //->Saida do for( ){ }

                        //    foreach (DataGridViewRow dgr  in mostra_lista.Rows )
                        //    {


                        lbl_msg.Text = "Finalizado...";
                        img_status.Image = Properties.Resources.verde_25x25;
                        MessageBox.Show("Dados salvos", "Atenção");
                        cxQtd.Text = mostra_lista.RowCount.ToString();

                        //dgConfig.mostra_Cliente(mostra_cliente_importado, provedor_ID);
                        //CarregarDadosNoGridView();


                    }
                    catch (Exception er) { MessageBox.Show("Encontrado erro durante o procedimento : " + er.Message); }
                }
                else
                {
                    MessageBox.Show("Ação cancelada , por favor selecione uma empresa e um banco para continuar !", "Atenção ao erro !!!");
                    lbl_msg.Text = "Cancelado...";
                    img_status.Image = Properties.Resources.vermelho_25x25;
                }
            }
        }
        void CarregarDadosNoGridView()
        {

            var caminhoArquivo = cx_caminho.Text;
            var nomeAba = cx_aba.Text;
            if (caminhoArquivo != "" && nomeAba != "")
            {
                try
                {

                    //Recebe imagem do disquete 2

                    bt_importar.Enabled = false;
                    bt_caregar.Enabled = false;
                    bt_buscar.Enabled = false;
                    cx_aba.Enabled = false;
                    img_status.Visible = true;
                    lbl_msg.Visible = true;
                    img_status.Image = Properties.Resources.amarelo_25x25;
                    lbl_msg.Text = "Carregando...";
                    //dgConfig.MostraDadosCarregadoExcelCliente(mostra_lista, caminhoArquivo, nomeAba);

                    bt_importar.Enabled = true;
                    bt_caregar.Enabled = true;
                    bt_buscar.Enabled = true;
                    cx_aba.Enabled = true;
                    lbl_msg.Text = "Pronto ...";
                    img_status.Image = Properties.Resources.verde_25x25;
                }
                catch { lbl_msg.Text = "Erro ao carregar.."; img_status.Image = Properties.Resources.vermelho_25x25; }
                cxQtd.Text = mostra_lista.RowCount.ToString();
            }

            if (caminhoArquivo == "" && nomeAba != "")
            {
                MessageBox.Show("Atenção aquivo não localizado ou formato está incorreto.", "Atenção ao erro");
            }
            if (caminhoArquivo != "" && nomeAba == "")
            {
                MessageBox.Show("Nome da aba incorreto ou não existe.", "Atenção ao erro");
            }
            if (caminhoArquivo == "" && nomeAba == "")
            {
                MessageBox.Show("Operação cancelada : Valores não informados.", "Atenção ao erro");
            }
        }
        private void liberar_Alteracao(int chave)
        {
            /*
             * METODO RESPONSÁVEL POR LIBERAR A ALTERAÇÃO DO CLIENTE:
             * REGRA01: TODOS OS USUÁRIOS PODEM ALTERAR AS INFORMAÇÕES DO NOME DO CLIENTE.
             * REGRA02: APENAS ADM OU ROOT PODERÁ ALTERAR O PROVEDOR E CÓDIGO DO CLIENTE.
             * REGRA03: HELPDESK E RECEPÇÃO REALIZA O MESMO TIPO DE ALTERAÇÕES.
             * REGRA04: APÓS ALTERAÇÃO OU CANCELAMENTO DO MESMO AS INFORMAÇÕES DEVEM SER RECARREGADAS E OS COMPOS
             * DEVEM FICAR LIMPOS.
             */
            switch (chave)
            {

                case (1):

                    //config_ComboBox.combox_Carregado_Filial(cb_proverdor_alterar, cb_proverdor_ID_alterar);
                    // cb_proverdor_alterar.Enabled = true;
                    // cx_codigo_alterar.Enabled = true;
                    // cx_nome_alterar.Enabled = true;

                    break;
                case (2):
                case (4):
                    // cx_nome_alterar.Enabled = true;
                    // cx_codigo_alterar.Enabled = true;
                    break;

            }

        }

        private void cb_proverdor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filial.Fili_ID = ((Filial)cb_proverdor.SelectedItem).Fili_ID;
        }

        private void tab_controle_Cleinte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
