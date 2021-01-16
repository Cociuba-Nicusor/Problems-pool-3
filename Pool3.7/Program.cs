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
            Console.Write("Lungime vector: ");
            n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            int[] vec2 = new int[n];
            Console.WriteLine();
            Console.Write("Vector initial: ");
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                vec[i] = x;
                Console.Write($"{vec[i]} ");

            }

            int c = 1;
            for (int i = 0; i < n; i++)
            {

                vec2[i] = vec[n - c];
                c++;
            }
            Console.WriteLine();
            Console.Write("Vector final: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{vec2[i]} ");

            }
            Console.ReadKey();
        }
    }
}
