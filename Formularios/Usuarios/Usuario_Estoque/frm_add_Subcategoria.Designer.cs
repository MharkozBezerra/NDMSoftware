namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class frm_add_Subcategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_Subcategoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_base_descricao = new System.Windows.Forms.Label();
            this.dg_mostrar_categoria = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.bt_cancelar_ADD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_salvar_ADD = new System.Windows.Forms.Button();
            this.cx_descricao_ADD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_categoria_ID = new System.Windows.Forms.ComboBox();
            this.cb_proverdor_ID = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cx_desc_antiga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_categoria_UPDATE = new System.Windows.Forms.ComboBox();
            this.dg_mostra_Up = new System.Windows.Forms.DataGridView();
            this.cb_provedor_Update_ID = new System.Windows.Forms.ComboBox();
            this.cb_categoria_UPDATE_ID = new System.Windows.Forms.ComboBox();
            this.cx_desc_nova = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar_categoria)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_Up)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 453);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cb_categoria_ID);
            this.tabPage1.Controls.Add(this.cb_proverdor_ID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Subcategoria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_base_descricao);
            this.groupBox1.Controls.Add(this.dg_mostrar_categoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_categoria);
            this.groupBox1.Controls.Add(this.bt_cancelar_ADD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_salvar_ADD);
            this.groupBox1.Controls.Add(this.cx_descricao_ADD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_base_descricao
            // 
            this.lbl_base_descricao.AutoSize = true;
            this.lbl_base_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_base_descricao.Location = new System.Drawing.Point(129, 13);
            this.lbl_base_descricao.Name = "lbl_base_descricao";
            this.lbl_base_descricao.Size = new System.Drawing.Size(32, 16);
            this.lbl_base_descricao.TabIndex = 12;
            this.lbl_base_descricao.Text = "???";
            // 
            // dg_mostrar_categoria
            // 
            this.dg_mostrar_categoria.AllowUserToAddRows = false;
            this.dg_mostrar_categoria.AllowUserToDeleteRows = false;
            this.dg_mostrar_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostrar_categoria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_mostrar_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostrar_categoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostrar_categoria.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_mostrar_categoria.Location = new System.Drawing.Point(6, 85);
            this.dg_mostrar_categoria.MultiSelect = false;
            this.dg_mostrar_categoria.Name = "dg_mostrar_categoria";
            this.dg_mostrar_categoria.ReadOnly = true;
            this.dg_mostrar_categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostrar_categoria.Size = new System.Drawing.Size(481, 329);
            this.dg_mostrar_categoria.TabIndex = 1;
            this.dg_mostrar_categoria.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_mostrar_categoria_CellMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categoria:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(132, 34);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(261, 21);
            this.cb_categoria.TabIndex = 10;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_SelectedIndexChanged);
            // 
            // bt_cancelar_ADD
            // 
            this.bt_cancelar_ADD.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar_ADD.Location = new System.Drawing.Point(400, 46);
            this.bt_cancelar_ADD.Name = "bt_cancelar_ADD";
            this.bt_cancelar_ADD.Size = new System.Drawing.Size(87, 30);
            this.bt_cancelar_ADD.TabIndex = 6;
            this.bt_cancelar_ADD.Text = "Cancelar";
            this.bt_cancelar_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar_ADD.UseVisualStyleBackColor = true;
            this.bt_cancelar_ADD.Click += new System.EventHandler(this.bt_cancelar_ADD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base:";
            // 
            // bt_salvar_ADD
            // 
            this.bt_salvar_ADD.Enabled = false;
            this.bt_salvar_ADD.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_salvar_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salvar_ADD.Location = new System.Drawing.Point(400, 13);
            this.bt_salvar_ADD.Name = "bt_salvar_ADD";
            this.bt_salvar_ADD.Size = new System.Drawing.Size(87, 30);
            this.bt_salvar_ADD.TabIndex = 4;
            this.bt_salvar_ADD.Text = "Salvar";
            this.bt_salvar_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salvar_ADD.UseVisualStyleBackColor = true;
            this.bt_salvar_ADD.Click += new System.EventHandler(this.bt_salvar_ADD_Click);
            // 
            // cx_descricao_ADD
            // 
            this.cx_descricao_ADD.Location = new System.Drawing.Point(132, 59);
            this.cx_descricao_ADD.MaxLength = 50;
            this.cx_descricao_ADD.Name = "cx_descricao_ADD";
            this.cx_descricao_ADD.Size = new System.Drawing.Size(261, 20);
            this.cx_descricao_ADD.TabIndex = 3;
            this.cx_descricao_ADD.TextChanged += new System.EventHandler(this.cx_descricao_ADD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nova Subcategoria:";
            // 
            // cb_categoria_ID
            // 
            this.cb_categoria_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categoria_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria_ID.FormattingEnabled = true;
            this.cb_categoria_ID.Location = new System.Drawing.Point(323, 186);
            this.cb_categoria_ID.Name = "cb_categoria_ID";
            this.cb_categoria_ID.Size = new System.Drawing.Size(64, 21);
            this.cb_categoria_ID.TabIndex = 9;
            // 
            // cb_proverdor_ID
            // 
            this.cb_proverdor_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_proverdor_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_proverdor_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_proverdor_ID.FormattingEnabled = true;
            this.cb_proverdor_ID.Location = new System.Drawing.Point(323, 164);
            this.cb_proverdor_ID.Name = "cb_proverdor_ID";
            this.cb_proverdor_ID.Size = new System.Drawing.Size(64, 21);
            this.cb_proverdor_ID.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cx_desc_antiga);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.cx_desc_nova);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.bt_alterar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Subcategoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subcategoria Atual:";
            // 
            // cx_desc_antiga
            // 
            this.cx_desc_antiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_desc_antiga.Location = new System.Drawing.Point(107, 373);
            this.cx_desc_antiga.Name = "cx_desc_antiga";
            this.cx_desc_antiga.ReadOnly = true;
            this.cx_desc_antiga.Size = new System.Drawing.Size(301, 21);
            this.cx_desc_antiga.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subcategoria Nova:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.cb_categoria_UPDATE);
            this.groupBox2.Controls.Add(this.dg_mostra_Up);
            this.groupBox2.Controls.Add(this.cb_provedor_Update_ID);
            this.groupBox2.Controls.Add(this.cb_categoria_UPDATE_ID);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 351);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.button1.Location = new System.Drawing.Point(406, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 44);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Categoria:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(144, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(257, 21);
            this.textBox1.TabIndex = 10;
            // 
            // cb_categoria_UPDATE
            // 
            this.cb_categoria_UPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categoria_UPDATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria_UPDATE.FormattingEnabled = true;
            this.cb_categoria_UPDATE.Location = new System.Drawing.Point(144, 14);
            this.cb_categoria_UPDATE.Name = "cb_categoria_UPDATE";
            this.cb_categoria_UPDATE.Size = new System.Drawing.Size(257, 21);
            this.cb_categoria_UPDATE.TabIndex = 10;
            // 
            // dg_mostra_Up
            // 
            this.dg_mostra_Up.AllowUserToAddRows = false;
            this.dg_mostra_Up.AllowUserToDeleteRows = false;
            this.dg_mostra_Up.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_Up.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_mostra_Up.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_Up.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_Up.GridColor = System.Drawing.SystemColors.Control;
            this.dg_mostra_Up.Location = new System.Drawing.Point(6, 59);
            this.dg_mostra_Up.MultiSelect = false;
            this.dg_mostra_Up.Name = "dg_mostra_Up";
            this.dg_mostra_Up.ReadOnly = true;
            this.dg_mostra_Up.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_Up.ShowCellErrors = false;
            this.dg_mostra_Up.ShowCellToolTips = false;
            this.dg_mostra_Up.ShowEditingIcon = false;
            this.dg_mostra_Up.ShowRowErrors = false;
            this.dg_mostra_Up.Size = new System.Drawing.Size(481, 286);
            this.dg_mostra_Up.TabIndex = 3;
            this.dg_mostra_Up.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_mostra_Up_CellMouseClick);
            // 
            // cb_provedor_Update_ID
            // 
            this.cb_provedor_Update_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_provedor_Update_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provedor_Update_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_provedor_Update_ID.FormattingEnabled = true;
            this.cb_provedor_Update_ID.Location = new System.Drawing.Point(352, 78);
            this.cb_provedor_Update_ID.Name = "cb_provedor_Update_ID";
            this.cb_provedor_Update_ID.Size = new System.Drawing.Size(90, 21);
            this.cb_provedor_Update_ID.TabIndex = 6;
            // 
            // cb_categoria_UPDATE_ID
            // 
            this.cb_categoria_UPDATE_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categoria_UPDATE_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria_UPDATE_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria_UPDATE_ID.FormattingEnabled = true;
            this.cb_categoria_UPDATE_ID.Location = new System.Drawing.Point(375, 74);
            this.cb_categoria_UPDATE_ID.Name = "cb_categoria_UPDATE_ID";
            this.cb_categoria_UPDATE_ID.Size = new System.Drawing.Size(67, 21);
            this.cb_categoria_UPDATE_ID.TabIndex = 12;
            // 
            // cx_desc_nova
            // 
            this.cx_desc_nova.Location = new System.Drawing.Point(107, 397);
            this.cx_desc_nova.MaxLength = 50;
            this.cx_desc_nova.Name = "cx_desc_nova";
            this.cx_desc_nova.ReadOnly = true;
            this.cx_desc_nova.Size = new System.Drawing.Size(301, 20);
            this.cx_desc_nova.TabIndex = 3;
            this.cx_desc_nova.TextChanged += new System.EventHandler(this.cx_desc_nova_TextChanged);
            // 
            // button3
            // 
            this.button3.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(413, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Enabled = false;
            this.bt_alterar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_alterar.Location = new System.Drawing.Point(413, 364);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(87, 30);
            this.bt_alterar.TabIndex = 4;
            this.bt_alterar.Text = "Editar";
            this.bt_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // frm_add_Subcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 464);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_add_Subcategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - { Subcategorias } ::...";
            this.Load += new System.EventHandler(this.frm_ADD_Subcategoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar_categoria)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_Up)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dg_mostrar_categoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_cancelar_ADD;
        private System.Windows.Forms.Button bt_salvar_ADD;
        private System.Windows.Forms.TextBox cx_descricao_ADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_proverdor_ID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cx_desc_antiga;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_mostra_Up;
        private System.Windows.Forms.ComboBox cb_provedor_Update_ID;
        private System.Windows.Forms.TextBox cx_desc_nova;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.ComboBox cb_categoria_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_categoria_UPDATE;
        private System.Windows.Forms.ComboBox cb_categoria_UPDATE_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_base_descricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}