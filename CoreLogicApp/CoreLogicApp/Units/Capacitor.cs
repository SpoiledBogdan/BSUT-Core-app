using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp.Units
{
    [Serializable]
    public class Capacitor : Quadripole
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

        public void SetValues()
        {
            Console.WriteLine("Введите тип подключения: ");
            connection_type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите емкость: ");
            capacity = Convert.ToDouble(Console.ReadLine());
        }
    }
}
