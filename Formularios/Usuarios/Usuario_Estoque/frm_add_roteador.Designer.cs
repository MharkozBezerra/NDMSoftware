namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class frm_add_roteador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_roteador));
            this.gp_alugado = new System.Windows.Forms.GroupBox();
            this.grp_equipamento = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.cx_mac = new System.Windows.Forms.MaskedTextBox();
            this.bt_gravar_devolução = new System.Windows.Forms.Button();
            this.cx_num_serie = new System.Windows.Forms.TextBox();
            this.cx_patrimonio = new System.Windows.Forms.TextBox();
            this.cx_preset = new System.Windows.Forms.TextBox();
            this.dg_mostra_geral = new System.Windows.Forms.DataGridView();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.lbl_modeloDescricao = new System.Windows.Forms.Label();
            this.bt_novo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_pesquisar_1 = new System.Windows.Forms.Button();
            this.cx_pesquisar_1 = new System.Windows.Forms.TextBox();
            this.cb_texto_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_alugado.SuspendLayout();
            this.grp_equipamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_geral)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_alugado
            // 
            this.gp_alugado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_alugado.Controls.Add(this.bt_novo);
            this.gp_alugado.Controls.Add(this.grp_equipamento);
            this.gp_alugado.Controls.Add(this.bt_cancelar);
            this.gp_alugado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_alugado.Location = new System.Drawing.Point(2, 0);
            this.gp_alugado.Name = "gp_alugado";
            this.gp_alugado.Size = new System.Drawing.Size(826, 118);
            this.gp_alugado.TabIndex = 8;
            this.gp_alugado.TabStop = false;
            this.gp_alugado.Text = "Dados Roteador ";
            // 
            // grp_equipamento
            // 
            this.grp_equipamento.Controls.Add(this.lbl_modeloDescricao);
            this.grp_equipamento.Controls.Add(this.bt_atualizar);
            this.grp_equipamento.Controls.Add(this.bt_gravar_devolução);
            this.grp_equipamento.Controls.Add(this.cx_preset);
            this.grp_equipamento.Controls.Add(this.cx_patrimonio);
            this.grp_equipamento.Controls.Add(this.cx_num_serie);
            this.grp_equipamento.Controls.Add(this.cx_mac);
            this.grp_equipamento.Controls.Add(this.cb_modelo);
            this.grp_equipamento.Controls.Add(this.label18);
            this.grp_equipamento.Controls.Add(this.label19);
            this.grp_equipamento.Controls.Add(this.label20);
            this.grp_equipamento.Controls.Add(this.label21);
            this.grp_equipamento.Controls.Add(this.label22);
            this.grp_equipamento.Enabled = false;
            this.grp_equipamento.Location = new System.Drawing.Point(8, 14);
            this.grp_equipamento.Name = "grp_equipamento";
            this.grp_equipamento.Size = new System.Drawing.Size(699, 94);
            this.grp_equipamento.TabIndex = 9;
            this.grp_equipamento.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(310, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Preset:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(285, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "Patrimonio:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "Nº Série:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 16);
            this.label21.TabIndex = 4;
            this.label21.Text = "Modelo:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 16);
            this.label22.TabIndex = 5;
            this.label22.Text = "Mac:";
            // 
            // cb_modelo
            // 
            this.cb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(64, 13);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(213, 24);
            this.cb_modelo.TabIndex = 17;
            this.cb_modelo.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_SelectedIndexChanged);
            // 
            // cx_mac
            // 
            this.cx_mac.Location = new System.Drawing.Point(64, 39);
            this.cx_mac.Mask = "AA:AA:AA:AA:AA:AA";
            this.cx_mac.Name = "cx_mac";
            this.cx_mac.Size = new System.Drawing.Size(111, 22);
            this.cx_mac.TabIndex = 18;
            // 
            // bt_gravar_devolução
            // 
            this.bt_gravar_devolução.BackColor = System.Drawing.SystemColors.Info;
            this.bt_gravar_devolução.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gravar_devolução.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_gravar_devolução.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_devolução.Location = new System.Drawing.Point(580, 13);
            this.bt_gravar_devolução.Name = "bt_gravar_devolução";
            this.bt_gravar_devolução.Size = new System.Drawing.Size(107, 34);
            this.bt_gravar_devolução.TabIndex = 9;
            this.bt_gravar_devolução.Text = "Gravar";
            this.bt_gravar_devolução.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_devolução.UseVisualStyleBackColor = false;
            this.bt_gravar_devolução.Click += new System.EventHandler(this.bt_gravar_devolução_Click);
            // 
            // cx_num_serie
            // 
            this.cx_num_serie.Location = new System.Drawing.Point(64, 64);
            this.cx_num_serie.MaxLength = 50;
            this.cx_num_serie.Name = "cx_num_serie";
            this.cx_num_serie.Size = new System.Drawing.Size(213, 22);
            this.cx_num_serie.TabIndex = 19;
            // 
            // cx_patrimonio
            // 
            this.cx_patrimonio.Location = new System.Drawing.Point(361, 13);
            this.cx_patrimonio.MaxLength = 50;
            this.cx_patrimonio.Name = "cx_patrimonio";
            this.cx_patrimonio.Size = new System.Drawing.Size(194, 22);
            this.cx_patrimonio.TabIndex = 20;
            // 
            // cx_preset
            // 
            this.cx_preset.Location = new System.Drawing.Point(361, 39);
            this.cx_preset.MaxLength = 30;
            this.cx_preset.Name = "cx_preset";
            this.cx_preset.Size = new System.Drawing.Size(194, 22);
            this.cx_preset.TabIndex = 21;
            // 
            // dg_mostra_geral
            // 
            this.dg_mostra_geral.AllowUserToAddRows = false;
            this.dg_mostra_geral.AllowUserToDeleteRows = false;
            this.dg_mostra_geral.AllowUserToResizeColumns = false;
            this.dg_mostra_geral.AllowUserToResizeRows = false;
            this.dg_mostra_geral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_geral.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_mostra_geral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_geral.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_geral.Location = new System.Drawing.Point(1, 159);
            this.dg_mostra_geral.MultiSelect = false;
            this.dg_mostra_geral.Name = "dg_mostra_geral";
            this.dg_mostra_geral.ReadOnly = true;
            this.dg_mostra_geral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_geral.ShowCellErrors = false;
            this.dg_mostra_geral.ShowCellToolTips = false;
            this.dg_mostra_geral.ShowEditingIcon = false;
            this.dg_mostra_geral.ShowRowErrors = false;
            this.dg_mostra_geral.Size = new System.Drawing.Size(826, 305);
            this.dg_mostra_geral.TabIndex = 9;
            this.dg_mostra_geral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_mostra_geral_CellDoubleClick);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(713, 65);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(107, 43);
            this.bt_cancelar.TabIndex = 22;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.BackColor = System.Drawing.SystemColors.Info;
            this.bt_atualizar.Enabled = false;
            this.bt_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_atualizar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(580, 50);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(107, 34);
            this.bt_atualizar.TabIndex = 23;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // lbl_modeloDescricao
            // 
            this.lbl_modeloDescricao.AutoSize = true;
            this.lbl_modeloDescricao.Location = new System.Drawing.Point(358, 67);
            this.lbl_modeloDescricao.Name = "lbl_modeloDescricao";
            this.lbl_modeloDescricao.Size = new System.Drawing.Size(119, 16);
            this.lbl_modeloDescricao.TabIndex = 24;
            this.lbl_modeloDescricao.Text = "Modelo Descrição";
            this.lbl_modeloDescricao.Visible = false;
            // 
            // bt_novo
            // 
            this.bt_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.bt_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_novo.Location = new System.Drawing.Point(713, 21);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(107, 43);
            this.bt_novo.TabIndex = 25;
            this.bt_novo.Text = "Novo";
            this.bt_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_novo.UseVisualStyleBackColor = false;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.bt_pesquisar_1);
            this.groupBox1.Controls.Add(this.cx_pesquisar_1);
            this.groupBox1.Controls.Add(this.cb_texto_1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(1, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // bt_pesquisar_1
            // 
            this.bt_pesquisar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_pesquisar_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisar_1.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_pesquisar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar_1.Location = new System.Drawing.Point(714, 17);
            this.bt_pesquisar_1.Name = "bt_pesquisar_1";
            this.bt_pesquisar_1.Size = new System.Drawing.Size(107, 25);
            this.bt_pesquisar_1.TabIndex = 10;
            this.bt_pesquisar_1.Text = "Procurar..";
            this.bt_pesquisar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_pesquisar_1.UseVisualStyleBackColor = false;
            this.bt_pesquisar_1.Click += new System.EventHandler(this.bt_pesquisar_1_Click);
            // 
            // cx_pesquisar_1
            // 
            this.cx_pesquisar_1.Location = new System.Drawing.Point(241, 17);
            this.cx_pesquisar_1.MaxLength = 50;
            this.cx_pesquisar_1.Name = "cx_pesquisar_1";
            this.cx_pesquisar_1.ReadOnly = true;
            this.cx_pesquisar_1.Size = new System.Drawing.Size(467, 22);
            this.cx_pesquisar_1.TabIndex = 9;
            this.cx_pesquisar_1.TextChanged += new System.EventHandler(this.cx_pesquisar_1_TextChanged);
            // 
            // cb_texto_1
            // 
            this.cb_texto_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_texto_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_texto_1.FormattingEnabled = true;
            this.cb_texto_1.Items.AddRange(new object[] {
            "",
            "MODELO",
            "Nº SERIE",
            "PATRIMONIO",
            "MAC "});
            this.cb_texto_1.Location = new System.Drawing.Point(73, 15);
            this.cb_texto_1.Name = "cb_texto_1";
            this.cb_texto_1.Size = new System.Drawing.Size(162, 24);
            this.cb_texto_1.TabIndex = 8;
            this.cb_texto_1.SelectedIndexChanged += new System.EventHandler(this.cb_texto_1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // frm_add_roteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 466);
            this.Controls.Add(this.gp_alugado);
            this.Controls.Add(this.dg_mostra_geral);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_roteador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Estoque -> Roteadores  -> Adicionar} ::...";
            this.Load += new System.EventHandler(this.frm_add_roteador_Load);
            this.gp_alugado.ResumeLayout(false);
            this.grp_equipamento.ResumeLayout(false);
            this.grp_equipamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_geral)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_alugado;
        private System.Windows.Forms.Button bt_gravar_devolução;
        private System.Windows.Forms.GroupBox grp_equipamento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox cx_mac;
        private System.Windows.Forms.ComboBox cb_modelo;
        private System.Windows.Forms.TextBox cx_preset;
        private System.Windows.Forms.TextBox cx_patrimonio;
        private System.Windows.Forms.TextBox cx_num_serie;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.DataGridView dg_mostra_geral;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Label lbl_modeloDescricao;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_pesquisar_1;
        private System.Windows.Forms.TextBox cx_pesquisar_1;
        private System.Windows.Forms.ComboBox cb_texto_1;
        private System.Windows.Forms.Label label1;
    }
}