using System;


namespace Dwie_cyfy_silni
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int liczba = int.Parse(Console.ReadLine());
                if (liczba >= 10) Console.WriteLine("0 0");
                else
                {
                    int silnia = 1;
                    for (int i = 1; i <= liczba; i++)
                    {
                        silnia *= i;
                    }
                    Console.WriteLine($"{(silnia / 10) % 10} {silnia % 10}");
                }
            }
        }
    }
}
