using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp.Units
{
    internal class Transformer : Quadripole
    {
        public int transformer_type;
        public double transformation_ratio;
        public double frequency;
        public bool is_throttle;

        public Transformer()
        {
            transformer_type = 0;
            transformation_ratio = 0.0;
            frequency = 0.0;
            is_throttle = false;
        }

        public Transformer(int transformer_type, double transformation_ratio, double frequency, bool is_throttle)
        {
            this.transformer_type = transformer_type;
            this.transformation_ratio = transformation_ratio;
            this.frequency = frequency;
            this.is_throttle = is_throttle;
        }
    }
}
