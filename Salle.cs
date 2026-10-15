using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class Salle
    {
        public string Nom { get; set; } = "salle";
        public Porte? Porte { get; set; } = null;
        public Salle() { Nom = GetType().Name; }
    }
   
}
