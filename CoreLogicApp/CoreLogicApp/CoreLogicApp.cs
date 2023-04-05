using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using CoreLogicApp.Units;
using CoreLogicApp.TrackChain;
using System.Runtime.Serialization.Formatters.Binary;


int i = 0;

Console.WriteLine("Приложение для расчета тунелирования рельсовых цепей.");

static void SaveBinaryFormat(object objGraph, string fileName)
{
    BinaryFormatter binFormat = new BinaryFormatter();
    try {
        using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            binFormat.Serialize(fStream, objGraph);
        }
        Console.WriteLine("--> Сохранение объекта в Binary format");
    }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
 }

while (i != 1)
{
    Console.WriteLine("Выберите нужный пункт" +
        "\n1. Выйти из программы" +
        "\n2. Создать рельсовую цепь" +
        "\n3. Сохранить рельсовую цепь" +
        "\n4. Загрузить рельсовую цепь\n");

    i = Convert.ToInt32(Console.ReadLine());

    switch (i)
    {
        case 1:
            Environment.Exit(0);
            break;
        case 2:
            RailCircuit railCircuit = new RailCircuit();
            int block = 0;
            while (block != 3)
            {
                Console.WriteLine("Выберите, для какого блока вводить значения:" +
                    "\n1. Питающий конец" +
                    "\n2. Релейный конец" +
                    "\n3. Закончить ввод\n");

                block = Convert.ToInt32(Console.ReadLine());

                bool isFeedingEndCreated = false;
                bool isRelayEndCreated = false;

                if (block == 1 && isFeedingEndCreated == false)
                {
                    isFeedingEndCreated = true;

                    Console.WriteLine("КАБЕЛЬ\n");
                    railCircuit.FeedingEnd.Cable.SetValues();

                    Console.WriteLine("КОНДЕНСАТОР\n");
                    railCircuit.FeedingEnd.Capacitor.SetValues();

                    Console.WriteLine("ФИЛЬТР\n");
                    railCircuit.FeedingEnd.Filter.SetValues();

                    Console.WriteLine("РЕЗИСТОР\n");
                    railCircuit.FeedingEnd.Resistor.SetValues();

                    Console.WriteLine("ТРАНСФОРМАТОР\n");
                    railCircuit.FeedingEnd.Transformer.SetValues();
                }

                else if (block == 2 && isRelayEndCreated == false)
                {
                    isRelayEndCreated = true;

                    Console.WriteLine("КАБЕЛЬ\n");
                    railCircuit.RelayEnd.Cable.SetValues();

                    Console.WriteLine("КОНДЕНСАТОР\n");
                    railCircuit.RelayEnd.Capacitor.SetValues();

                    Console.WriteLine("ФИЛЬТР\n");
                    railCircuit.RelayEnd.Filter.SetValues();

                    Console.WriteLine("РЕЗИСТОР\n");
                    railCircuit.RelayEnd.Resistor.SetValues();

                    Console.WriteLine("ТРАНСФОРМАТОР\n");
                    railCircuit.RelayEnd.Transformer.SetValues();
                }
            }
            SaveBinaryFormat(railCircuit, "railCircuit.dat");
            break;
        case (4):
            try
            {
                using (FileStream fs = new FileStream("railCircuit.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    RailCircuit railCircuit1 = (RailCircuit)binFormat.Deserialize(fs);
                    Console.WriteLine("файл загружен");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            break;
    }
    i++;
}
