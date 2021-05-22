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
using Controlador.Controle;
using NDM_SoftwareV5.Interface;

namespace NDM_SoftwareV5.Formularios.Administrador
{
    public partial class frm_add_empresa_filial : Form,I_Base
    {
        public static Empresa empresa_add = new Empresa();
        public static Filial filial_add   = new Filial();
        private Empresa_DAO empresa_dao   = new Empresa_DAO();
        private Filial_DAO filial_dao     = new Filial_DAO();

        public static int acao_tipo;
        public frm_add_empresa_filial()
        {
            InitializeComponent();
        }

        private void frm_add_empresa_filial_Load(object sender, EventArgs e)
        {
            acao_inicial(acao_tipo);
        }
        private void acao_inicial(int acao) {
            //1-> Adicionar dados empresa.
            //2-> Alterar dados empresa.
            //3-> Adicionar dados provedor.
            //4-> Alterar dados provedor.
            switch (acao)
            {
                case 1:
                    lbl_empresa_descricao.Text = "";
                    break;
                case 2:
                    lbl_empresa_descricao.Text = empresa_add.Emp_descricao;
                    lbl_empresa_filial_atual.Text = "Atual: ";
                    cx_descricao.Text = "";
                    cx_obs.ReadOnly = true;
                    break;
                case 3:
                    lbl_empresa_descricao.Text = "";
                    lbl_empresa_descricao.Text = empresa_add.Emp_descricao;

                    break;
                case 4:
                    lbl_empresa_filial_atual.Text = "Atual: ";
                    lbl_empresa_descricao.Text = filial_add.Fili_descricao;
                    cx_descricao.Text = "";
                    cx_obs.Text = filial_add.Fili_obs;
                    break;

                default:
                    this.Close();
                    break;
            }


        }
        private void acao_add_upt(int acao) {

            
            switch (acao)
            {
                case 1:
                    //1-> Adicionar dados empresa.
                    add_empresa(empresa_add);

                    break;
                //2-> Alterar dados empresa.
                case 2:
                    upt_empresa(empresa_add);
                    break;
                //3-> Adicionar dados provedor.
                case 3:
                    add_filial(filial_add);
                        break;
                //4-> Alterar dados provedor.
                case 4:
                    upt_filial(filial_add);
                    break;
                default:
                    MessageBox.Show("Opção inválida!");
                    this.Close();
                    break;
            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show("Deseja aplicar essa ação no banco de dados agora?","Atenção!!",MessageBoxButtons.YesNo);

            if (pergunta == DialogResult.Yes) {
                acao_add_upt(acao_tipo);
                this.Close();
            }
        }

        public void add_empresa(Empresa empresa)
        {
            if (empresa_dao.add_empresa(empresa) == true)
            {
                MessageBox.Show(empresa.Emp_descricao + ", salva com sucesso!");
            }
            else
            {
                MessageBox.Show(empresa.Emp_descricao + ", não pode ser salva, comunique o desenvolvedor!");
            }
        }

        public void upt_empresa(Empresa empresa)
        {
            if (cx_descricao.Text != "" && cx_descricao.Text != String.Empty)
            {
                empresa.Emp_descricao = cx_descricao.Text;
                if (empresa_dao.upt_empresa(empresa) == true)
                {
                    MessageBox.Show(empresa.Emp_descricao + ", alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show(empresa.Emp_descricao + ", não pode ser alterada, comunique o desenvolvedor!");
                }
            }
            else
            {
                MessageBox.Show("Informe uma descrição para essa empresa.");
                cx_descricao.Focus();
            }
        }

        public void add_filial(Filial filial)
        {
            if (cx_descricao.Text != "" && cx_descricao.Text != String.Empty)
            {

                filial.Fili_descricao = cx_descricao.Text;
                filial.Fili_obs = cx_obs.Text;
                if (filial_dao.add_filial(filial) == true)
                {
                    MessageBox.Show(filial.Fili_descricao + ", salvo com sucesso!");
                }
                else { MessageBox.Show(filial.Fili_descricao + ", não pode ser salvo, comunique o desenvolvedor!"); }
            }
            else
            {
                MessageBox.Show("Informe uma descrição para essa filial / base.");
                cx_descricao.Focus();
            }
        }

        public void upt_filial(Filial filial)
        {
            if (cx_descricao.Text != "" && cx_descricao.Text != String.Empty)
            {
                filial.Fili_descricao = cx_descricao.Text;
                filial.Fili_obs = cx_obs.Text;
                if (filial_dao.upt_filial(filial) == true)
                {
                    MessageBox.Show(filial.Fili_descricao + ", alterado com sucesso!");
                }
                else { MessageBox.Show(filial.Fili_descricao + ", não pode ser alterado, comunique o desenvolvedor!"); }
            }
            else
            {
                MessageBox.Show("Informe uma descrição para essa filial / base.");
                cx_descricao.Focus();
            }
        }
    }
}
