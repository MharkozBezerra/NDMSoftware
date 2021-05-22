namespace NDM_SoftwareV5.Formularios.Relatorios.Estoque
{
    partial class frm_reltatorio_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reltatorio_estoque));
            this.gp_relatorio = new System.Windows.Forms.GroupBox();
            this.rpt_local = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_fornecedor = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_usuario = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rb_roteador_disponivel = new System.Windows.Forms.RadioButton();
            this.gp_data = new System.Windows.Forms.GroupBox();
            this.bt_data = new System.Windows.Forms.Button();
            this.cx_data_2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cx_data_1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gp_mensal = new System.Windows.Forms.GroupBox();
            this.bt_mensal = new System.Windows.Forms.Button();
            this.cx_ano = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_mes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_data = new System.Windows.Forms.RadioButton();
            this.rb_mensal = new System.Windows.Forms.RadioButton();
            this.cb_provedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_usuario = new System.Windows.Forms.GroupBox();
            this.cb_usuario_retirada = new System.Windows.Forms.ComboBox();
            this.gp_fornecedor = new System.Windows.Forms.GroupBox();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.bt_buscar_roteador = new System.Windows.Forms.Button();
            this.gp_roteador = new System.Windows.Forms.GroupBox();
            this.gp_relatorio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gp_data.SuspendLayout();
            this.gp_mensal.SuspendLayout();
            this.gp_usuario.SuspendLayout();
            this.gp_fornecedor.SuspendLayout();
            this.gp_roteador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_relatorio
            // 
            this.gp_relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gp_relatorio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_relatorio.Controls.Add(this.rpt_local);
            this.gp_relatorio.Location = new System.Drawing.Point(4, 95);
            this.gp_relatorio.Name = "gp_relatorio";
            this.gp_relatorio.Size = new System.Drawing.Size(781, 456);
            this.gp_relatorio.TabIndex = 1;
            this.gp_relatorio.TabStop = false;
            // 
            // rpt_local
            // 
            this.rpt_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_local.Location = new System.Drawing.Point(3, 16);
            this.rpt_local.Name = "rpt_local";
            this.rpt_local.Size = new System.Drawing.Size(775, 437);
            this.rpt_local.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.chk_fornecedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chk_usuario);
            this.groupBox1.Controls.Add(this.gp_data);
            this.groupBox1.Controls.Add(this.gp_mensal);
            this.groupBox1.Controls.Add(this.rb_data);
            this.groupBox1.Controls.Add(this.rb_mensal);
            this.groupBox1.Controls.Add(this.cb_provedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gp_roteador);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chk_fornecedor
            // 
            this.chk_fornecedor.AutoSize = true;
            this.chk_fornecedor.Enabled = false;
            this.chk_fornecedor.Location = new System.Drawing.Point(140, 75);
            this.chk_fornecedor.Name = "chk_fornecedor";
            this.chk_fornecedor.Size = new System.Drawing.Size(96, 17);
            this.chk_fornecedor.TabIndex = 13;
            this.chk_fornecedor.Text = "Por fornecedor";
            this.chk_fornecedor.UseVisualStyleBackColor = true;
            this.chk_fornecedor.Visible = false;
            this.chk_fornecedor.CheckedChanged += new System.EventHandler(this.chk_fornecedor_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Busque:";
            // 
            // chk_usuario
            // 
            this.chk_usuario.AutoSize = true;
            this.chk_usuario.Enabled = false;
            this.chk_usuario.Location = new System.Drawing.Point(65, 75);
            this.chk_usuario.Name = "chk_usuario";
            this.chk_usuario.Size = new System.Drawing.Size(79, 17);
            this.chk_usuario.TabIndex = 11;
            this.chk_usuario.Text = "Por usuário";
            this.chk_usuario.UseVisualStyleBackColor = true;
            this.chk_usuario.Visible = false;
            this.chk_usuario.CheckedChanged += new System.EventHandler(this.chk_usuario_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(431, 11);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "Todos";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(281, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(152, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Roteadores com técnicos -";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(149, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Roteadores Alugados -";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_roteador_disponivel
            // 
            this.rb_roteador_disponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rb_roteador_disponivel.AutoSize = true;
            this.rb_roteador_disponivel.Location = new System.Drawing.Point(5, 10);
            this.rb_roteador_disponivel.Name = "rb_roteador_disponivel";
            this.rb_roteador_disponivel.Size = new System.Drawing.Size(145, 17);
            this.rb_roteador_disponivel.TabIndex = 7;
            this.rb_roteador_disponivel.Text = "Roteadores Disponíveis -";
            this.rb_roteador_disponivel.UseVisualStyleBackColor = true;
            this.rb_roteador_disponivel.CheckedChanged += new System.EventHandler(this.rb_roteador_disponivel_CheckedChanged);
            // 
            // gp_data
            // 
            this.gp_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gp_data.Controls.Add(this.bt_data);
            this.gp_data.Controls.Add(this.cx_data_2);
            this.gp_data.Controls.Add(this.label5);
            this.gp_data.Controls.Add(this.cx_data_1);
            this.gp_data.Controls.Add(this.label4);
            this.gp_data.Enabled = false;
            this.gp_data.Location = new System.Drawing.Point(544, 8);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(231, 62);
            this.gp_data.TabIndex = 5;
            this.gp_data.TabStop = false;
            this.gp_data.Text = "Entre Dadas";
            // 
            // bt_data
            // 
            this.bt_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_data.Location = new System.Drawing.Point(31, 37);
            this.bt_data.Name = "bt_data";
            this.bt_data.Size = new System.Drawing.Size(176, 23);
            this.bt_data.TabIndex = 11;
            this.bt_data.Text = "Buscar";
            this.bt_data.UseVisualStyleBackColor = true;
            this.bt_data.Click += new System.EventHandler(this.bt_data_Click);
            // 
            // cx_data_2
            // 
            this.cx_data_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_data_2.Location = new System.Drawing.Point(134, 14);
            this.cx_data_2.Mask = "00/00/0000";
            this.cx_data_2.Name = "cx_data_2";
            this.cx_data_2.Size = new System.Drawing.Size(73, 22);
            this.cx_data_2.TabIndex = 14;
            this.cx_data_2.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Até:";
            // 
            // cx_data_1
            // 
            this.cx_data_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_data_1.Location = new System.Drawing.Point(31, 14);
            this.cx_data_1.Mask = "00/00/0000";
            this.cx_data_1.Name = "cx_data_1";
            this.cx_data_1.Size = new System.Drawing.Size(73, 22);
            this.cx_data_1.TabIndex = 12;
            this.cx_data_1.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "De :";
            // 
            // gp_mensal
            // 
            this.gp_mensal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gp_mensal.Controls.Add(this.bt_mensal);
            this.gp_mensal.Controls.Add(this.cx_ano);
            this.gp_mensal.Controls.Add(this.label3);
            this.gp_mensal.Controls.Add(this.cb_mes);
            this.gp_mensal.Controls.Add(this.label2);
            this.gp_mensal.Enabled = false;
            this.gp_mensal.Location = new System.Drawing.Point(259, 8);
            this.gp_mensal.Name = "gp_mensal";
            this.gp_mensal.Size = new System.Drawing.Size(255, 62);
            this.gp_mensal.TabIndex = 4;
            this.gp_mensal.TabStop = false;
            this.gp_mensal.Text = "Mensal";
            // 
            // bt_mensal
            // 
            this.bt_mensal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_mensal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_mensal.Location = new System.Drawing.Point(92, 37);
            this.bt_mensal.Name = "bt_mensal";
            this.bt_mensal.Size = new System.Drawing.Size(133, 23);
            this.bt_mensal.TabIndex = 10;
            this.bt_mensal.Text = "Buscar";
            this.bt_mensal.UseVisualStyleBackColor = true;
            this.bt_mensal.Click += new System.EventHandler(this.bt_mensal_Click);
            // 
            // cx_ano
            // 
            this.cx_ano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cx_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_ano.Location = new System.Drawing.Point(39, 34);
            this.cx_ano.Mask = "0000";
            this.cx_ano.Name = "cx_ano";
            this.cx_ano.Size = new System.Drawing.Size(47, 22);
            this.cx_ano.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano:";
            // 
            // cb_mes
            // 
            this.cb_mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_mes.FormattingEnabled = true;
            this.cb_mes.Items.AddRange(new object[] {
            "",
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.cb_mes.Location = new System.Drawing.Point(39, 11);
            this.cb_mes.Name = "cb_mes";
            this.cb_mes.Size = new System.Drawing.Size(210, 21);
            this.cb_mes.TabIndex = 7;
            this.cb_mes.SelectedIndexChanged += new System.EventHandler(this.cb_mes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mês:";
            // 
            // rb_data
            // 
            this.rb_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rb_data.AutoSize = true;
            this.rb_data.Location = new System.Drawing.Point(65, 54);
            this.rb_data.Name = "rb_data";
            this.rb_data.Size = new System.Drawing.Size(123, 17);
            this.rb_data.TabIndex = 3;
            this.rb_data.Text = "Relatório entre datas";
            this.rb_data.UseVisualStyleBackColor = true;
            this.rb_data.CheckedChanged += new System.EventHandler(this.rb_data_CheckedChanged);
            // 
            // rb_mensal
            // 
            this.rb_mensal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rb_mensal.AutoSize = true;
            this.rb_mensal.Location = new System.Drawing.Point(65, 38);
            this.rb_mensal.Name = "rb_mensal";
            this.rb_mensal.Size = new System.Drawing.Size(121, 17);
            this.rb_mensal.TabIndex = 2;
            this.rb_mensal.Text = "Relatório por mensal";
            this.rb_mensal.UseVisualStyleBackColor = true;
            this.rb_mensal.CheckedChanged += new System.EventHandler(this.rb_mensal_CheckedChanged);
            // 
            // cb_provedor
            // 
            this.cb_provedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_provedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_provedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_provedor.FormattingEnabled = true;
            this.cb_provedor.Location = new System.Drawing.Point(65, 14);
            this.cb_provedor.Name = "cb_provedor";
            this.cb_provedor.Size = new System.Drawing.Size(186, 21);
            this.cb_provedor.TabIndex = 1;
            this.cb_provedor.SelectedIndexChanged += new System.EventHandler(this.cb_provedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provedor:";
            // 
            // gp_usuario
            // 
            this.gp_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gp_usuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_usuario.Controls.Add(this.cb_usuario_retirada);
            this.gp_usuario.Location = new System.Drawing.Point(59, 557);
            this.gp_usuario.Name = "gp_usuario";
            this.gp_usuario.Size = new System.Drawing.Size(242, 46);
            this.gp_usuario.TabIndex = 15;
            this.gp_usuario.TabStop = false;
            this.gp_usuario.Text = "Retirado por";
            this.gp_usuario.Visible = false;
            // 
            // cb_usuario_retirada
            // 
            this.cb_usuario_retirada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_usuario_retirada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_usuario_retirada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_usuario_retirada.FormattingEnabled = true;
            this.cb_usuario_retirada.Location = new System.Drawing.Point(10, 16);
            this.cb_usuario_retirada.Name = "cb_usuario_retirada";
            this.cb_usuario_retirada.Size = new System.Drawing.Size(221, 21);
            this.cb_usuario_retirada.TabIndex = 11;
            this.cb_usuario_retirada.SelectedIndexChanged += new System.EventHandler(this.cb_usuario_retirada_SelectedIndexChanged);
            // 
            // gp_fornecedor
            // 
            this.gp_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gp_fornecedor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_fornecedor.Controls.Add(this.cb_fornecedor);
            this.gp_fornecedor.Location = new System.Drawing.Point(329, 557);
            this.gp_fornecedor.Name = "gp_fornecedor";
            this.gp_fornecedor.Size = new System.Drawing.Size(242, 50);
            this.gp_fornecedor.TabIndex = 16;
            this.gp_fornecedor.TabStop = false;
            this.gp_fornecedor.Text = "Entregue por";
            this.gp_fornecedor.Visible = false;
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(10, 19);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(221, 21);
            this.cb_fornecedor.TabIndex = 12;
            this.cb_fornecedor.SelectedIndexChanged += new System.EventHandler(this.cb_fornecedor_SelectedIndexChanged);
            // 
            // bt_buscar_roteador
            // 
            this.bt_buscar_roteador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar_roteador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar_roteador.Location = new System.Drawing.Point(489, 8);
            this.bt_buscar_roteador.Name = "bt_buscar_roteador";
            this.bt_buscar_roteador.Size = new System.Drawing.Size(52, 23);
            this.bt_buscar_roteador.TabIndex = 15;
            this.bt_buscar_roteador.Text = "Buscar";
            this.bt_buscar_roteador.UseVisualStyleBackColor = true;
            this.bt_buscar_roteador.Click += new System.EventHandler(this.bt_buscar_roteador_Click);
            // 
            // gp_roteador
            // 
            this.gp_roteador.Controls.Add(this.radioButton4);
            this.gp_roteador.Controls.Add(this.radioButton3);
            this.gp_roteador.Controls.Add(this.radioButton2);
            this.gp_roteador.Controls.Add(this.bt_buscar_roteador);
            this.gp_roteador.Controls.Add(this.rb_roteador_disponivel);
            this.gp_roteador.Enabled = false;
            this.gp_roteador.Location = new System.Drawing.Point(233, 64);
            this.gp_roteador.Name = "gp_roteador";
            this.gp_roteador.Size = new System.Drawing.Size(542, 32);
            this.gp_roteador.TabIndex = 16;
            this.gp_roteador.TabStop = false;
            this.gp_roteador.Visible = false;
            // 
            // frm_reltatorio_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 602);
            this.Controls.Add(this.gp_fornecedor);
            this.Controls.Add(this.gp_usuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gp_relatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_reltatorio_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Estoque -> Controle de Entrada e Saída } ::...";
            this.Load += new System.EventHandler(this.frm_reltatorio_estoque_Load);
            this.gp_relatorio.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gp_data.ResumeLayout(false);
            this.gp_data.PerformLayout();
            this.gp_mensal.ResumeLayout(false);
            this.gp_mensal.PerformLayout();
            this.gp_usuario.ResumeLayout(false);
            this.gp_fornecedor.ResumeLayout(false);
            this.gp_roteador.ResumeLayout(false);
            this.gp_roteador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gp_relatorio;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_local;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gp_data;
        private System.Windows.Forms.Button bt_data;
        private System.Windows.Forms.MaskedTextBox cx_data_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox cx_data_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gp_mensal;
        private System.Windows.Forms.Button bt_mensal;
        private System.Windows.Forms.MaskedTextBox cx_ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_data;
        private System.Windows.Forms.RadioButton rb_mensal;
        private System.Windows.Forms.ComboBox cb_provedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb_roteador_disponivel;
        private System.Windows.Forms.GroupBox gp_usuario;
        private System.Windows.Forms.ComboBox cb_usuario_retirada;
        private System.Windows.Forms.GroupBox gp_fornecedor;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.CheckBox chk_fornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_usuario;
        private System.Windows.Forms.Button bt_buscar_roteador;
        private System.Windows.Forms.GroupBox gp_roteador;
    }
}