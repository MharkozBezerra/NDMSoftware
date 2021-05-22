namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    partial class frm_add_Atendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_Atendimento));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_proximo = new System.Windows.Forms.Label();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.img_clientes = new System.Windows.Forms.PictureBox();
            this.img_passar_atendimento = new System.Windows.Forms.PictureBox();
            this.cx_nome_tecnico = new System.Windows.Forms.TextBox();
            this.bt_buscar_tec = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cx_solicitado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cx_obs = new System.Windows.Forms.TextBox();
            this.cb_subcategoria_descricao = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cx_codOS = new System.Windows.Forms.TextBox();
            this.chk_OS = new System.Windows.Forms.CheckBox();
            this.cb_categoria_descricao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cx_nomeCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cx_codCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_provedor = new System.Windows.Forms.ComboBox();
            this.lbl_provedor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cx_dataHora = new System.Windows.Forms.MaskedTextBox();
            this.chk_acompanhar = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_passar_atendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lbl_proximo);
            this.groupBox2.Controls.Add(this.lbl_clientes);
            this.groupBox2.Controls.Add(this.img_clientes);
            this.groupBox2.Controls.Add(this.img_passar_atendimento);
            this.groupBox2.Controls.Add(this.cx_nome_tecnico);
            this.groupBox2.Controls.Add(this.bt_buscar_tec);
            this.groupBox2.Controls.Add(this.bt_cancelar);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.bt_gravar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cx_solicitado);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cx_obs);
            this.groupBox2.Controls.Add(this.cb_subcategoria_descricao);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cx_codOS);
            this.groupBox2.Controls.Add(this.chk_OS);
            this.groupBox2.Controls.Add(this.cb_categoria_descricao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cx_nomeCliente);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cx_codCliente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cb_provedor);
            this.groupBox2.Controls.Add(this.lbl_provedor);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cx_dataHora);
            this.groupBox2.Controls.Add(this.chk_acompanhar);
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 485);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Atendimento";
            // 
            // lbl_proximo
            // 
            this.lbl_proximo.AutoSize = true;
            this.lbl_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_proximo.ForeColor = System.Drawing.Color.Red;
            this.lbl_proximo.Location = new System.Drawing.Point(12, 433);
            this.lbl_proximo.Name = "lbl_proximo";
            this.lbl_proximo.Size = new System.Drawing.Size(71, 13);
            this.lbl_proximo.TabIndex = 32;
            this.lbl_proximo.Text = "Próximo turno";
            this.lbl_proximo.Visible = false;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_clientes.ForeColor = System.Drawing.Color.Red;
            this.lbl_clientes.Location = new System.Drawing.Point(90, 433);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(85, 13);
            this.lbl_clientes.TabIndex = 27;
            this.lbl_clientes.Text = "Não é o cliente?";
            this.lbl_clientes.Visible = false;
            // 
            // img_clientes
            // 
            this.img_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_clientes.Image = global::NDM_SoftwareV5.Properties.Resources.Cliente_Cor;
            this.img_clientes.Location = new System.Drawing.Point(107, 450);
            this.img_clientes.Name = "img_clientes";
            this.img_clientes.Size = new System.Drawing.Size(51, 30);
            this.img_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_clientes.TabIndex = 26;
            this.img_clientes.TabStop = false;
            this.img_clientes.Visible = false;
            this.img_clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_clientes_MouseClick);
            // 
            // img_passar_atendimento
            // 
            this.img_passar_atendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_passar_atendimento.Image = global::NDM_SoftwareV5.Properties.Resources.Passar_Atendimento_Cor;
            this.img_passar_atendimento.Location = new System.Drawing.Point(22, 450);
            this.img_passar_atendimento.Name = "img_passar_atendimento";
            this.img_passar_atendimento.Size = new System.Drawing.Size(51, 30);
            this.img_passar_atendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_passar_atendimento.TabIndex = 31;
            this.img_passar_atendimento.TabStop = false;
            this.img_passar_atendimento.Visible = false;
            this.img_passar_atendimento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_passar_atendimento_MouseClick);
            // 
            // cx_nome_tecnico
            // 
            this.cx_nome_tecnico.BackColor = System.Drawing.SystemColors.Info;
            this.cx_nome_tecnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_nome_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_nome_tecnico.Location = new System.Drawing.Point(10, 205);
            this.cx_nome_tecnico.MaxLength = 80;
            this.cx_nome_tecnico.Name = "cx_nome_tecnico";
            this.cx_nome_tecnico.ReadOnly = true;
            this.cx_nome_tecnico.Size = new System.Drawing.Size(170, 21);
            this.cx_nome_tecnico.TabIndex = 6;
            this.cx_nome_tecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_buscar_tec
            // 
            this.bt_buscar_tec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_buscar_tec.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_buscar_tec.Location = new System.Drawing.Point(186, 199);
            this.bt_buscar_tec.Name = "bt_buscar_tec";
            this.bt_buscar_tec.Size = new System.Drawing.Size(32, 33);
            this.bt_buscar_tec.TabIndex = 7;
            this.bt_buscar_tec.UseVisualStyleBackColor = true;
            this.bt_buscar_tec.Visible = false;
            this.bt_buscar_tec.Click += new System.EventHandler(this.bt_buscar_tec_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(287, 439);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(94, 40);
            this.bt_cancelar.TabIndex = 14;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label54.Location = new System.Drawing.Point(9, 185);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(57, 16);
            this.label54.TabIndex = 25;
            this.label54.Text = "Técnico";
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_gravar.Enabled = false;
            this.bt_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar.Location = new System.Drawing.Point(191, 440);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(94, 40);
            this.bt_gravar.TabIndex = 13;
            this.bt_gravar.Text = "Gravar ";
            this.bt_gravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Observações ";
            // 
            // cx_solicitado
            // 
            this.cx_solicitado.BackColor = System.Drawing.SystemColors.Info;
            this.cx_solicitado.Enabled = false;
            this.cx_solicitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_solicitado.Location = new System.Drawing.Point(10, 73);
            this.cx_solicitado.MaxLength = 20;
            this.cx_solicitado.Name = "cx_solicitado";
            this.cx_solicitado.ReadOnly = true;
            this.cx_solicitado.Size = new System.Drawing.Size(371, 21);
            this.cx_solicitado.TabIndex = 2;
            this.cx_solicitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(9, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Solicitado";
            // 
            // cx_obs
            // 
            this.cx_obs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cx_obs.BackColor = System.Drawing.SystemColors.Info;
            this.cx_obs.Enabled = false;
            this.cx_obs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cx_obs.Location = new System.Drawing.Point(10, 294);
            this.cx_obs.MaxLength = 2000;
            this.cx_obs.Multiline = true;
            this.cx_obs.Name = "cx_obs";
            this.cx_obs.Size = new System.Drawing.Size(371, 136);
            this.cx_obs.TabIndex = 12;
            // 
            // cb_subcategoria_descricao
            // 
            this.cb_subcategoria_descricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_subcategoria_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subcategoria_descricao.Enabled = false;
            this.cb_subcategoria_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_subcategoria_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_subcategoria_descricao.FormattingEnabled = true;
            this.cb_subcategoria_descricao.Location = new System.Drawing.Point(10, 248);
            this.cb_subcategoria_descricao.Name = "cb_subcategoria_descricao";
            this.cb_subcategoria_descricao.Size = new System.Drawing.Size(371, 23);
            this.cb_subcategoria_descricao.TabIndex = 11;
            this.cb_subcategoria_descricao.SelectedIndexChanged += new System.EventHandler(this.cb_subcategoria_descricao_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(9, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Atendimento realizado";
            // 
            // cx_codOS
            // 
            this.cx_codOS.Enabled = false;
            this.cx_codOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_codOS.Location = new System.Drawing.Point(271, 205);
            this.cx_codOS.MaxLength = 7;
            this.cx_codOS.Name = "cx_codOS";
            this.cx_codOS.Size = new System.Drawing.Size(110, 21);
            this.cx_codOS.TabIndex = 10;
            this.cx_codOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_codOS.Leave += new System.EventHandler(this.cx_codOS_Leave);
            // 
            // chk_OS
            // 
            this.chk_OS.AutoSize = true;
            this.chk_OS.Enabled = false;
            this.chk_OS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chk_OS.ForeColor = System.Drawing.Color.Black;
            this.chk_OS.Location = new System.Drawing.Point(222, 205);
            this.chk_OS.Name = "chk_OS";
            this.chk_OS.Size = new System.Drawing.Size(55, 20);
            this.chk_OS.TabIndex = 9;
            this.chk_OS.Text = "O.S :";
            this.chk_OS.UseVisualStyleBackColor = true;
            this.chk_OS.CheckedChanged += new System.EventHandler(this.chk_OS_CheckedChanged);
            // 
            // cb_categoria_descricao
            // 
            this.cb_categoria_descricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categoria_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria_descricao.Enabled = false;
            this.cb_categoria_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_categoria_descricao.FormattingEnabled = true;
            this.cb_categoria_descricao.Location = new System.Drawing.Point(10, 159);
            this.cb_categoria_descricao.Name = "cb_categoria_descricao";
            this.cb_categoria_descricao.Size = new System.Drawing.Size(371, 23);
            this.cb_categoria_descricao.TabIndex = 5;
            this.cb_categoria_descricao.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_descricao_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(9, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tipo de atendimento";
            // 
            // cx_nomeCliente
            // 
            this.cx_nomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_nomeCliente.Enabled = false;
            this.cx_nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_nomeCliente.Location = new System.Drawing.Point(81, 114);
            this.cx_nomeCliente.MaxLength = 80;
            this.cx_nomeCliente.Name = "cx_nomeCliente";
            this.cx_nomeCliente.Size = new System.Drawing.Size(300, 21);
            this.cx_nomeCliente.TabIndex = 4;
            this.cx_nomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(90, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nome Cliente";
            // 
            // cx_codCliente
            // 
            this.cx_codCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_codCliente.Location = new System.Drawing.Point(10, 114);
            this.cx_codCliente.MaxLength = 7;
            this.cx_codCliente.Name = "cx_codCliente";
            this.cx_codCliente.Size = new System.Drawing.Size(63, 21);
            this.cx_codCliente.TabIndex = 3;
            this.cx_codCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_codCliente.Validated += new System.EventHandler(this.cx_codCliente_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(9, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Código";
            // 
            // cb_provedor
            // 
            this.cb_provedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_provedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_provedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_provedor.FormattingEnabled = true;
            this.cb_provedor.Location = new System.Drawing.Point(134, 34);
            this.cb_provedor.Name = "cb_provedor";
            this.cb_provedor.Size = new System.Drawing.Size(247, 23);
            this.cb_provedor.TabIndex = 1;
            this.cb_provedor.SelectedIndexChanged += new System.EventHandler(this.cb_provedor_SelectedIndexChanged);
            // 
            // lbl_provedor
            // 
            this.lbl_provedor.AutoSize = true;
            this.lbl_provedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_provedor.Location = new System.Drawing.Point(131, 18);
            this.lbl_provedor.Name = "lbl_provedor";
            this.lbl_provedor.Size = new System.Drawing.Size(99, 16);
            this.lbl_provedor.TabIndex = 8;
            this.lbl_provedor.Text = "Base Provedor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Data Atendimento";
            // 
            // cx_dataHora
            // 
            this.cx_dataHora.BackColor = System.Drawing.SystemColors.Info;
            this.cx_dataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_dataHora.Location = new System.Drawing.Point(10, 34);
            this.cx_dataHora.Mask = "00/00/0000";
            this.cx_dataHora.Name = "cx_dataHora";
            this.cx_dataHora.ReadOnly = true;
            this.cx_dataHora.Size = new System.Drawing.Size(115, 21);
            this.cx_dataHora.TabIndex = 0;
            this.cx_dataHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_dataHora.ValidatingType = typeof(System.DateTime);
            // 
            // chk_acompanhar
            // 
            this.chk_acompanhar.AutoSize = true;
            this.chk_acompanhar.Enabled = false;
            this.chk_acompanhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chk_acompanhar.ForeColor = System.Drawing.Color.Black;
            this.chk_acompanhar.Location = new System.Drawing.Point(222, 185);
            this.chk_acompanhar.Name = "chk_acompanhar";
            this.chk_acompanhar.Size = new System.Drawing.Size(104, 20);
            this.chk_acompanhar.TabIndex = 8;
            this.chk_acompanhar.Text = "Acompanhar";
            this.chk_acompanhar.UseVisualStyleBackColor = true;
            // 
            // frm_add_Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 488);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_Atendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - {HelpDesk - Incluir Atendimento } ::...";
            this.Load += new System.EventHandler(this.frm_add_Atendimento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_passar_atendimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cx_nome_tecnico;
        private System.Windows.Forms.Button bt_buscar_tec;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cx_solicitado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cx_obs;
        private System.Windows.Forms.ComboBox cb_subcategoria_descricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cx_codOS;
        private System.Windows.Forms.CheckBox chk_OS;
        private System.Windows.Forms.ComboBox cb_categoria_descricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cx_nomeCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cx_codCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_provedor;
        private System.Windows.Forms.Label lbl_provedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox cx_dataHora;
        private System.Windows.Forms.CheckBox chk_acompanhar;
        private System.Windows.Forms.PictureBox img_clientes;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.Label lbl_proximo;
        private System.Windows.Forms.PictureBox img_passar_atendimento;
    }
}