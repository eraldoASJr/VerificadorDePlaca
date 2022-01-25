using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPlacas
{
    public partial class FrmRodizio : Form
    {
        public FrmRodizio()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int varFinalPlaca;

            varFinalPlaca = Convert.ToInt16(txtFinalPlaca.Text);

          /*  if (varFinalPlaca == 1 || varFinalPlaca == 2)
                lblMensagem.Text = " Proibido Segunda-Feira";
            else if (varFinalPlaca == 3 || varFinalPlaca == 4)
                lblMensagem.Text = " Proibido Terça-Feira";
            else if (varFinalPlaca == 5 || varFinalPlaca == 6)
                lblMensagem.Text = " Proibido Quarta-Feira";
            else if (varFinalPlaca == 7 || varFinalPlaca == 8)
                lblMensagem.Text = " Proibido Quinta-Feira";
            else if (varFinalPlaca == 9 || varFinalPlaca == 0)
                lblMensagem.Text = " Proibido Sexta-Feira";
          */

            switch (varFinalPlaca)
            {
                case 1: lblMensagem.Text = " Proibido Segunda-Feira e Licenciar até ABRIL"; break;

                case 2: lblMensagem.Text = " Proibido Segunda-Feira e Licenciar até MAIO"; break;

                case 3: lblMensagem.Text = " Proibido Terça-Feira e Licenciar até JUNHO"; break;

                case 4: lblMensagem.Text = " Proibido Terça-Feira e LICenciar atpe JULHO"; break;

                case 5:
                case 6: lblMensagem.Text = " Proibido Quarta-Feira e LIcenciar até AGOSTO"; break;

                case 7: lblMensagem.Text = " Proibido Quinta-Feira e Licenciar até SETEMBRO"; break;

                case 8: lblMensagem.Text = " Proibido Quinta-Feira e Licencair até OUTUBRO"; break;
                  
                case 9: lblMensagem.Text = " Proibido Sexta-Feira e Licenciar até NOVMBRO"; break;

                case 0: lblMensagem.Text = " Proibido Sexta-Feira e Liceniar até DEZEMBRO"; break;

                default :  lblMensagem.Text = " Erro....." ;                 
                    break;

            }


        }
    }
}
