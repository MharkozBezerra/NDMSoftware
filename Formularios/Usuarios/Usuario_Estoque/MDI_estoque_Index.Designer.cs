namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque
{
    partial class MDI_estoque_index
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_estoque_index));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cad_fornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorio_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorio_estoque_entrada = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorio_estoque_saida = new System.Windows.Forms.ToolStripMenuItem();
            this.roteadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_roteador = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.menu_roteador});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(930, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cad_fornecedor,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.toolStripSeparator4});
            this.fileMenu.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(85, 20);
            this.fileMenu.Text = "&Cadastrar";
            // 
            // menu_cad_fornecedor
            // 
            this.menu_cad_fornecedor.Image = ((System.Drawing.Image)(resources.GetObject("menu_cad_fornecedor.Image")));
            this.menu_cad_fornecedor.ImageTransparentColor = System.Drawing.Color.Black;
            this.menu_cad_fornecedor.Name = "menu_cad_fornecedor";
            this.menu_cad_fornecedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menu_cad_fornecedor.Size = new System.Drawing.Size(257, 22);
            this.menu_cad_fornecedor.Text = "&Fornecedor";
            this.menu_cad_fornecedor.Click += new System.EventHandler(this.menu_cad_fornecedor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(254, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.saveToolStripMenuItem.Text = "&Prod.Categoria-Desativado";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(254, 6);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6});
            this.editMenu.Image = ((System.Drawing.Image)(resources.GetObject("editMenu.Image")));
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(77, 20);
            this.editMenu.Text = "&Estoque";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.undoToolStripMenuItem.Text = "&Estoque";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_relatorio_estoque,
            this.roteadorToolStripMenuItem});
            this.redoToolStripMenuItem.Image = global::NDM_SoftwareV5.Properties.Resources.gravar;
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.redoToolStripMenuItem.Text = "&Controle";
            // 
            // menu_relatorio_estoque
            // 
            this.menu_relatorio_estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem,
            this.relatorio_estoque_entrada,
            this.relatorio_estoque_saida});
            this.menu_relatorio_estoque.Image = global::NDM_SoftwareV5.Properties.Resources.icone_alocar_produto_cor;
            this.menu_relatorio_estoque.Name = "menu_relatorio_estoque";
            this.menu_relatorio_estoque.Size = new System.Drawing.Size(122, 22);
            this.menu_relatorio_estoque.Text = "&Estoque";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Image = global::NDM_SoftwareV5.Properties.Resources.icone_alocar_produto;
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.geralToolStripMenuItem.Text = "Geral";
            this.geralToolStripMenuItem.Click += new System.EventHandler(this.geralToolStripMenuItem_Click);
            // 
            // relatorio_estoque_entrada
            // 
            this.relatorio_estoque_entrada.Image = global::NDM_SoftwareV5.Properties.Resources.Entrada_produto;
            this.relatorio_estoque_entrada.Name = "relatorio_estoque_entrada";
            this.relatorio_estoque_entrada.Size = new System.Drawing.Size(169, 22);
            this.relatorio_estoque_entrada.Text = "Somente Entradas";
            this.relatorio_estoque_entrada.Click += new System.EventHandler(this.somenteEntradasToolStripMenuItem_Click);
            // 
            // relatorio_estoque_saida
            // 
            this.relatorio_estoque_saida.Image = global::NDM_SoftwareV5.Properties.Resources.Saida_produtos;
            this.relatorio_estoque_saida.Name = "relatorio_estoque_saida";
            this.relatorio_estoque_saida.Size = new System.Drawing.Size(169, 22);
            this.relatorio_estoque_saida.Text = "Somente Saídas";
            this.relatorio_estoque_saida.Click += new System.EventHandler(this.relatorio_estoque_saida_Click);
            // 
            // roteadorToolStripMenuItem
            // 
            this.roteadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem});
            this.roteadorToolStripMenuItem.Image = global::NDM_SoftwareV5.Properties.Resources.entrada_roteador;
            this.roteadorToolStripMenuItem.Name = "roteadorToolStripMenuItem";
            this.roteadorToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.roteadorToolStripMenuItem.Text = "Roteador";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Image = global::NDM_SoftwareV5.Properties.Resources.saida_roteador;
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(153, 6);
            // 
            // menu_roteador
            // 
            this.menu_roteador.Image = global::NDM_SoftwareV5.Properties.Resources.roteador;
            this.menu_roteador.Name = "menu_roteador";
            this.menu_roteador.Size = new System.Drawing.Size(154, 20);
            this.menu_roteador.Text = "&Aluguel de Roteadores";
            this.menu_roteador.Click += new System.EventHandler(this.menu_roteador_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 686);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(930, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDI_estoque_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(140)))));
            this.BackgroundImage = global::NDM_SoftwareV5.Properties.Resources.fundo_estoque_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 708);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDI_estoque_index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Estoque } ::...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDI_estoque_index_FormClosed);
            this.Load += new System.EventHandler(this.MDI_estoque_index_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem menu_cad_fornecedor;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_roteador;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menu_relatorio_estoque;
        private System.Windows.Forms.ToolStripMenuItem roteadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorio_estoque_entrada;
        private System.Windows.Forms.ToolStripMenuItem relatorio_estoque_saida;
    }
}



