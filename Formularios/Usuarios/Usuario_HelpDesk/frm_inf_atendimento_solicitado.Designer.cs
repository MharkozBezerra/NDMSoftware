namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    partial class frm_inf_atendimento_solicitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inf_atendimento_solicitado));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mostra_atendimento = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_qtd_atendimento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_prioridade = new System.Windows.Forms.Label();
            this.img_prioridade = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cx_Subcategoria = new System.Windows.Forms.TextBox();
            this.cx_help = new System.Windows.Forms.TextBox();
            this.cx_categoria = new System.Windows.Forms.TextBox();
            this.cx_provedor = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.bt_finalizar = new System.Windows.Forms.Button();
            this.cx_solicitado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cx_obs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cx_nomeCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cx_codCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cx_dataHora = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_atendimento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_prioridade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mostra_atendimento);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbl_qtd_atendimento);
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 526);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Solicitações";
            // 
            // mostra_atendimento
            // 
            this.mostra_atendimento.AllowUserToAddRows = false;
            this.mostra_atendimento.AllowUserToDeleteRows = false;
            this.mostra_atendimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mostra_atendimento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mostra_atendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostra_atendimento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mostra_atendimento.Location = new System.Drawing.Point(6, 15);
            this.mostra_atendimento.MultiSelect = false;
            this.mostra_atendimento.Name = "mostra_atendimento";
            this.mostra_atendimento.ReadOnly = true;
            this.mostra_atendimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostra_atendimento.Size = new System.Drawing.Size(487, 484);
            this.mostra_atendimento.TabIndex = 5;
            this.mostra_atendimento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mostra_atendimento_CellMouseClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(161, 502);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Total de Solicitação:";
            // 
            // lbl_qtd_atendimento
            // 
            this.lbl_qtd_atendimento.AutoSize = true;
            this.lbl_qtd_atendimento.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbl_qtd_atendimento.ForeColor = System.Drawing.Color.Red;
            this.lbl_qtd_atendimento.Location = new System.Drawing.Point(287, 503);
            this.lbl_qtd_atendimento.Name = "lbl_qtd_atendimento";
            this.lbl_qtd_atendimento.Size = new System.Drawing.Size(15, 17);
            this.lbl_qtd_atendimento.TabIndex = 4;
            this.lbl_qtd_atendimento.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cx_Subcategoria);
            this.groupBox2.Controls.Add(this.cx_help);
            this.groupBox2.Controls.Add(this.cx_categoria);
            this.groupBox2.Controls.Add(this.cx_provedor);
            this.groupBox2.Controls.Add(this.bt_cancelar);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.bt_finalizar);
            this.groupBox2.Controls.Add(this.cx_solicitado);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cx_obs);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cx_nomeCliente);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cx_codCliente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cx_dataHora);
            this.groupBox2.Location = new System.Drawing.Point(509, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 519);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Atendimento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_prioridade);
            this.groupBox1.Controls.Add(this.img_prioridade);
            this.groupBox1.Location = new System.Drawing.Point(197, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 45);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitação com prioridade";
            // 
            // lbl_prioridade
            // 
            this.lbl_prioridade.AutoSize = true;
            this.lbl_prioridade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioridade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_prioridade.Location = new System.Drawing.Point(60, 18);
            this.lbl_prioridade.Name = "lbl_prioridade";
            this.lbl_prioridade.Size = new System.Drawing.Size(40, 17);
            this.lbl_prioridade.TabIndex = 28;
            this.lbl_prioridade.Text = "Baixa";
            this.lbl_prioridade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // img_prioridade
            // 
            this.img_prioridade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_prioridade.Image = global::NDM_SoftwareV5.Properties.Resources.verde_25x25;
            this.img_prioridade.Location = new System.Drawing.Point(38, 17);
            this.img_prioridade.Name = "img_prioridade";
            this.img_prioridade.Size = new System.Drawing.Size(20, 20);
            this.img_prioridade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_prioridade.TabIndex = 27;
            this.img_prioridade.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Detalhes sobre a solicitação";
            // 
            // cx_Subcategoria
            // 
            this.cx_Subcategoria.BackColor = System.Drawing.SystemColors.Info;
            this.cx_Subcategoria.Enabled = false;
            this.cx_Subcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_Subcategoria.Location = new System.Drawing.Point(9, 237);
            this.cx_Subcategoria.MaxLength = 20;
            this.cx_Subcategoria.Name = "cx_Subcategoria";
            this.cx_Subcategoria.ReadOnly = true;
            this.cx_Subcategoria.Size = new System.Drawing.Size(333, 21);
            this.cx_Subcategoria.TabIndex = 29;
            this.cx_Subcategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx_help
            // 
            this.cx_help.BackColor = System.Drawing.SystemColors.Info;
            this.cx_help.Enabled = false;
            this.cx_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_help.Location = new System.Drawing.Point(9, 157);
            this.cx_help.MaxLength = 20;
            this.cx_help.Name = "cx_help";
            this.cx_help.ReadOnly = true;
            this.cx_help.Size = new System.Drawing.Size(333, 21);
            this.cx_help.TabIndex = 28;
            this.cx_help.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx_categoria
            // 
            this.cx_categoria.BackColor = System.Drawing.SystemColors.Info;
            this.cx_categoria.Enabled = false;
            this.cx_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_categoria.Location = new System.Drawing.Point(9, 198);
            this.cx_categoria.MaxLength = 20;
            this.cx_categoria.Name = "cx_categoria";
            this.cx_categoria.ReadOnly = true;
            this.cx_categoria.Size = new System.Drawing.Size(333, 21);
            this.cx_categoria.TabIndex = 27;
            this.cx_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx_provedor
            // 
            this.cx_provedor.BackColor = System.Drawing.SystemColors.Info;
            this.cx_provedor.Enabled = false;
            this.cx_provedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_provedor.Location = new System.Drawing.Point(125, 35);
            this.cx_provedor.MaxLength = 20;
            this.cx_provedor.Name = "cx_provedor";
            this.cx_provedor.ReadOnly = true;
            this.cx_provedor.Size = new System.Drawing.Size(217, 21);
            this.cx_provedor.TabIndex = 26;
            this.cx_provedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Enabled = false;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(235, 474);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(112, 38);
            this.bt_cancelar.TabIndex = 11;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label54.Location = new System.Drawing.Point(9, 138);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(128, 16);
            this.label54.TabIndex = 25;
            this.label54.Text = "Técnico - HelpDesk";
            // 
            // bt_finalizar
            // 
            this.bt_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_finalizar.Enabled = false;
            this.bt_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_finalizar.Image = global::NDM_SoftwareV5.Properties.Resources.gravar;
            this.bt_finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_finalizar.Location = new System.Drawing.Point(12, 474);
            this.bt_finalizar.Name = "bt_finalizar";
            this.bt_finalizar.Size = new System.Drawing.Size(129, 38);
            this.bt_finalizar.TabIndex = 10;
            this.bt_finalizar.Text = "Aceitar";
            this.bt_finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_finalizar.UseVisualStyleBackColor = false;
            this.bt_finalizar.Click += new System.EventHandler(this.bt_finalizar_Click);
            // 
            // cx_solicitado
            // 
            this.cx_solicitado.BackColor = System.Drawing.SystemColors.Info;
            this.cx_solicitado.Enabled = false;
            this.cx_solicitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_solicitado.Location = new System.Drawing.Point(9, 73);
            this.cx_solicitado.MaxLength = 20;
            this.cx_solicitado.Name = "cx_solicitado";
            this.cx_solicitado.ReadOnly = true;
            this.cx_solicitado.Size = new System.Drawing.Size(181, 21);
            this.cx_solicitado.TabIndex = 0;
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
            this.cx_obs.BackColor = System.Drawing.SystemColors.Info;
            this.cx_obs.Enabled = false;
            this.cx_obs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cx_obs.Location = new System.Drawing.Point(12, 277);
            this.cx_obs.MaxLength = 180;
            this.cx_obs.Multiline = true;
            this.cx_obs.Name = "cx_obs";
            this.cx_obs.Size = new System.Drawing.Size(335, 197);
            this.cx_obs.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(9, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Atendimento realizado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(9, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tipo de atendimento";
            // 
            // cx_nomeCliente
            // 
            this.cx_nomeCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_nomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_nomeCliente.Enabled = false;
            this.cx_nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_nomeCliente.ForeColor = System.Drawing.Color.Red;
            this.cx_nomeCliente.Location = new System.Drawing.Point(81, 114);
            this.cx_nomeCliente.MaxLength = 80;
            this.cx_nomeCliente.Name = "cx_nomeCliente";
            this.cx_nomeCliente.ReadOnly = true;
            this.cx_nomeCliente.Size = new System.Drawing.Size(261, 20);
            this.cx_nomeCliente.TabIndex = 2;
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
            this.cx_codCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cx_codCliente.Enabled = false;
            this.cx_codCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_codCliente.ForeColor = System.Drawing.Color.Red;
            this.cx_codCliente.Location = new System.Drawing.Point(9, 114);
            this.cx_codCliente.MaxLength = 7;
            this.cx_codCliente.Name = "cx_codCliente";
            this.cx_codCliente.ReadOnly = true;
            this.cx_codCliente.Size = new System.Drawing.Size(63, 22);
            this.cx_codCliente.TabIndex = 1;
            this.cx_codCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(122, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Base Provedor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Data Solicitação";
            // 
            // cx_dataHora
            // 
            this.cx_dataHora.BackColor = System.Drawing.SystemColors.Info;
            this.cx_dataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_dataHora.Location = new System.Drawing.Point(9, 34);
            this.cx_dataHora.Mask = "00/00/0000";
            this.cx_dataHora.Name = "cx_dataHora";
            this.cx_dataHora.ReadOnly = true;
            this.cx_dataHora.Size = new System.Drawing.Size(107, 21);
            this.cx_dataHora.TabIndex = 0;
            this.cx_dataHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cx_dataHora.ValidatingType = typeof(System.DateTime);
            // 
            // frm_inf_atendimento_solicitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_inf_atendimento_solicitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - { HelpDesk - Solicitação } ::...";
            this.Load += new System.EventHandler(this.frm_inf_atendimento_solicitado_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_atendimento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_prioridade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_qtd_atendimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button bt_finalizar;
        private System.Windows.Forms.TextBox cx_solicitado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cx_obs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cx_nomeCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cx_codCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox cx_dataHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cx_Subcategoria;
        private System.Windows.Forms.TextBox cx_help;
        private System.Windows.Forms.TextBox cx_categoria;
        private System.Windows.Forms.TextBox cx_provedor;
        private System.Windows.Forms.Label lbl_prioridade;
        private System.Windows.Forms.PictureBox img_prioridade;
        private System.Windows.Forms.DataGridView mostra_atendimento;
    }
}