namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class frm_lista_produto_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lista_produto_estoque));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.cx_texto = new System.Windows.Forms.TextBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mostra_estoque = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.bt_procurar);
            this.groupBox1.Controls.Add(this.cx_texto);
            this.groupBox1.Controls.Add(this.cb_categoria);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(4, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // bt_procurar
            // 
            this.bt_procurar.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_procurar.Location = new System.Drawing.Point(526, 8);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(46, 46);
            this.bt_procurar.TabIndex = 44;
            this.bt_procurar.UseVisualStyleBackColor = true;
            this.bt_procurar.Click += new System.EventHandler(this.bt_procurar_Click);
            // 
            // cx_texto
            // 
            this.cx_texto.Location = new System.Drawing.Point(221, 19);
            this.cx_texto.Name = "cx_texto";
            this.cx_texto.Size = new System.Drawing.Size(299, 20);
            this.cx_texto.TabIndex = 43;
            this.cx_texto.TextChanged += new System.EventHandler(this.cx_texto_TextChanged);
            // 
            // cb_categoria
            // 
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "",
            "CATEGORIA",
            "SUBCATEGORIA",
            "CÓD. INTERNO",
            "CÓD. EXTERNO",
            "FORNECEDOR",
            "DESCRIÇÃO"});
            this.cb_categoria.Location = new System.Drawing.Point(60, 19);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(155, 21);
            this.cb_categoria.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Buscar por:";
            // 
            // mostra_estoque
            // 
            this.mostra_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mostra_estoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostra_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostra_estoque.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mostra_estoque.Location = new System.Drawing.Point(4, 59);
            this.mostra_estoque.MultiSelect = false;
            this.mostra_estoque.Name = "mostra_estoque";
            this.mostra_estoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostra_estoque.Size = new System.Drawing.Size(576, 269);
            this.mostra_estoque.TabIndex = 1;
            this.mostra_estoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mostra_estoque_CellDoubleClick);
            // 
            // frm_lista_produto_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 332);
            this.Controls.Add(this.mostra_estoque);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_lista_produto_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - { Lista de Produtos } ::...";
            this.Load += new System.EventHandler(this.frm_lista_produto_estoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_estoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView mostra_estoque;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.TextBox cx_texto;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label15;
    }
}