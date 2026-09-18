using System;
using System.IO;

namespace pomiar_predkosci
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            string line = reader.ReadLine();
            if (string.IsNullOrWhiteSpace(line)) return;

            int t = int.Parse(line.Trim());

            const int MAX_SUMA = 10000;

            while (t-- > 0)
            {
                int liczba_p = int.Parse(reader.ReadLine().Trim());

                bool[] mozliwe = new bool[2 * MAX_SUMA + 1];
                mozliwe[MAX_SUMA] = true;

                int max_p = 0;

                for (int i = 0; i < liczba_p; i++)
                {
                    int p = int.Parse(reader.ReadLine().Trim());
                    max_p += p;

                    bool[] nowe = new bool[2 * MAX_SUMA + 1];

                    int limit = max_p - p;
                    for (int v = -limit; v <= limit; v++)
                    {
                        if (mozliwe[v + MAX_SUMA])
                        {
                            nowe[v + p + MAX_SUMA] = true;
                            nowe[v - p + MAX_SUMA] = true;
                        }
                    }

                    mozliwe = nowe;
                }

                int min_p = int.MaxValue;
                for (int v = -max_p; v <= max_p; v++)
                {
                    if (mozliwe[v + MAX_SUMA])
                    {
                        int absV = Math.Abs(v);
                        if (absV < min_p)
                        {
                            min_p = absV;
                            if (min_p == 0) break; 
                        }
                    }
                }

                Console.WriteLine($"{min_p} {max_p}");
            }
        }
    }
}
