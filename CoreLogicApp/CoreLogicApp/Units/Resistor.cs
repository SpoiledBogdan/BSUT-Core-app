using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp.Units
{
    internal class Resistor : Quadripole
    {
        public int connection_type;
        public double resistance;

        public Resistor()
        {
            connection_type = 0;
            resistance = 0.0;
        }
    }
}
