namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente
{
    partial class frm_add_endereco_bairro_rua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_endereco_bairro_rua));
            this.grp_endereco_ver = new System.Windows.Forms.GroupBox();
            this.cx_cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.cx_rua = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.cx_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.cx_cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_atualizar_1 = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.grp_endereco_ver.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_endereco_ver
            // 
            this.grp_endereco_ver.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grp_endereco_ver.Controls.Add(this.cx_cep);
            this.grp_endereco_ver.Controls.Add(this.bt_atualizar_1);
            this.grp_endereco_ver.Controls.Add(this.lbl_cep);
            this.grp_endereco_ver.Controls.Add(this.bt_cancelar);
            this.grp_endereco_ver.Controls.Add(this.cx_rua);
            this.grp_endereco_ver.Controls.Add(this.lbl_rua);
            this.grp_endereco_ver.Controls.Add(this.cx_bairro);
            this.grp_endereco_ver.Controls.Add(this.lbl_bairro);
            this.grp_endereco_ver.Controls.Add(this.cx_cidade);
            this.grp_endereco_ver.Controls.Add(this.label7);
            this.grp_endereco_ver.Location = new System.Drawing.Point(1, 0);
            this.grp_endereco_ver.Name = "grp_endereco_ver";
            this.grp_endereco_ver.Size = new System.Drawing.Size(501, 101);
            this.grp_endereco_ver.TabIndex = 22;
            this.grp_endereco_ver.TabStop = false;
            this.grp_endereco_ver.Text = "Endereço";
            // 
            // cx_cep
            // 
            this.cx_cep.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cep.Location = new System.Drawing.Point(339, 69);
            this.cx_cep.Mask = "00.000-000";
            this.cx_cep.Name = "cx_cep";
            this.cx_cep.Size = new System.Drawing.Size(93, 22);
            this.cx_cep.TabIndex = 3;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_cep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cep.Location = new System.Drawing.Point(303, 72);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(38, 16);
            this.lbl_cep.TabIndex = 28;
            this.lbl_cep.Text = "CEP:";
            // 
            // cx_rua
            // 
            this.cx_rua.BackColor = System.Drawing.SystemColors.Info;
            this.cx_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_rua.Location = new System.Drawing.Point(63, 69);
            this.cx_rua.MaxLength = 245;
            this.cx_rua.Name = "cx_rua";
            this.cx_rua.Size = new System.Drawing.Size(237, 22);
            this.cx_rua.TabIndex = 2;
            this.cx_rua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_rua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_rua.Location = new System.Drawing.Point(28, 72);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(36, 16);
            this.lbl_rua.TabIndex = 26;
            this.lbl_rua.Text = "Rua:";
            // 
            // cx_bairro
            // 
            this.cx_bairro.BackColor = System.Drawing.SystemColors.Info;
            this.cx_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_bairro.Location = new System.Drawing.Point(63, 41);
            this.cx_bairro.MaxLength = 245;
            this.cx_bairro.Name = "cx_bairro";
            this.cx_bairro.Size = new System.Drawing.Size(369, 22);
            this.cx_bairro.TabIndex = 1;
            this.cx_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_bairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_bairro.Location = new System.Drawing.Point(17, 44);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(47, 16);
            this.lbl_bairro.TabIndex = 24;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // cx_cidade
            // 
            this.cx_cidade.BackColor = System.Drawing.SystemColors.Info;
            this.cx_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_cidade.Location = new System.Drawing.Point(63, 13);
            this.cx_cidade.MaxLength = 250;
            this.cx_cidade.Name = "cx_cidade";
            this.cx_cidade.Size = new System.Drawing.Size(369, 22);
            this.cx_cidade.TabIndex = 0;
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
            // bt_atualizar_1
            // 
            this.bt_atualizar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_atualizar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_atualizar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar_1.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_atualizar_1.Location = new System.Drawing.Point(441, 13);
            this.bt_atualizar_1.Name = "bt_atualizar_1";
            this.bt_atualizar_1.Size = new System.Drawing.Size(49, 38);
            this.bt_atualizar_1.TabIndex = 5;
            this.bt_atualizar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_atualizar_1.UseVisualStyleBackColor = false;
            this.bt_atualizar_1.Click += new System.EventHandler(this.bt_atualizar_1_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.Location = new System.Drawing.Point(441, 53);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(49, 38);
            this.bt_cancelar.TabIndex = 6;
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // frm_add_endereco_bairro_rua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 101);
            this.Controls.Add(this.grp_endereco_ver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_endereco_bairro_rua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - {Endereço - Inclusão / Alteração } ::...";
            this.Load += new System.EventHandler(this.frm_add_endereco_bairro_rua_Load);
            this.grp_endereco_ver.ResumeLayout(false);
            this.grp_endereco_ver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_endereco_ver;
        private System.Windows.Forms.MaskedTextBox cx_cep;
        private System.Windows.Forms.Button bt_atualizar_1;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox cx_rua;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.TextBox cx_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox cx_cidade;
        private System.Windows.Forms.Label label7;
    }
}