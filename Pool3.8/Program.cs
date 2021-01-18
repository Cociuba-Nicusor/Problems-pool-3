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
                Console.Write("Introduceti lungimea vectorului: ");
                n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                Console.WriteLine();
                Console.Write("Vector initial: ");
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(10);
                    v[i] = x;
                    Console.Write($"{v[i]} ");
                }
                int y = v[0];
                for (int i = 1; i < n; i++)
                {
                    v[i - 1] = v[i];
                }
                v[n - 1] = y;

                Console.WriteLine();
                Console.Write("Vector final: ");
                for (int i = 0; i < n; i++)
                    Console.Write($"{v[i]} ");
                Console.ReadKey();
            }
        }
    }
}
