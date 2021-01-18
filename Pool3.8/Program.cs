using System;

namespace Pool3._8
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Rotire. Se da un vector cu n elemente. 
            //Rotiti elementele vectorului cu o pozitie spre stanga. 
            //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
          
            {
                int n;
                Console.Write("Lungime vector: ");
                n = int.Parse(Console.ReadLine());

                int[] vec = new int[n];
                Console.WriteLine();
                Console.Write("Vector initial: ");
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(10);
                    vec[i] = x;
                    Console.Write($"{vec[i]} ");
                }
                int y = vec[0];
                for (int i = 1; i < n; i++)
                {
                    vec[i - 1] = vec[i];
                }
                vec[n - 1] = y;

                Console.WriteLine();
                Console.Write("Vector final: ");
                for (int i = 0; i < n; i++)
                    Console.Write($"{vec[i]} ");
            }
        }
    }
}
