using System;

namespace Pool3._7
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Reverse. Se da un vector nu n elemente. 
            //Se cere sa se inverseze ordinea elementelor din vector. 
            //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
            int n;
            Console.Write("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] v1 = new int[n];
            Console.WriteLine();
            Console.Write("Vector initial: ");
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                v[i] = x;
                Console.Write($"{v[i]} ");

            }

            int c = 1;
            for (int i = 0; i < n; i++)
            {

                v1[i] = v[n - c];
                c++;
            }
            Console.WriteLine();
            Console.Write("Vector final: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v1[i]} ");

            }
            Console.ReadKey();
        }
    }
}
