namespace NDM_SoftwareV5.Formularios.F_Cliente
{
    partial class frm_add_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_cliente));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_gravar_1 = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_cancelar_1 = new System.Windows.Forms.Button();
            this.cx_cpf_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.cx_rg_re = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cx_base = new System.Windows.Forms.TextBox();
            this.cx_nomeCliente = new System.Windows.Forms.TextBox();
            this.cx_codCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_telefone = new System.Windows.Forms.GroupBox();
            this.bt_exluir_numero = new System.Windows.Forms.Button();
            this.bt_incluir_numero = new System.Windows.Forms.Button();
            this.dg_mostra_telefone = new System.Windows.Forms.DataGridView();
            this.grp_endereco_ver = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cx_numero_casa = new System.Windows.Forms.TextBox();
            this.cx_cep = new System.Windows.Forms.MaskedTextBox();
            this.bt_atualizar_1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.cx_rua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cx_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cx_cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_add_endereco = new System.Windows.Forms.GroupBox();
            this.cb_rua_cep = new System.Windows.Forms.ComboBox();
            this.cb_rua_descricao = new System.Windows.Forms.ComboBox();
            this.cx_numero_casa_2 = new System.Windows.Forms.TextBox();
            this.cb_bairro_descricao = new System.Windows.Forms.ComboBox();
            this.cb_cidade_descricao = new System.Windows.Forms.ComboBox();
            this.bt_gravar_2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_cancelar_2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_cidade_ID = new System.Windows.Forms.ComboBox();
            this.cb_bairro_ID = new System.Windows.Forms.ComboBox();
            this.cb_rua_ID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grp_telefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_telefone)).BeginInit();
            this.grp_endereco_ver.SuspendLayout();
            this.grp_add_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Atenção: Confirme os dados antes de clicar no botão \"Gravar\"";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.bt_gravar_1);
            this.groupBox1.Controls.Add(this.bt_atualizar);
            this.groupBox1.Controls.Add(this.bt_cancelar_1);
            this.groupBox1.Controls.Add(this.cx_cpf_cnpj);
            this.groupBox1.Controls.Add(this.cx_rg_re);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cx_base);
            this.groupBox1.Controls.Add(this.cx_nomeCliente);
            this.groupBox1.Controls.Add(this.cx_codCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 140);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // bt_gravar_1
            // 
            this.bt_gravar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_gravar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gravar_1.Enabled = false;
            this.bt_gravar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar_1.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_gravar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_1.Location = new System.Drawing.Point(138, 98);
            this.bt_gravar_1.Name = "bt_gravar_1";
            this.bt_gravar_1.Size = new System.Drawing.Size(87, 38);
            this.bt_gravar_1.TabIndex = 6;
            this.bt_gravar_1.Text = "Gravar";
            this.bt_gravar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_1.UseVisualStyleBackColor = false;
            this.bt_gravar_1.Click += new System.EventHandler(this.bt_gravar_1_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_atualizar.Enabled = false;
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(226, 98);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(96, 38);
            this.bt_atualizar.TabIndex = 7;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_cancelar_1
            // 
            this.bt_cancelar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar_1.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar_1.Location = new System.Drawing.Point(323, 98);
            this.bt_cancelar_1.Name = "bt_cancelar_1";
            this.bt_cancelar_1.Size = new System.Drawing.Size(96, 38);
            this.bt_cancelar_1.TabIndex = 8;
            this.bt_cancelar_1.Text = "Cancelar";
            this.bt_cancelar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar_1.UseVisualStyleBackColor = false;
            this.bt_cancelar_1.Click += new System.EventHandler(this.button5_Click);
            // 
            // cx_cpf_cnpj
            // 
            this.cx_cpf_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cpf_cnpj.Location = new System.Drawing.Point(253, 70);
            this.cx_cpf_cnpj.Name = "cx_cpf_cnpj";
            this.cx_cpf_cnpj.Size = new System.Drawing.Size(166, 22);
            this.cx_cpf_cnpj.TabIndex = 1;
            // 
            // cx_rg_re
            // 
            this.cx_rg_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_rg_re.Location = new System.Drawing.Point(67, 70);
            this.cx_rg_re.Name = "cx_rg_re";
            this.cx_rg_re.Size = new System.Drawing.Size(106, 22);
            this.cx_rg_re.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(174, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "CPF / CNPJ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "RG / RE:";
            // 
            // cx_base
            // 
            this.cx_base.BackColor = System.Drawing.SystemColors.Info;
            this.cx_base.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_base.Location = new System.Drawing.Point(58, 15);
            this.cx_base.Name = "cx_base";
            this.cx_base.ReadOnly = true;
            this.cx_base.Size = new System.Drawing.Size(361, 22);
            this.cx_base.TabIndex = 6;
            this.cx_base.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx_nomeCliente
            // 
            this.cx_nomeCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_nomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_nomeCliente.Location = new System.Drawing.Point(158, 43);
            this.cx_nomeCliente.Name = "cx_nomeCliente";
            this.cx_nomeCliente.Size = new System.Drawing.Size(261, 22);
            this.cx_nomeCliente.TabIndex = 5;
            this.cx_nomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_nomeCliente.Validated += new System.EventHandler(this.cx_nomeCliente_Validated);
            // 
            // cx_codCliente
            // 
            this.cx_codCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_codCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_codCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_codCliente.ForeColor = System.Drawing.Color.Red;
            this.cx_codCliente.Location = new System.Drawing.Point(58, 43);
            this.cx_codCliente.MaxLength = 9;
            this.cx_codCliente.Name = "cx_codCliente";
            this.cx_codCliente.ReadOnly = true;
            this.cx_codCliente.Size = new System.Drawing.Size(59, 22);
            this.cx_codCliente.TabIndex = 4;
            this.cx_codCliente.Text = "99999";
            this.cx_codCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_codCliente.Validated += new System.EventHandler(this.cx_codCliente_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(115, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // grp_telefone
            // 
            this.grp_telefone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grp_telefone.Controls.Add(this.bt_exluir_numero);
            this.grp_telefone.Controls.Add(this.bt_incluir_numero);
            this.grp_telefone.Controls.Add(this.dg_mostra_telefone);
            this.grp_telefone.Enabled = false;
            this.grp_telefone.Location = new System.Drawing.Point(4, 163);
            this.grp_telefone.Name = "grp_telefone";
            this.grp_telefone.Size = new System.Drawing.Size(430, 98);
            this.grp_telefone.TabIndex = 23;
            this.grp_telefone.TabStop = false;
            this.grp_telefone.Text = "Telefone";
            // 
            // bt_exluir_numero
            // 
            this.bt_exluir_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_exluir_numero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exluir_numero.Enabled = false;
            this.bt_exluir_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exluir_numero.Image = global::NDM_SoftwareV5.Properties.Resources.excluir;
            this.bt_exluir_numero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exluir_numero.Location = new System.Drawing.Point(323, 52);
            this.bt_exluir_numero.Name = "bt_exluir_numero";
            this.bt_exluir_numero.Size = new System.Drawing.Size(96, 38);
            this.bt_exluir_numero.TabIndex = 25;
            this.bt_exluir_numero.Text = "Excluir";
            this.bt_exluir_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_exluir_numero.UseVisualStyleBackColor = false;
            this.bt_exluir_numero.Click += new System.EventHandler(this.bt_exluir_numero_Click);
            // 
            // bt_incluir_numero
            // 
            this.bt_incluir_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_incluir_numero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_incluir_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_incluir_numero.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.bt_incluir_numero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_incluir_numero.Location = new System.Drawing.Point(323, 12);
            this.bt_incluir_numero.Name = "bt_incluir_numero";
            this.bt_incluir_numero.Size = new System.Drawing.Size(96, 38);
            this.bt_incluir_numero.TabIndex = 24;
            this.bt_incluir_numero.Text = "Incluir";
            this.bt_incluir_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_incluir_numero.UseVisualStyleBackColor = false;
            this.bt_incluir_numero.Click += new System.EventHandler(this.bt_incluir_numero_Click);
            // 
            // dg_mostra_telefone
            // 
            this.dg_mostra_telefone.AllowUserToAddRows = false;
            this.dg_mostra_telefone.AllowUserToDeleteRows = false;
            this.dg_mostra_telefone.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_mostra_telefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_telefone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dg_mostra_telefone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_telefone.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_mostra_telefone.Location = new System.Drawing.Point(7, 12);
            this.dg_mostra_telefone.MultiSelect = false;
            this.dg_mostra_telefone.Name = "dg_mostra_telefone";
            this.dg_mostra_telefone.ReadOnly = true;
            this.dg_mostra_telefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_telefone.Size = new System.Drawing.Size(315, 82);
            this.dg_mostra_telefone.TabIndex = 0;
            this.dg_mostra_telefone.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_mostra_telefone_CellMouseClick);
            // 
            // grp_endereco_ver
            // 
            this.grp_endereco_ver.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grp_endereco_ver.Controls.Add(this.label15);
            this.grp_endereco_ver.Controls.Add(this.cx_numero_casa);
            this.grp_endereco_ver.Controls.Add(this.cx_cep);
            this.grp_endereco_ver.Controls.Add(this.bt_atualizar_1);
            this.grp_endereco_ver.Controls.Add(this.label10);
            this.grp_endereco_ver.Controls.Add(this.bt_cancelar);
            this.grp_endereco_ver.Controls.Add(this.cx_rua);
            this.grp_endereco_ver.Controls.Add(this.label9);
            this.grp_endereco_ver.Controls.Add(this.cx_bairro);
            this.grp_endereco_ver.Controls.Add(this.label8);
            this.grp_endereco_ver.Controls.Add(this.cx_cidade);
            this.grp_endereco_ver.Controls.Add(this.label7);
            this.grp_endereco_ver.Location = new System.Drawing.Point(4, 266);
            this.grp_endereco_ver.Name = "grp_endereco_ver";
            this.grp_endereco_ver.Size = new System.Drawing.Size(430, 134);
            this.grp_endereco_ver.TabIndex = 21;
            this.grp_endereco_ver.TabStop = false;
            this.grp_endereco_ver.Text = "Endereço";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(302, 72);
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
            this.cx_numero_casa.Location = new System.Drawing.Point(326, 69);
            this.cx_numero_casa.MaxLength = 250;
            this.cx_numero_casa.Name = "cx_numero_casa";
            this.cx_numero_casa.ReadOnly = true;
            this.cx_numero_casa.Size = new System.Drawing.Size(93, 22);
            this.cx_numero_casa.TabIndex = 29;
            this.cx_numero_casa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx_cep
            // 
            this.cx_cep.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cep.Location = new System.Drawing.Point(326, 41);
            this.cx_cep.Mask = "00000-000";
            this.cx_cep.Name = "cx_cep";
            this.cx_cep.ReadOnly = true;
            this.cx_cep.Size = new System.Drawing.Size(93, 22);
            this.cx_cep.TabIndex = 4;
            // 
            // bt_atualizar_1
            // 
            this.bt_atualizar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_atualizar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_atualizar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar_1.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_atualizar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar_1.Location = new System.Drawing.Point(226, 92);
            this.bt_atualizar_1.Name = "bt_atualizar_1";
            this.bt_atualizar_1.Size = new System.Drawing.Size(96, 38);
            this.bt_atualizar_1.TabIndex = 15;
            this.bt_atualizar_1.Text = "Atualizar";
            this.bt_atualizar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_atualizar_1.UseVisualStyleBackColor = false;
            this.bt_atualizar_1.Click += new System.EventHandler(this.bt_atualizar_1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(290, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "CEP:";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(323, 92);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(96, 38);
            this.bt_cancelar.TabIndex = 16;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // cx_rua
            // 
            this.cx_rua.BackColor = System.Drawing.SystemColors.Info;
            this.cx_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_rua.Location = new System.Drawing.Point(63, 69);
            this.cx_rua.MaxLength = 250;
            this.cx_rua.Name = "cx_rua";
            this.cx_rua.ReadOnly = true;
            this.cx_rua.Size = new System.Drawing.Size(237, 22);
            this.cx_rua.TabIndex = 5;
            this.cx_rua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(28, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Rua:";
            // 
            // cx_bairro
            // 
            this.cx_bairro.BackColor = System.Drawing.SystemColors.Info;
            this.cx_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_bairro.Location = new System.Drawing.Point(63, 41);
            this.cx_bairro.MaxLength = 250;
            this.cx_bairro.Name = "cx_bairro";
            this.cx_bairro.ReadOnly = true;
            this.cx_bairro.Size = new System.Drawing.Size(221, 22);
            this.cx_bairro.TabIndex = 3;
            this.cx_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(17, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bairro:";
            // 
            // cx_cidade
            // 
            this.cx_cidade.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cidade.Location = new System.Drawing.Point(63, 13);
            this.cx_cidade.MaxLength = 250;
            this.cx_cidade.Name = "cx_cidade";
            this.cx_cidade.ReadOnly = true;
            this.cx_cidade.Size = new System.Drawing.Size(356, 22);
            this.cx_cidade.TabIndex = 2;
            this.cx_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cidade:";
            // 
            // grp_add_endereco
            // 
            this.grp_add_endereco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grp_add_endereco.Controls.Add(this.cb_rua_cep);
            this.grp_add_endereco.Controls.Add(this.cb_rua_descricao);
            this.grp_add_endereco.Controls.Add(this.cx_numero_casa_2);
            this.grp_add_endereco.Controls.Add(this.cb_bairro_descricao);
            this.grp_add_endereco.Controls.Add(this.cb_cidade_descricao);
            this.grp_add_endereco.Controls.Add(this.bt_gravar_2);
            this.grp_add_endereco.Controls.Add(this.label11);
            this.grp_add_endereco.Controls.Add(this.bt_cancelar_2);
            this.grp_add_endereco.Controls.Add(this.label12);
            this.grp_add_endereco.Controls.Add(this.label13);
            this.grp_add_endereco.Controls.Add(this.label14);
            this.grp_add_endereco.Controls.Add(this.label16);
            this.grp_add_endereco.Enabled = false;
            this.grp_add_endereco.Location = new System.Drawing.Point(4, 406);
            this.grp_add_endereco.Name = "grp_add_endereco";
            this.grp_add_endereco.Size = new System.Drawing.Size(430, 130);
            this.grp_add_endereco.TabIndex = 29;
            this.grp_add_endereco.TabStop = false;
            this.grp_add_endereco.Text = "Endereço";
            // 
            // cb_rua_cep
            // 
            this.cb_rua_cep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rua_cep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_rua_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_rua_cep.FormattingEnabled = true;
            this.cb_rua_cep.Location = new System.Drawing.Point(310, 41);
            this.cb_rua_cep.Name = "cb_rua_cep";
            this.cb_rua_cep.Size = new System.Drawing.Size(109, 24);
            this.cb_rua_cep.TabIndex = 33;
            // 
            // cb_rua_descricao
            // 
            this.cb_rua_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rua_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_rua_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_rua_descricao.FormattingEnabled = true;
            this.cb_rua_descricao.Location = new System.Drawing.Point(58, 67);
            this.cb_rua_descricao.Name = "cb_rua_descricao";
            this.cb_rua_descricao.Size = new System.Drawing.Size(260, 24);
            this.cb_rua_descricao.TabIndex = 31;
            // 
            // cx_numero_casa_2
            // 
            this.cx_numero_casa_2.BackColor = System.Drawing.SystemColors.Info;
            this.cx_numero_casa_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_numero_casa_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_numero_casa_2.Location = new System.Drawing.Point(345, 68);
            this.cx_numero_casa_2.MaxLength = 250;
            this.cx_numero_casa_2.Name = "cx_numero_casa_2";
            this.cx_numero_casa_2.Size = new System.Drawing.Size(74, 22);
            this.cx_numero_casa_2.TabIndex = 31;
            this.cx_numero_casa_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_bairro_descricao
            // 
            this.cb_bairro_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bairro_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_bairro_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_bairro_descricao.FormattingEnabled = true;
            this.cb_bairro_descricao.Location = new System.Drawing.Point(58, 41);
            this.cb_bairro_descricao.Name = "cb_bairro_descricao";
            this.cb_bairro_descricao.Size = new System.Drawing.Size(217, 24);
            this.cb_bairro_descricao.TabIndex = 30;
            // 
            // cb_cidade_descricao
            // 
            this.cb_cidade_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cidade_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cidade_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_cidade_descricao.FormattingEnabled = true;
            this.cb_cidade_descricao.Location = new System.Drawing.Point(58, 13);
            this.cb_cidade_descricao.Name = "cb_cidade_descricao";
            this.cb_cidade_descricao.Size = new System.Drawing.Size(361, 24);
            this.cb_cidade_descricao.TabIndex = 29;
            // 
            // bt_gravar_2
            // 
            this.bt_gravar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_gravar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gravar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar_2.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_gravar_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_2.Location = new System.Drawing.Point(226, 92);
            this.bt_gravar_2.Name = "bt_gravar_2";
            this.bt_gravar_2.Size = new System.Drawing.Size(96, 38);
            this.bt_gravar_2.TabIndex = 22;
            this.bt_gravar_2.Text = "Gravar";
            this.bt_gravar_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_2.UseVisualStyleBackColor = false;
            this.bt_gravar_2.Click += new System.EventHandler(this.bt_gravar_2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(274, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "CEP:";
            // 
            // bt_cancelar_2
            // 
            this.bt_cancelar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar_2.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar_2.Location = new System.Drawing.Point(323, 92);
            this.bt_cancelar_2.Name = "bt_cancelar_2";
            this.bt_cancelar_2.Size = new System.Drawing.Size(96, 38);
            this.bt_cancelar_2.TabIndex = 16;
            this.bt_cancelar_2.Text = "Cancelar";
            this.bt_cancelar_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar_2.UseVisualStyleBackColor = false;
            this.bt_cancelar_2.Click += new System.EventHandler(this.bt_cancelar_2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(24, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Rua:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(13, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(5, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Cidade:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(324, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Nº:";
            // 
            // cb_cidade_ID
            // 
            this.cb_cidade_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_cidade_ID.FormattingEnabled = true;
            this.cb_cidade_ID.Location = new System.Drawing.Point(19, 542);
            this.cb_cidade_ID.Name = "cb_cidade_ID";
            this.cb_cidade_ID.Size = new System.Drawing.Size(52, 24);
            this.cb_cidade_ID.TabIndex = 30;
            this.cb_cidade_ID.SelectedIndexChanged += new System.EventHandler(this.cb_cidade_ID_SelectedIndexChanged);
            // 
            // cb_bairro_ID
            // 
            this.cb_bairro_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_bairro_ID.FormattingEnabled = true;
            this.cb_bairro_ID.Location = new System.Drawing.Point(77, 542);
            this.cb_bairro_ID.Name = "cb_bairro_ID";
            this.cb_bairro_ID.Size = new System.Drawing.Size(52, 24);
            this.cb_bairro_ID.TabIndex = 31;
            this.cb_bairro_ID.SelectedIndexChanged += new System.EventHandler(this.cb_bairro_ID_SelectedIndexChanged);
            // 
            // cb_rua_ID
            // 
            this.cb_rua_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_rua_ID.FormattingEnabled = true;
            this.cb_rua_ID.Location = new System.Drawing.Point(135, 542);
            this.cb_rua_ID.Name = "cb_rua_ID";
            this.cb_rua_ID.Size = new System.Drawing.Size(52, 24);
            this.cb_rua_ID.TabIndex = 32;
            this.cb_rua_ID.SelectedIndexChanged += new System.EventHandler(this.cb_rua_ID_SelectedIndexChanged);
            // 
            // frm_add_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 404);
            this.Controls.Add(this.cb_rua_ID);
            this.Controls.Add(this.cb_bairro_ID);
            this.Controls.Add(this.cb_cidade_ID);
            this.Controls.Add(this.grp_add_endereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_endereco_ver);
            this.Controls.Add(this.grp_telefone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - {HelpDesk - Inclusão / Alteração Cliente } ::...";
            this.Load += new System.EventHandler(this.frm_add_cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_telefone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_telefone)).EndInit();
            this.grp_endereco_ver.ResumeLayout(false);
            this.grp_endereco_ver.PerformLayout();
            this.grp_add_endereco.ResumeLayout(false);
            this.grp_add_endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_atualizar_1;
        private System.Windows.Forms.TextBox cx_base;
        private System.Windows.Forms.TextBox cx_nomeCliente;
        private System.Windows.Forms.TextBox cx_codCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_telefone;
        private System.Windows.Forms.Button bt_exluir_numero;
        private System.Windows.Forms.Button bt_incluir_numero;
        private System.Windows.Forms.DataGridView dg_mostra_telefone;
        private System.Windows.Forms.GroupBox grp_endereco_ver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cx_rua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cx_bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cx_cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_gravar_1;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_cancelar_1;
        private System.Windows.Forms.MaskedTextBox cx_cpf_cnpj;
        private System.Windows.Forms.MaskedTextBox cx_rg_re;
        private System.Windows.Forms.MaskedTextBox cx_cep;
        private System.Windows.Forms.GroupBox grp_add_endereco;
        private System.Windows.Forms.Button bt_gravar_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_cancelar_2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cx_numero_casa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_rua_descricao;
        private System.Windows.Forms.TextBox cx_numero_casa_2;
        private System.Windows.Forms.ComboBox cb_bairro_descricao;
        private System.Windows.Forms.ComboBox cb_cidade_descricao;
        private System.Windows.Forms.ComboBox cb_cidade_ID;
        private System.Windows.Forms.ComboBox cb_bairro_ID;
        private System.Windows.Forms.ComboBox cb_rua_ID;
        private System.Windows.Forms.ComboBox cb_rua_cep;
    }
}