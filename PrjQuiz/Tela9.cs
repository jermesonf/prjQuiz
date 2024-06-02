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
    public partial class Tela9 : MetroFramework.Forms.MetroForm
    {

        Compartilha comp = new Compartilha();

        public Tela9()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Tela10 tela10 = new Tela10();

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

            tela10.ShowDialog();
        }
    }
}
