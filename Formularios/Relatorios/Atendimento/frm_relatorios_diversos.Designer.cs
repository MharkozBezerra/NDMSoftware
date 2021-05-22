namespace NDM_SoftwareV5.Formularios.Relatorios.Estoque
{
    partial class frm_relatorios_diversos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_relatorios_diversos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.cb_provedor_ID = new System.Windows.Forms.ComboBox();
            this.chk_tipo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rpt_local = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gp_data.SuspendLayout();
            this.gp_mensal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.chk_tipo);
            this.groupBox1.Controls.Add(this.gp_data);
            this.groupBox1.Controls.Add(this.gp_mensal);
            this.groupBox1.Controls.Add(this.rb_data);
            this.groupBox1.Controls.Add(this.rb_mensal);
            this.groupBox1.Controls.Add(this.cb_provedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_provedor_ID);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // gp_data
            // 
            this.gp_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gp_data.Controls.Add(this.bt_data);
            this.gp_data.Controls.Add(this.cx_data_2);
            this.gp_data.Controls.Add(this.label5);
            this.gp_data.Controls.Add(this.cx_data_1);
            this.gp_data.Controls.Add(this.label4);
            this.gp_data.Enabled = false;
            this.gp_data.Location = new System.Drawing.Point(526, 8);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(231, 67);
            this.gp_data.TabIndex = 5;
            this.gp_data.TabStop = false;
            this.gp_data.Text = "Entre Dadas";
            // 
            // bt_data
            // 
            this.bt_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_data.Location = new System.Drawing.Point(31, 37);
            this.bt_data.Name = "bt_data";
            this.bt_data.Size = new System.Drawing.Size(176, 23);
            this.bt_data.TabIndex = 11;
            this.bt_data.Text = "Buscar";
            this.bt_data.UseVisualStyleBackColor = true;
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
            this.gp_mensal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gp_mensal.Controls.Add(this.bt_mensal);
            this.gp_mensal.Controls.Add(this.cx_ano);
            this.gp_mensal.Controls.Add(this.label3);
            this.gp_mensal.Controls.Add(this.cb_mes);
            this.gp_mensal.Controls.Add(this.label2);
            this.gp_mensal.Enabled = false;
            this.gp_mensal.Location = new System.Drawing.Point(265, 8);
            this.gp_mensal.Name = "gp_mensal";
            this.gp_mensal.Size = new System.Drawing.Size(255, 67);
            this.gp_mensal.TabIndex = 4;
            this.gp_mensal.TabStop = false;
            this.gp_mensal.Text = "Mensal";
            // 
            // bt_mensal
            // 
            this.bt_mensal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_mensal.Location = new System.Drawing.Point(92, 37);
            this.bt_mensal.Name = "bt_mensal";
            this.bt_mensal.Size = new System.Drawing.Size(133, 23);
            this.bt_mensal.TabIndex = 10;
            this.bt_mensal.Text = "Buscar";
            this.bt_mensal.UseVisualStyleBackColor = true;
            // 
            // cx_ano
            // 
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
            this.rb_data.Location = new System.Drawing.Point(87, 54);
            this.rb_data.Name = "rb_data";
            this.rb_data.Size = new System.Drawing.Size(123, 17);
            this.rb_data.TabIndex = 3;
            this.rb_data.Text = "Relatório entre datas";
            this.rb_data.UseVisualStyleBackColor = true;
            // 
            // rb_mensal
            // 
            this.rb_mensal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rb_mensal.AutoSize = true;
            this.rb_mensal.Location = new System.Drawing.Point(87, 38);
            this.rb_mensal.Name = "rb_mensal";
            this.rb_mensal.Size = new System.Drawing.Size(121, 17);
            this.rb_mensal.TabIndex = 2;
            this.rb_mensal.Text = "Relatório por mensal";
            this.rb_mensal.UseVisualStyleBackColor = true;
            // 
            // cb_provedor
            // 
            this.cb_provedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_provedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_provedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_provedor.FormattingEnabled = true;
            this.cb_provedor.Location = new System.Drawing.Point(87, 14);
            this.cb_provedor.Name = "cb_provedor";
            this.cb_provedor.Size = new System.Drawing.Size(170, 21);
            this.cb_provedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provedor:";
            // 
            // cb_provedor_ID
            // 
            this.cb_provedor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_provedor_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_provedor_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provedor_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_provedor_ID.FormattingEnabled = true;
            this.cb_provedor_ID.Location = new System.Drawing.Point(273, 20);
            this.cb_provedor_ID.Name = "cb_provedor_ID";
            this.cb_provedor_ID.Size = new System.Drawing.Size(34, 21);
            this.cb_provedor_ID.TabIndex = 6;
            // 
            // chk_tipo
            // 
            this.chk_tipo.AutoSize = true;
            this.chk_tipo.Location = new System.Drawing.Point(87, 73);
            this.chk_tipo.Name = "chk_tipo";
            this.chk_tipo.Size = new System.Drawing.Size(80, 17);
            this.chk_tipo.TabIndex = 7;
            this.chk_tipo.Text = "checkBox1";
            this.chk_tipo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.rpt_local);
            this.groupBox2.Location = new System.Drawing.Point(1, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 484);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rpt_local
            // 
            this.rpt_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_local.Location = new System.Drawing.Point(3, 16);
            this.rpt_local.Name = "rpt_local";
            this.rpt_local.Size = new System.Drawing.Size(785, 465);
            this.rpt_local.TabIndex = 0;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButton4.Location = new System.Drawing.Point(698, 78);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.Text = "Todos";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButton3.Location = new System.Drawing.Point(546, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(152, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "Roteadores com técnicos -";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButton2.Location = new System.Drawing.Point(413, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Roteadores Alugados -";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButton1.Location = new System.Drawing.Point(268, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(145, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Roteadores Disponíveis -";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            // 
            // frm_relatorios_diversos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_relatorios_diversos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Relatório } ::...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gp_data.ResumeLayout(false);
            this.gp_data.PerformLayout();
            this.gp_mensal.ResumeLayout(false);
            this.gp_mensal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.ComboBox cb_provedor_ID;
        private System.Windows.Forms.CheckBox chk_tipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_local;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}