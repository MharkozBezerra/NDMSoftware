namespace NDM_SoftwareV5.Formularios.OrdemServico
{
    partial class frm_fechar_agendamento_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fechar_agendamento_OS));
            this.cx_data_fechada = new System.Windows.Forms.MaskedTextBox();
            this.cx_ag_cod_OS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_data_txt = new System.Windows.Forms.Label();
            this.cx_age_subcategoria = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cx_age_categoria = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cx_age_obs = new System.Windows.Forms.TextBox();
            this.cx_age_helpdesk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cx_age_nome_cliente = new System.Windows.Forms.TextBox();
            this.cx_age_cod_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cx_data_aberta = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_titullo = new System.Windows.Forms.Label();
            this.bt_age_concluir = new System.Windows.Forms.Button();
            this.bt_age_cancelar = new System.Windows.Forms.Button();
            this.lbl_mudeAqui = new System.Windows.Forms.Label();
            this.lbl_texto_maximo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grupo_os = new System.Windows.Forms.GroupBox();
            this.cb_subcategoria_os_desc = new System.Windows.Forms.ComboBox();
            this.cb_categoria_os_desc = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grupo_os.SuspendLayout();
            this.SuspendLayout();
            // 
            // cx_data_fechada
            // 
            this.cx_data_fechada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_data_fechada.Location = new System.Drawing.Point(270, 69);
            this.cx_data_fechada.Mask = "00/00/0000";
            this.cx_data_fechada.Name = "cx_data_fechada";
            this.cx_data_fechada.Size = new System.Drawing.Size(84, 21);
            this.cx_data_fechada.TabIndex = 0;
            this.cx_data_fechada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_data_fechada.ValidatingType = typeof(System.DateTime);
            this.cx_data_fechada.Leave += new System.EventHandler(this.cx_data_fechada_Leave);
            this.cx_data_fechada.Validated += new System.EventHandler(this.cx_data_fechada_Validated);
            // 
            // cx_ag_cod_OS
            // 
            this.cx_ag_cod_OS.BackColor = System.Drawing.SystemColors.Info;
            this.cx_ag_cod_OS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_ag_cod_OS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cx_ag_cod_OS.Location = new System.Drawing.Point(86, 46);
            this.cx_ag_cod_OS.MaxLength = 5;
            this.cx_ag_cod_OS.Name = "cx_ag_cod_OS";
            this.cx_ag_cod_OS.ReadOnly = true;
            this.cx_ag_cod_OS.Size = new System.Drawing.Size(84, 21);
            this.cx_ag_cod_OS.TabIndex = 4;
            this.cx_ag_cod_OS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label17.Location = new System.Drawing.Point(2, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 16);
            this.label17.TabIndex = 61;
            this.label17.Text = "Código O.S :";
            // 
            // lbl_data_txt
            // 
            this.lbl_data_txt.AutoSize = true;
            this.lbl_data_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_data_txt.Location = new System.Drawing.Point(172, 70);
            this.lbl_data_txt.Name = "lbl_data_txt";
            this.lbl_data_txt.Size = new System.Drawing.Size(99, 16);
            this.lbl_data_txt.TabIndex = 67;
            this.lbl_data_txt.Text = "Agendamento :";
            // 
            // cx_age_subcategoria
            // 
            this.cx_age_subcategoria.BackColor = System.Drawing.SystemColors.Info;
            this.cx_age_subcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_age_subcategoria.Location = new System.Drawing.Point(104, 164);
            this.cx_age_subcategoria.MaxLength = 5;
            this.cx_age_subcategoria.Name = "cx_age_subcategoria";
            this.cx_age_subcategoria.ReadOnly = true;
            this.cx_age_subcategoria.Size = new System.Drawing.Size(331, 21);
            this.cx_age_subcategoria.TabIndex = 10;
            this.cx_age_subcategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label28.Location = new System.Drawing.Point(0, 164);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 16);
            this.label28.TabIndex = 65;
            this.label28.Text = "Subcategoria :";
            // 
            // cx_age_categoria
            // 
            this.cx_age_categoria.BackColor = System.Drawing.SystemColors.Info;
            this.cx_age_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_age_categoria.Location = new System.Drawing.Point(86, 140);
            this.cx_age_categoria.MaxLength = 5;
            this.cx_age_categoria.Name = "cx_age_categoria";
            this.cx_age_categoria.ReadOnly = true;
            this.cx_age_categoria.Size = new System.Drawing.Size(349, 21);
            this.cx_age_categoria.TabIndex = 9;
            this.cx_age_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label29.Location = new System.Drawing.Point(12, 142);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 16);
            this.label29.TabIndex = 64;
            this.label29.Text = "Categoria :";
            // 
            // cx_age_obs
            // 
            this.cx_age_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_age_obs.Location = new System.Drawing.Point(3, 279);
            this.cx_age_obs.MaxLength = 970;
            this.cx_age_obs.Multiline = true;
            this.cx_age_obs.Name = "cx_age_obs";
            this.cx_age_obs.Size = new System.Drawing.Size(432, 115);
            this.cx_age_obs.TabIndex = 1;
            this.cx_age_obs.TextChanged += new System.EventHandler(this.cx_age_obs_TextChanged);
            // 
            // cx_age_helpdesk
            // 
            this.cx_age_helpdesk.BackColor = System.Drawing.SystemColors.Info;
            this.cx_age_helpdesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_age_helpdesk.Location = new System.Drawing.Point(86, 116);
            this.cx_age_helpdesk.MaxLength = 5;
            this.cx_age_helpdesk.Name = "cx_age_helpdesk";
            this.cx_age_helpdesk.ReadOnly = true;
            this.cx_age_helpdesk.Size = new System.Drawing.Size(349, 21);
            this.cx_age_helpdesk.TabIndex = 8;
            this.cx_age_helpdesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Aberta por :";
            // 
            // cx_age_nome_cliente
            // 
            this.cx_age_nome_cliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_age_nome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_age_nome_cliente.Location = new System.Drawing.Point(174, 92);
            this.cx_age_nome_cliente.MaxLength = 5;
            this.cx_age_nome_cliente.Name = "cx_age_nome_cliente";
            this.cx_age_nome_cliente.ReadOnly = true;
            this.cx_age_nome_cliente.Size = new System.Drawing.Size(261, 21);
            this.cx_age_nome_cliente.TabIndex = 7;
            this.cx_age_nome_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx_age_cod_cliente
            // 
            this.cx_age_cod_cliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_age_cod_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_age_cod_cliente.Location = new System.Drawing.Point(86, 92);
            this.cx_age_cod_cliente.MaxLength = 5;
            this.cx_age_cod_cliente.Name = "cx_age_cod_cliente";
            this.cx_age_cod_cliente.ReadOnly = true;
            this.cx_age_cod_cliente.Size = new System.Drawing.Size(84, 21);
            this.cx_age_cod_cliente.TabIndex = 6;
            this.cx_age_cod_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(30, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Cliente :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label16.Location = new System.Drawing.Point(31, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "Aberta :";
            // 
            // cx_data_aberta
            // 
            this.cx_data_aberta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_data_aberta.Location = new System.Drawing.Point(86, 69);
            this.cx_data_aberta.Mask = "00/00/0000";
            this.cx_data_aberta.Name = "cx_data_aberta";
            this.cx_data_aberta.ReadOnly = true;
            this.cx_data_aberta.Size = new System.Drawing.Size(84, 21);
            this.cx_data_aberta.TabIndex = 5;
            this.cx_data_aberta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_data_aberta.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_titullo);
            this.groupBox1.Location = new System.Drawing.Point(5, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 47);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // lbl_titullo
            // 
            this.lbl_titullo.AutoSize = true;
            this.lbl_titullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titullo.Location = new System.Drawing.Point(45, 16);
            this.lbl_titullo.Name = "lbl_titullo";
            this.lbl_titullo.Size = new System.Drawing.Size(343, 25);
            this.lbl_titullo.TabIndex = 0;
            this.lbl_titullo.Text = "Conclusão de Ordem de Seviço";
            // 
            // bt_age_concluir
            // 
            this.bt_age_concluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_age_concluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_age_concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_age_concluir.Image = global::NDM_SoftwareV5.Properties.Resources.gravar;
            this.bt_age_concluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_age_concluir.Location = new System.Drawing.Point(55, 393);
            this.bt_age_concluir.Name = "bt_age_concluir";
            this.bt_age_concluir.Size = new System.Drawing.Size(132, 38);
            this.bt_age_concluir.TabIndex = 2;
            this.bt_age_concluir.Text = "Fechar O.S ";
            this.bt_age_concluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_age_concluir.UseVisualStyleBackColor = false;
            this.bt_age_concluir.Click += new System.EventHandler(this.bt_age_concluir_Click);
            // 
            // bt_age_cancelar
            // 
            this.bt_age_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_age_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_age_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_age_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_age_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_age_cancelar.Location = new System.Drawing.Point(187, 393);
            this.bt_age_cancelar.Name = "bt_age_cancelar";
            this.bt_age_cancelar.Size = new System.Drawing.Size(116, 38);
            this.bt_age_cancelar.TabIndex = 3;
            this.bt_age_cancelar.Text = "  Cancelar";
            this.bt_age_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_age_cancelar.UseVisualStyleBackColor = false;
            this.bt_age_cancelar.Click += new System.EventHandler(this.bt_age_cancelar_Click);
            // 
            // lbl_mudeAqui
            // 
            this.lbl_mudeAqui.AutoSize = true;
            this.lbl_mudeAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_mudeAqui.ForeColor = System.Drawing.Color.Red;
            this.lbl_mudeAqui.Location = new System.Drawing.Point(274, 51);
            this.lbl_mudeAqui.Name = "lbl_mudeAqui";
            this.lbl_mudeAqui.Size = new System.Drawing.Size(76, 16);
            this.lbl_mudeAqui.TabIndex = 71;
            this.lbl_mudeAqui.Text = "*Mude aqui";
            // 
            // lbl_texto_maximo
            // 
            this.lbl_texto_maximo.AutoSize = true;
            this.lbl_texto_maximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_texto_maximo.Location = new System.Drawing.Point(325, 397);
            this.lbl_texto_maximo.Name = "lbl_texto_maximo";
            this.lbl_texto_maximo.Size = new System.Drawing.Size(83, 16);
            this.lbl_texto_maximo.TabIndex = 72;
            this.lbl_texto_maximo.Text = "Texto : 0/970";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Subcategoria :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Categoria Técnica:";
            // 
            // grupo_os
            // 
            this.grupo_os.Controls.Add(this.cb_subcategoria_os_desc);
            this.grupo_os.Controls.Add(this.cb_categoria_os_desc);
            this.grupo_os.Controls.Add(this.label4);
            this.grupo_os.Controls.Add(this.label1);
            this.grupo_os.Location = new System.Drawing.Point(5, 189);
            this.grupo_os.Name = "grupo_os";
            this.grupo_os.Size = new System.Drawing.Size(430, 84);
            this.grupo_os.TabIndex = 75;
            this.grupo_os.TabStop = false;
            this.grupo_os.Text = "Definição Técnica";
            // 
            // cb_subcategoria_os_desc
            // 
            this.cb_subcategoria_os_desc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_subcategoria_os_desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subcategoria_os_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_subcategoria_os_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_subcategoria_os_desc.FormattingEnabled = true;
            this.cb_subcategoria_os_desc.Location = new System.Drawing.Point(137, 45);
            this.cb_subcategoria_os_desc.Name = "cb_subcategoria_os_desc";
            this.cb_subcategoria_os_desc.Size = new System.Drawing.Size(266, 23);
            this.cb_subcategoria_os_desc.TabIndex = 76;
            this.cb_subcategoria_os_desc.SelectedIndexChanged += new System.EventHandler(this.cb_subcategoria_os_desc_SelectedIndexChanged);
            // 
            // cb_categoria_os_desc
            // 
            this.cb_categoria_os_desc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categoria_os_desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria_os_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria_os_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_categoria_os_desc.FormattingEnabled = true;
            this.cb_categoria_os_desc.Location = new System.Drawing.Point(137, 20);
            this.cb_categoria_os_desc.Name = "cb_categoria_os_desc";
            this.cb_categoria_os_desc.Size = new System.Drawing.Size(266, 23);
            this.cb_categoria_os_desc.TabIndex = 75;
            this.cb_categoria_os_desc.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_os_desc_SelectedIndexChanged);
            // 
            // frm_fechar_agendamento_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(441, 432);
            this.Controls.Add(this.grupo_os);
            this.Controls.Add(this.lbl_texto_maximo);
            this.Controls.Add(this.lbl_mudeAqui);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cx_data_fechada);
            this.Controls.Add(this.cx_ag_cod_OS);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_data_txt);
            this.Controls.Add(this.cx_age_subcategoria);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cx_age_categoria);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.cx_age_obs);
            this.Controls.Add(this.cx_age_helpdesk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cx_age_nome_cliente);
            this.Controls.Add(this.cx_age_cod_cliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cx_data_aberta);
            this.Controls.Add(this.bt_age_cancelar);
            this.Controls.Add(this.bt_age_concluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_fechar_agendamento_OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - {Ordem de Serviço - Fechar Agendamento } ::...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_fechar_agendamento_OS_FormClosed);
            this.Load += new System.EventHandler(this.frm_fechar_agendamento_OS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupo_os.ResumeLayout(false);
            this.grupo_os.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cx_data_fechada;
        private System.Windows.Forms.TextBox cx_ag_cod_OS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_data_txt;
        private System.Windows.Forms.TextBox cx_age_subcategoria;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox cx_age_categoria;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox cx_age_obs;
        private System.Windows.Forms.TextBox cx_age_helpdesk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cx_age_nome_cliente;
        private System.Windows.Forms.TextBox cx_age_cod_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox cx_data_aberta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_titullo;
        private System.Windows.Forms.Button bt_age_concluir;
        private System.Windows.Forms.Button bt_age_cancelar;
        private System.Windows.Forms.Label lbl_mudeAqui;
        private System.Windows.Forms.Label lbl_texto_maximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupo_os;

        private System.Windows.Forms.ComboBox cb_subcategoria_os_desc;
        private System.Windows.Forms.ComboBox cb_categoria_os_desc;
    }
}