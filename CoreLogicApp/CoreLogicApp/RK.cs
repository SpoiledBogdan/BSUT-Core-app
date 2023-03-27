using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp
{
    internal class RK : Entity
    {
        private int parameterRK;
        public RK(int parameterRK)
        {
            this.parameterRK = parameterRK;
        }

        public RK()
        {
            this.parameterRK = 0;
        }

        public int ParameterRK
        {
            get { return parameterRK; }
            set { parameterRK = value; }
        }
    }
}
