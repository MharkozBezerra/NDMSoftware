using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Classes;
using Regras_N.Regra_N_Usuario;

namespace NDM_SoftwareV5.Formularios.F_Cliente
{
    public partial class add_Telefone_cliente : Form
    {
        public static Usuario usuario_statico = new Usuario();
        public static Cliente cliente_statico = new Cliente();
        public static Telefone telefone_statico = new Telefone();
        RN_Telefone regra_telefone = new RN_Telefone();
        public add_Telefone_cliente()
        {
            InitializeComponent();
        }

        private void add_Telefone_cliente_Load(object sender, EventArgs e)
        {
            if (telefone_statico.Tele_ID > 0) { bt_gravar_1.Enabled = false; bt_atualizar.Enabled = true; }
            else { bt_gravar_1.Enabled = true; bt_atualizar.Enabled = false; }

        }

        private void rb_celular_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_celular.Checked == true)
            {
                cx_celular.Enabled  = true;
                cx_telefone.Enabled = false;
                cx_telefone.Text    = "";
            }
            else {
                cx_celular.Enabled = false;
                cx_celular.Text = "";
            }
        }

        private void rb_telefone_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_telefone.Checked == true)
            {
                cx_celular.Enabled  = false;
                cx_celular.Text     = "";
                cx_telefone.Enabled = true;
            }
            else
            {

                cx_telefone.Text    = "";
                cx_telefone.Enabled = false;
            }
        }

        private void bt_gravar_1_Click(object sender, EventArgs e)
        {
            string numero_telefone = "";
            string observacao = cx_obs_telefone.Text;
            if (rb_celular.Checked == true) { numero_telefone = cx_celular.Text; }
            if (rb_telefone.Checked == true) { numero_telefone = cx_telefone.Text; }
            Telefone tel = new Telefone();
            tel.Tele_numero = numero_telefone;
            tel.Tele_descricao = observacao;
            
            if (cliente_statico.Clie_ID > 0) {
                regra_telefone.add_telefone_cliente(cliente_statico, tel);
                this.Close();
            }
            if (usuario_statico.Usu_ID > 0) {
                ////-> não criado ainda
            }
        }

        private void bt_cancelar_1_Click(object sender, EventArgs e)
        {
            usuario_statico = null;
            cliente_statico = null;
            telefone_statico = null;
            Close();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            string numero_telefone = "";
            string observacao = cx_obs_telefone.Text;
            if (rb_celular.Checked == true) { numero_telefone = cx_celular.Text; }
            if (rb_telefone.Checked == true) { numero_telefone = cx_telefone.Text; }
            Telefone tel = new Telefone();
            tel.Tele_numero = numero_telefone;
            tel.Tele_descricao = observacao;
            tel.Tele_ID = telefone_statico.Tele_ID;
            regra_telefone.upt_telefone_cliente( tel);
            this.Close();
            
        }
    }
}
