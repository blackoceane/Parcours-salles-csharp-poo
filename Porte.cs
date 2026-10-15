using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public abstract class Porte
    {
        private bool debarrée;

        public bool Ouverte { get; set; }

        public bool Debarree
        {
            get => debarrée;
            set
            {
                debarrée = value;

                // Quand Debarree devient true → Ouvrir() est appelée automatiquement
                if (debarrée)
                    Ouvrir();
            }
        }
        public void Ouvrir()
        {
            if (Debarree == true)
                Ouverte = true;

        }
        public abstract void Debarrer(string phrase_origi);     // façon de déverrouiller spécifique

        // Événement qui transporte le nom de la porte
        public event Action<string>? TentativeDebarrage;

        protected void Notify()  //  MÉTHODE appelée par portes spécifiques
        {
            string nomPorte = GetType().Name;  
            TentativeDebarrage?.Invoke(nomPorte);  // Envoie nom aux autres portes
        }

    }
}
