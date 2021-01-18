using System;

namespace Pool3._9
{
    class Program
    {
        //Rotire k. Se da un vector cu n elemente. 
        //Rotiti elementele vectorului cu k pozitii spre stanga. 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Numar de rotiri: ");
            k = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine();
            Console.Write("Vector initial: ");
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                a [i] = x;
                Console.Write($"{a[i]} ");
            }

            for (int j = 0; j < k; j++)
            {
                int y = a[0];
                for (int i = 1; i < n; i++)
                {
                    a[i - 1] = a[i];
                }
                a[n - 1] = y;
            }
            Console.WriteLine();
            Console.Write("Vector final: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{a[i]} ");
            Console.ReadKey();
        }
    }
}
