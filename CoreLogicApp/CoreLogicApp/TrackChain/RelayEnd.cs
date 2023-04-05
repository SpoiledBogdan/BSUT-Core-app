using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLogicApp.Units;


namespace CoreLogicApp.TrackChain
{
    [Serializable]
    public class RelayEnd : Entity
    {
        public Cable Cable { get; set; }

        public Capacitor Capacitor { get; set; }

        public Filter Filter { get; set; }

        public Resistor Resistor { get; set; }

        public Transformer Transformer { get; set; }

        public RelayEnd()
        {
            Cable = new Cable();
            Capacitor = new Capacitor();
            Filter = new Filter();
            Resistor = new Resistor();
            Transformer = new Transformer();
        }

        public RelayEnd(Cable cable, Capacitor capacitor, Filter filter, Resistor resistor, Transformer transformer)
        {
            Cable = cable;
            Capacitor = capacitor;
            Filter = filter;
            Resistor = resistor;
            Transformer = transformer;
        }
    }
}
