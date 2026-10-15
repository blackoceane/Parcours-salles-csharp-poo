using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class Spectateurs
    {
        public void Applaudissement(object sender, EventArgs e)
        {
            Console.WriteLine("Foule    !!! YOUHOU    !!!!!!!");
        }
        public void SAbonner(Porte porte)
        {
            // Abonne les encouragements à l'événement de la porte
            porte.TentativeDebarrage += EncagerPorte;
        }

        private void EncagerPorte(string nomPorte)
        {
            
            Console.WriteLine($" Foule:  ouvre la {nomPorte} ! GO GO GO GO !!!! )");
        }
    }
}
