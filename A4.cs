namespace Aufgaben01
{
    class A4
    {
       static void funktion(double[] d,int anz,out double m_hasel,out double m_wal,out int anz_hasel,out int anz_wal)
        {
            m_hasel = 0; m_wal = 0;
            anz_hasel = 0; anz_wal = 0;
            for (int i=0;i<anz;i++)
            {
                if (d[i] < 2)
                {
                    m_hasel += d[i]; anz_hasel++;
                }
                else
                {
                    m_wal += d[i]; anz_wal++;
                }
            }
            m_hasel = Math.PI * Math.Pow(m_hasel/anz_hasel, 3)/6;
            m_wal = Math.PI * Math.Pow(m_wal/anz_wal, 3)/6;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] d;
            int anz = random.Next(20, 100);
            d = new double[anz];
            for (int i = 0; i < anz; i++)
            {
                d[i]=random.Next(75, 400) / 100.0;
                //Console.WriteLine(d[i] + " ");
            }
            double m_hasel = 0, m_wal = 0;
            int anz_hasel = 0, anz_wal = 0;
            funktion(d, anz, out m_hasel, out m_wal, out anz_hasel, out anz_wal);
            Console.WriteLine(anz_hasel + " " + m_hasel.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(anz_wal + " " + m_wal.ToString(CultureInfo.InvariantCulture));

        }
    }
}

//int param <- value parameter
//ref int param <- ref parameter, muss vor der Übergabe initializiert werden
//out int param <- nur ausgabe parameter, muss nicht initialisiert werden
