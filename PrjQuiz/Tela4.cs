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
    public partial class Tela4 : MetroFramework.Forms.MetroForm
    {

        Compartilha comp = new Compartilha();

        public Tela4()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Tela5 tela5 = new Tela5();

            String txt = rdoVal4.Text;
            int cont = 0;

            if (rdoVal4.Checked == true)
            {


            }
            else if (rdoVal3.Checked == true)
            {
                cont++;
                comp.setNome(cont);
            }
            else if (rdoVal2.Checked == true)
            {

            }
            else
            {

            }

            tela5.ShowDialog();
        }
    }
}
