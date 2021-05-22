namespace NDM_SoftwareV5.Formularios.Usuarios
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img_login = new System.Windows.Forms.PictureBox();
            this.cx_senha = new System.Windows.Forms.TextBox();
            this.cx_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_versaoAtual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cx_senha);
            this.groupBox1.Controls.Add(this.cx_login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_cancelar);
            this.groupBox1.Controls.Add(this.bt_login);
            this.groupBox1.Location = new System.Drawing.Point(2, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.img_login);
            this.groupBox2.Location = new System.Drawing.Point(40, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // img_login
            // 
            this.img_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_login.Image = global::NDM_SoftwareV5.Properties.Resources.usuario_Comun;
            this.img_login.Location = new System.Drawing.Point(3, 16);
            this.img_login.Name = "img_login";
            this.img_login.Size = new System.Drawing.Size(162, 112);
            this.img_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_login.TabIndex = 1;
            this.img_login.TabStop = false;
            // 
            // cx_senha
            // 
            this.cx_senha.BackColor = System.Drawing.SystemColors.Info;
            this.cx_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_senha.Location = new System.Drawing.Point(13, 212);
            this.cx_senha.MaxLength = 20;
            this.cx_senha.Name = "cx_senha";
            this.cx_senha.PasswordChar = '*';
            this.cx_senha.Size = new System.Drawing.Size(214, 21);
            this.cx_senha.TabIndex = 1;
            this.cx_senha.TextChanged += new System.EventHandler(this.cx_senha_TextChanged);
            // 
            // cx_login
            // 
            this.cx_login.BackColor = System.Drawing.SystemColors.Info;
            this.cx_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cx_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cx_login.Location = new System.Drawing.Point(13, 169);
            this.cx_login.MaxLength = 14;
            this.cx_login.Name = "cx_login";
            this.cx_login.Size = new System.Drawing.Size(214, 21);
            this.cx_login.TabIndex = 0;
            this.cx_login.TextChanged += new System.EventHandler(this.cx_login_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SENHA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN:";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancelar.Image")));
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(13, 276);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(214, 31);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_login.Enabled = false;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Image = ((System.Drawing.Image)(resources.GetObject("bt_login.Image")));
            this.bt_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_login.Location = new System.Drawing.Point(13, 239);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(214, 31);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "Acessar";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "AUTENTICAÇÃO DE USUÁRIO";
            // 
            // lbl_versaoAtual
            // 
            this.lbl_versaoAtual.AutoSize = true;
            this.lbl_versaoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_versaoAtual.ForeColor = System.Drawing.Color.Black;
            this.lbl_versaoAtual.Location = new System.Drawing.Point(156, 379);
            this.lbl_versaoAtual.Name = "lbl_versaoAtual";
            this.lbl_versaoAtual.Size = new System.Drawing.Size(79, 15);
            this.lbl_versaoAtual.TabIndex = 7;
            this.lbl_versaoAtual.Text = "0000.00.00.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(180, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Versão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(113, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Versão:";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_versaoAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: NDM-Software - { Login } ::...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cx_senha;
        private System.Windows.Forms.TextBox cx_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lbl_versaoAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox img_login;
        private System.Windows.Forms.Label label5;
    }
}