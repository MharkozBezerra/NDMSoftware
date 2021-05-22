namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente
{
    partial class frm_MDIParent_ADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MDIParent_ADM));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_helpdesk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_subcategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_provedor = new System.Windows.Forms.ToolStripMenuItem();
            this.meu_provedor_alterar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_usuario_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_usuario_root = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorio_HelpDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorio_Geral = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somenteEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somenteSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roteadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadastrarEndereco = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem10,
            this.toolStripMenuItem12,
            this.menu_provedor,
            this.toolStripMenuItem15,
            this.toolStripMenuItem19,
            this.menu_estoque,
            this.toolStripMenuItem33,
            this.toolStripMenuItem32});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(960, 33);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Image = global::NDM_SoftwareV5.Properties.Resources.atendimento_25x25;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 29);
            this.toolStripMenuItem2.Text = "Atendimento";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.menu_add_helpdesk});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "HelpDesk";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem4.Text = "Abrir Janela Atendimento";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // menu_add_helpdesk
            // 
            this.menu_add_helpdesk.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.menu_add_helpdesk.Name = "menu_add_helpdesk";
            this.menu_add_helpdesk.Size = new System.Drawing.Size(209, 22);
            this.menu_add_helpdesk.Text = "Adicionar/Alterar";
            this.menu_add_helpdesk.Click += new System.EventHandler(this.menu_add_helpdesk_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "Recepção";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem6.Text = "Abrir Janela Solicitação";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.menu_subcategoria});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "Atendimento";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem8.Text = "Add.Categoria";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // menu_subcategoria
            // 
            this.menu_subcategoria.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.menu_subcategoria.Name = "menu_subcategoria";
            this.menu_subcategoria.Size = new System.Drawing.Size(169, 22);
            this.menu_subcategoria.Text = "Add.Subcategoria";
            this.menu_subcategoria.Click += new System.EventHandler(this.menu_subcategoria_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.toolStripMenuItem10.Image = global::NDM_SoftwareV5.Properties.Resources.os_25x25;
            this.toolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(137, 29);
            this.toolStripMenuItem10.Text = "Ordem de serviço";
            this.toolStripMenuItem10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem11.Text = "Abrir Janela";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrarCliente,
            this.menu_cadastrarEndereco});
            this.toolStripMenuItem12.Image = global::NDM_SoftwareV5.Properties.Resources.cliente_25x25;
            this.toolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(85, 29);
            this.toolStripMenuItem12.Text = "Clientes";
            this.toolStripMenuItem12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu_provedor
            // 
            this.menu_provedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meu_provedor_alterar});
            this.menu_provedor.Image = global::NDM_SoftwareV5.Properties.Resources.provedor_25x25;
            this.menu_provedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_provedor.Name = "menu_provedor";
            this.menu_provedor.Size = new System.Drawing.Size(92, 29);
            this.menu_provedor.Text = "Provedor";
            // 
            // meu_provedor_alterar
            // 
            this.meu_provedor_alterar.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.meu_provedor_alterar.Name = "meu_provedor_alterar";
            this.meu_provedor_alterar.Size = new System.Drawing.Size(149, 22);
            this.meu_provedor_alterar.Text = "Empresa- filial";
            this.meu_provedor_alterar.Click += new System.EventHandler(this.meu_provedor_alterar_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16});
            this.toolStripMenuItem15.Image = global::NDM_SoftwareV5.Properties.Resources.user_25x25;
            this.toolStripMenuItem15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(89, 29);
            this.toolStripMenuItem15.Text = "Usuários";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuario_add,
            this.menu_usuario_root});
            this.toolStripMenuItem16.Image = global::NDM_SoftwareV5.Properties.Resources.incluir;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem16.Text = "Adicionar";
            // 
            // menu_usuario_add
            // 
            this.menu_usuario_add.Name = "menu_usuario_add";
            this.menu_usuario_add.Size = new System.Drawing.Size(160, 22);
            this.menu_usuario_add.Text = "Usuário Comum";
            this.menu_usuario_add.Click += new System.EventHandler(this.menu_usuario_add_Click);
            // 
            // menu_usuario_root
            // 
            this.menu_usuario_root.Name = "menu_usuario_root";
            this.menu_usuario_root.Size = new System.Drawing.Size(160, 22);
            this.menu_usuario_root.Text = "Usuário Root";
            this.menu_usuario_root.Click += new System.EventHandler(this.menu_usuario_root_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem20,
            this.estoqueToolStripMenuItem,
            this.roteadorToolStripMenuItem});
            this.toolStripMenuItem19.Image = global::NDM_SoftwareV5.Properties.Resources.relatorio_25x25;
            this.toolStripMenuItem19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(96, 29);
            this.toolStripMenuItem19.Text = "Relatórios";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_relatorio_HelpDesk,
            this.menu_relatorio_Geral});
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem20.Text = "Atendimento";
            // 
            // menu_relatorio_HelpDesk
            // 
            this.menu_relatorio_HelpDesk.Name = "menu_relatorio_HelpDesk";
            this.menu_relatorio_HelpDesk.Size = new System.Drawing.Size(146, 22);
            this.menu_relatorio_HelpDesk.Text = "Por HelpDesk";
            this.menu_relatorio_HelpDesk.Click += new System.EventHandler(this.menu_relatorio_HelpDesk_Click);
            // 
            // menu_relatorio_Geral
            // 
            this.menu_relatorio_Geral.Name = "menu_relatorio_Geral";
            this.menu_relatorio_Geral.Size = new System.Drawing.Size(146, 22);
            this.menu_relatorio_Geral.Text = "Geral";
            this.menu_relatorio_Geral.Click += new System.EventHandler(this.menu_relatorio_Geral_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somenteEntradaToolStripMenuItem,
            this.somenteSaídaToolStripMenuItem,
            this.geralToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // somenteEntradaToolStripMenuItem
            // 
            this.somenteEntradaToolStripMenuItem.Name = "somenteEntradaToolStripMenuItem";
            this.somenteEntradaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.somenteEntradaToolStripMenuItem.Text = "Somente Entrada";
            // 
            // somenteSaídaToolStripMenuItem
            // 
            this.somenteSaídaToolStripMenuItem.Name = "somenteSaídaToolStripMenuItem";
            this.somenteSaídaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.somenteSaídaToolStripMenuItem.Text = "Somente Saída";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.geralToolStripMenuItem.Text = "Geral";
            // 
            // roteadorToolStripMenuItem
            // 
            this.roteadorToolStripMenuItem.Name = "roteadorToolStripMenuItem";
            this.roteadorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.roteadorToolStripMenuItem.Text = "&Roteador";
            // 
            // menu_estoque
            // 
            this.menu_estoque.Image = global::NDM_SoftwareV5.Properties.Resources.entrada_roteador;
            this.menu_estoque.Name = "menu_estoque";
            this.menu_estoque.Size = new System.Drawing.Size(77, 29);
            this.menu_estoque.Text = "Estoque";
            this.menu_estoque.Click += new System.EventHandler(this.menu_estoque_Click);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(12, 29);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Image = global::NDM_SoftwareV5.Properties.Resources.config_25x25;
            this.toolStripMenuItem32.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(124, 29);
            this.toolStripMenuItem32.Text = "Config.Sistema";
            // 
            // menu_cadastrarCliente
            // 
            this.menu_cadastrarCliente.Name = "menu_cadastrarCliente";
            this.menu_cadastrarCliente.Size = new System.Drawing.Size(241, 22);
            this.menu_cadastrarCliente.Text = "&Cadastrar / Atualizar - Clientes";
            this.menu_cadastrarCliente.Click += new System.EventHandler(this.menu_cadastrarCliente_Click);
            // 
            // menu_cadastrarEndereco
            // 
            this.menu_cadastrarEndereco.Name = "menu_cadastrarEndereco";
            this.menu_cadastrarEndereco.Size = new System.Drawing.Size(241, 22);
            this.menu_cadastrarEndereco.Text = "&Cadastrar / Atualizar - Endereço";
            this.menu_cadastrarEndereco.Click += new System.EventHandler(this.menu_cadastrarEndereco_Click);
            // 
            // frm_MDIParent_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NDM_SoftwareV5.Properties.Resources.fundo_8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 678);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_MDIParent_ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - { Acesso -ADM } ::...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_MDIParent_ADM_FormClosed);
            this.Load += new System.EventHandler(this.frm_MDIParent_ADM_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem menu_subcategoria;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem menu_provedor;
        private System.Windows.Forms.ToolStripMenuItem meu_provedor_alterar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem menu_relatorio_HelpDesk;
        private System.Windows.Forms.ToolStripMenuItem menu_relatorio_Geral;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem menu_usuario_add;
        private System.Windows.Forms.ToolStripMenuItem menu_usuario_root;
        private System.Windows.Forms.ToolStripMenuItem menu_add_helpdesk;
        private System.Windows.Forms.ToolStripMenuItem menu_estoque;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somenteEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somenteSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roteadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrarEndereco;
    }
}



