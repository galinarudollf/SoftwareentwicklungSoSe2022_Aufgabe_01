using System;
using System.Globalization;

namespace Aufgaben01
{
    class A5
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int wurf;
            int summe=0;

            for (int i = 0; i < 1000; i++)
            {
                wurf = random.Next(1, 7)+random.Next(1, 7)+random.Next(1, 7);

                switch (wurf)
                {
                    case 16: summe+=5; break;
                    case 17: summe+=10; break;
                    case 18: summe+=100; break;
                }
            }
            Console.WriteLine($"{summe}-{1000}={summe-1000}");

        }
    }
}
