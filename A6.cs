using System;
using System.Globalization;

namespace Aufgaben01
{
    class A6
    {
        static void Main(string[] args)
        {
            double[] insel1 = new double[]{ 1.1, 20.3, 3, 4, 4, 6.6, 7, 8, 10, 5.5 },
                     insel2 = { 1.9, 2, 3.0, 4, 4, 10, 7, 8, 10.1, 7 };
            double max =0;
            string smax = "beide";
            for (int i=0;i<insel1.Length;i++)
            {

                Console.WriteLine("{0} {1}", insel1[i].ToString(CultureInfo.InvariantCulture), insel2[i].ToString(CultureInfo.InvariantCulture));
                if (insel1[i] > insel2[i])
                {
                    Console.WriteLine("St. Kitts und Nevis");
                    if (insel1[i] > max)
                    {
                        max = insel1[i];
                        smax = "St. Kitts und Nevis";
                    }
                }
                else 
                {
                    if (insel2[i] > insel1[i])
                    {
                        Console.WriteLine("Niue");
                        if (insel2[i] > max)
                        {
                            max = insel2[i];
                            smax = "Niue";
                        }
                    }
                    else  Console.WriteLine("beide gleich"); 
                }
            }
            Console.WriteLine(smax+" "+max.ToString(CultureInfo.InvariantCulture));
        }
    }
}
//double maxValue = (skan.Max()>=niue.Max()) ? skan.Max() : niue.Max();
