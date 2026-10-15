using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class SalleDelegue : Salle
    {
        private string phrase = string.Empty;
        private int nombre = 0;
        public Hibou Hibou { get; } = new Hibou();
       
        
        public SalleDelegue()
        {
            Porte = new PorteDelegue();
        }
        public void fct1()
        {
            nombre++;

            Console.WriteLine("fct1");


        } 
        public void fct2()
        {
            nombre++;
            phrase = "Porte";
            Console.WriteLine("fct2");


        }
        public void fct4(string s)
        {
            phrase += s;
            nombre++;
            Console.WriteLine("fct4");

        }

        public string fct3()
        {
            Console.WriteLine("fct3");

            return " de salle";

        }




        public string fct5()
        {
            Console.WriteLine("fct5");
            return " Delegue";

        }
        public string fct6()
        {
            Console.WriteLine("fct6");
            return " ouvre-toi";

        }
        public int fct7()
        {
            Console.WriteLine("fct7");
            return nombre;
        }


        public string fct8(int a)
        {
            nombre++;
            Console.WriteLine("fct8");
            phrase += " " + a;
            return phrase;

        }


    }

}
