using System;

namespace Aufgaben01
{
    enum Tarife{S,M,L};
    class A1
    {
        static void Main(string[] args)
        {

            int minuten;
            double gebühr;
            //char tarif;
            Tarife tarif;
            try
            {
                //minuten = Int32.Parse(Console.ReadLine());
                minuten = Int32.Parse(args[0]);
                if (minuten <= 100)
                    gebühr = 3.99;
                else gebühr = 3.99 + (minuten - 100) * 9.9/100;
                //b
                //tarif = Char.Parse(Console.ReadLine());
                //tarif = Char.Parse(args[1]);
                tarif=Enum.Parse<Tarife>(args[1]);
                switch(tarif)
                {
                    case Tarife.S: gebühr = gebühr + 5;break;//case 'S': gebühr = gebühr + 5;break;
                    case Tarife.M: gebühr = gebühr + 7; break;//case 'M': gebühr = gebühr + 7; break;
                    case Tarife.L: gebühr = gebühr + 10; break;//case 'L': gebühr = gebühr + 10; break;
                }
                    Console.WriteLine(minuten+" "+tarif+" "+gebühr.ToString("F2"));
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
