using System;
using System.Globalization;

namespace Aufgaben01
{
    class A3
    {
        static void Main(string[] args)
        {
            double x, y, a, e, s;
            try
            {
                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = a;
                while (x<=e)
                {
                    if (Math.Abs((x - 1) *(x - 1)* (x + 2)) < Double.Epsilon)//<=Double.Epsilon/2
                    //if (Math.Abs((x - 1) *(x - 1)* (x + 2)).Equals(0))
                    //if (Math.Abs((x - 1) *(x - 1)* (x + 2)) == 0)
                    {
                        Console.WriteLine("{0,10} Polstelle", x.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        y = (3 * x - 6) / (x - 1) / (x - 1)/ (x + 2);
                        //Console.WriteLine("{0,10:F2}{1,10:F2}", x, y);
                        Console.WriteLine("{0,10}{1,10}",  //{3,10}
                            x.ToString("F2", CultureInfo.InvariantCulture),
                            y.ToString("F2", CultureInfo.InvariantCulture)); 
                    }
                    x = x + s;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Falsches Format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Überschreitung des Wertebereichs");
            }
            catch (Exception)
            {
                Console.WriteLine("Fehler");
            }

        }
    }
}
