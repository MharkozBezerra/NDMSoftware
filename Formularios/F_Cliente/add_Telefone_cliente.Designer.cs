namespace NDM_SoftwareV5.Formularios.F_Cliente
{
    partial class add_Telefone_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_Telefone_cliente));
            this.cx_celular = new System.Windows.Forms.MaskedTextBox();
            this.cx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.rb_celular = new System.Windows.Forms.RadioButton();
            this.rb_telefone = new System.Windows.Forms.RadioButton();
            this.cx_obs_telefone = new System.Windows.Forms.TextBox();
            this.bt_gravar_1 = new System.Windows.Forms.Button();
            this.bt_cancelar_1 = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cx_celular
            // 
            this.cx_celular.Enabled = false;
            this.cx_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_celular.Location = new System.Drawing.Point(84, 7);
            this.cx_celular.Mask = "(99) 00000-0000";
            this.cx_celular.Name = "cx_celular";
            this.cx_celular.Size = new System.Drawing.Size(106, 22);
            this.cx_celular.TabIndex = 1;
            // 
            // cx_telefone
            // 
            this.cx_telefone.Enabled = false;
            this.cx_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cx_telefone.Location = new System.Drawing.Point(279, 7);
            this.cx_telefone.Mask = "(99) 0000-0000";
            this.cx_telefone.Name = "cx_telefone";
            this.cx_telefone.Size = new System.Drawing.Size(106, 22);
            this.cx_telefone.TabIndex = 3;
            // 
            // rb_celular
            // 
            this.rb_celular.AutoSize = true;
            this.rb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rb_celular.Location = new System.Drawing.Point(17, 7);
            this.rb_celular.Name = "rb_celular";
            this.rb_celular.Size = new System.Drawing.Size(71, 20);
            this.rb_celular.TabIndex = 4;
            this.rb_celular.TabStop = true;
            this.rb_celular.Text = "Celular:";
            this.rb_celular.UseVisualStyleBackColor = true;
            this.rb_celular.CheckedChanged += new System.EventHandler(this.rb_celular_CheckedChanged);
            // 
            // rb_telefone
            // 
            this.rb_telefone.AutoSize = true;
            this.rb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rb_telefone.Location = new System.Drawing.Point(198, 7);
            this.rb_telefone.Name = "rb_telefone";
            this.rb_telefone.Size = new System.Drawing.Size(83, 20);
            this.rb_telefone.TabIndex = 5;
            this.rb_telefone.TabStop = true;
            this.rb_telefone.Text = "Telefone:";
            this.rb_telefone.UseVisualStyleBackColor = true;
            this.rb_telefone.CheckedChanged += new System.EventHandler(this.rb_telefone_CheckedChanged);
            // 
            // cx_obs_telefone
            // 
            this.cx_obs_telefone.Location = new System.Drawing.Point(17, 36);
            this.cx_obs_telefone.Multiline = true;
            this.cx_obs_telefone.Name = "cx_obs_telefone";
            this.cx_obs_telefone.Size = new System.Drawing.Size(266, 106);
            this.cx_obs_telefone.TabIndex = 7;
            // 
            // bt_gravar_1
            // 
            this.bt_gravar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_gravar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gravar_1.Enabled = false;
            this.bt_gravar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar_1.Image = global::NDM_SoftwareV5.Properties.Resources.bt_salvar_30x30;
            this.bt_gravar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gravar_1.Location = new System.Drawing.Point(289, 36);
            this.bt_gravar_1.Name = "bt_gravar_1";
            this.bt_gravar_1.Size = new System.Drawing.Size(96, 35);
            this.bt_gravar_1.TabIndex = 9;
            this.bt_gravar_1.Text = "Gravar";
            this.bt_gravar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gravar_1.UseVisualStyleBackColor = false;
            this.bt_gravar_1.Click += new System.EventHandler(this.bt_gravar_1_Click);
            // 
            // bt_cancelar_1
            // 
            this.bt_cancelar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar_1.Image = global::NDM_SoftwareV5.Properties.Resources.cancelar;
            this.bt_cancelar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar_1.Location = new System.Drawing.Point(289, 107);
            this.bt_cancelar_1.Name = "bt_cancelar_1";
            this.bt_cancelar_1.Size = new System.Drawing.Size(96, 35);
            this.bt_cancelar_1.TabIndex = 10;
            this.bt_cancelar_1.Text = "Cancelar";
            this.bt_cancelar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar_1.UseVisualStyleBackColor = false;
            this.bt_cancelar_1.Click += new System.EventHandler(this.bt_cancelar_1_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_atualizar.Enabled = false;
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar.Image = global::NDM_SoftwareV5.Properties.Resources.bt_atualizar_25x25;
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(289, 70);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(96, 38);
            this.bt_atualizar.TabIndex = 11;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // add_Telefone_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 148);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_gravar_1);
            this.Controls.Add(this.bt_cancelar_1);
            this.Controls.Add(this.cx_obs_telefone);
            this.Controls.Add(this.cx_telefone);
            this.Controls.Add(this.cx_celular);
            this.Controls.Add(this.rb_telefone);
            this.Controls.Add(this.rb_celular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_Telefone_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..:: NDM-Software - { Telefone } ::...";
            this.Load += new System.EventHandler(this.add_Telefone_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cx_celular;
        private System.Windows.Forms.MaskedTextBox cx_telefone;
        private System.Windows.Forms.RadioButton rb_celular;
        private System.Windows.Forms.RadioButton rb_telefone;
        private System.Windows.Forms.TextBox cx_obs_telefone;
        private System.Windows.Forms.Button bt_gravar_1;
        private System.Windows.Forms.Button bt_cancelar_1;
        private System.Windows.Forms.Button bt_atualizar;
    }
}