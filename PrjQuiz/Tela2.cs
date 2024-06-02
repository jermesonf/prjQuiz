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
    public partial class Tela2 : MetroFramework.Forms.MetroForm
    {

        Compartilha comp = new Compartilha();

        public Tela2()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {

            

            String txt = rdoVal4.Text;
            int cont = 0;

            Tela3 tela3 = new Tela3();

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

            tela3.ShowDialog();
        }
    }
}
