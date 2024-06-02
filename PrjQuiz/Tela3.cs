using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjQuiz
{
    public partial class Tela3 : MetroFramework.Forms.MetroForm
    {
        Compartilha comp = new Compartilha();
        public Tela3()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Tela4 tela4 = new Tela4();

            String txt = rdoVal4.Text;
            int cont = 0;

            if (rdoVal4.Checked == true)
            {
               
                
            }
            else if (rdoVal3.Checked == true)
            {

            }
            else if (rdoVal2.Checked == true)
            {
                cont++;
                comp.setNome(cont);
            }
            else
            {

            }

            tela4.ShowDialog();
        }
    }
}
