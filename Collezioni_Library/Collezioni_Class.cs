using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collezioni_Library
{
    public class Collezioni_Class
    {
        public static bool StringheUguali(string a, string b)
        {
            if(a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpaziStringa(string frase)
        {
            if (frase.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
