using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class PorteTest :Porte
    {
        public override void Debarrer(string snd)

        {
           Notify();
        }
     
    }

}
