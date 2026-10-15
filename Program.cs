using System;

namespace Salle_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OHEY OHEY CE SOIR AU GRAND HALL");
            Console.WriteLine("2 SALLES D EPREUVES :  LA SALLE DELEGUE ET LA SALLE EXCEPTION ");
            Console.WriteLine("AVEC LEUR PORTE POLYMORPHE ET DES EVENTS CACHÉS  ");

            HallEntree hall = new HallEntree();
            // 2. Créer un Participant
            Participant participant = new Participant("Alice");
            Spectateurs spectateurs = new Spectateurs();
            hall.ApplaudissementsEvent += spectateurs.Applaudissement;
            // 3. Faire entrer le Participant dans le Hall
            hall.EntreeParticipant(participant);
            
        }
    }
}
