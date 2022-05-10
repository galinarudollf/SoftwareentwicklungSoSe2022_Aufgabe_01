using System;
using System.Globalization;

namespace Aufgaben01
{
    class A7
    {
        static void Main(string[] args)
        {
            string[] namen = new string[]{"Röiseland", "Elvira Öberg", "Hauser",  "Hanna Öberg",
                "Chevalier-Bouchet", "Herrmann", "Alimbekava", "Braisaz-Bouchet", "Wierer", "Davidova" };
            int index=0;
            Console.WriteLine("Platzierung | Name");           
            Console.WriteLine("--- | ---------------------------");
            foreach (string s in namen) Console.WriteLine($"{index++} | {s}");
            do   
            {
                try
                {
                    index = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(namen[index]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatFehler");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index nicht vorhanden");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (index >= 0);
        }
    }
}
