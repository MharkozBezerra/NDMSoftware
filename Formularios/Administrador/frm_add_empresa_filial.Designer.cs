namespace NDM_SoftwareV5.Formularios.Administrador
{
    partial class frm_add_empresa_filial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_empresa_filial));
            this.label1 = new System.Windows.Forms.Label();
            this.cx_descricao = new System.Windows.Forms.TextBox();
            this.cx_obs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_empresa_descricao = new System.Windows.Forms.Label();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.lbl_empresa_filial_atual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descricao:";
            // 
            // cx_descricao
            // 
            this.cx_descricao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cx_descricao.Location = new System.Drawing.Point(8, 43);
            this.cx_descricao.MaxLength = 49;
            this.cx_descricao.Name = "cx_descricao";
            this.cx_descricao.Size = new System.Drawing.Size(257, 22);
            this.cx_descricao.TabIndex = 3;
            // 
            // cx_obs
            // 
            this.cx_obs.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cx_obs.Location = new System.Drawing.Point(8, 85);
            this.cx_obs.MaxLength = 170;
            this.cx_obs.Multiline = true;
            this.cx_obs.Name = "cx_obs";
            this.cx_obs.Size = new System.Drawing.Size(257, 90);
            this.cx_obs.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lbl_empresa_descricao);
            this.groupBox1.Controls.Add(this.bt_gravar);
            this.groupBox1.Controls.Add(this.bt_cancelar);
            this.groupBox1.Controls.Add(this.lbl_empresa_filial_atual);
            this.groupBox1.Controls.Add(this.cx_obs);
            this.groupBox1.Controls.Add(this.cx_descricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 221);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lbl_empresa_descricao
            // 
            this.lbl_empresa_descricao.AutoSize = true;
            this.lbl_empresa_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_empresa_descricao.Location = new System.Drawing.Point(69, 12);
            this.lbl_empresa_descricao.Name = "lbl_empresa_descricao";
            this.lbl_empresa_descricao.Size = new System.Drawing.Size(17, 16);
            this.lbl_empresa_descricao.TabIndex = 11;
            this.lbl_empresa_descricao.Text = "...";
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_gravar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar.Location = new System.Drawing.Point(8, 176);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(104, 39);
            this.bt_gravar.TabIndex = 10;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(161, 176);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(104, 39);
            this.bt_cancelar.TabIndex = 9;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // lbl_empresa_filial_atual
            // 
            this.lbl_empresa_filial_atual.AutoSize = true;
            this.lbl_empresa_filial_atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_empresa_filial_atual.Location = new System.Drawing.Point(5, 12);
            this.lbl_empresa_filial_atual.Name = "lbl_empresa_filial_atual";
            this.lbl_empresa_filial_atual.Size = new System.Drawing.Size(69, 16);
            this.lbl_empresa_filial_atual.TabIndex = 7;
            this.lbl_empresa_filial_atual.Text = "Empresa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Observação:";
            // 
            // frm_add_empresa_filial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(281, 223);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_empresa_filial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NDM-Software [ Empresa -Incluir/Alterar ]";
            this.Load += new System.EventHandler(this.frm_add_empresa_filial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cx_descricao;
        private System.Windows.Forms.TextBox cx_obs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_empresa_filial_atual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_empresa_descricao;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}