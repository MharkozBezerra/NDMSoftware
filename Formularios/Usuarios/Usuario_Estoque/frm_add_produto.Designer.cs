namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class frm_add_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_produto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cx_cod_interno = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.cx_valor = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_unidade_medidas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cx_descricao_produto = new System.Windows.Forms.TextBox();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cx_cod_externo = new System.Windows.Forms.TextBox();
            this.cb_subcategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_filial_descricao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_mostra_produto = new System.Windows.Forms.DataGridView();
            this.bt_remover = new System.Windows.Forms.Button();
            this.chk_aluguel = new System.Windows.Forms.CheckBox();
            this.lbl_aluguel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.chk_aluguel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cx_cod_interno);
            this.groupBox1.Controls.Add(this.bt_salvar);
            this.groupBox1.Controls.Add(this.cx_valor);
            this.groupBox1.Controls.Add(this.bt_cancelar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_unidade_medidas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cx_descricao_produto);
            this.groupBox1.Controls.Add(this.cb_fornecedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cx_cod_externo);
            this.groupBox1.Controls.Add(this.cb_subcategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_categoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Código Interno";
            // 
            // cx_cod_interno
            // 
            this.cx_cod_interno.Location = new System.Drawing.Point(6, 170);
            this.cx_cod_interno.Name = "cx_cod_interno";
            this.cx_cod_interno.Size = new System.Drawing.Size(303, 22);
            this.cx_cod_interno.TabIndex = 6;
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_salvar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salvar.Location = new System.Drawing.Point(321, 215);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(111, 38);
            this.bt_salvar.TabIndex = 9;
            this.bt_salvar.Text = "Gravar";
            this.bt_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // cx_valor
            // 
            this.cx_valor.BackColor = System.Drawing.SystemColors.Info;
            this.cx_valor.Location = new System.Drawing.Point(315, 170);
            this.cx_valor.Name = "cx_valor";
            this.cx_valor.Size = new System.Drawing.Size(117, 22);
            this.cx_valor.TabIndex = 7;
            this.cx_valor.Leave += new System.EventHandler(this.cx_valor_Leave);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(321, 255);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(111, 38);
            this.bt_cancelar.TabIndex = 10;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor:";
            // 
            // cb_unidade_medidas
            // 
            this.cb_unidade_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_unidade_medidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_unidade_medidas.FormattingEnabled = true;
            this.cb_unidade_medidas.Location = new System.Drawing.Point(222, 78);
            this.cb_unidade_medidas.Name = "cb_unidade_medidas";
            this.cb_unidade_medidas.Size = new System.Drawing.Size(210, 24);
            this.cb_unidade_medidas.TabIndex = 4;
            this.cb_unidade_medidas.SelectedIndexChanged += new System.EventHandler(this.cb_unidade_medidas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descrição do Produto";
            // 
            // cx_descricao_produto
            // 
            this.cx_descricao_produto.Location = new System.Drawing.Point(6, 215);
            this.cx_descricao_produto.Multiline = true;
            this.cx_descricao_produto.Name = "cx_descricao_produto";
            this.cx_descricao_produto.Size = new System.Drawing.Size(303, 92);
            this.cx_descricao_produto.TabIndex = 8;
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(6, 78);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(209, 24);
            this.cb_fornecedor.TabIndex = 3;
            this.cb_fornecedor.SelectedIndexChanged += new System.EventHandler(this.cb_fornecedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Externo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fornecedor";
            // 
            // cx_cod_externo
            // 
            this.cx_cod_externo.Location = new System.Drawing.Point(6, 125);
            this.cx_cod_externo.Name = "cx_cod_externo";
            this.cx_cod_externo.Size = new System.Drawing.Size(426, 22);
            this.cx_cod_externo.TabIndex = 5;
            // 
            // cb_subcategoria
            // 
            this.cb_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_subcategoria.FormattingEnabled = true;
            this.cb_subcategoria.Location = new System.Drawing.Point(222, 31);
            this.cb_subcategoria.Name = "cb_subcategoria";
            this.cb_subcategoria.Size = new System.Drawing.Size(210, 24);
            this.cb_subcategoria.TabIndex = 2;
            this.cb_subcategoria.SelectedIndexChanged += new System.EventHandler(this.cb_subcategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subcategoria";
            // 
            // cb_categoria
            // 
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(6, 31);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(209, 24);
            this.cb_categoria.TabIndex = 1;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // cb_filial_descricao
            // 
            this.cb_filial_descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filial_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filial_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_filial_descricao.FormattingEnabled = true;
            this.cb_filial_descricao.Location = new System.Drawing.Point(54, 4);
            this.cb_filial_descricao.Name = "cb_filial_descricao";
            this.cb_filial_descricao.Size = new System.Drawing.Size(390, 24);
            this.cb_filial_descricao.TabIndex = 0;
            this.cb_filial_descricao.SelectedIndexChanged += new System.EventHandler(this.cb_filial_descricao_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Base:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.lbl_aluguel);
            this.groupBox2.Controls.Add(this.lbl_total);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dg_mostra_produto);
            this.groupBox2.Controls.Add(this.bt_remover);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(6, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 274);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(67, 253);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(15, 16);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total de Itens";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dg_mostra_produto
            // 
            this.dg_mostra_produto.AllowUserToAddRows = false;
            this.dg_mostra_produto.AllowUserToDeleteRows = false;
            this.dg_mostra_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra_produto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_mostra_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra_produto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_mostra_produto.Location = new System.Drawing.Point(6, 11);
            this.dg_mostra_produto.MultiSelect = false;
            this.dg_mostra_produto.Name = "dg_mostra_produto";
            this.dg_mostra_produto.ReadOnly = true;
            this.dg_mostra_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mostra_produto.Size = new System.Drawing.Size(426, 223);
            this.dg_mostra_produto.TabIndex = 11;
            this.dg_mostra_produto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_mostra_produto_CellMouseClick);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_remover.Enabled = false;
            this.bt_remover.Image = global::NDM_SoftwareV5.Properties.Resources.excluir;
            this.bt_remover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_remover.Location = new System.Drawing.Point(321, 234);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(111, 38);
            this.bt_remover.TabIndex = 12;
            this.bt_remover.Text = "Remover";
            this.bt_remover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // chk_aluguel
            // 
            this.chk_aluguel.AutoSize = true;
            this.chk_aluguel.Location = new System.Drawing.Point(197, 149);
            this.chk_aluguel.Name = "chk_aluguel";
            this.chk_aluguel.Size = new System.Drawing.Size(112, 20);
            this.chk_aluguel.TabIndex = 19;
            this.chk_aluguel.Text = "Não Alugavel.";
            this.chk_aluguel.UseVisualStyleBackColor = true;
            this.chk_aluguel.CheckedChanged += new System.EventHandler(this.chk_aluguel_CheckedChanged);
            // 
            // lbl_aluguel
            // 
            this.lbl_aluguel.AutoSize = true;
            this.lbl_aluguel.Location = new System.Drawing.Point(137, 237);
            this.lbl_aluguel.Name = "lbl_aluguel";
            this.lbl_aluguel.Size = new System.Drawing.Size(132, 16);
            this.lbl_aluguel.TabIndex = 20;
            this.lbl_aluguel.Text = "Item Alugavel [ Não ]";
            this.lbl_aluguel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_add_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 629);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_filial_descricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Estoque-Add.Produto } ::...";
            this.Load += new System.EventHandler(this.frm_add_produto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cx_valor;
        private System.Windows.Forms.ComboBox cb_unidade_medidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cx_descricao_produto;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cx_cod_externo;
        private System.Windows.Forms.ComboBox cb_filial_descricao;
        private System.Windows.Forms.ComboBox cb_subcategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dg_mostra_produto;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cx_cod_interno;
        private System.Windows.Forms.CheckBox chk_aluguel;
        private System.Windows.Forms.Label lbl_aluguel;
    }
}