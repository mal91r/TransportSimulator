using System;
using System.IO;
using EKRLib;

namespace PeerGrade6
{
    internal class Program
    {
        /// <summary>
        /// Статический экземпляр класса Random.
        /// Вызывается из разных классов программы.
        /// </summary>
        static public Random rand = new Random();

        /// <summary>
        /// Точка входа в программу.
        /// В методе создается массив типа Transport, 
        /// заполняется случайно сгенерированными объектами,
        /// а затем происходит запись в файлы.
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            int transportCount = rand.Next(6, 10);
            Transport[] transports = new Transport[transportCount];
            Generator generator = new Generator();
            for (int i = 0; i < transportCount; i++)
            {
                transports[i] = generator.Generation();
                Console.WriteLine(transports[i].StartEngine());
            }

            using (StreamWriter carWriter = new StreamWriter(@"..\..\..\..\Cars.txt", false, System.Text.Encoding.Unicode))
            {
                using (StreamWriter boatWriter = new StreamWriter(@"..\..\..\..\MotorBoats.txt", false, System.Text.Encoding.Unicode))
                {
                    foreach (var transport in transports)
                    {
                        if (transport is Car)
                        {
                            carWriter.WriteLine(transport);
                        }
                        if (transport is MotorBoat)
                        {
                            boatWriter.WriteLine(transport);
                        }
                    }
                }
            }
        }
    }
}
