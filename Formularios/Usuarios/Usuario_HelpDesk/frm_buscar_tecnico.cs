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
using Controlador.Controle.DataGrid_Config.DataGrid_Usuario;
using NDM_SoftwareV5.Formularios.Ordem_Servicos;
using NDM_SoftwareV5.Formularios.Usuarios.Usuario_Estoque;

namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_HelpDesk
{
    public partial class frm_buscar_tecnico : Form
    {
        public static Filial filial_statico = new Filial();
        private TecnicoRua tecnico = new TecnicoRua();
        public static bool agendamento = false;
        private DataGrid_Usuario dg_config = new DataGrid_Usuario();
        public static bool is_atendimento_help =true;
        public frm_buscar_tecnico()
        {
            InitializeComponent();
        }

        private void frm_buscar_tecnico_Load(object sender, EventArgs e)
        {
            tecnico.Tec_ID     = 0;
            tecnico.Tec_nome   = "";
            tecnico.Tec_ativo  = 0;
            if (filial_statico.Fili_ID > 0)
            {
                mostra_tec.DataSource = dg_config.mostra_Tecnico_Rua_informacoes(mostra_tec, filial_statico, 1, tecnico);
            }
            else { mostra_tec.DataSource = null; }
        }
        private TecnicoRua puxarTecnico(DataGridView dg) {

            tecnico.Tec_ID = 0;
            tecnico.Tec_nome = "";
            tecnico.Tec_ativo = 0;
            try {

                tecnico.Tec_ID = Convert.ToInt32(dg.SelectedCells[0].Value.ToString());
                tecnico.Tec_nome = dg.SelectedCells[1].Value.ToString();
                tecnico.Tec_ativo = Convert.ToInt32(dg.SelectedCells[2].Value.ToString());
                tecnico.Usu_ID = Convert.ToInt32(dg.SelectedCells[3].Value.ToString());
            }
            catch {
                tecnico.Tec_ID = 0;
                tecnico.Tec_nome = "";
                tecnico.Tec_ativo = 0;
                tecnico.Usu_ID = 0;
            }
            return tecnico;

        }

        private void mostra_tec_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var id_grid = Convert.ToInt32(mostra_tec.SelectedCells[0].Value.ToString());
                if (id_grid > 0)
                {
                    if (is_atendimento_help == true)
                    {
                        frm_add_Atendimento.tecnico = puxarTecnico(mostra_tec);
                        this.Close();
                    }
                    else {

                        frm_Roteador.tecnico_staico = puxarTecnico(mostra_tec);
                        this.Close();
                    }
                }
            }
            catch { MessageBox.Show("Erro: Alvo não foi selecionado!");}
            }

        private void mostra_tec_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var id_grid = Convert.ToInt32(mostra_tec.SelectedCells[0].Value.ToString());
                
                if (id_grid > 0)
                {
                    bt_selecionar_tecnico.Enabled = true;
                    //usado para atendimentos.
                    if (agendamento == false) { frm_add_Atendimento.tecnico = puxarTecnico(mostra_tec); }
                    //usado para emição de técnico / agendamentos de OS
                    else { frm_abertura_OS_Atendimento.usuario_tecnico = puxarTecnico(mostra_tec); }
                    
                }
                else { bt_selecionar_tecnico.Enabled = false; }
            }
            catch { MessageBox.Show("Erro: Alvo não foi selecionado!"); }
        }

        private void bt_selecionar_tecnico_Click(object sender, EventArgs e)
        {
            try
            {
                var id_grid = Convert.ToInt32(mostra_tec.SelectedCells[0].Value.ToString());
                if (id_grid > 0)
                {
                    this.Close();
                }
                else { bt_selecionar_tecnico.Enabled = false; }
            }
            catch { MessageBox.Show("Erro: Alvo não foi selecionado!"); }
        }

        private void bt_buscar_tec_Click(object sender, EventArgs e)
        {
            tecnico.Tec_ID = 0;
            tecnico.Tec_nome = cx_nome_tec.Text;
            tecnico.Tec_ativo = 0;
            if (filial_statico.Fili_ID > 0)
            {
                mostra_tec.DataSource = dg_config.mostra_Tecnico_Rua_informacoes(mostra_tec, filial_statico, 1, tecnico);
            }
            else { mostra_tec.DataSource = null; }
        }
    }
}
