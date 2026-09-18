using System;

namespace czy_umiesz_potegowac
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                string[] liczby = Console.ReadLine().Split();

                int liczba1 = int.Parse(liczby[0]);
                int liczba2 = int.Parse(liczby[1]);

                if (liczba2 == 0) Console.WriteLine(1);
                else
                {
                    liczba1 = liczba1 % 10;

                    int l = liczba2 % 4;
                    if (l == 0) l = 4;
                    Console.WriteLine((int)Math.Pow(liczba1, l) % 10);
                }
            }
        }
    }
}
