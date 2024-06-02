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
    public partial class Tela5 : MetroFramework.Forms.MetroForm
    {
        Compartilha comp = new Compartilha();
        public Tela5()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Tela6 tela6 = new Tela6();

            String txt = rdoVal4.Text;
            int cont = 0;

            if (rdoVal4.Checked == true)
            {
                cont++;
                comp.setNome(cont);

            }
            else if (rdoVal3.Checked == true)
            {
                
            }
            else if (rdoVal2.Checked == true)
            {

            }
            else
            {

            }

            tela6.ShowDialog();
        }

    }
}
