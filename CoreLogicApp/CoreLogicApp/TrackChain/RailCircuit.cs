using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLogicApp.Units;

namespace CoreLogicApp.TrackChain
{
    internal class RailCircuit
    {
        public FeedingEnd FeedingEnd { get; set; }
        public RailLine RailLine { get; set; }

        public RelayEnd RelayEnd { get; set; }

        public RailCircuit()
        {
            FeedingEnd = new FeedingEnd();
            RailLine = new RailLine();
            RelayEnd = new RelayEnd();
        }

        public RailCircuit(FeedingEnd feedingEnd, RailLine railLine, RelayEnd relayEnd)
        {
            FeedingEnd = feedingEnd;
            RailLine = railLine;
            RelayEnd = relayEnd;
        }
    }
}