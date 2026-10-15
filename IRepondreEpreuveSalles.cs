using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{

  
        public interface IRepondreEpreuveSalles
        {
     
        string Nom { get; set; }

            void Epreuve_SalleTest(Salle salle) { }
            void Epreuve_SalleException(Salle salle) { }
            void Epreuve_SalleDelegue(Salle salle) {  }
           
        }
    
}
