namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    partial class frm_buscar_tecnico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_buscar_tecnico));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cx_nome_tec = new System.Windows.Forms.TextBox();
            this.mostra_tec = new System.Windows.Forms.DataGridView();
            this.bt_selecionar_tecnico = new System.Windows.Forms.Button();
            this.bt_buscar_tec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_tec)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 49);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Técnicos de Rua - Externos";
            // 
            // cx_nome_tec
            // 
            this.cx_nome_tec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_nome_tec.Location = new System.Drawing.Point(75, 54);
            this.cx_nome_tec.MaxLength = 50;
            this.cx_nome_tec.Name = "cx_nome_tec";
            this.cx_nome_tec.Size = new System.Drawing.Size(243, 22);
            this.cx_nome_tec.TabIndex = 31;
            // 
            // mostra_tec
            // 
            this.mostra_tec.AllowUserToAddRows = false;
            this.mostra_tec.AllowUserToDeleteRows = false;
            this.mostra_tec.AllowUserToOrderColumns = true;
            this.mostra_tec.AllowUserToResizeColumns = false;
            this.mostra_tec.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostra_tec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mostra_tec.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostra_tec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostra_tec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mostra_tec.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mostra_tec.GridColor = System.Drawing.SystemColors.Control;
            this.mostra_tec.Location = new System.Drawing.Point(2, 82);
            this.mostra_tec.MultiSelect = false;
            this.mostra_tec.Name = "mostra_tec";
            this.mostra_tec.ReadOnly = true;
            this.mostra_tec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostra_tec.ShowCellErrors = false;
            this.mostra_tec.ShowCellToolTips = false;
            this.mostra_tec.ShowEditingIcon = false;
            this.mostra_tec.ShowRowErrors = false;
            this.mostra_tec.Size = new System.Drawing.Size(353, 262);
            this.mostra_tec.TabIndex = 30;
            this.mostra_tec.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mostra_tec_CellMouseClick);
            this.mostra_tec.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mostra_tec_CellMouseDoubleClick);
            // 
            // bt_selecionar_tecnico
            // 
            this.bt_selecionar_tecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_selecionar_tecnico.Enabled = false;
            this.bt_selecionar_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selecionar_tecnico.Image = global::NDM_SoftwareV5.Properties.Resources.gravar;
            this.bt_selecionar_tecnico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_selecionar_tecnico.Location = new System.Drawing.Point(2, 346);
            this.bt_selecionar_tecnico.Name = "bt_selecionar_tecnico";
            this.bt_selecionar_tecnico.Size = new System.Drawing.Size(353, 43);
            this.bt_selecionar_tecnico.TabIndex = 35;
            this.bt_selecionar_tecnico.Text = "Selecionar";
            this.bt_selecionar_tecnico.UseVisualStyleBackColor = true;
            this.bt_selecionar_tecnico.Click += new System.EventHandler(this.bt_selecionar_tecnico_Click);
            // 
            // bt_buscar_tec
            // 
            this.bt_buscar_tec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_buscar_tec.Image = global::NDM_SoftwareV5.Properties.Resources.lupa_25x25;
            this.bt_buscar_tec.Location = new System.Drawing.Point(321, 49);
            this.bt_buscar_tec.Name = "bt_buscar_tec";
            this.bt_buscar_tec.Size = new System.Drawing.Size(32, 33);
            this.bt_buscar_tec.TabIndex = 33;
            this.bt_buscar_tec.UseVisualStyleBackColor = true;
            this.bt_buscar_tec.Click += new System.EventHandler(this.bt_buscar_tec_Click);
            // 
            // frm_buscar_tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 391);
            this.Controls.Add(this.bt_selecionar_tecnico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_buscar_tec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cx_nome_tec);
            this.Controls.Add(this.mostra_tec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_buscar_tecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - {HelpDesk - Atendimento } ::...";
            this.Load += new System.EventHandler(this.frm_buscar_tecnico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostra_tec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_buscar_tec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cx_nome_tec;
        private System.Windows.Forms.DataGridView mostra_tec;
        private System.Windows.Forms.Button bt_selecionar_tecnico;
    }
}