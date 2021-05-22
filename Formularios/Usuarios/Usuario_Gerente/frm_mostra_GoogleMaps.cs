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
namespace NDM_SoftwareV5.Formularios.Usuarios.Usuario_Gerente
{
    public partial class frm_mostra_GoogleMaps : Form
    {

        public static Filial filial = new Filial();
        string cidade = string.Empty;
        string bairro = string.Empty;
        string rua = string.Empty;
        string numero = string.Empty;
        string cep = string.Empty;


        public frm_mostra_GoogleMaps()
        {
            InitializeComponent();

        }

        private void buscar_endereco() {

            try
            {
               

                StringBuilder queryEndereco = new StringBuilder();
                queryEndereco.Append("http://maps.google.com/maps?q=");


                if (cidade != string.Empty) {

                    cidade = cidade.Replace("", "+");
                    queryEndereco.Append(cidade + ',' + '+');
                }
                if (bairro != string.Empty)
                {

                    bairro = bairro.Replace("", "+");
                    queryEndereco.Append(bairro + ',' + '+');
                }
                if (rua != string.Empty)
                {

                    rua = rua.Replace("", "+");
                    queryEndereco.Append(rua + ',' + '+');
                }
                if (numero != string.Empty)
                {

                    numero = numero.Replace("", "+");
                    queryEndereco.Append(numero + ',' + '+');
                }
                if (cep != string.Empty)
                {

                    cep = cep.Replace("", "+");
                    queryEndereco.Append(cep + ',' + '+');
                }


               // webBrowser_google.Navigate(queryEndereco.ToString());



            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message,"Erro no GoogleMaps");
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            buscar_endereco();
        }
    }
}
