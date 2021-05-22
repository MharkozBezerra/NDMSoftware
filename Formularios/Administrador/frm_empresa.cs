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
using Controlador.Controle.DataGrid_Config;
using Controlador.Controle.DataGrid_Config.DataGrid_Empresa;
using NDM_SoftwareV5.Formularios.Config_Sistemas;
using NDM_SoftwareV5.Interface;

namespace NDM_SoftwareV5.Formularios.Administrador
{
    public partial class frm_empresa : Form
    {
        Empresa empresa = new Empresa();
        Filial filia    = new Filial();
        Empresa_DAO empresa_dao = new Empresa_DAO();
        Filial_DAO filial_dao   = new Filial_DAO();
        DataGrid_Empresa dg_config = new DataGrid_Empresa();
        public static bool acesso_gerente = false;
        public frm_empresa()
        {
            InitializeComponent();
        }

        private void frm_empresa_Load(object sender, EventArgs e)
        {
            carregarGrids();
            if (acesso_gerente == true) {
                grupo_empresa.Enabled = false;
            }
        }

        private void carregarGrids() {
            
            dg_empresa.DataSource = dg_config.mostra_Empresa(dg_empresa);

        }
        private void puxaFilial(Empresa emp) {
            dg_filial.DataSource = dg_config.mostra_Filial(dg_filial, emp);
        }

        private void dg_empresa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            empresa.Emp_ID = 0;
            try {
                empresa.Emp_ID        = Convert.ToInt32(dg_empresa.SelectedCells[0].Value.ToString());
                empresa.Emp_descricao = dg_empresa.SelectedCells[1].Value.ToString();
                puxaFilial(empresa);

                //Libera ações.
                bt_alterar_empresa.Enabled = true;
                bt_incluir_filial.Enabled  = true;
            }
            catch {
                empresa.Emp_ID = 0;
                puxaFilial(empresa);
                bt_alterar_empresa.Enabled = false;
                bt_incluir_filial.Enabled  = false;
            }
        }

        private void dg_filial_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cx_descricao_filial.Text = "";
            try {
               
                filia.Fili_ID        = Convert.ToInt32(dg_filial.SelectedCells[0].Value.ToString());
                filia.Fili_descricao = dg_filial.SelectedCells[1].Value.ToString();
                filia.Emp_descricao  = dg_filial.SelectedCells[2].Value.ToString();
                filia.Emp_ID         = Convert.ToInt32(dg_filial.SelectedCells[3].Value.ToString());
                filia.Fili_obs       = dg_filial.SelectedCells[4].Value.ToString();
                cx_descricao_filial.Text = filia.Fili_obs;
                bt_alterar_filial.Enabled = true;
            }
            catch {
                cx_descricao_filial.Text = "";
                bt_alterar_filial.Enabled = false;
            }
        }

        private void acao_incluir_alterar(int acao) {
           
            
            switch (acao)
            {
                //1-> Adicionar dados empresa.
                case 1:
                    frm_add_empresa_filial.acao_tipo = acao;
                    var add_empresa = new frm_add_empresa_filial();
                    add_empresa.ShowDialog();
                    carregarGrids();
                    break;
                //2-> Alterar dados empresa.
                case 2:
                    frm_add_empresa_filial.acao_tipo = acao;
                    frm_add_empresa_filial.empresa_add.Emp_ID        = empresa.Emp_ID;
                    frm_add_empresa_filial.empresa_add.Emp_descricao = empresa.Emp_descricao;
                    var upt_empresa = new frm_add_empresa_filial();
                    upt_empresa.ShowDialog();
                    carregarGrids();
                    break;
                //3-> Adicionar dados provedor.
                case 3:
                    frm_add_empresa_filial.acao_tipo = acao;
                    frm_add_empresa_filial.empresa_add.Emp_ID = empresa.Emp_ID;
                    frm_add_empresa_filial.empresa_add.Emp_descricao = empresa.Emp_descricao;
                    var add_filial = new frm_add_empresa_filial();
                    add_filial.ShowDialog();
                    puxaFilial(empresa);
                    break;
                case 4:
                    frm_add_empresa_filial.acao_tipo = acao;
                    frm_add_empresa_filial.filial_add.Emp_ID = filia.Emp_ID;
                    frm_add_empresa_filial.filial_add.Emp_descricao = filia.Emp_descricao;
                    frm_add_empresa_filial.filial_add.Fili_ID = filia.Fili_ID;
                    frm_add_empresa_filial.filial_add.Fili_descricao = filia.Fili_descricao;
                    frm_add_empresa_filial.filial_add.Fili_obs = filia.Fili_obs;

                    var upt_filial = new frm_add_empresa_filial();
                    upt_filial.ShowDialog();
                    puxaFilial(empresa);
                    break;
                default:
                    break;
            }
            
            
            //4-> Alterar dados provedor.
        }

        private void bt_incluir_empresa_Click(object sender, EventArgs e)
        {
            acao_incluir_alterar(1);
        }

        private void bt_alterar_empresa_Click(object sender, EventArgs e)
        {
            acao_incluir_alterar(2);
        }

        private void bt_incluir_filial_Click(object sender, EventArgs e)
        {
            acao_incluir_alterar(3);
        }

        private void bt_alterar_filial_Click(object sender, EventArgs e)
        {
            acao_incluir_alterar(4);
        }

        private void dg_empresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quando usuário der dois clieque, será carregado o objeto Empresa do formulário de configuração.
            //Será inserido ID e descrição da empresa.
            //Depois deve ser fechado este formulário.
            try
            {
                empresa.Emp_ID = Convert.ToInt32(dg_empresa.SelectedCells[0].Value.ToString());
                empresa.Emp_descricao = dg_empresa.SelectedCells[1].Value.ToString();
                //-------------------------------------------------------------------
                frm_configuracao_sistema.empresa.Emp_ID = empresa.Emp_ID;
                frm_configuracao_sistema.empresa.Emp_descricao = empresa.Emp_descricao;
                this.Close();
            }
            catch {
                frm_configuracao_sistema.empresa.Emp_ID = Convert.ToInt32(dg_empresa.SelectedCells[0].Value.ToString());
                frm_configuracao_sistema.empresa.Emp_descricao = dg_empresa.SelectedCells[1].Value.ToString();
                this.Close();
            }
           }

    }
}
