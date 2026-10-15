using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class PorteDelegue :Porte
    {
        private string phrase = "Porte de salle Delegue ouvre-toi 5";
        public override void Debarrer(string phrase_origi)
        {
            Notify();
            if (phrase_origi ==phrase)
            {
                Debarree=true;
                Console.WriteLine(phrase_origi);
            }
        }
       

    }
}
