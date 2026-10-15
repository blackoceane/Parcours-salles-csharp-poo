using Salle_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Final
{
   
   public class PorteException : Porte
   {
       private int code = 11;

      public override void Debarrer(string snd)

      {
            Notify();
            int nbi;
        if (Int32.TryParse(snd, out nbi))
        {
          if (nbi > code)
          {
                    throw new ArgumentOutOfRangeException("tropgrand");
          }
          if (nbi < code)
          {
                    throw new ArgumentOutOfRangeException("troppetit");
          }
          if (nbi == code)
          {
                    Console.WriteLine("");
                    Console.WriteLine("oh oh oh ...");
                    Debarree = true;
                    throw new AccessViolationException();
          }
        }
        else
          {
                throw new FormatException();
            }
        }
       
    }

    
}
