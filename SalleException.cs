using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class SalleException : Salle
    {

        public List<string> ListeElements { get; set; }
        public SalleException()
        {
            Porte = new PorteException();
            ListeElements = new List<string>()
     {"1","E","20","3","13","A","6","48","HAHA","11" };


        }
    }


   
}
