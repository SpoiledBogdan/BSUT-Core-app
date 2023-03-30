using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp.Units
{
    internal class Capacitor : Quadripole
    {
        public int connection_type;
        public double capacity;

        public Capacitor() 
        {
            connection_type = 0;
            capacity = 0.0;

        }

        public Capacitor(int connection_type, double capacity)
        {
            this.connection_type = connection_type;
            this.capacity = capacity;
        }
    }
}
