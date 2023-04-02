using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp.Units
{
    internal class Cable : Quadripole
    {
        public double length;
        public int cable_type;
        public int cable_brand;

        public Cable() 
        {
            length = 0.0;
            cable_type = 0;
            cable_brand = 0;
        }

        public Cable(double length, int cable_type, int cable_brand)
        {
            this.length = length;
            this.cable_type = cable_type;
            this.cable_brand = cable_brand;
        }
        public void SetValues() 
        {
            Console.WriteLine("Введите длину кабеля: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите тип кабеля: ");
            cable_type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите марку кабеля: ");
            cable_brand = Convert.ToInt32(Console.ReadLine());
        }
    }
}
