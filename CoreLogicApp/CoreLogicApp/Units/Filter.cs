using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp.Units
{
    [Serializable]
    public class Filter : Quadripole
    {
        public int inclusion_type;
        public double carrier_frequency;
        public double modulation_frequency;
        public int filter_type;

        public Filter() 
        {
            inclusion_type = 0;
            carrier_frequency = 0.0;
            modulation_frequency = 0.0;
            filter_type = 0;
        }

        public Filter(int inclusion_type, double carrier_frequency, double modulation_frequency, int filter_type)
        {
            this.inclusion_type = inclusion_type;
            this.carrier_frequency = carrier_frequency;
            this.modulation_frequency = modulation_frequency;
            this.filter_type = filter_type;
        }

        public void SetValues()
        {
            Console.WriteLine("Введите тип включения: ");
            inclusion_type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите несущую частоту: ");
            carrier_frequency = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите частоту модуляции: ");
            modulation_frequency = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите тип фильтра: ");
            filter_type = Convert.ToInt32(Console.ReadLine());
        }
    }
}
