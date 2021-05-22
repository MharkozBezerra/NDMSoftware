namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    partial class frm_encaminhar_atendimento_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_encaminhar_atendimento_help));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_helpDesk = new System.Windows.Forms.ComboBox();
            this.cb_subcategoria_descricao = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_categoria_descricao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_ac_cancelar = new System.Windows.Forms.Button();
            this.bt_ac_salvar_sem_finalizar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cx_ac_obs = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cx_ac_nomeCliente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cx_ac_codCliente = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_texto_max = new System.Windows.Forms.Label();
            this.cb_helpDesk_ID = new System.Windows.Forms.ComboBox();
            this.cb_TipoAtendimento_ID = new System.Windows.Forms.ComboBox();
            this.cb_atendimentoRealizado_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.cb_helpDesk);
            this.groupBox4.Controls.Add(this.cb_subcategoria_descricao);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cb_categoria_descricao);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.bt_ac_cancelar);
            this.groupBox4.Controls.Add(this.bt_ac_salvar_sem_finalizar);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.cx_ac_obs);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cx_ac_nomeCliente);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.cx_ac_codCliente);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.lbl_texto_max);
            this.groupBox4.Location = new System.Drawing.Point(3, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 419);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acompanhar atendimentos";
            // 
            // cb_helpDesk
            // 
            this.cb_helpDesk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_helpDesk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_helpDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_helpDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_helpDesk.FormattingEnabled = true;
            this.cb_helpDesk.Location = new System.Drawing.Point(12, 35);
            this.cb_helpDesk.Name = "cb_helpDesk";
            this.cb_helpDesk.Size = new System.Drawing.Size(352, 23);
            this.cb_helpDesk.TabIndex = 27;
            this.cb_helpDesk.SelectedIndexChanged += new System.EventHandler(this.cb_helpDesk_SelectedIndexChanged);
            // 
            // cb_subcategoria_descricao
            // 
            this.cb_subcategoria_descricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_subcategoria_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subcategoria_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_subcategoria_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_subcategoria_descricao.FormattingEnabled = true;
            this.cb_subcategoria_descricao.Location = new System.Drawing.Point(12, 168);
            this.cb_subcategoria_descricao.Name = "cb_subcategoria_descricao";
            this.cb_subcategoria_descricao.Size = new System.Drawing.Size(352, 23);
            this.cb_subcategoria_descricao.TabIndex = 24;
            this.cb_subcategoria_descricao.SelectedIndexChanged += new System.EventHandler(this.cb_subcategoria_descricao_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(12, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Atendimento realizado";
            // 
            // cb_categoria_descricao
            // 
            this.cb_categoria_descricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categoria_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_categoria_descricao.FormattingEnabled = true;
            this.cb_categoria_descricao.Location = new System.Drawing.Point(12, 120);
            this.cb_categoria_descricao.Name = "cb_categoria_descricao";
            this.cb_categoria_descricao.Size = new System.Drawing.Size(352, 23);
            this.cb_categoria_descricao.TabIndex = 23;
            this.cb_categoria_descricao.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_descricao_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(12, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tipo de atendimento";
            // 
            // bt_ac_cancelar
            // 
            this.bt_ac_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_ac_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ac_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_ac_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ac_cancelar.Location = new System.Drawing.Point(219, 370);
            this.bt_ac_cancelar.Name = "bt_ac_cancelar";
            this.bt_ac_cancelar.Size = new System.Drawing.Size(145, 40);
            this.bt_ac_cancelar.TabIndex = 11;
            this.bt_ac_cancelar.Text = "Cancelar Encaminhamento";
            this.bt_ac_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ac_cancelar.UseVisualStyleBackColor = false;
            this.bt_ac_cancelar.Click += new System.EventHandler(this.bt_ac_cancelar_Click);
            // 
            // bt_ac_salvar_sem_finalizar
            // 
            this.bt_ac_salvar_sem_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_ac_salvar_sem_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ac_salvar_sem_finalizar.Image = global::NDM_SoftwareV5.Properties.Resources.gravar;
            this.bt_ac_salvar_sem_finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ac_salvar_sem_finalizar.Location = new System.Drawing.Point(12, 370);
            this.bt_ac_salvar_sem_finalizar.Name = "bt_ac_salvar_sem_finalizar";
            this.bt_ac_salvar_sem_finalizar.Size = new System.Drawing.Size(110, 40);
            this.bt_ac_salvar_sem_finalizar.TabIndex = 10;
            this.bt_ac_salvar_sem_finalizar.Text = "Encaminhar";
            this.bt_ac_salvar_sem_finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ac_salvar_sem_finalizar.UseVisualStyleBackColor = false;
            this.bt_ac_salvar_sem_finalizar.Click += new System.EventHandler(this.bt_ac_salvar_sem_finalizar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(191, 16);
            this.label20.TabIndex = 22;
            this.label20.Text = "Encaminhar Atendimento para:";
            // 
            // cx_ac_obs
            // 
            this.cx_ac_obs.BackColor = System.Drawing.SystemColors.Info;
            this.cx_ac_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_ac_obs.Location = new System.Drawing.Point(12, 210);
            this.cx_ac_obs.MaxLength = 180;
            this.cx_ac_obs.Multiline = true;
            this.cx_ac_obs.Name = "cx_ac_obs";
            this.cx_ac_obs.Size = new System.Drawing.Size(352, 154);
            this.cx_ac_obs.TabIndex = 7;
            this.cx_ac_obs.TextChanged += new System.EventHandler(this.cx_ac_obs_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label21.Location = new System.Drawing.Point(12, 191);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 16);
            this.label21.TabIndex = 20;
            this.label21.Text = "Observações ";
            // 
            // cx_ac_nomeCliente
            // 
            this.cx_ac_nomeCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_ac_nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_ac_nomeCliente.Location = new System.Drawing.Point(101, 76);
            this.cx_ac_nomeCliente.MaxLength = 5;
            this.cx_ac_nomeCliente.Name = "cx_ac_nomeCliente";
            this.cx_ac_nomeCliente.ReadOnly = true;
            this.cx_ac_nomeCliente.Size = new System.Drawing.Size(263, 21);
            this.cx_ac_nomeCliente.TabIndex = 6;
            this.cx_ac_nomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label22.Location = new System.Drawing.Point(91, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 16);
            this.label22.TabIndex = 12;
            this.label22.Text = "Nome Cliente";
            // 
            // cx_ac_codCliente
            // 
            this.cx_ac_codCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_ac_codCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_ac_codCliente.Location = new System.Drawing.Point(12, 76);
            this.cx_ac_codCliente.MaxLength = 5;
            this.cx_ac_codCliente.Name = "cx_ac_codCliente";
            this.cx_ac_codCliente.ReadOnly = true;
            this.cx_ac_codCliente.Size = new System.Drawing.Size(66, 21);
            this.cx_ac_codCliente.TabIndex = 5;
            this.cx_ac_codCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label23.Location = new System.Drawing.Point(12, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 16);
            this.label23.TabIndex = 10;
            this.label23.Text = "Código";
            // 
            // lbl_texto_max
            // 
            this.lbl_texto_max.AutoSize = true;
            this.lbl_texto_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_texto_max.Location = new System.Drawing.Point(259, 194);
            this.lbl_texto_max.Name = "lbl_texto_max";
            this.lbl_texto_max.Size = new System.Drawing.Size(105, 16);
            this.lbl_texto_max.TabIndex = 28;
            this.lbl_texto_max.Text = "Max.Texto 0/180";
            // 
            // cb_helpDesk_ID
            // 
            this.cb_helpDesk_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_helpDesk_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_helpDesk_ID.Enabled = false;
            this.cb_helpDesk_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_helpDesk_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_helpDesk_ID.FormattingEnabled = true;
            this.cb_helpDesk_ID.Location = new System.Drawing.Point(305, 41);
            this.cb_helpDesk_ID.Name = "cb_helpDesk_ID";
            this.cb_helpDesk_ID.Size = new System.Drawing.Size(69, 23);
            this.cb_helpDesk_ID.TabIndex = 28;
            // 
            // cb_TipoAtendimento_ID
            // 
            this.cb_TipoAtendimento_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_TipoAtendimento_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoAtendimento_ID.Enabled = false;
            this.cb_TipoAtendimento_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TipoAtendimento_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_TipoAtendimento_ID.FormattingEnabled = true;
            this.cb_TipoAtendimento_ID.Location = new System.Drawing.Point(305, 70);
            this.cb_TipoAtendimento_ID.Name = "cb_TipoAtendimento_ID";
            this.cb_TipoAtendimento_ID.Size = new System.Drawing.Size(69, 23);
            this.cb_TipoAtendimento_ID.TabIndex = 28;
            // 
            // cb_atendimentoRealizado_ID
            // 
            this.cb_atendimentoRealizado_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_atendimentoRealizado_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_atendimentoRealizado_ID.Enabled = false;
            this.cb_atendimentoRealizado_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_atendimentoRealizado_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_atendimentoRealizado_ID.FormattingEnabled = true;
            this.cb_atendimentoRealizado_ID.Location = new System.Drawing.Point(305, 99);
            this.cb_atendimentoRealizado_ID.Name = "cb_atendimentoRealizado_ID";
            this.cb_atendimentoRealizado_ID.Size = new System.Drawing.Size(69, 23);
            this.cb_atendimentoRealizado_ID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = " ..:: NDM-Software - {HelpDesk - Atendimento } ::...";
            // 
            // frm_encaminhar_atendimento_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cb_helpDesk_ID);
            this.Controls.Add(this.cb_atendimentoRealizado_ID);
            this.Controls.Add(this.cb_TipoAtendimento_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_encaminhar_atendimento_help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - {HelpDesk - Atendimento } ::...";
            this.Load += new System.EventHandler(this.frm_encaminhar_atendimento_help_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_ac_cancelar;
        private System.Windows.Forms.Button bt_ac_salvar_sem_finalizar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cx_ac_obs;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox cx_ac_nomeCliente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox cx_ac_codCliente;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cb_helpDesk;
        private System.Windows.Forms.ComboBox cb_subcategoria_descricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_categoria_descricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_helpDesk_ID;
        private System.Windows.Forms.ComboBox cb_TipoAtendimento_ID;
        private System.Windows.Forms.ComboBox cb_atendimentoRealizado_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_texto_max;
    }
}