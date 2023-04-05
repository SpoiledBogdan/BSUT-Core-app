using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp.Units
{
    [Serializable]
    public class Resistor : Quadripole
    {
        public int connection_type;
        public double resistance;

        public Resistor()
        {
            connection_type = 0;
            resistance = 0.0;
        }

        public Resistor(int connection_type, double resistance)
        {
            this.connection_type = connection_type;
            this.resistance = resistance;
        }

        public void SetValues()
        {
            Console.WriteLine("Введите тип подключения: ");
            connection_type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сопротивление: ");
            resistance = Convert.ToDouble(Console.ReadLine());
        }
    }
}
