using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class HallEntree
    {
        private Participant? participant = null;
        private List<Salle?>? salles = null;
        public Spectateurs? Spectateurs { get; set; } = new Spectateurs();
        public event EventHandler? ApplaudissementsEvent;
        
        public HallEntree()
        {
            salles = new List<Salle?>()
            {
                new SalleTest(),
                new SalleDelegue(),
                new SalleException()
            };
        }
        
        public void EntreeParticipant(Participant? participant)
        {

            Console.WriteLine( participant.Nom + " est notre participant!");
            this.participant = participant;

            foreach (var salle in salles)
            {
                if (salle?.Porte != null)
                    Spectateurs.SAbonner(salle.Porte);
            }
            ApplaudissementsEvent?.Invoke(this, EventArgs.Empty);
            // Abonne spectateurs à TOUTES les portes AVANT
           
            Console.WriteLine("Les épreuves commencent!");
            System.Threading.Thread.Sleep(2000);
            // *****Une boucle qui appelle la méthode Epreuve de la salle dans le participant!
            foreach (var salle in salles)

            {// ici appel de la méthode selon le nom de la salle a traiter 
                Console.WriteLine();

                Console.WriteLine(" vers la " + salle.Nom);
                Console.WriteLine("_____________________________");
                Console.WriteLine();
                string methodeName = "Epreuve_" + salle.Nom;

                MethodInfo m = participant.GetType().GetMethod(methodeName);
                //m.Invoke(salle); 

                m.Invoke(participant, new object[] { salle }); 
                if  (salle?.Porte != null && salle.Porte.Debarree) 
                    {
                    Console.WriteLine($" {salle.Porte.GetType().Name} s ouvre ! ");
                    
                }
                else
                {
                    Console.WriteLine($" {salle.Nom} reste fermée");
                }

                System.Threading.Thread.Sleep(2000);
            }
            Console.WriteLine(" Fin des epreuves ");
        }

       
    }
}
