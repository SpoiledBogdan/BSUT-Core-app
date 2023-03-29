using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp
{
    internal class RelayEnd : Entity
    {
        private int parameterRelayEnd;
        public RelayEnd(int parameterRelayEnd)
        {
            this.parameterRelayEnd = parameterRelayEnd;
        }

        public RelayEnd()
        {
            this.parameterRelayEnd = 0;
        }

        public int ParameterRelayEnd
        {
            get { return parameterRelayEnd; }
            set { parameterRelayEnd = value; }
        }
    }
}
