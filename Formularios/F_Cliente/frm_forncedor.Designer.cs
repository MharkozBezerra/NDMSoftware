namespace NDM_SoftwareV5.Formularios.F_Cliente
{
    partial class frm_forncedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_forncedor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.cb_proverdor = new System.Windows.Forms.ComboBox();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.grp_endereco_ver = new System.Windows.Forms.GroupBox();
            this.cx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cx_celular = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cx_cpf_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.cx_rg_re = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cx_numero_casa = new System.Windows.Forms.TextBox();
            this.cx_cep = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cx_rua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cx_bairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cx_cidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.cx_codigo_atual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cx_nome_atual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_mostra_fornecedor = new System.Windows.Forms.DataGridView();
            this.cb_texto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cx_pesquisar = new System.Windows.Forms.TextBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.chk_cnpj = new System.Windows.Forms.CheckBox();
            this.chk_ie = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.grp_endereco_ver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.bt_cancelar);
            this.groupBox2.Controls.Add(this.cb_proverdor);
            this.groupBox2.Controls.Add(this.bt_alterar);
            this.groupBox2.Controls.Add(this.grp_endereco_ver);
            this.groupBox2.Controls.Add(this.bt_gravar);
            this.groupBox2.Controls.Add(this.cx_codigo_atual);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cx_nome_atual);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 339);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(198, 298);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(86, 35);
            this.bt_cancelar.TabIndex = 27;
            this.bt_cancelar.Text = "Alterar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // cb_proverdor
            // 
            this.cb_proverdor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_proverdor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_proverdor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_proverdor.FormattingEnabled = true;
            this.cb_proverdor.Location = new System.Drawing.Point(47, 20);
            this.cb_proverdor.Name = "cb_proverdor";
            this.cb_proverdor.Size = new System.Drawing.Size(260, 25);
            this.cb_proverdor.TabIndex = 26;
            this.cb_proverdor.SelectedIndexChanged += new System.EventHandler(this.cb_proverdor_SelectedIndexChanged);
            // 
            // bt_alterar
            // 
            this.bt_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_alterar.Enabled = false;
            this.bt_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_alterar.Location = new System.Drawing.Point(109, 298);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(86, 35);
            this.bt_alterar.TabIndex = 25;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_alterar.UseVisualStyleBackColor = false;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // grp_endereco_ver
            // 
            this.grp_endereco_ver.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grp_endereco_ver.Controls.Add(this.chk_ie);
            this.grp_endereco_ver.Controls.Add(this.chk_cnpj);
            this.grp_endereco_ver.Controls.Add(this.cx_telefone);
            this.grp_endereco_ver.Controls.Add(this.label2);
            this.grp_endereco_ver.Controls.Add(this.cx_celular);
            this.grp_endereco_ver.Controls.Add(this.label1);
            this.grp_endereco_ver.Controls.Add(this.cx_cpf_cnpj);
            this.grp_endereco_ver.Controls.Add(this.cx_rg_re);
            this.grp_endereco_ver.Controls.Add(this.label14);
            this.grp_endereco_ver.Controls.Add(this.label19);
            this.grp_endereco_ver.Controls.Add(this.label15);
            this.grp_endereco_ver.Controls.Add(this.cx_numero_casa);
            this.grp_endereco_ver.Controls.Add(this.cx_cep);
            this.grp_endereco_ver.Controls.Add(this.label8);
            this.grp_endereco_ver.Controls.Add(this.cx_rua);
            this.grp_endereco_ver.Controls.Add(this.label11);
            this.grp_endereco_ver.Controls.Add(this.cx_bairro);
            this.grp_endereco_ver.Controls.Add(this.label12);
            this.grp_endereco_ver.Controls.Add(this.cx_cidade);
            this.grp_endereco_ver.Controls.Add(this.label13);
            this.grp_endereco_ver.Location = new System.Drawing.Point(2, 92);
            this.grp_endereco_ver.Name = "grp_endereco_ver";
            this.grp_endereco_ver.Size = new System.Drawing.Size(309, 200);
            this.grp_endereco_ver.TabIndex = 24;
            this.grp_endereco_ver.TabStop = false;
            this.grp_endereco_ver.Text = "Endereço";
            // 
            // cx_telefone
            // 
            this.cx_telefone.Location = new System.Drawing.Point(203, 62);
            this.cx_telefone.Mask = "(99) 0000-0000";
            this.cx_telefone.Name = "cx_telefone";
            this.cx_telefone.Size = new System.Drawing.Size(100, 20);
            this.cx_telefone.TabIndex = 38;
            this.cx_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(166, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tel:";
            // 
            // cx_celular
            // 
            this.cx_celular.Location = new System.Drawing.Point(63, 62);
            this.cx_celular.Mask = "(99) 9000-0000";
            this.cx_celular.Name = "cx_celular";
            this.cx_celular.Size = new System.Drawing.Size(100, 20);
            this.cx_celular.TabIndex = 36;
            this.cx_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Celular:";
            // 
            // cx_cpf_cnpj
            // 
            this.cx_cpf_cnpj.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cpf_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cpf_cnpj.Location = new System.Drawing.Point(89, 34);
            this.cx_cpf_cnpj.Mask = "AAA.AAA.AAA-AA";
            this.cx_cpf_cnpj.Name = "cx_cpf_cnpj";
            this.cx_cpf_cnpj.Size = new System.Drawing.Size(130, 22);
            this.cx_cpf_cnpj.TabIndex = 32;
            this.cx_cpf_cnpj.Text = "00000000000";
            this.cx_cpf_cnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cx_cpf_cnpj_MaskInputRejected);
            // 
            // cx_rg_re
            // 
            this.cx_rg_re.BackColor = System.Drawing.SystemColors.Info;
            this.cx_rg_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_rg_re.Location = new System.Drawing.Point(71, 10);
            this.cx_rg_re.Mask = "000.000.000-0";
            this.cx_rg_re.Name = "cx_rg_re";
            this.cx_rg_re.Size = new System.Drawing.Size(148, 22);
            this.cx_rg_re.TabIndex = 31;
            this.cx_rg_re.Text = "000000000";
            this.cx_rg_re.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cx_rg_re_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(3, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "* CPF / CNPJ:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(11, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "* RG / IE:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(38, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Nº:";
            // 
            // cx_numero_casa
            // 
            this.cx_numero_casa.BackColor = System.Drawing.SystemColors.Info;
            this.cx_numero_casa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_numero_casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_numero_casa.Location = new System.Drawing.Point(62, 167);
            this.cx_numero_casa.MaxLength = 5;
            this.cx_numero_casa.Name = "cx_numero_casa";
            this.cx_numero_casa.Size = new System.Drawing.Size(93, 22);
            this.cx_numero_casa.TabIndex = 29;
            this.cx_numero_casa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx_cep
            // 
            this.cx_cep.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cep.Location = new System.Drawing.Point(205, 167);
            this.cx_cep.Mask = "00000-000";
            this.cx_cep.Name = "cx_cep";
            this.cx_cep.Size = new System.Drawing.Size(98, 22);
            this.cx_cep.TabIndex = 4;
            this.cx_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(161, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "CEP:";
            // 
            // cx_rua
            // 
            this.cx_rua.BackColor = System.Drawing.SystemColors.Info;
            this.cx_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_rua.Location = new System.Drawing.Point(63, 140);
            this.cx_rua.MaxLength = 99;
            this.cx_rua.Name = "cx_rua";
            this.cx_rua.Size = new System.Drawing.Size(242, 22);
            this.cx_rua.TabIndex = 5;
            this.cx_rua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(28, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Rua:";
            // 
            // cx_bairro
            // 
            this.cx_bairro.BackColor = System.Drawing.SystemColors.Info;
            this.cx_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_bairro.Location = new System.Drawing.Point(63, 112);
            this.cx_bairro.MaxLength = 99;
            this.cx_bairro.Name = "cx_bairro";
            this.cx_bairro.Size = new System.Drawing.Size(240, 22);
            this.cx_bairro.TabIndex = 3;
            this.cx_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(17, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Bairro:";
            // 
            // cx_cidade
            // 
            this.cx_cidade.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cidade.Location = new System.Drawing.Point(63, 84);
            this.cx_cidade.MaxLength = 99;
            this.cx_cidade.Name = "cx_cidade";
            this.cx_cidade.Size = new System.Drawing.Size(240, 22);
            this.cx_cidade.TabIndex = 2;
            this.cx_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(9, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cidade:";
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_gravar.Enabled = false;
            this.bt_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gravar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar.Location = new System.Drawing.Point(21, 298);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(85, 35);
            this.bt_gravar.TabIndex = 19;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // cx_codigo_atual
            // 
            this.cx_codigo_atual.BackColor = System.Drawing.SystemColors.Info;
            this.cx_codigo_atual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_codigo_atual.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_codigo_atual.ForeColor = System.Drawing.Color.Red;
            this.cx_codigo_atual.Location = new System.Drawing.Point(4, 64);
            this.cx_codigo_atual.MaxLength = 5;
            this.cx_codigo_atual.Name = "cx_codigo_atual";
            this.cx_codigo_atual.Size = new System.Drawing.Size(65, 22);
            this.cx_codigo_atual.TabIndex = 22;
            this.cx_codigo_atual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Base:";
            // 
            // cx_nome_atual
            // 
            this.cx_nome_atual.BackColor = System.Drawing.SystemColors.Info;
            this.cx_nome_atual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_nome_atual.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_nome_atual.ForeColor = System.Drawing.Color.Red;
            this.cx_nome_atual.Location = new System.Drawing.Point(73, 64);
            this.cx_nome_atual.MaxLength = 110;
            this.cx_nome_atual.Name = "cx_nome_atual";
            this.cx_nome_atual.Size = new System.Drawing.Size(234, 22);
            this.cx_nome_atual.TabIndex = 19;
            this.cx_nome_atual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_nome_atual.TextChanged += new System.EventHandler(this.cx_nome_atual_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(4, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(75, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "* Nome";
            // 
            // dg_mostra_fornecedor
            // 
            this.dg_mostra_fornecedor.AllowUserToAddRows = false;
            this.dg_mostra_fornecedor.AllowUserToDeleteRows = false;
            this.dg_mostra_fornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_fornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dg_mostra_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_fornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dg_mostra_fornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_fornecedor.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg_mostra_fornecedor.Location = new System.Drawing.Point(314, 31);
            this.dg_mostra_fornecedor.MultiSelect = false;
            this.dg_mostra_fornecedor.Name = "dg_mostra_fornecedor";
            this.dg_mostra_fornecedor.ReadOnly = true;
            this.dg_mostra_fornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_fornecedor.Size = new System.Drawing.Size(496, 308);
            this.dg_mostra_fornecedor.TabIndex = 18;
            this.dg_mostra_fornecedor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_mostra_fornecedor_CellMouseDoubleClick);
            // 
            // cb_texto
            // 
            this.cb_texto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_texto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_texto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_texto.FormattingEnabled = true;
            this.cb_texto.Items.AddRange(new object[] {
            "",
            "NOME",
            "CPF / CNPJ",
            "RG / IE",
            "CIDADE",
            "CELULAR",
            "TELEFONE"});
            this.cb_texto.Location = new System.Drawing.Point(354, 3);
            this.cb_texto.Name = "cb_texto";
            this.cb_texto.Size = new System.Drawing.Size(127, 25);
            this.cb_texto.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(313, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filtrar:";
            // 
            // cx_pesquisar
            // 
            this.cx_pesquisar.BackColor = System.Drawing.SystemColors.Info;
            this.cx_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_pesquisar.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_pesquisar.ForeColor = System.Drawing.Color.Red;
            this.cx_pesquisar.Location = new System.Drawing.Point(487, 6);
            this.cx_pesquisar.MaxLength = 100;
            this.cx_pesquisar.Name = "cx_pesquisar";
            this.cx_pesquisar.Size = new System.Drawing.Size(234, 22);
            this.cx_pesquisar.TabIndex = 28;
            this.cx_pesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_pesquisar.TextChanged += new System.EventHandler(this.cx_pesquisar_TextChanged);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_pesquisar.Enabled = false;
            this.bt_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_pesquisar.Location = new System.Drawing.Point(725, 2);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(85, 26);
            this.bt_pesquisar.TabIndex = 28;
            this.bt_pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // chk_cnpj
            // 
            this.chk_cnpj.AutoSize = true;
            this.chk_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chk_cnpj.Location = new System.Drawing.Point(226, 35);
            this.chk_cnpj.Name = "chk_cnpj";
            this.chk_cnpj.Size = new System.Drawing.Size(62, 20);
            this.chk_cnpj.TabIndex = 39;
            this.chk_cnpj.Text = "CNPJ";
            this.chk_cnpj.UseVisualStyleBackColor = true;
            this.chk_cnpj.CheckedChanged += new System.EventHandler(this.chk_cnpj_CheckedChanged);
            // 
            // chk_ie
            // 
            this.chk_ie.AutoSize = true;
            this.chk_ie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chk_ie.Location = new System.Drawing.Point(226, 12);
            this.chk_ie.Name = "chk_ie";
            this.chk_ie.Size = new System.Drawing.Size(39, 20);
            this.chk_ie.TabIndex = 40;
            this.chk_ie.Text = "IE";
            this.chk_ie.UseVisualStyleBackColor = true;
            this.chk_ie.CheckedChanged += new System.EventHandler(this.chk_ie_CheckedChanged);
            // 
            // frm_forncedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 342);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.cx_pesquisar);
            this.Controls.Add(this.cb_texto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_mostra_fornecedor);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_forncedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - {Fornecedor } ::...";
            this.Load += new System.EventHandler(this.frm_forncedor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_endereco_ver.ResumeLayout(false);
            this.grp_endereco_ver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grp_endereco_ver;
        private System.Windows.Forms.MaskedTextBox cx_cpf_cnpj;
        private System.Windows.Forms.MaskedTextBox cx_rg_re;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cx_numero_casa;
        private System.Windows.Forms.MaskedTextBox cx_cep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cx_rua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cx_bairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cx_cidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.TextBox cx_codigo_atual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cx_nome_atual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.DataGridView dg_mostra_fornecedor;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.ComboBox cb_proverdor;
        private System.Windows.Forms.MaskedTextBox cx_telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cx_celular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_texto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cx_pesquisar;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.CheckBox chk_ie;
        private System.Windows.Forms.CheckBox chk_cnpj;
    }
}