using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Salle_Final
{
    public class Hibou
    {
        //        Void Executer(Action d)
        //o {d? Invoke();
        //    }
        //    ou {if (d!=null){d();
        //}} 
        public void Executer(Action d)
        {
            if (d != null) d();
        }

        public string Executer(Func<string> d)
        {
            return d != null ? d() : string.Empty;
        }

        public int Executer(Func<int> d)
        {
            return d != null ? d() : 0;
        }

        public string Executer(Func<int, string> d, int a)
        {
            return d != null ? d(a) : string.Empty;
        }

        public void Executer(Action<string> d, string s)
        {
            if (d != null) d(s);
        }
    }

    
}
