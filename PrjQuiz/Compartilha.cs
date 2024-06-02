using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjQuiz
{
    public class Compartilha
    {
        
        private static int count;

        public void setNome(int v)
        {
            

            for (int num = 0; num < v; num++)
            {
                count++;
            }
        }

        public String getName()
        {
            return count.ToString();          
        }
    }
}
