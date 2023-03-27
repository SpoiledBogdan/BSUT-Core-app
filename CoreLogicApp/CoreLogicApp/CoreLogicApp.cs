using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicApp
{
    internal class CoreLogicApp
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Введите количество рельсовых цепей: ");
            int count = Convert.ToInt32(Console.ReadLine());

            RK[] RKs = new RK[count];
            //RL[] RLs = new RL[count];
            //PK[] PKs = new PK[count];

            while (i < count)
            {
                RKs[i] = new RK();
                Console.WriteLine($"Введите для {i+1}-го РК параметр: ");
                RKs[i].ParameterRK = int.Parse(Console.ReadLine());

                i++;
            }

            Console.WriteLine($"Значение параметра РК 3 равно {RKs[2].ParameterRK}");
        }
    }
}
