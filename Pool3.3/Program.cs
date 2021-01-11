using System;

namespace Pool3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i;
            Console.Write("Introduceti lungimea nvectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for ( i = 0; i < n; i++)
            {
               a[i] = int.Parse(Console.ReadLine());
            }
                int poz1 = 0;
                int min = a[0];
                int max = a[0];
                int poz2 = 0;
                for ( i = 0; i < n; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                        poz1 = i;
                    }
                    if (a[i] > max)
                    {
                        max = a[i];
                        poz2 = i;
                    }
                }
            Console.WriteLine($"Minimul se afla pe pozitia {poz1} \n Maximul se afla pe pozitia {poz2}");
            Console.ReadKey();
        }
    }
}
