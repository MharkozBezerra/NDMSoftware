namespace NDM_SoftwareV5.Formularios.Administrador
{
    partial class frm_empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empresa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_empresa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cx_descricao_filial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dg_filial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grupo_empresa = new System.Windows.Forms.GroupBox();
            this.bt_alterar_empresa = new System.Windows.Forms.Button();
            this.bt_incluir_empresa = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_alterar_filial = new System.Windows.Forms.Button();
            this.bt_incluir_filial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_empresa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_filial)).BeginInit();
            this.grupo_empresa.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_empresa);
            this.groupBox1.Location = new System.Drawing.Point(4, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dg_empresa
            // 
            this.dg_empresa.AllowUserToAddRows = false;
            this.dg_empresa.AllowUserToDeleteRows = false;
            this.dg_empresa.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_empresa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_empresa.Location = new System.Drawing.Point(6, 9);
            this.dg_empresa.MultiSelect = false;
            this.dg_empresa.Name = "dg_empresa";
            this.dg_empresa.ReadOnly = true;
            this.dg_empresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_empresa.Size = new System.Drawing.Size(531, 85);
            this.dg_empresa.TabIndex = 5;
            this.dg_empresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_empresa_CellDoubleClick);
            this.dg_empresa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_empresa_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cx_descricao_filial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dg_filial);
            this.groupBox2.Location = new System.Drawing.Point(4, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cx_descricao_filial
            // 
            this.cx_descricao_filial.BackColor = System.Drawing.SystemColors.Info;
            this.cx_descricao_filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_descricao_filial.Location = new System.Drawing.Point(6, 154);
            this.cx_descricao_filial.Multiline = true;
            this.cx_descricao_filial.Name = "cx_descricao_filial";
            this.cx_descricao_filial.ReadOnly = true;
            this.cx_descricao_filial.Size = new System.Drawing.Size(531, 155);
            this.cx_descricao_filial.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(3, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Observações:";
            // 
            // dg_filial
            // 
            this.dg_filial.AllowUserToAddRows = false;
            this.dg_filial.AllowUserToDeleteRows = false;
            this.dg_filial.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_filial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_filial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_filial.Location = new System.Drawing.Point(6, 13);
            this.dg_filial.MultiSelect = false;
            this.dg_filial.Name = "dg_filial";
            this.dg_filial.ReadOnly = true;
            this.dg_filial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_filial.Size = new System.Drawing.Size(531, 119);
            this.dg_filial.TabIndex = 2;
            this.dg_filial.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_filial_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa / Matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filial / Base";
            // 
            // grupo_empresa
            // 
            this.grupo_empresa.Controls.Add(this.bt_alterar_empresa);
            this.grupo_empresa.Controls.Add(this.bt_incluir_empresa);
            this.grupo_empresa.Location = new System.Drawing.Point(553, 21);
            this.grupo_empresa.Name = "grupo_empresa";
            this.grupo_empresa.Size = new System.Drawing.Size(100, 100);
            this.grupo_empresa.TabIndex = 2;
            this.grupo_empresa.TabStop = false;
            // 
            // bt_alterar_empresa
            // 
            this.bt_alterar_empresa.Enabled = false;
            this.bt_alterar_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_alterar_empresa.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_alterar_empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_alterar_empresa.Location = new System.Drawing.Point(4, 52);
            this.bt_alterar_empresa.Name = "bt_alterar_empresa";
            this.bt_alterar_empresa.Size = new System.Drawing.Size(92, 39);
            this.bt_alterar_empresa.TabIndex = 1;
            this.bt_alterar_empresa.Text = "Alterar";
            this.bt_alterar_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_alterar_empresa.UseVisualStyleBackColor = true;
            this.bt_alterar_empresa.Click += new System.EventHandler(this.bt_alterar_empresa_Click);
            // 
            // bt_incluir_empresa
            // 
            this.bt_incluir_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_incluir_empresa.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.bt_incluir_empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_incluir_empresa.Location = new System.Drawing.Point(4, 12);
            this.bt_incluir_empresa.Name = "bt_incluir_empresa";
            this.bt_incluir_empresa.Size = new System.Drawing.Size(92, 39);
            this.bt_incluir_empresa.TabIndex = 0;
            this.bt_incluir_empresa.Text = "Incluir";
            this.bt_incluir_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_incluir_empresa.UseVisualStyleBackColor = true;
            this.bt_incluir_empresa.Click += new System.EventHandler(this.bt_incluir_empresa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_alterar_filial);
            this.groupBox4.Controls.Add(this.bt_incluir_filial);
            this.groupBox4.Location = new System.Drawing.Point(553, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 317);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // bt_alterar_filial
            // 
            this.bt_alterar_filial.Enabled = false;
            this.bt_alterar_filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_alterar_filial.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_alterar_filial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_alterar_filial.Location = new System.Drawing.Point(4, 53);
            this.bt_alterar_filial.Name = "bt_alterar_filial";
            this.bt_alterar_filial.Size = new System.Drawing.Size(92, 39);
            this.bt_alterar_filial.TabIndex = 3;
            this.bt_alterar_filial.Text = "Alterar";
            this.bt_alterar_filial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_alterar_filial.UseVisualStyleBackColor = true;
            this.bt_alterar_filial.Click += new System.EventHandler(this.bt_alterar_filial_Click);
            // 
            // bt_incluir_filial
            // 
            this.bt_incluir_filial.Enabled = false;
            this.bt_incluir_filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_incluir_filial.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.bt_incluir_filial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_incluir_filial.Location = new System.Drawing.Point(4, 13);
            this.bt_incluir_filial.Name = "bt_incluir_filial";
            this.bt_incluir_filial.Size = new System.Drawing.Size(92, 39);
            this.bt_incluir_filial.TabIndex = 2;
            this.bt_incluir_filial.Text = "Incluir";
            this.bt_incluir_filial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_incluir_filial.UseVisualStyleBackColor = true;
            this.bt_incluir_filial.Click += new System.EventHandler(this.bt_incluir_filial_Click);
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 459);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grupo_empresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NDM-Software [ Empresa ]";
            this.Load += new System.EventHandler(this.frm_empresa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_empresa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_filial)).EndInit();
            this.grupo_empresa.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_empresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cx_descricao_filial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dg_filial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupo_empresa;
        private System.Windows.Forms.Button bt_incluir_empresa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_alterar_empresa;
        private System.Windows.Forms.Button bt_alterar_filial;
        private System.Windows.Forms.Button bt_incluir_filial;
    }
}