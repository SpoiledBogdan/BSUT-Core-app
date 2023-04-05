using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp
{
    [Serializable]
    public class Quadripole
    {
        public string A;
        public string B;
        public string C;
        public string D;

        public Quadripole()
        {
            A = "";
            B = "";
            C = "";
            D = "";
        }

        public Quadripole(string a, string b, string c, string d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
    }
}
