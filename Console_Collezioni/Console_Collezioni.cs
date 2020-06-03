using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collezioni_Library;

namespace Console_Collezioni
{
    class Console_Collezioni
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci prima frase");
            string a = Console.ReadLine();
            Console.WriteLine("Inserisci seconda frase");
            string b = Console.ReadLine();
            bool stringheUguali = Collezioni_Class.StringheUguali(a, b);
            Console.WriteLine("Le frasi sono uguali? " +stringheUguali);

            Console.WriteLine("inserisci una frase");
            string frase = Console.ReadLine();
            bool spazi = Collezioni_Class.SpaziStringa(frase);
            Console.WriteLine("La frase contiene spazi? " + spazi);
            Console.ReadLine();
        }
    }
}
