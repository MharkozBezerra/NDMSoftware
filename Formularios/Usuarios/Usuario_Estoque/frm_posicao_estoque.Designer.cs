namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class frm_posicao_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_posicao_estoque));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_filial_descricao = new System.Windows.Forms.ComboBox();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.cx_texto = new System.Windows.Forms.TextBox();
            this.cb_buscar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mostra_estoque = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cx_localizacao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cx_qtd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cx_unidade = new System.Windows.Forms.TextBox();
            this.cx_fornecedor = new System.Windows.Forms.TextBox();
            this.cx_subcategoria = new System.Windows.Forms.TextBox();
            this.cx_categoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cx_cod_interno = new System.Windows.Forms.TextBox();
            this.cx_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cx_descricao_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cx_cod_externo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_alocar = new System.Windows.Forms.Button();
            this.bt_gravar_saida = new System.Windows.Forms.Button();
            this.bt_gravar_entrada = new System.Windows.Forms.Button();
            this.bt_novo_produto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.bt_categoria = new System.Windows.Forms.Button();
            this.bt_subcategoria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_estoque)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_filial_descricao);
            this.groupBox1.Controls.Add(this.bt_procurar);
            this.groupBox1.Controls.Add(this.cx_texto);
            this.groupBox1.Controls.Add(this.cb_buscar);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(104, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base:";
            // 
            // cb_filial_descricao
            // 
            this.cb_filial_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filial_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filial_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_filial_descricao.FormattingEnabled = true;
            this.cb_filial_descricao.Location = new System.Drawing.Point(152, 10);
            this.cb_filial_descricao.Name = "cb_filial_descricao";
            this.cb_filial_descricao.Size = new System.Drawing.Size(390, 24);
            this.cb_filial_descricao.TabIndex = 7;
            this.cb_filial_descricao.SelectedIndexChanged += new System.EventHandler(this.cb_filial_descricao_SelectedIndexChanged);
            // 
            // bt_procurar
            // 
            this.bt_procurar.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_procurar.Location = new System.Drawing.Point(552, 11);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(97, 55);
            this.bt_procurar.TabIndex = 40;
            this.bt_procurar.UseVisualStyleBackColor = true;
            this.bt_procurar.Click += new System.EventHandler(this.bt_procurar_Click);
            // 
            // cx_texto
            // 
            this.cx_texto.Location = new System.Drawing.Point(235, 39);
            this.cx_texto.MaxLength = 50;
            this.cx_texto.Name = "cx_texto";
            this.cx_texto.Size = new System.Drawing.Size(309, 20);
            this.cx_texto.TabIndex = 39;
            // 
            // cb_buscar
            // 
            this.cb_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_buscar.FormattingEnabled = true;
            this.cb_buscar.Items.AddRange(new object[] {
            "",
            "CATEGORIA",
            "SUBCATEGORIA",
            "CÓD. INTERNO",
            "CÓD. EXTERNO",
            "FORNECEDOR",
            "DESCRIÇÃO",
            "PROD.NÃO ALOCADOS"});
            this.cb_buscar.Location = new System.Drawing.Point(74, 39);
            this.cb_buscar.Name = "cb_buscar";
            this.cb_buscar.Size = new System.Drawing.Size(155, 21);
            this.cb_buscar.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Buscar por:";
            // 
            // mostra_estoque
            // 
            this.mostra_estoque.AllowUserToAddRows = false;
            this.mostra_estoque.AllowUserToDeleteRows = false;
            this.mostra_estoque.AllowUserToResizeColumns = false;
            this.mostra_estoque.AllowUserToResizeRows = false;
            this.mostra_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mostra_estoque.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mostra_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostra_estoque.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mostra_estoque.Location = new System.Drawing.Point(4, 73);
            this.mostra_estoque.MultiSelect = false;
            this.mostra_estoque.Name = "mostra_estoque";
            this.mostra_estoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostra_estoque.Size = new System.Drawing.Size(553, 273);
            this.mostra_estoque.TabIndex = 1;
            this.mostra_estoque.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mostra_estoque_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cx_unidade);
            this.groupBox2.Controls.Add(this.cx_fornecedor);
            this.groupBox2.Controls.Add(this.cx_subcategoria);
            this.groupBox2.Controls.Add(this.cx_categoria);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cx_cod_interno);
            this.groupBox2.Controls.Add(this.cx_valor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cx_descricao_produto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cx_cod_externo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.cx_localizacao);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbl_data);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cx_qtd);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(294, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 78);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cx_localizacao
            // 
            this.cx_localizacao.BackColor = System.Drawing.SystemColors.Info;
            this.cx_localizacao.Location = new System.Drawing.Point(87, 19);
            this.cx_localizacao.Name = "cx_localizacao";
            this.cx_localizacao.ReadOnly = true;
            this.cx_localizacao.Size = new System.Drawing.Size(125, 20);
            this.cx_localizacao.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Localização ->";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(249, 43);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(65, 13);
            this.lbl_data.TabIndex = 46;
            this.lbl_data.Text = "00/00/0000";
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Última Movimentação";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cx_qtd
            // 
            this.cx_qtd.BackColor = System.Drawing.SystemColors.Info;
            this.cx_qtd.Location = new System.Drawing.Point(87, 42);
            this.cx_qtd.Name = "cx_qtd";
            this.cx_qtd.ReadOnly = true;
            this.cx_qtd.Size = new System.Drawing.Size(76, 20);
            this.cx_qtd.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Estoque ->";
            // 
            // cx_unidade
            // 
            this.cx_unidade.BackColor = System.Drawing.SystemColors.Control;
            this.cx_unidade.Location = new System.Drawing.Point(439, 68);
            this.cx_unidade.Name = "cx_unidade";
            this.cx_unidade.ReadOnly = true;
            this.cx_unidade.Size = new System.Drawing.Size(90, 20);
            this.cx_unidade.TabIndex = 38;
            // 
            // cx_fornecedor
            // 
            this.cx_fornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.cx_fornecedor.Location = new System.Drawing.Point(439, 29);
            this.cx_fornecedor.Name = "cx_fornecedor";
            this.cx_fornecedor.ReadOnly = true;
            this.cx_fornecedor.Size = new System.Drawing.Size(210, 20);
            this.cx_fornecedor.TabIndex = 37;
            // 
            // cx_subcategoria
            // 
            this.cx_subcategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cx_subcategoria.Location = new System.Drawing.Point(221, 29);
            this.cx_subcategoria.Name = "cx_subcategoria";
            this.cx_subcategoria.ReadOnly = true;
            this.cx_subcategoria.Size = new System.Drawing.Size(211, 20);
            this.cx_subcategoria.TabIndex = 36;
            // 
            // cx_categoria
            // 
            this.cx_categoria.BackColor = System.Drawing.SystemColors.Control;
            this.cx_categoria.Location = new System.Drawing.Point(9, 29);
            this.cx_categoria.Name = "cx_categoria";
            this.cx_categoria.ReadOnly = true;
            this.cx_categoria.Size = new System.Drawing.Size(206, 20);
            this.cx_categoria.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Código Interno";
            // 
            // cx_cod_interno
            // 
            this.cx_cod_interno.BackColor = System.Drawing.SystemColors.Control;
            this.cx_cod_interno.Location = new System.Drawing.Point(221, 68);
            this.cx_cod_interno.Name = "cx_cod_interno";
            this.cx_cod_interno.ReadOnly = true;
            this.cx_cod_interno.Size = new System.Drawing.Size(211, 20);
            this.cx_cod_interno.TabIndex = 27;
            // 
            // cx_valor
            // 
            this.cx_valor.BackColor = System.Drawing.SystemColors.Info;
            this.cx_valor.Location = new System.Drawing.Point(552, 68);
            this.cx_valor.Name = "cx_valor";
            this.cx_valor.ReadOnly = true;
            this.cx_valor.Size = new System.Drawing.Size(97, 20);
            this.cx_valor.TabIndex = 28;
            this.cx_valor.TextChanged += new System.EventHandler(this.cx_valor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Valor:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Unidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Descrição do Produto";
            // 
            // cx_descricao_produto
            // 
            this.cx_descricao_produto.BackColor = System.Drawing.SystemColors.Info;
            this.cx_descricao_produto.Location = new System.Drawing.Point(6, 107);
            this.cx_descricao_produto.Multiline = true;
            this.cx_descricao_produto.Name = "cx_descricao_produto";
            this.cx_descricao_produto.ReadOnly = true;
            this.cx_descricao_produto.Size = new System.Drawing.Size(282, 69);
            this.cx_descricao_produto.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código Externo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fornecedor";
            // 
            // cx_cod_externo
            // 
            this.cx_cod_externo.BackColor = System.Drawing.SystemColors.Control;
            this.cx_cod_externo.Location = new System.Drawing.Point(6, 68);
            this.cx_cod_externo.Name = "cx_cod_externo";
            this.cx_cod_externo.ReadOnly = true;
            this.cx_cod_externo.Size = new System.Drawing.Size(209, 20);
            this.cx_cod_externo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Subcategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categoria";
            // 
            // bt_alocar
            // 
            this.bt_alocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_alocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alocar.Image = global::NDM_SoftwareV5.Properties.Resources.icone_alocar_produto_cor;
            this.bt_alocar.Location = new System.Drawing.Point(558, 190);
            this.bt_alocar.Name = "bt_alocar";
            this.bt_alocar.Size = new System.Drawing.Size(102, 78);
            this.bt_alocar.TabIndex = 12;
            this.bt_alocar.Text = "Alocar Produto";
            this.bt_alocar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_alocar.UseVisualStyleBackColor = false;
            this.bt_alocar.Click += new System.EventHandler(this.bt_alocar_Click);
            // 
            // bt_gravar_saida
            // 
            this.bt_gravar_saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_gravar_saida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gravar_saida.Image = global::NDM_SoftwareV5.Properties.Resources.Saida_produtos;
            this.bt_gravar_saida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_saida.Location = new System.Drawing.Point(558, 151);
            this.bt_gravar_saida.Name = "bt_gravar_saida";
            this.bt_gravar_saida.Size = new System.Drawing.Size(102, 38);
            this.bt_gravar_saida.TabIndex = 10;
            this.bt_gravar_saida.Text = "Saída";
            this.bt_gravar_saida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_saida.UseVisualStyleBackColor = false;
            this.bt_gravar_saida.Click += new System.EventHandler(this.bt_gravar_saida_Click);
            // 
            // bt_gravar_entrada
            // 
            this.bt_gravar_entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_gravar_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gravar_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar_entrada.Image = global::NDM_SoftwareV5.Properties.Resources.Entrada_produto;
            this.bt_gravar_entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_entrada.Location = new System.Drawing.Point(558, 112);
            this.bt_gravar_entrada.Name = "bt_gravar_entrada";
            this.bt_gravar_entrada.Size = new System.Drawing.Size(102, 38);
            this.bt_gravar_entrada.TabIndex = 11;
            this.bt_gravar_entrada.Text = "Entrada";
            this.bt_gravar_entrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_entrada.UseVisualStyleBackColor = false;
            this.bt_gravar_entrada.Click += new System.EventHandler(this.bt_gravar_entrada_Click);
            // 
            // bt_novo_produto
            // 
            this.bt_novo_produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_novo_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo_produto.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.bt_novo_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_novo_produto.Location = new System.Drawing.Point(558, 73);
            this.bt_novo_produto.Name = "bt_novo_produto";
            this.bt_novo_produto.Size = new System.Drawing.Size(102, 38);
            this.bt_novo_produto.TabIndex = 13;
            this.bt_novo_produto.Text = "Novo Prod.";
            this.bt_novo_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_novo_produto.UseVisualStyleBackColor = false;
            this.bt_novo_produto.Click += new System.EventHandler(this.bt_novo_produto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Location = new System.Drawing.Point(202, 546);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 78);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(224, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Localização:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(206, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "00/00/0000";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(184, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Última Movimentação";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(76, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Estoque ->";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(76, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Saidas ( - ):";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(76, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Entradas ( + ):";
            // 
            // bt_categoria
            // 
            this.bt_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_categoria.Location = new System.Drawing.Point(558, 269);
            this.bt_categoria.Name = "bt_categoria";
            this.bt_categoria.Size = new System.Drawing.Size(102, 38);
            this.bt_categoria.TabIndex = 48;
            this.bt_categoria.Text = "&Categoria";
            this.bt_categoria.UseVisualStyleBackColor = false;
            this.bt_categoria.Click += new System.EventHandler(this.bt_categoria_Click);
            // 
            // bt_subcategoria
            // 
            this.bt_subcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_subcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_subcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_subcategoria.Location = new System.Drawing.Point(558, 308);
            this.bt_subcategoria.Name = "bt_subcategoria";
            this.bt_subcategoria.Size = new System.Drawing.Size(102, 38);
            this.bt_subcategoria.TabIndex = 49;
            this.bt_subcategoria.Text = "&Subcategoria";
            this.bt_subcategoria.UseVisualStyleBackColor = false;
            this.bt_subcategoria.Click += new System.EventHandler(this.bt_subcategoria_Click);
            // 
            // frm_posicao_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 536);
            this.Controls.Add(this.bt_subcategoria);
            this.Controls.Add(this.bt_categoria);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bt_novo_produto);
            this.Controls.Add(this.bt_alocar);
            this.Controls.Add(this.bt_gravar_saida);
            this.Controls.Add(this.bt_gravar_entrada);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mostra_estoque);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_posicao_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Estoque - Posição } ::...";
            this.Load += new System.EventHandler(this.frm_posicao_estoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_estoque)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView mostra_estoque;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_filial_descricao;
        private System.Windows.Forms.TextBox cx_unidade;
        private System.Windows.Forms.TextBox cx_fornecedor;
        private System.Windows.Forms.TextBox cx_subcategoria;
        private System.Windows.Forms.TextBox cx_categoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cx_cod_interno;
        private System.Windows.Forms.TextBox cx_valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cx_descricao_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cx_cod_externo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cx_qtd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.TextBox cx_texto;
        private System.Windows.Forms.ComboBox cb_buscar;
        private System.Windows.Forms.TextBox cx_localizacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bt_gravar_saida;
        private System.Windows.Forms.Button bt_gravar_entrada;
        private System.Windows.Forms.Button bt_alocar;
        private System.Windows.Forms.Button bt_novo_produto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bt_categoria;
        private System.Windows.Forms.Button bt_subcategoria;
    }
}