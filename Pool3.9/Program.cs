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
            Console.Write("Lungimea vector: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Numar de rotiri: ");
            k = int.Parse(Console.ReadLine());

            int[] vec = new int[n];
            Console.WriteLine();
            Console.Write("Vector initial: ");
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                vec[i] = x;
                Console.Write($"{vec[i]} ");
            }

            for (int j = 0; j < k; j++)
            {
                int y = vec[0];
                for (int i = 1; i < n; i++)
                {
                    vec[i - 1] = vec[i];
                }
                vec[n - 1] = y;
            }
            Console.WriteLine();
            Console.Write("Vector final: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{vec[i]} ");

        }
    }
}
