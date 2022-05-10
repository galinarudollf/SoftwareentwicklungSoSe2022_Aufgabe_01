using System;

namespace Aufgaben01
{
    class A2
    {
        static void Main(string[] args)
        {
            int jahr;
            string jahrstr=" ";
	          //bool ok=true;
            do{
                try
                {
                    Console.WriteLine("Jahr? ");
                    jahrstr=Console.ReadLine();
                    if (jahrstr.Length>0){
                        jahr = Int32.Parse(jahrstr);
                        //jahr = Int32.Parse(args[0]);
                        if (jahr%400==0)
                            Console.WriteLine(jahr +" ist ein Schaltjahr");
                            else if (jahr%100==0)
                                Console.WriteLine(jahr +" ist kein Schaltjahr");
                                else if (jahr%4==0)
                                    Console.WriteLine(jahr +" ist ein Schaltjahr");
                                    else Console.WriteLine(jahr +" ist kein Schaltjahr");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Falsches Format");
			              //ok=false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Überschreitung des Wertebereichs");
                }
                catch (Exception)
                {
                    Console.WriteLine("Fehler");
                }
           }while (jahrstr.Length>0);//jahrstr.Equals("");//==//ok
        }
    }
}
