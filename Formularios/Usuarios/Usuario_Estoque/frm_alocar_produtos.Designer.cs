namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class frm_alocar_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alocar_produtos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_alocar = new System.Windows.Forms.Button();
            this.cx_localizacao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cx_qtd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cx_entrada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cx_unidade = new System.Windows.Forms.TextBox();
            this.cx_fornecedor = new System.Windows.Forms.TextBox();
            this.cx_subcategoria = new System.Windows.Forms.TextBox();
            this.cx_categoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cx_cod_interno = new System.Windows.Forms.TextBox();
            this.cx_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cx_descricao_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cx_cod_externo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mostra_produtos = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cx_unidade);
            this.groupBox2.Controls.Add(this.cx_fornecedor);
            this.groupBox2.Controls.Add(this.cx_subcategoria);
            this.groupBox2.Controls.Add(this.cx_categoria);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cx_cod_interno);
            this.groupBox2.Controls.Add(this.cx_valor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cx_descricao_produto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cx_cod_externo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 185);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.bt_alocar);
            this.groupBox3.Controls.Add(this.cx_localizacao);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbl_data);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cx_qtd);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cx_entrada);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(294, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 78);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // bt_alocar
            // 
            this.bt_alocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_alocar.Enabled = false;
            this.bt_alocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alocar.Image = global::NDM_SoftwareV5.Properties.Resources.icone_alocar_produto_cor;
            this.bt_alocar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_alocar.Location = new System.Drawing.Point(253, 11);
            this.bt_alocar.Name = "bt_alocar";
            this.bt_alocar.Size = new System.Drawing.Size(102, 64);
            this.bt_alocar.TabIndex = 47;
            this.bt_alocar.Text = "Alocar Produto";
            this.bt_alocar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_alocar.UseVisualStyleBackColor = false;
            this.bt_alocar.Click += new System.EventHandler(this.bt_alocar_Click);
            // 
            // cx_localizacao
            // 
            this.cx_localizacao.BackColor = System.Drawing.SystemColors.Info;
            this.cx_localizacao.Location = new System.Drawing.Point(78, 55);
            this.cx_localizacao.Name = "cx_localizacao";
            this.cx_localizacao.Size = new System.Drawing.Size(166, 20);
            this.cx_localizacao.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Localização:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(179, 30);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(65, 13);
            this.lbl_data.TabIndex = 46;
            this.lbl_data.Text = "00/00/0000";
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(157, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Locação Estoque";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cx_qtd
            // 
            this.cx_qtd.BackColor = System.Drawing.SystemColors.Info;
            this.cx_qtd.Location = new System.Drawing.Point(76, 33);
            this.cx_qtd.Name = "cx_qtd";
            this.cx_qtd.ReadOnly = true;
            this.cx_qtd.Size = new System.Drawing.Size(76, 20);
            this.cx_qtd.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Estoque ->";
            // 
            // cx_entrada
            // 
            this.cx_entrada.BackColor = System.Drawing.SystemColors.Info;
            this.cx_entrada.Location = new System.Drawing.Point(76, 11);
            this.cx_entrada.Name = "cx_entrada";
            this.cx_entrada.Size = new System.Drawing.Size(76, 20);
            this.cx_entrada.TabIndex = 39;
            this.cx_entrada.Leave += new System.EventHandler(this.cx_entrada_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Entradas ( + ):";
            // 
            // cx_unidade
            // 
            this.cx_unidade.BackColor = System.Drawing.SystemColors.Control;
            this.cx_unidade.Location = new System.Drawing.Point(439, 68);
            this.cx_unidade.Name = "cx_unidade";
            this.cx_unidade.ReadOnly = true;
            this.cx_unidade.Size = new System.Drawing.Size(90, 20);
            this.cx_unidade.TabIndex = 38;
            // 
            // cx_fornecedor
            // 
            this.cx_fornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.cx_fornecedor.Location = new System.Drawing.Point(439, 29);
            this.cx_fornecedor.Name = "cx_fornecedor";
            this.cx_fornecedor.ReadOnly = true;
            this.cx_fornecedor.Size = new System.Drawing.Size(210, 20);
            this.cx_fornecedor.TabIndex = 37;
            // 
            // cx_subcategoria
            // 
            this.cx_subcategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cx_subcategoria.Location = new System.Drawing.Point(221, 29);
            this.cx_subcategoria.Name = "cx_subcategoria";
            this.cx_subcategoria.ReadOnly = true;
            this.cx_subcategoria.Size = new System.Drawing.Size(211, 20);
            this.cx_subcategoria.TabIndex = 36;
            // 
            // cx_categoria
            // 
            this.cx_categoria.BackColor = System.Drawing.SystemColors.Control;
            this.cx_categoria.Location = new System.Drawing.Point(9, 29);
            this.cx_categoria.Name = "cx_categoria";
            this.cx_categoria.ReadOnly = true;
            this.cx_categoria.Size = new System.Drawing.Size(206, 20);
            this.cx_categoria.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Código Interno";
            // 
            // cx_cod_interno
            // 
            this.cx_cod_interno.BackColor = System.Drawing.SystemColors.Control;
            this.cx_cod_interno.Location = new System.Drawing.Point(221, 68);
            this.cx_cod_interno.Name = "cx_cod_interno";
            this.cx_cod_interno.ReadOnly = true;
            this.cx_cod_interno.Size = new System.Drawing.Size(211, 20);
            this.cx_cod_interno.TabIndex = 27;
            // 
            // cx_valor
            // 
            this.cx_valor.BackColor = System.Drawing.SystemColors.Info;
            this.cx_valor.Location = new System.Drawing.Point(552, 68);
            this.cx_valor.Name = "cx_valor";
            this.cx_valor.ReadOnly = true;
            this.cx_valor.Size = new System.Drawing.Size(97, 20);
            this.cx_valor.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Unidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Descrição do Produto";
            // 
            // cx_descricao_produto
            // 
            this.cx_descricao_produto.BackColor = System.Drawing.SystemColors.Info;
            this.cx_descricao_produto.Location = new System.Drawing.Point(6, 107);
            this.cx_descricao_produto.Multiline = true;
            this.cx_descricao_produto.Name = "cx_descricao_produto";
            this.cx_descricao_produto.ReadOnly = true;
            this.cx_descricao_produto.Size = new System.Drawing.Size(282, 69);
            this.cx_descricao_produto.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código Externo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fornecedor";
            // 
            // cx_cod_externo
            // 
            this.cx_cod_externo.BackColor = System.Drawing.SystemColors.Control;
            this.cx_cod_externo.Location = new System.Drawing.Point(6, 68);
            this.cx_cod_externo.Name = "cx_cod_externo";
            this.cx_cod_externo.ReadOnly = true;
            this.cx_cod_externo.Size = new System.Drawing.Size(209, 20);
            this.cx_cod_externo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Subcategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categoria";
            // 
            // mostra_produtos
            // 
            this.mostra_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mostra_produtos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mostra_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostra_produtos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mostra_produtos.Location = new System.Drawing.Point(3, 5);
            this.mostra_produtos.MultiSelect = false;
            this.mostra_produtos.Name = "mostra_produtos";
            this.mostra_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostra_produtos.Size = new System.Drawing.Size(656, 270);
            this.mostra_produtos.TabIndex = 3;
            this.mostra_produtos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mostra_produtos_CellMouseClick);
            // 
            // frm_alocar_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mostra_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_alocar_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - { Estoque - Alocar} ::...";
            this.Load += new System.EventHandler(this.frm_alocar_produtos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cx_localizacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cx_qtd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cx_entrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cx_unidade;
        private System.Windows.Forms.TextBox cx_fornecedor;
        private System.Windows.Forms.TextBox cx_subcategoria;
        private System.Windows.Forms.TextBox cx_categoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cx_cod_interno;
        private System.Windows.Forms.TextBox cx_valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cx_descricao_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cx_cod_externo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView mostra_produtos;
        private System.Windows.Forms.Button bt_alocar;
    }
}