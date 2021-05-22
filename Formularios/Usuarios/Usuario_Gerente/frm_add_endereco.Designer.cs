namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente
{
    partial class frm_add_endereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_endereco));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_provedor = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cb_cidade_alterar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_pesquisar_endereco = new System.Windows.Forms.ComboBox();
            this.grp_endereco_ver = new System.Windows.Forms.GroupBox();
            this.cx_atualizar_cep = new System.Windows.Forms.MaskedTextBox();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.cx_atualizar_rua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cx_atualizar_bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cx_pesquisar_endereco = new System.Windows.Forms.TextBox();
            this.bt_pesquisar_endereco = new System.Windows.Forms.Button();
            this.dg_atualizar_endereco = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dg_mostra_cidade = new System.Windows.Forms.DataGridView();
            this.cx_pesquisa_bairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_pesquisar_bairro = new System.Windows.Forms.Button();
            this.bt_gravar_bairro = new System.Windows.Forms.Button();
            this.dg_mostra_bairro = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pesquisa_rua = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cx_pesquisa_bairro_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_pesquisar_bairro_2 = new System.Windows.Forms.Button();
            this.dg_mostra_bairro_rua = new System.Windows.Forms.DataGridView();
            this.cx_pesquisa_rua = new System.Windows.Forms.TextBox();
            this.dg_mostra_rua = new System.Windows.Forms.DataGridView();
            this.bt_incluir_rua = new System.Windows.Forms.Button();
            this.bt_pesquisa_rua = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.grp_endereco_ver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atualizar_endereco)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_cidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_bairro)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_bairro_rua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_rua)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cb_provedor);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base";
            // 
            // cb_provedor
            // 
            this.cb_provedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_provedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_provedor.FormattingEnabled = true;
            this.cb_provedor.Location = new System.Drawing.Point(10, 17);
            this.cb_provedor.Name = "cb_provedor";
            this.cb_provedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_provedor.Size = new System.Drawing.Size(729, 24);
            this.cb_provedor.TabIndex = 0;
            this.cb_provedor.SelectedIndexChanged += new System.EventHandler(this.cb_provedor_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Atualizar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl3);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(729, 464);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Location = new System.Drawing.Point(7, 14);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(717, 444);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage5.Controls.Add(this.cb_cidade_alterar);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.cb_pesquisar_endereco);
            this.tabPage5.Controls.Add(this.grp_endereco_ver);
            this.tabPage5.Controls.Add(this.cx_pesquisar_endereco);
            this.tabPage5.Controls.Add(this.bt_pesquisar_endereco);
            this.tabPage5.Controls.Add(this.dg_atualizar_endereco);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(709, 415);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Atualizar Endereço";
            // 
            // cb_cidade_alterar
            // 
            this.cb_cidade_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_cidade_alterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cidade_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cidade_alterar.FormattingEnabled = true;
            this.cb_cidade_alterar.Location = new System.Drawing.Point(262, 6);
            this.cb_cidade_alterar.Name = "cb_cidade_alterar";
            this.cb_cidade_alterar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_cidade_alterar.Size = new System.Drawing.Size(270, 24);
            this.cb_cidade_alterar.TabIndex = 37;
            this.cb_cidade_alterar.SelectedIndexChanged += new System.EventHandler(this.cb_cidade_alterar_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(210, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Cidade:";
            // 
            // cb_pesquisar_endereco
            // 
            this.cb_pesquisar_endereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_pesquisar_endereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pesquisar_endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_pesquisar_endereco.FormattingEnabled = true;
            this.cb_pesquisar_endereco.Items.AddRange(new object[] {
            "BAIRRO",
            "RUA",
            "CEP"});
            this.cb_pesquisar_endereco.Location = new System.Drawing.Point(4, 33);
            this.cb_pesquisar_endereco.Name = "cb_pesquisar_endereco";
            this.cb_pesquisar_endereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_pesquisar_endereco.Size = new System.Drawing.Size(165, 24);
            this.cb_pesquisar_endereco.TabIndex = 1;
            this.cb_pesquisar_endereco.SelectedIndexChanged += new System.EventHandler(this.cb_pesquisar_endereco_SelectedIndexChanged);
            // 
            // grp_endereco_ver
            // 
            this.grp_endereco_ver.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grp_endereco_ver.Controls.Add(this.cx_atualizar_cep);
            this.grp_endereco_ver.Controls.Add(this.bt_atualizar);
            this.grp_endereco_ver.Controls.Add(this.label10);
            this.grp_endereco_ver.Controls.Add(this.bt_cancelar);
            this.grp_endereco_ver.Controls.Add(this.cx_atualizar_rua);
            this.grp_endereco_ver.Controls.Add(this.label7);
            this.grp_endereco_ver.Controls.Add(this.cx_atualizar_bairro);
            this.grp_endereco_ver.Controls.Add(this.label6);
            this.grp_endereco_ver.Location = new System.Drawing.Point(6, 328);
            this.grp_endereco_ver.Name = "grp_endereco_ver";
            this.grp_endereco_ver.Size = new System.Drawing.Size(697, 81);
            this.grp_endereco_ver.TabIndex = 32;
            this.grp_endereco_ver.TabStop = false;
            this.grp_endereco_ver.Text = "Endereço";
            // 
            // cx_atualizar_cep
            // 
            this.cx_atualizar_cep.BackColor = System.Drawing.SystemColors.Info;
            this.cx_atualizar_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_atualizar_cep.Location = new System.Drawing.Point(423, 52);
            this.cx_atualizar_cep.Mask = "00000-000";
            this.cx_atualizar_cep.Name = "cx_atualizar_cep";
            this.cx_atualizar_cep.ReadOnly = true;
            this.cx_atualizar_cep.Size = new System.Drawing.Size(93, 22);
            this.cx_atualizar_cep.TabIndex = 4;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_atualizar.Enabled = false;
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_atualizar.Location = new System.Drawing.Point(522, 40);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(46, 38);
            this.bt_atualizar.TabIndex = 15;
            this.bt_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(387, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "CEP:";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.Enabled = false;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.Location = new System.Drawing.Point(574, 40);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(46, 38);
            this.bt_cancelar.TabIndex = 16;
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // cx_atualizar_rua
            // 
            this.cx_atualizar_rua.BackColor = System.Drawing.SystemColors.Info;
            this.cx_atualizar_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_atualizar_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_atualizar_rua.Location = new System.Drawing.Point(52, 49);
            this.cx_atualizar_rua.MaxLength = 250;
            this.cx_atualizar_rua.Name = "cx_atualizar_rua";
            this.cx_atualizar_rua.ReadOnly = true;
            this.cx_atualizar_rua.Size = new System.Drawing.Size(329, 22);
            this.cx_atualizar_rua.TabIndex = 5;
            this.cx_atualizar_rua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(17, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rua:";
            // 
            // cx_atualizar_bairro
            // 
            this.cx_atualizar_bairro.BackColor = System.Drawing.SystemColors.Info;
            this.cx_atualizar_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_atualizar_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_atualizar_bairro.Location = new System.Drawing.Point(52, 21);
            this.cx_atualizar_bairro.MaxLength = 250;
            this.cx_atualizar_bairro.Name = "cx_atualizar_bairro";
            this.cx_atualizar_bairro.ReadOnly = true;
            this.cx_atualizar_bairro.Size = new System.Drawing.Size(329, 22);
            this.cx_atualizar_bairro.TabIndex = 3;
            this.cx_atualizar_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bairro:";
            // 
            // cx_pesquisar_endereco
            // 
            this.cx_pesquisar_endereco.BackColor = System.Drawing.SystemColors.Info;
            this.cx_pesquisar_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_pesquisar_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_pesquisar_endereco.Location = new System.Drawing.Point(175, 35);
            this.cx_pesquisar_endereco.MaxLength = 250;
            this.cx_pesquisar_endereco.Name = "cx_pesquisar_endereco";
            this.cx_pesquisar_endereco.ReadOnly = true;
            this.cx_pesquisar_endereco.Size = new System.Drawing.Size(484, 22);
            this.cx_pesquisar_endereco.TabIndex = 29;
            this.cx_pesquisar_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_pesquisar_endereco.TextChanged += new System.EventHandler(this.cx_pesquisar_endereco_TextChanged);
            // 
            // bt_pesquisar_endereco
            // 
            this.bt_pesquisar_endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_pesquisar_endereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisar_endereco.Enabled = false;
            this.bt_pesquisar_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar_endereco.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_pesquisar_endereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar_endereco.Location = new System.Drawing.Point(665, 26);
            this.bt_pesquisar_endereco.Name = "bt_pesquisar_endereco";
            this.bt_pesquisar_endereco.Size = new System.Drawing.Size(38, 35);
            this.bt_pesquisar_endereco.TabIndex = 30;
            this.bt_pesquisar_endereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_pesquisar_endereco.UseVisualStyleBackColor = false;
            this.bt_pesquisar_endereco.Click += new System.EventHandler(this.bt_pesquisar_endereco_Click);
            // 
            // dg_atualizar_endereco
            // 
            this.dg_atualizar_endereco.AllowUserToAddRows = false;
            this.dg_atualizar_endereco.AllowUserToDeleteRows = false;
            this.dg_atualizar_endereco.AllowUserToResizeColumns = false;
            this.dg_atualizar_endereco.AllowUserToResizeRows = false;
            this.dg_atualizar_endereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_atualizar_endereco.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_atualizar_endereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_atualizar_endereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dg_atualizar_endereco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_atualizar_endereco.Location = new System.Drawing.Point(6, 63);
            this.dg_atualizar_endereco.MultiSelect = false;
            this.dg_atualizar_endereco.Name = "dg_atualizar_endereco";
            this.dg_atualizar_endereco.ReadOnly = true;
            this.dg_atualizar_endereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_atualizar_endereco.ShowCellErrors = false;
            this.dg_atualizar_endereco.ShowEditingIcon = false;
            this.dg_atualizar_endereco.ShowRowErrors = false;
            this.dg_atualizar_endereco.Size = new System.Drawing.Size(697, 259);
            this.dg_atualizar_endereco.TabIndex = 1;
            this.dg_atualizar_endereco.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_atualizar_endereco_CellMouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 474);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 14);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(717, 454);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.dg_mostra_cidade);
            this.tabPage3.Controls.Add(this.cx_pesquisa_bairro);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.bt_pesquisar_bairro);
            this.tabPage3.Controls.Add(this.bt_gravar_bairro);
            this.tabPage3.Controls.Add(this.dg_mostra_bairro);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(709, 425);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Bairro";
            // 
            // dg_mostra_cidade
            // 
            this.dg_mostra_cidade.AllowDrop = true;
            this.dg_mostra_cidade.AllowUserToAddRows = false;
            this.dg_mostra_cidade.AllowUserToDeleteRows = false;
            this.dg_mostra_cidade.AllowUserToOrderColumns = true;
            this.dg_mostra_cidade.AllowUserToResizeColumns = false;
            this.dg_mostra_cidade.AllowUserToResizeRows = false;
            this.dg_mostra_cidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_cidade.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_mostra_cidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_cidade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_cidade.Location = new System.Drawing.Point(10, 6);
            this.dg_mostra_cidade.MultiSelect = false;
            this.dg_mostra_cidade.Name = "dg_mostra_cidade";
            this.dg_mostra_cidade.ReadOnly = true;
            this.dg_mostra_cidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_cidade.ShowCellErrors = false;
            this.dg_mostra_cidade.ShowEditingIcon = false;
            this.dg_mostra_cidade.ShowRowErrors = false;
            this.dg_mostra_cidade.Size = new System.Drawing.Size(694, 121);
            this.dg_mostra_cidade.TabIndex = 32;
            this.dg_mostra_cidade.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_mostra_cidade_CellMouseClick);
            // 
            // cx_pesquisa_bairro
            // 
            this.cx_pesquisa_bairro.BackColor = System.Drawing.SystemColors.Info;
            this.cx_pesquisa_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_pesquisa_bairro.Enabled = false;
            this.cx_pesquisa_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_pesquisa_bairro.Location = new System.Drawing.Point(60, 139);
            this.cx_pesquisa_bairro.MaxLength = 250;
            this.cx_pesquisa_bairro.Name = "cx_pesquisa_bairro";
            this.cx_pesquisa_bairro.Size = new System.Drawing.Size(300, 22);
            this.cx_pesquisa_bairro.TabIndex = 29;
            this.cx_pesquisa_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_pesquisa_bairro.TextChanged += new System.EventHandler(this.cx_pesquisa_bairro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Bairro:";
            // 
            // bt_pesquisar_bairro
            // 
            this.bt_pesquisar_bairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_pesquisar_bairro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisar_bairro.Enabled = false;
            this.bt_pesquisar_bairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisar_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar_bairro.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_pesquisar_bairro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar_bairro.Location = new System.Drawing.Point(366, 136);
            this.bt_pesquisar_bairro.Name = "bt_pesquisar_bairro";
            this.bt_pesquisar_bairro.Size = new System.Drawing.Size(37, 27);
            this.bt_pesquisar_bairro.TabIndex = 30;
            this.bt_pesquisar_bairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_pesquisar_bairro.UseVisualStyleBackColor = false;
            this.bt_pesquisar_bairro.Click += new System.EventHandler(this.bt_pesquisar_bairro_Click);
            // 
            // bt_gravar_bairro
            // 
            this.bt_gravar_bairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_gravar_bairro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gravar_bairro.Enabled = false;
            this.bt_gravar_bairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gravar_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar_bairro.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.bt_gravar_bairro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_bairro.Location = new System.Drawing.Point(608, 395);
            this.bt_gravar_bairro.Name = "bt_gravar_bairro";
            this.bt_gravar_bairro.Size = new System.Drawing.Size(96, 28);
            this.bt_gravar_bairro.TabIndex = 28;
            this.bt_gravar_bairro.Text = "Incluir";
            this.bt_gravar_bairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_bairro.UseVisualStyleBackColor = false;
            this.bt_gravar_bairro.Click += new System.EventHandler(this.bt_gravar_bairro_Click);
            // 
            // dg_mostra_bairro
            // 
            this.dg_mostra_bairro.AllowDrop = true;
            this.dg_mostra_bairro.AllowUserToOrderColumns = true;
            this.dg_mostra_bairro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_bairro.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_mostra_bairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_bairro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_bairro.Location = new System.Drawing.Point(10, 164);
            this.dg_mostra_bairro.MultiSelect = false;
            this.dg_mostra_bairro.Name = "dg_mostra_bairro";
            this.dg_mostra_bairro.ReadOnly = true;
            this.dg_mostra_bairro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_bairro.ShowCellErrors = false;
            this.dg_mostra_bairro.ShowEditingIcon = false;
            this.dg_mostra_bairro.ShowRowErrors = false;
            this.dg_mostra_bairro.Size = new System.Drawing.Size(694, 229);
            this.dg_mostra_bairro.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.cb_pesquisa_rua);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.cx_pesquisa_rua);
            this.tabPage4.Controls.Add(this.dg_mostra_rua);
            this.tabPage4.Controls.Add(this.bt_incluir_rua);
            this.tabPage4.Controls.Add(this.bt_pesquisa_rua);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(709, 425);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Rua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Procure por:";
            // 
            // cb_pesquisa_rua
            // 
            this.cb_pesquisa_rua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_pesquisa_rua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pesquisa_rua.Enabled = false;
            this.cb_pesquisa_rua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_pesquisa_rua.FormattingEnabled = true;
            this.cb_pesquisa_rua.Items.AddRange(new object[] {
            "RUA",
            "CEP"});
            this.cb_pesquisa_rua.Location = new System.Drawing.Point(95, 181);
            this.cb_pesquisa_rua.Name = "cb_pesquisa_rua";
            this.cb_pesquisa_rua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_pesquisa_rua.Size = new System.Drawing.Size(107, 24);
            this.cb_pesquisa_rua.TabIndex = 37;
            this.cb_pesquisa_rua.SelectedIndexChanged += new System.EventHandler(this.cb_pesquisa_rua_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox6.Controls.Add(this.cb_cidade);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.cx_pesquisa_bairro_2);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.bt_pesquisar_bairro_2);
            this.groupBox6.Controls.Add(this.dg_mostra_bairro_rua);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(696, 163);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bairro";
            // 
            // cb_cidade
            // 
            this.cb_cidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Location = new System.Drawing.Point(58, 15);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_cidade.Size = new System.Drawing.Size(233, 24);
            this.cb_cidade.TabIndex = 35;
            this.cb_cidade.SelectedIndexChanged += new System.EventHandler(this.cb_cidade_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Cidade:";
            // 
            // cx_pesquisa_bairro_2
            // 
            this.cx_pesquisa_bairro_2.BackColor = System.Drawing.SystemColors.Info;
            this.cx_pesquisa_bairro_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_pesquisa_bairro_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_pesquisa_bairro_2.Location = new System.Drawing.Point(341, 16);
            this.cx_pesquisa_bairro_2.MaxLength = 250;
            this.cx_pesquisa_bairro_2.Name = "cx_pesquisa_bairro_2";
            this.cx_pesquisa_bairro_2.Size = new System.Drawing.Size(305, 22);
            this.cx_pesquisa_bairro_2.TabIndex = 32;
            this.cx_pesquisa_bairro_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(297, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Bairro:";
            // 
            // bt_pesquisar_bairro_2
            // 
            this.bt_pesquisar_bairro_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_pesquisar_bairro_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisar_bairro_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar_bairro_2.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_pesquisar_bairro_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar_bairro_2.Location = new System.Drawing.Point(652, 9);
            this.bt_pesquisar_bairro_2.Name = "bt_pesquisar_bairro_2";
            this.bt_pesquisar_bairro_2.Size = new System.Drawing.Size(38, 35);
            this.bt_pesquisar_bairro_2.TabIndex = 33;
            this.bt_pesquisar_bairro_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_pesquisar_bairro_2.UseVisualStyleBackColor = false;
            this.bt_pesquisar_bairro_2.Click += new System.EventHandler(this.bt_pesquisar_bairro_2_Click);
            // 
            // dg_mostra_bairro_rua
            // 
            this.dg_mostra_bairro_rua.AllowUserToAddRows = false;
            this.dg_mostra_bairro_rua.AllowUserToDeleteRows = false;
            this.dg_mostra_bairro_rua.AllowUserToResizeColumns = false;
            this.dg_mostra_bairro_rua.AllowUserToResizeRows = false;
            this.dg_mostra_bairro_rua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_bairro_rua.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_mostra_bairro_rua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_bairro_rua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dg_mostra_bairro_rua.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_bairro_rua.Location = new System.Drawing.Point(7, 42);
            this.dg_mostra_bairro_rua.MultiSelect = false;
            this.dg_mostra_bairro_rua.Name = "dg_mostra_bairro_rua";
            this.dg_mostra_bairro_rua.ReadOnly = true;
            this.dg_mostra_bairro_rua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_bairro_rua.ShowCellErrors = false;
            this.dg_mostra_bairro_rua.ShowEditingIcon = false;
            this.dg_mostra_bairro_rua.ShowRowErrors = false;
            this.dg_mostra_bairro_rua.Size = new System.Drawing.Size(683, 114);
            this.dg_mostra_bairro_rua.TabIndex = 0;
            this.dg_mostra_bairro_rua.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_mostra_bairro_rua_CellMouseClick);
            // 
            // cx_pesquisa_rua
            // 
            this.cx_pesquisa_rua.BackColor = System.Drawing.SystemColors.Info;
            this.cx_pesquisa_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_pesquisa_rua.Enabled = false;
            this.cx_pesquisa_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_pesquisa_rua.Location = new System.Drawing.Point(208, 182);
            this.cx_pesquisa_rua.MaxLength = 250;
            this.cx_pesquisa_rua.Name = "cx_pesquisa_rua";
            this.cx_pesquisa_rua.ReadOnly = true;
            this.cx_pesquisa_rua.Size = new System.Drawing.Size(304, 22);
            this.cx_pesquisa_rua.TabIndex = 36;
            this.cx_pesquisa_rua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_pesquisa_rua.TextChanged += new System.EventHandler(this.cx_pesquisa_rua_TextChanged);
            // 
            // dg_mostra_rua
            // 
            this.dg_mostra_rua.AllowUserToAddRows = false;
            this.dg_mostra_rua.AllowUserToDeleteRows = false;
            this.dg_mostra_rua.AllowUserToResizeColumns = false;
            this.dg_mostra_rua.AllowUserToResizeRows = false;
            this.dg_mostra_rua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_rua.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_mostra_rua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_rua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dg_mostra_rua.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_rua.Location = new System.Drawing.Point(13, 209);
            this.dg_mostra_rua.MultiSelect = false;
            this.dg_mostra_rua.Name = "dg_mostra_rua";
            this.dg_mostra_rua.ReadOnly = true;
            this.dg_mostra_rua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_rua.ShowCellErrors = false;
            this.dg_mostra_rua.ShowEditingIcon = false;
            this.dg_mostra_rua.ShowRowErrors = false;
            this.dg_mostra_rua.Size = new System.Drawing.Size(689, 182);
            this.dg_mostra_rua.TabIndex = 31;
            // 
            // bt_incluir_rua
            // 
            this.bt_incluir_rua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_incluir_rua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_incluir_rua.Enabled = false;
            this.bt_incluir_rua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_incluir_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_incluir_rua.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.bt_incluir_rua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_incluir_rua.Location = new System.Drawing.Point(606, 393);
            this.bt_incluir_rua.Name = "bt_incluir_rua";
            this.bt_incluir_rua.Size = new System.Drawing.Size(96, 28);
            this.bt_incluir_rua.TabIndex = 42;
            this.bt_incluir_rua.Text = "Incluir";
            this.bt_incluir_rua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_incluir_rua.UseVisualStyleBackColor = false;
            this.bt_incluir_rua.Click += new System.EventHandler(this.bt_incluir_rua_Click);
            // 
            // bt_pesquisa_rua
            // 
            this.bt_pesquisa_rua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_pesquisa_rua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisa_rua.Enabled = false;
            this.bt_pesquisa_rua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisa_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisa_rua.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_pesquisa_rua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisa_rua.Location = new System.Drawing.Point(521, 180);
            this.bt_pesquisa_rua.Name = "bt_pesquisa_rua";
            this.bt_pesquisa_rua.Size = new System.Drawing.Size(38, 27);
            this.bt_pesquisa_rua.TabIndex = 37;
            this.bt_pesquisa_rua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_pesquisa_rua.UseVisualStyleBackColor = false;
            this.bt_pesquisa_rua.Click += new System.EventHandler(this.bt_pesquisa_rua_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 515);
            this.tabControl1.TabIndex = 1;
            // 
            // frm_add_endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 570);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_endereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_endereco";
            this.Load += new System.EventHandler(this.frm_add_endereco_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.grp_endereco_ver.ResumeLayout(false);
            this.grp_endereco_ver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atualizar_endereco)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_cidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_bairro)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_bairro_rua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_rua)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_provedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dg_mostra_bairro;
        private System.Windows.Forms.Button bt_pesquisar_bairro;
        private System.Windows.Forms.Button bt_gravar_bairro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox cx_pesquisar_endereco;
        private System.Windows.Forms.Button bt_pesquisar_endereco;
        private System.Windows.Forms.DataGridView dg_atualizar_endereco;
        private System.Windows.Forms.TextBox cx_pesquisa_bairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bt_pesquisa_rua;
        private System.Windows.Forms.TextBox cx_pesquisa_rua;
        private System.Windows.Forms.DataGridView dg_mostra_rua;
        private System.Windows.Forms.GroupBox grp_endereco_ver;
        private System.Windows.Forms.MaskedTextBox cx_atualizar_cep;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox cx_atualizar_rua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cx_atualizar_bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_pesquisar_endereco;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cx_pesquisa_bairro_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_pesquisar_bairro_2;
        private System.Windows.Forms.DataGridView dg_mostra_bairro_rua;
        private System.Windows.Forms.ComboBox cb_cidade_alterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dg_mostra_cidade;
        private System.Windows.Forms.Button bt_incluir_rua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pesquisa_rua;
    }
}