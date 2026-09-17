using System;

namespace Liczby_pierwsze
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0) 
            {
                int liczba = int.Parse(Console.ReadLine());
                bool czyLiczbaP = true;
                if (liczba == 0 || liczba == 1) czyLiczbaP = false;
                else
                {
                    for (int i = 2; i < liczba; i++)
                    {
                        if (liczba % i == 0)
                        {
                            czyLiczbaP = false;
                            break;
                        }
                    }
                }
                if (czyLiczbaP) Console.WriteLine("TAK");
                else Console.WriteLine("NIE");
            }
        }
    }
}
