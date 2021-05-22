namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class frm_entrada_saida_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_entrada_saida_produto));
            this.gr_entrada = new System.Windows.Forms.GroupBox();
            this.bt_bucar_produto = new System.Windows.Forms.Button();
            this.cx_id_estoque = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cx_unidade = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grp_entrada = new System.Windows.Forms.GroupBox();
            this.cx_qtd_entrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_motivo_entrada = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cx_data_entrada = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_gravar_entrada = new System.Windows.Forms.Button();
            this.bt_canelar_entrada = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cx_descricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cx_cod_interno = new System.Windows.Forms.TextBox();
            this.cx_qtd_atual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cx_cod_externo = new System.Windows.Forms.TextBox();
            this.cx_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_saida = new System.Windows.Forms.GroupBox();
            this.cb_usuario_saida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cx_qtd_saida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_motivo_saida = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cx_data_saida = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_gravar_saida = new System.Windows.Forms.Button();
            this.bt_cancelar_saida = new System.Windows.Forms.Button();
            this.dg_mostra_entrada_saida = new System.Windows.Forms.DataGridView();
            this.bt_buscar_identificacao = new System.Windows.Forms.Button();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.gr_entrada.SuspendLayout();
            this.grp_entrada.SuspendLayout();
            this.grp_saida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_entrada_saida)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_entrada
            // 
            this.gr_entrada.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gr_entrada.Controls.Add(this.bt_bucar_produto);
            this.gr_entrada.Controls.Add(this.cx_id_estoque);
            this.gr_entrada.Controls.Add(this.label14);
            this.gr_entrada.Controls.Add(this.cx_unidade);
            this.gr_entrada.Controls.Add(this.label17);
            this.gr_entrada.Controls.Add(this.grp_entrada);
            this.gr_entrada.Controls.Add(this.label2);
            this.gr_entrada.Controls.Add(this.cx_descricao);
            this.gr_entrada.Controls.Add(this.label11);
            this.gr_entrada.Controls.Add(this.cx_cod_interno);
            this.gr_entrada.Controls.Add(this.cx_qtd_atual);
            this.gr_entrada.Controls.Add(this.label8);
            this.gr_entrada.Controls.Add(this.label1);
            this.gr_entrada.Controls.Add(this.cx_cod_externo);
            this.gr_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gr_entrada.Location = new System.Drawing.Point(3, 3);
            this.gr_entrada.Name = "gr_entrada";
            this.gr_entrada.Size = new System.Drawing.Size(438, 312);
            this.gr_entrada.TabIndex = 1;
            this.gr_entrada.TabStop = false;
            this.gr_entrada.Text = "Produto";
            // 
            // bt_bucar_produto
            // 
            this.bt_bucar_produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_bucar_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bucar_produto.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_bucar_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bucar_produto.Location = new System.Drawing.Point(254, 9);
            this.bt_bucar_produto.Name = "bt_bucar_produto";
            this.bt_bucar_produto.Size = new System.Drawing.Size(45, 29);
            this.bt_bucar_produto.TabIndex = 2;
            this.bt_bucar_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_bucar_produto.UseVisualStyleBackColor = false;
            this.bt_bucar_produto.Click += new System.EventHandler(this.bt_bucar_produto_Click);
            // 
            // cx_id_estoque
            // 
            this.cx_id_estoque.BackColor = System.Drawing.SystemColors.Info;
            this.cx_id_estoque.Location = new System.Drawing.Point(133, 11);
            this.cx_id_estoque.MaxLength = 11;
            this.cx_id_estoque.Name = "cx_id_estoque";
            this.cx_id_estoque.Size = new System.Drawing.Size(115, 22);
            this.cx_id_estoque.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Pesquisar Produto:";
            // 
            // cx_unidade
            // 
            this.cx_unidade.BackColor = System.Drawing.SystemColors.Info;
            this.cx_unidade.Location = new System.Drawing.Point(335, 38);
            this.cx_unidade.Name = "cx_unidade";
            this.cx_unidade.ReadOnly = true;
            this.cx_unidade.Size = new System.Drawing.Size(94, 22);
            this.cx_unidade.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(307, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "Uni:";
            // 
            // grp_entrada
            // 
            this.grp_entrada.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grp_entrada.Controls.Add(this.cx_qtd_entrada);
            this.grp_entrada.Controls.Add(this.label7);
            this.grp_entrada.Controls.Add(this.cb_motivo_entrada);
            this.grp_entrada.Controls.Add(this.label6);
            this.grp_entrada.Controls.Add(this.cx_data_entrada);
            this.grp_entrada.Controls.Add(this.label5);
            this.grp_entrada.Controls.Add(this.bt_gravar_entrada);
            this.grp_entrada.Controls.Add(this.bt_canelar_entrada);
            this.grp_entrada.Location = new System.Drawing.Point(9, 205);
            this.grp_entrada.Name = "grp_entrada";
            this.grp_entrada.Size = new System.Drawing.Size(420, 100);
            this.grp_entrada.TabIndex = 23;
            this.grp_entrada.TabStop = false;
            this.grp_entrada.Text = "Dados de entrada";
            // 
            // cx_qtd_entrada
            // 
            this.cx_qtd_entrada.BackColor = System.Drawing.SystemColors.Info;
            this.cx_qtd_entrada.Location = new System.Drawing.Point(55, 70);
            this.cx_qtd_entrada.MaxLength = 6;
            this.cx_qtd_entrada.Name = "cx_qtd_entrada";
            this.cx_qtd_entrada.Size = new System.Drawing.Size(69, 22);
            this.cx_qtd_entrada.TabIndex = 5;
            this.cx_qtd_entrada.Leave += new System.EventHandler(this.cx_qtd_entrada_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Qtd:";
            // 
            // cb_motivo_entrada
            // 
            this.cb_motivo_entrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_motivo_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_motivo_entrada.FormattingEnabled = true;
            this.cb_motivo_entrada.Items.AddRange(new object[] {
            "",
            "- Compra",
            "- Cancelamento",
            "- Correção de Estoque-Entrada",
            "- Devolução",
            "- Reposição"});
            this.cb_motivo_entrada.Location = new System.Drawing.Point(55, 40);
            this.cb_motivo_entrada.Name = "cb_motivo_entrada";
            this.cb_motivo_entrada.Size = new System.Drawing.Size(214, 24);
            this.cb_motivo_entrada.TabIndex = 4;
            this.cb_motivo_entrada.SelectedIndexChanged += new System.EventHandler(this.cb_motivo_entrada_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Movito:";
            // 
            // cx_data_entrada
            // 
            this.cx_data_entrada.Location = new System.Drawing.Point(55, 15);
            this.cx_data_entrada.Mask = "00/00/0000";
            this.cx_data_entrada.Name = "cx_data_entrada";
            this.cx_data_entrada.Size = new System.Drawing.Size(77, 22);
            this.cx_data_entrada.TabIndex = 3;
            this.cx_data_entrada.ValidatingType = typeof(System.DateTime);
            this.cx_data_entrada.Leave += new System.EventHandler(this.cx_data_entrada_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data:";
            // 
            // bt_gravar_entrada
            // 
            this.bt_gravar_entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_gravar_entrada.Enabled = false;
            this.bt_gravar_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar_entrada.Image = global::NDM_SoftwareV5.Properties.Resources.Entrada_produto;
            this.bt_gravar_entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_entrada.Location = new System.Drawing.Point(305, 15);
            this.bt_gravar_entrada.Name = "bt_gravar_entrada";
            this.bt_gravar_entrada.Size = new System.Drawing.Size(111, 38);
            this.bt_gravar_entrada.TabIndex = 7;
            this.bt_gravar_entrada.Text = "Adicionar";
            this.bt_gravar_entrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_entrada.UseVisualStyleBackColor = false;
            this.bt_gravar_entrada.Click += new System.EventHandler(this.bt_gravar_entrada_Click);
            // 
            // bt_canelar_entrada
            // 
            this.bt_canelar_entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_canelar_entrada.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_canelar_entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_canelar_entrada.Location = new System.Drawing.Point(305, 54);
            this.bt_canelar_entrada.Name = "bt_canelar_entrada";
            this.bt_canelar_entrada.Size = new System.Drawing.Size(111, 38);
            this.bt_canelar_entrada.TabIndex = 8;
            this.bt_canelar_entrada.Text = "Cancelar";
            this.bt_canelar_entrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_canelar_entrada.UseVisualStyleBackColor = false;
            this.bt_canelar_entrada.Click += new System.EventHandler(this.bt_canelar_entrada_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Descrição do Produto";
            // 
            // cx_descricao
            // 
            this.cx_descricao.BackColor = System.Drawing.SystemColors.Info;
            this.cx_descricao.Location = new System.Drawing.Point(6, 111);
            this.cx_descricao.Multiline = true;
            this.cx_descricao.Name = "cx_descricao";
            this.cx_descricao.ReadOnly = true;
            this.cx_descricao.Size = new System.Drawing.Size(423, 92);
            this.cx_descricao.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Código Interno";
            // 
            // cx_cod_interno
            // 
            this.cx_cod_interno.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cod_interno.Location = new System.Drawing.Point(106, 66);
            this.cx_cod_interno.Name = "cx_cod_interno";
            this.cx_cod_interno.ReadOnly = true;
            this.cx_cod_interno.Size = new System.Drawing.Size(193, 22);
            this.cx_cod_interno.TabIndex = 6;
            // 
            // cx_qtd_atual
            // 
            this.cx_qtd_atual.BackColor = System.Drawing.SystemColors.Info;
            this.cx_qtd_atual.Location = new System.Drawing.Point(360, 66);
            this.cx_qtd_atual.Name = "cx_qtd_atual";
            this.cx_qtd_atual.ReadOnly = true;
            this.cx_qtd_atual.Size = new System.Drawing.Size(69, 22);
            this.cx_qtd_atual.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Qtd.Atual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Externo";
            // 
            // cx_cod_externo
            // 
            this.cx_cod_externo.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cod_externo.Location = new System.Drawing.Point(106, 38);
            this.cx_cod_externo.Name = "cx_cod_externo";
            this.cx_cod_externo.ReadOnly = true;
            this.cx_cod_externo.Size = new System.Drawing.Size(193, 22);
            this.cx_cod_externo.TabIndex = 5;
            // 
            // cx_ID
            // 
            this.cx_ID.BackColor = System.Drawing.SystemColors.Info;
            this.cx_ID.Location = new System.Drawing.Point(531, 2);
            this.cx_ID.MaxLength = 20;
            this.cx_ID.Name = "cx_ID";
            this.cx_ID.Size = new System.Drawing.Size(240, 20);
            this.cx_ID.TabIndex = 21;
            this.cx_ID.Enter += new System.EventHandler(this.cx_ID_Enter);
            this.cx_ID.Leave += new System.EventHandler(this.cx_ID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Identificação:";
            // 
            // grp_saida
            // 
            this.grp_saida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grp_saida.Controls.Add(this.cb_usuario_saida);
            this.grp_saida.Controls.Add(this.label4);
            this.grp_saida.Controls.Add(this.cx_qtd_saida);
            this.grp_saida.Controls.Add(this.label9);
            this.grp_saida.Controls.Add(this.cb_motivo_saida);
            this.grp_saida.Controls.Add(this.label10);
            this.grp_saida.Controls.Add(this.cx_data_saida);
            this.grp_saida.Controls.Add(this.label12);
            this.grp_saida.Controls.Add(this.bt_gravar_saida);
            this.grp_saida.Controls.Add(this.bt_cancelar_saida);
            this.grp_saida.Location = new System.Drawing.Point(12, 321);
            this.grp_saida.Name = "grp_saida";
            this.grp_saida.Size = new System.Drawing.Size(420, 100);
            this.grp_saida.TabIndex = 24;
            this.grp_saida.TabStop = false;
            this.grp_saida.Text = "Dados de Saída";
            // 
            // cb_usuario_saida
            // 
            this.cb_usuario_saida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_usuario_saida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_usuario_saida.FormattingEnabled = true;
            this.cb_usuario_saida.Items.AddRange(new object[] {
            "",
            "Compra",
            "Devolução",
            "Cancelamento"});
            this.cb_usuario_saida.Location = new System.Drawing.Point(64, 67);
            this.cb_usuario_saida.Name = "cb_usuario_saida";
            this.cb_usuario_saida.Size = new System.Drawing.Size(139, 21);
            this.cb_usuario_saida.TabIndex = 27;
            this.cb_usuario_saida.SelectedIndexChanged += new System.EventHandler(this.cb_usuario_saida_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Saída para:";
            // 
            // cx_qtd_saida
            // 
            this.cx_qtd_saida.BackColor = System.Drawing.SystemColors.Info;
            this.cx_qtd_saida.Location = new System.Drawing.Point(234, 67);
            this.cx_qtd_saida.Name = "cx_qtd_saida";
            this.cx_qtd_saida.Size = new System.Drawing.Size(35, 20);
            this.cx_qtd_saida.TabIndex = 24;
            this.cx_qtd_saida.Leave += new System.EventHandler(this.cx_qtd_saida_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Qtd:";
            // 
            // cb_motivo_saida
            // 
            this.cb_motivo_saida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_motivo_saida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_motivo_saida.FormattingEnabled = true;
            this.cb_motivo_saida.Items.AddRange(new object[] {
            "",
            "- Aluguel",
            "- Correção de Estoque-Saída.",
            "- Equipamento com defeito.",
            "- Mont.de Kit [EPON/GPON].",
            "- Requisição."});
            this.cb_motivo_saida.Location = new System.Drawing.Point(64, 40);
            this.cb_motivo_saida.Name = "cb_motivo_saida";
            this.cb_motivo_saida.Size = new System.Drawing.Size(205, 21);
            this.cb_motivo_saida.TabIndex = 19;
            this.cb_motivo_saida.SelectedIndexChanged += new System.EventHandler(this.cb_motivo_saida_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Movito:";
            // 
            // cx_data_saida
            // 
            this.cx_data_saida.Location = new System.Drawing.Point(64, 15);
            this.cx_data_saida.Mask = "00/00/0000";
            this.cx_data_saida.Name = "cx_data_saida";
            this.cx_data_saida.Size = new System.Drawing.Size(77, 20);
            this.cx_data_saida.TabIndex = 25;
            this.cx_data_saida.ValidatingType = typeof(System.DateTime);
            this.cx_data_saida.Leave += new System.EventHandler(this.cx_data_saida_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Data:";
            // 
            // bt_gravar_saida
            // 
            this.bt_gravar_saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_gravar_saida.Enabled = false;
            this.bt_gravar_saida.Image = global::NDM_SoftwareV5.Properties.Resources.Saida_produtos;
            this.bt_gravar_saida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_saida.Location = new System.Drawing.Point(305, 15);
            this.bt_gravar_saida.Name = "bt_gravar_saida";
            this.bt_gravar_saida.Size = new System.Drawing.Size(111, 38);
            this.bt_gravar_saida.TabIndex = 9;
            this.bt_gravar_saida.Text = "Retirar";
            this.bt_gravar_saida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_saida.UseVisualStyleBackColor = false;
            this.bt_gravar_saida.Click += new System.EventHandler(this.bt_gravar_saida_Click);
            // 
            // bt_cancelar_saida
            // 
            this.bt_cancelar_saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar_saida.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar_saida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar_saida.Location = new System.Drawing.Point(305, 54);
            this.bt_cancelar_saida.Name = "bt_cancelar_saida";
            this.bt_cancelar_saida.Size = new System.Drawing.Size(111, 38);
            this.bt_cancelar_saida.TabIndex = 10;
            this.bt_cancelar_saida.Text = "Cancelar";
            this.bt_cancelar_saida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar_saida.UseVisualStyleBackColor = false;
            this.bt_cancelar_saida.Click += new System.EventHandler(this.bt_cancelar_saida_Click);
            // 
            // dg_mostra_entrada_saida
            // 
            this.dg_mostra_entrada_saida.AllowUserToAddRows = false;
            this.dg_mostra_entrada_saida.AllowUserToDeleteRows = false;
            this.dg_mostra_entrada_saida.AllowUserToResizeColumns = false;
            this.dg_mostra_entrada_saida.AllowUserToResizeRows = false;
            this.dg_mostra_entrada_saida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_entrada_saida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_mostra_entrada_saida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dg_mostra_entrada_saida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_entrada_saida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dg_mostra_entrada_saida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_entrada_saida.Location = new System.Drawing.Point(448, 33);
            this.dg_mostra_entrada_saida.MultiSelect = false;
            this.dg_mostra_entrada_saida.Name = "dg_mostra_entrada_saida";
            this.dg_mostra_entrada_saida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_entrada_saida.Size = new System.Drawing.Size(374, 282);
            this.dg_mostra_entrada_saida.TabIndex = 25;
            // 
            // bt_buscar_identificacao
            // 
            this.bt_buscar_identificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_buscar_identificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar_identificacao.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_buscar_identificacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar_identificacao.Location = new System.Drawing.Point(777, -1);
            this.bt_buscar_identificacao.Name = "bt_buscar_identificacao";
            this.bt_buscar_identificacao.Size = new System.Drawing.Size(45, 33);
            this.bt_buscar_identificacao.TabIndex = 26;
            this.bt_buscar_identificacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar_identificacao.UseVisualStyleBackColor = false;
            this.bt_buscar_identificacao.Click += new System.EventHandler(this.bt_buscar_identificacao_Click);
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(447, 22);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(110, 13);
            this.lbl_descricao.TabIndex = 27;
            this.lbl_descricao.Text = "Descrição do Produto";
            // 
            // frm_entrada_saida_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 426);
            this.Controls.Add(this.bt_buscar_identificacao);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.dg_mostra_entrada_saida);
            this.Controls.Add(this.cx_ID);
            this.Controls.Add(this.grp_saida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gr_entrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_entrada_saida_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Estoque - Entrada / Saída  } ::...";
            this.Load += new System.EventHandler(this.frm_entrada_saida_produto_Load);
            this.gr_entrada.ResumeLayout(false);
            this.gr_entrada.PerformLayout();
            this.grp_entrada.ResumeLayout(false);
            this.grp_entrada.PerformLayout();
            this.grp_saida.ResumeLayout(false);
            this.grp_saida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_entrada_saida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_entrada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cx_cod_interno;
        private System.Windows.Forms.Button bt_gravar_entrada;
        private System.Windows.Forms.TextBox cx_qtd_atual;
        private System.Windows.Forms.Button bt_canelar_entrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cx_cod_externo;
        private System.Windows.Forms.TextBox cx_unidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grp_entrada;
        private System.Windows.Forms.TextBox cx_qtd_entrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_motivo_entrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox cx_data_entrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cx_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cx_descricao;
        private System.Windows.Forms.GroupBox grp_saida;
        private System.Windows.Forms.ComboBox cb_usuario_saida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cx_qtd_saida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_motivo_saida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox cx_data_saida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_gravar_saida;
        private System.Windows.Forms.Button bt_cancelar_saida;
        private System.Windows.Forms.Button bt_buscar_identificacao;
        private System.Windows.Forms.DataGridView dg_mostra_entrada_saida;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Button bt_bucar_produto;
        private System.Windows.Forms.TextBox cx_id_estoque;
        private System.Windows.Forms.Label label14;
    }
}