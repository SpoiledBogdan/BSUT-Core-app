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

            RelayEnd[] RKs = new RelayEnd[count];
            //RL[] RLs = new RL[count];
            //PK[] PKs = new PK[count];

            while (i < count)
            {
                RKs[i] = new RelayEnd();
                Console.WriteLine($"Введите для {i+1}-го РК параметр: ");
                RKs[i].ParameterRelayEnd = int.Parse(Console.ReadLine());

                i++;
            }

            Console.WriteLine($"Значение параметра РК 3 равно {RKs[2].ParameterRelayEnd}");
        }

        private void structcore() // структура программы
        {
          
        }
        private struct RailCircuit
        {
            private int quantityEnds;
            private Ends[] ends;
            private RailLine[] railLines;
        }
    }
}
