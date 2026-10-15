using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
    public class Participant :IRepondreEpreuveSalles
    {
        public Salle? SalleCourante { get; set; } = null;
        public string Nom { get;  set; }
        public Participant( string Nom) 
        {
            this.Nom = Nom;
        }

        public void Epreuve_SalleDelegue(Salle salle)
        {
            //j'appelle les fct de la salle par execute grace à Hibou
            SalleDelegue sd = (SalleDelegue)salle;
            //Tu ne peux pas appeler directement salleDelegue.fct2(). Tu dois passer un délégué au Hibou qui l'exécutera pour toi :
            Action del = sd.fct1;
            Action del2 = sd.fct2;// cree delegue
            Func<string> del3 = sd.fct3;
            Action<string> del4 = sd.fct4;
            Func<string> del5 = sd.fct5;
            Func<string> del6 = sd.fct6;
            Func<int> del7 = sd.fct7;
            Func<int, string> del8 = sd.fct8;



            sd.Hibou.Executer(del);
            sd.Hibou.Executer(del2);// hibou execute fct2
            string morceau1 = sd.Hibou.Executer(del3);
            sd.Hibou.Executer(del4, morceau1);
            string morceau2 = sd.Hibou.Executer(del5);
            sd.Hibou.Executer(del4, morceau2);
            string morceau3 = sd.Hibou.Executer(del6);
            sd.Hibou.Executer(del4, morceau3);
            int nombre = sd.Hibou.Executer(del7);
            string phrase = sd.Hibou.Executer(del8, nombre);

            PorteDelegue porte = (PorteDelegue)sd.Porte;
            porte.Debarrer(phrase);

        }
       
        public void Epreuve_SalleException(Salle salle)
        {
            SalleException se = (SalleException)salle;
            if (se == null) return;

            PorteException porte = (PorteException)se.Porte;

            foreach (string element in se.ListeElements)
            {
               

                try
                {
                    porte.Debarrer(element);
                }
                catch (FormatException)
                {
                    Console.WriteLine(" est une lettre donc ne debarre pas");  // "E", "A", "HAHA"
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($" {ex.ParamName}");  // "troppetit" ou "tropgrand"
                }
                catch (AccessViolationException)
                {
                   
                    if (porte.Debarree)
                    {
                        Console.WriteLine(" Porte ouverte avec succès!");
                        return;
                    }
                }
                Console.Write($"Test: la valeur '{element}'");
            }

            Console.WriteLine(" Échec: aucune valeur n'a ouvert la porte.");
        }


        public void Epreuve_SalleTest(Salle salle) 
        {
            
        }

      
    }
}
